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
    public partial class AllMeal : Form
    {
        public AllMeal()
        {
            InitializeComponent();
        }

        private void AllMeal_Load(object sender, EventArgs e)
        {
            dis_dta();
        }
        public string RoomString = "Data Source=localhost;Initial Catalog=HostelManagement;Integrated Security=True";
        public void dis_dta()
        {
            SqlConnection srch = new SqlConnection(RoomString);
            srch.Open();
            SqlCommand cmd = srch.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Meal";
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

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            AddMeal addmel = new AddMeal();
            this.Hide();
            addmel.ShowDialog();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteMeal dm = new DeleteMeal();
            this.Hide();
            dm.ShowDialog();
        }
    }
}
