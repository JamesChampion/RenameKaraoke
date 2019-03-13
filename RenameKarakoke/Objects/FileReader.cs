using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;


namespace RenameKarakoke
{
   public class FileReader

    {
   
        private string _filePath { get; set; }
        public List<Song> Read(string path)
        {
            _filePath = path;
            var expression = new Regex("^KV");
            var lines = File.ReadLines(path);
            var songList = new List<Song>();
            foreach (var line in lines)
            {
                Match match = expression.Match(line);
                if (match.Success && !line.EndsWith("kmh"))
                {
                    var song = ParseSong((Path.GetFileNameWithoutExtension(line)));
                    if (song != null)
                    {
                        songList.Add(song);
                    }
                    else
                    {
                        ThrowInvalidSongException(_filePath, line);
                    }
                }
            }
            return songList;
   
        }

        //Parses File
        public Song ParseSong(string fileLine)
        {
            var categories = Regex.Split(fileLine, " - ");
            if(categories.Length != 3) {
                return null;
            }
            var iD = categories[0];
            var artist = categories[1];
            var title = categories[2];
            return new Song(iD, artist, title);
        }

        public string GetFilePath() => _filePath;


        public void ThrowInvalidSongException(string filePath, string invalidSongName)
        {
            StreamWriter streamWriter;
            var sourceDir = Path.GetDirectoryName(filePath);
            var textFileName = "InvalidSongNamesInMasterList.txt";
            string path = Path.Combine(sourceDir, "Invalid Song Names");
            var textFilePath = path + "\\" + textFileName;

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (!File.Exists(textFilePath))
            {
                streamWriter = new StreamWriter(textFilePath, false);
                streamWriter.WriteLine("Song Format in Master.Txt Should Be: {KVM ID} - {Artist} - {Title}.zip");
            }
            else
            {
                streamWriter = new StreamWriter(textFilePath, true);
            }
            streamWriter.WriteLine(invalidSongName);
            streamWriter.Close();
            streamWriter.Dispose();

        }



    }







}


