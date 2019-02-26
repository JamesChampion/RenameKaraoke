using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RenameKarakoke
{
    class DirectoryReader : IReader
    {
        private string _filePath { get; set; }

        //public DirectoryReader(ISongListManager songListManager)
        //{
        //}

        // Try having this method return the list of songs
        public void Read(string path)
        {
            var files = Directory.EnumerateFiles(path);
            _filePath = path;
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

        public string GetFilePath() => _filePath;
    }
}
