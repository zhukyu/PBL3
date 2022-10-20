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
    public partial class UCCustomer : UserControl
    {
        List<Customer> customers;
        int selectedIndex = 0;
        public UCCustomer()
        {
            InitializeComponent();
        }
        private void DGV_Load()
        {
            CustomerDGV.Rows.Clear();
            if (customers.Count == 0)
                return;
            foreach (Customer customer in customers)
            {
                CustomerDGV.Rows.Add(
                    customer._customerID,
                    customer._fullName,
                    customer._gender,
                    customer._birthday.ToString("dd/MM/yyyy"),
                    customer._phoneNumber,                   
                    customer._idNumber,
                    customer._address
                );
            }
            CustomerDGV.Rows[selectedIndex].Cells[0].Selected = true;
            CustomerInfo(customers[selectedIndex]);
        }
        private void UCCustomer_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            customers = CustomerBLL.GetAllCustomers();
            DGV_Load();
        }
        private void addButton_Click(object sender, EventArgs e)
        {

            FormAddCustomer frm = new FormAddCustomer();
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.FormClosing += new FormClosingEventHandler(this.addCustomer_FormClosing);
            frm.ShowDialog();
            UCCustomer_Load(sender, e);
        }

        private void addCustomer_FormClosing(object? sender, FormClosingEventArgs e)
        {
            
        }

      

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomerDGV.Rows.Count == 0)
                    throw new Exception("Bạn chưa chọn dữ liệu");
                string customerID = CustomerDGV.CurrentRow.Cells[0].Value.ToString();
                Customer customer = customers.Find(x => x._customerID == customerID);
                FormUpdateCustomer updateCustomer = new FormUpdateCustomer(customer);
                updateCustomer.ShowDialog();
                selectedIndex = CustomerDGV.CurrentRow.Index;
                UCCustomer_Load(sender, e);
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
       
        private void CustomerInfo(Customer customer)
        {
            if(customer == null)
            {
                _customerID.Text = "";
                _fullName.Text = "";
                _gender.Text = "";
                _birthday.Text = "";
                _phoneNumber.Text = "";
                _address.Text = "";
                _idNumber.Text = "";
                return;
            }
            _customerID.Text = customer._customerID;
            _fullName.Text = customer._fullName;
            _gender.Text = customer._gender;
            _birthday.Text = customer._birthday.ToString("dd/MM/yyyy");
            _phoneNumber.Text = customer._phoneNumber;
            _idNumber.Text = customer._idNumber;
            _address.Text = customer._address;
            

        }
        private void editCustomer_FormClosing(object? sender, FormClosingEventArgs e)
        {
           
        }

        
       

        

        

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    if (CustomerDGV.Rows.Count == 0)
                        throw new Exception("Bạn chưa chọn dữ liệu");
                    string customerID = CustomerDGV.CurrentRow.Cells[0].Value.ToString();
                    bool result = CustomerBLL.DeleteCustomer(customerID);
                    if (result)
                    {
                        MessageBox.Show("Đã xóa thành công");
                        selectedIndex = 0;
                        UCCustomer_Load(sender, e);
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

        private void CustomerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CustomerDGV.Rows.Count == 0)
            {
                CustomerInfo(null);
                return;
            }
            string customerID = CustomerDGV.CurrentRow.Cells[0].Value.ToString();
            Customer customer = customers.Find(x => x._customerID == customerID);
            CustomerInfo(customer);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                customers = CustomerBLL.SearchCustomer(searchkh.Text);
                DGV_Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomerDGV.Rows.Count == 0)
                    throw new Exception("Bạn chưa chọn dữ liệu");
                string customerID = CustomerDGV.CurrentRow.Cells[0].Value.ToString();
                Customer customer = customers.Find(x => x._customerID == customerID);
                FormCourseSale formCourseSale = new FormCourseSale(customer);
                formCourseSale.ShowDialog();
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
    }
}

