namespace Gym
{
    partial class FormProductReceipt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._total = new System.Windows.Forms.TextBox();
            this.productList = new System.Windows.Forms.DataGridView();
            this._productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._unitTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this._cashier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._publishDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this._receiptID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 59);
            this.panel1.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(741, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hóa đơn sản phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(29, 628);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 29);
            this.label8.TabIndex = 79;
            this.label8.Text = "TỔNG CỘNG";
            // 
            // _total
            // 
            this._total.BackColor = System.Drawing.Color.White;
            this._total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._total.Enabled = false;
            this._total.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._total.Location = new System.Drawing.Point(462, 628);
            this._total.Name = "_total";
            this._total.Size = new System.Drawing.Size(246, 29);
            this._total.TabIndex = 78;
            // 
            // productList
            // 
            this.productList.AllowUserToAddRows = false;
            this.productList.AllowUserToDeleteRows = false;
            this.productList.AllowUserToResizeColumns = false;
            this.productList.AllowUserToResizeRows = false;
            this.productList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.productList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._productName,
            this._amount,
            this._unitPrice,
            this._unitTotal});
            this.productList.Enabled = false;
            this.productList.EnableHeadersVisualStyles = false;
            this.productList.Location = new System.Drawing.Point(29, 197);
            this.productList.MultiSelect = false;
            this.productList.Name = "productList";
            this.productList.ReadOnly = true;
            this.productList.RowHeadersWidth = 51;
            this.productList.RowTemplate.Height = 29;
            this.productList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productList.Size = new System.Drawing.Size(679, 406);
            this.productList.TabIndex = 77;
            // 
            // _productName
            // 
            this._productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._productName.HeaderText = "Tên Sản phẩm";
            this._productName.MinimumWidth = 6;
            this._productName.Name = "_productName";
            this._productName.ReadOnly = true;
            // 
            // _amount
            // 
            this._amount.HeaderText = "Số lượng";
            this._amount.MinimumWidth = 6;
            this._amount.Name = "_amount";
            this._amount.ReadOnly = true;
            this._amount.Width = 115;
            // 
            // _unitPrice
            // 
            this._unitPrice.HeaderText = "Đơn giá";
            this._unitPrice.MinimumWidth = 6;
            this._unitPrice.Name = "_unitPrice";
            this._unitPrice.ReadOnly = true;
            this._unitPrice.Width = 150;
            // 
            // _unitTotal
            // 
            this._unitTotal.HeaderText = "Thành tiền";
            this._unitTotal.MinimumWidth = 6;
            this._unitTotal.Name = "_unitTotal";
            this._unitTotal.ReadOnly = true;
            this._unitTotal.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 29);
            this.label2.TabIndex = 68;
            this.label2.Text = "NV thu ngân";
            // 
            // _cashier
            // 
            this._cashier.BackColor = System.Drawing.Color.White;
            this._cashier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._cashier.Enabled = false;
            this._cashier.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cashier.Location = new System.Drawing.Point(196, 135);
            this._cashier.Name = "_cashier";
            this._cashier.Size = new System.Drawing.Size(192, 29);
            this._cashier.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(394, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 29);
            this.label6.TabIndex = 66;
            this.label6.Text = "Ngày xuất";
            // 
            // _publishDate
            // 
            this._publishDate.BackColor = System.Drawing.Color.White;
            this._publishDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._publishDate.Enabled = false;
            this._publishDate.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._publishDate.Location = new System.Drawing.Point(536, 83);
            this._publishDate.Name = "_publishDate";
            this._publishDate.Size = new System.Drawing.Size(172, 29);
            this._publishDate.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(29, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 29);
            this.label9.TabIndex = 64;
            this.label9.Text = "Mã HĐ";
            // 
            // _receiptID
            // 
            this._receiptID.BackColor = System.Drawing.Color.White;
            this._receiptID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._receiptID.Enabled = false;
            this._receiptID.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._receiptID.Location = new System.Drawing.Point(196, 83);
            this._receiptID.Name = "_receiptID";
            this._receiptID.Size = new System.Drawing.Size(192, 29);
            this._receiptID.TabIndex = 63;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(678, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormProductReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 712);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this._total);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._cashier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._publishDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this._receiptID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormProductReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductReceipt";
            this.Load += new System.EventHandler(this.ProductReceipt_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _total;
        private System.Windows.Forms.DataGridView productList;
        private System.Windows.Forms.DataGridViewTextBoxColumn _productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn _unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn _unitTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _cashier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _publishDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _receiptID;
        private System.Windows.Forms.Button button1;
    }
}