namespace LibraryManagement
{
    partial class Return
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBorrowID = new System.Windows.Forms.TextBox();
            this.btnLost = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvReturn = new System.Windows.Forms.DataGridView();
            this.dgvBorrowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.65271F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.34729F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1352, 573);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.BackgroundImage = global::LibraryManagement.Properties.Resources._1223333;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtBookId);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtBorrowID);
            this.panel2.Controls.Add(this.btnLost);
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 362);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1346, 208);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Book ID";
            // 
            // txtBookId
            // 
            this.txtBookId.BackColor = System.Drawing.Color.White;
            this.txtBookId.Location = new System.Drawing.Point(60, 52);
            this.txtBookId.Multiline = true;
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.ReadOnly = true;
            this.txtBookId.Size = new System.Drawing.Size(167, 36);
            this.txtBookId.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(203, 135);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(97, 35);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Borrow ID";
            // 
            // txtBorrowID
            // 
            this.txtBorrowID.BackColor = System.Drawing.Color.White;
            this.txtBorrowID.Location = new System.Drawing.Point(269, 52);
            this.txtBorrowID.Multiline = true;
            this.txtBorrowID.Name = "txtBorrowID";
            this.txtBorrowID.ReadOnly = true;
            this.txtBorrowID.Size = new System.Drawing.Size(167, 36);
            this.txtBorrowID.TabIndex = 2;
            // 
            // btnLost
            // 
            this.btnLost.Location = new System.Drawing.Point(693, 52);
            this.btnLost.Name = "btnLost";
            this.btnLost.Size = new System.Drawing.Size(114, 50);
            this.btnLost.TabIndex = 1;
            this.btnLost.Text = "Lost Book";
            this.btnLost.UseVisualStyleBackColor = true;
            this.btnLost.Click += new System.EventHandler(this.btnLost_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(547, 52);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(105, 50);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Return Book";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvReturn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 353);
            this.panel1.TabIndex = 0;
            // 
            // dgvReturn
            // 
            this.dgvReturn.AllowUserToAddRows = false;
            this.dgvReturn.AllowUserToDeleteRows = false;
            this.dgvReturn.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvBorrowID,
            this.dgvTitle,
            this.dgvAuthor,
            this.dgvPublisher,
            this.dgvISBN,
            this.dgvBDate,
            this.dgvDue,
            this.dgvStatus});
            this.dgvReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReturn.Location = new System.Drawing.Point(0, 0);
            this.dgvReturn.Name = "dgvReturn";
            this.dgvReturn.ReadOnly = true;
            this.dgvReturn.RowHeadersWidth = 51;
            this.dgvReturn.RowTemplate.Height = 24;
            this.dgvReturn.Size = new System.Drawing.Size(1344, 351);
            this.dgvReturn.TabIndex = 0;
            this.dgvReturn.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReturn_CellDoubleClick);
            // 
            // dgvBorrowID
            // 
            this.dgvBorrowID.DataPropertyName = "Borrow_ID";
            this.dgvBorrowID.HeaderText = "Borrow ID";
            this.dgvBorrowID.MinimumWidth = 6;
            this.dgvBorrowID.Name = "dgvBorrowID";
            this.dgvBorrowID.ReadOnly = true;
            this.dgvBorrowID.Width = 125;
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
            this.dgvAuthor.Width = 200;
            // 
            // dgvPublisher
            // 
            this.dgvPublisher.DataPropertyName = "Publisher";
            this.dgvPublisher.HeaderText = "Publisher";
            this.dgvPublisher.MinimumWidth = 6;
            this.dgvPublisher.Name = "dgvPublisher";
            this.dgvPublisher.ReadOnly = true;
            this.dgvPublisher.Width = 200;
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
            // dgvBDate
            // 
            this.dgvBDate.DataPropertyName = "Borrow_Date";
            this.dgvBDate.HeaderText = "Borrow Date";
            this.dgvBDate.MinimumWidth = 6;
            this.dgvBDate.Name = "dgvBDate";
            this.dgvBDate.ReadOnly = true;
            this.dgvBDate.Width = 125;
            // 
            // dgvDue
            // 
            this.dgvDue.DataPropertyName = "Due_Date";
            this.dgvDue.HeaderText = "Due Date";
            this.dgvDue.MinimumWidth = 6;
            this.dgvDue.Name = "dgvDue";
            this.dgvDue.ReadOnly = true;
            this.dgvDue.Width = 125;
            // 
            // dgvStatus
            // 
            this.dgvStatus.DataPropertyName = "Borrow_Status";
            this.dgvStatus.HeaderText = "Borrow Status";
            this.dgvStatus.MinimumWidth = 6;
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.ReadOnly = true;
            this.dgvStatus.Width = 125;
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 573);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Return";
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvReturn;
        private System.Windows.Forms.Button btnLost;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtBorrowID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBorrowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStatus;
    }
}