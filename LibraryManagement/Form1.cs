using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void NewCommand()
        {
            txtId.Text = "Auto Generated";
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtPublisher.Text = "";
            txtISBN.Text = "";
            txtQuantity.Text = "";
            cmbSubCategory.SelectedItem = null;

        }
        private void LoadBook()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string query = "Select  Book.*,SubCategory.SubCategory_Name as 'Type' from Book inner join SubCategory on SubCategory.SubCategory_ID= Book.SubCategory_ID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                dgvBook.DataSource = dt;
                dgvBook.Refresh();
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void txtUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                string title = txtTitle.Text;
                string author = txtAuthor.Text;
                string publisher = txtPublisher.Text;
                string isbn = txtISBN.Text;
                int subCategory_ID = cmbSubCategory.SelectedValue == null ? -1 : int.Parse(cmbSubCategory.SelectedValue.ToString());
                int quantity;
                

                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(publisher) || string.IsNullOrEmpty(isbn) || subCategory_ID <= 0)
                {
                    MessageBox.Show("Please fill the box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtQuantity.Text, out quantity))
                {
                    MessageBox.Show("Quantity must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                    conn.Open();
                    string query = "UPDATE Book SET " + "title='" + title + "', " +"author='" + author + "', " + "publisher='" + publisher + "', " +   "ISBN='" + isbn + "', " +
                  "book_quantity=" + quantity + ", " +"available_status=CASE WHEN " + quantity + " > 0 THEN 'Available' ELSE 'Not Available' END, " +
                  "SubCategory_ID=" + subCategory_ID + " " +"WHERE Book_ID=" + txtId.Text;

                    
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Infrmation Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    this.LoadBook();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void LoadSubCategory()
        {
            var query = "select * from SubCategory";
            var result = DbHelper.GetResult(query);
            if(result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }
            cmbSubCategory.DataSource = result.Data;
            cmbSubCategory.DisplayMember = "SubCategory_Name";
            cmbSubCategory.ValueMember = "SubCategory_ID";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadBook();
            this.LoadSubCategory();
            this.NewCommand();
           
        }

        private void txtInsert_Click(object sender, EventArgs e)
        {
            try
            {

                string title = txtTitle.Text;
                string author = txtAuthor.Text;
                string publisher = txtPublisher.Text;
                string isbn = txtISBN.Text;
                int subCategory_ID = cmbSubCategory.SelectedValue == null ? -1 : int.Parse(cmbSubCategory.SelectedValue.ToString());
                int quantity;
               

                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(publisher) || string.IsNullOrEmpty(isbn) || subCategory_ID <= 0)
                {
                    MessageBox.Show("Please fill the box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtQuantity.Text, out quantity))
                {
                    MessageBox.Show("Quantity must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                    conn.Open();
                    string query = "INSERT INTO Book (title, author, publisher, ISBN, book_quantity, available_status, SubCategory_ID) " +
                                "VALUES ('" + title + "','" + author + "','" + publisher + "','" + isbn + "'," + quantity + ", " +
                                "CASE WHEN " + quantity + " > 0 THEN 'Available' ELSE 'Not Available' END, " + subCategory_ID + ")";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    this.LoadBook();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgvBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedIndex = e.RowIndex;
                if (selectedIndex < 0)
                {
                    this.dgvBook.ClearSelection();
                    return;
                }
                int id = int.Parse(this.dgvBook.Rows[selectedIndex].Cells["dgvBook_ID"].Value.ToString());
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string query = "Select * from Book where Book_Id=" + id;
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                txtId.Text = dt.Rows[0]["Book_ID"].ToString();
                txtTitle.Text = dt.Rows[0]["Title"].ToString();
                txtAuthor.Text = dt.Rows[0]["Author"].ToString();
                txtPublisher.Text = dt.Rows[0]["Publisher"].ToString();
                txtISBN.Text = dt.Rows[0]["ISBN"].ToString();
                txtQuantity.Text = dt.Rows[0]["Book_Quantity"].ToString();
                cmbSubCategory.SelectedValue = dt.Rows[0]["SubCategory_ID"].ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "Auto Generated")
                {
                    MessageBox.Show("Error: Please select a row first ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                    conn.Open();
                    string query = "Delete from Book where Book_Id=" + txtId.Text;
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    this.LoadBook();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Can't Delete the book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.NewCommand();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.NewCommand();
            this.LoadBook();
            txtSearch.Text = "";
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string searchValue = txtSearch.Text.Trim();

                string query ="SELECT Book.*, SubCategory.SubCategory_Name AS 'Type' " +
                              "FROM Book " +
                              "INNER JOIN SubCategory ON SubCategory.SubCategory_ID = Book.SubCategory_ID " +
                               "WHERE Book.title LIKE '%" + searchValue + "%' " +
                               "OR Book.Book_ID LIKE '%" + searchValue + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                dgvBook.DataSource = dt;
                dgvBook.Refresh();
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
