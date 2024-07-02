using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Customer
    {
        private string _connectionString = "Server=LUCALUZZI\\SQLEXPRESS;Database=test1;Trusted_Connection=True";
        public int OrderId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }

        public Customer()
        {

        }

        public List<Customer> GetAll()
        {
            List<Customer> list = new List<Customer>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand cmd = new SqlCommand("select OrderId from Orders", connection);
                    connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Customer customer = new Customer();
                        customer.OrderId = reader.GetInt32(0);
                        list.Add(customer);
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return list;
        }

        public Customer SearchOrder(int orderId)
        {
            // Apply logic
            OrderId = orderId;

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "select CompanyName, Address from Orders ord\r\nINNER JOIN Customers co ON co.CustomerID = ord.CustomerID\r\nwhere ord.OrderId = @orderId;";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        CompanyName = reader["CompanyName"].ToString();
                        Address = reader["Address"].ToString();
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return this;
        }

        public List<Product> GetProductsByOrderId()
        {
            List<Product> list = new List<Product>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "select ProductName from [Order Details] ord\r\ninner join Products pro \r\non pro.ProductID = ord.ProductID\r\nwhere ord.OrderID = @orderId;";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@orderId", OrderId);
                    connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Product product = new Product();
                        product.ProductName = reader["ProductName"].ToString();
                        list.Add(product);
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return list;
        }
    }

    internal class Product
    {
        public string ProductName { get; set; }
    }
}
