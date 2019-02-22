using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenameKarakoke
{
  public interface IReader
    {
     //   string FileLocation { get; set; }
        void Read(string FileName);

        Song GetSong(string line);
        
    }
}
