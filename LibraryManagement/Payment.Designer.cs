namespace LibraryManagement
{
    partial class Payment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.dgvFineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBorrowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.76762F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.23238F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 667);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 649);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1364, 15);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvPayment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 413);
            this.panel1.TabIndex = 1;
            // 
            // dgvPayment
            // 
            this.dgvPayment.AllowUserToAddRows = false;
            this.dgvPayment.AllowUserToDeleteRows = false;
            this.dgvPayment.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvFineID,
            this.dgvBorrowID,
            this.dgvAmount,
            this.dgvStatus,
            this.dgvReason});
            this.dgvPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayment.Location = new System.Drawing.Point(0, 0);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.ReadOnly = true;
            this.dgvPayment.RowHeadersWidth = 51;
            this.dgvPayment.RowTemplate.Height = 24;
            this.dgvPayment.Size = new System.Drawing.Size(1362, 411);
            this.dgvPayment.TabIndex = 0;
            this.dgvPayment.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayment_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::LibraryManagement.Properties.Resources._1223333;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtFine);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.btnPay);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cmbMethod);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 422);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1364, 221);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fine ID";
            // 
            // txtFine
            // 
            this.txtFine.Location = new System.Drawing.Point(151, 65);
            this.txtFine.Multiline = true;
            this.txtFine.Name = "txtFine";
            this.txtFine.ReadOnly = true;
            this.txtFine.Size = new System.Drawing.Size(147, 35);
            this.txtFine.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(430, 65);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 44);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(587, 65);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(100, 44);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(767, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Method";
            // 
            // cmbMethod
            // 
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Items.AddRange(new object[] {
            "Cash",
            "Bkash",
            "Nagad",
            "Upay",
            "Rocket",
            "Celfin"});
            this.cmbMethod.Location = new System.Drawing.Point(851, 76);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(159, 24);
            this.cmbMethod.TabIndex = 0;
            // 
            // dgvFineID
            // 
            this.dgvFineID.DataPropertyName = "Fine_ID";
            this.dgvFineID.HeaderText = "Fine ID";
            this.dgvFineID.MinimumWidth = 6;
            this.dgvFineID.Name = "dgvFineID";
            this.dgvFineID.ReadOnly = true;
            this.dgvFineID.Width = 125;
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
            // dgvAmount
            // 
            this.dgvAmount.DataPropertyName = "Amount";
            this.dgvAmount.HeaderText = "Amount";
            this.dgvAmount.MinimumWidth = 6;
            this.dgvAmount.Name = "dgvAmount";
            this.dgvAmount.ReadOnly = true;
            this.dgvAmount.Width = 125;
            // 
            // dgvStatus
            // 
            this.dgvStatus.DataPropertyName = "Status";
            this.dgvStatus.HeaderText = "Status";
            this.dgvStatus.MinimumWidth = 6;
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.ReadOnly = true;
            this.dgvStatus.Width = 125;
            // 
            // dgvReason
            // 
            this.dgvReason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvReason.DataPropertyName = "Reason";
            this.dgvReason.HeaderText = "Reason";
            this.dgvReason.MinimumWidth = 6;
            this.dgvReason.Name = "dgvReason";
            this.dgvReason.ReadOnly = true;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 667);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMethod;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBorrowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReason;
    }
}