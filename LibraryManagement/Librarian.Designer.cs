namespace LibraryManagement
{
    partial class Librarian
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
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnPayment = new MetroFramework.Controls.MetroButton();
            this.btnRBorrow = new MetroFramework.Controls.MetroButton();
            this.btnFine = new MetroFramework.Controls.MetroButton();
            this.btnSCategory = new MetroFramework.Controls.MetroButton();
            this.btnCategory = new MetroFramework.Controls.MetroButton();
            this.btnReservation = new MetroFramework.Controls.MetroButton();
            this.btnBorrow = new MetroFramework.Controls.MetroButton();
            this.btnBook = new MetroFramework.Controls.MetroButton();
            this.pnlMain = new MetroFramework.Controls.MetroPanel();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.metroPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlMain, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1451, 754);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.metroPanel2.BackgroundImage = global::LibraryManagement.Properties.Resources._1223333;
            this.metroPanel2.Controls.Add(this.metroButton2);
            this.metroPanel2.Controls.Add(this.metroButton1);
            this.metroPanel2.Controls.Add(this.btnOut);
            this.metroPanel2.Controls.Add(this.btnPayment);
            this.metroPanel2.Controls.Add(this.btnRBorrow);
            this.metroPanel2.Controls.Add(this.btnFine);
            this.metroPanel2.Controls.Add(this.btnSCategory);
            this.metroPanel2.Controls.Add(this.btnCategory);
            this.metroPanel2.Controls.Add(this.btnReservation);
            this.metroPanel2.Controls.Add(this.btnBorrow);
            this.metroPanel2.Controls.Add(this.btnBook);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(248, 748);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(37, 636);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(173, 50);
            this.metroButton2.TabIndex = 11;
            this.metroButton2.Text = "User Information";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(37, 568);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(173, 50);
            this.metroButton1.TabIndex = 10;
            this.metroButton1.Text = "Reservation Report";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnOut
            // 
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Location = new System.Drawing.Point(74, 702);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(105, 37);
            this.btnOut.TabIndex = 2;
            this.btnOut.Text = "Log Out";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(37, 501);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(173, 50);
            this.btnPayment.TabIndex = 9;
            this.btnPayment.Text = "Payement Report";
            this.btnPayment.UseSelectable = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnRBorrow
            // 
            this.btnRBorrow.Location = new System.Drawing.Point(37, 430);
            this.btnRBorrow.Name = "btnRBorrow";
            this.btnRBorrow.Size = new System.Drawing.Size(173, 50);
            this.btnRBorrow.TabIndex = 8;
            this.btnRBorrow.Text = "Borrow Report";
            this.btnRBorrow.UseSelectable = true;
            this.btnRBorrow.Click += new System.EventHandler(this.btnRBorrow_Click);
            // 
            // btnFine
            // 
            this.btnFine.Location = new System.Drawing.Point(37, 359);
            this.btnFine.Name = "btnFine";
            this.btnFine.Size = new System.Drawing.Size(173, 50);
            this.btnFine.TabIndex = 7;
            this.btnFine.Text = "Fine Report";
            this.btnFine.UseSelectable = true;
            this.btnFine.Click += new System.EventHandler(this.btnFine_Click);
            // 
            // btnSCategory
            // 
            this.btnSCategory.Location = new System.Drawing.Point(37, 290);
            this.btnSCategory.Name = "btnSCategory";
            this.btnSCategory.Size = new System.Drawing.Size(173, 50);
            this.btnSCategory.TabIndex = 6;
            this.btnSCategory.Text = "Manage Sub-Category";
            this.btnSCategory.UseSelectable = true;
            this.btnSCategory.Click += new System.EventHandler(this.btnSCategory_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(37, 224);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(173, 50);
            this.btnCategory.TabIndex = 5;
            this.btnCategory.Text = "Manage Category";
            this.btnCategory.UseSelectable = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.Location = new System.Drawing.Point(37, 157);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(173, 50);
            this.btnReservation.TabIndex = 4;
            this.btnReservation.Text = "Reservation Request";
            this.btnReservation.UseSelectable = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(37, 90);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(173, 50);
            this.btnBorrow.TabIndex = 3;
            this.btnBorrow.Text = "Borrow Request";
            this.btnBorrow.UseSelectable = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(37, 23);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(173, 50);
            this.btnBook.TabIndex = 2;
            this.btnBook.Text = "Book Managment";
            this.btnBook.UseSelectable = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImage = global::LibraryManagement.Properties.Resources._8888;
            this.pnlMain.Controls.Add(this.lblUser);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.HorizontalScrollbarBarColor = true;
            this.pnlMain.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMain.HorizontalScrollbarSize = 10;
            this.pnlMain.Location = new System.Drawing.Point(257, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1191, 748);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.VerticalScrollbarBarColor = true;
            this.pnlMain.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMain.VerticalScrollbarSize = 10;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.SystemColors.Control;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(719, 90);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(165, 58);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome";
            // 
            // Librarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 754);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Librarian";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Librarian_FormClosed);
            this.Load += new System.EventHandler(this.Librarian_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btnCategory;
        private MetroFramework.Controls.MetroButton btnReservation;
        private MetroFramework.Controls.MetroButton btnBorrow;
        private MetroFramework.Controls.MetroButton btnBook;
        private MetroFramework.Controls.MetroPanel pnlMain;
        private MetroFramework.Controls.MetroButton btnSCategory;
        private MetroFramework.Controls.MetroButton btnPayment;
        private MetroFramework.Controls.MetroButton btnRBorrow;
        private MetroFramework.Controls.MetroButton btnFine;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}