using RenameKarakoke.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;


namespace RenameKarakoke
{
    public partial class QueryTable_form : Form
    {
        private readonly IReader _directoryReader;
        private readonly IReader _fileReader;


        public QueryTable_form(IReader directoryReader, IReader fileReader)

        {
            _directoryReader = directoryReader;
            _fileReader = fileReader;
            InitializeComponent();
        }


        //Set Location, Add Binding DataSource to Table
        private void QueryTable_form_Load(object sender, EventArgs e)
        {
            var location = Location;
            location.X += 350;
            Location = location;
            songBindingSource.DataSource = Song.songQueryList;
        }




        //Submit Button Should Only Show Successful Completion 
        private void Submit_btn_Click(object sender, EventArgs e)

        {
            bool isCompressed = Unzip_checkBox.Checked ? true : false;
            var directoryWriter = new DirectoryWriter(isCompressed, _directoryReader);
            var selectedSongList = GetSelectedSongs();
            var oldFilePath = _directoryReader.GetFilePath();
            var newFilePath = directoryWriter.GetNewFilePath();

            //Copy Every File To New Location --Done
            directoryWriter.DirectoryCopy(oldFilePath, newFilePath, isCompressed);
            directoryWriter.RenameFilesInDirectory(newFilePath, selectedSongList);
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in SongQueryDataTable_dataGridView.Rows)
            {
                row.Cells[0].Value = CheckState.Unchecked;
            }
        }
        private void SelectAll_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in SongQueryDataTable_dataGridView.Rows)
            {
                row.Cells[0].Value = CheckState.Checked;
            }
        }
        private List<Song> GetSelectedSongs()
        {
            var selectedSongList = new List<Song>();

            foreach (DataGridViewRow row in SongQueryDataTable_dataGridView.Rows)
            {

                if (row.Cells[0].Value != null)
                {

                    if (row.Cells[0].FormattedValue.Equals(true))
                    {
                        string id = row.Cells[1].Value.ToString();
                        string artist = row.Cells[2].Value.ToString();
                        string title = row.Cells[3].Value.ToString();
                        selectedSongList.Add(new Song(id, artist, title));
                    }
                }
            }
            if (Song.songQueryList.Count == 0)
            {
                MessageBox.Show("Please Make A Selection", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return selectedSongList;
        }

        private void SongQueryDataTable_dataGridView_headerClick(object sender, DataGridViewColumnEventHandler e)
        {
            Console.WriteLine("This Is Clicked");
        }
    }
}

