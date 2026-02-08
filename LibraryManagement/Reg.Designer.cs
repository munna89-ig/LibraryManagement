namespace LibraryManagement
{
    partial class Reg
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnConfirm = new MetroFramework.Controls.MetroButton();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.txtMail = new MetroFramework.Controls.MetroTextBox();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnBack);
            this.metroPanel1.Controls.Add(this.btnConfirm);
            this.metroPanel1.Controls.Add(this.txtAddress);
            this.metroPanel1.Controls.Add(this.txtPhone);
            this.metroPanel1.Controls.Add(this.txtMail);
            this.metroPanel1.Controls.Add(this.txtPass);
            this.metroPanel1.Controls.Add(this.txtName);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(326, 80);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(664, 543);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(354, 477);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 36);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(205, 477);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(113, 36);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(251, 1);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(173, 388);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PromptText = "Enter Address...";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(285, 35);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMark = "Enter Address...";
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(251, 1);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(173, 306);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PromptText = "Enter phone-number...";
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(285, 35);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMark = "Enter phone-number...";
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMail
            // 
            // 
            // 
            // 
            this.txtMail.CustomButton.Image = null;
            this.txtMail.CustomButton.Location = new System.Drawing.Point(251, 1);
            this.txtMail.CustomButton.Name = "";
            this.txtMail.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMail.CustomButton.TabIndex = 1;
            this.txtMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMail.CustomButton.UseSelectable = true;
            this.txtMail.CustomButton.Visible = false;
            this.txtMail.Lines = new string[0];
            this.txtMail.Location = new System.Drawing.Point(173, 221);
            this.txtMail.MaxLength = 32767;
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.PromptText = "Enter E-Mail...";
            this.txtMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionLength = 0;
            this.txtMail.SelectionStart = 0;
            this.txtMail.ShortcutsEnabled = true;
            this.txtMail.Size = new System.Drawing.Size(285, 35);
            this.txtMail.TabIndex = 5;
            this.txtMail.UseSelectable = true;
            this.txtMail.WaterMark = "Enter E-Mail...";
            this.txtMail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.CustomButton.Image = null;
            this.txtPass.CustomButton.Location = new System.Drawing.Point(251, 1);
            this.txtPass.CustomButton.Name = "";
            this.txtPass.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPass.CustomButton.TabIndex = 1;
            this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPass.CustomButton.UseSelectable = true;
            this.txtPass.CustomButton.Visible = false;
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(173, 137);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PromptText = "Enter Password...";
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(285, 35);
            this.txtPass.TabIndex = 4;
            this.txtPass.UseSelectable = true;
            this.txtPass.WaterMark = "Enter Password...";
            this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(251, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(173, 66);
            this.txtName.MaxLength = 32767;
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Enter full name...";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(285, 35);
            this.txtName.TabIndex = 3;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Enter full name...";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 678);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Reg";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Reg_FormClosed);
            this.Load += new System.EventHandler(this.Reg_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroTextBox txtMail;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroButton btnConfirm;
        private MetroFramework.Controls.MetroButton btnBack;
    }
}