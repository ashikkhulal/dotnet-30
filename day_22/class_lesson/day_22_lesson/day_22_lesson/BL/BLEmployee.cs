using day_22_lesson.DAL;
using day_22_lesson.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace day_22_lesson.BL
{
    public class BLEmployee
    {
        public void registerEmployee(Employee employee) 
        {
            employee.Address = employee.Address + " - Abstraction";
            
            DBContext dbContext = new DBContext();
            dbContext.registerEmployee(employee);

        }
    }
}