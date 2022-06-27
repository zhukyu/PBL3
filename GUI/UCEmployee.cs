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
        SqlConnection conn = null;

        string maSp=null;
        
        public UCEmployee()
        {
            InitializeComponent();

        }
        private void DGV_Load()
        {
            EmployeeDGV.Rows.Clear();
            if (employees.Count == 0)
                return;
            foreach (Employee employee in employees)
            {
                EmployeeDGV.Rows.Add(
                    employee._employeeID,
                    employee._fullName,
                    employee._gender,
                    employee._birthday.ToString("dd-MM-yyyy"),
                    employee._phoneNumber,
                    employee._idNumber,
                    employee._address,
                    employee._role
                );
            }
            EmployeeInfo(employees[0]);
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

            frm.FormClosing += new FormClosingEventHandler(this.addEmployee_FormClosing);
            frm.ShowDialog();
            UCEmployee_Load(sender, e);
        }

        private void addEmployee_FormClosing(object? sender, FormClosingEventArgs e)
        {
            
           
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
                    bool result = EmployeeBLL.DeleteEmployee(employeeID);
                    if (result)
                    {
                        MessageBox.Show("Đã xóa thành công");
                        UCEmployee_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Đã xóa thất bại");

                    }
                    UCEmployee_Load(sender, e);
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

        
        private void EmployeeInfo(Employee employee)
        {
            _employeeID.Text = employee._employeeID;
            _fullName.Text = employee._fullName;
            _gender.Text = employee._gender;
            dateTimePicker1.Text = employee._birthday.ToString("dd-MM-yyyy");
            _phoneNumber.Text = employee._phoneNumber;
            _idNumber.Text = employee._idNumber;
            _role.Text = employee._role;
            _address.Text = employee._address;
            Image temp = ImageHandle.GetImage(employee._image);
            
            if (temp != null)
            {
                Image img = (Image)temp.Clone();
                employeePicture.Image = img;
                temp.Dispose();
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











/*private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
    _employeeID.ReadOnly = true;
    int i;
    i = dataGridView1.CurrentRow.Index;
    _employeeID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
    _fullName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
    _gender.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
    textBox1.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
    _phoneNumber.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
    _idNumber.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
    _role.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
    _address.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();

}*/

/*private void deleteButton_Click(object sender, EventArgs e)
{
    cm = conn.CreateCommand();
    cm.CommandText = "delete from Employee where employeeID = '" + _employeeID.Text + "'";
    cm.ExecuteNonQuery();
    loaddata();
}

private void addButton_Click(object sender, EventArgs e)
{
    cm = conn.CreateCommand();
    cm.CommandText = "insert into Employee values('" + _employeeID.Text + "','" + _fullName.Text + "','" + _gender.Text + "','" + textBox1.Text + "','" + _phoneNumber.Text + "','" + _idNumber.Text + "','" + _role.Text + "','" + _address.Text + "')";
    cm.ExecuteNonQuery();
    loaddata();
}
private void edit_Click(object sender, EventArgs e)
{
    //Form frm = new updateEmployee();
    //frm.Show();
    cm = conn.CreateCommand();
    cm.CommandText = "update Employee set  fullName ='"+ _fullName.Text + "',gender='" + _gender.Text + "',birthday='" + textBox1.Text + "',phoneNumber='" + _phoneNumber.Text + "',idNumber='" + _idNumber.Text + "',role='" + _role.Text + "',address='"+_address+ "' where employeeID = '" + _employeeID.Text + "'";
    cm.ExecuteNonQuery();
    loaddata();
}
*/

