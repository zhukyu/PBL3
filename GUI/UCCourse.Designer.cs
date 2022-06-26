namespace Gym
{
    partial class UCCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCourse));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this._price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._duration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._courseName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._courseID = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.formNameLable = new System.Windows.Forms.Panel();
            this.formName = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.button2 = new System.Windows.Forms.Button();
            this.botPanel = new System.Windows.Forms.Panel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.courseList = new System.Windows.Forms.Panel();
            this.memberTable = new System.Windows.Forms.DataGridView();
            this.courseIDClmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameClmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationClmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceClmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.formNameLable.SuspendLayout();
            this.botPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.courseList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberTable)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this._price);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this._duration);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this._courseName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this._courseID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1320, 228);
            this.panel2.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(694, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 45;
            this.label3.Text = "Đơn giá :";
            // 
            // _price
            // 
            this._price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._price.BackColor = System.Drawing.Color.White;
            this._price.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._price.Location = new System.Drawing.Point(923, 139);
            this._price.Name = "_price";
            this._price.Size = new System.Drawing.Size(245, 40);
            this._price.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(126, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 29);
            this.label4.TabIndex = 43;
            this.label4.Text = "Thời gian :";
            // 
            // _duration
            // 
            this._duration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._duration.BackColor = System.Drawing.Color.White;
            this._duration.Enabled = false;
            this._duration.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._duration.Location = new System.Drawing.Point(361, 139);
            this._duration.Name = "_duration";
            this._duration.Size = new System.Drawing.Size(245, 40);
            this._duration.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(694, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 41;
            this.label2.Text = "Tên khóa học :";
            // 
            // _courseName
            // 
            this._courseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._courseName.BackColor = System.Drawing.Color.White;
            this._courseName.Enabled = false;
            this._courseName.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._courseName.Location = new System.Drawing.Point(923, 59);
            this._courseName.Name = "_courseName";
            this._courseName.Size = new System.Drawing.Size(245, 40);
            this._courseName.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(126, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 29);
            this.label6.TabIndex = 39;
            this.label6.Text = "Mã khóa học :";
            // 
            // _courseID
            // 
            this._courseID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._courseID.BackColor = System.Drawing.Color.White;
            this._courseID.Enabled = false;
            this._courseID.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._courseID.Location = new System.Drawing.Point(361, 59);
            this._courseID.Name = "_courseID";
            this._courseID.Size = new System.Drawing.Size(245, 40);
            this._courseID.TabIndex = 37;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.deleteButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.Location = new System.Drawing.Point(23, 237);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(167, 49);
            this.deleteButton.TabIndex = 63;
            this.deleteButton.Text = "Xóa";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 59);
            this.panel1.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1320, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi tiết khóa học";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.editButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.Location = new System.Drawing.Point(224, 126);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(167, 49);
            this.editButton.TabIndex = 62;
            this.editButton.Text = "Sửa ";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
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
            this.formNameLable.Size = new System.Drawing.Size(901, 59);
            this.formNameLable.TabIndex = 60;
            // 
            // formName
            // 
            this.formName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formName.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.formName.Location = new System.Drawing.Point(0, 0);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(901, 59);
            this.formName.TabIndex = 1;
            this.formName.Text = "Danh sách khóa học";
            this.formName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.addButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(23, 126);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(167, 49);
            this.addButton.TabIndex = 61;
            this.addButton.Text = "Thêm";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.White;
            this.search.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.search.ForeColor = System.Drawing.Color.Gray;
            this.search.Location = new System.Drawing.Point(23, 37);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(270, 43);
            this.search.TabIndex = 57;
            this.search.Text = "ID,TÊN";
            this.search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            this.search.Enter += new System.EventHandler(this.search_Enter);
            this.search.Leave += new System.EventHandler(this.search_Leave);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(318, 32);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(73, 52);
            this.searchButton.TabIndex = 58;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(45, 91);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(26, 34);
            this.listView1.TabIndex = 65;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "Mã khóa học";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "Tên Khóa học";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Name = "columnHeader3";
            this.columnHeader3.Text = "Thời gian";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Name = "columnHeader4";
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 200;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(224, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 49);
            this.button2.TabIndex = 67;
            this.button2.Text = "  Đặt lại";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // botPanel
            // 
            this.botPanel.Controls.Add(this.panel2);
            this.botPanel.Controls.Add(this.panel1);
            this.botPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botPanel.Location = new System.Drawing.Point(3, 361);
            this.botPanel.Name = "botPanel";
            this.botPanel.Size = new System.Drawing.Size(1320, 287);
            this.botPanel.TabIndex = 68;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.deleteButton);
            this.controlPanel.Controls.Add(this.searchButton);
            this.controlPanel.Controls.Add(this.search);
            this.controlPanel.Controls.Add(this.addButton);
            this.controlPanel.Controls.Add(this.editButton);
            this.controlPanel.Controls.Add(this.button2);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlPanel.Location = new System.Drawing.Point(901, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(419, 352);
            this.controlPanel.TabIndex = 0;
            // 
            // courseList
            // 
            this.courseList.Controls.Add(this.memberTable);
            this.courseList.Controls.Add(this.formNameLable);
            this.courseList.Controls.Add(this.controlPanel);
            this.courseList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseList.Location = new System.Drawing.Point(0, 0);
            this.courseList.Name = "courseList";
            this.courseList.Size = new System.Drawing.Size(1320, 352);
            this.courseList.TabIndex = 0;
            // 
            // memberTable
            // 
            this.memberTable.AllowUserToAddRows = false;
            this.memberTable.AllowUserToDeleteRows = false;
            this.memberTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.memberTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.memberTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.memberTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDClmn,
            this.courseNameClmn,
            this.durationClmn,
            this.priceClmn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.memberTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.memberTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberTable.EnableHeadersVisualStyles = false;
            this.memberTable.Location = new System.Drawing.Point(0, 59);
            this.memberTable.Name = "memberTable";
            this.memberTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.memberTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.memberTable.RowHeadersWidth = 51;
            this.memberTable.RowTemplate.Height = 29;
            this.memberTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.memberTable.Size = new System.Drawing.Size(901, 293);
            this.memberTable.TabIndex = 61;
            // 
            // courseIDClmn
            // 
            this.courseIDClmn.HeaderText = "Mã KH";
            this.courseIDClmn.MinimumWidth = 6;
            this.courseIDClmn.Name = "courseIDClmn";
            this.courseIDClmn.ReadOnly = true;
            // 
            // courseNameClmn
            // 
            this.courseNameClmn.HeaderText = "Tên khóa học";
            this.courseNameClmn.MinimumWidth = 6;
            this.courseNameClmn.Name = "courseNameClmn";
            this.courseNameClmn.ReadOnly = true;
            // 
            // durationClmn
            // 
            this.durationClmn.HeaderText = "Thời gian";
            this.durationClmn.MinimumWidth = 6;
            this.durationClmn.Name = "durationClmn";
            this.durationClmn.ReadOnly = true;
            // 
            // priceClmn
            // 
            this.priceClmn.HeaderText = "Đơn giá";
            this.priceClmn.MinimumWidth = 6;
            this.priceClmn.Name = "priceClmn";
            this.priceClmn.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.topPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.botPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1326, 651);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.courseList);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel.Location = new System.Drawing.Point(3, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1320, 352);
            this.topPanel.TabIndex = 0;
            // 
            // UCCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listView1);
            this.Name = "UCCourse";
            this.Size = new System.Drawing.Size(1326, 651);
            this.Load += new System.EventHandler(this.Course_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.formNameLable.ResumeLayout(false);
            this.botPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.courseList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memberTable)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _duration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _courseName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _courseID;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Panel formNameLable;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel botPanel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel courseList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.DataGridView memberTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDClmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameClmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationClmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceClmn;
    }
}