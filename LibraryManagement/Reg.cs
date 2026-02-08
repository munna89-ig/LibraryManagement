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

namespace LibraryManagement
{
    public partial class Reg : MetroFramework.Forms.MetroForm
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void Reg_Load(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void NewCommand()
        {
            txtName.Text = "";
            txtPass.Text = "";
            txtMail.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {

                string name = txtName.Text;
                string pass = txtPass.Text;
                string mail = txtMail.Text;
                string phone= txtPhone.Text;
                string address = txtAddress.Text;


                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address))
                {
                    MessageBox.Show("Please fill the box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE E_Mail='" + txtMail.Text + "' OR Phone='" + txtPhone.Text + "'";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 0)
                    {

                        string insertQuery = "INSERT INTO Users (Name, Password, E_Mail, Phone, Address, Role) " +
                       "VALUES ('" + txtName.Text + "', '" + txtPass.Text + "', '" + txtMail.Text + "', '" + txtPhone.Text + "', '" + txtAddress.Text + "', 'Member')";

                        SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                        insertCmd.ExecuteNonQuery();

                        MessageBox.Show(" Registration Complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        conn.Close();
                        this.NewCommand();

                    }
                    else
                    {

                        MessageBox.Show(" Email or Phone number already exists", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void Reg_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
