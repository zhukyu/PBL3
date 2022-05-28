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
    public partial class updateEmployee : Form
    {
        public updateEmployee()
        {
            InitializeComponent();
        }
        OpenFileDialog _openFileDialog = new OpenFileDialog();

        SqlConnection conn = null;

        private void fixButton_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn thay đổi dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    updateEmployee em = new updateEmployee();
                    string maSp = _employeeID.Text;
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
                        string st = "update Employee set  fullName=N'" + _fullName.Text + "',gender=N'" + gioitinh.Text + "',birthday='" + dateTimePicker1.Text + "',phoneNumber='" + _phoneNumber.Text + "',idNumber='" + _idNumber.Text + "',role=N'" + comboBox1.Text + "',address=N'" + _address.Text + "' " + "where employeeID=@maSp";
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

        //private void fixPictureBox1_Click(object sender, EventArgs e)
        //        {

        //            _openFileDialog.Filter = "All files (*.*)|*.*|exe files (*.exe)|*.exe";

        //            _openFileDialog.FilterIndex = 1;

        //            _openFileDialog.RestoreDirectory = true;
        //            if (_openFileDialog.ShowDialog() == DialogResult.OK)

        //            {

        //                string fileName = _openFileDialog.FileName;
        //                this.bmp = new Bitmap(fileName);

        //                this.pictureBox1.Image = this.bmp;
        //            }

        //            string id = _employeeID.Text;
        //            string file = id + ".jpg";

        //            this.filePath = "Img\\" + file;
        //            this.bmp.Save(filePath);

        //        }

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










