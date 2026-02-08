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
    public partial class LibrarianOperation : Form
    {
        public LibrarianOperation()
        {
            InitializeComponent();
        }
        private void LoadUserInfo()
        {
            try
            {
               
                    txtmail.ReadOnly = false;
                    txtphn.ReadOnly = false;
                
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string query = "SELECT * FROM Users WHERE Role = 'Librarian'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                dgvMember.DataSource = dt;
                dgvMember.Refresh();
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Loaduserinfocommand()
        {

            txtuserid.Text = "Auto Generated";
            txtname.Text = "";
            txtmail.Text = "";
            txtphn.Text = "";
            txtadd.Text = "";
            txtpass.Text = "";

        }
        private void LibrarianOperation_Load(object sender, EventArgs e)
        {
            
            this.LoadUserInfo();
            this.Loaduserinfocommand();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtname.Text;
                string mail = txtmail.Text;
                string phn = txtphn.Text;
                string add = txtadd.Text;
                string pass = txtpass.Text;

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(phn)
                    || string.IsNullOrEmpty(add) || string.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("Fill the box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();


                string checkQuery = "SELECT COUNT(*) FROM Users WHERE E_mail='" + mail + "' OR Phone='" + phn + "'";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("E-Mail and Phone Already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                    return;
                }


                string insertQuery = "INSERT INTO Users (Name, E_mail, Phone, Address, Password, Role) " +
                     "VALUES ('" + name + "', '" + mail + "', '" + phn + "', '" + add + "', '" + pass + "', 'Librarian')";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Insert Librarian", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();

                this.LoadUserInfo();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {

                string id = txtuserid.Text;
                string name = txtname.Text;
                string mail = txtmail.Text; ;
                string phn = txtphn.Text;
                string add = txtadd.Text;
                string pass = txtpass.Text;

                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(phn) || string.IsNullOrEmpty(add) || string.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("Please fill the box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                    conn.Open();
                    
                    string query = "UPDATE Users SET " + "Name = '" + name + "', " + "E_mail = '" + mail + "', " + "Phone = '" + phn + "', " +
                                   "Password = '" + pass + "', " + "Address = '" + add + "' " + "WHERE User_ID = " + id;


                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Infrmation Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    this.LoadUserInfo();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtuserid.Text == "Auto Generated")
                {
                    MessageBox.Show("Error: Please select a row first ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                    conn.Open();
                    string query = "Delete from Users where user_Id=" + txtuserid.Text;
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    this.LoadUserInfo();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Can't Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            this.LoadUserInfo();
            this.Loaduserinfocommand();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string search = txtSearch.Text.Trim();

                string query = "SELECT * FROM Users " +
                    "WHERE Name LIKE '%" + search + "%' " +
                    "OR User_ID LIKE '%" + search + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                dgvMember.DataSource = dt;
                dgvMember.Refresh();
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgvMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelectedIndex = e.RowIndex;
            if (SelectedIndex < 0)
            {
                this.dgvMember.ClearSelection();
                return;
            }
            int id = int.Parse(this.dgvMember.Rows[SelectedIndex].Cells[0].Value.ToString());
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
            conn.Open();
            string query = "Select * from Users where User_ID =" + id;
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            txtuserid.Text = dt.Rows[0]["User_ID"].ToString();
            txtname.Text = dt.Rows[0]["Name"].ToString();
            txtadd.Text = dt.Rows[0]["Address"].ToString();
            txtmail.Text = dt.Rows[0]["E_mail"].ToString();
            txtpass.Text = dt.Rows[0]["Password"].ToString();
            txtphn.Text = dt.Rows[0]["Phone"].ToString();
            conn.Close();
            txtmail.ReadOnly = true;
            txtphn.ReadOnly = true;
        }
    }
}
