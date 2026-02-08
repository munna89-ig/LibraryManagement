namespace LibraryManagement
{
    partial class Reservation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.dgvReservation = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.btnReject = new MetroFramework.Controls.MetroButton();
            this.btnAccept = new MetroFramework.Controls.MetroButton();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.dgvMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.31058F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.68942F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1240, 586);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.dgvReservation);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1234, 365);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnRefresh);
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
            this.metroPanel2.Location = new System.Drawing.Point(3, 374);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1234, 209);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // dgvReservation
            // 
            this.dgvReservation.AllowUserToAddRows = false;
            this.dgvReservation.AllowUserToDeleteRows = false;
            this.dgvReservation.AllowUserToResizeRows = false;
            this.dgvReservation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReservation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReservation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMID,
            this.dgvBID,
            this.dgvRDate,
            this.dgvStatus,
            this.dgvTitle,
            this.dgvRID,
            this.dgvMName,
            this.dgcQuantity});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservation.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservation.EnableHeadersVisualStyles = false;
            this.dgvReservation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvReservation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvReservation.Location = new System.Drawing.Point(0, 0);
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.ReadOnly = true;
            this.dgvReservation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservation.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReservation.RowHeadersWidth = 51;
            this.dgvReservation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReservation.RowTemplate.Height = 24;
            this.dgvReservation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservation.Size = new System.Drawing.Size(1234, 365);
            this.dgvReservation.TabIndex = 2;
            this.dgvReservation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            this.dgvReservation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservation_CellDoubleClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(456, 44);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(113, 20);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Reservation ID";
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
            this.txtID.Location = new System.Drawing.Point(624, 35);
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
            this.txtID.TabIndex = 13;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtSearch.Location = new System.Drawing.Point(11, 54);
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
            this.txtSearch.TabIndex = 10;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search here....";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(105, 103);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 36);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(778, 138);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(107, 36);
            this.btnReject.TabIndex = 11;
            this.btnReject.Text = "Reject";
            this.btnReject.UseSelectable = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(641, 138);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(107, 36);
            this.btnAccept.TabIndex = 9;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseSelectable = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(504, 138);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(107, 36);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvMID
            // 
            this.dgvMID.DataPropertyName = "User_ID";
            this.dgvMID.HeaderText = "Member ID";
            this.dgvMID.MinimumWidth = 6;
            this.dgvMID.Name = "dgvMID";
            this.dgvMID.ReadOnly = true;
            this.dgvMID.Width = 125;
            // 
            // dgvBID
            // 
            this.dgvBID.DataPropertyName = "Book_ID";
            this.dgvBID.HeaderText = "Book ID";
            this.dgvBID.MinimumWidth = 6;
            this.dgvBID.Name = "dgvBID";
            this.dgvBID.ReadOnly = true;
            this.dgvBID.Width = 125;
            // 
            // dgvRDate
            // 
            this.dgvRDate.DataPropertyName = "Reservation_Date";
            this.dgvRDate.HeaderText = "Reservation Date";
            this.dgvRDate.MinimumWidth = 6;
            this.dgvRDate.Name = "dgvRDate";
            this.dgvRDate.ReadOnly = true;
            this.dgvRDate.Width = 125;
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
            // dgvTitle
            // 
            this.dgvTitle.DataPropertyName = "Title";
            this.dgvTitle.HeaderText = "Book Name";
            this.dgvTitle.MinimumWidth = 6;
            this.dgvTitle.Name = "dgvTitle";
            this.dgvTitle.ReadOnly = true;
            this.dgvTitle.Width = 125;
            // 
            // dgvRID
            // 
            this.dgvRID.DataPropertyName = "Reservation_ID";
            this.dgvRID.HeaderText = "Reservation ID";
            this.dgvRID.MinimumWidth = 6;
            this.dgvRID.Name = "dgvRID";
            this.dgvRID.ReadOnly = true;
            this.dgvRID.Width = 125;
            // 
            // dgvMName
            // 
            this.dgvMName.DataPropertyName = "Name";
            this.dgvMName.HeaderText = "Member Name";
            this.dgvMName.MinimumWidth = 6;
            this.dgvMName.Name = "dgvMName";
            this.dgvMName.ReadOnly = true;
            this.dgvMName.Width = 125;
            // 
            // dgcQuantity
            // 
            this.dgcQuantity.DataPropertyName = "Book_Quantity";
            this.dgcQuantity.HeaderText = "Book Quantity";
            this.dgcQuantity.MinimumWidth = 6;
            this.dgcQuantity.Name = "dgcQuantity";
            this.dgcQuantity.ReadOnly = true;
            this.dgcQuantity.Width = 125;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 666);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid dgvReservation;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtID;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroButton btnReject;
        private MetroFramework.Controls.MetroButton btnAccept;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcQuantity;
    }
}