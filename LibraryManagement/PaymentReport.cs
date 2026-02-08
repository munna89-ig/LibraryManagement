using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class PaymentReport : Form
    {
        public PaymentReport()
        {
            InitializeComponent();
        }
        private void LoadPayment()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string query = "SELECT Payment.Payment_ID, Payment.Fine_ID, Fine.Borrow_ID, " +
                       "Borrow.User_ID, Users.Name, " +
                       "Payment.Payment_Date, Payment.Payment_Method, Payment.Amount " +
                       "FROM Payment " +
                       "INNER JOIN Fine ON Payment.Fine_ID = Fine.Fine_ID " +
                       "INNER JOIN Borrow ON Fine.Borrow_ID = Borrow.Borrow_ID " +
                       "INNER JOIN Users ON Borrow.User_ID = Users.User_ID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                dgvPayment.DataSource = dt;
                dgvPayment.Refresh();
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void PaymentReport_Load(object sender, EventArgs e)
        {
            this.LoadPayment();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string method = cmbMethod.SelectedItem == null ? string.Empty : cmbMethod.SelectedItem.ToString();
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string query = "SELECT Payment.Payment_ID, Payment.Fine_ID, Fine.Borrow_ID, " +
                "Borrow.User_ID, Users.Name, " +
                "Payment.Payment_Date, Payment.Payment_Method, Payment.Amount " +
                "FROM Payment " +
                "INNER JOIN Fine ON Payment.Fine_ID = Fine.Fine_ID " +
                "INNER JOIN Borrow ON Fine.Borrow_ID = Borrow.Borrow_ID " +
                "INNER JOIN Users ON Borrow.User_ID = Users.User_ID " +
                "WHERE Payment.Payment_Method = '" + method + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                dgvPayment.DataSource = dt;
                dgvPayment.Refresh();
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.LoadPayment();
            cmbMethod.SelectedItem = null;
        }
    }
}
