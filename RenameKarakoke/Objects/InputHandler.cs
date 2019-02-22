using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RenameKarakoke
{
    public class InputHandler
    {
        private readonly IReader _fileReader;
        private readonly IReader _directoryReader;
        private string FileName { get; set; }

        public InputHandler(IReader directoryReader, IReader fileReader)
        {
            _directoryReader = directoryReader;
            _fileReader = fileReader;
        }


        public bool IsValidInput(IEnumerable<TextBox> textBoxes)
        {
            var filteredResult = textBoxes.Where(t => t.TextLength == 0);
            using (var enumerator = filteredResult.GetEnumerator())
            {
                return !enumerator.MoveNext();
            }
        }
        public void UpdateField(TextBox field, UserResponse userButtonResponse)
        {
            
            if (IsValidDialogResponse(userButtonResponse))
                field.Text = GetUserDialogInput();
            field.Refresh();
        }

        public bool IsValidDialogResponse(UserResponse userButtonResponse)
        {
            DialogResult result;
            switch ((userButtonResponse))
            {
                case UserResponse.BrowseFile:
                    OpenFileDialog openFileDialog = new OpenFileDialog
                    {
                        Filter = "txt files (*.txt)|*.txt|.txt files (*.txt)|*.txt",
                        InitialDirectory = @"c:\"
                    };
                    result = openFileDialog.ShowDialog();
                     FileName = openFileDialog.FileName;
                    if (IsValidFile(FileName))
                    {
                        return result == DialogResult.OK;
                    }
                    else
                    {
                        if (result != DialogResult.Cancel)
                        {
                            MessageBox.Show("Please Only Select .txt Files", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            IsValidDialogResponse(userButtonResponse);
                            return false;
                        }
                        return false;
                    }

                default:
                    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
                    {
                        ShowNewFolderButton = false
                    };
                    result = folderBrowserDialog.ShowDialog();
                    FileName = folderBrowserDialog.SelectedPath;
                    return result == DialogResult.OK;
            }



        }

        public string GetUserDialogInput() => FileName;

        private bool IsValidFile(string fileName) => fileName.EndsWith(".txt") && !string.IsNullOrWhiteSpace(fileName) ? true : false;

    }
}
    
