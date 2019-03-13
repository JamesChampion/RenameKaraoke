using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RenameKarakoke
{
  public  class Song
    {

        public string ID { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public static string title { get; private set; }

        public Song(string iD, string artist, string title)
        {
            ID = iD ?? throw new ArgumentNullException(nameof(iD));
            Artist = artist ?? throw new ArgumentNullException(nameof(artist));
            Title = title ?? throw new ArgumentNullException(nameof(title));
        }

  

       
    }
}
