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
    internal class ProductReceiptDAL
    {
        public static List<ProductReceipt> GetAllProductReceipts()
        {
            List<ProductReceipt> productReceipts = new List<ProductReceipt>();
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from ProductReceipt";
                cmd.Connection = conn;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ProductReceipt productReceipt = new ProductReceipt
                    (
                        rd.GetString(0),
                        rd.GetString(1),
                        rd.GetDateTime(2),
                        rd.GetInt32(3)
                    );
                    productReceipts.Add(productReceipt);
                }
                rd.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return productReceipts;
        }
        public static bool InsertProductReceipt(ProductReceipt productReceipt)
        {
            bool result = false;
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                string st = "insert into ProductReceipt (receiptID, employeeID, publishDate, total)" +
                        $"values ('{productReceipt._receiptID}', '{productReceipt._employeeID}', " +
                        $"'{productReceipt._publishDate.ToString("yyyyMMdd")}', {productReceipt._total})";
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
        public static ProductReceipt SearchProductReceipt(string ID)
        {
            ProductReceipt productRcpt = null;
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"select * from ProductReceipt where receiptID = {ID}";
                cmd.Connection = conn;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    productRcpt = new ProductReceipt
                    (
                        rd.GetString(0),
                        rd.GetString(1),
                        rd.GetDateTime(2),
                        rd.GetInt32(3)
                    );
                }
                rd.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return productRcpt;
        }
        public static string GetLastID()
        {
            string lastID = null;
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT TOP 1 receiptID FROM ProductReceipt ORDER BY receiptID DESC";
                cmd.Connection = conn;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    lastID = rd.GetString(0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lastID;
        }
    }
}
