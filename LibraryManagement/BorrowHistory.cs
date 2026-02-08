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
    public partial class BorrowHistory : Form
    {
        public BorrowHistory()
        {
            InitializeComponent();
        }

        private void BorrowHistory_Load(object sender, EventArgs e)
        {

        }

        private void BorrowHistory_Load_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string userId = MemberID.memberId.ToString();

                string query = "SELECT Borrow.Borrow_ID, Book.Book_ID, Book.Title, Book.Author, Book.Publisher, Book.ISBN, " +
                              "Borrow.Borrow_Date, Borrow.Due_Date, Borrow.Return_Date, Borrow.Borrow_Status " +
                               "FROM Borrow " +
                              "INNER JOIN Book ON Borrow.Book_ID = Book.Book_ID " +
                              "WHERE Borrow.User_ID = " + userId;

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

        private void dgvBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
