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
using System.IO;

namespace Gym
{
    public partial class updateDevice : Form
    {
        public updateDevice()
        {
            InitializeComponent();
        }


        SqlConnection conn = null;
        private void editButton_Click(object sender, EventArgs e)
        {


            try
            {


                string maSp = _deviceID.Text;
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
                    string st = "update Device set deviceName=N'" + _deviceID.Text + "',amount=N'" + _amount.Text + "',status=N'" + comboBox1.Text + "',importDate='" + dateTimePicker1.Text + "',nv=N'"+comboBox2.Text+"' " + "where deviceID=@maSp";
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
                        MessageBox.Show("lỗi");
                    }
                }
        }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi:" + ex.Message);
                }
}

        private void updateDevice_Load(object sender, EventArgs e)
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
            comm.CommandText = "select fullName from Employee";
            comm.Connection = conn;


            SqlDataAdapter da = new SqlDataAdapter("select fullName from Employee", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember="fullname";
           
        }




    }
}


