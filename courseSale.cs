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
    public partial class CourseSale : Form
    {
        int index = 0;
        List<int> durations = new List<int>();
        List<int> prices = new List<int>();
        public CourseSale()
        {
            InitializeComponent();
        }

        private void courseSale_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.cnstr);
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from course", conn);
                SqlDataReader data = (SqlDataReader)cmd.ExecuteReader();
                while(data.Read())
                {
                    int _duration = Convert.ToInt32(data.GetString(2).Split(' ')[0]);
                    int _prices = data.GetInt32(3);
                    durations.Add(_duration);
                    prices.Add(_prices);
                    string str = data.GetString(0) + " - " + data.GetString(1);
                    courseCb.Items.Add(str);
                }
                data.Close();

                cmd = new SqlCommand("select employeeID, fullName from Employee where role = N'Huấn luyện viên'", conn);
                data = (SqlDataReader)cmd.ExecuteReader();
                while (data.Read())
                {
                    string str = data.GetString(0) + " - " + data.GetString(1);
                    teacherCb.Items.Add(str);

                }
                data.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void courseCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = courseCb.SelectedIndex;
            this._duration.Text = durations[index].ToString() + " Tháng";
            this._price.Text = prices[index].ToString();
        }

        private string GenerateID(SqlConnection conn)
        {
            int count = 1;
            StringBuilder ID = new StringBuilder("CR0000");
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 receiptID FROM CourseReceipt ORDER BY receiptID DESC", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            if(rd.Read())
            {
                MessageBox.Show("asd");
                count = Convert.ToInt32(rd.GetString(0).Substring(2)); //lấy số thứ tự
                count++;
            }
            string countStr = count.ToString();
            ID.Remove(ID.Length - countStr.Length, countStr.Length); // CR000 - 12 = CR0
            ID.Append(countStr);
            rd.Close();
            return ID.ToString();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.cnstr);
            try
            {
                conn.Open();
                string _receiptID = GenerateID(conn);
                string _registerDate = DateTime.Today.ToString("yyyyMMdd");
                string _expiredDate = DateTime.Today.AddMonths(durations[index]).ToString("yyyyMMdd");
                string _courseID = courseCb.Text.Split(' ')[0];
                string _teacherID = teacherCb.Text.Split(' ')[0];
                SqlCommand cmd = new SqlCommand("insert into CourseReceipt (receiptID ,customerID, courseID, teacherID, registerDate, expiredDate) " +
                    $"values ('{_receiptID}', '{_customerID.Text}', '{_courseID}', '{_teacherID}', '{_registerDate}', '{_expiredDate}')" , conn);
                MessageBox.Show(_registerDate);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }
    }
}
