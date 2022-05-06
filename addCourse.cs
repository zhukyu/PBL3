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

namespace Gym
{

    public partial class addCourse : Form
    {
        public addCourse()
        {
            InitializeComponent();
        }



        private void addButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;

            try

            {
                if (conn == null)
                {
                    conn = new SqlConnection(Program.cnstr);
                }
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                string st = "Insert into Course(courseID,courseName,duration,price)" + "values (N'" + _courseID.Text + "',N'" + comboBox1.Text + "',N'" + comboBox2.Text + "','" + _price.Text + "')";
                comm.CommandText = st;
                comm.Connection = conn;

                int ret = comm.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("loi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi:" + ex.Message);
            }
        }
    }
}
