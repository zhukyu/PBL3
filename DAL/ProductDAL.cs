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
    internal class ProductDAL
    {
        public static List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Product";
                cmd.Connection = conn;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Product product = new Product
                    (
                        rd.GetString(0),
                        rd.GetString(1),
                        rd.GetInt32(2),
                        rd.GetInt32(3),
                        rd.GetString(4)
                    );
                    products.Add(product);
                }
                rd.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return products;
        }
        public static List<Product> SearchProduct(string str)
        {
            List<Product> products = new List<Product>();
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Product where productName LIKE N'%" + str + "%' OR productID = '" + str + "' "; ;
                cmd.Connection = conn;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    Product product = new Product
                    (
                        rd.GetString(0),
                        rd.GetString(1),
                        rd.GetInt32(2),
                        rd.GetInt32(3),
                        rd.GetString(4)
                    );
                    products.Add(product);
                }
                rd.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return products;
        }
        public static bool InsertProduct(Product product)
        {
            bool result = false;
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                string st = "Insert into product(productID,productName,amount,price,image)" + 
                    "values (N'" + product._productID + "',N'" + product._productName + "','" +
                    product._amount + "','" + product._price + "','" + product._image + "')";
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
        public static bool UpdateProduct(Product product)
        {
            bool result = false;
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                string st = "update product set  productName=N'" + product._productName + "',amount=N'" +
                    product._amount + "',price='" + product._price + "',image=N'" + product._image + "' " 
                    + "where productID = '" + product._productID + "'";
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
        public static bool DeleteProduct(string ID)
        {
            bool result = false;
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                string st = "delete from Product where productID = '" + ID + "'";
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
