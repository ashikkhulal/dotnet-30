using ABCShippingCo.DL;
using ABCShippingCo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ABCShippingCo.BL
{
    public class DeliveryBL
    {
        public List<ShippingInfo>  getShippingInfoBL() 
        {
            DatabaseContext databaseContext = new DatabaseContext();

            var shippingInfo = from ship in databaseContext.getShippingDetails()
                               //where
                               select ship;
            
            
            return databaseContext.getShippingDetails();

        }

        public void addShippingInfoBL()
        {
            DatabaseContext databaseContext = new DatabaseContext();

            databaseContext.addShippingDetails();

        }


    }
}