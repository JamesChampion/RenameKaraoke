using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RenameKarakoke
{
    public partial class TextFileTable_Form : Form
    {
        private readonly IReader _directoryReader;
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
            Song.AddBindingSongs(songMasterBindingSource, Song.songMasterList);
           
        }
    }
}
