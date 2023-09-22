using day_22_lesson.BL;
using day_22_lesson.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace day_22_lesson.PL
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Submit_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.FirstName = Txt_FirstName.Text;
            employee.LastName = Txt_LastName.Text;
            employee.Phone = Txt_Phone.Text;
            employee.Email = Txt_Email.Text;
            employee.Address = Txt_Address.Text;

            BLEmployee bLEmployee = new BLEmployee();
            bLEmployee.registerEmployee(employee);

            Server.TransferRequest("./Confirmation");
        }
    }
}