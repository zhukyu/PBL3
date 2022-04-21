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

namespace Gym
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S7H27N8\SQLEXPRESS;Initial Catalog=Gymmer;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = username.Text;
                string mk = password.Text;
                string sql = "select *from NguoiDung where taikhoan='" + tk + "'and matkhau='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader data = (SqlDataReader)cmd.ExecuteReader();


                if (username.Text == "")
                {
                    MessageBox.Show("ban chua nhap uername");
                }
                if (password.Text == "")
                {
                    MessageBox.Show("ban chua nhap password");
                }

                if (username.Text != "" && password.Text != "")
                    if (data.Read() == true)
                    {
                        MessageBox.Show("dang nhap thanh cong");
                        var homeform = new Home();
                        this.Hide();
                        homeform.Show();
                        // this.Close();

                    }

                    else
                    {
                        MessageBox.Show("dang nhap that bai");
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi ket noi");
            }
            finally
            {
                conn.Close();
            }
        }

        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
