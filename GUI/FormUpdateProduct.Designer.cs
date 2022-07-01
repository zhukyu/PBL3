namespace Gym
{
    partial class FormUpdateProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.formNameLable = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.formName = new System.Windows.Forms.Label();
            this.fixbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this._price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._productName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._productID = new System.Windows.Forms.TextBox();
            this.productPicture = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSL = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorprice = new System.Windows.Forms.ErrorProvider(this.components);
            this.formNameLable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorprice)).BeginInit();
            this.SuspendLayout();
            // 
            // formNameLable
            // 
            this.formNameLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.formNameLable.Controls.Add(this.button3);
            this.formNameLable.Controls.Add(this.formName);
            this.formNameLable.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formNameLable.ForeColor = System.Drawing.Color.White;
            this.formNameLable.Location = new System.Drawing.Point(-4, 0);
            this.formNameLable.Margin = new System.Windows.Forms.Padding(0);
            this.formNameLable.Name = "formNameLable";
            this.formNameLable.Size = new System.Drawing.Size(652, 66);
            this.formNameLable.TabIndex = 59;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(582, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 48);
            this.button3.TabIndex = 5;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.formName.Location = new System.Drawing.Point(124, 18);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(401, 33);
            this.formName.TabIndex = 1;
            this.formName.Text = "Thay đổi thông tin sản phẩm";
            // 
            // fixbutton
            // 
            this.fixbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.fixbutton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fixbutton.ForeColor = System.Drawing.Color.White;
            this.fixbutton.Location = new System.Drawing.Point(203, 591);
            this.fixbutton.Name = "fixbutton";
            this.fixbutton.Size = new System.Drawing.Size(216, 46);
            this.fixbutton.TabIndex = 70;
            this.fixbutton.Text = "Lưu thay đổi";
            this.fixbutton.UseVisualStyleBackColor = false;
            this.fixbutton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(156, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 68;
            this.label3.Text = "Đơn giá :";
            // 
            // _price
            // 
            this._price.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._price.Location = new System.Drawing.Point(309, 534);
            this._price.Name = "_price";
            this._price.Size = new System.Drawing.Size(153, 36);
            this._price.TabIndex = 67;
            this._price.Validating += new System.ComponentModel.CancelEventHandler(this._price_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(156, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 29);
            this.label4.TabIndex = 66;
            this.label4.Text = "Số lượng :";
            // 
            // _amount
            // 
            this._amount.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._amount.Location = new System.Drawing.Point(309, 477);
            this._amount.Name = "_amount";
            this._amount.Size = new System.Drawing.Size(153, 36);
            this._amount.TabIndex = 65;
            this._amount.Validating += new System.ComponentModel.CancelEventHandler(this._amount_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(156, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 29);
            this.label2.TabIndex = 64;
            this.label2.Text = "Tên SP :";
            // 
            // _productName
            // 
            this._productName.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._productName.Location = new System.Drawing.Point(309, 418);
            this._productName.Name = "_productName";
            this._productName.Size = new System.Drawing.Size(153, 36);
            this._productName.TabIndex = 63;
            this._productName.Validating += new System.ComponentModel.CancelEventHandler(this._productName_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(156, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 29);
            this.label6.TabIndex = 62;
            this.label6.Text = "Mã SP :";
            // 
            // _productID
            // 
            this._productID.Enabled = false;
            this._productID.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._productID.Location = new System.Drawing.Point(309, 363);
            this._productID.Name = "_productID";
            this._productID.Size = new System.Drawing.Size(153, 36);
            this._productID.TabIndex = 61;
            // 
            // productPicture
            // 
            this.productPicture.BackColor = System.Drawing.Color.White;
            this.productPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productPicture.Image = global::Gym.Properties.Resources.icons8_product_60px;
            this.productPicture.Location = new System.Drawing.Point(212, 93);
            this.productPicture.Name = "productPicture";
            this.productPicture.Size = new System.Drawing.Size(206, 201);
            this.productPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPicture.TabIndex = 60;
            this.productPicture.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(208, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 36);
            this.button1.TabIndex = 71;
            this.button1.Text = "Xóa ảnh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(322, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 36);
            this.button2.TabIndex = 71;
            this.button2.Text = "Thêm ảnh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorName
            // 
            this.errorName.ContainerControl = this;
            // 
            // errorSL
            // 
            this.errorSL.ContainerControl = this;
            // 
            // errorprice
            // 
            this.errorprice.ContainerControl = this;
            // 
            // FormUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 648);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.formNameLable);
            this.Controls.Add(this.fixbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._productName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._productID);
            this.Controls.Add(this.productPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUpdateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fixProduct";
            this.formNameLable.ResumeLayout(false);
            this.formNameLable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorprice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formNameLable;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.Button fixbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox _price;
        public System.Windows.Forms.TextBox _amount;
        public System.Windows.Forms.TextBox _productName;
        public System.Windows.Forms.TextBox _productID;
        public System.Windows.Forms.PictureBox productPicture;
        private System.Drawing.Bitmap bmp = null;
        private string filePath = null;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.ErrorProvider errorSL;
        private System.Windows.Forms.ErrorProvider errorprice;
        private System.Windows.Forms.Button button3;
    }
}