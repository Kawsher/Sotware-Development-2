using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HostelManagement
{
    public partial class ViewPayment : Form
    {
        public ViewPayment()
        {
            InitializeComponent();
        }

        private void ViewPayment_Load(object sender, EventArgs e)
        {
            dis_dta();
        }
        public string Paymentstring = "Data Source=localhost;Initial Catalog=HostelManagement;Integrated Security=True";
        public void dis_dta()
        {
            SqlConnection srch = new SqlConnection(Paymentstring);
            srch.Open();
            SqlCommand cmd = srch.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from payment";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            srch.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            this.Hide();
            ad.ShowDialog();
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            Payment py = new Payment();
            this.Hide();
            py.ShowDialog();
        }
    }
}
