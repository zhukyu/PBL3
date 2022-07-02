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
        List<Employee> teachers = new List<Employee>();
        public UCMember()
        {
            InitializeComponent();
        }
        private void FilterInit()
        {
            TeacherNameCB.Items.Clear();
            TeacherNameCB.Items.AddRange(new string[] { "Huấn luyện viên", "Tự tập" });
            TeacherNameCB.SelectedIndex = 0;
            SortByCB.SelectedIndex = 0;
            DirectionCB.SelectedIndex = 0;
            foreach(Employee teacher in teachers)
            {
                TeacherNameCB.Items.Add(teacher._fullName);
            }

        }
        private void MemberTableLoad(List<Member> members)
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
                teachers = EmployeeBLL.GetAllPTs();
                MemberTableLoad(this.members);
                FilterInit();
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
                MemberTableLoad(members);
                FilterInit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // trả về true nếu a <= b với direction = 0
        private bool Compare(Member mb1, Member mb2, int sortBy, int direction)
        {
            // Mã học viên
            if (sortBy == 0)
            {
                int result = mb1._customerID.CompareTo(mb2._customerID);
                if (direction == 0) // tăng dần
                {
                    return result < 0;
                }
                else // giảm dần
                {
                    return result > 0;
                }
            }
            // Họ tên
            else if (sortBy == 1)
            {
                int result = mb1._fullName.CompareTo(mb2._fullName);
                if (direction == 0) // tăng dần
                {
                    return result < 0;
                }
                else // giảm dần
                {
                    return result > 0;
                }
            }
            
            // Tên khóa học
            else
            {
                int result = mb1._courseName.CompareTo(mb2._courseName);
                if (direction == 0) // tăng dần
                {
                    return result < 0;
                }
                else // giảm dần
                {
                    return result > 0;
                }
            }
        }
        private void Sort(List<Member> members, int sortBy, int direction)
        {
            for(int i = 0; i < members.Count - 1; i++)
            {
                int x = i;
                for(int j = i + 1; j < members.Count; j++)
                {
                    if (Compare(members[j], members[x], sortBy, direction))
                        x = j;
                }
                Member temp = members[x];
                members[x] = members[i];
                members[i] = temp;
            }
        }
        private void FilterButton_Click(object sender, EventArgs e)
        {
            List<Member> temp = new List<Member>();
            int index = TeacherNameCB.SelectedIndex;
            if (index == 0)
                temp = members;
            if(index == 1)
                temp = members.FindAll(x => x._teacherID == null);
            else if(index > 1)
            {
                int teacherIndex = index - 2;
                temp = members.FindAll(x => x._teacherID == teachers[teacherIndex]._employeeID);
            }
            Sort(temp, SortByCB.SelectedIndex, DirectionCB.SelectedIndex);
            MemberTableLoad(temp);
        }
    }
}
