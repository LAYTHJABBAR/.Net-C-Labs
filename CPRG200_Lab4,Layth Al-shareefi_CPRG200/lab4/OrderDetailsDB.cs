using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class OrderDetailsDB
    {

        // connection to the database
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS01; Initial Catalog = Northwind; Integrated Security = True";
            return new SqlConnection(connectionString);
        }

        // get order details data

        public static List<OrderDetails> GetOrderDetails(int orderID)
        {
            List<OrderDetails> orderDetails = new List<OrderDetails>(); //empty list
            OrderDetails det;
            using(SqlConnection con = GetConnection())
            {
                string query = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount " +
                               "FROM [Order Details] " +
                               "Where OrderID = @OrderID";
                using(SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderID);
                    con.Open();
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())  // while there is a data
                        {
                            det = new OrderDetails();   // create new orderDetails object

                            det.OrderID = (int)reader["OrderID"];
                            det.ProductID = (int)reader["ProductID"];
                            det.UnitPrice = (decimal)reader["UnitPrice"];
                            det.Quantity = (short)reader["Quantity"];
                            det.Discount = (float)reader["Discount"];
                            decimal reset = 1 - Convert.ToDecimal(det.Discount);
                            det.OrderTotal = (float)(det.UnitPrice * (reset) * det.Quantity);
                            orderDetails.Add(det); /// add it to the list

                        }
                    }
                }
            }


            return orderDetails;
        }
    }
}
