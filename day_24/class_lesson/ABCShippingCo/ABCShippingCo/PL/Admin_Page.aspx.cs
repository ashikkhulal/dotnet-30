using ABCShippingCo.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ABCShippingCo.PL
{
    public partial class Admin_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Grv_Admin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Gv_admin2_Load(object sender, EventArgs e)
        {
            BLCustomer blCustomer = new BLCustomer();
            Gv_admin2.DataSource = blCustomer.getTableData();
            Gv_admin2.DataBind();
        }
    }
}