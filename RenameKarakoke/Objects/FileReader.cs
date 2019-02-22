using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RenameKarakoke
{
    class FileReader : IReader

    {
        //public FolderBrowserDialog _folderBrowserDialog { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        //public OpenFileDialog _openFileDialog { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        //public FileReader(OpenFileDialog fileDialog)
        //{
        //    _openFileDialog = fileDialog;

        //    //Ask Daniel About This Implementation of Interface.
        //    _folderBrowserDialog = null;
        //}


        public void Read(string path)
        {
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

       

    }







}


