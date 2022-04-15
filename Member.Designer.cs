namespace Gym
{
    partial class Member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member));
            this.searchButton = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.employeeTable = new System.Windows.Forms.DataGridView();
            this.formName = new System.Windows.Forms.Label();
            this.formNameLable = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this._address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._idNumber = new System.Windows.Forms.TextBox();
            this._phoneNumber = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._gender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._fullName = new System.Windows.Forms.TextBox();
            this._customerID = new System.Windows.Forms.TextBox();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).BeginInit();
            this.formNameLable.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(329, 36);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(36, 32);
            this.searchButton.TabIndex = 30;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // search
            // 
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search.Location = new System.Drawing.Point(51, 36);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(272, 32);
            this.search.TabIndex = 28;
            // 
            // employeeTable
            // 
            this.employeeTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.employeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerID,
            this.fullname,
            this.phoneNumber,
            this.courseName,
            this.registerDate,
            this.expiredDate});
            this.employeeTable.Location = new System.Drawing.Point(12, 75);
            this.employeeTable.Name = "employeeTable";
            this.employeeTable.RowHeadersWidth = 51;
            this.employeeTable.RowTemplate.Height = 29;
            this.employeeTable.Size = new System.Drawing.Size(903, 571);
            this.employeeTable.TabIndex = 27;
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.formName.Location = new System.Drawing.Point(285, 13);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(269, 33);
            this.formName.TabIndex = 1;
            this.formName.Text = "Danh sách hội viên";
            // 
            // formNameLable
            // 
            this.formNameLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.formNameLable.Controls.Add(this.formName);
            this.formNameLable.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formNameLable.ForeColor = System.Drawing.Color.White;
            this.formNameLable.Location = new System.Drawing.Point(12, 13);
            this.formNameLable.Margin = new System.Windows.Forms.Padding(0);
            this.formNameLable.Name = "formNameLable";
            this.formNameLable.Size = new System.Drawing.Size(903, 59);
            this.formNameLable.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(921, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 59);
            this.panel1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi tiết khách hàng";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this._address);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this._idNumber);
            this.panel2.Controls.Add(this._phoneNumber);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this._gender);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this._fullName);
            this.panel2.Controls.Add(this._customerID);
            this.panel2.Location = new System.Drawing.Point(921, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 403);
            this.panel2.TabIndex = 36;
            // 
            // _address
            // 
            this._address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._address.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._address.Location = new System.Drawing.Point(137, 344);
            this._address.Name = "_address";
            this._address.Size = new System.Drawing.Size(245, 27);
            this._address.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(17, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 49;
            this.label5.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(17, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 24);
            this.label7.TabIndex = 48;
            this.label7.Text = "Số CMND";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(17, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "SĐT";
            // 
            // _idNumber
            // 
            this._idNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._idNumber.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._idNumber.Location = new System.Drawing.Point(137, 291);
            this._idNumber.Name = "_idNumber";
            this._idNumber.Size = new System.Drawing.Size(245, 27);
            this._idNumber.TabIndex = 46;
            // 
            // _phoneNumber
            // 
            this._phoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._phoneNumber.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._phoneNumber.Location = new System.Drawing.Point(137, 237);
            this._phoneNumber.Name = "_phoneNumber";
            this._phoneNumber.Size = new System.Drawing.Size(245, 27);
            this._phoneNumber.TabIndex = 45;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(137, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 27);
            this.textBox1.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 43;
            this.label4.Text = "Ngày sinh";
            // 
            // _gender
            // 
            this._gender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._gender.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._gender.Location = new System.Drawing.Point(137, 128);
            this._gender.Name = "_gender";
            this._gender.Size = new System.Drawing.Size(245, 27);
            this._gender.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 40;
            this.label2.Text = "Họ tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(17, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 39;
            this.label6.Text = "Mã KH";
            // 
            // _fullName
            // 
            this._fullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._fullName.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._fullName.Location = new System.Drawing.Point(137, 73);
            this._fullName.Name = "_fullName";
            this._fullName.Size = new System.Drawing.Size(245, 27);
            this._fullName.TabIndex = 38;
            // 
            // _customerID
            // 
            this._customerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._customerID.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._customerID.Location = new System.Drawing.Point(137, 20);
            this._customerID.Name = "_customerID";
            this._customerID.Size = new System.Drawing.Size(245, 27);
            this._customerID.TabIndex = 37;
            // 
            // customerID
            // 
            this.customerID.HeaderText = "Mã HV";
            this.customerID.MinimumWidth = 6;
            this.customerID.Name = "customerID";
            this.customerID.ReadOnly = true;
            this.customerID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.customerID.Width = 120;
            // 
            // fullname
            // 
            this.fullname.HeaderText = "Họ tên";
            this.fullname.MinimumWidth = 6;
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            this.fullname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fullname.Width = 220;
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "Số điện thoại";
            this.phoneNumber.MinimumWidth = 6;
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.ReadOnly = true;
            this.phoneNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.phoneNumber.Width = 125;
            // 
            // courseName
            // 
            this.courseName.HeaderText = "Tên khóa học";
            this.courseName.MinimumWidth = 6;
            this.courseName.Name = "courseName";
            this.courseName.ReadOnly = true;
            this.courseName.Width = 125;
            // 
            // registerDate
            // 
            this.registerDate.HeaderText = "Ngày đăng ký";
            this.registerDate.MinimumWidth = 6;
            this.registerDate.Name = "registerDate";
            this.registerDate.ReadOnly = true;
            this.registerDate.Width = 130;
            // 
            // expiredDate
            // 
            this.expiredDate.HeaderText = "Ngày hết hạn";
            this.expiredDate.MinimumWidth = 6;
            this.expiredDate.Name = "expiredDate";
            this.expiredDate.ReadOnly = true;
            this.expiredDate.Width = 130;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(138, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 33);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tìm kiếm";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel3.Controls.Add(this.label9);
            this.panel3.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(921, 481);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 59);
            this.panel3.TabIndex = 36;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.search);
            this.panel4.Controls.Add(this.searchButton);
            this.panel4.Location = new System.Drawing.Point(921, 543);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(402, 103);
            this.panel4.TabIndex = 37;
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1335, 658);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.formNameLable);
            this.Controls.Add(this.employeeTable);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Member";
            this.Text = "Member";
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).EndInit();
            this.formNameLable.ResumeLayout(false);
            this.formNameLable.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.DataGridView employeeTable;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.Panel formNameLable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox _address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _idNumber;
        private System.Windows.Forms.TextBox _phoneNumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _gender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _fullName;
        private System.Windows.Forms.TextBox _customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiredDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}