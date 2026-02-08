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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void NewCommand()
        {
            txtCategoryID.Text = "Auto Generated";
            txtCategoryName.Text = "";
           

        }
        private void LoadCategory()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string query = "Select * from Category";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                dgvCategory.DataSource = dt;
                dgvCategory.Refresh();
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.NewCommand();
            this.LoadCategory();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

                string name = txtCategoryName.Text;
               

                if (string.IsNullOrEmpty(name) )
                {
                    MessageBox.Show("Please fill the box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM Category WHERE Category_Name = '" + name + "'";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("This Category already exists!");
                    }
                    else
                    {
                        string insertQuery = "INSERT INTO Category (Category_Name) VALUES ('" + name + "')";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                        insertCmd.ExecuteNonQuery();

                        MessageBox.Show("Category inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    conn.Close();
                    this.LoadCategory();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                string name = txtCategoryName.Text;
               

                if (string.IsNullOrEmpty(name) )
                {
                    MessageBox.Show("Please fill the box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM Category WHERE Category_Name = '" + name + "' AND Category_Id <> " + txtCategoryID.Text;
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("This category name already exists.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        
                        string query = "UPDATE Category SET Category_Name = '" + name + "' WHERE Category_Id = " + txtCategoryID.Text;
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Category updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       
                        LoadCategory();
                    }

                   
                    conn.Close();
                    
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.NewCommand();
            this.LoadCategory();
            txtSearch.Text = "";
        }

        private void dgvCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedIndex = e.RowIndex;
                if (selectedIndex < 0)
                {
                    this.dgvCategory.ClearSelection();
                    return;
                }
                int id = int.Parse(this.dgvCategory.Rows[selectedIndex].Cells["dgvCategory_ID"].Value.ToString());
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string query = "Select * from Category where Category_Id=" + id;
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                txtCategoryID.Text = dt.Rows[0]["Category_ID"].ToString();
                txtCategoryName.Text = dt.Rows[0]["Category_Name"].ToString();
               

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string searchValue = txtSearch.Text.Trim();

                string query = "SELECT Category_ID, Category_Name " +"from Category " + "WHERE Category_ID LIKE '%" + searchValue + "%' " + "   OR Category_Name LIKE '%" + searchValue + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                dgvCategory.DataSource = dt;
                dgvCategory.Refresh();
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
            

   
    }
}
