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
using Gym.BLL;
using Gym.DTO;

namespace Gym
{
    public partial class FormAddCustomer : Form
    {
        public FormAddCustomer()
        {
            InitializeComponent();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn Thêm dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    try
                    {
                        Customer customer = new Customer(
                                _customerID.Text,
                                _fullName.Text,
                                _gender.Text,
                                _birthday.Value,
                                _phoneNumber.Text,
                                _idNumber.Text,
                                _address.Text
                                


                            );
                        bool result = CustomerBLL.AddCustomer(customer);
                        if (result)
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.ToString());
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

        private void _customerID_Validating(object sender, CancelEventArgs e)
        {
            if (_customerID.Text=="")
            {
                e.Cancel = true;
                _customerID.Focus();

                errorID.SetError(_customerID, "vui lòng nhập Mã khách hàng!");

            }
            else
            {
                e.Cancel = false;
                errorID.SetError(_customerID, null);
            }
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

        private void FormAddCustomer_Load(object sender, EventArgs e)
        {

            _customerID.Text = CustomerBLL.GenerateID();
            _customerID.ReadOnly = true;
        }
    }
}
