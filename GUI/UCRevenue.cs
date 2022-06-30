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
using Gym.BLL;
using Gym.DTO;

namespace Gym
{
    public partial class UCRevenue : UserControl
    {
        int productPrft = 0;
        int coursePrft = 0;
        List<CourseReceipt> courseReceipts = new List<CourseReceipt>();
        List<ProductReceipt> productReceipts = new List<ProductReceipt>();
        private void DGV_Load()
        {
            foreach(CourseReceipt receipt in courseReceipts)
            {
                string customerName = CustomerBLL.GetCustomerName(receipt._customerID);
                string cashierName = EmployeeBLL.GetEmployeeName(receipt._employeeID);
                courseList.Rows.Add(
                        receipt._receiptID,
                        customerName,
                        cashierName,
                        receipt._registerDate.ToString("dd/MM/yyyy"),
                        receipt._price.ToString()
                    );
                coursePrft += receipt._price;
            }
            foreach(ProductReceipt receipt in productReceipts)
            {
                string cashierName = EmployeeBLL.GetEmployeeName(receipt._employeeID);
                productList.Rows.Add(
                    receipt._receiptID,
                    cashierName,
                    receipt._publishDate.ToString("dd/MM/yyyy"),
                    receipt._total
                );
                productPrft += receipt._total;
            }
        }
        public UCRevenue()
        {
            InitializeComponent();
        }

        private void Revenue_Load(object sender, EventArgs e)
        {
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
            productList.Rows.Clear();
            courseList.Rows.Clear();
            DateTime _beginDate = beginDate.Value;
            DateTime _endDate = endDate.Value;
            try
            {
                courseReceipts = CourseReceiptBLL.GetCourseReceiptsByDate(_beginDate, _endDate);
                productReceipts = ProductReceiptBLL.GetProductReceiptsByDate(_beginDate, _endDate);
                DGV_Load();
                int profit = coursePrft + productPrft;
                _profit.Text = profit.ToString();
                _coursePrft.Text = coursePrft.ToString();
                _productPrft.Text = productPrft.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void productList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productList.Rows.Count == 0)
                return;
            string receiptID = productList.CurrentRow.Cells[0].Value.ToString();
            ProductReceipt receipt = productReceipts.Find(x => x._receiptID == receiptID); ;
            FormProductReceipt rcpt = new FormProductReceipt(receipt);

            rcpt.ShowDialog();
        }

        private void courseList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (courseList.Rows.Count == 0)
                return;
            string receiptID = courseList.CurrentRow.Cells[0].Value.ToString();
            CourseReceipt receipt = courseReceipts.Find(x => x._receiptID == receiptID);
            FormCourseReceipt rcpt = new FormCourseReceipt(receipt);

            rcpt.ShowDialog();
        }
    }
}
