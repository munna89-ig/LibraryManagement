using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryManagement
{
    public partial class Forget : MetroFramework.Forms.MetroForm
    {
        public Forget()
        {
            InitializeComponent();
        }

        private void Forget_Load(object sender, EventArgs e)
        {
           
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {

                string mail = txtMail.Text;
                string pass = txtPass.Text;




                if (string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("Please fill the box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE E_Mail='" + mail + "'";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        string updateQuery = "UPDATE Users SET Password='" + pass + "' WHERE E_Mail='" + mail + "'";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show(" Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtMail.Text = "";
                        txtPass.Text = "";
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show(" Email not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
                    
                
            
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Forget_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
