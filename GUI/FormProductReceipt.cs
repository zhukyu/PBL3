using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class FormProductReceipt : Form
    {
        public FormProductReceipt()
        {
            InitializeComponent();
        }
        public FormProductReceipt(string str)
        {
            InitializeComponent();
            this._receiptID.Text = str;
        }

        private void ProductReceipt_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.cnstr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select a.publishDate, b.fullName, a.total " +
                    "from ProductReceipt a, Employee b " +
                    $"where a.employeeID = b.employeeID and a.receiptID = '{_receiptID.Text}'", conn);
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    _publishDate.Text = rd.GetDateTime(0).ToString("dd-MM-yyyy");
                    _cashier.Text = rd.GetString(1);

                    string receiptID = _receiptID.Text;
                    string total = rd.GetInt32(2).ToString();

                    rd.Close();
                    cmd = new SqlCommand("select b.productName, a.amount, a.unitPrice, a.unitTotal " +
                        "from ProductReceipt_Detail a, Product b " +
                        $"where a.productID = b.productID and a.receiptID = '{receiptID}'", conn);
                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        string productName = rd.GetString(0);
                        string amount = rd.GetInt32(1).ToString();
                        string unitPrice = rd.GetInt32(2).ToString();
                        string unitTotal = rd.GetInt32(3).ToString();
                        productList.Rows.Add(
                            productName,
                            amount,
                            unitPrice,
                            unitTotal
                            );
                    }
                    rd.Close();
                    productList.ClearSelection();
                    _total.Text = total;

                }
                else
                {
                    MessageBox.Show("Không có dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
