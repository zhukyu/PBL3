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
    public partial class updateProduct : Form
    {
        public updateProduct()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string str = @"Data Source=DESKTOP-S7H27N8\SQLEXPRESS;Initial Catalog=GymDatabase;Integrated Security=True";
        private void addButton_Click(object sender, EventArgs e)
        {

            try
            {


                string maSp = _productID.Text;
                {
                    if (conn == null)
                    {
                        conn = new SqlConnection(str);
                    }
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    SqlCommand comm = new SqlCommand();
                    comm.CommandType = CommandType.Text;
                    string st = "update product set  productName=N'" + _productName.Text + "',amount=N'" + _amount.Text + "',price='" + _price.Text + "' " + "where productID=@maSp";
                    comm.CommandText = st;
                    comm.CommandText = st;
                    comm.Connection = conn;

                    SqlParameter para = new SqlParameter("@maSp", SqlDbType.NVarChar);
                    para.Value = maSp;
                    comm.Parameters.Add(para);
                    int ret = comm.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        MessageBox.Show("Sửa thành công");

                    }
                    else
                    {
                        MessageBox.Show("lỗi");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi:" + ex.Message);
            }
        }
    }
}
