using day_22_lesson.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace day_22_lesson.DAL
{
    public class DBContext
    {
        public void openConnection() 
        {
            string connectionString = "Data Source=G7-LAPTOP\\SQLEXPRESS;Initial Catalog=MyLocalDb;Integrated Security=True";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Employees", sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            }

        }

        public void registerEmployee(Employee employee) 
        {
            string connectionString = "Data Source=G7-LAPTOP\\SQLEXPRESS;Initial Catalog=MyLocalDb;Integrated Security=True";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string queryCommand = "INSERT INTO Employees(FirstName, LastName, Phone, Email, Address) VALUES(@FirstName, @LastName, @Phone, @Email, @Address)";
                
                SqlCommand sqlCommand = new SqlCommand(queryCommand, sqlConnection);

                sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar);
                sqlCommand.Parameters["@FirstName"].Value = employee.FirstName;

                sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar);
                sqlCommand.Parameters["@LastName"].Value = employee.LastName;

                sqlCommand.Parameters.Add("@Phone", SqlDbType.VarChar);
                sqlCommand.Parameters["@Phone"].Value = employee.Phone;

                sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar);
                sqlCommand.Parameters["@Email"].Value = employee.Email;

                sqlCommand.Parameters.Add("@Address", SqlDbType.VarChar);
                sqlCommand.Parameters["@Address"].Value = employee.Address;

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}