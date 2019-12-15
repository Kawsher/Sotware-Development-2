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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string addstring = "Data Source=localhost;Initial Catalog=HostelManagement;Integrated Security=True";
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateUi()) {
                SaveStudent();
                ClearUi();
            }
            
        }
        private void ClearUi()
        {
            txtAddress.Text = string.Empty;
            txtId.Text = "";
            txtName.Text = "";
            txtFather.Text = "";
            txtMother.Text = "";
            txtRoom.Text = "";
            joinDate.Text = "";
            txtPhn.Text = "";
            txtEmail.Text = "";
            txtFare.Text = "";
        }

        private bool ValidateUi()
        {
            if(txtId.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Warning", "Please Enter Student Id",MessageBoxButtons.OK);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text.ToString()))
            {
                MessageBox.Show("Warning", "Please Enter Name", MessageBoxButtons.OK);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFather.Text.ToString()))
            {
                MessageBox.Show("Warning", "Please Enter Father Name", MessageBoxButtons.OK);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMother.Text.ToString()))
            {
                MessageBox.Show("Warning", "Please Enter Mother Name", MessageBoxButtons.OK);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtRoom.Text.ToString()))
            {
                MessageBox.Show("Warning", "Please Enter Room Number", MessageBoxButtons.OK);
                return false;
            }
            if (string.IsNullOrWhiteSpace(joinDate.Text.ToString()))
            {
                MessageBox.Show("Warning", "Please Enter Join Date", MessageBoxButtons.OK);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPhn.Text.ToString()))
            {
                MessageBox.Show("Warning", "Please Enter Phone Number", MessageBoxButtons.OK);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text.ToString()))
            {
                MessageBox.Show("Warning", "Please Enter Email", MessageBoxButtons.OK);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text.ToString()))
            {
                MessageBox.Show("Warning", "Please Enter Room Fare ", MessageBoxButtons.OK);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text.ToString()))
            {
                MessageBox.Show("Warning", "Please Enter Address", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void SaveStudent() {
            SqlConnection add = new SqlConnection(addstring);
            add.Open();
            if (add.State == System.Data.ConnectionState.Open)
            {
                string q = "INSERT INTO addstudent VALUES('" + txtId.Text.ToString() + "','" + txtName.Text.ToString() + "','" + txtFather.Text.ToString() + "','" + txtMother.Text.ToString() + "','" + txtRoom.Text.ToString() + "','" + joinDate.Text.ToString() + "','" + txtPhn.Text.ToString() + "','" + txtEmail.Text.ToString() + "','" + txtAddress.Text.ToString() + "')";
                string p = "update Room set AvailableSeat -=1 where RoomNo ='" + txtRoom.Text + "'";
                string r = "Insert into Payment(Id,PayAmount,DueAmount,TotalAmount,LastPaymentDate) values('" + txtId.Text.ToString() + "',0,'" + txtFare.Text.ToString() + "','" + txtFare.Text.ToString() + "','" + joinDate.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, add);
                SqlCommand updt = new SqlCommand(p, add);
                SqlCommand fare = new SqlCommand(r, add);
                cmd.ExecuteNonQuery();
                updt.ExecuteNonQuery();
                fare.ExecuteNonQuery();
                MessageBox.Show("Add successfully");
            }
            add.Close();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Admin addh = new Admin();
            this.Hide();
            addh.ShowDialog();
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtRoom_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPhn_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtFather_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtMother_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtRoom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtPhn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtFare_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void joinDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
