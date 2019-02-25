
using System;
using System.Linq;
using System.Windows.Forms;

namespace RenameKarakoke
{
    public partial class Title_form : Form
    {
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
            _inputHandler = new InputHandler(_directoryReader, _fileReader);
            InitializeComponent();
            TextFile_btn.Click += (s, e) => {_inputHandler.UpdateField(TextFile_txtBox, UserResponse.BrowseFile); };
            Directory_btn.Click += (s, e) => { _inputHandler.UpdateField(Directory_txtBox, UserResponse.BrowseDirectory); };
        }


        //Read Both Inputs and Show the Form If Inputs Aren't Blank
        private void Execute_btn_Click(object sender, System.EventArgs e)
        {
            // I Must Construct The Forms Here So If it is Closed, It will Open Again
            _queryTable = new QueryTable_form(_directoryReader, _fileReader);
            _textFileTable = new TextFileTable_Form(_fileReader);
            var allTextBoxes = Input_panel.Controls.OfType<TextBox>();
            if (_inputHandler.IsValidInput(allTextBoxes))
            {
                
                
                    var fileName = TextFile_txtBox.Text;
                    _fileReader.Read(fileName);
                    _textFileTable.Show();
                    var dirPath = Directory_txtBox.Text;
                    _directoryReader.Read(dirPath);
                    _queryTable.Show();
                
               
            }
            else
            {
                var title = "Invalid!";
                var message = "Please make sure 2 selections have been made";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
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


    }
}
