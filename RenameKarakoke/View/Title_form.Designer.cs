using System.Windows.Forms;

namespace RenameKarakoke
{
    partial class Title_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Title_form));
            this.Title_lbl = new System.Windows.Forms.Label();
            this.TxtFile_lbl = new System.Windows.Forms.Label();
            this.Directory_lbl = new System.Windows.Forms.Label();
            this.TextFile_txtBox = new System.Windows.Forms.TextBox();
            this.Directory_txtBox = new System.Windows.Forms.TextBox();
            this.TextFile_btn = new System.Windows.Forms.Button();
            this.Directory_btn = new System.Windows.Forms.Button();
            this.Karaoke_pictureBox = new System.Windows.Forms.PictureBox();
            this.Execute_btn = new System.Windows.Forms.Button();
            this.Quit_btn = new System.Windows.Forms.Button();
            this.Input_panel = new System.Windows.Forms.Panel();
            this.Execution_panel = new System.Windows.Forms.Panel();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.Karaoke_pictureBox)).BeginInit();
            this.Input_panel.SuspendLayout();
            this.Execution_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title_lbl
            // 
            this.Title_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_lbl.Location = new System.Drawing.Point(-1, 9);
            this.Title_lbl.Name = "Title_lbl";
            this.Title_lbl.Size = new System.Drawing.Size(761, 41);
            this.Title_lbl.TabIndex = 0;
            this.Title_lbl.Text = "Renaming Karaoke File Helper";
            this.Title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtFile_lbl
            // 
            this.TxtFile_lbl.AutoSize = true;
            this.TxtFile_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFile_lbl.Location = new System.Drawing.Point(13, 0);
            this.TxtFile_lbl.Name = "TxtFile_lbl";
            this.TxtFile_lbl.Size = new System.Drawing.Size(417, 24);
            this.TxtFile_lbl.TabIndex = 1;
            this.TxtFile_lbl.Text = "Please Select Text File With Correct Names";
            // 
            // Directory_lbl
            // 
            this.Directory_lbl.AutoSize = true;
            this.Directory_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Directory_lbl.Location = new System.Drawing.Point(13, 50);
            this.Directory_lbl.Name = "Directory_lbl";
            this.Directory_lbl.Size = new System.Drawing.Size(394, 24);
            this.Directory_lbl.TabIndex = 2;
            this.Directory_lbl.Text = "Please Select Folder With Karakoke Files";
            // 
            // TextFile_txtBox
            // 
            this.TextFile_txtBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextFile_txtBox.Enabled = false;
            this.TextFile_txtBox.Location = new System.Drawing.Point(17, 27);
            this.TextFile_txtBox.Name = "TextFile_txtBox";
            this.TextFile_txtBox.ReadOnly = true;
            this.TextFile_txtBox.Size = new System.Drawing.Size(413, 20);
            this.TextFile_txtBox.TabIndex = 3;
            // 
            // Directory_txtBox
            // 
            this.Directory_txtBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Directory_txtBox.Enabled = false;
            this.Directory_txtBox.Location = new System.Drawing.Point(17, 77);
            this.Directory_txtBox.Name = "Directory_txtBox";
            this.Directory_txtBox.ReadOnly = true;
            this.Directory_txtBox.Size = new System.Drawing.Size(413, 20);
            this.Directory_txtBox.TabIndex = 4;
            // 
            // TextFile_btn
            // 
            this.TextFile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextFile_btn.Location = new System.Drawing.Point(436, 23);
            this.TextFile_btn.Name = "TextFile_btn";
            this.TextFile_btn.Size = new System.Drawing.Size(90, 26);
            this.TextFile_btn.TabIndex = 5;
            this.TextFile_btn.Text = "Browse";
            this.TextFile_btn.UseVisualStyleBackColor = true;
            // 
            // Directory_btn
            // 
            this.Directory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Directory_btn.Location = new System.Drawing.Point(436, 73);
            this.Directory_btn.Name = "Directory_btn";
            this.Directory_btn.Size = new System.Drawing.Size(90, 26);
            this.Directory_btn.TabIndex = 6;
            this.Directory_btn.Text = "Browse";
            this.Directory_btn.UseVisualStyleBackColor = true;
            // 
            // Karaoke_pictureBox
            // 
            this.Karaoke_pictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Karaoke_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Karaoke_pictureBox.Image")));
            this.Karaoke_pictureBox.Location = new System.Drawing.Point(147, 76);
            this.Karaoke_pictureBox.Name = "Karaoke_pictureBox";
            this.Karaoke_pictureBox.Size = new System.Drawing.Size(475, 156);
            this.Karaoke_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Karaoke_pictureBox.TabIndex = 7;
            this.Karaoke_pictureBox.TabStop = false;
            // 
            // Execute_btn
            // 
            this.Execute_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execute_btn.Location = new System.Drawing.Point(340, 26);
            this.Execute_btn.Name = "Execute_btn";
            this.Execute_btn.Size = new System.Drawing.Size(90, 26);
            this.Execute_btn.TabIndex = 9;
            this.Execute_btn.Text = "Execute";
            this.Execute_btn.UseVisualStyleBackColor = true;
            this.Execute_btn.Click += new System.EventHandler(this.Execute_btn_Click);
            // 
            // Quit_btn
            // 
            this.Quit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit_btn.Location = new System.Drawing.Point(436, 26);
            this.Quit_btn.Name = "Quit_btn";
            this.Quit_btn.Size = new System.Drawing.Size(90, 26);
            this.Quit_btn.TabIndex = 11;
            this.Quit_btn.Text = "Quit";
            this.Quit_btn.UseVisualStyleBackColor = true;
            this.Quit_btn.Click += new System.EventHandler(this.Quit_btn_Click);
            // 
            // Input_panel
            // 
            this.Input_panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Input_panel.Controls.Add(this.Directory_btn);
            this.Input_panel.Controls.Add(this.TextFile_txtBox);
            this.Input_panel.Controls.Add(this.TextFile_btn);
            this.Input_panel.Controls.Add(this.TxtFile_lbl);
            this.Input_panel.Controls.Add(this.Directory_lbl);
            this.Input_panel.Controls.Add(this.Directory_txtBox);
            this.Input_panel.Location = new System.Drawing.Point(109, 272);
            this.Input_panel.Name = "Input_panel";
            this.Input_panel.Size = new System.Drawing.Size(529, 112);
            this.Input_panel.TabIndex = 12;
            // 
            // Execution_panel
            // 
            this.Execution_panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Execution_panel.Controls.Add(this.Execute_btn);
            this.Execution_panel.Controls.Add(this.Quit_btn);
            this.Execution_panel.Location = new System.Drawing.Point(109, 425);
            this.Execution_panel.Name = "Execution_panel";
            this.Execution_panel.Size = new System.Drawing.Size(529, 63);
            this.Execution_panel.TabIndex = 13;
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "C:\\Users\\championj\\source\\repos\\RenameKaraoke\\RenameKarakoke\\View\\HelpFile.html";
            // 
            // Title_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(762, 582);
            this.Controls.Add(this.Execution_panel);
            this.Controls.Add(this.Input_panel);
            this.Controls.Add(this.Karaoke_pictureBox);
            this.Controls.Add(this.Title_lbl);
            this.HelpButton = true;
            this.helpProvider.SetHelpKeyword(this, "Help.html");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Title_form";
            this.helpProvider.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renaming Wizard";
            ((System.ComponentModel.ISupportInitialize)(this.Karaoke_pictureBox)).EndInit();
            this.Input_panel.ResumeLayout(false);
            this.Input_panel.PerformLayout();
            this.Execution_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title_lbl;
        private System.Windows.Forms.Label TxtFile_lbl;
        private System.Windows.Forms.Label Directory_lbl;
        private System.Windows.Forms.TextBox TextFile_txtBox;
        private System.Windows.Forms.TextBox Directory_txtBox;
        private System.Windows.Forms.Button TextFile_btn;
        private System.Windows.Forms.Button Directory_btn;
        private PictureBox Karaoke_pictureBox;
        private Button Execute_btn;
        private Button Quit_btn;
        private Panel Input_panel;
        private Panel Execution_panel;
        private HelpProvider helpProvider;
    }
}

