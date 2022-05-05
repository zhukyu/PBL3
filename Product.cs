using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void saleButton_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form frm = new addProduct();
            frm.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Form frm = new updateProduct();
            frm.Show();
        }

        private void saleButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
