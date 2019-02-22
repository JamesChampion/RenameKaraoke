<<<<<<< HEAD
﻿
=======
﻿using System;
using System.Collections.Generic;
>>>>>>> aab5e9b4669314b9549fc5d37f0deb46ea440a9f
using System.Linq;
using System.Windows.Forms;

namespace RenameKarakoke
{
    public partial class Title_form : Form
    {
<<<<<<< HEAD
        private readonly IReader _directoryReader;
        private readonly IReader _fileReader;
        private readonly InputHandler _inputHandler;
        private TextFileTable_Form _textFileTable;
        private QueryTable_form _queryTable;

        //Initalize Form, Add Click Events, Initalize Private Variables
        public Title_form(IReader directoryReader, IReader fileReader)
        {
            _directoryReader = directoryReader;
            _fileReader = fileReader;
            _textFileTable = new TextFileTable_Form(_fileReader);
            _queryTable = new QueryTable_form(_directoryReader, _fileReader);
            _inputHandler = new InputHandler(_directoryReader, _fileReader);
            InitializeComponent();
            TextFile_btn.Click += (s, e) => {_inputHandler.UpdateField(TextFile_txtBox, UserResponse.BrowseFile); };
            Directory_btn.Click += (s, e) => { _inputHandler.UpdateField(Directory_txtBox, UserResponse.BrowseDirectory); };
        }

        //Read Both Inputs and Show the Form If Inputs Aren't Blank
        private void Execute_btn_Click(object sender, System.EventArgs e)
        {
            var allTextBoxes = Input_panel.Controls.OfType<TextBox>();
            if (_inputHandler.IsValidInput(allTextBoxes))
            {
                var fileName = TextFile_txtBox.Text;
                _fileReader.Read(fileName);
                _textFileTable.Show();
                var dirPath = Directory_txtBox.Text;
                _directoryReader.Read(dirPath);
                _queryTable.Show();
=======
        public Title_form()
        {
            InitializeComponent();
            TextFile_btn.Click += (s, e) => { UpdateField(TextFile_txtBox, UserResponse.BrowseFile); };
            Directory_btn.Click += (s, e) => { UpdateField(Directory_txtBox, UserResponse.BrowseDirectory); };
        }

        private void UpdateField(TextBox field, UserResponse userButtonResponse)
        {
            var module = new Module();
            if (module.IsValidDialogResponse(userButtonResponse))
                field.Text = module.GetUserDialogInput();
            field.Refresh();
        }

        private void Quit_btn_Click(object sender, System.EventArgs e)
        {
            DialogResult result;
            var title = "Quit Application";
            var message = "Are you sure you would like to quit?";
            result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Execute_btn_Click(object sender, System.EventArgs e)
        {
            var allTextBoxes = Input_panel.Controls.OfType<TextBox>();
            if (IsValidInput(allTextBoxes))
            {
                var fileReader = new FileReader();
                var fileName = TextFile_txtBox.Text;
                fileReader.Read(fileName);
                var directoryReader = new DirectoryReader();
                var path = Directory_txtBox.Text;
                directoryReader.Read(path);

                

>>>>>>> aab5e9b4669314b9549fc5d37f0deb46ea440a9f
            }
            else
            {
                var title = "Invalid!";
                var message = "Please make sure 2 selections have been made";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }


        //Passes A Collection, Filters Based On Null Entries, Then Tries to Iterate Through It
<<<<<<< HEAD
    

        private void Quit_btn_Click(object sender, System.EventArgs e)
        {
            DialogResult result;
            var title = "Quit Application";
            var message = "Are you sure you would like to quit?";
            result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


=======
        private bool IsValidInput(IEnumerable<TextBox> textBoxes)
        {
            var filteredResult = textBoxes.Where(t => t.TextLength == 0);
            using (var enumerator = filteredResult.GetEnumerator())
            {
                return !enumerator.MoveNext();
            }
        }

        private void Title_form_Load(object sender, EventArgs e)
        {
          
        }
>>>>>>> aab5e9b4669314b9549fc5d37f0deb46ea440a9f
    }
}
