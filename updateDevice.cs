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
    public partial class updateDevice : Form
    {
        public updateDevice()
        {
            InitializeComponent();
        }


        SqlConnection conn = null;
        string str = @"Data Source=DESKTOP-S7H27N8\SQLEXPRESS;Initial Catalog=GymDatabase;Integrated Security=True";
        private void editButton_Click(object sender, EventArgs e)
        {


            try
            {


                string maSp = _deviceID.Text;
                {
                    if (conn == null)
                    {
                        conn = new SqlConnection(str);
                    }
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    SqlCommand comm = new SqlCommand();
                    comm.CommandType = CommandType.Text;
                    string st = "update Device set deviceName=N'" + _deviceID.Text + "',amount=N'" + _amount.Text + "',status=N'" + comboBox1.Text + "',importDate='" + dateTimePicker1.Text + "' " + "where deviceID=@maSp";
                    comm.CommandText = st;
                    comm.CommandText = st;
                    comm.Connection = conn;

                    SqlParameter para = new SqlParameter("@maSp", SqlDbType.NVarChar);
                    para.Value = maSp;
                    comm.Parameters.Add(para);
                    int ret = comm.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        MessageBox.Show("Sửa thành công");


                    }
                    else
                    {
                        MessageBox.Show("lỗi");
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

