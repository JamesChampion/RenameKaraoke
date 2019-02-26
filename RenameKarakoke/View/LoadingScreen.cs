using System.Windows.Forms;

namespace RenameKarakoke.View
{
    public partial class LoadingScreen : Form
    {
        public ProgressBar _loadingProgressBar { get; set; }

        public LoadingScreen()
        {
            InitializeComponent();
            _loadingProgressBar = this.Loading_progressBar;
            _loadingProgressBar.Show();
        }


    }
}
