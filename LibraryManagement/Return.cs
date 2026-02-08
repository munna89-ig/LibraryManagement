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

namespace LibraryManagement
{
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }
        private void LoadReturn()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string userId = MemberID.memberId.ToString();

                string query = "SELECT Borrow.Borrow_ID, Book.Book_ID, Book.Title, Book.Author, Book.Publisher, Book.ISBN, " +
                    "Borrow.Borrow_Date, Borrow.Due_Date, Borrow.Borrow_Status " +
                    "FROM Borrow " +
                    "INNER JOIN Book ON Borrow.Book_ID = Book.Book_ID " +
                    "WHERE Borrow.User_ID = " + userId + " AND Borrow.Borrow_Status = 'Accepted'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                dgvReturn.DataSource = dt;
                dgvReturn.Refresh();
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void Return_Load(object sender, EventArgs e)
        {
            this.LoadReturn();
        }

        private void dgvReturn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string userId = MemberID.memberId.ToString();
                int selectedIndex = e.RowIndex;
                if (selectedIndex < 0)
                {
                    this.dgvReturn.ClearSelection();
                    return;
                }
                int id = int.Parse(this.dgvReturn.Rows[selectedIndex].Cells["dgvBorrowID"].Value.ToString());
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string query = "Select * from Borrow where Borrow_Id=" + id;
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                txtBorrowID.Text = dt.Rows[0]["Borrow_ID"].ToString();
                txtBookId.Text = dt.Rows[0]["Book_ID"].ToString();



                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                
                string id = txtBorrowID.Text;
                string bookId = txtBookId.Text;



                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Please select book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                    conn.Open();
                    string updateQuery = "UPDATE Borrow " +
                              "SET Return_Date = GETDATE(), " +
                              "Borrow_Status = 'Returned' " +
                              "WHERE Borrow_ID = " + id;

                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.ExecuteNonQuery();
                    string updateBook = "UPDATE Book " +
                             "SET Book_Quantity = Book_Quantity + 1, " +
                             "Available_Status = CASE WHEN Book_Quantity + 1 > 0 THEN 'Available' ELSE Available_Status END " +
                             "WHERE Book_ID = " + bookId;

                    SqlCommand cmdBook = new SqlCommand(updateBook, conn);
                    cmdBook.ExecuteNonQuery();

                    string fineQuery = "SELECT DATEDIFF(DAY, Due_Date, GETDATE()) AS LateDays " +
                                       "FROM Borrow WHERE Borrow_ID = " + id;

                    SqlCommand fineCmd = new SqlCommand(fineQuery, conn);
                    SqlDataReader reader = fineCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int lateDays = Convert.ToInt32(reader["LateDays"]);
                        reader.Close();

                        if (lateDays > 0)
                        {
                            int fineAmount = lateDays * 10; 

                            string insertFine = "INSERT INTO Fine (Borrow_ID, Amount, Status, Reason) " +
                                                "VALUES (" + id + ", " + fineAmount + ", 'Unpaid', 'Late Return')";

                            SqlCommand insertCmd = new SqlCommand(insertFine, conn);
                            insertCmd.ExecuteNonQuery();

                            MessageBox.Show("Book returned! Fine : " + fineAmount + " Tk (Unpaid)");
                        }
                        else
                        {
                            MessageBox.Show("Book returned on time. No fine.");
                        }
                    }
                    else
                    {
                        reader.Close();
                    }
                    conn.Close();
                    this.LoadReturn();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnLost_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtBorrowID.Text;
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Please select book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else 
                {
                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                    conn.Open();

                    
                    string updateBorrow = "UPDATE Borrow SET Borrow_Status = 'Lost' WHERE Borrow_ID = " + id;
                    SqlCommand cmdBorrow = new SqlCommand(updateBorrow, conn);
                    cmdBorrow.ExecuteNonQuery();

                    
                    string insertFine = "INSERT INTO Fine (Borrow_ID, Amount, Status, Reason) " +
                                        "VALUES (" + id + ", 500, 'Unpaid', 'Lost Book')";
                    SqlCommand cmdFine = new SqlCommand(insertFine, conn);
                    cmdFine.ExecuteNonQuery();

                    MessageBox.Show("Book marked as Lost. Fine of 500 Tk has been added.");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Lost Book Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadReturn();
            txtBorrowID.Text = "";
        }
    }
}
