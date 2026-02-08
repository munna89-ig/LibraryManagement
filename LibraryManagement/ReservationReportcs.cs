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
    public partial class ReservationReportcs : Form
    {
        public ReservationReportcs()
        {
            InitializeComponent();
        }
        private void LoadReservation()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string query = "SELECT Reservation.Reservation_ID, Reservation.Book_ID, Reservation.User_ID, Users.Name , " +
                       "Reservation.Reservation_Date,Reservation.Status " +
                       "FROM Reservation " +
                       "INNER JOIN Users ON Reservation.User_ID = Users.User_ID";
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
        private void ReservationReportcs_Load(object sender, EventArgs e)
        {
            this.LoadReservation(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.LoadReservation();
            cmbType.SelectedItem = null;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string type = cmbType.SelectedItem == null ? string.Empty : cmbType.SelectedItem.ToString();
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string query = "SELECT Reservation.Reservation_ID,Reservation.Book_ID, Reservation.User_ID, Users.Name, " +
               "Reservation.Reservation_Date, Reservation.Status " +
               "FROM Reservation " +
               "INNER JOIN Users ON Reservation.User_ID = Users.User_ID " +
               "WHERE Reservation.Status = '" + type + "'";
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
