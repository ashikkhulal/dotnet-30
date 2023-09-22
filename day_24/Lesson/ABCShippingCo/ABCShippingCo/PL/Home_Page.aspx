<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home_Page.aspx.cs" Inherits="ABCShippingCo.PL.Home_page" %>

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

            <h3>Services:</h3>

            <table>
                <tr>
                    
                    <td>
                        <asp:HyperLink ID="Hlnk_HomeDelivery1" runat="server" NavigateUrl="./Customer_Reg_Page.aspx">ABC Home Delivery®</asp:HyperLink>
                    </td>
                    <td>
                        <asp:Label ID="Lbl_empty1" runat="server" Text="&emsp;|&emsp;&emsp;&emsp;&emsp;|&emsp;"></asp:Label>
                    </td>
                    <td>
                        <asp:HyperLink ID="Hlnk_BusinessDelivery1" runat="server" NavigateUrl="./Customer_Reg_Page.aspx">ABC Business Delivery®</asp:HyperLink>
                    </td>
                </tr>
            </table>
            <br />

            <asp:Image ID="Img_Image1" src="../assets/image1.jpg" alt="Express Delivery" width="500" length="500" runat="server" />

            <p>If you need to ship to a residential address, use <asp:HyperLink ID="Hlnk_HomeDelivery2" runat="server" NavigateUrl="./Customer_Reg_Page.aspx">ABC Home Delivery®</asp:HyperLink>, which delivers every day of the week, , 24 X 7, for your convenience.</p>
            
            <p>If you need to ship to a business address, use <asp:HyperLink ID="Hlnk_BusinessDelivery2" runat="server" NavigateUrl="./Customer_Reg_Page.aspx">ABC Business Delivery®</asp:HyperLink>, which also delivers every day of the week, 24 X 7, for your convenience.</p>
            <asp:Image ID="Img_Image2" src="../assets/image2.jpg" alt="Business Delivery" width="500" length="500" runat="server" />

        </div>

        <div>
            For admin page, click <asp:HyperLink ID="Hlnk_Admin" runat="server" NavigateUrl="./Admin_Page.aspx">here</asp:HyperLink>
        </div>

    </form>
</body>
</html>
