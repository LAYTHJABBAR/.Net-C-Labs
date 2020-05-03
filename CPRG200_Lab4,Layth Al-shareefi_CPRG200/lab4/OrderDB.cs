using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public static class OrderDB
    {
        // connection to the database
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS01
; Initial Catalog = Northwind; Integrated Security = True";
            return new SqlConnection(connectionString);
        }

        // gets all Order IDs
        public static List<int> GetOrderIDs()
        {
            List<int> orderIDs = new List<int>(); // empty list of IDs
            int id; // for reading
            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT OrderID FROM Orders";
                // any exception not handled here is automatically thrown to the form
                // where the method was called
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    // close connection as soon as done with reading
                    while (reader.Read())
                    {
                        id = (int)reader["OrderID"];
                        orderIDs.Add(id);
                    }
                } // command object recycled
            } // connection object recycled
            return orderIDs;
        }

        // get member with given ID
        public static Order GetOrderByID(int orderID)
        {
            Order order = null;
            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT OrderID, CustomerID, OrderDate, RequiredDate, ShippedDate " +
                               "FROM Orders " +
                               "WHERE OrderID = @OrderID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderID);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (reader.Read()) // if order with given ID exists
                    {
                        order = new Order();
                        order.OrderID = (int)reader["OrderID"];
                        order.CustomerID = Convert.ToString(reader["CustomerID"]);
                        order.OrderDate = Convert.ToDateTime(reader["OrderDate"]);
                        order.RequiredDate = Convert.ToDateTime(reader["RequiredDate"]);

                        // for any column that can be null need to determine if it is DBNull
                        // and set accordingly
                        int col = reader.GetOrdinal("ShippedDate"); // column number of ShippedDate
                        if (reader.IsDBNull(col)) // if reader contains DBNull in this column
                            order.ShippedDate = null; // make it null in the object
                        else // it is not null
                            order.ShippedDate = Convert.ToDateTime(reader["ShippedDate"]);
                    }
                }  
            }  
            return order;
        }
        public static bool UpdateOrder(Order oldOrder, Order newOrder)
        {
            bool success = false; // no success yet

            using (SqlConnection con = GetConnection())
            {
                string updateStatement = "UPDATE Orders SET " +
                                          "  ShippedDate = @NewShippedDate " + // only Shipped Date can be updated
                                          "WHERE OrderID = @OldOrderID " + // identifies member
                                          "  AND CustomerID = @OldCustomerID " + // optimistic concurrency
                                          "  AND OrderDate = @OldOrderDate  " +
                                          "  AND RequiredDate= @OldRequiredDate " +
                                          "  AND (ShippedDate = @OldShippedDate OR " + // either equal or both are null
                                          "       ShippedDate IS NULL AND @OldShippedDate IS NULL)";
                using (SqlCommand cmd = new SqlCommand(updateStatement, con))
                {
                    // provide values for parameters
                    // for every new column (new or old)that allows null have to check if null
                    if (newOrder.ShippedDate == null)
                        cmd.Parameters.AddWithValue("@NewShippedDate", DBNull.Value);
                    else
                    cmd.Parameters.AddWithValue("@NewShippedDate", (DateTime)newOrder.ShippedDate);
                    cmd.Parameters.AddWithValue("@OldOrderID", oldOrder.OrderID);
                    cmd.Parameters.AddWithValue("@OldCustomerID", oldOrder.CustomerID);
                    cmd.Parameters.AddWithValue("@OldOrderDate", oldOrder.OrderDate);
                    cmd.Parameters.AddWithValue("@OldRequiredDate", oldOrder.RequiredDate);

                    //for every old column that allows null also have to check if null
                    if (oldOrder.ShippedDate == null)
                        cmd.Parameters.AddWithValue("@OldShippedDate", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@OldShippedDate", (DateTime)oldOrder.ShippedDate);

                    // open connection
                    con.Open();
                    // execute UPDATE command
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                        success = true;
                } // command object recycled
            } // connection closed and recycled
            return success;
        }


    }
}
