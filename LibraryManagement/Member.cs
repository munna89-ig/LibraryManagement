using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagement
{
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }
        private void NewCommand()
        {
            txtBookID.Text = "";
            

        }
        private void LoadMember()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string query = "SELECT Book.Book_ID, Book.Title, Book.Author, Book.Publisher, " +
               "Book.ISBN, Book.Available_Status, Book.Book_Quantity, " +
               "SubCategory.SubCategory_Name " +
               "FROM Book " +
               "INNER JOIN SubCategory ON Book.SubCategory_ID = SubCategory.SubCategory_ID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                dgvbookinfo.DataSource = dt;
                dgvbookinfo.Refresh();
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = MemberID.memberId.ToString();
                string id = txtBookID.Text;
                string status = "Pending";



                if (string.IsNullOrEmpty(id) )
                {
                    MessageBox.Show("Please select book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                    conn.Open();
                    string checkQuery = "SELECT Book_Quantity FROM Book WHERE Book_ID = " + id;
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    object result = checkCmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Book not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int quantity = Convert.ToInt32(result);
                    if (quantity <= 0)
                    {
                        MessageBox.Show("This book is not available. Please Reserve or waiting for availble", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    string query = "INSERT INTO Borrow (User_ID, Book_ID, Borrow_Status) " +
                   "VALUES (" + userId + ", " + id + ", '" + status + "')";


                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Request done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    this.LoadMember();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = MemberID.memberId.ToString();
                string id = txtBookID.Text;
                string status = "Pending";



                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Please select book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                    conn.Open();
                    string query = "INSERT INTO Reservation (User_ID, Book_ID, Reservation_Date, Status) " +
                "VALUES (" + userId + ", " + id + ", GETDATE(), '" + status + "')";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Request done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    this.LoadMember();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Member_Load(object sender, EventArgs e)
        {
            this.LoadMember();
           
            this.NewCommand();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (keyword == "")
            {
                MessageBox.Show("Please enter Book ID or Name to search!");
                return;
            }

            try
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();

                string query = "SELECT Book.Book_ID, Book.Title, Book.Author, Book.Publisher, " +
                               "Book.ISBN, Book.Available_Status, Book.Book_Quantity, SubCategory.SubCategory_Name " +
                               "FROM Book " +
                               "INNER JOIN SubCategory ON Book.SubCategory_ID = SubCategory.SubCategory_ID " +
                               "WHERE CAST(Book.Book_ID AS NVARCHAR) LIKE '%" + keyword + "%' " +
                               "OR Book.Title LIKE '%" + keyword + "%' " +
                               "OR Book.ISBN LIKE '%" + keyword + "%'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];
                dgvbookinfo.DataSource = dt;
                dgvbookinfo.Refresh();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadMember();
            this.NewCommand();
            txtSearch.Text = "";
        }

        private void dgvbookinfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedIndex = e.RowIndex;
                if (selectedIndex < 0)
                {
                    this.dgvbookinfo.ClearSelection();
                    return;
                }
                int id = int.Parse(this.dgvbookinfo.Rows[selectedIndex].Cells["dgvBookID"].Value.ToString());
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string query = "Select * from Book where Book_Id=" + id;
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                txtBookID.Text = dt.Rows[0]["Book_ID"].ToString();



                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
