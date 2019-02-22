using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
<<<<<<< HEAD
using System.Windows.Forms.VisualStyles;
=======

>>>>>>> aab5e9b4669314b9549fc5d37f0deb46ea440a9f

namespace RenameKarakoke
{
    public partial class TextFileTable_Form : Form
    {
<<<<<<< HEAD
        private readonly IReader _directoryReader;
        private readonly IReader _fileReader;


        public TextFileTable_Form(IReader fileReader)
        {
            _fileReader = fileReader;
=======
        public TextFileTable_Form()
        {
>>>>>>> aab5e9b4669314b9549fc5d37f0deb46ea440a9f
            InitializeComponent();
        }

        private void TextFileTable_form_Load(object sender, EventArgs e)
        {

            var location = this.Location;
            location.X = 0;
<<<<<<< HEAD
            Location = location;
            Song.AddBindingSongs(songMasterBindingSource, Song.songMasterList);
           
        }
=======

            Location = location;
            foreach (var song in Song.songMasterList)
            {
                songMasterBindingSource.Add(song);
            }
           
        }

        private void SongDataTable_dataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            //TODO: CREATE USER RESPONSE FOR AUTOSORTING
            //var columnName = SongDataTable_dataGridView.Columns[e.ColumnIndex].Name;
            //var index = columnName.IndexOf("Data");
            //var sortingByCriteria = columnName.Substring(0, index);
            //DataGridViewColumn newColumn = SongDataTable_dataGridView.Columns[e.ColumnIndex];
            //DataGridViewColumn oldColumn = SongDataTable_dataGridView.SortedColumn;
            //ListSortDirection direction;
            //if (oldColumn != null)
            //{
            //    if (oldColumn == newColumn && SongDataTable_dataGridView.SortOrder == SortOrder.Ascending)
            //    {
            //        direction = ListSortDirection.Descending;

            //    }
            //    else
            //    {
            //        direction = ListSortDirection.Ascending;
            //        oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
            //    }

            //}
            //else
            //{
            //    direction = ListSortDirection.Ascending;
            //}
            //SongDataTable_dataGridView.Sort(newColumn, direction);
            //newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        }


        private void SongDataTable_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var song = new Song("","","");

            //if (e.ColumnIndex == 0 && e.RowIndex != -1)
            //{
            //    Song.songMasterList.Clear();
            //    song = Song.GetSong(SongDataTable_dataGridView, e.RowIndex);
            //    Song.songMasterList.Add(song);
            //}

            //var queryTable = new QueryTable_form();
            //queryTable.FindSong(song);


        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in SongDataTable_dataGridView.Rows)
            {
                if (row.Cells[0].Value == 1)
                {
                    Console.WriteLine("oNE cHECK mAR");
                }
                
            }
        }
>>>>>>> aab5e9b4669314b9549fc5d37f0deb46ea440a9f
    }
}
