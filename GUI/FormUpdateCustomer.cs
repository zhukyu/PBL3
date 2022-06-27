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
using Gym.DTO;
using Gym.BLL;

namespace Gym
{
    public partial class FormUpdateCustomer : Form
    {
        public FormUpdateCustomer()
        {
            InitializeComponent();
        }

        public FormUpdateCustomer(Customer customer)
        {
            InitializeComponent();
            _customerID.Text = customer._customerID;
            _fullName.Text = customer._fullName;
            gioitinh.Text = customer._gender;
            _birtday.Value = customer._birthday;
            _phoneNumber.Text = customer._phoneNumber;
            _idNumber.Text = customer._idNumber;
            _address.Text = customer._address;

        }

        private void fixButton_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn thay đổi dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    Customer customer = new Customer(
                            _customerID.Text,
                            _fullName.Text,
                            gioitinh.Text,
                            _birtday.Value,
                            _phoneNumber.Text,
                            _idNumber.Text,
                            _address.Text
                           
                        );
                    bool result = CustomerBLL.UpdateCustomer(customer);
                    if (result)
                    {
                        MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("lỗi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi:" + ex.ToString());
                }
            }


        }
    }
}
