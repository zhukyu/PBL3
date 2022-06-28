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
    public partial class FormCourseReceipt : Form
    {
        public FormCourseReceipt()
        {
            InitializeComponent();
        }

        public FormCourseReceipt(string str)
        {
            InitializeComponent();
            this._receiptID.Text = str;
        }

        private void CourseReceipt_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.cnstr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select a.registerDate, b.fullName, c.fullName, c.idNumber, c.phoneNumber, c.address, a.courseID, a.price, a.teacherID " +
                    "from CourseReceipt a, Employee b, Customer c " +
                    $"where a.receiptID = '{_receiptID.Text}' and a.employeeID = b.employeeID and a.customerID = c.customerID", conn);
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    _publishDate.Text = rd.GetDateTime(0).ToString("dd-MM-yyyy");
                    _cashier.Text = rd.GetString(1);
                    _customerName.Text = rd.GetString(2);
                    _idNumber.Text = rd.GetString(3);
                    _phoneNumber.Text = rd.GetString(4);
                    _address.Text = rd.GetString(5);

                    string courseID = rd.GetString(6);
                    string total = rd.GetInt32(7).ToString();
                    string teacherID = rd.GetString(8);

                    rd.Close();
                    cmd = new SqlCommand("select courseName, duration from Course " +
                        $"where courseID = '{courseID}'", conn);
                    rd = cmd.ExecuteReader();
                    if(rd.Read())
                    {
                        string courseName = rd.GetString(0);
                        string duration = rd.GetString(1);
                        courseList.Rows.Add(
                            courseName,
                            duration
                            );
                        if(teacherID != null)
                        {
                            courseList.Rows[0].Cells[2].Value = true;
                        }
                        courseList.Rows[0].Cells[3].Value = total;
                    }
                    rd.Close();
                    courseList.ClearSelection();
                    _total.Text = total;

                }
                else
                {
                    MessageBox.Show("Không có dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
