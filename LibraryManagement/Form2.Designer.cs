namespace LibraryManagement
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnInsert = new MetroFramework.Controls.MetroButton();
            this.txtCategoryName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCategoryID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dgvCategory = new MetroFramework.Controls.MetroGrid();
            this.dgvCategory_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCategory_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.metroPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.82353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1332, 681);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackgroundImage = global::LibraryManagement.Properties.Resources._1223333;
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.btnRefresh);
            this.metroPanel2.Controls.Add(this.txtSearch);
            this.metroPanel2.Controls.Add(this.btnSearch);
            this.metroPanel2.Controls.Add(this.btnUpdate);
            this.metroPanel2.Controls.Add(this.btnInsert);
            this.metroPanel2.Controls.Add(this.txtCategoryName);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.txtCategoryID);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 403);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1326, 275);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(527, 168);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 50);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(32, 111);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search Here....";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(212, 40);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search Here....";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(100, 168);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 40);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(740, 168);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 50);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(631, 168);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(86, 50);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseSelectable = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtCategoryName
            // 
            // 
            // 
            // 
            this.txtCategoryName.CustomButton.Image = null;
            this.txtCategoryName.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.txtCategoryName.CustomButton.Name = "";
            this.txtCategoryName.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtCategoryName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCategoryName.CustomButton.TabIndex = 1;
            this.txtCategoryName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCategoryName.CustomButton.UseSelectable = true;
            this.txtCategoryName.CustomButton.Visible = false;
            this.txtCategoryName.Lines = new string[0];
            this.txtCategoryName.Location = new System.Drawing.Point(711, 111);
            this.txtCategoryName.MaxLength = 32767;
            this.txtCategoryName.Multiline = true;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.PasswordChar = '\0';
            this.txtCategoryName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCategoryName.SelectedText = "";
            this.txtCategoryName.SelectionLength = 0;
            this.txtCategoryName.SelectionStart = 0;
            this.txtCategoryName.ShortcutsEnabled = true;
            this.txtCategoryName.Size = new System.Drawing.Size(212, 40);
            this.txtCategoryName.TabIndex = 5;
            this.txtCategoryName.UseSelectable = true;
            this.txtCategoryName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCategoryName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(740, 64);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(145, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Category Name";
            // 
            // txtCategoryID
            // 
            // 
            // 
            // 
            this.txtCategoryID.CustomButton.Image = null;
            this.txtCategoryID.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.txtCategoryID.CustomButton.Name = "";
            this.txtCategoryID.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtCategoryID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCategoryID.CustomButton.TabIndex = 1;
            this.txtCategoryID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCategoryID.CustomButton.UseSelectable = true;
            this.txtCategoryID.CustomButton.Visible = false;
            this.txtCategoryID.Lines = new string[0];
            this.txtCategoryID.Location = new System.Drawing.Point(430, 111);
            this.txtCategoryID.MaxLength = 32767;
            this.txtCategoryID.Multiline = true;
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.PasswordChar = '\0';
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCategoryID.SelectedText = "";
            this.txtCategoryID.SelectionLength = 0;
            this.txtCategoryID.SelectionStart = 0;
            this.txtCategoryID.ShortcutsEnabled = true;
            this.txtCategoryID.Size = new System.Drawing.Size(212, 40);
            this.txtCategoryID.TabIndex = 3;
            this.txtCategoryID.UseSelectable = true;
            this.txtCategoryID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCategoryID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(447, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Category ID";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.dgvCategory);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1326, 394);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AllowUserToDeleteRows = false;
            this.dgvCategory.AllowUserToResizeRows = false;
            this.dgvCategory.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCategory_ID,
            this.dgvCategory_Name});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategory.EnableHeadersVisualStyles = false;
            this.dgvCategory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCategory.Location = new System.Drawing.Point(0, 0);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategory.RowHeadersWidth = 51;
            this.dgvCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCategory.RowTemplate.Height = 24;
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.Size = new System.Drawing.Size(1324, 392);
            this.dgvCategory.TabIndex = 2;
            this.dgvCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellContentClick);
            this.dgvCategory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellDoubleClick);
            // 
            // dgvCategory_ID
            // 
            this.dgvCategory_ID.DataPropertyName = "Category_ID";
            this.dgvCategory_ID.HeaderText = "Category ID";
            this.dgvCategory_ID.MinimumWidth = 6;
            this.dgvCategory_ID.Name = "dgvCategory_ID";
            this.dgvCategory_ID.ReadOnly = true;
            this.dgvCategory_ID.Width = 125;
            // 
            // dgvCategory_Name
            // 
            this.dgvCategory_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCategory_Name.DataPropertyName = "Category_Name";
            this.dgvCategory_Name.HeaderText = "Category Name";
            this.dgvCategory_Name.MinimumWidth = 6;
            this.dgvCategory_Name.Name = "dgvCategory_Name";
            this.dgvCategory_Name.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "CATEGORY";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid dgvCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCategory_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCategory_Name;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnInsert;
        private MetroFramework.Controls.MetroTextBox txtCategoryName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtCategoryID;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroButton btnRefresh;
    }
}