namespace Gym
{
    partial class FormAddProduct
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
            this.formName = new System.Windows.Forms.Label();
            this.productPicture = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this._price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._productName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._productID = new System.Windows.Forms.TextBox();
            this.addPictureBox1 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.errorID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSL = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorprice = new System.Windows.Forms.ErrorProvider(this.components);
            this.formNameLable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorprice)).BeginInit();
            this.SuspendLayout();
            // 
            // formNameLable
            // 
            this.formNameLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.formNameLable.Controls.Add(this.formName);
            this.formNameLable.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formNameLable.ForeColor = System.Drawing.Color.White;
            this.formNameLable.Location = new System.Drawing.Point(-1, 1);
            this.formNameLable.Margin = new System.Windows.Forms.Padding(0);
            this.formNameLable.Name = "formNameLable";
            this.formNameLable.Size = new System.Drawing.Size(655, 69);
            this.formNameLable.TabIndex = 36;
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.formName.Location = new System.Drawing.Point(216, 20);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(238, 33);
            this.formName.TabIndex = 1;
            this.formName.Text = "Thêm sản phẩm ";
            // 
            // productPicture
            // 
            this.productPicture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productPicture.Location = new System.Drawing.Point(213, 83);
            this.productPicture.Name = "productPicture";
            this.productPicture.Size = new System.Drawing.Size(221, 224);
            this.productPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productPicture.TabIndex = 47;
            this.productPicture.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(148, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 55;
            this.label3.Text = "Đơn giá :";
            // 
            // _price
            // 
            this._price.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._price.Location = new System.Drawing.Point(298, 533);
            this._price.Name = "_price";
            this._price.Size = new System.Drawing.Size(155, 36);
            this._price.TabIndex = 54;
            this._price.Validating += new System.ComponentModel.CancelEventHandler(this._price_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(148, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 29);
            this.label4.TabIndex = 53;
            this.label4.Text = "Số lượng :";
            // 
            // _amount
            // 
            this._amount.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._amount.Location = new System.Drawing.Point(298, 474);
            this._amount.Name = "_amount";
            this._amount.Size = new System.Drawing.Size(155, 36);
            this._amount.TabIndex = 52;
            this._amount.Validating += new System.ComponentModel.CancelEventHandler(this._amount_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(148, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 29);
            this.label2.TabIndex = 51;
            this.label2.Text = "Tên SP :";
            // 
            // _productName
            // 
            this._productName.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._productName.Location = new System.Drawing.Point(298, 417);
            this._productName.Name = "_productName";
            this._productName.Size = new System.Drawing.Size(155, 36);
            this._productName.TabIndex = 50;
            this._productName.Validating += new System.ComponentModel.CancelEventHandler(this._productName_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(148, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 29);
            this.label6.TabIndex = 49;
            this.label6.Text = "Mã SP :";
            // 
            // _productID
            // 
            this._productID.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._productID.Location = new System.Drawing.Point(298, 359);
            this._productID.Name = "_productID";
            this._productID.Size = new System.Drawing.Size(155, 36);
            this._productID.TabIndex = 48;
            this._productID.Validating += new System.ComponentModel.CancelEventHandler(this._productID_Validating);
            // 
            // addPictureBox1
            // 
            this.addPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.addPictureBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addPictureBox1.ForeColor = System.Drawing.Color.White;
            this.addPictureBox1.Location = new System.Drawing.Point(275, 313);
            this.addPictureBox1.Name = "addPictureBox1";
            this.addPictureBox1.Size = new System.Drawing.Size(94, 29);
            this.addPictureBox1.TabIndex = 57;
            this.addPictureBox1.Text = "Thêm ảnh";
            this.addPictureBox1.UseVisualStyleBackColor = false;
            this.addPictureBox1.Click += new System.EventHandler(this.addPictureBox1_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.addButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(203, 600);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(231, 49);
            this.addButton.TabIndex = 58;
            this.addButton.Text = "Thêm sản phẩm";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // errorID
            // 
            this.errorID.ContainerControl = this;
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
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 681);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addPictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._productName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._productID);
            this.Controls.Add(this.productPicture);
            this.Controls.Add(this.formNameLable);
            this.Name = "FormAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addProduct";
            this.formNameLable.ResumeLayout(false);
            this.formNameLable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorprice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formNameLable;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addPictureBox1;
        private System.Windows.Forms.Button addButton;
        public System.Windows.Forms.TextBox _price;
        public System.Windows.Forms.TextBox _amount;
        public System.Windows.Forms.TextBox _productName;
        public System.Windows.Forms.TextBox _productID;
        public System.Windows.Forms.PictureBox productPicture;
        private System.Drawing.Bitmap bmp = null;
        private string filePath = null;
        private System.Windows.Forms.ErrorProvider errorID;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.ErrorProvider errorSL;
        private System.Windows.Forms.ErrorProvider errorprice;
    }
}