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
    public partial class Course : UserControl
    {
        public Course()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;

        private void addButton_Click(object sender, EventArgs e)
        {
            addCourse frm = new addCourse();

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.FormClosing += new FormClosingEventHandler(this.addCourse_FormClosing);
            frm.ShowDialog();
        }

        private void addCourse_FormClosing(object? sender, FormClosingEventArgs e)
        {
            hienthitoanbosanpham();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            updateCourse anh = new updateCourse();
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
                comm.CommandText = "select *from Course where courseID=@maSp";
                comm.Connection = conn;

                SqlParameter para = new SqlParameter("@maSp", SqlDbType.NVarChar);
                para.Value = maSp;
                comm.Parameters.Add(para);

                _courseID.ReadOnly = true;
                SqlDataReader rar = comm.ExecuteReader();
                while (rar.Read())
                {

                    anh._courseID.Text = lvi.SubItems[0].Text;
                    anh.comboBox2.Text = lvi.SubItems[1].Text;
                    anh.comboBox1.Text = lvi.SubItems[2].Text;
                    anh._price.Text = lvi.SubItems[3].Text;

                }

                rar.Close();
                anh.StartPosition = FormStartPosition.CenterScreen;
                anh.FormClosing += new FormClosingEventHandler(this.editCourse_FormClosing);
                anh.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu");
            }
        }

        private void editCourse_FormClosing(object? sender, FormClosingEventArgs e)
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
                comm.CommandText = "delete from Course where courseID=@maSp";
                comm.Connection = conn;
                SqlParameter para = new SqlParameter("@maSp", SqlDbType.NVarChar);
                para.Value = maSp;
                comm.Parameters.Add(para);
                int ret = comm.ExecuteNonQuery();
                if (ret > 0)
                {

                    hienthitoanbosanpham();
                    _courseID.Text = null;
                    _courseName.Text = null;
                    _duration.Text = null;

                    _price.Text = null;

                    MessageBox.Show("đã xóa thành công");
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
            comm.CommandText = "select *from Course";
            comm.Connection = conn;


            SqlDataReader rar = comm.ExecuteReader();
            listView1.Items.Clear();
            while (rar.Read())
            {
                ListViewItem lvi = new ListViewItem(rar.GetString(0));
                lvi.SubItems.Add(rar.GetString(1));
                lvi.SubItems.Add(rar.GetString(2) + "");
                lvi.SubItems.Add(rar.GetInt32(3) + "");

                listView1.Items.Add(lvi);

            }
            rar.Close();
        }

        private void Course_Load(object sender, EventArgs e)
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
                    comm.CommandText = "select *from Course where courseID=@maSp";
                    comm.Connection = conn;

                    SqlParameter para = new SqlParameter("@maSp", SqlDbType.NVarChar);
                    para.Value = maSp;
                    comm.Parameters.Add(para);

                    _courseID.ReadOnly = true;
                    SqlDataReader rar = comm.ExecuteReader();
                    while (rar.Read())
                    {

                        _courseID.Text = lvi.SubItems[0].Text;
                        _courseName.Text = lvi.SubItems[1].Text;
                        _duration.Text = lvi.SubItems[2].Text;
                        _price.Text = lvi.SubItems[3].Text;


                    }

                    rar.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("bạn chưa chọn dữa liệu");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
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
                comm.CommandText = "select *from Course where courseID=" + search.Text;
                comm.Connection = conn;

                SqlDataReader rar = comm.ExecuteReader();
                if (rar.Read())
                {
                    _courseID.Text = rar.GetString(0);
                    _courseName.Text = rar.GetString(1);
                    _duration.Text = rar.GetString(2);

                    _price.Text = rar.GetInt32(3) + "";
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
    }

}
