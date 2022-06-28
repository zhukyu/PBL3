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
using Gym.BLL;
using Gym.DTO;
namespace Gym
{
    public partial class FormAddProduct : Form
    {
        string fileName = "";
        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn Thêm dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    try
                    {
                        Product product = new Product(
                                _productID.Text,
                                _productName.Text,
                                int.Parse(_amount.Text),
                               int.Parse(_price.Text),

                                fileName
                            );
                        bool result = ProductBLL.AddProduct(product);
                        if (result)
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm");
                        }
                    }
                    catch (Exception ex)
                    {
                        errorID.SetError(_productID, "Mã Sản phẩm đã tồn tại");//MessageBox.Show("Lỗi: " + ex.ToString());
                    }
                }
            }
        }
        
        private void addPictureBox1_Click(object sender, EventArgs e)
        {



            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
                openFile.FilterIndex = 1;
                openFile.RestoreDirectory = true;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFile.FileName;
                    productPicture.Image = ImageHandle.GetImage(fileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void _productID_Validating(object sender, CancelEventArgs e)
        {
            if (_productID.Text == "")
            {
                e.Cancel = true;
                _productID.Focus();

                errorID.SetError(_productID, "vui lòng nhập Mã Sảm phẩm!");

            }
            else
            {
                e.Cancel = false;
                errorID.SetError(_productID, null);
            }
        }

        private void _productName_Validating(object sender, CancelEventArgs e)
        {
            if (_productName.Text == "")
            {
                e.Cancel = true;
                _productName.Focus();

                errorName.SetError(_productName, "vui lòng nhập Tên Sản phẩm!");

            }
            else
            {
                e.Cancel = false;
                errorName.SetError(_productName, null);
            }
        }
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private void _amount_Validating(object sender, CancelEventArgs e)
        {
            if (_amount.Text == "")
            {
                e.Cancel = true;
                _amount.Focus();

                errorSL.SetError(_amount, "vui lòng nhập Số lượng sản phẩm!");

            }
            else if (!IsNumber(_amount.Text))
            {
                e.Cancel = true;
                _amount.Focus();

                errorSL.SetError(_amount, "Vui lòng nhập kí tự số!");

            }
            else
            {
                e.Cancel = false;
                errorSL.SetError(_amount, null);
            }
        }

        private void _price_Validating(object sender, CancelEventArgs e)
        {
            if (_price.Text == "")
            {
                e.Cancel = true;
                _price.Focus();

                errorprice.SetError(_price, "vui lòng nhập Đơn giá!");

            }
            else if (!IsNumber(_price.Text))
            {
                e.Cancel = true;
                _price.Focus();

                errorprice.SetError(_price, "Vui lòng nhập kí tự số!");

            }
            else
            {
                e.Cancel = false;
                errorprice.SetError(_price, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}

