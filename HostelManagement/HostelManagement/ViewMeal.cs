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
    public partial class ViewMeal : Form
    {
        public ViewMeal()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string RoomString = "Data Source=localhost;Initial Catalog=HostelManagement;Integrated Security=True";
        public void dis_dta()
        {
            SqlConnection srch = new SqlConnection(RoomString);
            srch.Open();
            SqlCommand cmd = srch.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Date,Breakfast,Lunch,Dinnar from Meal where Id ='" + txtId.Text.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            srch.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            this.Hide();
            st.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (ValidateUi())
            {
                dis_dta();
                txtId.Text = "";
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewMeal_Load(object sender, EventArgs e)
        {

        }

        private void btnMeal_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            AddMeal adm = new AddMeal();
            this.Hide();
            adm.ShowDialog();
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
    }
}
