using Gym.BLL;
using Gym.DTO;
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
        List<Member> members = new List<Member>();
        public UCMember()
        {
            InitializeComponent();
        }
        private void MemberTableLoad()
        {
            memberTable.Rows.Clear();
            foreach (Member member in members)
            {
                memberTable.Rows.Add(
                    member._customerID,
                    member._fullName,
                    member._idNumber,
                    member._phoneNumber,
                    member._courseName,
                    member._registerDate.ToString("dd/MM/yyyy"),
                    member._expiredDate.ToString("dd/MM/yyyy")
                );
            }
            //hiển thị member info
            if (members.Count > 0)
                MemberInfo(members[0]);
        }
        private void Member_Load(object sender, EventArgs e)
        {
            
            try
            {
                members = MemberBLL.GetAllMembers();
                MemberTableLoad();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void MemberInfo(Member member)
        {
            if (member == null)
                return;
            _customerID.Text = member._customerID;
            _fullName.Text = member._fullName;
            _gender.Text = member._gender;
            _birthday.Text = member._birthday.ToString("dd/MM/yyyy");
            _phoneNumber.Text = member._phoneNumber;
            _idNumber.Text = member._idNumber;
            _address.Text = member._address;
        }
        private void memberTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (memberTable.Rows.Count == 0)
                    return;
                string memberID = memberTable.CurrentRow.Cells[0].Value.ToString();
                Member member = members.Find(x => x._customerID == memberID);
                MemberInfo(member);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                members = MemberBLL.SearchMember(search.Text);
                MemberTableLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
