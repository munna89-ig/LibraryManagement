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
    public partial class Librarian : Form
    {
        public Librarian()
        {
            InitializeComponent();
        }

        private void Librarian_Load(object sender, EventArgs e)
        {
            string name= MemberID.memberName.ToString();
            lblUser.Text = name;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            Form1 form = new Form1();
            form.TopLevel = false;
            form.FormBorderStyle= FormBorderStyle.None; 
            form.AutoScroll = true; 
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
            

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            Borrow form = new Borrow();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            Reservation form = new Reservation();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            Form2 form = new Form2();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnSCategory_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            Form3 form = new Form3();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnFine_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            Fine form = new Fine();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnRBorrow_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            BorrowReport form = new BorrowReport();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            PaymentReport form = new PaymentReport();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Login l=new Login();
            l.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            ReservationReportcs form = new ReservationReportcs();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            UserInfo form = new UserInfo();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void Librarian_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
