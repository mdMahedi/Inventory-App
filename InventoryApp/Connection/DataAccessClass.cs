using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InventoryApp.Connection
{
    public class DataAccessClass
    {
        public bool InsertIntoProduct(string name, decimal price, int quantity)
        {
            SqlConnection connection = ConnectionClass.InventoryDBConnection();
            string query = "Insert Into Product Values('"+name+"','"+price+"','"+quantity+"')";
            SqlCommand command=new SqlCommand(query,connection);
            if (command.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EditProduct(string name, decimal price, int quantity)
        {
            SqlConnection connection = ConnectionClass.InventoryDBConnection();
            string query = "Update Product set Name='"+name+"',UnitPrice='"+price+"',Quantity+='"+quantity+"'";
            SqlCommand command=new SqlCommand(query,connection);
            if (command.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable GetAllProduct()
        {
            SqlConnection connection = ConnectionClass.InventoryDBConnection();
            string query = "Select * From Product";
            SqlDataAdapter adapter=new SqlDataAdapter(query,connection);
            DataTable data=new DataTable();
            adapter.Fill(data);
            return data;
        }
        public bool DeleteFromProduct(string name)
        {
            SqlConnection connection = ConnectionClass.InventoryDBConnection();
            string query = "Delete from Product where Name='"+name+"'";
            SqlCommand command=new SqlCommand(query,connection);
            if (command.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsProductExist(string name)
        {
            string product = "";
            SqlConnection connection = ConnectionClass.InventoryDBConnection();
            string query = "Select Name from Product Where Name='"+name+"'";
            SqlCommand command=new SqlCommand(query,connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                product = reader["Name"].ToString();
            }
            if (name==product)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}