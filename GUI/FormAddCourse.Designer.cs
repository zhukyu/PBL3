namespace Gym
{
    partial class FormAddCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCourse));
            this.formNameLable = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.formName = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this._courseName = new System.Windows.Forms.TextBox();
            this._duration = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this._price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._courseID = new System.Windows.Forms.TextBox();
            this.errorID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTime = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorprice = new System.Windows.Forms.ErrorProvider(this.components);
            this.formNameLable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorprice)).BeginInit();
            this.SuspendLayout();
            // 
            // formNameLable
            // 
            this.formNameLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.formNameLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.formNameLable.Controls.Add(this.button1);
            this.formNameLable.Controls.Add(this.formName);
            this.formNameLable.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formNameLable.ForeColor = System.Drawing.Color.White;
            this.formNameLable.Location = new System.Drawing.Point(-2, -2);
            this.formNameLable.Margin = new System.Windows.Forms.Padding(0);
            this.formNameLable.Name = "formNameLable";
            this.formNameLable.Size = new System.Drawing.Size(575, 70);
            this.formNameLable.TabIndex = 37;
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
            this.button1.Location = new System.Drawing.Point(516, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 50);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.formName.Location = new System.Drawing.Point(173, 25);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(221, 33);
            this.formName.TabIndex = 1;
            this.formName.Text = "Thêm khoá học";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.addButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(164, 527);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(231, 49);
            this.addButton.TabIndex = 62;
            this.addButton.Text = "Thêm khóa học";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // _courseName
            // 
            this._courseName.BackColor = System.Drawing.Color.White;
            this._courseName.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._courseName.Location = new System.Drawing.Point(263, 223);
            this._courseName.Name = "_courseName";
            this._courseName.Size = new System.Drawing.Size(245, 40);
            this._courseName.TabIndex = 77;
            this._courseName.Validating += new System.ComponentModel.CancelEventHandler(this._courseName_Validating);
            // 
            // _duration
            // 
            this._duration.BackColor = System.Drawing.Color.White;
            this._duration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._duration.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._duration.FormattingEnabled = true;
            this._duration.Items.AddRange(new object[] {
            "1 Tháng",
            "3 Tháng",
            "6 Tháng",
            "12 Tháng"});
            this._duration.Location = new System.Drawing.Point(263, 308);
            this._duration.Name = "_duration";
            this._duration.Size = new System.Drawing.Size(245, 39);
            this._duration.TabIndex = 76;
            this._duration.Validating += new System.ComponentModel.CancelEventHandler(this._duration_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(81, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 75;
            this.label3.Text = "Đơn giá :";
            // 
            // _price
            // 
            this._price.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._price.Location = new System.Drawing.Point(263, 387);
            this._price.Name = "_price";
            this._price.Size = new System.Drawing.Size(245, 40);
            this._price.TabIndex = 74;
            this._price.Validating += new System.ComponentModel.CancelEventHandler(this._price_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(81, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 73;
            this.label4.Text = "Thời gian :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(81, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 72;
            this.label2.Text = "Tên khóa học :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(81, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 24);
            this.label6.TabIndex = 71;
            this.label6.Text = "Mã khóa học :";
            // 
            // _courseID
            // 
            this._courseID.BackColor = System.Drawing.Color.White;
            this._courseID.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._courseID.Location = new System.Drawing.Point(263, 141);
            this._courseID.Name = "_courseID";
            this._courseID.ReadOnly = true;
            this._courseID.Size = new System.Drawing.Size(245, 40);
            this._courseID.TabIndex = 70;
            this._courseID.Validating += new System.ComponentModel.CancelEventHandler(this._courseID_Validating);
            // 
            // errorID
            // 
            this.errorID.ContainerControl = this;
            // 
            // errorName
            // 
            this.errorName.ContainerControl = this;
            // 
            // errorTime
            // 
            this.errorTime.ContainerControl = this;
            // 
            // errorprice
            // 
            this.errorprice.ContainerControl = this;
            // 
            // FormAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 633);
            this.ControlBox = false;
            this.Controls.Add(this._courseName);
            this.Controls.Add(this._duration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._courseID);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.formNameLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddCourse";
            this.Text = "addCourse";
            this.Load += new System.EventHandler(this.FormAddCourse_Load);
            this.formNameLable.ResumeLayout(false);
            this.formNameLable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorprice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formNameLable;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.Button addButton;
        public System.Windows.Forms.TextBox _courseName;
        public System.Windows.Forms.ComboBox _duration;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox _price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox _courseID;
        private System.Windows.Forms.ErrorProvider errorID;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.ErrorProvider errorTime;
        private System.Windows.Forms.ErrorProvider errorprice;
        private System.Windows.Forms.Button button1;
    }
}