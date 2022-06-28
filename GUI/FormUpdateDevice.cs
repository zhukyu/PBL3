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

        
    }
}


