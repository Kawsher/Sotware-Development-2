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
    public partial class DeleteRoom : Form
    {
        public DeleteRoom()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Room ad = new Room();
            this.Hide();
            ad.ShowDialog();
        }
        public string addstring = "Data Source=localhost;Initial Catalog=HostelManagement;Integrated Security=True";
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ValidateUi())
            {
                SqlConnection add = new SqlConnection(addstring);
                add.Open();
                if (add.State == System.Data.ConnectionState.Open)
                {
                    string q = "Delete from Room where RoomNo ='" + txtDeleteRoom.Text.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(q, add);
                    cmd.ExecuteNonQuery();
                    ValidateUi();
                    MessageBox.Show("Delete successfully");
                }
                add.Close();
                Room dr = new Room();
                this.Close();
                dr.ShowDialog();
            }
            
        }
        private bool ValidateUi()
        {
            if (txtDeleteRoom.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Warning", "Please Enter Room Number", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
    }
}
