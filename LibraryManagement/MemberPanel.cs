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
    public partial class MemberPanel : Form
    {
        public MemberPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            Member form = new Member();
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
            Member form = new Member();
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
            Return form = new Return();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            Payment form = new Payment();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Login forget = new Login();
            forget.Show();
            this.Hide();
        }

        private void MemberPanel_Load(object sender, EventArgs e)
        {
            string name = MemberID.memberName.ToString();
            lblName.Text = name;
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            BorrowHistory form = new BorrowHistory();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void MemberPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            ReservationHistory form = new ReservationHistory();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
