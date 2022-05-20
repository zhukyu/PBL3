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
    public partial class Customer : UserControl
    {
        public Customer()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        private void addButton_Click(object sender, EventArgs e)
        {
            addCustomer frm = new addCustomer();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.FormClosing += new FormClosingEventHandler(this.addCustomer_FormClosing);
            frm.ShowDialog();
        }

        private void addCustomer_FormClosing(object? sender, FormClosingEventArgs e)
        {
            hienthitoanbosanpham();
        }

        public void hienthitoanbosanpham()
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
            comm.CommandText = "select *from Customer";
            comm.Connection = conn;


            SqlDataReader rar = comm.ExecuteReader();
            listView1.Items.Clear();
            while (rar.Read())
            {
                ListViewItem lvi = new ListViewItem(rar.GetString(0));
                lvi.SubItems.Add(rar.GetString(1));
                lvi.SubItems.Add(rar.GetString(2));
                lvi.SubItems.Add(rar.GetDateTime(3).ToString("dd-MM-yyyy"));
                lvi.SubItems.Add(rar.GetString(4));
                lvi.SubItems.Add(rar.GetString(5));
                lvi.SubItems.Add(rar.GetString(6));

                listView1.Items.Add(lvi);

            }
            rar.Close();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            hienthitoanbosanpham();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listView1.SelectedItems[0];
                string maSp = lvi.SubItems[0].Text;
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
                comm.CommandText = "select *from Customer where customerID=@maSp";
                comm.Connection = conn;

                SqlParameter para = new SqlParameter("@maSp", SqlDbType.NVarChar);
                para.Value = maSp;
                comm.Parameters.Add(para);

                _customerID.ReadOnly = true;
                SqlDataReader rar = comm.ExecuteReader();
                while (rar.Read())
                {

                    _customerID.Text = lvi.SubItems[0].Text;
                    _fullName.Text = lvi.SubItems[1].Text;
                    _gender.Text = lvi.SubItems[2].Text;
                    dateTimePicker1.Text = lvi.SubItems[3].Text;
                    _phoneNumber.Text = lvi.SubItems[4].Text;
                    _idNumber.Text = lvi.SubItems[5].Text;
                    _address.Text = lvi.SubItems[6].Text;
                }

                rar.Close();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                updateCustomer anh = new updateCustomer();

                ListViewItem lvi = listView1.SelectedItems[0];
                string maSp = lvi.SubItems[0].Text;
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
                comm.CommandText = "select *from Customer where customerID=@maSp";

                comm.Connection = conn;

                SqlParameter para = new SqlParameter("@maSp", SqlDbType.NVarChar);
                para.Value = maSp;
                comm.Parameters.Add(para);

                _customerID.ReadOnly = true;
                SqlDataReader rar = comm.ExecuteReader();
                while (rar.Read())
                {

                    anh._customerID.Text = lvi.SubItems[0].Text;
                    anh._fullName.Text = lvi.SubItems[1].Text;
                    anh.gioitinh.Text = lvi.SubItems[2].Text;
                    anh.dateTimePicker1.Text = lvi.SubItems[3].Text;
                    anh._phoneNumber.Text = lvi.SubItems[4].Text;
                    anh._idNumber.Text = lvi.SubItems[6].Text;

                    anh._address.Text = lvi.SubItems[5].Text;



                }

                rar.Close();
                anh.StartPosition = FormStartPosition.CenterScreen;
                anh.FormClosing += new FormClosingEventHandler(this.editCustomer_FormClosing);
                anh.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ban chua chon du lieu");
            }
        }

        private void editCustomer_FormClosing(object? sender, FormClosingEventArgs e)
        {
            hienthitoanbosanpham();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem lvi = listView1.SelectedItems[0];
                string maSp = lvi.SubItems[0].Text;
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
                comm.CommandText = "delete from Customer where customerID=@maSp";
                comm.Connection = conn;
                SqlParameter para = new SqlParameter("@maSp", SqlDbType.NVarChar);
                para.Value = maSp;
                comm.Parameters.Add(para);
                int ret = comm.ExecuteNonQuery();
                if (ret > 0)
                {
                    DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        hienthitoanbosanpham();
                        _customerID.Text = null;
                        _fullName.Text = null;
                        _gender.Text = null;
                        dateTimePicker1.Text = null;
                        _phoneNumber.Text = null;
                        _idNumber.Text = null;
                        _address.Text = null;
                        MessageBox.Show("đã xóa thành công");
                    }
                }
                else
                {
                    MessageBox.Show("đã xóa thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ban chua chon du lieu");
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                comm.CommandText = "select *from Customer where customerID=" + textBox2.Text;
                comm.Connection = conn;

                SqlDataReader rar = comm.ExecuteReader();
                if (rar.Read())
                {
                    _customerID.Text = rar.GetString(0);
                    _fullName.Text = rar.GetString(1);
                    _gender.Text = rar.GetString(2);
                    dateTimePicker1.Value = rar.GetDateTime(3);
                    _phoneNumber.Text = rar.GetString(4);
                    _address.Text = rar.GetString(5);
                    _idNumber.Text = rar.GetString(6);
                }
                else
                {
                    MessageBox.Show("khong co du lieu");
                }

                rar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("khong co du lieu");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

