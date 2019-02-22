using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RenameKarakoke
{
    class DirectoryReader : IReader
    {
        public static string FilePath { get; set; }
        //public FolderBrowserDialog _folderBrowserDialog { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        //public OpenFileDialog _openFileDialog { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        //public DirectoryReader(FolderBrowserDialog folderBrowserDialog)
        //{
        //    _folderBrowserDialog = folderBrowserDialog;
        //    _openFileDialog = null;
        //}


        public void Read(string path)
        {

            var files = Directory.EnumerateFiles(path);
            FilePath = path;
            foreach (var file in files)
            {
                var fileName = Path.GetFileNameWithoutExtension(file);
                Song.songQueryList.Add(ParseSong(fileName));
            }
        }

        public Song ParseSong(string line)
        {
            //TODO: Catch Invalid Format And Allow User to Add them Manually

            var categories = Regex.Split(line, " - ");
            if (categories.Length < 3)
            {
                return new Song(categories[0], " INVALID FORMAT", " ");
            }
            else
            {

                var iD = categories[0];
                var artist = categories[1];
                var title = categories[2];
                return new Song(iD, artist, title);

            }

        }

        public void DirectoryCopy(string sourceDirName, string destName)
        {
            sourceDirName = FilePath;
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destName, file.Name);
                file.CopyTo(temppath, false);
            }

        }

        public string UnzipFile(string zipPath)
        {
            string extractPath = null;

            try
            {

                extractPath = zipPath.Substring(0, zipPath.IndexOf(Path.GetFileNameWithoutExtension(zipPath)));
                var folderName = extractPath + Path.GetFileNameWithoutExtension(zipPath);
                CreateNewFolder(folderName);
                ZipFile.ExtractToDirectory(zipPath, extractPath);
                File.Delete(zipPath);
            }
            catch (System.IO.InvalidDataException e)
            {

                //A Few Files Are Corrupt.  Decide What to Do With The Corrupted Files. 
                System.Console.WriteLine(e.Message);
            }
            return extractPath;
        }

        private void CreateNewFolder(string folderName)
        {
              
                var directory = Directory.CreateDirectory(folderName);
                        
        }

    }
}
