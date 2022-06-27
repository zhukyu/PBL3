using Gym.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.DAL
{
    internal class ProductReceipt_DetailDAL
    {
        public static List<ProductReceipt_Detail> GetAllProductReceiptItems(string receiptID)
        {
            List<ProductReceipt_Detail> productReceiptItems = new List<ProductReceipt_Detail>();
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"select * from Product where receiptID = '{receiptID}'";
                cmd.Connection = conn;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ProductReceipt_Detail productReceiptItem = new ProductReceipt_Detail
                    (
                        rd.GetString(0),
                        rd.GetString(1),
                        rd.GetInt32(2),
                        rd.GetInt32(3),
                        rd.GetInt32(4)
                    );
                    productReceiptItems.Add(productReceiptItem);
                }
                rd.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return productReceiptItems;
        }
        public static bool InsertProductReceiptItem(ProductReceipt_Detail Item)
        {
            bool result = false;
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                string st = "insert into ProductReceipt_Detail(receiptID, productID, amount, unitPrice, unitTotal) " +
                        $"values ('{Item._receiptID}', '{Item._productID}', '{Item._amount}', '{Item._unitPrice}', '{Item._unitTotal}')";
                comm.CommandText = st;
                comm.Connection = conn;

                int ret = comm.ExecuteNonQuery();
                if (ret == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;

        }
    }
}
