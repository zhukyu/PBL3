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
    public partial class addEmployee : Form
    {
        public addEmployee()
        {
            InitializeComponent();
        }
        OpenFileDialog openFile = new OpenFileDialog();
        
       
        
        SqlConnection conn = null;
        string fileName = "";
        private void addButton_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn Thêm dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
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
                    string st = "Insert into Employee(employeeID,fullName,gender,birthday,phoneNumber,idNumber,role,address,anh)" + "values (N'" + _employeeID.Text + "',N'" + _fullName.Text + "',N'" + gioitinh.Text + "','" + dateTimePicker1.Value.ToString("yyyyMMdd") + "','" + _phoneNumber.Text + "','" + _idNumber.Text + "',N'" + comboBox1.Text + "',N'" + _address.Text + "',N'" + fileName + "')";
                    comm.CommandText = st;
                    comm.Connection = conn;

                    int ret = comm.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
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
        }

        
        
        private void addPictureBox1_Click(object sender, EventArgs e)
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
                //_openFileDialog.Filter = "All files (*.*)|*.*|exe files (*.exe)|*.exe";

                //_openFileDialog.FilterIndex = 1;

                //_openFileDialog.RestoreDirectory = true;


                //if (_openFileDialog.ShowDialog() == DialogResult.OK)

                //{
                //    string fileName = _openFileDialog.FileName;
                //    this.bmp = new Bitmap(fileName);

                //    this.pictureBox1.Image = this.bmp;
                //}

                //string id = _employeeID.Text;
                //string file = id + ".jpg";

                //this.filePath = "Img\\" + file;
                //this.bmp.Save(filePath);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}

