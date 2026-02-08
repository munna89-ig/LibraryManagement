namespace LibraryManagement
{
    partial class PaymentReport
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
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.dgvPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1323, 638);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPayment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 632);
            this.panel1.TabIndex = 0;
            // 
            // dgvPayment
            // 
            this.dgvPayment.AllowUserToAddRows = false;
            this.dgvPayment.AllowUserToDeleteRows = false;
            this.dgvPayment.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvPID,
            this.dgvFID,
            this.dgvDate,
            this.dgvMethod,
            this.dgvAmount});
            this.dgvPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayment.Location = new System.Drawing.Point(0, 0);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.ReadOnly = true;
            this.dgvPayment.RowHeadersWidth = 51;
            this.dgvPayment.RowTemplate.Height = 24;
            this.dgvPayment.Size = new System.Drawing.Size(1090, 632);
            this.dgvPayment.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::LibraryManagement.Properties.Resources.Screenshot_2025_10_08_040459;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Controls.Add(this.cmbMethod);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1099, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 632);
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
            this.cmbMethod.Location = new System.Drawing.Point(26, 120);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(173, 24);
            this.cmbMethod.TabIndex = 0;
            // 
            // dgvPID
            // 
            this.dgvPID.DataPropertyName = "Payment_ID";
            this.dgvPID.HeaderText = "Payment ID";
            this.dgvPID.MinimumWidth = 6;
            this.dgvPID.Name = "dgvPID";
            this.dgvPID.ReadOnly = true;
            this.dgvPID.Width = 150;
            // 
            // dgvFID
            // 
            this.dgvFID.DataPropertyName = "Fine_ID";
            this.dgvFID.HeaderText = "Fine ID";
            this.dgvFID.MinimumWidth = 6;
            this.dgvFID.Name = "dgvFID";
            this.dgvFID.ReadOnly = true;
            this.dgvFID.Width = 150;
            // 
            // dgvDate
            // 
            this.dgvDate.DataPropertyName = "Payment_Date";
            this.dgvDate.HeaderText = "Payment Date";
            this.dgvDate.MinimumWidth = 6;
            this.dgvDate.Name = "dgvDate";
            this.dgvDate.ReadOnly = true;
            this.dgvDate.Width = 200;
            // 
            // dgvMethod
            // 
            this.dgvMethod.DataPropertyName = "Payment_Method";
            this.dgvMethod.HeaderText = "Payment Method";
            this.dgvMethod.MinimumWidth = 6;
            this.dgvMethod.Name = "dgvMethod";
            this.dgvMethod.ReadOnly = true;
            this.dgvMethod.Width = 200;
            // 
            // dgvAmount
            // 
            this.dgvAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvAmount.DataPropertyName = "Amount";
            this.dgvAmount.HeaderText = "Amount";
            this.dgvAmount.MinimumWidth = 6;
            this.dgvAmount.Name = "dgvAmount";
            this.dgvAmount.ReadOnly = true;
            // 
            // PaymentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 638);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PaymentReport";
            this.Text = "PaymentReport";
            this.Load += new System.EventHandler(this.PaymentReport_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cmbMethod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
    }
}