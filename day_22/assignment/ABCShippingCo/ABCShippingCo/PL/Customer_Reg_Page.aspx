<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer_Reg_Page.aspx.cs" Inherits="ABCShippingCo.PL.Customer_Reg_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ABC Shipping Co - Shipping Portal</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left:auto; margin-right:auto;">
            <h1>ABC Shipping Company - Shipping Portal</h1>
            <p>Please enter your shipping details for your item delivery below: </p>
        </div>
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="Lbl_FullName" runat="server" Text="Full Name: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Txt_FullName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Lbl_Phone" runat="server" Text="Phone: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Txt_Phone" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Lbl_Email" runat="server" Text="Email: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Txt_Email" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Lbl_Address" runat="server" Text="Address: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Txt_Address" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Lbl_AptOrSuite" runat="server" Text="Apt / Suite: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Txt_AptOrSuite" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Lbl_PostalZip" runat="server" Text="PostalZip: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Txt_PostalZip" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Lbl_Country" runat="server" Text="Country: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Txt_Country" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <div>
            <asp:Button ID="Btn_Submit" runat="server" Text="Submit" OnClick="Btn_Submit_Click" />
        </div>
        <div>
            <h3>What is ABC Shipping Company?</h3>
            <p>ABC Shipping Company(Co.) is a low-cost shipping service that delivers to home and businesses and is faster to more locations than other shipping companies.</p>
            <p>If you need to ship to a residential address, use ABC Home Delivery®, which delivers every day of the week, , 24 X 7, for your convenience.</p>
            <p>If you need to ship to a business address, use ABC Business Delivery®, which also delivers every day of the week, 24 X 7, for your convenience.</p>
        </div>
        <div>
            <h3>Shipping/transit time</h3>
            <p>Delivery within the contiguous U.S. takes 1–5 business days. Shipping to and from Alaska and Hawaii requires 3–7 business days.</p>
        </div>
        <div>
            <h3>Weight limit and maximum package size</h3>
            <p>Packages up to 150 lbs., 108" in length, and 165" in length plus girth (L+2W+2H) can be shipped.</p>
        </div>
        <div>
            <h3>Delivery Area</h3>
            <p>ABC Ground delivers throughout all 50 states to all U.S. business addresses. ABC International Ground® ships between the U.S. and Canada, and within Canada.</p>
        </div>
    </form>
</body>
</html>
