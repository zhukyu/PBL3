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
                    if(result)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
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
    }
}
