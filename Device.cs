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
    public partial class Device : Form
    {
        public Device()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form frm = new addDevice();
            frm.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Form frm = new updateDevice();
            frm.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
