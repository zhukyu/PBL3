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
    public partial class addEmployee : Form
    {
        public addEmployee()
        {
            InitializeComponent();
        }

        SqlConnection conn = null;
        private void addButton_Click(object sender, EventArgs e)
        {


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
                string st = "Insert into Employee(employeeID,fullName,gender,birthday,phoneNumber,idNumber,role,address)" + "values (N'" + _employeeID.Text + "',N'" + _fullName.Text + "','" + gioitinh.Text + "','" + dateTimePicker1.Text + "','" + _phoneNumber.Text + "','" + _idNumber.Text + "',N'" + comboBox1.Text + "',N'" + _address.Text + "')";
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

