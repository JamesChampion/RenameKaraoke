using System.Windows.Forms;

namespace RenameKarakoke
{
    public class TitleController 
    {
        //Constructor
        //Controller Should Only Pass The Values Really... Logic Should Be Elsewhere Tooooooo.....
        public string FileName { get; set; }
        private readonly UserResponse _userResponse;
        private readonly IReader _directoryReader;
        private readonly IReader _fileReader;

        public TitleController(IReader directoryReader, IReader fileReader, UserResponse userResponse)
        {
            _userResponse = userResponse;
            _directoryReader = directoryReader;
            _fileReader = fileReader;
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
