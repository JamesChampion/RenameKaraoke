using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RenameKarakoke
{
  public  class Song
    {


        //Remove Static Ref IF Possible
        public static List<Song> songMasterList = new List<Song>();
        public static List<Song> songQueryList = new List<Song>();
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

        public static Song GetSong(DataGridView dataGrid, int rowIndex)
        {
            string iD = dataGrid.Rows[rowIndex].Cells[1].Value.ToString();
            string artist = dataGrid.Rows[rowIndex].Cells[2].Value.ToString();
            string title = dataGrid.Rows[rowIndex].Cells[3].Value.ToString();
            return new Song(iD, artist, title);
        }



        public static void AddBindingSongs(BindingSource songBindingSource, List<Song> songList)
        {

            songBindingSource.Clear();
            foreach(var Song in songList)
            {
                songBindingSource.Add(Song);
            }
        }

       
    }
}
