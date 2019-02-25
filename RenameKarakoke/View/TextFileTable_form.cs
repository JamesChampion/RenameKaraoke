using System;
using System.Windows.Forms;
using System.Linq.Dynamic;
using System.Collections.Generic;

namespace RenameKarakoke
{
    public partial class TextFileTable_Form : Form
    {
        private readonly IReader _fileReader;

      
   


        public TextFileTable_Form(IReader fileReader)
        {
            _fileReader = fileReader;
            InitializeComponent();
        }

        private void TextFileTable_form_Load(object sender, EventArgs e)
        {



            var location = this.Location;
            location.X = 0;
            Location = location;
            songMasterBindingSource.DataSource = Song.songMasterList;
        
        }

        private void SongMasterDataTable_dataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Insert Code For Auto Sorting The Column Header
            Console.WriteLine("The Header was Clicked");
        }

       
    }
}
