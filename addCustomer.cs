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
    public partial class addCustomer : Form
    {
        public addCustomer()
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
                string st = "Insert into Customer(customerID,fullName,gender,birthday,phoneNumber,address,idNumber)" + "values (N'" + _customerID.Text + "',N'" + _fullName.Text + "','" + gioitinh.Text + "','" + dateTimePicker1.Text + "','" + _phoneNumber.Text + "',N'" + _address.Text + "','" + _idNumber.Text + "')";
                comm.CommandText = st;
                comm.Connection = conn;

                int ret = comm.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm Thất bại");
                }
        }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi:" + ex.Message);
            }
}
    }
}
