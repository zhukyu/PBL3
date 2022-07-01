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
            if (ValidateChildren(ValidationConstraints.Enabled))
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

                                _address.Text,
                                _idNumber.Text


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
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        

        private void _fullName_Validating(object sender, CancelEventArgs e)
        {
            if (_fullName.Text == "")
            {
                e.Cancel = true;
                _fullName.Focus();

                errorName.SetError(_fullName, "vui lòng nhập Tên khách hàng!");

            }
            else
            {
                e.Cancel = false;
                errorName.SetError(_fullName, null);
            }
        }

        private void _phoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (_phoneNumber.Text == "")
            {
                e.Cancel = true;
                _phoneNumber.Focus();

                errorPhone.SetError(_phoneNumber, "vui lòng nhập SDT khách hàng!");

            }
            else if (!IsNumber(_phoneNumber.Text))
            {
                e.Cancel = true;
                _phoneNumber.Focus();

                errorPhone.SetError(_phoneNumber, "Vui lòng nhập kí tự số!");

            }
            else
            {
                e.Cancel = false;
                errorPhone.SetError(_phoneNumber, null);
            }
        }

        private void _address_Validating(object sender, CancelEventArgs e)
        {
            if (_address.Text == "")
            {
                e.Cancel = true;
                _address.Focus();

                erroradress.SetError(_address, "vui lòng nhập Địa chỉ khách hàng!");

            }
            else
            {
                e.Cancel = false;
                erroradress.SetError(_address, null);
            }

        }

        private void _idNumber_Validating(object sender, CancelEventArgs e)
        {
            if (_idNumber.Text == "")
            {
                e.Cancel = true;
                _idNumber.Focus();

                errorCMND.SetError(_idNumber, "vui lòng CMND khách hàng!");

            }
            else if (!IsNumber(_idNumber.Text))
            {
                e.Cancel = true;
                _idNumber.Focus();

                errorCMND.SetError(_idNumber, "Vui lòng nhập kí tự số!");

            }

            else
            {
                e.Cancel = false;
                errorCMND.SetError(_idNumber, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
