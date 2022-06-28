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
using Gym.DTO;
using Gym.BLL;

namespace Gym
{
    public partial class UCDevice : UserControl
    {
        List<Device> devices;
        int selectedIndex = 0;
        public UCDevice()
        {
            InitializeComponent();
        }

        private void DGV_Load()
        {
            DeviceDGV.Rows.Clear();
            if (devices.Count == 0)
                return;
            foreach (Device device in devices)
            {
                DeviceDGV.Rows.Add(
                    device._deviceID,
                    device._deviceName,
                    device._amount,
                    device._status,
                    device._importDate
                );
            }
            DeviceDGV.Rows[selectedIndex].Cells[0].Selected = true;
            DeviceInfo(devices[selectedIndex]);
        }
        private void DeviceInfo(Device device)
        {
            _deviceID.Text = device._deviceID;
            _deviceName.Text = device._deviceName;
            _amount.Text = device._amount.ToString();
            _status.Text = device._status;
            _importDate.Text = device._importDate.ToString("dd-MM-yyyy");
            _employeeID.Text = EmployeeBLL.GetEmployeeName(device._employeeID);



            Image img = ImageHandle.GetImage(device._image);

            if (img != null)
            {
                devicePicture.Image = img;
            }
            else
                devicePicture.Image = Properties.Resources.icons8_barbell_60px;

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            FormAddDevice frm = new FormAddDevice();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            UCDevice_Load(sender, e);
        }

        private void editButton_Click(object sender, EventArgs e)
        {


            try
            {
                if (DeviceDGV.Rows.Count == 0)
                    throw new Exception("Bạn chưa chọn dữ liệu");
                string deviceID = DeviceDGV.CurrentRow.Cells[0].Value.ToString();
                Device device = devices.Find(x => x._deviceID == deviceID);
                FormUpdateDevice updatedevice = new FormUpdateDevice(device);
                updatedevice.ShowDialog();
                selectedIndex = DeviceDGV.CurrentRow.Index;
                UCDevice_Load(sender, e);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    if (DeviceDGV.Rows.Count == 0)
                        throw new Exception("Bạn chưa chọn dữ liệu");
                    string deviceID = DeviceDGV.CurrentRow.Cells[0].Value.ToString();
                    bool result = DeviceBLL.DeleteDevice(deviceID);
                    if (result)
                    {
                        MessageBox.Show("Đã xóa thành công");
                        selectedIndex = 0;
                        UCDevice_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Đã xóa thất bại");

                    }

                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Bạn chưa chọn dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                devices = DeviceBLL.SearchDevice(searchTB.Text);
                DGV_Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DeviceDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DeviceDGV.Rows.Count == 0)
                return;
            string deviceID = DeviceDGV.CurrentRow.Cells[0].Value.ToString();
            Device device = devices.Find(x => x._deviceID == deviceID);
            DeviceInfo(device);
        }



        private void UCDevice_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            devices = DeviceBLL.GetAllDevices();
            DGV_Load();
        }
    }
}
