using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace day_25_lesson.DAL
{
    public class DBContext
    {
        public List<Employee> getEmployeeInfo()
        {
            MyLocalDbEntities myLocalDbEntities = new MyLocalDbEntities();

            return myLocalDbEntities.Employees.ToList();
        }
    }
}