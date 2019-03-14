namespace RenameKarakoke
{
    partial class TextFileTable_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextFileTable_Form));
            this.DataTable_panel = new System.Windows.Forms.Panel();
            this.MasterSongList_dataGridView = new System.Windows.Forms.DataGridView();
            this.DataTable_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MasterSongList_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable_panel
            // 
            this.DataTable_panel.Controls.Add(this.MasterSongList_dataGridView);
            this.DataTable_panel.Location = new System.Drawing.Point(3, 5);
            this.DataTable_panel.Name = "DataTable_panel";
            this.DataTable_panel.Size = new System.Drawing.Size(756, 538);
            this.DataTable_panel.TabIndex = 0;
            // 
            // MasterSongList_dataGridView
            // 
            this.MasterSongList_dataGridView.AllowUserToAddRows = false;
            this.MasterSongList_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MasterSongList_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MasterSongList_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MasterSongList_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MasterSongList_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.MasterSongList_dataGridView.Name = "MasterSongList_dataGridView";
            this.MasterSongList_dataGridView.RowHeadersVisible = false;
            this.MasterSongList_dataGridView.Size = new System.Drawing.Size(756, 538);
            this.MasterSongList_dataGridView.TabIndex = 0;
            // 
            // TextFileTable_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 582);
            this.Controls.Add(this.DataTable_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TextFileTable_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master List";
            this.Load += new System.EventHandler(this.TextFileTable_form_Load);
            this.DataTable_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MasterSongList_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DataTable_panel;
        private System.Windows.Forms.DataGridView MasterSongList_dataGridView;
    }
}