<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer_Registration.aspx.cs" Inherits="ABCShippingCo.PL.Customer_Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>ABC Delivery® Portal</h1>
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
            <br />
            <asp:Button ID="Btn_Submit" runat="server" Text="Submit" OnClick="Btn_Submit_Click" />
        </div>
        <div>
            <h2>Our Policies:</h2>
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