using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Gym
{
    partial class Home
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
        /// 
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Button();
            this.revenueButton = new System.Windows.Forms.Button();
            this.deviceButton = new System.Windows.Forms.Button();
            this.courseButton = new System.Windows.Forms.Button();
            this.productButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.employeeButton = new System.Windows.Forms.Button();
            this.memberButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pContainer = new System.Windows.Forms.Panel();
            this.formNameLable = new System.Windows.Forms.Panel();
            this.btnminMax = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.formName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.formNameLable.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.logOutButton);
            this.panelMenu.Controls.Add(this.revenueButton);
            this.panelMenu.Controls.Add(this.deviceButton);
            this.panelMenu.Controls.Add(this.courseButton);
            this.panelMenu.Controls.Add(this.productButton);
            this.panelMenu.Controls.Add(this.customerButton);
            this.panelMenu.Controls.Add(this.employeeButton);
            this.panelMenu.Controls.Add(this.memberButton);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(267, 783);
            this.panelMenu.TabIndex = 1;
            // 
            // logOutButton
            // 
            this.logOutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logOutButton.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logOutButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.logOutButton.Image = ((System.Drawing.Image)(resources.GetObject("logOutButton.Image")));
            this.logOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.Location = new System.Drawing.Point(0, 685);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Padding = new System.Windows.Forms.Padding(12, 0, 25, 0);
            this.logOutButton.Size = new System.Drawing.Size(267, 98);
            this.logOutButton.TabIndex = 8;
            this.logOutButton.Text = "Đăng xuất";
            this.logOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // revenueButton
            // 
            this.revenueButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.revenueButton.FlatAppearance.BorderSize = 0;
            this.revenueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.revenueButton.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.revenueButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.revenueButton.Image = ((System.Drawing.Image)(resources.GetObject("revenueButton.Image")));
            this.revenueButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.revenueButton.Location = new System.Drawing.Point(0, 605);
            this.revenueButton.Name = "revenueButton";
            this.revenueButton.Padding = new System.Windows.Forms.Padding(12, 0, 25, 0);
            this.revenueButton.Size = new System.Drawing.Size(267, 80);
            this.revenueButton.TabIndex = 7;
            this.revenueButton.Text = "Doanh thu";
            this.revenueButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.revenueButton.UseVisualStyleBackColor = true;
            this.revenueButton.Click += new System.EventHandler(this.revenueButton_Click);
            // 
            // deviceButton
            // 
            this.deviceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deviceButton.FlatAppearance.BorderSize = 0;
            this.deviceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deviceButton.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deviceButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deviceButton.Image = ((System.Drawing.Image)(resources.GetObject("deviceButton.Image")));
            this.deviceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deviceButton.Location = new System.Drawing.Point(0, 525);
            this.deviceButton.Name = "deviceButton";
            this.deviceButton.Padding = new System.Windows.Forms.Padding(12, 0, 60, 0);
            this.deviceButton.Size = new System.Drawing.Size(267, 80);
            this.deviceButton.TabIndex = 6;
            this.deviceButton.Text = "Thiết bị";
            this.deviceButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deviceButton.UseVisualStyleBackColor = true;
            this.deviceButton.Click += new System.EventHandler(this.deviceButton_Click);
            // 
            // courseButton
            // 
            this.courseButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseButton.FlatAppearance.BorderSize = 0;
            this.courseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.courseButton.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.courseButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.courseButton.Image = ((System.Drawing.Image)(resources.GetObject("courseButton.Image")));
            this.courseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.courseButton.Location = new System.Drawing.Point(0, 445);
            this.courseButton.Name = "courseButton";
            this.courseButton.Padding = new System.Windows.Forms.Padding(12, 0, 40, 0);
            this.courseButton.Size = new System.Drawing.Size(267, 80);
            this.courseButton.TabIndex = 5;
            this.courseButton.Text = "Khóa học";
            this.courseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.courseButton.UseVisualStyleBackColor = true;
            this.courseButton.Click += new System.EventHandler(this.courseButton_Click);
            // 
            // productButton
            // 
            this.productButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.productButton.FlatAppearance.BorderSize = 0;
            this.productButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.productButton.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.productButton.Image = ((System.Drawing.Image)(resources.GetObject("productButton.Image")));
            this.productButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton.Location = new System.Drawing.Point(0, 365);
            this.productButton.Name = "productButton";
            this.productButton.Padding = new System.Windows.Forms.Padding(12, 0, 30, 0);
            this.productButton.Size = new System.Drawing.Size(267, 80);
            this.productButton.TabIndex = 4;
            this.productButton.Text = "Sản phẩm";
            this.productButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.productButton.UseVisualStyleBackColor = true;
            this.productButton.Click += new System.EventHandler(this.productButton_Click);
            // 
            // customerButton
            // 
            this.customerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerButton.FlatAppearance.BorderSize = 0;
            this.customerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customerButton.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.customerButton.Image = ((System.Drawing.Image)(resources.GetObject("customerButton.Image")));
            this.customerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerButton.Location = new System.Drawing.Point(0, 285);
            this.customerButton.Name = "customerButton";
            this.customerButton.Padding = new System.Windows.Forms.Padding(12, 0, 10, 0);
            this.customerButton.Size = new System.Drawing.Size(267, 80);
            this.customerButton.TabIndex = 3;
            this.customerButton.Text = "Khách hàng";
            this.customerButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // employeeButton
            // 
            this.employeeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeButton.FlatAppearance.BorderSize = 0;
            this.employeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.employeeButton.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.employeeButton.Image = ((System.Drawing.Image)(resources.GetObject("employeeButton.Image")));
            this.employeeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeeButton.Location = new System.Drawing.Point(0, 205);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Padding = new System.Windows.Forms.Padding(12, 0, 30, 0);
            this.employeeButton.Size = new System.Drawing.Size(267, 80);
            this.employeeButton.TabIndex = 2;
            this.employeeButton.Text = "Nhân viên";
            this.employeeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.employeeButton.UseVisualStyleBackColor = true;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click);
            // 
            // memberButton
            // 
            this.memberButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.memberButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.memberButton.FlatAppearance.BorderSize = 0;
            this.memberButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.memberButton.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.memberButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.memberButton.Image = ((System.Drawing.Image)(resources.GetObject("memberButton.Image")));
            this.memberButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.memberButton.Location = new System.Drawing.Point(0, 125);
            this.memberButton.Name = "memberButton";
            this.memberButton.Padding = new System.Windows.Forms.Padding(12, 0, 55, 0);
            this.memberButton.Size = new System.Drawing.Size(267, 80);
            this.memberButton.TabIndex = 1;
            this.memberButton.Text = "Hội viên";
            this.memberButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.memberButton.UseVisualStyleBackColor = true;
            this.memberButton.Click += new System.EventHandler(this.memberButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 125);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 62);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pContainer
            // 
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(0, 125);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1335, 658);
            this.pContainer.TabIndex = 2;
            // 
            // formNameLable
            // 
            this.formNameLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.formNameLable.Controls.Add(this.btnminMax);
            this.formNameLable.Controls.Add(this.button2);
            this.formNameLable.Controls.Add(this.button1);
            this.formNameLable.Controls.Add(this.formName);
            this.formNameLable.Dock = System.Windows.Forms.DockStyle.Top;
            this.formNameLable.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formNameLable.ForeColor = System.Drawing.Color.White;
            this.formNameLable.Location = new System.Drawing.Point(0, 0);
            this.formNameLable.Margin = new System.Windows.Forms.Padding(0);
            this.formNameLable.Name = "formNameLable";
            this.formNameLable.Size = new System.Drawing.Size(1335, 125);
            this.formNameLable.TabIndex = 0;
            // 
            // btnminMax
            // 
            this.btnminMax.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnminMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnminMax.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnminMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnminMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnminMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminMax.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnminMax.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnminMax.Image = ((System.Drawing.Image)(resources.GetObject("btnminMax.Image")));
            this.btnminMax.Location = new System.Drawing.Point(1216, 0);
            this.btnminMax.Name = "btnminMax";
            this.btnminMax.Size = new System.Drawing.Size(57, 47);
            this.btnminMax.TabIndex = 0;
            this.btnminMax.UseVisualStyleBackColor = false;
            this.btnminMax.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1156, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 48);
            this.button2.TabIndex = 0;
            this.button2.Text = "_";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1279, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // formName
            // 
            this.formName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formName.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.formName.Location = new System.Drawing.Point(0, 0);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(1335, 125);
            this.formName.TabIndex = 1;
            this.formName.Text = "Hội viên";
            this.formName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pContainer);
            this.panel2.Controls.Add(this.formNameLable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(267, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1335, 783);
            this.panel2.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1602, 783);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan ly phong gym";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.formNameLable.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button memberButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button revenueButton;
        private System.Windows.Forms.Button deviceButton;
        private System.Windows.Forms.Button courseButton;
        private System.Windows.Forms.Button productButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Panel formNameLable;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnminMax;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}