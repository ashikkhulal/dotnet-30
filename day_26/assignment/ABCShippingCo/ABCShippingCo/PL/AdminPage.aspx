<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="ABCShippingCo.PL.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Welcome to ABC Shipping Co Admin Page!</h3>
            <br />
            <h4>View customers shipping info below:</h4>

            <asp:GridView ID="Gv_Admin" runat="server"></asp:GridView>

        </div>
    </form>
</body>
</html>
