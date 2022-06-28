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
    public partial class UCCourse : UserControl
    {
        List<Course> courses;
        int selectedIndex = 0;
        public UCCourse()
        {
            InitializeComponent();
        }

        private void DGV_Load()
        {
            CourseDGV.Rows.Clear();
            if (courses.Count == 0)
                return;
            foreach (Course course in courses)
            {
                CourseDGV.Rows.Add(
                    course._courseID,
                    course._courseName,
                    course._duration,
                    course._price
                );
            }
            CourseDGV.Rows[selectedIndex].Cells[0].Selected = true;
            CourseInfo(courses[selectedIndex]);
        }
        private void CourseInfo(Course course)
        {
            _courseID.Text = course._courseID;
            _courseName.Text = course._courseName;
            _duration.Text = course._duration;
            _price.Text = course._price.ToString();

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            FormAddCourse frm = new FormAddCourse();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            UCCourse_Load(sender, e);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CourseDGV.Rows.Count == 0)
                    throw new Exception("Bạn chưa chọn dữ liệu");
                string courseID = CourseDGV.CurrentRow.Cells[0].Value.ToString();
                Course course = courses.Find(x => x._courseID == courseID);
                FormUpdateCourse updateCourse = new FormUpdateCourse(course);
                updateCourse.ShowDialog();
                selectedIndex = CourseDGV.CurrentRow.Index;
                UCCourse_Load(sender, e);
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
                    if (CourseDGV.Rows.Count == 0)
                        throw new Exception("Bạn chưa chọn dữ liệu");
                    string CourseID = CourseDGV.CurrentRow.Cells[0].Value.ToString();
                    bool result = CourseBLL.DeleteCourse(CourseID);
                    if (result)
                    {
                        MessageBox.Show("Đã xóa thành công");
                        selectedIndex = 0;
                        UCCourse_Load(sender, e);
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
                courses = CourseBLL.SearchCourse(search.Text);
                DGV_Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CourseDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CourseDGV.Rows.Count == 0)
                return;
            string courseID = CourseDGV.CurrentRow.Cells[0].Value.ToString();
            Course course = courses.Find(x => x._courseID == courseID);
            CourseInfo(course);
        }



        private void UCCourse_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            courses = CourseBLL.GetAllCourses();
            DGV_Load();
        }

    }

}
