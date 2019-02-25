using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;


namespace RenameKarakoke
{
    class FileReader : IReader

    {
   
        private string _filePath { get; set; }
        public void Read(string path)
        {
            _filePath = path;
            var expression = new Regex("^KV");
            var lines = File.ReadLines(path);
            foreach (var line in lines)
            {
                Match match = expression.Match(line);
                if (match.Success && !line.EndsWith("kmh"))
                {

                    Song.songMasterList.Add(ParseSong((Path.GetFileNameWithoutExtension(line))));
                }
            }
   
        }

        //Parses File
        public Song ParseSong(string fileLine)
        {
            var categories = Regex.Split(fileLine, " - ");
            var iD = categories[0];
            var artist = categories[1];
            var title = categories[2];
            return new Song(iD, artist, title);
        }

        public string GetFilePath() => _filePath;
        
            
        
    }







}


