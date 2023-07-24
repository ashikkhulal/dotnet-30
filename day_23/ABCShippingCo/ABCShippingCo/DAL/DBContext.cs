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
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            }

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