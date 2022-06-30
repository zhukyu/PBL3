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
using Gym.DTO;
using Gym.BLL;

namespace Gym
{
    public partial class FormProductReceipt : Form
    {
        ProductReceipt receipt;
        List<ProductReceipt_Detail> items;
        public FormProductReceipt()
        {
            InitializeComponent();
        }
        public FormProductReceipt(ProductReceipt receipt)
        {
            InitializeComponent();
            this.receipt = receipt;
        }
        private void DGV_Load()
        {
            foreach(ProductReceipt_Detail item in items)
            {
                string productName = ProductBLL.GetProductName(item._productID);
                productList.Rows.Add(
                    productName,
                    item._amount,
                    item._unitPrice,
                    item._unitTotal
                );
            }
        }
        private void ProductReceipt_Load(object sender, EventArgs e)
        {
            try
            {
                string cashier = EmployeeBLL.GetEmployeeName(receipt._employeeID);
                _receiptID.Text = receipt._receiptID;
                _publishDate.Text = receipt._publishDate.ToString("dd/MM/yyyy");
                _cashier.Text = cashier;
                _total.Text = receipt._total.ToString();

                items = ProductReceipt_DetailBLL.GetAllProductReceipts(receipt._receiptID);
                DGV_Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
