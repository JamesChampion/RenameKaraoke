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
            string newFileName;
            bool isCompressed =  Unzip_checkBox.Checked ? true : false;
            var directoryWriter = new DirectoryWriter(isCompressed, _directoryReader);
            var selectedSongList = GetSelectedSongs();
            var oldFilePath = _directoryReader.GetFilePath();
            var newFilePath = directoryWriter.GetNewFilePath();
            
            //Copy Every File To New Location --Done
            directoryWriter.DirectoryCopy(oldFilePath, newFilePath, isCompressed);
            //Eventually, Only Unzip Files With Incorrect Names.


            var count = 0;
            foreach (var song in selectedSongList)
            {
                //FindCorrectSongInfo --DONE
                var actualSongInfo = directoryWriter.FindCorrectSongInfo(song);

                if (actualSongInfo != null)
                {
                    var oldFileName = newFilePath + "\\" + song.ID + " - " + song.Artist + " - " + song.Title + ".zip";
                    if (actualSongInfo.Artist != song.Artist)
                    {
                        newFileName = newFilePath + "\\" + actualSongInfo.ID + " - " + song.Artist + " - " + actualSongInfo.Title + ".zip";

                    }
                    else
                    {
                        newFileName = newFilePath + "\\" + actualSongInfo.ID + " - " + actualSongInfo.Artist + " - " + actualSongInfo.Title + ".zip";
                    }

                    var i = 0;
                    //Old Song Info Has the correct FileName



                    if (!File.Exists(newFileName)) //If The File Exisits, its a Good Title
                    {
                        File.Copy(oldFileName, newFileName);
                        File.Delete(oldFileName);
                        //oldFileName += i++;
                    }




                }
                count++;

                //Rename Interior FileComponents
                //Rename .Zip File
                //Compress



            }
           
           
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

