using day_26_lesson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace day_26_lesson.DL
{
    public class DatabaseContext
    {
        public DatabaseContext() { }
        public DatabaseContext(string efModelName) { }

        public void getEmployeeDetails()
        { 
        }

        public void addEmployeeDetails() 
        {
            using (EmployeeDetailsModel employeeDetailsModel = new EmployeeDetailsModel())
            {
                EmployeeDetailsEntities employeeDetails = new EmployeeDetailsEntities();
                employeeDetails.ID = 1;
                employeeDetails.FullName = "Ashik Khulal";
                employeeDetails.Phone = "987254123";
                employeeDetails.Email = "ashik@example.com";
                employeeDetails.Address = "1528 Arcu. Rd.";
                employeeDetails.AptOrSuite = "APT 200";
                employeeDetails.PostalZip = "388737";
                employeeDetails.Country = "Mexico";
                employeeDetails.OnVacation = true;

                employeeDetailsModel.EmployeeDetailsEntities.Add(employeeDetails);
            }
        }
    }
}