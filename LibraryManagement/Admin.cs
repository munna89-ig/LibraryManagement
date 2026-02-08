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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            string name = MemberID.memberName.ToString();
            lblAdmin.Text = name;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            AdminOperation form = new AdminOperation();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            LibrarianOperation form = new LibrarianOperation();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            MemberOperation form = new MemberOperation();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
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

        private void button8_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
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

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
