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
<<<<<<< HEAD
            this.SongMasterDataTable_dataGridView = new System.Windows.Forms.DataGridView();
=======
            this.SongDataTable_dataGridView = new System.Windows.Forms.DataGridView();
            this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
>>>>>>> aab5e9b4669314b9549fc5d37f0deb46ea440a9f
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
<<<<<<< HEAD
            this.DataTable_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SongMasterDataTable_dataGridView)).BeginInit();
=======
            this.Submit_btn = new System.Windows.Forms.Button();
            this.DataTable_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SongDataTable_dataGridView)).BeginInit();
>>>>>>> aab5e9b4669314b9549fc5d37f0deb46ea440a9f
            ((System.ComponentModel.ISupportInitialize)(this.songMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable_panel
            // 
<<<<<<< HEAD
            this.DataTable_panel.Controls.Add(this.SongMasterDataTable_dataGridView);
=======
            this.DataTable_panel.Controls.Add(this.SongDataTable_dataGridView);
>>>>>>> aab5e9b4669314b9549fc5d37f0deb46ea440a9f
            this.DataTable_panel.Location = new System.Drawing.Point(3, 5);
            this.DataTable_panel.Name = "DataTable_panel";
            this.DataTable_panel.Size = new System.Drawing.Size(756, 538);
            this.DataTable_panel.TabIndex = 0;
            // 
<<<<<<< HEAD
            // SongMasterDataTable_dataGridView
            // 
            this.SongMasterDataTable_dataGridView.AllowUserToAddRows = false;
            this.SongMasterDataTable_dataGridView.AutoGenerateColumns = false;
            this.SongMasterDataTable_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
=======
            // SongDataTable_dataGridView
            // 
            this.SongDataTable_dataGridView.AllowUserToAddRows = false;
            this.SongDataTable_dataGridView.AutoGenerateColumns = false;
            this.SongDataTable_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
>>>>>>> aab5e9b4669314b9549fc5d37f0deb46ea440a9f
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
<<<<<<< HEAD
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
=======
            this.SongDataTable_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SongDataTable_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SongDataTable_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBox,
            this.iDDataGridViewTextBoxColumn,
            this.artistDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn});
            this.SongDataTable_dataGridView.DataSource = this.songMasterBindingSource;
            this.SongDataTable_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SongDataTable_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.SongDataTable_dataGridView.Name = "SongDataTable_dataGridView";
            this.SongDataTable_dataGridView.RowHeadersVisible = false;
            this.SongDataTable_dataGridView.Size = new System.Drawing.Size(756, 538);
            this.SongDataTable_dataGridView.TabIndex = 0;
            this.SongDataTable_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SongDataTable_dataGridView_CellContentClick);
            this.SongDataTable_dataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SongDataTable_dataGridView_ColumnHeaderMouseClick);
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CheckBox.FalseValue = "0";
            this.CheckBox.FillWeight = 10F;
            this.CheckBox.HeaderText = "";
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CheckBox.ToolTipText = "Check A Box";
            this.CheckBox.TrueValue = "1";
            this.CheckBox.Width = 24;
>>>>>>> aab5e9b4669314b9549fc5d37f0deb46ea440a9f
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
            // 
<<<<<<< HEAD
=======
            // Submit_btn
            // 
            this.Submit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_btn.Location = new System.Drawing.Point(660, 549);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(90, 26);
            this.Submit_btn.TabIndex = 6;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
>>>>>>> aab5e9b4669314b9549fc5d37f0deb46ea440a9f
            // TextFileTable_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 582);
<<<<<<< HEAD
=======
            this.Controls.Add(this.Submit_btn);
>>>>>>> aab5e9b4669314b9549fc5d37f0deb46ea440a9f
            this.Controls.Add(this.DataTable_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TextFileTable_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master List";
            this.Load += new System.EventHandler(this.TextFileTable_form_Load);
            this.DataTable_panel.ResumeLayout(false);
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.SongMasterDataTable_dataGridView)).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.SongDataTable_dataGridView)).EndInit();
>>>>>>> aab5e9b4669314b9549fc5d37f0deb46ea440a9f
            ((System.ComponentModel.ISupportInitialize)(this.songMasterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DataTable_panel;
<<<<<<< HEAD
        private System.Windows.Forms.DataGridView SongMasterDataTable_dataGridView;
        private System.Windows.Forms.BindingSource songMasterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
=======
        private System.Windows.Forms.DataGridView SongDataTable_dataGridView;
        private System.Windows.Forms.BindingSource songMasterBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Submit_btn;
>>>>>>> aab5e9b4669314b9549fc5d37f0deb46ea440a9f
    }
}