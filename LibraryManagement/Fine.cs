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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagement
{
    public partial class Fine : Form
    {
        public Fine()
        {
            InitializeComponent();
        }
        private void LoadFine()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string query = "SELECT Fine.Fine_ID, Fine.Borrow_ID, Borrow.User_ID, Users.Name , " +
                       "Fine.Amount , Fine.Status " +
                       "FROM Fine " +
                       "INNER JOIN Borrow ON Fine.Borrow_ID = Borrow.Borrow_ID " +
                       "INNER JOIN Users ON Borrow.User_ID = Users.User_ID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                dgvFine.DataSource = dt;
                dgvFine.Refresh();
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Fine_Load(object sender, EventArgs e)
        {
            this.LoadFine();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            try
            {
                string type = cmbType.SelectedItem == null ? string.Empty : cmbType.SelectedItem.ToString();
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string query = "SELECT Fine.Fine_ID, Fine.Borrow_ID, Borrow.User_ID, Users.Name, " +
                "Fine.Amount, Fine.Status " +
                "FROM Fine " +
                "INNER JOIN Borrow ON Fine.Borrow_ID = Borrow.Borrow_ID " +
                "INNER JOIN Users ON Borrow.User_ID = Users.User_ID " +
                "WHERE Fine.Status = '" + type + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                dgvFine.DataSource = dt;
                dgvFine.Refresh();
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.LoadFine();
            cmbType.SelectedItem = null;
        }
    }
}
