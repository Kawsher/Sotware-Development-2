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
    public partial class AddMeal : Form
    {
        public AddMeal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public string Mealstring = "Data Source=localhost;Initial Catalog=HostelManagement;Integrated Security=True";

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(ValidateUi())
            {
                SqlConnection mel = new SqlConnection(Mealstring);
                mel.Open();
                string m = "INSERT INTO Meal VALUES('" + dtDate.Value + "','" + txtId.Text.ToString() + "','" + txtBreakfast.Text.ToString() + "','" + txtLunch.Text.ToString() + "','" + txtDinner.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(m, mel);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add Successfully");
                mel.Close();
                txtId.Text = "";
                txtBreakfast.Text = "";
                txtLunch.Text = "";
                txtDinner.Text = "";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AllMeal ad = new AllMeal();
            this.Hide();
            ad.ShowDialog();
        }

        private void AddMeal_Load(object sender, EventArgs e)
        {

        }
        private bool ValidateUi()
        {
            if (dtDate.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Warning", "Please Enter Room Number", MessageBoxButtons.OK);
                return false;
            }
            if (txtId.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Warning", "Please Enter Number Id", MessageBoxButtons.OK);
                return false;
            }
            if (txtBreakfast.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Warning", "Please Enter Number of Breakfast", MessageBoxButtons.OK);
                return false;
            }
            if (txtLunch.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Warning", "Please Enter Number of Lunch", MessageBoxButtons.OK);
                return false;
            }
            if (txtDinner.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Warning", "Please Enter Number of Dinner", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void dtDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtBreakfast_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtLunch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtDinner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
