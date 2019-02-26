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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextFileTable_Form));
            this.DataTable_panel = new System.Windows.Forms.Panel();
            this.SongMasterDataTable_dataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SongMasterDataTable_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable_panel
            // 
            this.DataTable_panel.Controls.Add(this.SongMasterDataTable_dataGridView);
            this.DataTable_panel.Location = new System.Drawing.Point(3, 5);
            this.DataTable_panel.Name = "DataTable_panel";
            this.DataTable_panel.Size = new System.Drawing.Size(756, 538);
            this.DataTable_panel.TabIndex = 0;
            // 
            // SongMasterDataTable_dataGridView
            // 
            this.SongMasterDataTable_dataGridView.AllowUserToAddRows = false;
            this.SongMasterDataTable_dataGridView.AutoGenerateColumns = false;
            this.SongMasterDataTable_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SongMasterDataTable_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SongMasterDataTable_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SongMasterDataTable_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.artistDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn});
            this.SongMasterDataTable_dataGridView.DataSource = this.songMasterBindingSource;
            this.SongMasterDataTable_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SongMasterDataTable_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.SongMasterDataTable_dataGridView.Name = "SongMasterDataTable_dataGridView";
            this.SongMasterDataTable_dataGridView.RowHeadersVisible = false;
            this.SongMasterDataTable_dataGridView.Size = new System.Drawing.Size(756, 538);
            this.SongMasterDataTable_dataGridView.TabIndex = 0;
            this.SongMasterDataTable_dataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SongMasterDataTable_dataGridView_ColumnHeaderMouseClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // artistDataGridViewTextBoxColumn
            // 
            this.artistDataGridViewTextBoxColumn.DataPropertyName = "Artist";
            this.artistDataGridViewTextBoxColumn.HeaderText = "Artist";
            this.artistDataGridViewTextBoxColumn.Name = "artistDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // songMasterBindingSource
            // 
            this.songMasterBindingSource.DataSource = typeof(RenameKarakoke.Song);
            this.songMasterBindingSource.Sort = "Title";
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TextFileTable_Form_FormClosed);
            this.Load += new System.EventHandler(this.TextFileTable_form_Load);
            this.DataTable_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SongMasterDataTable_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songMasterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DataTable_panel;
        private System.Windows.Forms.DataGridView SongMasterDataTable_dataGridView;
        private System.Windows.Forms.BindingSource songMasterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
    }
}