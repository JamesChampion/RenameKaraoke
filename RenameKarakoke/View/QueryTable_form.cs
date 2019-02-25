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
            Song.AddBindingSongs(songBindingSource, Song.songQueryList);
        }




        //Submit Button Should Only Show Successful Completion 
        private void Submit_btn_Click(object sender, EventArgs e)
        {
            //Open File Dialog And Get Selected Path --Done
            var selectedSongList = GetSelectedSongs();
            var newFilePath = GetNewFilePath();

            //Copy Every File To New Location --Done
            var oldFilePath = DirectoryReader.FilePath;
            var directoryReader = new DirectoryReader();
            directoryReader.DirectoryCopy(oldFilePath, newFilePath);
            var files = Directory.GetFiles(newFilePath);

            // Unzip Files to New Location....Should This Only Be Done With Incorrect FileNames???
            foreach (var file in files)
            {
               var newFileName =  Path.GetFileNameWithoutExtension(directoryReader.UnzipFile(file));
            }


            foreach (var song in selectedSongList)
            {
                //FindCorrectSongInfo --DONE
                var actualSongInfo = FindCorrectSongInfo(song);
                if(actualSongInfo != null)
                {
                
                //Rename Interior FileComponents
                //Rename .Zip File
                //Compress
                }
                

            }
        }



        private void RenameFile()
        {

        }




        //Method Should Be Moved*******
        private string GetNewFilePath()
        {
            string newFilePath = null;
            DialogResult result;
            var folderBrowserDialog = new FolderBrowserDialog()
            {
                Description = "Please Select A Destination to Save Renamed Files",
                ShowNewFolderButton = true

            };
            result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                newFilePath = folderBrowserDialog.SelectedPath;
            }



            return newFilePath;

        }



        //This Method Should Be Moved******
        private Song FindCorrectSongInfo(Song oldSong)
        {

            foreach (Song songinfo in Song.songMasterList)
            {
                if (songinfo.Title == oldSong.Title)
                {
                    return songinfo;

                }
            }
            return null;



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





        //This Method Needs To be Moved To A Controller Class      
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


    }
}

//Commented Old FindSong FX...Keep For Now
//public void FindSongs(List<Song> selectedSongs)
//{
//    bool isRenamed;
//    DialogResult result;
//    string newFilePath;
//    int count = 0;
//    var songsThatCouldNotBeRenamed = new List<Song>();
//    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
//    {
//        Description = "Select A Destination to Save",
//        ShowNewFolderButton = true
//    };
//    result = folderBrowserDialog.ShowDialog();
//    if (result == DialogResult.OK)
//    {
//        newFilePath = folderBrowserDialog.SelectedPath;
//        foreach (Song song in selectedSongs)
//        {
//            var item = Song.songMasterList.Find(s => s.Title == song.Title);

//            if (item != null)
//            {
//                isRenamed = RenameSong(item, newFilePath);
//                if (isRenamed)
//                {
//                    count++;
//                }
//                else
//                {
//                    songsThatCouldNotBeRenamed.Add(item);
//                }
//            }
//            isRenamed = false;
//        }
//    }

//    MessageBox.Show(count + " Files Out Of " + selectedSongs.Count + " Have Been Renamed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
//    Console.WriteLine("The Songs That Could Not Be Renamed Are");
//    foreach (Song song in songsThatCouldNotBeRenamed)
//    {
//        Console.WriteLine(song.Title + " - " + song.Artist);
//    }
//}
