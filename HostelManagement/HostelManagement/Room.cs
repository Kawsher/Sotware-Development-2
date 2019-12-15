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
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            this.Hide();
            ad.ShowDialog();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Room_Load(object sender, EventArgs e)
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
            cmd.CommandText = "select * from Room";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            srch.Close();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            AddRoom adr = new AddRoom();
            this.Hide();
            adr.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRoom dr = new DeleteRoom();
            this.Close();
            dr.ShowDialog();
        }
    }
}
