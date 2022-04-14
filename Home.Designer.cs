using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace GUI
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
            this.panelMenu.SuspendLayout();
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
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(267, 833);
            this.panelMenu.TabIndex = 1;
            // 
            // logOutButton
            // 
            this.logOutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logOutButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.logOutButton.Image = ((System.Drawing.Image)(resources.GetObject("logOutButton.Image")));
            this.logOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.Location = new System.Drawing.Point(0, 744);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Padding = new System.Windows.Forms.Padding(12, 0, 25, 0);
            this.logOutButton.Size = new System.Drawing.Size(267, 80);
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
            this.revenueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.revenueButton.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.revenueButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.revenueButton.Image = ((System.Drawing.Image)(resources.GetObject("revenueButton.Image")));
            this.revenueButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.revenueButton.Location = new System.Drawing.Point(0, 664);
            this.revenueButton.Name = "revenueButton";
            this.revenueButton.Padding = new System.Windows.Forms.Padding(12, 0, 25, 0);
            this.revenueButton.Size = new System.Drawing.Size(267, 80);
            this.revenueButton.TabIndex = 7;
            this.revenueButton.Text = "Doanh thu";
            this.revenueButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.revenueButton.UseVisualStyleBackColor = true;
            // 
            // deviceButton
            // 
            this.deviceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deviceButton.FlatAppearance.BorderSize = 0;
            this.deviceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deviceButton.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deviceButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deviceButton.Image = ((System.Drawing.Image)(resources.GetObject("deviceButton.Image")));
            this.deviceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deviceButton.Location = new System.Drawing.Point(0, 584);
            this.deviceButton.Name = "deviceButton";
            this.deviceButton.Padding = new System.Windows.Forms.Padding(12, 0, 60, 0);
            this.deviceButton.Size = new System.Drawing.Size(267, 80);
            this.deviceButton.TabIndex = 6;
            this.deviceButton.Text = "Thiết bị";
            this.deviceButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deviceButton.UseVisualStyleBackColor = true;
            // 
            // courseButton
            // 
            this.courseButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseButton.FlatAppearance.BorderSize = 0;
            this.courseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courseButton.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.courseButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.courseButton.Image = ((System.Drawing.Image)(resources.GetObject("courseButton.Image")));
            this.courseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.courseButton.Location = new System.Drawing.Point(0, 504);
            this.courseButton.Name = "courseButton";
            this.courseButton.Padding = new System.Windows.Forms.Padding(12, 0, 40, 0);
            this.courseButton.Size = new System.Drawing.Size(267, 80);
            this.courseButton.TabIndex = 5;
            this.courseButton.Text = "Khóa học";
            this.courseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.courseButton.UseVisualStyleBackColor = true;
            // 
            // productButton
            // 
            this.productButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.productButton.FlatAppearance.BorderSize = 0;
            this.productButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productButton.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.productButton.Image = ((System.Drawing.Image)(resources.GetObject("productButton.Image")));
            this.productButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton.Location = new System.Drawing.Point(0, 424);
            this.productButton.Name = "productButton";
            this.productButton.Padding = new System.Windows.Forms.Padding(12, 0, 30, 0);
            this.productButton.Size = new System.Drawing.Size(267, 80);
            this.productButton.TabIndex = 4;
            this.productButton.Text = "Sản phẩm";
            this.productButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.productButton.UseVisualStyleBackColor = true;
            // 
            // customerButton
            // 
            this.customerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerButton.FlatAppearance.BorderSize = 0;
            this.customerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerButton.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.customerButton.Image = ((System.Drawing.Image)(resources.GetObject("customerButton.Image")));
            this.customerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerButton.Location = new System.Drawing.Point(0, 344);
            this.customerButton.Name = "customerButton";
            this.customerButton.Padding = new System.Windows.Forms.Padding(12, 0, 10, 0);
            this.customerButton.Size = new System.Drawing.Size(267, 80);
            this.customerButton.TabIndex = 3;
            this.customerButton.Text = "Khách hàng";
            this.customerButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customerButton.UseVisualStyleBackColor = true;
            // 
            // employeeButton
            // 
            this.employeeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeButton.FlatAppearance.BorderSize = 0;
            this.employeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeButton.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.employeeButton.Image = ((System.Drawing.Image)(resources.GetObject("employeeButton.Image")));
            this.employeeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeeButton.Location = new System.Drawing.Point(0, 264);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Padding = new System.Windows.Forms.Padding(12, 0, 30, 0);
            this.employeeButton.Size = new System.Drawing.Size(267, 80);
            this.employeeButton.TabIndex = 2;
            this.employeeButton.Text = "Nhân viên";
            this.employeeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.employeeButton.UseVisualStyleBackColor = true;
            // 
            // memberButton
            // 
            this.memberButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.memberButton.FlatAppearance.BorderSize = 0;
            this.memberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memberButton.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.memberButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.memberButton.Image = ((System.Drawing.Image)(resources.GetObject("memberButton.Image")));
            this.memberButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.memberButton.Location = new System.Drawing.Point(0, 184);
            this.memberButton.Name = "memberButton";
            this.memberButton.Padding = new System.Windows.Forms.Padding(12, 0, 55, 0);
            this.memberButton.Size = new System.Drawing.Size(267, 80);
            this.memberButton.TabIndex = 1;
            this.memberButton.Text = "Hội viên";
            this.memberButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.memberButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 184);
            this.panel1.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1702, 833);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan ly phong gym";
            this.panelMenu.ResumeLayout(false);
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
    }
}