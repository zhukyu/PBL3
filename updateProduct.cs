﻿using System;
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
    public partial class updateProduct : Form
    {
        public updateProduct()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        private void addButton_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn thay đổi dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {


                    string maSp = _productID.Text;
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
                        string st = "update product set  productName=N'" + _productName.Text + "',amount=N'" + _amount.Text + "',price='" + _price.Text + "' " + "where productID=@maSp";
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

                string id = _productID.Text;
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
            comm.CommandText = "select *from Employee Where EmployeeID= '" + _productID.Text + "'";
            comm.Connection = conn;


            SqlDataReader rar = comm.ExecuteReader();
            string filePath = null;
            if (rar.Read())
            {

                filePath += rar.GetString(4);

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
        //OpenFileDialog _openFileDialog = new OpenFileDialog();
        //        private void addPictureBox1_Click(object sender, EventArgs e)
        //        {



        //                _openFileDialog.Filter = "All files (*.*)|*.*|exe files (*.exe)|*.exe";

        //                _openFileDialog.FilterIndex = 1;

        //                _openFileDialog.RestoreDirectory = true;
        //            if (_openFileDialog.ShowDialog() == DialogResult.OK)

        //            {
        //                string fileName = _openFileDialog.FileName;
        //                this.bmp = new Bitmap(fileName);

        //                this.pictureBox1.Image = this.bmp;
        //            }

        //            string id = _productID.Text;
        //            string file = id + ".jpg";

        //            this.filePath = "Img\\" + file;
        //            this.bmp.Save(filePath);
        //        }



        //            private byte[] ConverImgToByte()
        //            {
        //                FileStream fs;
        //                fs = new FileStream(_openFileDialog.FileName, FileMode.Open, FileAccess.Read);
        //                byte[] picbyte = new byte[fs.Length];
        //                fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
        //                fs.Close();
        //                return picbyte;
        //            }
    }
}

