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

namespace Gym
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        
        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.cnstr);
            try
            {
                conn.Open();
                string _username = username.Text;
                string _password = password.Text;
                string sql = "select * from Account where userID ='" + _username + "'and password ='" + _password + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader data = (SqlDataReader)cmd.ExecuteReader();

                if (username.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên tài khoản");
                }
                if (password.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu");
                }

                if (username.Text != "" && password.Text != "")
                    if (data.Read() == true)
                    {
                        //MessageBox.Show("dang nhap thanh cong");
                        var homeForm = new Home();
                        this.Hide();
                        homeForm.ShowDialog();
                        this.Close();

                    }

                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu");
            }
            finally
            {
                conn.Close();
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
                password.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
            
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if(password.Text== "*******")
            {
                password.Text = "";
                password.ForeColor = Color.Black;

            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "*******";
                password.ForeColor = Color.Silver;
            }
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "User Name")
            {
                username.Text = "";
                username.ForeColor = Color.Black;

            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "User Name";
                username.ForeColor = Color.Silver;
            }
        }
    }


}
