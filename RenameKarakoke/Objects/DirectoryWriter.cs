using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

namespace RenameKarakoke.Objects
{
    class DirectoryWriter
    {
        private bool _isCompressed { get; set; }
   
        private readonly DataSet _dataSet;
 
        public DirectoryWriter(bool isCompressed, DataSet dataSet)
        {
            _isCompressed = isCompressed;
            _dataSet = dataSet;
        }

        public int RenameFilesInDirectory(string sourceDir, List<Song> selectedSongList)
        {
            var count = 0;
            string newFileName;
            if (sourceDir != null)
            {
                foreach (var song in selectedSongList)
                {
                    var correctSongInfo = FindCorrectSongInfo(song);
                    if (correctSongInfo != null)
                    {
                        var oldFileName = FormatFileName(sourceDir, song);
                        if (HasDuplicate(song, correctSongInfo))
                        {
                            ReplaceDuplicateSongID(song, correctSongInfo);
                        }
                        newFileName = FormatFileName(sourceDir, correctSongInfo);

                        //If File.Exists No Need To Rename
                        if (File.Exists(newFileName)) continue;


                        File.Copy(oldFileName, newFileName);
                        File.Delete(oldFileName);
                        count++;
                    }
                }
            }
            return count;
        }

        public string FormatFileName(string sourceDir, Song song)
        {
            var fileName = sourceDir + "\\" + song.ID + " - " + song.Artist + " - " + song.Title;
            if (_isCompressed)
            {
                AddZipExtension(fileName);
            }
            
            return fileName;
        }

        private bool HasDuplicate(Song oldSong, Song newSong)
        {
            return oldSong.Artist == newSong.Artist;
        }

        private void ReplaceDuplicateSongID(Song oldSongInfo, Song newSongInfo)
        {
            
            newSongInfo.Artist = oldSongInfo.Artist;
            newSongInfo.Title = oldSongInfo.Title;
        }
        public string GetDirectorySavePath()
        {
            string savePath = null;
            DialogResult result;
            var folderBrowserDialog = new FolderBrowserDialog()
            {
                Description = "Please Select A Destination to Save Renamed Files",
                ShowNewFolderButton = true

            };
            result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                savePath = folderBrowserDialog.SelectedPath;
            }

            return savePath;

        }
        public Song FindCorrectSongInfo(Song oldSong)
        {
            return _dataSet.MasterSongList.FirstOrDefault(s => s.Title == oldSong.Title);
        }

        public void AddZipExtension(string fileName)
        {
               fileName += ".zip";         
        }
        public void DirectoryCopy(string sourceDirectoryPath, string destDirectoryPath)
        {
            if (destDirectoryPath != null)
            {
                var directoryInfo = new DirectoryInfo(sourceDirectoryPath);
                FileInfo[] files = directoryInfo.GetFiles();
                foreach (FileInfo file in files)
                {
                    //Change All .Zip to .zip
                    var fileExtension = GetFileExtension(file);
                    var newFileName = file.Name.Replace(fileExtension, ".zip");
                    var newDestPath = Path.Combine(destDirectoryPath, newFileName);
                    file.CopyTo(newDestPath, false);
                }
            }

        }
        private void CreateNewFolder(string folderName)
        {

            Directory.CreateDirectory(folderName);

        }
        public void UnzipFiles(string sourceDirPath)
        {
            var directoryInfo = new DirectoryInfo(sourceDirPath);
            FileInfo[] files = directoryInfo.GetFiles();
            foreach (FileInfo file in files)
            {
                var sourceFilePath = sourceDirPath + "\\" + file.Name;
                var destFilePath = sourceDirPath + "\\" + Path.GetFileNameWithoutExtension(file.Name);
                try
                {
                    CreateNewFolder(destFilePath);
                   
                    ZipFile.ExtractToDirectory(sourceFilePath, destFilePath);
                    File.Delete(sourceFilePath);
                }
                catch (InvalidDataException)
                {
                    var corruptFileName = ReplaceCorruptedFileName(sourceFilePath);
                    File.Copy(sourceFilePath, corruptFileName);
                    File.Delete(sourceFilePath);
                }
            }
        }
        private string GetFileExtension(FileInfo fileInfo)
        {
            var fileExtension = fileInfo.Name.Substring(fileInfo.Name.IndexOf('.'));
            return fileExtension;
        }

        private string ReplaceCorruptedFileName(string sourceFilePath)
        {
            var corruptFileName = sourceFilePath.Substring(sourceFilePath.IndexOf(".zip")) + "---Corrupt.zip";
            return corruptFileName;

        }

        private void RenameFolderContents(string sourceZipPath, string fileName)
        {
            
        }




       

    }
}

