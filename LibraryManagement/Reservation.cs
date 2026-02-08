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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }
        private void NewCommand()
        {
            txtID.Text = "";


        }
        private void LoadReservation()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string query = "SELECT Reservation.Reservation_ID, Reservation.User_ID, Users.Name , " +
                       "Reservation.Book_ID, Book.Title , Book.Book_Quantity, " +
                       "Reservation.Reservation_Date, Reservation.Status " +
                       "FROM Reservation " +
                       "INNER JOIN Users ON Reservation.User_ID = Users.User_ID " +
                       "INNER JOIN Book ON Reservation.Book_ID = Book.Book_ID " +
                       "WHERE Reservation.Status = 'Pending'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                dgvReservation.DataSource = dt;
                dgvReservation.Refresh();
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            this.LoadReservation();
            this.NewCommand();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.NewCommand();
            this.LoadReservation();
            txtSearch.Text = "";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text;

                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Please select first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();


                string query = "UPDATE Reservation " +
                       "SET Status = 'Accepted' " +
                       "WHERE Reservation_ID = " + txtID.Text;

                SqlCommand cmdBorrow = new SqlCommand(query, conn);
                cmdBorrow.ExecuteNonQuery();

                MessageBox.Show("Reservation request Accepted .", "Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();


                LoadReservation();
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
                    MessageBox.Show("Please select first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();


                string query = "UPDATE Reservation " +
                       "SET Status = 'Rejected' " +
                       "WHERE Reservation_ID = " + txtID.Text;

                SqlCommand cmdBorrow = new SqlCommand(query, conn);
                cmdBorrow.ExecuteNonQuery();

                MessageBox.Show("Reservation request Rejected .", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();


                LoadReservation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvReservation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedIndex = e.RowIndex;
                if (selectedIndex < 0)
                {
                    this.dgvReservation.ClearSelection();
                    return;
                }
                int id = int.Parse(this.dgvReservation.Rows[selectedIndex].Cells["dgvRID"].Value.ToString());
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string query = "Select * from Reservation where reservation_Id=" + id;
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                txtID.Text = dt.Rows[0]["Reservation_ID"].ToString();
                


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


                string query = "SELECT Reservation.Reservation_ID, Reservation.User_ID, Users.Name , " +
                       "Reservation.Book_ID, Book.Title , Book.Book_Quantity, " +
                       "Reservation.Reservation_Date, Reservation.Status " +
                       "FROM Reservation " +
                       "INNER JOIN Users ON Reservation.User_ID = Users.User_ID " +
                       "INNER JOIN Book ON Reservation.Book_ID = Book.Book_ID " +
                       "WHERE Reservation.Status = 'Pending' " +
                       "AND (Reservation.Reservation_ID LIKE '%" + searchValue + "%' " +
                       "OR Users.Name LIKE '%" + searchValue + "%')";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                dgvReservation.DataSource = dt;
                dgvReservation.Refresh();
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
