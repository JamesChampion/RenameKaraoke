using System.Collections.Generic;
using System.Windows.Forms;

namespace RenameKarakoke.Objects
{
   public class SongListManager
    {
        public List<Song> MasterSongList { get; set; }
        public List<Song> QuerySongList { get; set; }
        public List<Song> SelectedSongList { get; set; }

        public SongListManager()
        {

        }

        private Song GetSong(DataGridView dataGrid, int rowIndex)
        {

            string iD = dataGrid.Rows[rowIndex].Cells[1].Value.ToString();
            string artist = dataGrid.Rows[rowIndex].Cells[2].Value.ToString();
            string title = dataGrid.Rows[rowIndex].Cells[3].Value.ToString();
            return new Song(iD, artist, title);
           
        }


      
        




    }
}
