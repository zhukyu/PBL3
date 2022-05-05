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
    public partial class Employee : UserControl
    {
        SqlConnection conn = null;
        string str = @"Data Source=DESKTOP-S7H27N8\SQLEXPRESS;Initial Catalog=GymDatabase;Integrated Security=True";

        public Employee()
        {
            InitializeComponent();

        }
        public void hienthitoanbosanpham()
        {
            if (conn == null)
            {
                conn = new SqlConnection(str);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select *from Employee";
            comm.Connection = conn;


            SqlDataReader rar = comm.ExecuteReader();
            listView1.Items.Clear();
            while (rar.Read())
            {
                ListViewItem lvi = new ListViewItem(rar.GetString(0));
                lvi.SubItems.Add(rar.GetString(1));
                lvi.SubItems.Add(rar.GetString(2));
                lvi.SubItems.Add(rar.GetDateTime(3).ToString("dd-MM-yyyy"));
                lvi.SubItems.Add(rar.GetString(4));
                lvi.SubItems.Add(rar.GetString(5));
                lvi.SubItems.Add(rar.GetString(6));
                lvi.SubItems.Add(rar.GetString(7));
                listView1.Items.Add(lvi);

            }
            rar.Close();
        }
        private void Employee_Load(object sender, EventArgs e)
        {
            hienthitoanbosanpham();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem lvi = listView1.SelectedItems[0];
                    string maSp = lvi.SubItems[0].Text;
                    if (conn == null)
                    {
                        conn = new SqlConnection(str);
                    }
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }


                    SqlCommand comm = new SqlCommand();
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = "select *from Employee where employeeID=@maSp";
                    comm.Connection = conn;

                    SqlParameter para = new SqlParameter("@maSp", SqlDbType.NVarChar);
                    para.Value = maSp;
                    comm.Parameters.Add(para);

                    _employeeID.ReadOnly = true;
                    SqlDataReader rar = comm.ExecuteReader();
                    while (rar.Read())
                    {

                        _employeeID.Text = lvi.SubItems[0].Text;
                        _fullName.Text = lvi.SubItems[1].Text;
                        _gender.Text = lvi.SubItems[2].Text;
                        dateTimePicker1.Text = lvi.SubItems[3].Text;
                        _phoneNumber.Text = lvi.SubItems[4].Text;
                        _idNumber.Text = lvi.SubItems[5].Text;
                        _role.Text = lvi.SubItems[6].Text;
                        _address.Text = lvi.SubItems[7].Text;


                    }

                    rar.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("bạn chưa chọn dữa liệu");
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addEmployee frm = new addEmployee();
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.FormClosing += new FormClosingEventHandler(this.addEmployee_FormClosing);
            frm.ShowDialog();
        }

        private void addEmployee_FormClosing(object? sender, FormClosingEventArgs e)
        {

            hienthitoanbosanpham();

        }


        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                updateEmployee anh = new updateEmployee();

                ListViewItem lvi = listView1.SelectedItems[0];
                string maSp = lvi.SubItems[0].Text;
                if (conn == null)
                {
                    conn = new SqlConnection(str);
                }
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }


                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                comm.CommandText = "select *from Employee where employeeID=@maSp";
                comm.Connection = conn;

                SqlParameter para = new SqlParameter("@maSp", SqlDbType.NVarChar);
                para.Value = maSp;
                comm.Parameters.Add(para);

                _employeeID.ReadOnly = true;
                SqlDataReader rar = comm.ExecuteReader();
                while (rar.Read())
                {

                    anh._employeeID.Text = lvi.SubItems[0].Text;
                    anh._fullName.Text = lvi.SubItems[1].Text;
                    anh.gioitinh.Text = lvi.SubItems[2].Text;
                    anh.dateTimePicker1.Text = lvi.SubItems[3].Text;
                    anh._phoneNumber.Text = lvi.SubItems[4].Text;
                    anh._idNumber.Text = lvi.SubItems[5].Text;
                    anh.comboBox1.Text = lvi.SubItems[6].Text;
                    anh._address.Text = lvi.SubItems[7].Text;



                }

                rar.Close();
                anh.StartPosition = FormStartPosition.CenterScreen;
                anh.FormClosing += new FormClosingEventHandler(this.editEmployee_FormClosing);
                anh.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ban chua chon du lieu");
            }
        }

        private void editEmployee_FormClosing(object? sender, FormClosingEventArgs e)
        {
            hienthitoanbosanpham();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem lvi = listView1.SelectedItems[0];
                string maSp = lvi.SubItems[0].Text;
                if (conn == null)
                {
                    conn = new SqlConnection(str);
                }
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                comm.CommandText = "delete from Employee where employeeID=@maSp";
                comm.Connection = conn;
                SqlParameter para = new SqlParameter("@maSp", SqlDbType.NVarChar);
                para.Value = maSp;
                comm.Parameters.Add(para);
                int ret = comm.ExecuteNonQuery();
                if (ret > 0)
                {

                    hienthitoanbosanpham();
                    _employeeID.Text = null;
                    _fullName.Text = null;
                    _gender.Text = null;
                    dateTimePicker1.Text = null;
                    _phoneNumber.Text = null;
                    _idNumber.Text = null;
                    _role.Text = null;
                    _address.Text = null;
                    MessageBox.Show("đã xóa thành công");
                }
                else
                {
                    MessageBox.Show("đã xóa thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ban chua chon du lieu");
            }
        }





        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (conn == null)
                {
                    conn = new SqlConnection(str);
                }
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                comm.CommandText = "select *from Employee where employeeID=" + textBox2.Text;
                comm.Connection = conn;

                SqlDataReader rar = comm.ExecuteReader();
                if (rar.Read())
                {
                    _employeeID.Text = rar.GetString(0);
                    _fullName.Text = rar.GetString(1);
                    _gender.Text = rar.GetString(2);
                    dateTimePicker1.Value = rar.GetDateTime(3);
                    _phoneNumber.Text = rar.GetString(4);
                    _idNumber.Text = rar.GetString(5);
                    _role.Text = rar.GetString(6);
                    _address.Text = rar.GetString(7);
                }
                else
                {
                    MessageBox.Show("khong co du lieu");
                }    
                rar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("khong co du lieu");
            }
        }
    }







    /*private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

    }*/

    /*private void deleteButton_Click(object sender, EventArgs e)
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
*/
}
