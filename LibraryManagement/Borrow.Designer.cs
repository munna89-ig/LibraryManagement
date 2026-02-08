namespace LibraryManagement
{
    partial class Borrow
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.dgvBorrow = new MetroFramework.Controls.MetroGrid();
            this.btnAccept = new MetroFramework.Controls.MetroButton();
            this.btnReject = new MetroFramework.Controls.MetroButton();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtBook_ID = new MetroFramework.Controls.MetroTextBox();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.dgvBorrow_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBorrow_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDue_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvM_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvB_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStaus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.metroPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.71329F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.28671F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1300, 591);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.dgvBorrow);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1294, 358);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnRefresh);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.txtBook_ID);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.txtID);
            this.metroPanel2.Controls.Add(this.txtSearch);
            this.metroPanel2.Controls.Add(this.btnSearch);
            this.metroPanel2.Controls.Add(this.btnReject);
            this.metroPanel2.Controls.Add(this.btnAccept);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 367);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1294, 221);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.AllowUserToAddRows = false;
            this.dgvBorrow.AllowUserToDeleteRows = false;
            this.dgvBorrow.AllowUserToResizeRows = false;
            this.dgvBorrow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBorrow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBorrow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBorrow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvBorrow_ID,
            this.dgvBorrow_Date,
            this.dgvDue_Date,
            this.dgvM_ID,
            this.dgvB_ID,
            this.dgvStaus,
            this.dgvBook,
            this.dgvQuantity});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBorrow.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBorrow.EnableHeadersVisualStyles = false;
            this.dgvBorrow.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvBorrow.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBorrow.Location = new System.Drawing.Point(0, 0);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.ReadOnly = true;
            this.dgvBorrow.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrow.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBorrow.RowHeadersWidth = 51;
            this.dgvBorrow.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBorrow.RowTemplate.Height = 24;
            this.dgvBorrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrow.Size = new System.Drawing.Size(1294, 358);
            this.dgvBorrow.TabIndex = 2;
            this.dgvBorrow.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrow_CellDoubleClick);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(648, 127);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(107, 36);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseSelectable = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(797, 127);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(107, 36);
            this.btnReject.TabIndex = 3;
            this.btnReject.Text = "Reject";
            this.btnReject.UseSelectable = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(189, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 36);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(273, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(95, 43);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search here....";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(303, 32);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search here....";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(157, 2);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(681, 24);
            this.txtID.MaxLength = 32767;
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ReadOnly = true;
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(193, 38);
            this.txtID.TabIndex = 5;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(557, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 20);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Borrow ID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(975, 33);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 20);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Book ID";
            // 
            // txtBook_ID
            // 
            // 
            // 
            // 
            this.txtBook_ID.CustomButton.Image = null;
            this.txtBook_ID.CustomButton.Location = new System.Drawing.Point(157, 2);
            this.txtBook_ID.CustomButton.Name = "";
            this.txtBook_ID.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtBook_ID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBook_ID.CustomButton.TabIndex = 1;
            this.txtBook_ID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBook_ID.CustomButton.UseSelectable = true;
            this.txtBook_ID.CustomButton.Visible = false;
            this.txtBook_ID.Lines = new string[0];
            this.txtBook_ID.Location = new System.Drawing.Point(1078, 24);
            this.txtBook_ID.MaxLength = 32767;
            this.txtBook_ID.Multiline = true;
            this.txtBook_ID.Name = "txtBook_ID";
            this.txtBook_ID.PasswordChar = '\0';
            this.txtBook_ID.ReadOnly = true;
            this.txtBook_ID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBook_ID.SelectedText = "";
            this.txtBook_ID.SelectionLength = 0;
            this.txtBook_ID.SelectionStart = 0;
            this.txtBook_ID.ShortcutsEnabled = true;
            this.txtBook_ID.Size = new System.Drawing.Size(193, 38);
            this.txtBook_ID.TabIndex = 7;
            this.txtBook_ID.UseSelectable = true;
            this.txtBook_ID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBook_ID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(507, 127);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(107, 36);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvBorrow_ID
            // 
            this.dgvBorrow_ID.DataPropertyName = "Borrow_ID";
            this.dgvBorrow_ID.HeaderText = "Borrow ID";
            this.dgvBorrow_ID.MinimumWidth = 6;
            this.dgvBorrow_ID.Name = "dgvBorrow_ID";
            this.dgvBorrow_ID.ReadOnly = true;
            this.dgvBorrow_ID.Width = 125;
            // 
            // dgvBorrow_Date
            // 
            this.dgvBorrow_Date.DataPropertyName = "Borrow_Date";
            this.dgvBorrow_Date.HeaderText = "Borrow Date";
            this.dgvBorrow_Date.MinimumWidth = 6;
            this.dgvBorrow_Date.Name = "dgvBorrow_Date";
            this.dgvBorrow_Date.ReadOnly = true;
            this.dgvBorrow_Date.Width = 125;
            // 
            // dgvDue_Date
            // 
            this.dgvDue_Date.DataPropertyName = "Due_Date";
            this.dgvDue_Date.HeaderText = "Due Date";
            this.dgvDue_Date.MinimumWidth = 6;
            this.dgvDue_Date.Name = "dgvDue_Date";
            this.dgvDue_Date.ReadOnly = true;
            this.dgvDue_Date.Width = 125;
            // 
            // dgvM_ID
            // 
            this.dgvM_ID.DataPropertyName = "User_ID";
            this.dgvM_ID.HeaderText = "Member ID";
            this.dgvM_ID.MinimumWidth = 6;
            this.dgvM_ID.Name = "dgvM_ID";
            this.dgvM_ID.ReadOnly = true;
            this.dgvM_ID.Width = 125;
            // 
            // dgvB_ID
            // 
            this.dgvB_ID.DataPropertyName = "Book_ID";
            this.dgvB_ID.HeaderText = "Book_ID";
            this.dgvB_ID.MinimumWidth = 6;
            this.dgvB_ID.Name = "dgvB_ID";
            this.dgvB_ID.ReadOnly = true;
            this.dgvB_ID.Width = 125;
            // 
            // dgvStaus
            // 
            this.dgvStaus.DataPropertyName = "Borrow_Status";
            this.dgvStaus.HeaderText = "Borrow Status";
            this.dgvStaus.MinimumWidth = 6;
            this.dgvStaus.Name = "dgvStaus";
            this.dgvStaus.ReadOnly = true;
            this.dgvStaus.Width = 125;
            // 
            // dgvBook
            // 
            this.dgvBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvBook.DataPropertyName = "Title";
            this.dgvBook.HeaderText = "Book Name";
            this.dgvBook.MinimumWidth = 6;
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            // 
            // dgvQuantity
            // 
            this.dgvQuantity.DataPropertyName = "Book_Quantity";
            this.dgvQuantity.HeaderText = "Book Quantity";
            this.dgvQuantity.MinimumWidth = 6;
            this.dgvQuantity.Name = "dgvQuantity";
            this.dgvQuantity.ReadOnly = true;
            this.dgvQuantity.Width = 150;
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 671);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Borrow";
            this.Text = "Borrow";
            this.Load += new System.EventHandler(this.Borrow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroButton btnReject;
        private MetroFramework.Controls.MetroButton btnAccept;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid dgvBorrow;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtBook_ID;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBorrow_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBorrow_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDue_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvM_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvB_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStaus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuantity;
    }
}