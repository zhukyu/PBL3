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
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi: " + ex.Message);
                }
            }
        }

        
    }
}
