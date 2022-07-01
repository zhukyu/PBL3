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
    public partial class FormAddDevice : Form
    {
        string fileName = null;
        public FormAddDevice()
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
                        Device device = new Device(
                            _deviceID.Text,
                            _deviceName.Text,
                            Convert.ToInt32(_amount.Text),
                            _status.Text,
                            _importDate.Value,
                            fileName,
                            Program.userID
                        );
                        bool result = DeviceBLL.AddDevice(device);
                        if (result)
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("loi");
                        }
                    }
                    catch (Exception)
                    {
                        errorID.SetError(_deviceID, "Mã khách hàng đã tồn tại");//MessageBox.Show("lỗi:" + ex.Message);
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
                    devicePicture.Image = ImageHandle.GetImage(fileName);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void addDevice_Load(object sender, EventArgs e)
        {
            _employeeID.Text = Program.userName;
        }

        private void _deviceID_Validating(object sender, CancelEventArgs e)
        {
            if (_deviceID.Text == "")
            {
                e.Cancel = true;
                _deviceID.Focus();

                errorID.SetError(_deviceID, "vui lòng nhập Mã Thiết bị!");

            }
            else
            {
                e.Cancel = false;
                errorID.SetError(_deviceID, null);
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

                errorSL.SetError(_amount, "vui lòng nhập Số lượng !");

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

                errorName.SetError(_status, "vui lòng nhập Trạng thái thiết bị!");

            }
            else
            {
                e.Cancel = false;
                errorName.SetError(_status, null);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
