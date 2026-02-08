namespace LibraryManagement
{
    partial class Member
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvbookinfo = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAvailableStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbookinfo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1428, 725);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::LibraryManagement.Properties.Resources.Screenshot_2025_10_08_040459;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnBorrow);
            this.panel5.Controls.Add(this.btnReserve);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(1165, 78);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(260, 644);
            this.panel5.TabIndex = 3;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.Location = new System.Drawing.Point(22, 42);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(228, 50);
            this.btnBorrow.TabIndex = 0;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.Location = new System.Drawing.Point(25, 123);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(225, 50);
            this.btnReserve.TabIndex = 1;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvbookinfo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1156, 644);
            this.panel3.TabIndex = 2;
            // 
            // dgvbookinfo
            // 
            this.dgvbookinfo.AllowUserToAddRows = false;
            this.dgvbookinfo.AllowUserToDeleteRows = false;
            this.dgvbookinfo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvbookinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbookinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvBookID,
            this.dgvTitle,
            this.dgvAuthor,
            this.dgvPublisher,
            this.dgvISBN,
            this.dgvAvailableStatus,
            this.dgvSCName,
            this.dgvQuantity});
            this.dgvbookinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvbookinfo.Location = new System.Drawing.Point(0, 0);
            this.dgvbookinfo.Name = "dgvbookinfo";
            this.dgvbookinfo.ReadOnly = true;
            this.dgvbookinfo.RowHeadersWidth = 51;
            this.dgvbookinfo.RowTemplate.Height = 24;
            this.dgvbookinfo.Size = new System.Drawing.Size(1154, 642);
            this.dgvbookinfo.TabIndex = 0;
            this.dgvbookinfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbookinfo_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1165, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 69);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::LibraryManagement.Properties.Resources._1223333;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtBookID);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(260, 69);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book ID";
            // 
            // txtBookID
            // 
            this.txtBookID.BackColor = System.Drawing.Color.White;
            this.txtBookID.Location = new System.Drawing.Point(109, 13);
            this.txtBookID.Multiline = true;
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.ReadOnly = true;
            this.txtBookID.Size = new System.Drawing.Size(125, 33);
            this.txtBookID.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::LibraryManagement.Properties.Resources._1223333;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 69);
            this.panel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(82, 17);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(416, 33);
            this.txtSearch.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(680, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 45);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(545, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 45);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvBookID
            // 
            this.dgvBookID.DataPropertyName = "Book_ID";
            this.dgvBookID.HeaderText = "Book ID";
            this.dgvBookID.MinimumWidth = 6;
            this.dgvBookID.Name = "dgvBookID";
            this.dgvBookID.ReadOnly = true;
            this.dgvBookID.Width = 125;
            // 
            // dgvTitle
            // 
            this.dgvTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTitle.DataPropertyName = "Title";
            this.dgvTitle.HeaderText = "Title";
            this.dgvTitle.MinimumWidth = 6;
            this.dgvTitle.Name = "dgvTitle";
            this.dgvTitle.ReadOnly = true;
            // 
            // dgvAuthor
            // 
            this.dgvAuthor.DataPropertyName = "Author";
            this.dgvAuthor.HeaderText = "Author";
            this.dgvAuthor.MinimumWidth = 6;
            this.dgvAuthor.Name = "dgvAuthor";
            this.dgvAuthor.ReadOnly = true;
            this.dgvAuthor.Width = 170;
            // 
            // dgvPublisher
            // 
            this.dgvPublisher.DataPropertyName = "Publisher";
            this.dgvPublisher.HeaderText = "Publisher";
            this.dgvPublisher.MinimumWidth = 6;
            this.dgvPublisher.Name = "dgvPublisher";
            this.dgvPublisher.ReadOnly = true;
            this.dgvPublisher.Width = 170;
            // 
            // dgvISBN
            // 
            this.dgvISBN.DataPropertyName = "ISBN";
            this.dgvISBN.HeaderText = "ISBN";
            this.dgvISBN.MinimumWidth = 6;
            this.dgvISBN.Name = "dgvISBN";
            this.dgvISBN.ReadOnly = true;
            this.dgvISBN.Width = 125;
            // 
            // dgvAvailableStatus
            // 
            this.dgvAvailableStatus.DataPropertyName = "Available_Status";
            this.dgvAvailableStatus.HeaderText = "Available Staus";
            this.dgvAvailableStatus.MinimumWidth = 6;
            this.dgvAvailableStatus.Name = "dgvAvailableStatus";
            this.dgvAvailableStatus.ReadOnly = true;
            this.dgvAvailableStatus.Width = 125;
            // 
            // dgvSCName
            // 
            this.dgvSCName.DataPropertyName = "SubCategory_Name";
            this.dgvSCName.HeaderText = "Type";
            this.dgvSCName.MinimumWidth = 6;
            this.dgvSCName.Name = "dgvSCName";
            this.dgvSCName.ReadOnly = true;
            this.dgvSCName.Width = 125;
            // 
            // dgvQuantity
            // 
            this.dgvQuantity.DataPropertyName = "Book_Quantity";
            this.dgvQuantity.HeaderText = "Book Quantity";
            this.dgvQuantity.MinimumWidth = 6;
            this.dgvQuantity.Name = "dgvQuantity";
            this.dgvQuantity.ReadOnly = true;
            this.dgvQuantity.Width = 125;
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 725);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Member";
            this.Text = "Member";
            this.Load += new System.EventHandler(this.Member_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbookinfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvbookinfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAvailableStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuantity;
    }
}