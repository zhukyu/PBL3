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
            _employeeID.Text = employee._employeeID;
            _fullName.Text = employee._fullName;
            _gender.Text = employee._gender;
            _birthday.Value = employee._birthday;
            _phoneNumber.Text = employee._phoneNumber;
            _idNumber.Text = employee._idNumber;
            _address.Text = employee._address;
            _role.Text = employee._role;
            employeePicture.ImageLocation = employee._image;
        }
        

        private void fixButton_Click(object sender, EventArgs e)
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
    }

}










