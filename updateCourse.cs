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
    public partial class updateCourse : Form
    {
        public updateCourse()
        {
            InitializeComponent();
        }



        private void editButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;

            try
            {




                string maSp = _courseID.Text;
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
                    string st = "update Course set  courseName=N'" + comboBox1.Text + "',duration=N'" + comboBox2.Text + "',price='" + _price.Text + "' " + "where courseID=@maSp";
                    comm.CommandText = st;
                    comm.CommandText = st;
                    comm.Connection = conn;

                    SqlParameter para = new SqlParameter("@maSp", SqlDbType.NVarChar);
                    para.Value = maSp;
                    comm.Parameters.Add(para);
                    int ret = comm.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        MessageBox.Show("Lỗi");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi:" + ex.Message);
            }
        }
    }
}
