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
    public partial class FormUpdateDevice : Form
    {
        string fileName = null;
        public FormUpdateDevice()
        {
            InitializeComponent();
        }
        public FormUpdateDevice(Device device)
        {
            InitializeComponent();
            _deviceID.Text = device._deviceID;
            _deviceName.Text = device._deviceName;
            _amount.Text = device._amount.ToString();
            _status.Text = device._status;
            _importDate.Value = device._importDate;
            _employeeID.Text = device._employeeID;
            fileName = device._image;
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn thay đổi dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {

                    try
                    {
                        Device device = new Device(
                            _deviceID.Text,
                            _deviceName.Text,
                            Convert.ToInt32(_amount.Text),
                            _status.Text,
                            _importDate.Value,
                            fileName,
                            Program.userID
                        );
                        bool result = DeviceBLL.UpdateDevice(device);
                        if (result)
                        {
                            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("lỗi");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void updateDevice_Load(object sender, EventArgs e)
        {
            _employeeID.Text = Program.userName;
            if (fileName == null)
            {
                devicePicture.Image = Properties.Resources.icons8_barbell_60px;
            }
            else
            {
                devicePicture.Image = ImageHandle.GetImage(fileName);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            devicePicture.Image = Properties.Resources.icons8_barbell_60px;
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
                    devicePicture.Image = ImageHandle.GetImage(fileName);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void _deviceName_Validating(object sender, CancelEventArgs e)
        {
            if (_deviceName.Text == "")
            {
                e.Cancel = true;
                _deviceName.Focus();

                errorName.SetError(_deviceName, "vui lòng nhập Tên Thiết bị!");

            }
            else
            {
                e.Cancel = false;
                errorName.SetError(_deviceName, null);
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
        private void _amount_Validating(object sender, CancelEventArgs e)
        {
            if (_amount.Text == "")
            {
                e.Cancel = true;
                _amount.Focus();

                errorSL.SetError(_amount, "vui lòng Số lượng!");

            }
            else if (!IsNumber(_amount.Text))
            {
                e.Cancel = true;
                _amount.Focus();

                errorSL.SetError(_amount, "Vui lòng nhập kí tự số!");

            }
            else
            {
                e.Cancel = false;
                errorSL.SetError(_amount, null);
            }
        }

        private void _status_Validating(object sender, CancelEventArgs e)
        {
            if (_status.Text == "")
            {
                e.Cancel = true;
                _status.Focus();

                error_status.SetError(_status, "vui lòng nhập Trạng thái thiết bị!");

            }
            else
            {
                e.Cancel = false;
                error_status.SetError(_status, null);
            }
        }

        private void _employeeID_Validating(object sender, CancelEventArgs e)
        {
            if (_employeeID.Text == "")
            {
                e.Cancel = true;
                _employeeID.Focus();

                errorQL.SetError(_employeeID, "vui lòng nhập Nhân viên quản lý!");

            }
            else
            {
                e.Cancel = false;
                errorQL.SetError(_employeeID, null);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


