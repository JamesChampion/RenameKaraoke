namespace RenameKarakoke
{
    partial class QueryTable_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryTable_form));
            this.DataTable_panel = new System.Windows.Forms.Panel();
            this.SongQueryDataTable_dataGridView = new System.Windows.Forms.DataGridView();
            this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SelectAll_btn = new System.Windows.Forms.Button();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.DataTable_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SongQueryDataTable_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable_panel
            // 
            this.DataTable_panel.Controls.Add(this.SongQueryDataTable_dataGridView);
            this.DataTable_panel.Location = new System.Drawing.Point(3, 5);
            this.DataTable_panel.Name = "DataTable_panel";
            this.DataTable_panel.Size = new System.Drawing.Size(756, 538);
            this.DataTable_panel.TabIndex = 0;
            // 
            // SongQueryDataTable_dataGridView
            // 
            this.SongQueryDataTable_dataGridView.AllowUserToAddRows = false;
            this.SongQueryDataTable_dataGridView.AutoGenerateColumns = false;
            this.SongQueryDataTable_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SongQueryDataTable_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SongQueryDataTable_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SongQueryDataTable_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBox,
            this.iDDataGridViewTextBoxColumn,
            this.artistDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn});
            this.SongQueryDataTable_dataGridView.DataSource = this.songBindingSource;
            this.SongQueryDataTable_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SongQueryDataTable_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.SongQueryDataTable_dataGridView.Name = "SongQueryDataTable_dataGridView";
            this.SongQueryDataTable_dataGridView.RowHeadersVisible = false;
            this.SongQueryDataTable_dataGridView.Size = new System.Drawing.Size(756, 538);
            this.SongQueryDataTable_dataGridView.TabIndex = 0;
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CheckBox.FalseValue = "0";
            this.CheckBox.FillWeight = 10F;
            this.CheckBox.HeaderText = "";
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CheckBox.ToolTipText = "Check A Box";
            this.CheckBox.TrueValue = "1";
            this.CheckBox.Width = 24;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // artistDataGridViewTextBoxColumn
            // 
            this.artistDataGridViewTextBoxColumn.DataPropertyName = "Artist";
            this.artistDataGridViewTextBoxColumn.HeaderText = "Artist";
            this.artistDataGridViewTextBoxColumn.Name = "artistDataGridViewTextBoxColumn";
            this.artistDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // songBindingSource
            // 
            this.songBindingSource.DataSource = typeof(RenameKarakoke.Song);
            // 
            // SelectAll_btn
            // 
            this.SelectAll_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectAll_btn.Location = new System.Drawing.Point(3, 549);
            this.SelectAll_btn.Name = "SelectAll_btn";
            this.SelectAll_btn.Size = new System.Drawing.Size(90, 26);
            this.SelectAll_btn.TabIndex = 7;
            this.SelectAll_btn.Text = "Select All";
            this.SelectAll_btn.UseVisualStyleBackColor = true;
            this.SelectAll_btn.Click += new System.EventHandler(this.SelectAll_btn_Click);
            // 
            // Submit_btn
            // 
            this.Submit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_btn.Location = new System.Drawing.Point(669, 549);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(90, 26);
            this.Submit_btn.TabIndex = 8;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_btn.Location = new System.Drawing.Point(99, 549);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(90, 26);
            this.Clear_btn.TabIndex = 9;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // QueryTable_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 582);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.SelectAll_btn);
            this.Controls.Add(this.DataTable_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QueryTable_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Files To Be Renamed";
            this.Load += new System.EventHandler(this.QueryTable_form_Load);
            this.DataTable_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SongQueryDataTable_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DataTable_panel;
        private System.Windows.Forms.DataGridView SongQueryDataTable_dataGridView;
        private System.Windows.Forms.BindingSource songBindingSource;
        private System.Windows.Forms.Button SelectAll_btn;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Clear_btn;
    }
}