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
    public partial class updateEmployee : Form
    {
        public updateEmployee()
        {
            InitializeComponent();
        }

        SqlConnection conn = null;
        private void fixButton_Click(object sender, EventArgs e)
        {
            try
            {

                Employee em = new Employee();


                string maSp = _employeeID.Text;
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
                    string st = "update Employee set  fullName=N'" + _fullName.Text + "',gender=N'" + gioitinh.Text + "',birthday='" + dateTimePicker1.Text + "',phoneNumber='" + _phoneNumber.Text + "',idNumber='" + _idNumber.Text + "',role=N'" + comboBox1.Text + "',address=N'" + _address.Text + "' " + "where employeeID=@maSp";
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










