using ABCShippingCo.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ABCShippingCo.PL
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DeliveryBL deliveryBL = new DeliveryBL();
            Gv_Admin.DataSource = deliveryBL.getShippingInfoBL();
            Gv_Admin.DataBind();

        }
    }
}