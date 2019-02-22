using System;
using System.IO;
using System.Text.RegularExpressions;

namespace RenameKarakoke
{
    class FileReader : IReader

    {
        public void Read(string path)
        {
            var expression = new Regex("^KV");
            var lines = File.ReadLines(path);
            foreach (var line in lines)
            {
                Match match = expression.Match(line);
                if (match.Success && !line.EndsWith("kmh"))
                {

                    Song.songMasterList.Add(GetSong((Path.GetFileNameWithoutExtension(line))));
                }
            }
            var dataTableForm = new TextFileTable_Form();
            dataTableForm.Show();
        }

        public Song GetSong(string fileLine)
        {
            var categories = Regex.Split(fileLine, " - ");
            var iD = categories[0];
            var artist = categories[1];
            var title = categories[2];
            return new Song(iD, artist, title);
        }



    }







}


