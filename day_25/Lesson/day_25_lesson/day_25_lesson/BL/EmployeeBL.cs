using day_25_lesson.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace day_25_lesson.BL
{
    public class EmployeeBL
    {
        public List<Employee> getEmployeeInfo() 
        { 
            DBContext dBContext = new DBContext();

            return dBContext.getEmployeeInfo();
        }
    }
}