using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenameKarakoke
{
    class TestUnzipping
    {
        public TestUnzipping()
        {
            //This Works 
            var sourceFolder = "";
            DirectoryInfo currentDirectoryInfo = new DirectoryInfo(sourceFolder);

            FileInfo[] files = currentDirectoryInfo.GetFiles();
            var count = 0;
            foreach (var file in files)
            {
                var sourceFilePath = sourceFolder + "\\" + file.Name;
                var newSongName = "K2 - SongArtist - SongTitle" + " -" + count;
                count += 1;
                var destFilePath = sourceFolder + "\\" + newSongName;
                Directory.CreateDirectory(destFilePath);
                ZipFile.ExtractToDirectory(sourceFilePath, destFilePath);
                //  File.Delete(sourceFilePath);
                var sourcePath = destFilePath;
                var newDirect = Path.GetDirectoryName(sourcePath);
                var newDestPath = newDirect + "\\" + newSongName;
                currentDirectoryInfo = new DirectoryInfo(destFilePath);
                var newfiles = currentDirectoryInfo.GetFiles();
                var fileNames = new List<string>();

                foreach (var file2 in newfiles)
                {
                    var extension = file2.Extension;
                    file2.MoveTo(currentDirectoryInfo + "\\" + newSongName + extension);
                    Console.WriteLine(file2.Name);
                }

            }
        }

    }
}
