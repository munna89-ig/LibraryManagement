using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

       

       

        private void lblError_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            this.lblError.Visible = false;
            string input = txtName.Text;
            string pass = txtPassword.Text;
            var query = "select * from Users where (User_ID='" + input + "' or Phone='" + input + "') and password='" + pass + "'";


            var result = DbHelper.GetResult(query);
            if (result.HasError)
            {
                this.lblError.Visible = true;
                return;
            }
            if (result.Data.Rows.Count != 1)
            {
                this.lblError.Visible = true;
                return;
            }


            int userId = Convert.ToInt32(result.Data.Rows[0]["User_ID"]);
            string name = result.Data.Rows[0]["Name"].ToString();
            MemberID.memberId = userId;
            MemberID.memberName = name;

            if (result.Data.Rows[0]["Role"].ToString() == "Admin")
            {
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
            }
            else if (result.Data.Rows[0]["Role"].ToString() == "Member")
            {
                MemberPanel member = new MemberPanel();
                member.Show();
                this.Hide();
            }
            else
            {
                Librarian librarian = new Librarian();
                librarian.Show();
                this.Hide();
            }
        }

       
        private void label1_Click(object sender, EventArgs e)
        {
            Forget forget = new Forget();
            forget.Show();
            this.Hide();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Reg reg = new Reg();
            reg.Show();
            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
