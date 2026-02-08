using System;
using System.Collections;
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
    public partial class Borrow : Form
    {
        public Borrow()
        {
            InitializeComponent();
        }
        private void NewCommand()
        {
            txtID.Text = "";
            

        }
        private void LoadBorrow()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string query = "SELECT Borrow.Borrow_ID, Borrow.User_ID, Users.Name AS UserName, " +
                "Borrow.Book_ID, Book.Title , Book.Book_Quantity, " +
                "Borrow.Borrow_Date, Borrow.Due_Date, Borrow.Borrow_Status " +
                "FROM Borrow " +
                "INNER JOIN Book ON Borrow.Book_ID = Book.Book_ID " +
                "INNER JOIN Users ON Borrow.User_ID = Users.User_ID " +
                "WHERE Borrow.Borrow_Status = 'Pending'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                dgvBorrow.DataSource = dt;
                dgvBorrow.Refresh();
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            this.LoadBorrow();
            this.NewCommand();

        }

        private void dgvBorrow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedIndex = e.RowIndex;
                if (selectedIndex < 0)
                {
                    this.dgvBorrow.ClearSelection();
                    return;
                }
                int id = int.Parse(this.dgvBorrow.Rows[selectedIndex].Cells["dgvBorrow_ID"].Value.ToString());
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string query = "Select * from Borrow where Borrow_Id=" + id;
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                txtID.Text = dt.Rows[0]["Borrow_ID"].ToString();
                txtBook_ID.Text = dt.Rows[0]["Book_ID"].ToString();


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text;
                string B_id = txtBook_ID.Text;
                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(B_id))
                {
                    MessageBox.Show("Please select a borrow record first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string checkQuery = "SELECT Book_Quantity FROM Book WHERE Book_ID = " + B_id;
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                int quantity = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (quantity <= 0)
                {
                    MessageBox.Show("This book is currently not available!", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                    return;
                }

                string queryBorrow = "UPDATE Borrow " +
                                     "SET Borrow_Status = 'Accepted', " +
                                     "Borrow_Date = GETDATE(), " +
                                     "Due_Date = DATEADD(DAY, 7, GETDATE()) " +
                                     "WHERE Borrow_ID = " + id;
                SqlCommand cmd = new SqlCommand(queryBorrow, conn);
                cmd.ExecuteNonQuery();


                string queryBook = "UPDATE Book " +
                                   "SET Book_Quantity = Book_Quantity - 1 " +
                                   "WHERE Book_ID = " + B_id + " AND Book_Quantity > 0";
                SqlCommand cmd1 = new SqlCommand(queryBook, conn);
                cmd1.ExecuteNonQuery();


                string queryStatus = "UPDATE Book " +
                                     "SET Available_Status = CASE " +
                                     "WHEN Book_Quantity > 0 THEN 'Available' " +
                                     "ELSE 'Not Available' END " +
                                     "WHERE Book_ID = " + B_id;
                SqlCommand cmd2 = new SqlCommand(queryStatus, conn);
                cmd2.ExecuteNonQuery();


                string queryReservation = "UPDATE Reservation " +
                                          "SET Status = 'Completed' " +
                                          "WHERE Book_ID = " + B_id +
                                          " AND User_ID = (SELECT User_ID FROM Borrow WHERE Borrow_ID = " + id + ")";
                SqlCommand cmd3 = new SqlCommand(queryReservation, conn);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Borrow accepted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
                LoadBorrow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text;
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Please select a borrow record first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();

                string query = "UPDATE Borrow " +
                               "SET Borrow_Status = 'Rejected', Borrow_Date = NULL, Due_Date = NULL " +
                               "WHERE Borrow_ID = " + id;
                new SqlCommand(query, conn).ExecuteNonQuery();

                
                string queryReservation = "UPDATE Reservation " +
                                          "SET Status = 'Rejected' " +
                                          "WHERE Book_ID = (SELECT Book_ID FROM Borrow WHERE Borrow_ID = " + id + ") " +
                                          "AND User_ID = (SELECT User_ID FROM Borrow WHERE Borrow_ID = " + id + ")";
                new SqlCommand(queryReservation, conn).ExecuteNonQuery();

                MessageBox.Show("Borrow request rejected .", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
                LoadBorrow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.NewCommand();
            this.LoadBorrow();
            txtSearch.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string searchValue = txtSearch.Text.Trim();


                string query = "SELECT Borrow.Borrow_ID, Borrow.User_ID, Users.Name AS UserName, " +
                       "Borrow.Book_ID, Book.Title , Book.Book_Quantity, " +
                       "Borrow.Borrow_Date, Borrow.Due_Date, Borrow.Borrow_Status " +
                       "FROM Borrow " +
                       "INNER JOIN Book ON Borrow.Book_ID = Book.Book_ID " +
                       "INNER JOIN Users ON Borrow.User_ID = Users.User_ID " +
                       "WHERE Borrow.Borrow_Status = 'Pending' " +
                       "AND (Borrow.Borrow_ID LIKE '%" + searchValue + "%' " +
                       "OR Users.Name LIKE '%" + searchValue + "%')";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                dgvBorrow.DataSource = dt;
                dgvBorrow.Refresh();
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
