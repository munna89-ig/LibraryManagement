namespace LibraryManagement
{
    partial class Forget
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
            this.txtMail = new MetroFramework.Controls.MetroTextBox();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.btnConfirm = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtMail
            // 
            // 
            // 
            // 
            this.txtMail.CustomButton.Image = null;
            this.txtMail.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.txtMail.CustomButton.Name = "";
            this.txtMail.CustomButton.Size = new System.Drawing.Size(43, 43);
            this.txtMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMail.CustomButton.TabIndex = 1;
            this.txtMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMail.CustomButton.UseSelectable = true;
            this.txtMail.CustomButton.Visible = false;
            this.txtMail.Lines = new string[0];
            this.txtMail.Location = new System.Drawing.Point(463, 226);
            this.txtMail.MaxLength = 32767;
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.PromptText = "Enter your E-Mail....";
            this.txtMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionLength = 0;
            this.txtMail.SelectionStart = 0;
            this.txtMail.ShortcutsEnabled = true;
            this.txtMail.Size = new System.Drawing.Size(277, 45);
            this.txtMail.TabIndex = 0;
            this.txtMail.UseSelectable = true;
            this.txtMail.WaterMark = "Enter your E-Mail....";
            this.txtMail.WaterMarkColor = System.Drawing.Color.Black;
            this.txtMail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.CustomButton.Image = null;
            this.txtPass.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.txtPass.CustomButton.Name = "";
            this.txtPass.CustomButton.Size = new System.Drawing.Size(43, 43);
            this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPass.CustomButton.TabIndex = 1;
            this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPass.CustomButton.UseSelectable = true;
            this.txtPass.CustomButton.Visible = false;
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(463, 316);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.PromptText = "New password...";
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(277, 45);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSelectable = true;
            this.txtPass.WaterMark = "New password...";
            this.txtPass.WaterMarkColor = System.Drawing.Color.Black;
            this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(472, 408);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(109, 35);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(621, 408);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 35);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Forget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 703);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtMail);
            this.Name = "Forget";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Forget_FormClosed);
            this.Load += new System.EventHandler(this.Forget_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtMail;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroButton btnConfirm;
        private MetroFramework.Controls.MetroButton btnBack;
    }
}