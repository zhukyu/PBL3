using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing;

namespace Gym
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();

            // change color
            this.memberButton.BackColor = Color.FromArgb(142, 124, 195);

            // change form name
            this.formName.Text = "Hội viên";

            // add form to panel
            var member = new UCMember();
            member.AutoScroll = true;
            this.pContainer.Controls.Add(member);
            member.Dock = DockStyle.Fill;
            member.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        // truyen kieu form de in ra panel
        private void showForm()
        {

        }

        private void clearForm()
        {
            //string log = "";
            foreach (Control c in this.pContainer.Controls)
            {
                //Console.WriteLine(c.GetType().Name);
                //log += c.GetType().Name;
                this.pContainer.Controls.Remove(c);
            }
            foreach (Control c in this.panelMenu.Controls)
            {
                if (c.GetType().Name == "Button")
                {
                    c.BackColor = Color.FromArgb(51, 51, 76);
                }
            }
            //MessageBox.Show(log, "asd");
        }

        private void memberButton_Click(object sender, EventArgs e)
        {

            // clear container
            clearForm();

            // change color
            this.memberButton.BackColor = Color.FromArgb(142, 124, 195);

            // change form name
            this.formName.Text = "Hội viên";

            // add form to panel
            var member = new UCMember();
            member.AutoScroll = true;
            this.pContainer.Controls.Add(member);
            member.Dock = DockStyle.Fill;
            member.Show();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            // clear container
            clearForm();

            // change color
            this.employeeButton.BackColor = Color.FromArgb(142, 124, 195);

            // change form name
            this.formName.Text = "Nhân viên";

            // add form to panel
            var employee = new UCEmployee();
            employee.AutoScroll = true;
            this.pContainer.Controls.Add(employee);
            employee.Dock = DockStyle.Fill;
            employee.Show();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            // clear container
            clearForm();

            // change color
            this.customerButton.BackColor = Color.FromArgb(142, 124, 195);

            // change form name
            this.formName.Text = "Khách hàng";

            // add form to panel
            var customer = new Customer();
            customer.AutoScroll = true;
            this.pContainer.Controls.Add(customer);
            customer.Dock = DockStyle.Fill;
            customer.Show();
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            // clear container
            clearForm();

            // change color
            this.productButton.BackColor = Color.FromArgb(142, 124, 195);

            // change form name
            this.formName.Text = "Sản phẩm";

            // add form to panel
            var product = new UCProduct();
            product.AutoScroll = true;
            this.pContainer.Controls.Add(product);
            product.Dock = DockStyle.Fill;
            product.Show();
        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            // clear container
            clearForm();

            // change color
            this.courseButton.BackColor = Color.FromArgb(142, 124, 195);

            // change form name
            this.formName.Text = "Khóa học";

            // add form to panel
            var course = new UCCourse();
            course.AutoScroll = true;
            this.pContainer.Controls.Add(course);
            course.Dock = DockStyle.Fill;
            course.Show();
        }

        private void deviceButton_Click(object sender, EventArgs e)
        {
            // clear container
            clearForm();

            // change color
            this.deviceButton.BackColor = Color.FromArgb(142, 124, 195);

            // change form name
            this.formName.Text = "Thiết bị";

            // add form to panel
            var device = new UCDevice();
            device.AutoScroll = true;
            this.pContainer.Controls.Add(device);
            device.Dock = DockStyle.Fill;
            device.Show();
        }

        private void revenueButton_Click(object sender, EventArgs e)
        {
            // clear container
            clearForm();

            // change color
            this.revenueButton.BackColor = Color.FromArgb(142, 124, 195);

            // change form name
            this.formName.Text = "Doanh thu";

            // add form to panel
            var revenue = new UCRevenue();
            revenue.AutoScroll = true;
            this.pContainer.Controls.Add(revenue);
            revenue.Dock = DockStyle.Fill;
            revenue.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                button3.Text = "><";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                button3.Text = "<>";
            }
        }

        
    }
}
