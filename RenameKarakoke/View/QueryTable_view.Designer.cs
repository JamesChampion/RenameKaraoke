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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryTable_form));
            this.DataTable_panel = new System.Windows.Forms.Panel();
            this.Query_dataTableView = new System.Windows.Forms.DataGridView();
            this.SelectAll_btn = new System.Windows.Forms.Button();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Unzip_checkBox = new System.Windows.Forms.CheckBox();
            this.DataTable_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Query_dataTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable_panel
            // 
            this.DataTable_panel.Controls.Add(this.Query_dataTableView);
            this.DataTable_panel.Location = new System.Drawing.Point(3, 5);
            this.DataTable_panel.Name = "DataTable_panel";
            this.DataTable_panel.Size = new System.Drawing.Size(756, 538);
            this.DataTable_panel.TabIndex = 0;
            // 
            // Query_dataTableView
            // 
            this.Query_dataTableView.AllowUserToAddRows = false;
            this.Query_dataTableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Query_dataTableView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Query_dataTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Query_dataTableView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Query_dataTableView.Location = new System.Drawing.Point(0, 0);
            this.Query_dataTableView.Name = "Query_dataTableView";
            this.Query_dataTableView.RowHeadersVisible = false;
            this.Query_dataTableView.Size = new System.Drawing.Size(756, 538);
            this.Query_dataTableView.TabIndex = 0;
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
            // Unzip_checkBox
            // 
            this.Unzip_checkBox.AutoSize = true;
            this.Unzip_checkBox.Location = new System.Drawing.Point(195, 555);
            this.Unzip_checkBox.Name = "Unzip_checkBox";
            this.Unzip_checkBox.Size = new System.Drawing.Size(77, 17);
            this.Unzip_checkBox.TabIndex = 10;
            this.Unzip_checkBox.Text = "Unzip Files";
            this.Unzip_checkBox.UseVisualStyleBackColor = true;
            this.Unzip_checkBox.Visible = false;
            // 
            // QueryTable_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 582);
            this.Controls.Add(this.Unzip_checkBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.Query_dataTableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DataTable_panel;
        private System.Windows.Forms.DataGridView Query_dataTableView;
        private System.Windows.Forms.Button SelectAll_btn;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.CheckBox Unzip_checkBox;
    }
}