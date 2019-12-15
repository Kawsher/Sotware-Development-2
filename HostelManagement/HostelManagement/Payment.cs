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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
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
            cmd.CommandText = "select * from payment where id ='" + txtId.Text.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            srch.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateUi())
            {
                SqlConnection paystd = new SqlConnection(Paymentstring);
                paystd.Open();
                SqlCommand cmds = paystd.CreateCommand();
                cmds.CommandType = CommandType.Text;
                cmds.CommandText = "update Payment set PayAmount +='" + txtAmount.Text.ToString() + "',DueAmount -='" + txtAmount.Text.ToString() + "',LastPaymentDate ='" + date.Text.ToString() + "' where Id ='" + txtId.Text.ToString() + "'";
                cmds.ExecuteNonQuery();
                dis_dta();
                
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ViewPayment  ad = new ViewPayment();
            this.Hide();
            ad.ShowDialog();
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
        private bool ValidateUi()
        {
            if (txtId.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Warning", "Please Enter Student Id", MessageBoxButtons.OK);
                return false;
            }
            if (txtAmount.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Warning", "Please Enter Amount", MessageBoxButtons.OK);
                return false;
            }
            if (date.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Warning", "Please Enter Date", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
