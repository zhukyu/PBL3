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

namespace Gym
{
    public partial class updateDevice : Form
    {
        public updateDevice()
        {
            InitializeComponent();
        }


        SqlConnection conn = null;
        private void editButton_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn thay đổi dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {

                try
                {


                    string maSp = _deviceID.Text;
                    {
                        if (conn == null)
                        {
                            conn = new SqlConnection(Program.cnstr);
                        }
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }

                        SqlCommand comm = new SqlCommand();
                        comm.CommandType = CommandType.Text;
                        string st = "update Device set deviceName=N'" + _deviceID.Text + "',amount=N'" + _amount.Text + "',status=N'" + comboBox1.Text + "',importDate='" + dateTimePicker1.Text + "',nv=N'" + comboBox2.Text + "' " + "where deviceID=@maSp";
                        comm.CommandText = st;
                        comm.CommandText = st;
                        comm.Connection = conn;

                        SqlParameter para = new SqlParameter("@maSp", SqlDbType.NVarChar);
                        para.Value = maSp;
                        comm.Parameters.Add(para);
                        int ret = comm.ExecuteNonQuery();
                        if (ret > 0)
                        {
                            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("lỗi");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi:" + ex.Message);
                }
            }
        }
        OpenFileDialog _openFileDialog = new OpenFileDialog();
        private void updateDevice_Load(object sender, EventArgs e)
        {
            if (conn == null)
            {
                conn = new SqlConnection(Program.cnstr);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select fullName from Employee";
            comm.Connection = conn;


            SqlDataAdapter da = new SqlDataAdapter("select fullName from Employee", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "fullname";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _openFileDialog.Filter = "All files (*.*)|*.*|exe files (*.exe)|*.exe";

                _openFileDialog.FilterIndex = 1;

                _openFileDialog.RestoreDirectory = true;


                if (_openFileDialog.ShowDialog() == DialogResult.OK)

                {
                    string fileName = _openFileDialog.FileName;
                    this.bmp = new Bitmap(fileName);

                    this.pictureBox1.Image = this.bmp;
                }

                string id = _deviceID.Text;
                string file = id + ".jpg";

                this.filePath = "Img\\" + file;
                this.bmp.Save(filePath);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (conn == null)
            {
                conn = new SqlConnection(Program.cnstr);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select *from Employee Where EmployeeID= '" + _deviceID.Text + "'";
            comm.Connection = conn;


            SqlDataReader rar = comm.ExecuteReader();
            string filePath = null;
            if (rar.Read())
            {

                filePath += rar.GetString(5);

            }
            rar.Close();
            conn.Close();
            pictureBox1.Image = null;
            if (File.Exists(filePath))
            {
                // xóa file
                File.Delete(filePath);

                // kiểm tra lại xem file còn tồn tại không.
               
            }
            

        }
    }
}


