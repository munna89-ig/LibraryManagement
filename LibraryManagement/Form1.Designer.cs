namespace LibraryManagement
{
    partial class Form1
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
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cmbSubCategory = new MetroFramework.Controls.MetroComboBox();
            this.txtQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtISBN = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtPublisher = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtAuthor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtTitle = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.dgvBook = new MetroFramework.Controls.MetroGrid();
            this.dgvBook_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.txtDelete = new MetroFramework.Controls.MetroButton();
            this.txtUpdate = new MetroFramework.Controls.MetroButton();
            this.txtInsert = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Controls.Add(this.metroPanel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1341, 662);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroPanel5
            // 
            this.metroPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel5.Controls.Add(this.metroLabel7);
            this.metroPanel5.Controls.Add(this.cmbSubCategory);
            this.metroPanel5.Controls.Add(this.txtQuantity);
            this.metroPanel5.Controls.Add(this.metroLabel6);
            this.metroPanel5.Controls.Add(this.txtISBN);
            this.metroPanel5.Controls.Add(this.metroLabel5);
            this.metroPanel5.Controls.Add(this.txtPublisher);
            this.metroPanel5.Controls.Add(this.metroLabel4);
            this.metroPanel5.Controls.Add(this.txtAuthor);
            this.metroPanel5.Controls.Add(this.metroLabel3);
            this.metroPanel5.Controls.Add(this.txtTitle);
            this.metroPanel5.Controls.Add(this.metroLabel2);
            this.metroPanel5.Controls.Add(this.txtId);
            this.metroPanel5.Controls.Add(this.metroLabel1);
            this.metroPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(1094, 113);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(244, 546);
            this.metroPanel5.TabIndex = 3;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(16, 407);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(53, 25);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "Type";
            // 
            // cmbSubCategory
            // 
            this.cmbSubCategory.FormattingEnabled = true;
            this.cmbSubCategory.ItemHeight = 24;
            this.cmbSubCategory.Location = new System.Drawing.Point(95, 407);
            this.cmbSubCategory.Name = "cmbSubCategory";
            this.cmbSubCategory.Size = new System.Drawing.Size(144, 30);
            this.cmbSubCategory.TabIndex = 14;
            this.cmbSubCategory.UseSelectable = true;
            // 
            // txtQuantity
            // 
            // 
            // 
            // 
            this.txtQuantity.CustomButton.Image = null;
            this.txtQuantity.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.txtQuantity.CustomButton.Name = "";
            this.txtQuantity.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.txtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantity.CustomButton.TabIndex = 1;
            this.txtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantity.CustomButton.UseSelectable = true;
            this.txtQuantity.CustomButton.Visible = false;
            this.txtQuantity.Lines = new string[0];
            this.txtQuantity.Location = new System.Drawing.Point(137, 328);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.ShortcutsEnabled = true;
            this.txtQuantity.Size = new System.Drawing.Size(57, 39);
            this.txtQuantity.TabIndex = 13;
            this.txtQuantity.UseSelectable = true;
            this.txtQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(19, 337);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(87, 25);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Quantity";
            // 
            // txtISBN
            // 
            // 
            // 
            // 
            this.txtISBN.CustomButton.Image = null;
            this.txtISBN.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtISBN.CustomButton.Name = "";
            this.txtISBN.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtISBN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtISBN.CustomButton.TabIndex = 1;
            this.txtISBN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtISBN.CustomButton.UseSelectable = true;
            this.txtISBN.CustomButton.Visible = false;
            this.txtISBN.Lines = new string[0];
            this.txtISBN.Location = new System.Drawing.Point(19, 288);
            this.txtISBN.MaxLength = 32767;
            this.txtISBN.Multiline = true;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.PasswordChar = '\0';
            this.txtISBN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtISBN.SelectedText = "";
            this.txtISBN.SelectionLength = 0;
            this.txtISBN.SelectionStart = 0;
            this.txtISBN.ShortcutsEnabled = true;
            this.txtISBN.Size = new System.Drawing.Size(204, 34);
            this.txtISBN.TabIndex = 11;
            this.txtISBN.UseSelectable = true;
            this.txtISBN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtISBN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(19, 260);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(54, 25);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "ISBN";
            // 
            // txtPublisher
            // 
            // 
            // 
            // 
            this.txtPublisher.CustomButton.Image = null;
            this.txtPublisher.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtPublisher.CustomButton.Name = "";
            this.txtPublisher.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtPublisher.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPublisher.CustomButton.TabIndex = 1;
            this.txtPublisher.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPublisher.CustomButton.UseSelectable = true;
            this.txtPublisher.CustomButton.Visible = false;
            this.txtPublisher.Lines = new string[0];
            this.txtPublisher.Location = new System.Drawing.Point(19, 223);
            this.txtPublisher.MaxLength = 32767;
            this.txtPublisher.Multiline = true;
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.PasswordChar = '\0';
            this.txtPublisher.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPublisher.SelectedText = "";
            this.txtPublisher.SelectionLength = 0;
            this.txtPublisher.SelectionStart = 0;
            this.txtPublisher.ShortcutsEnabled = true;
            this.txtPublisher.Size = new System.Drawing.Size(204, 34);
            this.txtPublisher.TabIndex = 9;
            this.txtPublisher.UseSelectable = true;
            this.txtPublisher.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPublisher.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(19, 195);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(91, 25);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Publisher";
            // 
            // txtAuthor
            // 
            // 
            // 
            // 
            this.txtAuthor.CustomButton.Image = null;
            this.txtAuthor.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtAuthor.CustomButton.Name = "";
            this.txtAuthor.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtAuthor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAuthor.CustomButton.TabIndex = 1;
            this.txtAuthor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAuthor.CustomButton.UseSelectable = true;
            this.txtAuthor.CustomButton.Visible = false;
            this.txtAuthor.Lines = new string[0];
            this.txtAuthor.Location = new System.Drawing.Point(19, 158);
            this.txtAuthor.MaxLength = 32767;
            this.txtAuthor.Multiline = true;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.PasswordChar = '\0';
            this.txtAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAuthor.SelectedText = "";
            this.txtAuthor.SelectionLength = 0;
            this.txtAuthor.SelectionStart = 0;
            this.txtAuthor.ShortcutsEnabled = true;
            this.txtAuthor.Size = new System.Drawing.Size(204, 34);
            this.txtAuthor.TabIndex = 7;
            this.txtAuthor.UseSelectable = true;
            this.txtAuthor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAuthor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(19, 130);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(72, 25);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Author";
            // 
            // txtTitle
            // 
            // 
            // 
            // 
            this.txtTitle.CustomButton.Image = null;
            this.txtTitle.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtTitle.CustomButton.Name = "";
            this.txtTitle.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitle.CustomButton.TabIndex = 1;
            this.txtTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitle.CustomButton.UseSelectable = true;
            this.txtTitle.CustomButton.Visible = false;
            this.txtTitle.Lines = new string[0];
            this.txtTitle.Location = new System.Drawing.Point(19, 93);
            this.txtTitle.MaxLength = 32767;
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitle.SelectedText = "";
            this.txtTitle.SelectionLength = 0;
            this.txtTitle.SelectionStart = 0;
            this.txtTitle.ShortcutsEnabled = true;
            this.txtTitle.Size = new System.Drawing.Size(204, 34);
            this.txtTitle.TabIndex = 5;
            this.txtTitle.UseSelectable = true;
            this.txtTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(19, 65);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Title";
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(19, 28);
            this.txtId.MaxLength = 32767;
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ReadOnly = true;
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(204, 34);
            this.txtId.TabIndex = 3;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(19, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Book ID";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroPanel4);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(3, 113);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(1085, 546);
            this.metroPanel3.TabIndex = 2;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroPanel4
            // 
            this.metroPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel4.Controls.Add(this.dgvBook);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(0, 0);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(1085, 546);
            this.metroPanel4.TabIndex = 2;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.AllowUserToResizeRows = false;
            this.dgvBook.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvBook_ID,
            this.dgvTitle,
            this.dgvAuthor,
            this.dgvPublisher,
            this.dgvISBN,
            this.dgvStatus,
            this.dgvQuantity});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBook.EnableHeadersVisualStyles = false;
            this.dgvBook.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvBook.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBook.Location = new System.Drawing.Point(0, 0);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBook.RowTemplate.Height = 24;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(1083, 544);
            this.dgvBook.TabIndex = 2;
            this.dgvBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellContentClick);
            this.dgvBook.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellDoubleClick);
            // 
            // dgvBook_ID
            // 
            this.dgvBook_ID.DataPropertyName = "Book_ID";
            this.dgvBook_ID.HeaderText = "Book_ID";
            this.dgvBook_ID.MinimumWidth = 6;
            this.dgvBook_ID.Name = "dgvBook_ID";
            this.dgvBook_ID.ReadOnly = true;
            this.dgvBook_ID.Width = 125;
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
            this.dgvAuthor.Width = 125;
            // 
            // dgvPublisher
            // 
            this.dgvPublisher.DataPropertyName = "Publisher";
            this.dgvPublisher.HeaderText = "Publisher";
            this.dgvPublisher.MinimumWidth = 6;
            this.dgvPublisher.Name = "dgvPublisher";
            this.dgvPublisher.ReadOnly = true;
            this.dgvPublisher.Width = 125;
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
            // dgvStatus
            // 
            this.dgvStatus.DataPropertyName = "Available_Status";
            this.dgvStatus.HeaderText = "Available Status";
            this.dgvStatus.MinimumWidth = 6;
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.ReadOnly = true;
            this.dgvStatus.Width = 125;
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
            // metroPanel2
            // 
            this.metroPanel2.BackgroundImage = global::LibraryManagement.Properties.Resources._1223333;
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.btnRefresh);
            this.metroPanel2.Controls.Add(this.txtDelete);
            this.metroPanel2.Controls.Add(this.txtUpdate);
            this.metroPanel2.Controls.Add(this.txtInsert);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(1094, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(244, 104);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Location = new System.Drawing.Point(84, 65);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 34);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDelete.Location = new System.Drawing.Point(3, 61);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(75, 38);
            this.txtDelete.TabIndex = 4;
            this.txtDelete.Text = "Delete";
            this.txtDelete.UseSelectable = true;
            this.txtDelete.Click += new System.EventHandler(this.txtDelete_Click);
            // 
            // txtUpdate
            // 
            this.txtUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUpdate.Location = new System.Drawing.Point(84, 3);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(71, 52);
            this.txtUpdate.TabIndex = 3;
            this.txtUpdate.Text = "Update";
            this.txtUpdate.UseSelectable = true;
            this.txtUpdate.Click += new System.EventHandler(this.txtUpdate_Click);
            // 
            // txtInsert
            // 
            this.txtInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtInsert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtInsert.Location = new System.Drawing.Point(3, 3);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(75, 52);
            this.txtInsert.TabIndex = 2;
            this.txtInsert.Text = "Insert";
            this.txtInsert.UseSelectable = true;
            this.txtInsert.Click += new System.EventHandler(this.txtInsert_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.White;
            this.metroPanel1.BackgroundImage = global::LibraryManagement.Properties.Resources._008080;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.txtSearch);
            this.metroPanel1.Controls.Add(this.btnSearch);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1085, 104);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(707, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(50, 42);
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
            this.txtSearch.Size = new System.Drawing.Size(737, 32);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search here....";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSearch.Location = new System.Drawing.Point(855, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 662);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Book Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel5.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroGrid dgvBook;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroTextBox txtISBN;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtPublisher;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtAuthor;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtTitle;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton txtInsert;
        private MetroFramework.Controls.MetroButton txtDelete;
        private MetroFramework.Controls.MetroButton txtUpdate;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroComboBox cmbSubCategory;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBook_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuantity;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnSearch;
    }
}

