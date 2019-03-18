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


        public FileCompressionHelper()
        {

        }

        public FileCompressionHelper(string sourceDir, string destDir)
        {
            _sourceDir = sourceDir;
            _destDir = destDir;
        }

        public void ExtractFileWithNewName(string songTitle)
        {


            //RenameInteriorContents(songTitle);

        }
        public string GetFileName(string sourceDir, Song song)
        {
            var fileName = sourceDir + "\\" + song.ID + " - " + song.Artist + " - " + song.Title;
            return fileName;
        }

        //Find File
        // Unzip
        //Rename Interior Contents

        
      






    }
}
