using ABCShippingCo.DAL;
using ABCShippingCo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ABCShippingCo.BL
{
    public class BLCustomer
    {
        public void getShippingDetails(Customer customer)
        {
            DBContext dbContext = new DBContext();
            dbContext.addShippingDetails(customer);
        }

        public DataTable getTableData()
        {
            DBContext dBContext = new DBContext();
            return dBContext.getTableData();

        }

        public DataTable getTableData_DA()
        {
            DBContext dBContext = new DBContext();
            return dBContext.getTableData_DA();
        }
    }
}