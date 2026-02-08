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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void NewCommand()
        {
            txtID.Text = "Auto Generated";
            txtName.Text = "";
            cmbCategory.SelectedItem = null;

        }
        private void LoadSubCategory()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string query = "Select  SubCategory.*,Category.Category_Name as 'Category' from SubCategory inner join Category on Category.Category_ID= SubCategory.Category_ID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                dgvSubCategory.DataSource = dt;
                dgvSubCategory.Refresh();
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void LoadCategory()
        {
            var query = "select * from Category";
            var result = DbHelper.GetResult(query);
            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }
            cmbCategory.DataSource = result.Data;
            cmbCategory.DisplayMember = "Category_Name";
            cmbCategory.ValueMember = "Category_ID";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.LoadSubCategory();
            this.LoadCategory();
            this.NewCommand();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.NewCommand();
            this.LoadSubCategory();
            txtSearch.Text = "";
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

                string name = txtName.Text;
               
                int Category_ID = cmbCategory.SelectedValue == null ? -1 : int.Parse(cmbCategory.SelectedValue.ToString());
                

                if (string.IsNullOrEmpty(name) || Category_ID <= 0)
                {
                    MessageBox.Show("Please fill the box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                    conn.Open();
                    string query = "INSERT INTO SubCategory (SubCategory_Name, Category_ID) " +
                                 "VALUES ('" + name+ "', " + Category_ID + ")";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    this.LoadSubCategory();
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

                string name = txtName.Text;
                
                int Category_ID = cmbCategory.SelectedValue == null ? -1 : int.Parse(cmbCategory.SelectedValue.ToString());
               

                if (string.IsNullOrEmpty(name) || Category_ID <= 0)
                {
                    MessageBox.Show("Please fill the box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                    conn.Open();
                    string query = "UPDATE SubCategory SET " +"SubCategory_Name='" + name + "', " + "Category_ID=" + Category_ID + " " +"WHERE SubCategory_ID=" + txtID.Text;
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Infrmation Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    this.LoadSubCategory();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void dgvSubCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedIndex = e.RowIndex;
                if (selectedIndex < 0)
                {
                    this.dgvSubCategory.ClearSelection();
                    return;
                }
                int id = int.Parse(this.dgvSubCategory.Rows[selectedIndex].Cells["dgvSCID"].Value.ToString());
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string query = "Select * from SubCategory where SubCategory_Id=" + id;
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                txtID.Text = dt.Rows[0]["SubCategory_ID"].ToString();
                txtName.Text = dt.Rows[0]["SubCategory_Name"].ToString();
                cmbCategory.SelectedValue = dt.Rows[0]["Category_ID"].ToString();


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

                string query = "SELECT SubCategory.*, Category.Category_Name AS 'Category' " + "FROM SubCategory " + "INNER JOIN Category ON Category.Category_ID = SubCategory.Category_ID " + "WHERE SubCategory.SubCategory_ID LIKE '%" + searchValue + "%' " +
                               "   OR SubCategory.SubCategory_Name LIKE '%" + searchValue + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                dgvSubCategory.DataSource = dt;
                dgvSubCategory.Refresh();
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgvSubCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
