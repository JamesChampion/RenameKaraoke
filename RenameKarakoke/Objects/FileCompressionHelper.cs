using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenameKarakoke.Objects
{
    class FileCompressionHelper
    {
        private string _sourceDir { get; set; }
        private string _destDir { get; set; }
        private List<Song> _selectedSongList { get; set; }

        public FileCompressionHelper(string sourceDir, string destDir, List<Song> selectedSongList)
        {
            _sourceDir = sourceDir;
            _destDir = destDir;
            _selectedSongList = selectedSongList;
        }

        public void ExtractFileWithNewName(string songTitle)
        {


            RenameInteriorContents(songTitle);

        }

        public void RenameInteriorContents(string songTitle)
        {

        }






    }
}
