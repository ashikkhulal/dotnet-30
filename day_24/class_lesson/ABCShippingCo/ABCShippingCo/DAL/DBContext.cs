using ABCShippingCo.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using ABCShippingCo.Models;

namespace ABCShippingCo.DAL
{
    public class DBContext
    {
        public void openConnection()
        {
            string connectionString = "Data Source=G7-LAPTOP\\SQLEXPRESS;Initial Catalog=MyLocalDb;Integrated Security=True";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM ABC_Shipping_Co", sqlConnection);
                sqlConnection.Open();
                // SqlDataReader: (Class) Provides a way of reading a forward-only stream of rows from a SQL Server database
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID");
                dataTable.Columns.Add("FullName");
                dataTable.Columns.Add("Phone");
                dataTable.Columns.Add("Email");
                dataTable.Columns.Add("Address");
                dataTable.Columns.Add("AptOrSuite");
                dataTable.Columns.Add("PostalZip");
                dataTable.Columns.Add("Country");
                
                while (sqlDataReader.Read())
                {
                    DataRow dataRow = dataTable.NewRow();

                    dataRow["Id"] = sqlDataReader["Id"];
                    dataRow["FullName"] = sqlDataReader["FullName"];
                    dataRow["Phone"] = sqlDataReader["Phone"];
                    dataRow["Email"] = sqlDataReader["Email"];
                    dataRow["Address"] = sqlDataReader["Address"];
                    dataRow["AptOrSuite"] = sqlDataReader["AptOrSuite"];
                    dataRow["PostalZip"] = sqlDataReader["PostalZip"];
                    dataRow["Country"] = sqlDataReader["Country"];
                    
                    dataTable.Rows.Add(dataRow);

                }
                sqlConnection.Close(); // need to close already existing connection before starting a new one
            }

        }

        public DataTable getTableData()
        {
            string connectionString = "Data Source=G7-LAPTOP\\SQLEXPRESS;Initial Catalog=MyLocalDb;Integrated Security=True";
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM ABC_Shipping_Co", sqlConnection);
                sqlConnection.Open();
                // SqlDataReader: (Class) Provides a way of reading a forward-only stream of rows from a SQL Server database
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                dataTable.Columns.Add("ID");
                dataTable.Columns.Add("FullName");
                dataTable.Columns.Add("Phone");
                dataTable.Columns.Add("Email");
                dataTable.Columns.Add("Address");
                dataTable.Columns.Add("AptOrSuite");
                dataTable.Columns.Add("PostalZip");
                dataTable.Columns.Add("Country");

                while (sqlDataReader.Read())
                {
                    DataRow dataRow = dataTable.NewRow();

                    dataRow["Id"] = sqlDataReader["Id"];
                    dataRow["FullName"] = sqlDataReader["FullName"];
                    dataRow["Phone"] = sqlDataReader["Phone"];
                    dataRow["Email"] = sqlDataReader["Email"];
                    dataRow["Address"] = sqlDataReader["Address"];
                    dataRow["AptOrSuite"] = sqlDataReader["AptOrSuite"];
                    dataRow["PostalZip"] = sqlDataReader["PostalZip"];
                    dataRow["Country"] = sqlDataReader["Country"];

                    dataTable.Rows.Add(dataRow);

                }
                //sqlConnection.Close(); // need to close already existing connection before starting a new one
            }
            
            return dataTable;
        }

        public void addShippingDetails(Customer customer)
        {
            string connectionString = "Data Source=G7-LAPTOP\\SQLEXPRESS;Initial Catalog=MyLocalDb;Integrated Security=True";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string queryCommand = "INSERT INTO ABC_Shipping_Co(FullName, Phone, Email, Address, AptOrSuite, PostalZip, Country) VALUES(@FullName, @Phone, @Email, @Address, @AptOrSuite, @PostalZip, @Country)";

                SqlCommand sqlCommand = new SqlCommand(queryCommand, sqlConnection);

                sqlCommand.Parameters.Add("@FullName", SqlDbType.VarChar);
                sqlCommand.Parameters["@FullName"].Value = customer.FullName;

                sqlCommand.Parameters.Add("@Phone", SqlDbType.VarChar);
                sqlCommand.Parameters["@Phone"].Value = customer.Phone;

                sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar);
                sqlCommand.Parameters["@Email"].Value = customer.Email;

                sqlCommand.Parameters.Add("@Address", SqlDbType.VarChar);
                sqlCommand.Parameters["@Address"].Value = customer.Address;

                sqlCommand.Parameters.Add("@AptOrSuite", SqlDbType.VarChar);
                sqlCommand.Parameters["@AptOrSuite"].Value = customer.AptOrSuite;

                sqlCommand.Parameters.Add("@PostalZip", SqlDbType.VarChar);
                sqlCommand.Parameters["@PostalZip"].Value = customer.PostalZip;

                sqlCommand.Parameters.Add("@Country", SqlDbType.VarChar);
                sqlCommand.Parameters["@Country"].Value = customer.Country;

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}