using RenameKarakoke.Enum;
using RenameKarakoke.Objects;
using System;
using System.Windows.Forms;
namespace RenameKarakoke
{
    public partial class TextFileTable_Form : Form
    {
        private readonly DataSet _dataSet;
        private InputSource _dataSource { get; set; }

        public TextFileTable_Form(DataSet dataSet)
        {
            this._dataSet = dataSet;
            _dataSource = InputSource.textFile;
            InitializeComponent();
        }

        private void TextFileTable_form_Load(object sender, EventArgs e)
        {

            var dataTable = _dataSet.GetDataTable(_dataSource);
            var location = this.Location;
            location.X = 0;
            Location = location;
            MasterSongList_dataGridView.DataSource = dataTable;
        }

      
    }
}
