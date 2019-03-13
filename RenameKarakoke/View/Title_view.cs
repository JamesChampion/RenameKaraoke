using RenameKarakoke.Objects;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RenameKarakoke
{
    public partial class Title_form : Form
    {
        private readonly DirectoryReader _directoryReader;
        private readonly FileReader _fileReader;
        private readonly InputHandler _inputHandler;
        private TextFileTable_Form _textFileTable;
        private QueryTable_form _queryTable;
        private SongListManager _songListManager;

        //Initalize Form, Add Click Events, Initalize Private Variables
        public Title_form(DirectoryReader directoryReader, FileReader fileReader)
        {
            _directoryReader = directoryReader;
            _fileReader = fileReader;
            _inputHandler = new InputHandler();
            _songListManager = new SongListManager();
            InitializeComponent();
            TextFile_btn.Click += (s, e) => { _inputHandler.UpdateField(TextFile_txtBox, UserResponse.BrowseFile); };
            Directory_btn.Click += (s, e) => { _inputHandler.UpdateField(Directory_txtBox, UserResponse.BrowseDirectory); };

        }

        //Read Both Inputs and Show the Form If Inputs Aren't Blank
        private void Execute_btn_Click(object sender, System.EventArgs e)
        {

            var forms = GetOpenForms();
            DisposeUnusedForms(forms);
            var allTextBoxes = Input_panel.Controls.OfType<TextBox>();
            if (_inputHandler.IsValidInput(allTextBoxes))
            {
                var fileName = TextFile_txtBox.Text;
                var dirPath = Directory_txtBox.Text;
                _songListManager.MasterSongList = _fileReader.Read(fileName);
                _songListManager.QuerySongList = _directoryReader.Read(dirPath);
                var dataSet = new DataSet(_songListManager, dirPath);
                _textFileTable = new TextFileTable_Form(dataSet);
                _queryTable = new QueryTable_form(dirPath, dataSet);
                _textFileTable.Show();
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
        private Form[] GetOpenForms()
        {
            var forms = Application.OpenForms.Cast<Form>().ToArray();
            return forms;
        }
        private void DisposeUnusedForms(Form[] forms)
        {
            foreach (Form thisForm in forms)
            {
                if (thisForm.Name != this.Name)
                {
                    thisForm.Close();
                    thisForm.Dispose();
                }
            }


        }
    }
}
