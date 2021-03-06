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
    public partial class addDevice : Form
    {
        public addDevice()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        private void addButton_Click(object sender, EventArgs e)
        {

            try

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
                string st = "Insert into Device(deviceID,deviceName,amount,status,importDate,anh,nv)" + "values (N'" + _deviceID.Text + "',N'" + _deviceName.Text + "','" + _amount.Text + "',N'" + comboBox1.Text + "','" + dateTimePicker1.Text + "','" + filePath + "',N'"+comboBox2+"')";
                comm.CommandText = st;
                comm.Connection = conn;

                int ret = comm.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Thêm thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                   
                }
                else
                {
                    MessageBox.Show("loi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi:" + ex.Message);
            }

        }
        OpenFileDialog _openFileDialog = new OpenFileDialog();
        private void addPictureBox1_Click(object sender, EventArgs e)
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

        private void addDevice_Load(object sender, EventArgs e)
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



        //private byte[] ConverImgToByte()
        //{
        //    FileStream fs;
        //    fs = new FileStream(_openFileDialog.FileName, FileMode.Open, FileAccess.Read);
        //    byte[] picbyte = new byte[fs.Length];
        //    fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
        //    fs.Close();
        //    return picbyte;
        //}
    }
}
