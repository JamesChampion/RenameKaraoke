using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace RenameKarakoke.Objects
{
    class DirectoryWriter
    {
        private bool _isCompressed;
        private IReader _directoryReader;
        private string _filePath;
        public DirectoryWriter(bool isCompressed, IReader directoryReader)
        {
            _isCompressed = isCompressed;
            _directoryReader = directoryReader;
            _filePath = directoryReader.GetFilePath();
        }

        public void RenameFilesInDirectory(string sourceDir, List<Song> selectedSongList)
        {
            var count = 0;
           string newFileName;
            foreach (var song in selectedSongList)
            {
                //FindCorrectSongInfo --DONE   -----If We Have To Extract, They Wont Have .Zip @ the End Of The FileName
                var correctSongInfo = FindCorrectSongInfo(song);
                if (correctSongInfo != null)
                {
                    var oldFileName = sourceDir + "\\" + song.ID + " - " + song.Artist + " - " + song.Title + ".zip";
                    if (correctSongInfo.Artist != song.Artist)
                    {
                        newFileName = sourceDir + "\\" + correctSongInfo.ID + " - " + song.Artist + " - " + correctSongInfo.Title + ".zip";

                    }
                    else
                    {
                        newFileName = sourceDi r + "\\" + correctSongInfo.ID + " - " + correctSongInfo.Artist + " - " + correctSongInfo.Title + ".zip";
                    }


                    //Old Song Info Has the correct FileName

                    if (!File.Exists(newFileName)) //If The File Exisits, its a Good Title
                    {
                        File.Copy(oldFileName, newFileName);
                        File.Delete(oldFileName);
                        //oldFileName += i++;
                    }
                }
                count++;
            }
        }

        public string FormatFileName(string sourceDir, Song oldSongInfo, Song correctSongInfo)
        {
            var oldFileName = AddExtension(sourceDir + "\\" + oldSongInfo.ID + " - " + oldSongInfo.Artist + " - " + oldSongInfo.Title);
            string correctFileName = "";
            if (correctSongInfo.Artist != oldSongInfo.Artist)
            {
                correctFileName = AddExtension(sourceDir + "\\" + correctSongInfo.ID + " - " + oldSongInfo.Artist + " - " + correctSongInfo.Title);

            }
            else
            {
                correctFileName = AddExtension(sourceDir + "\\" + correctSongInfo.ID + " - " + correctSongInfo.Artist + " - " + correctSongInfo.Title);
            }

            return correctFileName;
        }


        public string GetNewFilePath()
        {
            string newFilePath = null;
            DialogResult result;
            var folderBrowserDialog = new FolderBrowserDialog()
            {
                Description = "Please Select A Destination to Save Renamed Files",
                ShowNewFolderButton = true

            };
            result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                newFilePath = folderBrowserDialog.SelectedPath;
            }



            return newFilePath;

        }
        public Song FindCorrectSongInfo(Song oldSong)
        {

            foreach (Song songinfo in Song.songMasterList)
            {
                if (songinfo.Title == oldSong.Title)
                {
                    return songinfo;

                }
            }
            return null;



        }
        public string AddExtension(string fileName)
        {
            if (_isCompressed)
            {
                fileName += ".zip";
            }
            return fileName;
        }
        public void DirectoryCopy(string sourceDirName, string destName, bool isCompressed)
        {
            sourceDirName = _filePath;
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                //Change All .Zip to .Zip
                var fileExtension = file.Name.Substring(file.Name.IndexOf('.'));
                file.Name.Replace(fileExtension, ".zip");
                string temppath = Path.Combine(destName, file.Name);
                file.CopyTo(temppath, false);

            }
            if (isCompressed)
            {
                UnzipFiles(destName);
            }


        }
        private void CreateNewFolder(string folderName)
        {

            var directory = Directory.CreateDirectory(folderName);

        }
        public void UnzipFiles(string zipPath)
        {

            var files = Directory.GetFiles(zipPath);
            foreach (var file in files)
            {
                var folderName = zipPath + "\\" + Path.GetFileNameWithoutExtension(file);
                var oldFileName = zipPath + "\\" + Path.GetFileNameWithoutExtension(file) + ".zip";
                try
                {
                    CreateNewFolder(folderName);
                    ZipFile.ExtractToDirectory(oldFileName, folderName);
                    File.Delete(oldFileName);
                }
                catch (System.IO.InvalidDataException e)
                {
                    var corruptFileName = oldFileName.Substring(oldFileName.IndexOf(".zip")) + "---Corrupt.zip";
                    File.Copy(oldFileName, corruptFileName);
                    File.Delete(oldFileName);
                    //A Few Files Are Corrupt.  Decide What to Do With The Corrupted Files. Probably Should Rename With Flag
                    System.Console.WriteLine(e.Message);
                }
            }
        }
    }
}

