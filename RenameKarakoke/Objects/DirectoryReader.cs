using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace RenameKarakoke
{
   public class DirectoryReader
    {

        public List<Song> Read(string path)
        {
            var files = Directory.EnumerateFiles(path);
            var songList = new List<Song>();
            foreach (var file in files)
            {
                var fileName = Path.GetFileNameWithoutExtension(file);
                var song = ParseSong(fileName);
                if (song != null)
                {
                    songList.Add(song);
                }
                else
                {
                    ThrowUnsupportedFileName(file);
                }
            }
            return songList;
        }

        public Song ParseSong(string line)
        {
            var categories = Regex.Split(line, " - ");
            if (categories.Length != 3)
            {
                //Invalid Entry Return Null
                return null;
            }
            else
            {
                var iD = categories[0];
                var artist = categories[1];
                var title = categories[2];
                return new Song(iD, artist, title);
            }
        }



        public void ThrowUnsupportedFileName(string sourceFilePath)
        {
            //Create A Folder That Stores All Unsupported Files
            var currentDirectory = Path.GetDirectoryName(sourceFilePath);
            var targetDirectory = currentDirectory + "\\Unsupported Files";
            if (!Directory.Exists(targetDirectory)){
                Directory.CreateDirectory(targetDirectory);
            }

            var destFilePath = targetDirectory +"\\" + Path.GetFileName(sourceFilePath);
            File.Copy(sourceFilePath, destFilePath);
        }
    }
}
