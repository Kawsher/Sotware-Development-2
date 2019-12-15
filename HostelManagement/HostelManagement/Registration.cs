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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        public string addstring = "Data Source=localhost;Initial Catalog=HostelManagement;Integrated Security=True";
        private void btnsignup_Click(object sender, EventArgs e)
        {
            if (ValidateUi())
            {
                SaveStudent();
                ClearUi();
            }
        }
        private void ClearUi()
        {
            TxtName.Text = "";
            txtUser.Text = "";
            TxtEmail.Text = string.Empty;
            txtPass.Text = "";
            
        }

        private bool ValidateUi()
        {
            if (TxtName.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Warning", "Please Enter Student Name", MessageBoxButtons.OK);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtUser.Text.ToString()))
            {
                MessageBox.Show("Warning", "Please Enter User Name", MessageBoxButtons.OK);
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtEmail.Text.ToString()))
            {
                MessageBox.Show("Warning", "Please Enter Email", MessageBoxButtons.OK);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPass.Text.ToString().Trim()))
            {
                MessageBox.Show("Warning", "Please Enter Password", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void SaveStudent()
        {
            SqlConnection add = new SqlConnection(addstring);
            add.Open();
            if (add.State == System.Data.ConnectionState.Open)
            {
                string q = "INSERT INTO Login VALUES('" + TxtName.Text.ToString() + "','" + txtUser.Text.ToString() + "','" + TxtEmail.Text.ToString() + "','" + txtPass.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, add);
                cmd.ExecuteNonQuery();
                MessageBox.Show("registration completed successfully");
            }
            add.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();
        }

        private void TxtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
