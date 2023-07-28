using ABCShippingCo.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ABCShippingCo.PL
{
    public partial class Customer_Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Submit_Click(object sender, EventArgs e)
        {
            DeliveryBL deliveryBL = new DeliveryBL();
            deliveryBL.addShippingInfoBL();
        }
    }
}