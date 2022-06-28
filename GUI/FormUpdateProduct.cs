﻿using System;
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
    public partial class FormUpdateProduct : Form
    {
        string fileName = null;
        public FormUpdateProduct()
        {
            InitializeComponent();
        }
        
        public FormUpdateProduct(Product product)
        {
            InitializeComponent();
            
            _productID.Text = product._productID;
            _productName.Text = product._productName;
            _amount.Text = product._amount+"";
            _price.Text = product._price+"";
            productPicture.ImageLocation = product._image;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn thay đổi dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        bool result = ProductBLL.UpdateProduct(product);
                        if (result)
                        {
                            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("lỗi");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("lỗi:" + ex.ToString());
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productPicture.Image = Properties.Resources.person_128px1;
            fileName = null;
        }

        private void button2_Click(object sender, EventArgs e)
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







        //OpenFileDialog _openFileDialog = new OpenFileDialog();
        //        private void addPictureBox1_Click(object sender, EventArgs e)
        //        {



        //                _openFileDialog.Filter = "All files (*.*)|*.*|exe files (*.exe)|*.exe";

        //                _openFileDialog.FilterIndex = 1;

        //                _openFileDialog.RestoreDirectory = true;
        //            if (_openFileDialog.ShowDialog() == DialogResult.OK)

        //            {
        //                string fileName = _openFileDialog.FileName;
        //                this.bmp = new Bitmap(fileName);

        //                this.pictureBox1.Image = this.bmp;
        //            }

        //            string id = _productID.Text;
        //            string file = id + ".jpg";

        //            this.filePath = "Img\\" + file;
        //            this.bmp.Save(filePath);
        //        }



        //            private byte[] ConverImgToByte()
        //            {
        //                FileStream fs;
        //                fs = new FileStream(_openFileDialog.FileName, FileMode.Open, FileAccess.Read);
        //                byte[] picbyte = new byte[fs.Length];
        //                fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
        //                fs.Close();
        //                return picbyte;
        //            }
    }
}

