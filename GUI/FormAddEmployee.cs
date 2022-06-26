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
                    MessageBox.Show("Lỗi: " + ex.ToString());
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
                    Bitmap img = new Bitmap(openFile.FileName);
                    employeePicture.Image = (Bitmap)img.Clone();
                    img.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }


}

