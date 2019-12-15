using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudent addstudent = new AddStudent();
            this.Hide();
            addstudent.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete dlt = new Delete();
            this.Hide();
            dlt.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Room rm = new Room();
            this.Hide();
            rm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewStudent vs = new ViewStudent();
            this.Hide();
            vs.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();
        }

        private void btnMeal_Click(object sender, EventArgs e)
        {
            AllMeal ml = new AllMeal();
            this.Hide();
            ml.ShowDialog();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            ViewPayment vp = new ViewPayment();
            this.Hide();
            vp.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ViewAllStudentInfo vlsi = new ViewAllStudentInfo();
            this.Hide();
            vlsi.ShowDialog();
        }
    }
}
