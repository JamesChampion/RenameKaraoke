using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenameKarakoke.Objects
{
    class FileWriter
    {
        public FileWriter()
        {

        }
        private void RenameFile(string sourcePath, string destPath)
        {
            //Is It Compressed?

            var fileExtension = Path.GetExtension(sourcePath);


        }

        private string ReplaceCorruptedFileName(string sourceFilePath)
        {
            var corruptFileName = sourceFilePath.Substring(sourceFilePath.IndexOf(".zip")) + "---Corrupt.zip";
            return corruptFileName;

        }



    }
}
