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
    public partial class Device : UserControl
    {
        public Device()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
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
            comm.CommandText = "select *from Device";
            comm.Connection = conn;


            SqlDataReader rar = comm.ExecuteReader();
            listView1.Items.Clear();
            while (rar.Read())
            {
                ListViewItem lvi = new ListViewItem(rar.GetString(0));
                lvi.SubItems.Add(rar.GetString(1));
                lvi.SubItems.Add(rar.GetInt32(2)+"");
                lvi.SubItems.Add(rar.GetString(3)); 
                lvi.SubItems.Add(rar.GetDateTime(4).ToString("dd-MM-yyyy"));
                lvi.SubItems.Add(rar.GetString(6));
                listView1.Items.Add(lvi);


            }
            rar.Close();
        }

        private void Device_Load(object sender, EventArgs e)
        {
            hienthitoanbosanpham();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
                    comm.CommandText = "select *from Device where deviceID=@maSp";
                    comm.Connection = conn;

                    SqlParameter para = new SqlParameter("@maSp", SqlDbType.NVarChar);
                    para.Value = maSp;
                    comm.Parameters.Add(para);

                    _employeeID.ReadOnly = true;
                    SqlDataReader rar = comm.ExecuteReader();
                    while (rar.Read())
                    {

                        _deviceID.Text = lvi.SubItems[0].Text;
                        _deviceName.Text = lvi.SubItems[1].Text;
                        _amount.Text = lvi.SubItems[2].Text;
                         _status.Text = lvi.SubItems[3].Text;
                        dateTimePicker1.Text = lvi.SubItems[4].Text;
                        pictureBox1.Image = new Bitmap(rar.GetString(5));
                        _employeeID.Text = lvi.SubItems[5].Text;
                    }

                    rar.Close();
                }
        }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn chưa chọn dữa liệu");
                }
}

        private void addButton_Click(object sender, EventArgs e)
        {
            addDevice frm = new addDevice();
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.FormClosing += new FormClosingEventHandler(this.addDevice_FormClosing);
            frm.ShowDialog();
        }

        private void addDevice_FormClosing(object? sender, FormClosingEventArgs e)
        {
            hienthitoanbosanpham();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                updateDevice anh = new updateDevice();
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
                comm.CommandText = "select *from Device where deviceID=@maSp";
                comm.Connection = conn;

                SqlParameter para = new SqlParameter("@maSp", SqlDbType.NVarChar);
                para.Value = maSp;
                comm.Parameters.Add(para);

                _employeeID.ReadOnly = true;
                SqlDataReader rar = comm.ExecuteReader();
                while (rar.Read())
                {

                    anh._deviceID.Text = lvi.SubItems[0].Text;
                    anh._deviceName.Text = lvi.SubItems[1].Text;
                    anh._amount.Text = lvi.SubItems[2].Text;
                    anh.dateTimePicker1.Text = lvi.SubItems[3].Text;
                    anh.comboBox1.Text = lvi.SubItems[4].Text;
                    anh.pictureBox1.Image = pictureBox1.Image;
                    anh.comboBox2.Text = lvi.SubItems[5].Text;


                }

                rar.Close();
                anh.StartPosition = FormStartPosition.CenterScreen;
                anh.FormClosing += new FormClosingEventHandler(this.editDevice_FormClosing);
                anh.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu!");
            }
        }

        private void editDevice_FormClosing(object? sender, FormClosingEventArgs e)
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
                comm.CommandText = "delete from Device where deviceID=@maSp";
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
                        _deviceID.Text = null;
                        _deviceName.Text = null;
                        _amount.Text = null;
                        dateTimePicker1.Text = null;
                        _status.Text = null;
                        pictureBox1.Image = null;

                        MessageBox.Show("Đã xóa thành công","Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("đã xóa thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu!");
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
                comm.CommandText = "select *from Device where deviceID=" + textBox2.Text;
                comm.Connection = conn;

                SqlDataReader rar = comm.ExecuteReader();
                if (rar.Read())
                {
                    _deviceID.Text = rar.GetString(0);
                    _deviceName.Text = rar.GetString(1);
                    _amount.Text = rar.GetInt32(2)+"";                   
                    _status.Text = rar.GetString(3);
                    dateTimePicker1.Value = rar.GetDateTime(4);
                    pictureBox1.Image = new Bitmap(rar.GetString(5));
                }

                else
                {
                    MessageBox.Show("Không có dữ liệu");
                }
                rar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có dữ liệu");
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Tìm kiếm")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Tìm kiếm";
                textBox2.ForeColor = Color.Silver;
            }
        }
    }
}
