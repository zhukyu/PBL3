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
using System.IO;

namespace Gym
{
    public partial class UCEmployee : UserControl
    {
        SqlConnection conn = null;

        string maSp=null;
        
        public UCEmployee()
        {
            InitializeComponent();

        }
      
        
        public void hienthitoanbosanpham()
        {
            if (conn == null)
            {
                conn = new SqlConnection(Program.cnstr);
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



        private void addButton_Click(object sender, EventArgs e)
        {
            FormAddEmployee frm = new FormAddEmployee();
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
                FormUpdateEmployee anh = new FormUpdateEmployee();

                ListViewItem lvi = listView1.SelectedItems[0];


                anh._employeeID.Text = lvi.SubItems[0].Text;
                anh._fullName.Text = lvi.SubItems[1].Text;
                anh.gioitinh.Text = lvi.SubItems[2].Text;
                anh.dateTimePicker1.Text = lvi.SubItems[3].Text;
                anh._phoneNumber.Text = lvi.SubItems[4].Text;
                anh._idNumber.Text = lvi.SubItems[5].Text;
                anh.comboBox1.Text = lvi.SubItems[6].Text;
                anh._address.Text = lvi.SubItems[7].Text;
                anh.pictureBox1.Image = pictureBox1.Image;



                anh.StartPosition = FormStartPosition.CenterScreen;
                anh.FormClosing += new FormClosingEventHandler(this.editEmployee_FormClosing);
                anh.ShowDialog();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void editEmployee_FormClosing(object? sender, FormClosingEventArgs e)
        {
           
            hienthitoanbosanpham();
            
            if (conn == null)
            {
                conn = new SqlConnection(Program.cnstr);
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


            SqlDataReader rar = comm.ExecuteReader();
            while (rar.Read())
            {
                _employeeID.Text = rar.GetString(0);
                _fullName.Text = rar.GetString(1);
                _gender.Text = rar.GetString(2);
                dateTimePicker1.Text = rar.GetDateTime(3).ToString("dd-MM-yyyy");
                _phoneNumber.Text = rar.GetString(4);
                _idNumber.Text = rar.GetString(5);
                _role.Text = rar.GetString(6);
                _address.Text = rar.GetString(7);
                if (rar.GetString(8) == "")
                {
                    pictureBox1.Image = Properties.Resources.icons8_person_128px;
                }
                else
                {
                    pictureBox1.Image = Program.ByteToImg(rar.GetString(8));
                }

            }
            rar.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            {

                try
                {
                    ListViewItem lvi = listView1.SelectedItems[0];
                    string maSp = lvi.SubItems[0].Text;
                    if (conn == null)
                    {
                        conn = new SqlConnection(Program.cnstr);
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
                        DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dlr == DialogResult.Yes)
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
                            pictureBox1.Image = null;
                            MessageBox.Show("Đã xóa thành công");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã xóa thất bại");

                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show("Bạn chưa chọn dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null)
                {
                    conn = new SqlConnection(Program.cnstr);
                }
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                comm.CommandText = "select *from Employee where EmployeeID   = '" + textBox2.Text + "' OR fullname = N'" + textBox2.Text + "' OR idNumber = '" + textBox2.Text + "' OR fullName LIKE N'%" + textBox2.Text + "%'";
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
                if (listView1.Items.Count <= 0)
                {
                    MessageBox.Show("không có dữ liệu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có dữ liệu");
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem lvi = listView1.SelectedItems[0];
                     maSp = lvi.SubItems[0].Text;
                    if (conn == null)
                    {
                        conn = new SqlConnection(Program.cnstr);
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
                        if (rar.GetString(8) == "")
                        {
                            pictureBox1.Image = Properties.Resources.icons8_person_128px;
                        }
                        else
                        {
                            pictureBox1.Image = Program.ByteToImg(rar.GetString(8));
                        }


                    }


                    rar.Close();
                }

            }

            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "ID,TÊN,CMND")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "ID,TÊN,CMND";
                textBox2.ForeColor = Color.Gray;
                hienthitoanbosanpham();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            hienthitoanbosanpham();
            textBox2.Text = "ID,TÊN,CMND";
            textBox2.ForeColor = Color.Gray;
            _employeeID.Text = null;
            _fullName.Text = null;
            _gender.Text = null;
            dateTimePicker1.Text = null;
            _phoneNumber.Text = null;
            _idNumber.Text = null;
            _role.Text = null;
            _address.Text = null;
            pictureBox1.Image = null;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (conn == null)
            {
                conn = new SqlConnection(Program.cnstr);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select *from Employee where EmployeeID   = '" + textBox2.Text + "' OR fullname = N'" + textBox2.Text + "' OR idNumber = '" + textBox2.Text + "' OR fullName LIKE N'%" + textBox2.Text + "%'";

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

