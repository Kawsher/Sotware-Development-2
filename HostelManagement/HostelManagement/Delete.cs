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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }
        public string dltstring = "Data Source=localhost;Initial Catalog=HostelManagement;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateUi())
            {
                delete();
            }
            
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            this.Hide();
            ad.ShowDialog();
        }
        private bool ValidateUi()
        {
            if (txtDltID.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Warning", "Please Enter Student Id", MessageBoxButtons.OK);
                return false;
            }
            if (txtRoom.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Warning", "Please Enter Room Number", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void delete()
        {
            SqlConnection dlt = new SqlConnection(dltstring);
            dlt.Open();

            SqlCommand cmd = dlt.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from addstudent where id ='" + txtDltID.Text + "'and RoomNo='" + txtRoom.Text + "'";
            string p = "update Room set AvailableSeat +=1 where RoomNo ='" + txtRoom.Text + "'";
            string m = "Delete from Meal where Id ='" + txtDltID.Text + "'";
            string pay = "Delete from Payment where Id ='" + txtDltID.Text + "'";
            SqlCommand updt = new SqlCommand(p, dlt);
            SqlCommand me = new SqlCommand(m, dlt);
            SqlCommand pa = new SqlCommand(pay, dlt);
            cmd.ExecuteNonQuery();
            updt.ExecuteNonQuery();
            me.ExecuteNonQuery();
            pa.ExecuteNonQuery();
            dlt.Close();

            MessageBox.Show("Delete Succeessful");
            ViewStudent dlth = new ViewStudent();
            this.Hide();
            dlth.ShowDialog();
        }
    }
}
