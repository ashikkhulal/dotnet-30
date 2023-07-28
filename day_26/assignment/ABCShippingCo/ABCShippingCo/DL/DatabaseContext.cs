using ABCShippingCo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABCShippingCo.DL
{
    public class DatabaseContext
    {
        public List<ShippingInfo> getShippingDetails() 
        {
            using (ABCShippingCoEF aBCShippingCoEF = new ABCShippingCoEF())
            {
                return aBCShippingCoEF.ShippingInfoGeneric.ToList();
            }
        }

        public void addShippingDetails()
        {
            using (ABCShippingCoEF aBCShippingCoEF = new ABCShippingCoEF())
            {
                ShippingInfo shippingInfo = new ShippingInfo();

                shippingInfo.ID = 1;
                shippingInfo.FullName = "John Doe";
                shippingInfo.Phone = "0123456789";
                shippingInfo.Email = "johndoe@example.com";
                shippingInfo.Address = "123 Drive way";
                shippingInfo.AptOrSuite = "APT 200";
                shippingInfo.PostalZip = "75967";
                shippingInfo.Country = "USA";

                aBCShippingCoEF.ShippingInfoGeneric.Add(shippingInfo);




            }
        }
    }
}