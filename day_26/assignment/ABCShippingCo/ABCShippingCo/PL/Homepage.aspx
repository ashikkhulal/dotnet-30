<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="ABCShippingCo.PL.Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome to ABC Shipping Co.</h1>
            <h4>Where all your shipping needs are delivered!</h4>
            <asp:Image ID="Img_Welcome" src="../assets/welcome_image.jpg" alt="Welcome Photo" width="500" length="500" runat="server" />
        </div>
        <div>
            <h3>What is ABC Shipping Company?</h3>
            <p>ABC Shipping Company(Co.) is a low-cost shipping service that delivers to home and businesses and is faster to more locations than other shipping companies.</p>
            <p>If you need to ship to a residential and business address, use <asp:HyperLink ID="Hlnk_Delivery2" runat="server" NavigateUrl="./Customer_Registration.aspx">ABC Delivery®</asp:HyperLink>, which delivers every day of the week, , 24 X 7, for your convenience.</p>
            <h3>Services:</h3>
            <table>
                <tr>
                    <td>
                        <asp:HyperLink ID="Hl_Delivery" runat="server" NavigateUrl="./Customer_Registration.aspx">ABC Delivery®</asp:HyperLink>
                    </td>
                    <td>
                        <asp:Label ID="Lbl_WhiteSpace" runat="server" Text="&emsp;|&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;|&emsp;"></asp:Label>
                    </td>
                    <td>
                        <asp:HyperLink ID="Hl_Admin" runat="server" NavigateUrl="./AdminPage.aspx">Admin Page</asp:HyperLink>
                    </td>
                </tr>
            </table>
            <br />
          
        </div>
    </form>
</body>
</html>
