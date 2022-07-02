namespace Gym
{
    partial class FormProductSale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductSale));
            this._cashier = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.amountInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.productCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this._change = new System.Windows.Forms.TextBox();
            this._received = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.acceptBtn = new System.Windows.Forms.Button();
            this._publishDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this._saleID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.formName = new System.Windows.Forms.Label();
            this.productList = new System.Windows.Forms.DataGridView();
            this._productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._unitTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formNameLable = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productList)).BeginInit();
            this.formNameLable.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cashier
            // 
            this._cashier.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cashier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._cashier.Enabled = false;
            this._cashier.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cashier.Location = new System.Drawing.Point(673, 107);
            this._cashier.Name = "_cashier";
            this._cashier.Size = new System.Drawing.Size(316, 33);
            this._cashier.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(498, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 37);
            this.label8.TabIndex = 70;
            this.label8.Text = "NV thu ngân";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.addBtn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(605, 221);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 49);
            this.addBtn.TabIndex = 69;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.editBtn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(721, 221);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(100, 49);
            this.editBtn.TabIndex = 67;
            this.editBtn.Text = "Sửa";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.deleteBtn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(839, 221);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 49);
            this.deleteBtn.TabIndex = 66;
            this.deleteBtn.Text = "Xoá";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // amountInput
            // 
            this.amountInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountInput.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountInput.Location = new System.Drawing.Point(438, 231);
            this.amountInput.Name = "amountInput";
            this.amountInput.Size = new System.Drawing.Size(106, 33);
            this.amountInput.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(432, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 30);
            this.label9.TabIndex = 63;
            this.label9.Text = "Số lượng";
            // 
            // productCb
            // 
            this.productCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productCb.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productCb.FormattingEnabled = true;
            this.productCb.Location = new System.Drawing.Point(76, 229);
            this.productCb.Name = "productCb";
            this.productCb.Size = new System.Drawing.Size(340, 35);
            this.productCb.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(156, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 30);
            this.label6.TabIndex = 57;
            this.label6.Text = "Tên sản phẩm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this._change);
            this.panel1.Controls.Add(this._received);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this._total);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.acceptBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 739);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 223);
            this.panel1.TabIndex = 73;
            // 
            // _change
            // 
            this._change.BackColor = System.Drawing.Color.WhiteSmoke;
            this._change.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._change.Enabled = false;
            this._change.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._change.ForeColor = System.Drawing.SystemColors.MenuText;
            this._change.Location = new System.Drawing.Point(810, 54);
            this._change.Name = "_change";
            this._change.Size = new System.Drawing.Size(179, 33);
            this._change.TabIndex = 75;
            this._change.Text = "0";
            // 
            // _received
            // 
            this._received.BackColor = System.Drawing.Color.WhiteSmoke;
            this._received.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._received.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._received.ForeColor = System.Drawing.SystemColors.MenuText;
            this._received.Location = new System.Drawing.Point(479, 54);
            this._received.Name = "_received";
            this._received.Size = new System.Drawing.Size(179, 33);
            this._received.TabIndex = 74;
            this._received.TextChanged += new System.EventHandler(this._received_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(691, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 37);
            this.label7.TabIndex = 73;
            this.label7.Text = "Tiền trả";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(361, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 37);
            this.label5.TabIndex = 71;
            this.label5.Text = "Tiền gửi";
            // 
            // _total
            // 
            this._total.BackColor = System.Drawing.Color.WhiteSmoke;
            this._total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._total.Enabled = false;
            this._total.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._total.ForeColor = System.Drawing.SystemColors.InfoText;
            this._total.Location = new System.Drawing.Point(150, 54);
            this._total.Name = "_total";
            this._total.Size = new System.Drawing.Size(179, 33);
            this._total.TabIndex = 70;
            this._total.Text = "0";
            this._total.TextChanged += new System.EventHandler(this._total_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 37);
            this.label3.TabIndex = 69;
            this.label3.Text = "Tổng tiền";
            // 
            // acceptBtn
            // 
            this.acceptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.acceptBtn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.acceptBtn.ForeColor = System.Drawing.Color.White;
            this.acceptBtn.Location = new System.Drawing.Point(839, 138);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(150, 49);
            this.acceptBtn.TabIndex = 68;
            this.acceptBtn.Text = "Xác nhận";
            this.acceptBtn.UseVisualStyleBackColor = false;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // _publishDate
            // 
            this._publishDate.Enabled = false;
            this._publishDate.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._publishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._publishDate.Location = new System.Drawing.Point(190, 107);
            this._publishDate.Name = "_publishDate";
            this._publishDate.Size = new System.Drawing.Size(193, 34);
            this._publishDate.TabIndex = 51;
            this._publishDate.Value = new System.DateTime(2022, 6, 1, 0, 46, 54, 0);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(24, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 37);
            this.label4.TabIndex = 54;
            this.label4.Text = "Ngày tạo";
            // 
            // _saleID
            // 
            this._saleID.BackColor = System.Drawing.Color.WhiteSmoke;
            this._saleID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._saleID.Enabled = false;
            this._saleID.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._saleID.Location = new System.Drawing.Point(190, 36);
            this._saleID.Name = "_saleID";
            this._saleID.Size = new System.Drawing.Size(193, 33);
            this._saleID.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã đơn hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(498, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bán sản phẩm";
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.formName.Location = new System.Drawing.Point(59, 102);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(0, 33);
            this.formName.TabIndex = 1;
            // 
            // productList
            // 
            this.productList.AllowUserToAddRows = false;
            this.productList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.productList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._productID,
            this._productName,
            this._amount,
            this._price,
            this._unitTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productList.DefaultCellStyle = dataGridViewCellStyle2;
            this.productList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productList.EnableHeadersVisualStyles = false;
            this.productList.Location = new System.Drawing.Point(0, 304);
            this.productList.MultiSelect = false;
            this.productList.Name = "productList";
            this.productList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.productList.RowHeadersWidth = 51;
            this.productList.RowTemplate.Height = 29;
            this.productList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productList.Size = new System.Drawing.Size(1017, 658);
            this.productList.TabIndex = 72;
            this.productList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productList_CellClick);
            // 
            // _productID
            // 
            this._productID.HeaderText = "Mã SP";
            this._productID.MinimumWidth = 6;
            this._productID.Name = "_productID";
            this._productID.ReadOnly = true;
            this._productID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._productID.Width = 140;
            // 
            // _productName
            // 
            this._productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._productName.HeaderText = "Tên sản phẩm";
            this._productName.MinimumWidth = 6;
            this._productName.Name = "_productName";
            this._productName.ReadOnly = true;
            this._productName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _amount
            // 
            this._amount.HeaderText = "Số lượng";
            this._amount.MinimumWidth = 6;
            this._amount.Name = "_amount";
            this._amount.ReadOnly = true;
            this._amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._amount.Width = 130;
            // 
            // _price
            // 
            this._price.HeaderText = "Đơn giá";
            this._price.MinimumWidth = 6;
            this._price.Name = "_price";
            this._price.ReadOnly = true;
            this._price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._price.Width = 161;
            // 
            // _unitTotal
            // 
            this._unitTotal.HeaderText = "Thành tiền";
            this._unitTotal.MinimumWidth = 6;
            this._unitTotal.Name = "_unitTotal";
            this._unitTotal.ReadOnly = true;
            this._unitTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._unitTotal.Width = 161;
            // 
            // formNameLable
            // 
            this.formNameLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.formNameLable.Controls.Add(this.button1);
            this.formNameLable.Controls.Add(this._cashier);
            this.formNameLable.Controls.Add(this.label8);
            this.formNameLable.Controls.Add(this.addBtn);
            this.formNameLable.Controls.Add(this.editBtn);
            this.formNameLable.Controls.Add(this.deleteBtn);
            this.formNameLable.Controls.Add(this.amountInput);
            this.formNameLable.Controls.Add(this.label9);
            this.formNameLable.Controls.Add(this.productCb);
            this.formNameLable.Controls.Add(this.label6);
            this.formNameLable.Controls.Add(this._publishDate);
            this.formNameLable.Controls.Add(this.label4);
            this.formNameLable.Controls.Add(this._saleID);
            this.formNameLable.Controls.Add(this.label2);
            this.formNameLable.Controls.Add(this.label1);
            this.formNameLable.Controls.Add(this.formName);
            this.formNameLable.Dock = System.Windows.Forms.DockStyle.Top;
            this.formNameLable.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formNameLable.ForeColor = System.Drawing.Color.White;
            this.formNameLable.Location = new System.Drawing.Point(0, 0);
            this.formNameLable.Margin = new System.Windows.Forms.Padding(0);
            this.formNameLable.Name = "formNameLable";
            this.formNameLable.Size = new System.Drawing.Size(1017, 304);
            this.formNameLable.TabIndex = 71;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(956, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 48);
            this.button1.TabIndex = 72;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormProductSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 962);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.formNameLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "test";
            this.Load += new System.EventHandler(this.FormProductSale_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productList)).EndInit();
            this.formNameLable.ResumeLayout(false);
            this.formNameLable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox _cashier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox amountInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox productCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox _change;
        private System.Windows.Forms.TextBox _received;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.DateTimePicker _publishDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _saleID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.DataGridView productList;
        private System.Windows.Forms.Panel formNameLable;
        private System.Windows.Forms.DataGridViewTextBoxColumn _productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn _price;
        private System.Windows.Forms.DataGridViewTextBoxColumn _unitTotal;
        private System.Windows.Forms.Button button1;
    }
}