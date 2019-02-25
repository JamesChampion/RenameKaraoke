using System.IO;
using System.IO.Compression;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;

namespace RenameKarakoke.Objects
{
    class DirectoryWriter
    {
        private bool _unzipFiles;
        private IReader _directoryReader;
        private string _filePath;
        public DirectoryWriter(bool unzipFiles, IReader directoryReader)
        {
            _unzipFiles = unzipFiles;
            _directoryReader = directoryReader;
            _filePath = directoryReader.GetFilePath();
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
                try
                {
                    var extractPath = zipPath;
                    var folderName = zipPath + "\\" +  Path.GetFileNameWithoutExtension(file);
                    var oldFileName = zipPath + "\\" + Path.GetFileNameWithoutExtension(file) + ".zip";
                    CreateNewFolder(folderName);
                    ZipFile.ExtractToDirectory(oldFileName, folderName);
                  //File.Delete(zipPath);
                }
                catch (System.IO.InvalidDataException e)
                {

                    //A Few Files Are Corrupt.  Decide What to Do With The Corrupted Files. 
                    System.Console.WriteLine(e.Message);
                }
            }
        }
    }
}

