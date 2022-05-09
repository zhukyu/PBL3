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
            catch (Exception ex)
            {
                MessageBox.Show("ban chua chon du lieu");
            }
        }

        private void editProduct_FormClosing(object? sender, FormClosingEventArgs e)
        {
            hienthitoanbosanpham();
        }

        private void Product_Load(object sender, EventArgs e)
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
                        pictureBox1.Image = new Bitmap(Program.ByteToImg(rar.GetString(4)));

                    }

                    rar.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("bạn chưa chọn dữa liệu");
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

                    hienthitoanbosanpham();
                    _productID.Text = null;
                    _productName.Text = null;
                    _amount.Text = null;
                    _price.Text = null;
                    pictureBox1.Image = null;

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
                comm.CommandText = "select *from product where productID=" + search.Text;
                comm.Connection = conn;

                SqlDataReader rar = comm.ExecuteReader();
                if (rar.Read())
                {
                    _productID.Text = rar.GetString(0);
                    _productName.Text = rar.GetString(1);
                    _amount.Text = rar.GetInt32(2) + "";
                    _price.Text = rar.GetInt32(3) + "";
                    pictureBox1.Image = new Bitmap(Program.ByteToImg(rar.GetString(4)));

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

        private void saleButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
    


