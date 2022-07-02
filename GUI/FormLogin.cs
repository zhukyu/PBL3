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
using Gym.BLL;
using Gym.DTO;

namespace Gym
{
    public partial class FormLogin : Form
    {
        
        public FormLogin()
        {
            InitializeComponent();
        }

        
        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (username.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (password.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (username.Text != "" && password.Text != "")
                {
                    Account account = new Account(username.Text, password.Text);
                    bool result = AccountBLL.Login(account);
                    if(result)
                    {
                        FormHome formHome = new FormHome(account);
                        this.Hide();
                        formHome.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(this, new EventArgs());
            }
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password.PasswordChar= (char)0;

            }
            else
            {
                password.PasswordChar = '●'; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dg == DialogResult.Yes)
            //    Application.Exit();
            username.Text = "";            
            password.Text = "";

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


        //private void password_Enter(object sender, EventArgs e)
        //{
        //    if(password.Text== "Password")
        //    {
        //        password.Text = "";
        //        password.ForeColor = Color.Black;

        //    }
        //}

        //private void password_Leave(object sender, EventArgs e)
        //{
        //    if (password.Text == "")
        //    {
        //        password.Text = "Password";
        //        password.ForeColor = Color.DimGray;
        //    }
        //}

        //private void username_Enter(object sender, EventArgs e)
        //{
        //    if (username.Text == "Username")
        //    {
        //        username.Text = "";
        //        username.ForeColor = Color.Black;

        //    }
        //}

        //private void username_Leave(object sender, EventArgs e)
        //{
        //    if (username.Text == "")
        //    {
        //        username.Text = "Username";
        //        username.ForeColor = Color.DimGray;
        //    }
        //}


    }


}
