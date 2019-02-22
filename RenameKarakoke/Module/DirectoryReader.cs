using System.IO;
using System.Text.RegularExpressions;

namespace RenameKarakoke
{
    class DirectoryReader : IReader
    {
        public void Read(string path)
        {
            var expression = new Regex("^KV");
            var files = Directory.EnumerateFiles(path);
            foreach (var file in files)
            {
                var fileName = Path.GetFileNameWithoutExtension(file);
                Match match = expression.Match(fileName);
                if (match.Success && !fileName.EndsWith(".txt"))
                {
                    Song.songQueryList.Add(GetSong(fileName));
                }

                
               
            }

            var dataTableForm = new QueryTable_form();
            dataTableForm.Show();
        }

        public Song GetSong(string line)
        { 
            var categories = Regex.Split(line, " - ");
            if (categories.Length < 3)
            {
                System.Console.WriteLine("Invalid Reg Format: " + line );
                return new Song(categories[0], " INVALID FORMAT", " ****");
            }
            else
            {

            var iD = categories[0];
            var artist = categories[1];
            var title = categories[2];
            return new Song(iD, artist, title);

            }
            
        }

    }
}
