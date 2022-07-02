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
    public partial class FormUpdateEmployee : Form
    {
        string fileName = null;

        public FormUpdateEmployee()
        {
            InitializeComponent();
        }
        public FormUpdateEmployee(Employee employee)
        {
            InitializeComponent();
            fileName = employee._image;
            _employeeID.Text = employee._employeeID;
            _fullName.Text = employee._fullName;
            _gender.Text = employee._gender;
            _birthday.Value = employee._birthday;
            _phoneNumber.Text = employee._phoneNumber;
            _idNumber.Text = employee._idNumber;
            _address.Text = employee._address;
            _role.Text = employee._role;
            if(fileName == null)
                employeePicture.Image = Properties.Resources.person_128px1;
            else
                employeePicture.ImageLocation = employee._image;
            Account temp = AccountBLL.GetAccount(_employeeID.Text);
            _password.Text = temp._password;
            if(employee._role == "Quản trị viên")
            {
                _role.DropDownStyle = ComboBoxStyle.DropDown;
                _role.Text = "Quản trị viên";
                _role.Enabled = false;
            }
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
                        Employee employee = new Employee(
                                _employeeID.Text,
                                _fullName.Text,
                                _gender.Text,
                                _birthday.Value,
                                _phoneNumber.Text,
                                _idNumber.Text,
                                _address.Text,
                                _role.Text,
                                fileName
                            );
                        bool result = EmployeeBLL.UpdateEmployee(employee);
                        Account account = new Account(_employeeID.Text, _password.Text);
                        result = AccountBLL.UpdateAccount(account);
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
       
        private void button1_Click(object sender, EventArgs e)
        {

            employeePicture.Image = Properties.Resources.person_128px1;
            fileName = null;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
                openFile.FilterIndex = 1;
                openFile.RestoreDirectory = true;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFile.FileName;
                    employeePicture.Image = ImageHandle.GetImage(fileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void updateEmployee_Load(object sender, EventArgs e)
        {

        }

        private void _fullName_Validating(object sender, CancelEventArgs e)
        {
            if (_fullName.Text == "")
            {
                e.Cancel = true;
                _fullName.Focus();

                errorName.SetError(_fullName, "vui lòng nhập Tên Nhân viên!");

            }
            else
            {
                e.Cancel = false;
                errorName.SetError(_fullName, null);
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

                errorPhone.SetError(_phoneNumber, "vui lòng nhập SDT Nhân viên!");

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

        private void _idNumber_Validating(object sender, CancelEventArgs e)
        {
            if (_idNumber.Text == "")
            {
                e.Cancel = true;
                _idNumber.Focus();

                errorCMND.SetError(_idNumber, "Vui lòng nhập CMND Nhân viên!");

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

        private void _role_Validating(object sender, CancelEventArgs e)
        {
            if (_role.Text == "")
            {
                e.Cancel = true;
                _role.Focus();

                errorChucvu.SetError(_role, "Vui lòng nhập Chức vụ!");

            }
            else
            {
                e.Cancel = false;
                errorChucvu.SetError(_role, null);
            }
        }

        private void _address_Validating(object sender, CancelEventArgs e)
        {
            if (_address.Text == "")
            {
                e.Cancel = true;
                _address.Focus();

                erroradress.SetError(_address, "Vui lòng nhập Địa chỉ Nhân viên!");

            }
            else
            {
                e.Cancel = false;
                erroradress.SetError(_address, null);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}










