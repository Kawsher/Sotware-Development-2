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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search se = new Search();
            this.Hide();
            se.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewMeal vm = new ViewMeal();
            this.Hide();
            vm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaymentStudent pys = new PaymentStudent();
            this.Hide();
            pys.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RoomMates rm = new RoomMates();
            this.Hide();
            rm.ShowDialog();
        }
    }
}
