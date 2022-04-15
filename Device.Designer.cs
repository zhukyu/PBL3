namespace Gym
{
    partial class Device
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Device));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.employeeTable = new System.Windows.Forms.DataGridView();
            this.detail = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._importDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._employeeID = new System.Windows.Forms.TextBox();
            this._status = new System.Windows.Forms.TextBox();
            this._amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._deviceName = new System.Windows.Forms.TextBox();
            this._deviceID = new System.Windows.Forms.TextBox();
            this.deviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).BeginInit();
            this.detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 59);
            this.panel1.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(377, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 33);
            this.label9.TabIndex = 1;
            this.label9.Text = "Danh sách thiết bị";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.deleteButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(1061, 255);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(231, 49);
            this.deleteButton.TabIndex = 48;
            this.deleteButton.Text = "Xóa thiết bị";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.editButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(1061, 184);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(231, 49);
            this.editButton.TabIndex = 47;
            this.editButton.Text = "Sửa thông tin";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.addButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(1061, 116);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(231, 49);
            this.addButton.TabIndex = 46;
            this.addButton.Text = "Thêm thiết bị";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1270, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 45;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(1046, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 36);
            this.textBox2.TabIndex = 43;
            // 
            // employeeTable
            // 
            this.employeeTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.employeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deviceID,
            this.deviceName,
            this.amount,
            this.status,
            this.employeeID,
            this.importDate});
            this.employeeTable.Location = new System.Drawing.Point(9, 72);
            this.employeeTable.Name = "employeeTable";
            this.employeeTable.RowHeadersWidth = 51;
            this.employeeTable.RowTemplate.Height = 29;
            this.employeeTable.Size = new System.Drawing.Size(997, 308);
            this.employeeTable.TabIndex = 42;
            // 
            // detail
            // 
            this.detail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detail.Controls.Add(this.pictureBox1);
            this.detail.Controls.Add(this._importDate);
            this.detail.Controls.Add(this.label6);
            this.detail.Controls.Add(this.label7);
            this.detail.Controls.Add(this.label8);
            this.detail.Controls.Add(this._employeeID);
            this.detail.Controls.Add(this._status);
            this.detail.Controls.Add(this._amount);
            this.detail.Controls.Add(this.label3);
            this.detail.Controls.Add(this.label2);
            this.detail.Controls.Add(this.label1);
            this.detail.Controls.Add(this._deviceName);
            this.detail.Controls.Add(this._deviceID);
            this.detail.Location = new System.Drawing.Point(9, 386);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(1314, 260);
            this.detail.TabIndex = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 223);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // _importDate
            // 
            this._importDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._importDate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._importDate.Location = new System.Drawing.Point(919, 201);
            this._importDate.Name = "_importDate";
            this._importDate.Size = new System.Drawing.Size(255, 36);
            this._importDate.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(795, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 27);
            this.label6.TabIndex = 33;
            this.label6.Text = "Ngày nhập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(795, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 27);
            this.label7.TabIndex = 32;
            this.label7.Text = "NV quản lý";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(795, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 27);
            this.label8.TabIndex = 31;
            this.label8.Text = "Tình trạng";
            // 
            // _employeeID
            // 
            this._employeeID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._employeeID.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._employeeID.Location = new System.Drawing.Point(919, 114);
            this._employeeID.Name = "_employeeID";
            this._employeeID.Size = new System.Drawing.Size(255, 36);
            this._employeeID.TabIndex = 30;
            // 
            // _status
            // 
            this._status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._status.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._status.Location = new System.Drawing.Point(919, 27);
            this._status.Name = "_status";
            this._status.Size = new System.Drawing.Size(255, 36);
            this._status.TabIndex = 29;
            // 
            // _amount
            // 
            this._amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._amount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._amount.Location = new System.Drawing.Point(457, 201);
            this._amount.Name = "_amount";
            this._amount.Size = new System.Drawing.Size(255, 36);
            this._amount.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(343, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 27);
            this.label3.TabIndex = 25;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(343, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 27);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên TB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(343, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 27);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã TB";
            // 
            // _deviceName
            // 
            this._deviceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._deviceName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._deviceName.Location = new System.Drawing.Point(457, 114);
            this._deviceName.Name = "_deviceName";
            this._deviceName.Size = new System.Drawing.Size(255, 36);
            this._deviceName.TabIndex = 22;
            // 
            // _deviceID
            // 
            this._deviceID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._deviceID.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._deviceID.Location = new System.Drawing.Point(457, 28);
            this._deviceID.Name = "_deviceID";
            this._deviceID.Size = new System.Drawing.Size(255, 36);
            this._deviceID.TabIndex = 21;
            // 
            // deviceID
            // 
            this.deviceID.HeaderText = "Mã TB";
            this.deviceID.MinimumWidth = 6;
            this.deviceID.Name = "deviceID";
            this.deviceID.ReadOnly = true;
            this.deviceID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.deviceID.Width = 125;
            // 
            // deviceName
            // 
            this.deviceName.HeaderText = "Tên TB";
            this.deviceName.MinimumWidth = 6;
            this.deviceName.Name = "deviceName";
            this.deviceName.ReadOnly = true;
            this.deviceName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deviceName.Width = 250;
            // 
            // amount
            // 
            this.amount.HeaderText = "Số lượng";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.amount.Width = 125;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.HeaderText = "Tình trạng";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // employeeID
            // 
            this.employeeID.HeaderText = "NV quản lý";
            this.employeeID.MinimumWidth = 6;
            this.employeeID.Name = "employeeID";
            this.employeeID.ReadOnly = true;
            this.employeeID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.employeeID.Width = 150;
            // 
            // importDate
            // 
            this.importDate.HeaderText = "Ngày nhập";
            this.importDate.MinimumWidth = 6;
            this.importDate.Name = "importDate";
            this.importDate.ReadOnly = true;
            this.importDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.importDate.Width = 150;
            // 
            // Device
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 658);
            this.Controls.Add(this.detail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.employeeTable);
            this.Name = "Device";
            this.Text = "Device";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).EndInit();
            this.detail.ResumeLayout(false);
            this.detail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView employeeTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn importDate;
        private System.Windows.Forms.Panel detail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox _importDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _employeeID;
        private System.Windows.Forms.TextBox _status;
        private System.Windows.Forms.TextBox _amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _deviceName;
        private System.Windows.Forms.TextBox _deviceID;
    }
}