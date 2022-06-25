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
        string fileName = "";
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
                        string st = "update Device set deviceName=N'" + _deviceID.Text + "',amount=N'" + _amount.Text + "',status=N'" + comboBox1.Text + "',importDate='" + dateTimePicker1.Text + "',nv=N'" + comboBox2.Text + "' ,anh=N'" + fileName + "'" + "where deviceID=@maSp";
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
            comm.CommandText = "select *from  Device";
            comm.Connection = conn;


            SqlDataReader rar = comm.ExecuteReader();

            while (rar.Read())
            {
                fileName = rar.GetString(5);


            }
            rar.Close();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            fileName = "";
        }
        private byte[] converImgToByte()
        {
            FileStream fs;
            fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
                openFile.FilterIndex = 1;
                openFile.RestoreDirectory = true;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFile.FileName;
                    fileName = Convert.ToBase64String(converImgToByte());
                    pictureBox1.ImageLocation = openFile.FileName;
                    pictureBox1.Load();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


