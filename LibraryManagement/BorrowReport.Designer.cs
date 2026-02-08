namespace LibraryManagement
{
    partial class BorrowReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.bid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1413, 686);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvBorrow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 680);
            this.panel1.TabIndex = 0;
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.AllowUserToAddRows = false;
            this.dgvBorrow.AllowUserToDeleteRows = false;
            this.dgvBorrow.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bid,
            this.uid,
            this.name,
            this.date,
            this.ddate,
            this.rdate,
            this.status});
            this.dgvBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBorrow.Location = new System.Drawing.Point(0, 0);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.ReadOnly = true;
            this.dgvBorrow.RowHeadersWidth = 51;
            this.dgvBorrow.RowTemplate.Height = 24;
            this.dgvBorrow.Size = new System.Drawing.Size(1180, 680);
            this.dgvBorrow.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::LibraryManagement.Properties.Resources.Screenshot_2025_10_08_040459;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Controls.Add(this.cmbType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1189, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 680);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(75, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(75, 168);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 32);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Accepted",
            "Rejected",
            "Returned",
            "Lost",
            "Pending"});
            this.cmbType.Location = new System.Drawing.Point(25, 122);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(173, 24);
            this.cmbType.TabIndex = 0;
            // 
            // bid
            // 
            this.bid.DataPropertyName = "Borrow_ID";
            this.bid.HeaderText = "Borrow ID";
            this.bid.MinimumWidth = 6;
            this.bid.Name = "bid";
            this.bid.ReadOnly = true;
            this.bid.Width = 125;
            // 
            // uid
            // 
            this.uid.DataPropertyName = "User_ID";
            this.uid.HeaderText = "Member ID";
            this.uid.MinimumWidth = 6;
            this.uid.Name = "uid";
            this.uid.ReadOnly = true;
            this.uid.Width = 125;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Member Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // date
            // 
            this.date.DataPropertyName = "Borrow_Date";
            this.date.HeaderText = "Borrow Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 170;
            // 
            // ddate
            // 
            this.ddate.DataPropertyName = "Due_Date";
            this.ddate.HeaderText = "Due Date";
            this.ddate.MinimumWidth = 6;
            this.ddate.Name = "ddate";
            this.ddate.ReadOnly = true;
            this.ddate.Width = 170;
            // 
            // rdate
            // 
            this.rdate.DataPropertyName = "Return_Date";
            this.rdate.HeaderText = "Return Date";
            this.rdate.MinimumWidth = 6;
            this.rdate.Name = "rdate";
            this.rdate.ReadOnly = true;
            this.rdate.Width = 170;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.DataPropertyName = "Borrow_Status";
            this.status.HeaderText = "Borrow Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // BorrowReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 686);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BorrowReport";
            this.Text = "BorrowReport";
            this.Load += new System.EventHandler(this.BorrowReport_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvBorrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn bid;
        private System.Windows.Forms.DataGridViewTextBoxColumn uid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}