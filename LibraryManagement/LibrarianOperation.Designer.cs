namespace LibraryManagement
{
    partial class LibrarianOperation
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.txtphn = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.userid = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1402, 660);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 94);
            this.panel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(126, 28);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(494, 40);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(8, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 81);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvMember);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1096, 554);
            this.panel2.TabIndex = 1;
            // 
            // dgvMember
            // 
            this.dgvMember.AllowUserToAddRows = false;
            this.dgvMember.AllowUserToDeleteRows = false;
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMember.Location = new System.Drawing.Point(0, 0);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.ReadOnly = true;
            this.dgvMember.RowHeadersWidth = 51;
            this.dgvMember.RowTemplate.Height = 24;
            this.dgvMember.Size = new System.Drawing.Size(1094, 552);
            this.dgvMember.TabIndex = 0;
            this.dgvMember.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMember_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Snow;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.btnInsert);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(1105, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 94);
            this.panel3.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(209, 57);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 32);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 8);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 32);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(209, 8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 57);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 32);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Salmon;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtpass);
            this.panel4.Controls.Add(this.txtadd);
            this.panel4.Controls.Add(this.txtphn);
            this.panel4.Controls.Add(this.txtmail);
            this.panel4.Controls.Add(this.txtname);
            this.panel4.Controls.Add(this.txtuserid);
            this.panel4.Controls.Add(this.password);
            this.panel4.Controls.Add(this.address);
            this.panel4.Controls.Add(this.phone);
            this.panel4.Controls.Add(this.email);
            this.panel4.Controls.Add(this.name);
            this.panel4.Controls.Add(this.userid);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1105, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 554);
            this.panel4.TabIndex = 3;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(90, 340);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(166, 22);
            this.txtpass.TabIndex = 12;
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(90, 265);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(166, 22);
            this.txtadd.TabIndex = 11;
            // 
            // txtphn
            // 
            this.txtphn.Location = new System.Drawing.Point(90, 200);
            this.txtphn.Name = "txtphn";
            this.txtphn.Size = new System.Drawing.Size(166, 22);
            this.txtphn.TabIndex = 10;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(90, 143);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(166, 22);
            this.txtmail.TabIndex = 9;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(90, 80);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(166, 22);
            this.txtname.TabIndex = 8;
            // 
            // txtuserid
            // 
            this.txtuserid.Location = new System.Drawing.Point(90, 16);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(166, 22);
            this.txtuserid.TabIndex = 7;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(9, 340);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(70, 16);
            this.password.TabIndex = 5;
            this.password.Text = "Password:";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(9, 271);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(61, 16);
            this.address.TabIndex = 4;
            this.address.Text = "Address:";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(9, 203);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(49, 16);
            this.phone.TabIndex = 3;
            this.phone.Text = "Phone:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(9, 143);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(48, 16);
            this.email.TabIndex = 2;
            this.email.Text = "E-Mail:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(9, 80);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(47, 16);
            this.name.TabIndex = 1;
            this.name.Text = "Name:";
            // 
            // userid
            // 
            this.userid.AutoSize = true;
            this.userid.Location = new System.Drawing.Point(9, 19);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(55, 16);
            this.userid.TabIndex = 0;
            this.userid.Text = "User ID:";
            // 
            // LibrarianOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 660);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LibrarianOperation";
            this.Text = "LibrarianOperation";
            this.Load += new System.EventHandler(this.LibrarianOperation_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.TextBox txtphn;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label userid;
    }
}