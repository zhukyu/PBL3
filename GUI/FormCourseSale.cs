using Gym.BLL;
using Gym.DTO;
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

namespace Gym
{
    public partial class FormCourseSale : Form
    {
        Customer customer;
        int teacherIndex = 0;
        int courseIndex = 0;
        // lưu giá trị của vị trí index trong combobox
        List<Employee> teachers = new List<Employee>();
        List<Course> courses = new List<Course>();
        public FormCourseSale()
        {
            InitializeComponent();
        }
        public FormCourseSale(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void courseSale_Load(object sender, EventArgs e)
        {
            _cashier.Text = Program.userName;
            _customerID.Text = customer._customerID;
            _fullName.Text = customer._fullName;
            _idNumber.Text = customer._idNumber;
            _phoneNumber.Text = customer._phoneNumber;
            try
            {
                teachers = EmployeeBLL.GetAllPTs();
                courses = CourseBLL.GetAllCourses();
                foreach(Employee teacher in teachers)
                {
                    teacherCb.Items.Add(teacher._fullName);
                }
                foreach(Course course in courses)
                {
                    courseCb.Items.Add(course._courseName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void courseCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseIndex = courseCb.SelectedIndex;
            this._duration.Text = courses[courseIndex]._duration.ToString() + " Tháng";
            this._price.Text = courses[courseIndex]._price.ToString();
        }

        

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn đăng ký ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    int duration = Convert.ToInt32(courses[courseIndex]._duration.Split(" ")[0]); // lấy ra số tháng
                    CourseReceipt courseReceipt = new CourseReceipt(
                        CourseReceiptBLL.GenerateID(),
                        customer._customerID,
                        courses[courseIndex]._courseID,
                        teachers[teacherIndex]._employeeID,
                        Program.userID,
                        DateTime.Today,
                        DateTime.Today.AddMonths(duration),
                        Convert.ToInt32(_price.Text)

                    );;
                    bool result = CourseReceiptBLL.InsertCourseReceipt(courseReceipt);
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
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void teacherCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            teacherIndex = teacherCb.SelectedIndex;
            if (teacherCb.SelectedIndex != -1)
            {
                int duration = Convert.ToInt32(courses[courseIndex]._duration.Split(" ")[0]); // lấy ra số tháng
                int price = courses[courseIndex]._price + 50000 * duration;
                this._price.Text = price.ToString();
            }
            else
            {
                this._price.Text = courses[courseIndex]._price.ToString();
            }
        }
    }
}
