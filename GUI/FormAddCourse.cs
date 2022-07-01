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

    public partial class FormAddCourse : Form
    {
        public FormAddCourse()
        {
            InitializeComponent();
        }

        

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DialogResult dlr = MessageBox.Show("Bạn có muốn thêm dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    try
                    {
                        Course course = new Course(
                            _courseID.Text,
                            _courseName.Text,
                            _duration.Text,
                            Convert.ToInt32(_price.Text)
                        );
                        bool result = CourseBLL.AddCourse(course);
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
                    catch (Exception)
                    {
                       MessageBox.Show("lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void _courseID_Validating(object sender, CancelEventArgs e)
        {
            if (_courseID.Text == "")
            {
                e.Cancel = true;
                _courseID.Focus();

                errorID.SetError(_courseID, "vui lòng nhập Mã Khóa học!");

            }
            else
            {
                e.Cancel = false;
                errorID.SetError(_courseID, null);
            }
        }

        private void _courseName_Validating(object sender, CancelEventArgs e)
        {
            if (_courseName.Text == "")
            {
                e.Cancel = true;
                _courseName.Focus();

                errorName.SetError(_courseName, "vui lòng nhập Tên khóa học!");

            }
            else
            {
                e.Cancel = false;
                errorName.SetError(_courseName, null);
            }
        }

        private void _duration_Validating(object sender, CancelEventArgs e)
        {
            if (_duration.Text == "")
            {
                e.Cancel = true;
                _duration.Focus();

                errorTime.SetError(_duration, "vui lòng nhập Thời gian khóa học!");

            }
            else
            {
                e.Cancel = false;
                errorTime.SetError(_duration, null);
            }
        }
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private void _price_Validating(object sender, CancelEventArgs e)
        {
            if (_price.Text == "")
            {
                e.Cancel = true;
                _price.Focus();

                errorprice.SetError(_price, "vui lòng nhập Đơn giá khóa học!");

            }
            else if (!IsNumber(_price.Text))
            {
                e.Cancel = true;
                _price.Focus();

                errorprice.SetError(_price, "Vui lòng nhập kí tự số!");

            }
            else
            {
                e.Cancel = false;
                errorprice.SetError(_price, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddCourse_Load(object sender, EventArgs e)
        {
       
            _courseID.Text = CourseBLL.GenerateID();
            _courseID.ReadOnly = true;


        }
    }
}
