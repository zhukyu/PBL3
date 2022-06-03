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
    public partial class Revenue : UserControl
    {
        public Revenue()
        {
            InitializeComponent();
        }

        private void employeeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Revenue_Load(object sender, EventArgs e)
        {
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int productPrft = 0;
            int coursePrft = 0;
            productList.Rows.Clear();
            courseList.Rows.Clear();
            SqlConnection conn = new SqlConnection(Program.cnstr);
            string _beginDate = beginDate.Value.ToString("yyyyMMdd");
            string _endDate = endDate.Value.ToString("yyyyMMdd");
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select a.receiptID, b.fullName, a.publishDate, a.total " +
                    "from ProductReceipt a, Employee b where a.employeeID = b.employeeID " +
                    $"and a.publishDate >= '{_beginDate}' and a.publishDate <= '{_endDate}'", conn);

                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    productPrft += rd.GetInt32(3);
                    productList.Rows.Add(
                        rd.GetString(0),
                        rd.GetString(1),
                        rd.GetDateTime(2).ToString("dd-MM-yyyy"),
                        rd.GetInt32(3).ToString()
                    );
                }
                rd.Close();

                cmd = new SqlCommand("select a.receiptID, c.fullName, b.fullName, a.registerDate, a.price " +
                    "from CourseReceipt a, Employee b, Customer c where a.employeeID = b.employeeID and a.customerID = c.customerID " +
                    $"and a.registerDate >= '{_beginDate}' and a.registerDate <= '{_endDate}'", conn);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    coursePrft += rd.GetInt32(4);
                    courseList.Rows.Add(
                        rd.GetString(0),
                        rd.GetString(1),
                        rd.GetString(2),
                        rd.GetDateTime(3).ToString("dd-MM-yyyy"),
                        rd.GetInt32(4).ToString()
                    );
                }
                rd.Close();
                int profit = coursePrft + productPrft;
                _profit.Text = profit.ToString();
                _productPrft.Text = productPrft.ToString();
                _coursePrft.Text = coursePrft.ToString();
                productList.ClearSelection();
                courseList.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void productList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string receiptID = productList.CurrentRow.Cells[0].Value.ToString();
            ProductReceipt rcpt = new ProductReceipt(receiptID);

            rcpt.ShowDialog();
        }

        private void courseList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string receiptID = courseList.CurrentRow.Cells[0].Value.ToString();
            CourseReceipt rcpt = new CourseReceipt(receiptID);
            
            rcpt.ShowDialog();
        }

        private void courseList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

    }
}
