using Gym.BLL;
using Gym.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class FormProductSale : Form
    {
        int selectedIndex = 0;
        List<Product> products = new List<Product>();
        List<ProductReceipt_Detail> items = new List<ProductReceipt_Detail>();
        public FormProductSale()
        {
            InitializeComponent();
        }
        // lấy vị trí sản phẩm trong list theo id
        private int GetCBIndex(String productID)
        {
            int cbIndex = -1;
            for(int i = 0; i < products.Count; i++)
            {
                if (products[i]._productID == productID)
                {
                    cbIndex = i;
                    break;
                }
            }
            return cbIndex;
        }
        // cập nhật combobox, textbox
        private void InputUpdate()
        {
            int cbIndex = GetCBIndex(productList.CurrentRow.Cells[0].Value.ToString());
            productCb.SelectedIndex = cbIndex;
            amountInput.Text = productList.CurrentRow.Cells[2].Value.ToString();
        }
        private void TotalSum()
        {
            int sum = 0;
            for (int i = 0; i < productList.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(productList.Rows[i].Cells[4].Value);
            }
            _total.Text = sum.ToString();
        }
        private void ProductList_Load()
        {
            productList.Rows.Clear();
            foreach(ProductReceipt_Detail item in items)
            {
                int cbIndex = GetCBIndex(item._productID);
                productList.Rows.Add(
                    item._productID,
                    products[cbIndex]._productName,
                    item._amount,
                    products[cbIndex]._price,
                    item._unitTotal
                );
            }
            if (productList.Rows.Count == 0)
                return;
            productList.Rows[selectedIndex].Cells[0].Selected = true;
            InputUpdate();
            TotalSum();
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int index = productCb.SelectedIndex;
                if(index == -1) // chưa chọn sản phẩm
                {
                    throw new Exception("Bạn chưa chọn sản phẩm");
                }
                int amount = Convert.ToInt32(amountInput.Text);
                // xử lý số lượng sản phẩm
                if (amount < 1)
                {
                    throw new FormatException(); ;
                }
                if (products[index]._amount < amount)
                {
                    throw new Exception("Không có đủ sản phẩm");
                }
                else
                {
                    products[index]._amount -= amount;
                }
                ProductReceipt_Detail temp = new ProductReceipt_Detail(
                    _saleID.Text,
                    products[index]._productID,
                    amount,
                    products[index]._price,
                    products[index]._price * amount
                );
                bool hasItem = false; // chưa được thêm
                for(int i = 0; i < items.Count; i++) // kiểm tra trùng sản phẩm, nếu đúng thì cộng dồn vào
                {
                    if (items[i]._productID == temp._productID)
                    {
                        DialogResult dlr = MessageBox.Show("Sản phẩm đã tồn tại, thêm số lượng ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dlr == DialogResult.Yes)
                        {
                            hasItem = true;
                            items[i]._amount += temp._amount;
                            items[i]._unitTotal += temp._unitTotal;
                            selectedIndex = i;
                            break;
                        }
                        else
                            return;
                    }
                }
                if (!hasItem)
                {
                    items.Add(temp);
                    selectedIndex = productList.Rows.Count;
                   
                }
                ProductList_Load();
            }
            catch (FormatException)
            {
                MessageBox.Show("Định dạng số lượng phải là số nguyên dương", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(productList.Rows.Count == 0)
                {
                    throw new Exception("Bạn chưa chọn sản phẩm");
                }
                selectedIndex = productList.CurrentRow.Index;
                int index = productCb.SelectedIndex;
                if (index == -1) // chưa chọn sản phẩm
                {
                    throw new Exception("Bạn chưa chọn sản phẩm");
                }
                int amount = Convert.ToInt32(amountInput.Text);
                if (amount < 1)
                {
                    throw new FormatException(); ;
                }
                ProductReceipt_Detail temp = new ProductReceipt_Detail(
                    _saleID.Text,
                    products[index]._productID,
                    amount,
                    products[index]._price,
                    products[index]._price * amount
                );
                ProductReceipt_Detail oldItem = items[selectedIndex];
                items[selectedIndex] = temp;
                // gộp 2 item trùng lặp
                List<ProductReceipt_Detail> duplicateItems = items.FindAll(x => x._productID == temp._productID); 
                if (duplicateItems.Count == 2)
                {
                    DialogResult dlr = MessageBox.Show("Sản phẩm đã tồn tại, thêm số lượng ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        duplicateItems[0]._amount += duplicateItems[1]._amount;
                        duplicateItems[0]._unitTotal += duplicateItems[1]._unitTotal;
                        items.Remove(duplicateItems[1]);
                        selectedIndex = items.IndexOf(duplicateItems[0]);
                    }
                    else
                    {
                        items[selectedIndex] = oldItem;
                        return;
                    }
                }
                ProductList_Load();

            }
            catch (FormatException)
            {
                MessageBox.Show("Định dạng số lượng phải là số nguyên dương", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                selectedIndex = productList.CurrentRow.Index; // số chỉ của datagridview
                DialogResult dlr = MessageBox.Show("Bạn có muốn xóa mục đã chọn ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    items.RemoveAt(selectedIndex);
                    if (selectedIndex != 0)
                    {
                        selectedIndex--;
                    }
                    ProductList_Load();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool ProductUpdate()
        {
            bool result = false;
            foreach(Product product in products)
            {
                result = ProductBLL.UpdateProduct(product);
            }
            return result;
        }
        private void acceptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_total.Text == "0")
                    throw new Exception("Bạn chưa chọn sản phẩm");
                DialogResult dlr = MessageBox.Show("Xác nhận thanh toán ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    ProductReceipt productReceipt = new ProductReceipt(
                        _saleID.Text,
                        FormHome.userID,
                        DateTime.Today,
                        Convert.ToInt32(_total.Text)
                    );
                    bool result = ProductReceiptBLL.InsertProductReceipt(productReceipt);
                    foreach(ProductReceipt_Detail item in items)
                    {
                        result = ProductReceipt_DetailBLL.InsertProductReceiptItem(item);
                    }
                    ProductUpdate(); // cập nhật số lượng sản phẩm
                    if (result)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FormProductSale_Load(object sender, EventArgs e)
        {
            _publishDate.Value = DateTime.Today;
            try
            {
                _saleID.Text = ProductReceiptBLL.GenerateID();
                _cashier.Text = FormHome.userName;
                products = ProductBLL.GetAllProducts();
                foreach(Product product in products)
                {
                    productCb.Items.Add(product._productName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void productList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productList.Rows.Count == 0)
                return;
            InputUpdate();
        }
        private void ChangeUpdate()
        {
            try
            {
                if (_received.Text == "")
                {
                    _change.Text = "0";
                    return;
                }
                int received = Convert.ToInt32(_received.Text);
                if (received < 0)
                    throw new FormatException();
                int change = received - Convert.ToInt32(_total.Text);
                _change.Text = change.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Định dạng tiền nhận phải là số nguyên dương", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void _received_TextChanged(object sender, EventArgs e)
        {
            ChangeUpdate();
        }

        private void _total_TextChanged(object sender, EventArgs e)
        {
            ChangeUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
