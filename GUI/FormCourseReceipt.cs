using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym.BLL;
using Gym.DTO;

namespace Gym
{
    public partial class FormCourseReceipt : Form
    {
        CourseReceipt receipt;
        public FormCourseReceipt()
        {
            InitializeComponent();
        }

        public FormCourseReceipt(CourseReceipt receipt)
        {
            InitializeComponent();
            this.receipt = receipt;
        }

        private void CourseReceipt_Load(object sender, EventArgs e)
        {
            try
            {
                string cashier = EmployeeBLL.GetEmployeeName(receipt._employeeID);
                _receiptID.Text = receipt._receiptID;   
                _publishDate.Text = receipt._registerDate.ToString("dd/MM/yyyy");
                _cashier.Text = cashier;
                Customer customer = CustomerBLL.SearchCustomer(receipt._customerID)[0];
                _customerName.Text = customer._fullName;
                _idNumber.Text = customer._idNumber;
                _phoneNumber.Text = customer._phoneNumber;
                _address.Text = customer._address;

                Course course = CourseBLL.SearchCourse(receipt._courseID)[0];
                courseList.Rows.Add(
                    course._courseName,
                    course._duration,
                    receipt._teacherID != "" ? true : false,
                    receipt._price
                );
                _total.Text = receipt._price.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
