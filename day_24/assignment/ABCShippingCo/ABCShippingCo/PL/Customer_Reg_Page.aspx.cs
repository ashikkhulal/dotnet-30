using ABCShippingCo.BL;
using ABCShippingCo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ABCShippingCo.PL
{
    public partial class Customer_Reg_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Submit_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.FullName = Txt_FullName.Text;
            customer.Phone = Txt_Phone.Text;
            customer.Email = Txt_Email.Text;
            customer.Address = Txt_Address.Text;
            customer.AptOrSuite = Txt_AptOrSuite.Text;
            customer.PostalZip = Txt_PostalZip.Text;
            customer.Country = Txt_Country.Text;

            BLCustomer bLCustomer = new BLCustomer();
            bLCustomer.getShippingDetails(customer);

            Server.TransferRequest("./Submission_Page.aspx");
        }
    }
}