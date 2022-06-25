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

        
        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.cnstr);
            try
            {
                conn.Open();
                //string _username = username.Text;
                //string _password = password.Text;
                //string sql = "select * from Account where userID ='" + _username + "'and password ='" + _password + "'";
                //SqlCommand cmd = new SqlCommand(sql, conn);
                
                SqlCommand cmd = new SqlCommand("select * from Account where userID = @_username and password = @_password ", conn);
                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@_username";
                param1.Value = username.Text;
                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@_password";
                param2.Value = password.Text;
                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);

                SqlDataReader data = cmd.ExecuteReader();

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
                        data.Close();
                        Program.userID = username.Text;
                        cmd = new SqlCommand($"Select fullname from Employee where employeeID = '{username.Text}'", conn);
                        SqlDataReader rd = cmd.ExecuteReader();
                        if(rd.Read() == true)
                        {
                            Program.userName = rd.GetString(0);
                        }
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnminMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnminMax.Image = Properties.Resources.min;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnminMax.Image = Properties.Resources.maximum1;

            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
