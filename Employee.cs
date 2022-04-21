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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {

            Form frm = new addEmployee();
            frm.Show();
            //this.Hide();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            Form frm = new updateEmployee();
            frm.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void employeeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
