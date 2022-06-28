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
    public partial class FormAddEmployee : Form
    {
        string fileName = "";
        public FormAddEmployee()
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
                        bool result = EmployeeBLL.AddEmployee(employee);
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
                        errorID.SetError(_employeeID, "Mã Nhân viên đã tồn tại"); // MessageBox.Show("Lỗi: " + ex.ToString());
                    }
                }
            }
        }

        
        
        private void addPictureBox1_Click(object sender, EventArgs e)
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

        private void _employeeID_Validating(object sender, CancelEventArgs e)
        {
            if (_employeeID.Text == "")
            {
                e.Cancel = true;
                _employeeID.Focus();

                errorID.SetError(_employeeID, "vui lòng nhập Mã Nhân viên!");

            }
            else
            {
                e.Cancel = false;
                errorID.SetError(_employeeID, null);
            }
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
    }
    


}

