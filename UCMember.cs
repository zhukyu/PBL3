using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class UCMember : UserControl
    {
        public UCMember()
        {
            InitializeComponent();
        }

        private void Member_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.cnstr);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetMember", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataReader rd = cmd.ExecuteReader();
                while(rd.Read())
                {
                    memberTable.Rows.Add(
                        rd.GetString(0), 
                        rd.GetString(1), 
                        rd.GetString(2), 
                        rd.GetString(3), 
                        rd.GetString(4), 
                        rd.GetDateTime(5).ToString("dd-MM-yyyy"),
                        rd.GetDateTime(6).ToString("dd-MM-yyyy")
                    );
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void memberTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string customerID = memberTable.CurrentRow.Cells[0].Value.ToString();
            SqlConnection conn = new SqlConnection(Program.cnstr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"select * from Customer where customerID = '{customerID}'", conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    _customerID.Text = rd.GetString(0);
                    _fullName.Text = rd.GetString(1);
                    _gender.Text = rd.GetString(2);
                    _birthday.Text = rd.GetDateTime(3).ToString("dd-MM-yyyy");
                    _phoneNumber.Text = rd.GetString(4);
                    _address.Text = rd.GetString(5);
                    _idNumber.Text = rd.GetString(6);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
