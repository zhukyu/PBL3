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
    public partial class FormProductSale : Form
    {
        List<string> productIDs = new List<string>();
        List<string> productNames = new List<string>();
        List<int> remains = new List<int>();
        List<int> prices = new List<int>();
        List<int> addedIndexs = new List<int>(); // addedIndexs[2] = 3: sp thứ 2 trong list là sp thứ 3 trong combobox
        public FormProductSale()
        {
            InitializeComponent();
        }
        private string GenerateID(SqlConnection conn)
        {
            int count = 1;
            StringBuilder ID = new StringBuilder("PR0000");
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 receiptID FROM ProductReceipt ORDER BY receiptID DESC", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                count = Convert.ToInt32(rd.GetString(0).Substring(2)); //lấy số thứ tự
                count++;
            }
            string countStr = count.ToString();
            ID.Remove(ID.Length - countStr.Length, countStr.Length); // PR0000 - 12 = CR00
            ID.Append(countStr);
            rd.Close();
            return ID.ToString();
        }
        private void productSale_Load(object sender, EventArgs e)
        {
            _publishDate.Value = DateTime.Today;
            SqlConnection conn = new SqlConnection(Program.cnstr);
            try
            {
                conn.Open();
                _saleID.Text = GenerateID(conn);
                _cashier.Text = Program.userName;
                SqlCommand cmd = new SqlCommand("select * from product", conn);
                SqlDataReader data = (SqlDataReader)cmd.ExecuteReader();
                while (data.Read())
                {
                    string productID = data.GetString(0);
                    string productName = data.GetString(1);
                    int remain = data.GetInt32(2);
                    int price = data.GetInt32(3);
                    productCb.Items.Add(productName);
                    productIDs.Add(productID);
                    productNames.Add(productName);
                    remains.Add(remain);
                    prices.Add(price);
                }
                data.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TotalSum()
        {
            int sum = 0;
            for (int i = 0; i < productList.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(productList.Rows[i].Cells[4].Value);
            }
            _total.Text = sum.ToString();
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int CbIndex = productCb.SelectedIndex;
                if(CbIndex == -1) // chưa chọn sản phẩm
                {
                    throw new Exception("Bạn chưa chọn sản phẩm");
                }
                int amount = Convert.ToInt32(amountInput.Text);
                if(amount < 1)
                {
                    throw new FormatException();
                }
                int total = amount * prices[CbIndex];
                int addedIndex = addedIndexs.IndexOf(CbIndex);
                if(addedIndex != -1) // kiểm tra xem sản phẩm đã được thêm chưa
                {
                    DialogResult dlr = MessageBox.Show("Sản phẩm đã tồn tại, thêm số lượng ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        int oldAmount = Convert.ToInt32(productList.Rows[addedIndex].Cells[2].Value);
                        int newAmount = oldAmount + Convert.ToInt32(amountInput.Text);
                        total = newAmount * prices[CbIndex];
                        productList.Rows[addedIndex].Cells[2].Value = newAmount; // cộng thêm số lượng
                        productList.Rows[addedIndex].Cells[4].Value = total;
                    }
                }
                else // nếu không thì thêm mới sản phẩm
                {
                    DialogResult dlr = MessageBox.Show("Bạn có muốn thêm sản phẩm ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        productList.Rows.Add(
                            productIDs[CbIndex],
                            productNames[CbIndex],
                            amount.ToString(),
                            prices[CbIndex],
                            total
                        );
                        addedIndexs.Add(CbIndex);
                    }
                }
                TotalSum();
            }
            catch(FormatException)
            {
                MessageBox.Show("Định dạng số lượng phải là số nguyên dương", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    
            }
        }

        private void productList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productCb.Text = productList.CurrentRow.Cells[1].Value.ToString();
            amountInput.Text = productList.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int index = productList.SelectedRows[0].Index; // số chỉ của datagridview
                int CbIndex = productCb.SelectedIndex; // số chỉ ComboBox
                if (CbIndex == -1) // chưa chọn sản phẩm
                {
                    throw new Exception("Bạn chưa chọn sản phẩm");
                }
                int amount = Convert.ToInt32(amountInput.Text);
                if (amount < 1)
                {
                    throw new FormatException();
                }
                int total = amount * prices[CbIndex];
                DialogResult dlr = MessageBox.Show("Bạn có muốn chỉnh sửa mục đã chọn ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    productList.Rows[index].SetValues(
                            productIDs[CbIndex],
                            productNames[CbIndex],
                            amount.ToString(),
                            prices[CbIndex],
                            total
                        );
                    addedIndexs[index] = CbIndex;

                    // kiểm tra xem sản phẩm đã tồn tại hay chưa
                    int firstAddedIndex = addedIndexs.IndexOf(CbIndex);
                    int lastAddedIndex = addedIndexs.LastIndexOf(CbIndex);
                    int replaceIndex = -1; // vị trí cập nhật dữ liệu
                    if (firstAddedIndex != -1 && firstAddedIndex != index) // tìm thấy addedIndex, 
                    {
                        replaceIndex = firstAddedIndex;
                    }
                    else if (lastAddedIndex != -1 && lastAddedIndex != index)
                    {
                        replaceIndex = lastAddedIndex;
                    }
                    else
                    {
                        TotalSum();
                        return;
                    }
                    int oldAmount = Convert.ToInt32(productList.Rows[replaceIndex].Cells[2].Value);
                    int newAmount = oldAmount + Convert.ToInt32(amountInput.Text);
                    total = newAmount * prices[CbIndex];
                    productList.Rows[replaceIndex].Cells[2].Value = newAmount; // cộng thêm số lượng
                    productList.Rows[replaceIndex].Cells[4].Value = total;
                    productList.Rows.RemoveAt(index);
                    addedIndexs.RemoveAt(index);
                    TotalSum();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int index = productList.SelectedRows[0].Index; // số chỉ của datagridview
                DialogResult dlr = MessageBox.Show("Bạn có muốn xóa mục đã chọn ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    productList.Rows.RemoveAt(index);
                    addedIndexs.RemoveAt(index);
                    TotalSum();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_total.Text == "0")
                    throw new Exception("Bạn chưa chọn sản phẩm");
                DialogResult dlr = MessageBox.Show("Xác nhận thanh toán ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(Program.cnstr);

                    conn.Open();
                    string receiptID = _saleID.Text;
                    string employeeID = Program.userID;
                    string publishDate = _publishDate.Value.ToString("yyyyMMdd");
                    int total = Convert.ToInt32(_total.Text);
                    SqlCommand cmd = new SqlCommand("insert into ProductReceipt (receiptID, employeeID, publishDate, total)" +
                        $"values ('{receiptID}', '{employeeID}', '{publishDate}', {total})", conn);
                    cmd.ExecuteNonQuery();

                    // build string Values
                    string values = "";
                    int i;
                    for (i = 0; i < productList.Rows.Count; ++i)
                    {
                        int index = productList.Rows[i].Index; // số chỉ sản phẩm trong list
                        int CbIndex = addedIndexs[index];
                        string productID = productIDs[CbIndex];
                        int unitPrice = prices[CbIndex];
                        int amount = Convert.ToInt32(productList.Rows[i].Cells[2].Value);
                        int unitTotal = Convert.ToInt32(productList.Rows[i].Cells[4].Value);
                        values += $"('{receiptID}', '{productID}', '{amount}', '{unitPrice}', '{unitTotal}')";
                        if (i != productList.Rows.Count - 1)
                        {
                            values += ", ";
                        }
                        else
                        {
                            values += "; ";
                        }
                    }
                    cmd = new SqlCommand("insert into ProductReceipt_Detail (receiptID, productID, amount, unitPrice, unitTotal)" +
                        $"values {values}", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void ChangeUpdate()
        {
            try
            {
                if (_received.Text == "")
                {
                    _change.Text = "0";
                    return;
                }
                int received = Convert.ToInt32(_received.Text);
                if (received < 0)
                    throw new FormatException();
                int change = received - Convert.ToInt32(_total.Text);
                _change.Text = change.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Định dạng tiền nhận phải là số nguyên dương", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void _received_TextChanged(object sender, EventArgs e)
        {
            ChangeUpdate();
        }

        private void _total_TextChanged(object sender, EventArgs e)
        {
            ChangeUpdate();
        }
    }
}
