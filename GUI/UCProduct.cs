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
using Gym.DTO;
using Gym.BLL;
namespace Gym
{
    public partial class UCProduct : UserControl
    {
        List<Product> products;
        int selectedIndex = 0;
        public UCProduct()
        {
            InitializeComponent();
        }

        private void DGV_Load()
        {
            ProductDGV.Rows.Clear();
            if (products.Count == 0)
                return;
            foreach (Product product in products)
            {
                ProductDGV.Rows.Add(
                    product._productID,
                    product._productName,
                    product._amount,
                    product._price
                );
            }
            ProductDGV.Rows[selectedIndex].Cells[0].Selected = true;
            ProductInfo(products[selectedIndex]);
        }
        private void ProductInfo(Product product)
        {
            _productID.Text = product._productID;
            _productName.Text = product._productName;
            _amount.Text = product._amount + "";
            _price.Text = product._price + "";



            Image img = ImageHandle.GetImage(product._image);

            if (img != null)
            {
                productPicture.Image = img;
            }
            else
                productPicture.Image = Properties.Resources.person_128px1;

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            FormAddProduct frm = new FormAddProduct();
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.FormClosing += new FormClosingEventHandler(this.addProduct_FormClosing);
            frm.ShowDialog();
            UCProduct_Load(sender, e);
        }

        private void addProduct_FormClosing(object? sender, FormClosingEventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {


            try
            {
                if (ProductDGV.Rows.Count == 0)
                    throw new Exception("Bạn chưa chọn dữ liệu");
                string productID = ProductDGV.CurrentRow.Cells[0].Value.ToString();
                Product product = products.Find(x => x._productID == productID);
                FormUpdateProduct updateProduct = new FormUpdateProduct(product);
                updateProduct.ShowDialog();
                selectedIndex = ProductDGV.CurrentRow.Index;
                UCProduct_Load(sender, e);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editProduct_FormClosing(object? sender, FormClosingEventArgs e)
        {
        }


        


        private void deleteButton_Click(object sender, EventArgs e)
        {

            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    if (ProductDGV.Rows.Count == 0)
                        throw new Exception("Bạn chưa chọn dữ liệu");
                    string productID = ProductDGV.CurrentRow.Cells[0].Value.ToString();
                    bool result = ProductBLL.DeleteProduct(productID);
                    if (result)
                    {
                        MessageBox.Show("Đã xóa thành công");
                        selectedIndex = 0;
                        UCProduct_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Đã xóa thất bại");

                    }

                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Bạn chưa chọn dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                products = ProductBLL.SearchProduct(searchsp.Text);
                DGV_Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ProductDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductDGV.Rows.Count == 0)
                return;
            string productID = ProductDGV.CurrentRow.Cells[0].Value.ToString();
            Product product = products.Find(x => x._productID == productID);
            ProductInfo(product);
        }

       

        private void UCProduct_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            products = ProductBLL.GetAllProducts();
            DGV_Load();
        }
    }
}
    


