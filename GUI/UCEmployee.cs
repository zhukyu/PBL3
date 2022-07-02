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
    public partial class UCEmployee : UserControl
    {
        List<Employee> employees;
        int selectedIndex = 0;

        public UCEmployee()
        {
            InitializeComponent();

        }
        private void DGV_Load()
        {
            EmployeeDGV.Rows.Clear();
            if (employees.Count == 0)
            {
                EmployeeInfo(null);
                return;
            }      
            foreach (Employee employee in employees)
            {
                EmployeeDGV.Rows.Add(
                    employee._employeeID,
                    employee._fullName,
                    employee._gender,
                    employee._birthday.ToString("dd/MM/yyyy"),
                    employee._phoneNumber,
                    employee._idNumber,
                    employee._address,
                    employee._role
                );
            }
            EmployeeDGV.Rows[selectedIndex].Cells[0].Selected = true;
            EmployeeInfo(employees[selectedIndex]);
        }
        private void UCEmployee_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            employees = EmployeeBLL.GetAllEmployees();
            DGV_Load();
        }



        private void addButton_Click(object sender, EventArgs e)
        {
            FormAddEmployee frm = new FormAddEmployee();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            UCEmployee_Load(sender, e);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeDGV.Rows.Count == 0)
                    throw new Exception("Bạn chưa chọn dữ liệu");
                string employeeID = EmployeeDGV.CurrentRow.Cells[0].Value.ToString();
                Employee employee = employees.Find(x => x._employeeID == employeeID);
                FormUpdateEmployee updateEmployee = new FormUpdateEmployee(employee);
                updateEmployee.ShowDialog();
                selectedIndex = EmployeeDGV.CurrentRow.Index;
                UCEmployee_Load(sender, e);
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
                    if (EmployeeDGV.Rows.Count == 0)
                        throw new Exception("Bạn chưa chọn dữ liệu");
                    string employeeID = EmployeeDGV.CurrentRow.Cells[0].Value.ToString();
                    string role = EmployeeDGV.CurrentRow.Cells[7].Value.ToString();
                    if (role == "Quản trị viên")
                    {
                        throw new Exception("Không thể xóa quản trị viên");
                    }
                    bool result = EmployeeBLL.DeleteEmployee(employeeID);
                    if (result)
                    {
                        MessageBox.Show("Đã xóa thành công");
                        selectedIndex = 0;
                        UCEmployee_Load(sender, e);
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
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void EmployeeInfo(Employee employee)
        {
            if(employee == null)
            {
                _employeeID.Text = "";
                _fullName.Text = "";
                _gender.Text = "";
                dateTimePicker1.Text = "";
                _phoneNumber.Text = "";
                _idNumber.Text = "";
                _role.Text = "";
                _address.Text = "";
                employeePicture.Image = Properties.Resources.person_128px1;
                return;
            }
            _employeeID.Text = employee._employeeID;
            _fullName.Text = employee._fullName;
            _gender.Text = employee._gender;
            dateTimePicker1.Text = employee._birthday.ToString("dd-MM-yyyy");
            _phoneNumber.Text = employee._phoneNumber;
            _idNumber.Text = employee._idNumber;
            _role.Text = employee._role;
            _address.Text = employee._address;
            Image img = ImageHandle.GetImage(employee._image);
            
            if (img != null)
            {
                employeePicture.Image = img;
            }
            else
                employeePicture.Image = Properties.Resources.person_128px1;
            
        }
        private void EmployeeDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EmployeeDGV.Rows.Count == 0)
                return;
            string employeeID = EmployeeDGV.CurrentRow.Cells[0].Value.ToString();
            Employee employee = employees.Find(x => x._employeeID == employeeID);
            EmployeeInfo(employee);
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                employees = EmployeeBLL.SearchEmployee(searchTB.Text);
                DGV_Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}