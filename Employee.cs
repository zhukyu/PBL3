using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gym
{
    public partial class Employee : Form
    {
        SqlConnection conn;
        SqlCommand cm;
        string str = @"Data Source=DESKTOP-S7H27N8\SQLEXPRESS;Initial Catalog=GymDatabase;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            cm = conn.CreateCommand();
            cm.CommandText = "Select *from Employee";
            adapter.SelectCommand = cm;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }
        public Employee()
        {
            InitializeComponent();
            conn = new SqlConnection(str);
            conn.Open();
            loaddata();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        //    //Form frm = new addEmployee();
        //    //frm.Show();
        //    //this.Hide();
        //}

       

        private void delete_Click(object sender, EventArgs e)
        {
            
        }

        private void employeeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _employeeID.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            _employeeID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            _fullName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            _gender.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox1.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            _phoneNumber.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            _idNumber.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            _role.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            _address.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            cm = conn.CreateCommand();
            cm.CommandText = "delete from Employee where employeeID = '" + _employeeID.Text + "'";
            cm.ExecuteNonQuery();
            loaddata();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            cm = conn.CreateCommand();
            cm.CommandText = "insert into Employee values('" + _employeeID.Text + "','" + _fullName.Text + "','" + _gender.Text + "','" + textBox1.Text + "','" + _phoneNumber.Text + "','" + _idNumber.Text + "','" + _role.Text + "','" + _address.Text + "')";
            cm.ExecuteNonQuery();
            loaddata();
        }
        private void edit_Click(object sender, EventArgs e)
        {
            //Form frm = new updateEmployee();
            //frm.Show();
            cm = conn.CreateCommand();
            cm.CommandText = "update Employee set  fullName ='"+ _fullName.Text + "',gender='" + _gender.Text + "',birthday='" + textBox1.Text + "',phoneNumber='" + _phoneNumber.Text + "',idNumber='" + _idNumber.Text + "',role='" + _role.Text + "',address='"+_address+ "' where employeeID = '" + _employeeID.Text + "'";
            cm.ExecuteNonQuery();
            loaddata();
        }
    }
}
