namespace LibraryManagement
{
    partial class Fine
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
            this.dgvFine = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.dgvFId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFine)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1334, 701);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvFine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 695);
            this.panel1.TabIndex = 0;
            // 
            // dgvFine
            // 
            this.dgvFine.AllowUserToAddRows = false;
            this.dgvFine.AllowUserToDeleteRows = false;
            this.dgvFine.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvFine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvFId,
            this.dgvBID,
            this.dgvUid,
            this.dgvName,
            this.dgvAmount,
            this.dgvStatus});
            this.dgvFine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFine.Location = new System.Drawing.Point(0, 0);
            this.dgvFine.Name = "dgvFine";
            this.dgvFine.ReadOnly = true;
            this.dgvFine.RowHeadersWidth = 51;
            this.dgvFine.RowTemplate.Height = 24;
            this.dgvFine.Size = new System.Drawing.Size(1101, 695);
            this.dgvFine.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.BackgroundImage = global::LibraryManagement.Properties.Resources.Screenshot_2025_10_08_040459;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Controls.Add(this.cmbType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1110, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 695);
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
            "Paid",
            "Unpaid"});
            this.cmbType.Location = new System.Drawing.Point(25, 122);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(173, 24);
            this.cmbType.TabIndex = 0;
            // 
            // dgvFId
            // 
            this.dgvFId.DataPropertyName = "Fine_ID";
            this.dgvFId.HeaderText = "Fine ID";
            this.dgvFId.MinimumWidth = 6;
            this.dgvFId.Name = "dgvFId";
            this.dgvFId.ReadOnly = true;
            this.dgvFId.Width = 125;
            // 
            // dgvBID
            // 
            this.dgvBID.DataPropertyName = "Borrow_ID";
            this.dgvBID.HeaderText = "Borrow ID";
            this.dgvBID.MinimumWidth = 6;
            this.dgvBID.Name = "dgvBID";
            this.dgvBID.ReadOnly = true;
            this.dgvBID.Width = 125;
            // 
            // dgvUid
            // 
            this.dgvUid.DataPropertyName = "User_ID";
            this.dgvUid.HeaderText = "Member ID";
            this.dgvUid.MinimumWidth = 6;
            this.dgvUid.Name = "dgvUid";
            this.dgvUid.ReadOnly = true;
            this.dgvUid.Width = 125;
            // 
            // dgvName
            // 
            this.dgvName.DataPropertyName = "Name";
            this.dgvName.HeaderText = "Member Name";
            this.dgvName.MinimumWidth = 6;
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            this.dgvName.Width = 200;
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
            this.dgvStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvStatus.DataPropertyName = "Status";
            this.dgvStatus.HeaderText = " Payment Status";
            this.dgvStatus.MinimumWidth = 6;
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.ReadOnly = true;
            // 
            // Fine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 701);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Fine";
            this.Text = "Fine";
            this.Load += new System.EventHandler(this.Fine_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFine)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvFine;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStatus;
    }
}