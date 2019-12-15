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
    public partial class DeleteMeal : Form
    {
        public DeleteMeal()
        {
            InitializeComponent();
        }
        public string Mealstring = "Data Source=localhost;Initial Catalog=HostelManagement;Integrated Security=True";
        private void btnViewMeal_Click(object sender, EventArgs e)
        {
            if (ValidateUi())
            {
                SqlConnection mel = new SqlConnection(Mealstring);
                mel.Open();
                string m = "Delete From Meal where Id='" + txtId.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(m, mel);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully");
                mel.Close();
                AllMeal am = new AllMeal();
                this.Hide();
                am.ShowDialog();
            }


        }
        private void btnAddMeal_Click(object sender, EventArgs e)
        {
        }
        private bool ValidateUi()
        {
            if (txtId.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Warning", "Please Enter Student Id", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllMeal al = new AllMeal();
            this.Hide();
            al.ShowDialog();
        }
    }
}