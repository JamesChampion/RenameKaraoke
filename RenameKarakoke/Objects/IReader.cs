using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameKarakoke
{
  public interface IReader
    {
       //FolderBrowserDialog _folderBrowserDialog { get; set; }
       // OpenFileDialog _openFileDialog { get; set; }


        void Read(string FileName);

        Song ParseSong(string line);

    }
}
