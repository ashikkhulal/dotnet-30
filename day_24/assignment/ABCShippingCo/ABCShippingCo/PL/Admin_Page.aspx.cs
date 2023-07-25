using ABCShippingCo.BL;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            foreach (GridViewRow row in Gv_Admin.Rows)
            {
                if (row.RowIndex == Gv_Admin.SelectedIndex)
                {
                    row.BackColor = ColorTranslator.FromHtml("#A1DCF2");
                    row.ToolTip = string.Empty;
                }
                else
                {
                    row.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    row.ToolTip = "Click to select this row.";
                }
            }

        }

        protected void Gv_admin2_Load(object sender, EventArgs e)
        {
            BLCustomer blCustomer = new BLCustomer();
            Gv_admin2.DataSource = blCustomer.getTableData();
            Gv_admin2.DataBind();
        }

        protected void Gv_admin3_Load(object sender, EventArgs e)
        {
            BLCustomer blCustomer = new BLCustomer();
            Gv_admin3.DataSource = blCustomer.getTableData_DA();
            Gv_admin3.DataBind();
        }
    }
}