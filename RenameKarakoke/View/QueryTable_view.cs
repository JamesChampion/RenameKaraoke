using RenameKarakoke.Enum;
using RenameKarakoke.Objects;
using RenameKarakoke.View;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataSet = RenameKarakoke.Objects.DataSet;

namespace RenameKarakoke
{
    public partial class QueryTable_form : Form
    {

        private readonly DataSet _dataSet;
        private LoadingScreen _loadingScreen;
        private readonly string _songDirPath;
        private InputSource _dataSource { get; set; }

        public QueryTable_form(string dirPath, DataSet dataset)

        {
            _dataSet = dataset;
             _dataSet.SongSourceDirPath = dirPath;
            _dataSource = InputSource.directory;
            _loadingScreen = new LoadingScreen();
            InitializeComponent();

        }


        //Set Location
        private void QueryTable_form_Load(object sender, EventArgs e)
        {
            var location = Location;
            location.X += 350;
            Location = location;
            var dataTable = _dataSet.GetDataTable(_dataSource);
            Query_dataTableView.DataSource = dataTable;
            Query_dataTableView.Columns[0].HeaderText = "";
            Query_dataTableView.Columns[0].FillWeight = 10;
        }

        //Submit Button Should Only Show Successful Completion 
        private async void Submit_btn_Click(object sender, EventArgs e)

        {
            bool isCompressed = false;
            _dataSet.SongListManager.SelectedSongList = GetSelectedSongs();
            var renameHelper = new RenameHelper(_dataSet);
            if (Unzip_checkBox.CheckState == CheckState.Checked) isCompressed = true;
            renameHelper.EvaluateUserInput(isCompressed);
            


            //bool isCompressed = false;
            //if (Unzip_checkBox.CheckState == CheckState.Checked)
            //{
            //    isCompressed = true;
            //}

            //var directoryWriter = new DirectoryWriter(isCompressed, _dataSet);
            //var selectedSongList = GetSelectedSongs();

            //var currentDirPath = _songDirPath;
            //var saveDirPath = directoryWriter.GetDirectorySavePath();
            //if (saveDirPath != null)
            //{
            //    Hide();
            //    _loadingScreen.Show();
            //    if (isCompressed)
            //    {
            //        var fileCompressionHelper = new FileCompressionHelper(currentDirPath, saveDirPath, selectedSongList);
            //    }
                
                    //Find The Correct Song Info, 
                    //If its a match, check to see if they want to unzip it
                    //If so, Rename/Unzip Then rename the interior contents and compress
                    //Else, Rename The File
                    //After All Files Are renamed, Copy Files That were not found into the new Location
                

                //await Task.Run(() => directoryWriter.DirectoryCopy(currentDirPath, saveDirPath));
                //int fileCount = 0;
                //await Task.Run(() => fileCount = directoryWriter.RenameFilesInDirectory(saveDirPath, selectedSongList));
                //_loadingScreen.Hide();
                //MessageBox.Show(fileCount + " files Renamed!", "File Renamed", MessageBoxButtons.OK);
            //}


        }

        private List<Song> GetSelectedSongs()
        {
            var selectedSongList = new List<Song>();
            foreach (DataGridViewRow row in Query_dataTableView.Rows)
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
            if (selectedSongList.Count == 0)
            {
                MessageBox.Show("Please Make A Selection", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return selectedSongList;
        }





        #region UI button Events
        private void Clear_btn_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in Query_dataTableView.Rows)
            {
                row.Cells[0].Value = CheckState.Unchecked;
            }
        }
        private void SelectAll_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Query_dataTableView.Rows)
            {
                row.Cells[0].Value = CheckState.Checked;
            }
        }



        #endregion

    }
}

