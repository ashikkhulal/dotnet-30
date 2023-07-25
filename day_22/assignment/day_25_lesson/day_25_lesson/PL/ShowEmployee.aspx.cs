using day_25_lesson.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace day_25_lesson.PL
{
    public partial class ShowEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeBL employeeBL = new EmployeeBL();
            Gv_ShowEmployeeInfo.DataSource = employeeBL.getEmployeeInfo();
            Gv_ShowEmployeeInfo.DataBind();

        }
    }
}