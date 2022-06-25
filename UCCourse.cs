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
    public partial class UCCourse : UserControl
    {
        public UCCourse()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string maSp = null;
        private void addButton_Click(object sender, EventArgs e)
        {
            FormAddCourse frm = new FormAddCourse();

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
            FormupdateCourse anh = new FormupdateCourse();
            try
            {

                ListViewItem lvi = listView1.SelectedItems[0];
                 maSp = lvi.SubItems[0].Text;
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
                    anh.comboBox1.Text = lvi.SubItems[1].Text;
                    anh.comboBox2.Text = lvi.SubItems[2].Text;
                    anh._price.Text = lvi.SubItems[3].Text;

                }

                rar.Close();
                anh.StartPosition = FormStartPosition.CenterScreen;
                anh.FormClosing += new FormClosingEventHandler(this.editCourse_FormClosing);
                anh.ShowDialog();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void editCourse_FormClosing(object? sender, FormClosingEventArgs e)
        {
            hienthitoanbosanpham();
            
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
                comm.CommandText = "select *from Course where courseID=@maSp";
                comm.Connection = conn;

                SqlParameter para = new SqlParameter("@maSp", SqlDbType.NVarChar);
                para.Value = maSp;
                comm.Parameters.Add(para);

               
                SqlDataReader rar = comm.ExecuteReader();
                while (rar.Read())
                {

                    _courseID.Text = rar.GetString(0);
                    _courseName.Text = rar.GetString(1);
                    _duration.Text = rar.GetString(2);
                    _price.Text = rar.GetInt32(3)+"";

                }

                rar.Close();
            }
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
                comm.CommandText = "select from Course where courseID=@maSp";
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
                        _courseID.Text = null;
                        _courseName.Text = null;
                        _duration.Text = null;

                        _price.Text = null;

                        MessageBox.Show("Đã xóa thành công", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Đã xóa thất bại");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                comm.CommandText = "select *from Course where courseName LIKE N'%" + search.Text + "%' OR courseID = '" + search.Text + "' ";
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


                if (listView1.Items.Count <= 0)
                {
                    MessageBox.Show("không có dữ liệu!");
                }
                rar.Close();
            }



            catch (Exception ex)
            {
                MessageBox.Show("không có dữ liệu");
            }
        }





        private void search_Enter(object sender, EventArgs e)
        {
            if (search.Text == "ID,TÊN")
            {
                search.Text = "";
                search.ForeColor = Color.Black;
            }
        }

        private void search_Leave(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                search.Text = "ID,TÊN";
                search.ForeColor = Color.Gray;
                hienthitoanbosanpham();
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
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
            comm.CommandText = "select *from Course where courseName LIKE N'%" + search.Text + "%' OR courseID = '" + search.Text + "' ";
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

        private void button2_Click(object sender, EventArgs e)
        {
            hienthitoanbosanpham();
            search.Text = "ID,TÊN";
            search.ForeColor = Color.Gray;
            _courseID.Text = null;
            _courseName.Text = null;
            _duration.Text = null;

            _price.Text = null;
        }
    }

}
