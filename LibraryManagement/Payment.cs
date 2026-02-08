using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryManagement
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        private void LoadPayment()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string userId = MemberID.memberId.ToString();

                string query = "SELECT Fine.Fine_ID, Borrow.Borrow_ID,Fine.Status,Fine.Reason, Fine.Amount " +"FROM Fine " +"INNER JOIN Borrow ON Fine.Borrow_ID = Borrow.Borrow_ID " +
                                "WHERE Borrow.User_ID = " + userId + " AND Fine.Status = 'Unpaid'";

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
        private void Payment_Load(object sender, EventArgs e)
        {
            this.LoadPayment();
        }

        private void dgvPayment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                int selectedIndex = e.RowIndex;
                if (selectedIndex < 0)
                {
                    this.dgvPayment.ClearSelection();
                    return;
                }
                int id = int.Parse(this.dgvPayment.Rows[selectedIndex].Cells["dgvFineID"].Value.ToString());
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                conn.Open();
                string query = "Select * from Fine where Fine_Id=" + id;
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                txtFine.Text = dt.Rows[0]["Fine_ID"].ToString();
                



                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            try
            {
                string fineId = txtFine.Text;
                string method = cmbMethod.SelectedItem == null ? string.Empty : cmbMethod.SelectedItem.ToString();

                if (string.IsNullOrEmpty(fineId)|| string.IsNullOrEmpty(method))
                {
                    MessageBox.Show("Please select a row or Payement method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else 
                {
                    SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
                    conn.Open();

                    
                    string query = "SELECT Amount FROM Fine WHERE Fine_ID = " + fineId;
                    SqlCommand cmd = new SqlCommand(query, conn);
                    object result = cmd.ExecuteScalar();
                    int amount = Convert.ToInt32(result);

                    string insertQuery = "INSERT INTO Payment (Fine_ID, Payment_Method, Amount, Payment_Date) " +
                                         "VALUES (" + fineId + ", '" + method + "', " + amount + ", GETDATE())";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.ExecuteNonQuery();

                   
                    string updateQuery = "UPDATE Fine SET Status = 'Paid' WHERE Fine_ID = " + fineId;
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show(" Payment completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                    this.LoadPayment();
                    txtFine.Text="";
                    cmbMethod.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Payment failed: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtFine.Text = "";
            cmbMethod.SelectedIndex = -1;   
        }
    }
    
}
