namespace Gym
{
    partial class updateProduct
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
            this.formNameLable = new System.Windows.Forms.Panel();
            this.formName = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.addPictureBox1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this._price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._productName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._productID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.formNameLable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // formNameLable
            // 
            this.formNameLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.formNameLable.Controls.Add(this.formName);
            this.formNameLable.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formNameLable.ForeColor = System.Drawing.Color.White;
            this.formNameLable.Location = new System.Drawing.Point(-4, 0);
            this.formNameLable.Margin = new System.Windows.Forms.Padding(0);
            this.formNameLable.Name = "formNameLable";
            this.formNameLable.Size = new System.Drawing.Size(645, 66);
            this.formNameLable.TabIndex = 59;
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
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.addButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(200, 565);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(216, 46);
            this.addButton.TabIndex = 70;
            this.addButton.Text = "Thêm sản phẩm";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addPictureBox1
            // 
            this.addPictureBox1.Location = new System.Drawing.Point(259, 234);
            this.addPictureBox1.Name = "addPictureBox1";
            this.addPictureBox1.Size = new System.Drawing.Size(117, 26);
            this.addPictureBox1.TabIndex = 69;
            this.addPictureBox1.Text = "Thay đổi ảnh";
            this.addPictureBox1.UseVisualStyleBackColor = true;
            this.addPictureBox1.Click += new System.EventHandler(this.addPictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(166, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 68;
            this.label3.Text = "Đơn giá";
            // 
            // _price
            // 
            this._price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._price.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._price.Location = new System.Drawing.Point(291, 452);
            this._price.Name = "_price";
            this._price.Size = new System.Drawing.Size(140, 29);
            this._price.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(166, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 29);
            this.label4.TabIndex = 66;
            this.label4.Text = "Số lượng";
            // 
            // _amount
            // 
            this._amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._amount.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._amount.Location = new System.Drawing.Point(291, 404);
            this._amount.Name = "_amount";
            this._amount.Size = new System.Drawing.Size(140, 29);
            this._amount.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(166, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 64;
            this.label2.Text = "Tên SP";
            // 
            // _productName
            // 
            this._productName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._productName.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._productName.Location = new System.Drawing.Point(291, 352);
            this._productName.Name = "_productName";
            this._productName.Size = new System.Drawing.Size(140, 29);
            this._productName.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(166, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 29);
            this.label6.TabIndex = 62;
            this.label6.Text = "Mã SP";
            // 
            // _productID
            // 
            this._productID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._productID.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._productID.Location = new System.Drawing.Point(291, 305);
            this._productID.Name = "_productID";
            this._productID.Size = new System.Drawing.Size(140, 29);
            this._productID.TabIndex = 61;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(212, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // updateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 648);
            this.Controls.Add(this.formNameLable);
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
            this.Controls.Add(this.pictureBox1);
            this.Name = "updateProduct";
            this.Text = "fixProduct";
            this.formNameLable.ResumeLayout(false);
            this.formNameLable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formNameLable;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button addPictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox _price;
        public System.Windows.Forms.TextBox _amount;
        public System.Windows.Forms.TextBox _productName;
        public System.Windows.Forms.TextBox _productID;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Drawing.Bitmap bmp = null;
        private string filePath = null;
    }
}