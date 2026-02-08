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
    public partial class BorrowReport : Form
    {
        public BorrowReport()
        {
            InitializeComponent();
        }
        private void LoadBorrow()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string query = "SELECT Borrow.Borrow_ID, Borrow.User_ID, Users.Name , " +
                       "Borrow.Borrow_Date , Borrow.Due_Date,Borrow.Return_Date, Borrow.Borrow_Status " +
                       "FROM Borrow " +
                       "INNER JOIN Users ON Borrow.User_ID = Users.User_ID";
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
        private void BorrowReport_Load(object sender, EventArgs e)
        {
            this.LoadBorrow();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string type = cmbType.SelectedItem == null ? string.Empty : cmbType.SelectedItem.ToString();
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string query = "SELECT Borrow.Borrow_ID, Borrow.User_ID, Users.Name, " +
               "Borrow.Borrow_Date, Borrow.Due_Date, Borrow.Return_Date, Borrow.Borrow_Status " +
               "FROM Borrow " +
               "INNER JOIN Users ON Borrow.User_ID = Users.User_ID " +
               "WHERE Borrow.Borrow_Status = '" + type + "'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.LoadBorrow();
            cmbType.SelectedItem = null;
        }
    }
}
