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
        string str = @"Data Source=DESKTOP-S7H27N8\SQLEXPRESS;Initial Catalog=GymDatabase;Integrated Security=True";

        private void addButton_Click(object sender, EventArgs e)
        {
            try

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
                string st = "Insert into Customer(customerID,fullName,gender,birthday,phoneNumber,address,idNumber)" + "values (N'" + _customerID.Text + "',N'" + _fullName.Text + "','" + gioitinh.Text + "','" + dateTimePicker1.Text + "','" + _phoneNumber.Text + "',N'" + _address.Text + "','" + _idNumber.Text + "')";
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
