namespace RenameKarakoke.View
{
    partial class LoadingScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreen));
            this.Loading_progressBar = new System.Windows.Forms.ProgressBar();
            this.Renaming_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Loading_progressBar
            // 
            this.Loading_progressBar.Location = new System.Drawing.Point(4, 103);
            this.Loading_progressBar.Name = "Loading_progressBar";
            this.Loading_progressBar.Size = new System.Drawing.Size(374, 23);
            this.Loading_progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.Loading_progressBar.TabIndex = 0;
            // 
            // Renaming_label
            // 
            this.Renaming_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Renaming_label.Location = new System.Drawing.Point(12, 23);
            this.Renaming_label.Name = "Renaming_label";
            this.Renaming_label.Size = new System.Drawing.Size(340, 34);
            this.Renaming_label.TabIndex = 1;
            this.Renaming_label.Text = "Renaming Files";
            this.Renaming_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadingScreen
            // 
            this.ClientSize = new System.Drawing.Size(380, 138);
            this.Controls.Add(this.Renaming_label);
            this.Controls.Add(this.Loading_progressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading. . .";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar Loading_progressBar;
        private System.Windows.Forms.Label Renaming_label;
    }
}
