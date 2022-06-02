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
    public partial class Product : UserControl
    {
        public Product()
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
            comm.CommandText = "select *from product";
            comm.Connection = conn;


            SqlDataReader rar = comm.ExecuteReader();
            listView1.Items.Clear();
            while (rar.Read())
            {
                ListViewItem lvi = new ListViewItem(rar.GetString(0));
                lvi.SubItems.Add(rar.GetString(1));
                lvi.SubItems.Add(rar.GetInt32(2) + "");
                lvi.SubItems.Add(rar.GetInt32(3) + "");


                listView1.Items.Add(lvi);

            }
            rar.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addProduct frm = new addProduct();
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.FormClosing += new FormClosingEventHandler(this.addProduct_FormClosing);
            frm.ShowDialog();
        }

        private void addProduct_FormClosing(object? sender, FormClosingEventArgs e)
        {
            hienthitoanbosanpham();
        }

        private void editButton_Click(object sender, EventArgs e)
        {

            try
            {
                updateProduct anh = new updateProduct();

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
                comm.CommandText = "select *from product where productID=@maSp";
                comm.Connection = conn;

                SqlParameter para = new SqlParameter("@maSp", SqlDbType.NVarChar);
                para.Value = maSp;
                comm.Parameters.Add(para);

                _productID.ReadOnly = true;
                SqlDataReader rar = comm.ExecuteReader();
                while (rar.Read())
                {

                    anh._productID.Text = lvi.SubItems[0].Text;
                    anh._productName.Text = lvi.SubItems[1].Text;
                    anh._amount.Text = lvi.SubItems[2].Text;
                    anh._price.Text = lvi.SubItems[3].Text;
                    anh.pictureBox1.Image = pictureBox1.Image;
                }

                rar.Close();
                anh.StartPosition = FormStartPosition.CenterScreen;
                anh.FormClosing += new FormClosingEventHandler(this.editProduct_FormClosing);
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

        private void editProduct_FormClosing(object? sender, FormClosingEventArgs e)
        {
            hienthitoanbosanpham();
            _productID.Text = null;
            _productName.Text = null;
            _amount.Text = null;
            _price.Text = null;
            pictureBox1.Image = null;
        }

        private void Product_Load(object sender, EventArgs e)
        {
            hienthitoanbosanpham();
        }
        OpenFileDialog _openFileDialog = new OpenFileDialog();
        private byte[] ConverImgToByte(String x)
        {
            FileStream fs;
            fs = new FileStream(x, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
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
                    comm.CommandText = "select *from product where productID=@maSp";
                    comm.Connection = conn;

                    SqlParameter para = new SqlParameter("@maSp", SqlDbType.NVarChar);
                    para.Value = maSp;
                    comm.Parameters.Add(para);

                    _productID.ReadOnly = true;
                    SqlDataReader rar = comm.ExecuteReader();
                    while (rar.Read())
                    {

                        _productID.Text = lvi.SubItems[0].Text;
                        _productName.Text = lvi.SubItems[1].Text;
                        _amount.Text = lvi.SubItems[2].Text;
                        _price.Text = lvi.SubItems[3].Text;
                        //pictureBox1.Image = new Bitmap(rar.GetString(4));
                        ConverImgToByte(rar.GetString(4));
                        using (Stream stream = new MemoryStream(ConverImgToByte(rar.GetString(4))))
                        {
                            pictureBox1.Image = System.Drawing.Image.FromStream(stream);
                            stream.Dispose();
                        }


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
                comm.CommandText = "delete from product where productID=@maSp";
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
                        _productID.Text = null;
                        _productName.Text = null;
                        _amount.Text = null;
                        _price.Text = null;
                        pictureBox1.Image = null;

                        MessageBox.Show("Đã xóa thành công","Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("đã xóa thất bại");
                }
            }
            catch (ArgumentOutOfRangeException)
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
                comm.CommandText = "select *from product where productID='"+ search.Text+ "' or productName like '%" + search.Text + "%'";
                comm.Connection = conn;

                SqlDataReader rar = comm.ExecuteReader();
                listView1.Items.Clear();
                while (rar.Read())
                {
                    ListViewItem lvi = new ListViewItem(rar.GetString(0));
                    lvi.SubItems.Add(rar.GetString(1));
                    lvi.SubItems.Add(rar.GetInt32(2) + "");
                    lvi.SubItems.Add(rar.GetInt32(3) + "");


                    listView1.Items.Add(lvi);

                }
               if(listView1.Items.Count<=0)
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

        private void search_Enter(object sender, EventArgs e)
        {
            if (search.Text == "Tìm kiếm")
            {
                search.Text = "";
                search.ForeColor = Color.Black;
            }
        }

        private void search_Leave(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                search.Text = "Tìm kiếm";
                search.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            hienthitoanbosanpham();
            search.Text = "ID,TÊN";
            search.ForeColor = Color.Gray;
            _productID.Text = null;
            _productName.Text = null;
            _amount.Text = null;
            _price.Text = null;
            pictureBox1.Image = null;
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
            comm.CommandText = "select *from product where productID='" + search.Text + "' or productName like '%" + search.Text + "%'";
            comm.Connection = conn;

            SqlDataReader rar = comm.ExecuteReader();
            listView1.Items.Clear();
            while (rar.Read())
            {
                ListViewItem lvi = new ListViewItem(rar.GetString(0));
                lvi.SubItems.Add(rar.GetString(1));
                lvi.SubItems.Add(rar.GetInt32(2) + "");
                lvi.SubItems.Add(rar.GetInt32(3) + "");


                listView1.Items.Add(lvi);

            }
            rar.Close();
        }

        private void saleBtn_Click(object sender, EventArgs e)
        {
            ProductSale productSale = new ProductSale();
            productSale.ShowDialog();
        }
    }
}
    


