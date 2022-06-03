namespace Gym
{
    partial class CourseReceipt
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
            this.formNameLable = new System.Windows.Forms.Panel();
            this.formName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._receiptID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._publishDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._cashier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._customerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._idNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._phoneNumber = new System.Windows.Forms.TextBox();
            this.courseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseList = new System.Windows.Forms.DataGridView();
            this._courseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasPT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.courseTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this._total = new System.Windows.Forms.TextBox();
            this.formNameLable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseList)).BeginInit();
            this.SuspendLayout();
            // 
            // formNameLable
            // 
            this.formNameLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.formNameLable.Controls.Add(this.formName);
            this.formNameLable.Dock = System.Windows.Forms.DockStyle.Top;
            this.formNameLable.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formNameLable.ForeColor = System.Drawing.Color.White;
            this.formNameLable.Location = new System.Drawing.Point(0, 0);
            this.formNameLable.Margin = new System.Windows.Forms.Padding(0);
            this.formNameLable.Name = "formNameLable";
            this.formNameLable.Size = new System.Drawing.Size(735, 70);
            this.formNameLable.TabIndex = 38;
            // 
            // formName
            // 
            this.formName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formName.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.formName.Location = new System.Drawing.Point(0, 0);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(735, 70);
            this.formName.TabIndex = 1;
            this.formName.Text = "Hoá đơn khoá học";
            this.formName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(26, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 29);
            this.label6.TabIndex = 47;
            this.label6.Text = "Mã HĐ";
            // 
            // _receiptID
            // 
            this._receiptID.BackColor = System.Drawing.Color.White;
            this._receiptID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._receiptID.Enabled = false;
            this._receiptID.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._receiptID.Location = new System.Drawing.Point(193, 88);
            this._receiptID.Name = "_receiptID";
            this._receiptID.Size = new System.Drawing.Size(192, 29);
            this._receiptID.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(391, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 49;
            this.label1.Text = "Ngày xuất";
            // 
            // _publishDate
            // 
            this._publishDate.BackColor = System.Drawing.Color.White;
            this._publishDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._publishDate.Enabled = false;
            this._publishDate.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._publishDate.Location = new System.Drawing.Point(533, 88);
            this._publishDate.Name = "_publishDate";
            this._publishDate.Size = new System.Drawing.Size(172, 29);
            this._publishDate.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 29);
            this.label2.TabIndex = 51;
            this.label2.Text = "NV thu ngân";
            // 
            // _cashier
            // 
            this._cashier.BackColor = System.Drawing.Color.White;
            this._cashier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._cashier.Enabled = false;
            this._cashier.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cashier.Location = new System.Drawing.Point(193, 140);
            this._cashier.Name = "_cashier";
            this._cashier.Size = new System.Drawing.Size(192, 29);
            this._cashier.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 29);
            this.label3.TabIndex = 53;
            this.label3.Text = "Tên KH";
            // 
            // _customerName
            // 
            this._customerName.BackColor = System.Drawing.Color.White;
            this._customerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._customerName.Enabled = false;
            this._customerName.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._customerName.Location = new System.Drawing.Point(131, 217);
            this._customerName.Name = "_customerName";
            this._customerName.Size = new System.Drawing.Size(254, 29);
            this._customerName.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 55;
            this.label4.Text = "Địa chỉ";
            // 
            // _address
            // 
            this._address.BackColor = System.Drawing.Color.White;
            this._address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._address.Enabled = false;
            this._address.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._address.Location = new System.Drawing.Point(131, 325);
            this._address.Name = "_address";
            this._address.Size = new System.Drawing.Size(574, 29);
            this._address.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 29);
            this.label5.TabIndex = 57;
            this.label5.Text = "CMND";
            // 
            // _idNumber
            // 
            this._idNumber.BackColor = System.Drawing.Color.White;
            this._idNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._idNumber.Enabled = false;
            this._idNumber.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._idNumber.Location = new System.Drawing.Point(131, 270);
            this._idNumber.Name = "_idNumber";
            this._idNumber.Size = new System.Drawing.Size(254, 29);
            this._idNumber.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(391, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 29);
            this.label7.TabIndex = 59;
            this.label7.Text = "SĐT";
            // 
            // _phoneNumber
            // 
            this._phoneNumber.BackColor = System.Drawing.Color.White;
            this._phoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._phoneNumber.Enabled = false;
            this._phoneNumber.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._phoneNumber.Location = new System.Drawing.Point(459, 270);
            this._phoneNumber.Name = "_phoneNumber";
            this._phoneNumber.Size = new System.Drawing.Size(246, 29);
            this._phoneNumber.TabIndex = 58;
            // 
            // courseName
            // 
            this.courseName.HeaderText = "Tên khóa học";
            this.courseName.MinimumWidth = 6;
            this.courseName.Name = "courseName";
            this.courseName.Width = 150;
            // 
            // courseList
            // 
            this.courseList.AllowUserToAddRows = false;
            this.courseList.AllowUserToDeleteRows = false;
            this.courseList.AllowUserToResizeColumns = false;
            this.courseList.AllowUserToResizeRows = false;
            this.courseList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.courseList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.courseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.courseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._courseName,
            this._duration,
            this.hasPT,
            this.courseTotal});
            this.courseList.Enabled = false;
            this.courseList.EnableHeadersVisualStyles = false;
            this.courseList.Location = new System.Drawing.Point(26, 383);
            this.courseList.MultiSelect = false;
            this.courseList.Name = "courseList";
            this.courseList.ReadOnly = true;
            this.courseList.RowHeadersWidth = 51;
            this.courseList.RowTemplate.Height = 29;
            this.courseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.courseList.Size = new System.Drawing.Size(679, 217);
            this.courseList.TabIndex = 60;
            // 
            // _courseName
            // 
            this._courseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._courseName.HeaderText = "Tên Khóa học";
            this._courseName.MinimumWidth = 6;
            this._courseName.Name = "_courseName";
            this._courseName.ReadOnly = true;
            // 
            // _duration
            // 
            this._duration.HeaderText = "Thời gian";
            this._duration.MinimumWidth = 6;
            this._duration.Name = "_duration";
            this._duration.ReadOnly = true;
            this._duration.Width = 125;
            // 
            // hasPT
            // 
            this.hasPT.HeaderText = "Tập cùng PT";
            this.hasPT.MinimumWidth = 6;
            this.hasPT.Name = "hasPT";
            this.hasPT.ReadOnly = true;
            this.hasPT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hasPT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hasPT.Width = 138;
            // 
            // courseTotal
            // 
            this.courseTotal.HeaderText = "Tổng tiền";
            this.courseTotal.MinimumWidth = 6;
            this.courseTotal.Name = "courseTotal";
            this.courseTotal.ReadOnly = true;
            this.courseTotal.Width = 180;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(26, 633);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 29);
            this.label8.TabIndex = 62;
            this.label8.Text = "TỔNG CỘNG";
            // 
            // _total
            // 
            this._total.BackColor = System.Drawing.Color.White;
            this._total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._total.Enabled = false;
            this._total.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._total.Location = new System.Drawing.Point(459, 633);
            this._total.Name = "_total";
            this._total.Size = new System.Drawing.Size(246, 29);
            this._total.TabIndex = 61;
            // 
            // CourseReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 708);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._total);
            this.Controls.Add(this.courseList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._phoneNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._idNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._customerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._cashier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._publishDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._receiptID);
            this.Controls.Add(this.formNameLable);
            this.MaximizeBox = false;
            this.Name = "CourseReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseReceipt";
            this.Load += new System.EventHandler(this.CourseReceipt_Load);
            this.formNameLable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courseList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formNameLable;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _receiptID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _publishDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _cashier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _customerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _idNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseName;
        private System.Windows.Forms.DataGridView courseList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _total;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _duration;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTotal;
    }
}