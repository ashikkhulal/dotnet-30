<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Page.aspx.cs" Inherits="ABCShippingCo.PL.Admin_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Welcome to ABC Shipping Admin Page!</h3>
            <h4>View customers data below:</h4>

            <h6>Note: Using frontend way to get data:</h6>
            <asp:GridView ID="Gv_Admin" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSourceMyLocalDb" AllowPaging="True" AllowSorting="True" OnSelectedIndexChanged="Grv_Admin_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True"></asp:CommandField>
                    <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" InsertVisible="False" SortExpression="ID"></asp:BoundField>
                    <asp:BoundField DataField="FullName" HeaderText="FullName" SortExpression="FullName"></asp:BoundField>
                    <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone"></asp:BoundField>
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email"></asp:BoundField>
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address"></asp:BoundField>
                    <asp:BoundField DataField="AptOrSuite" HeaderText="AptOrSuite" SortExpression="AptOrSuite"></asp:BoundField>
                    <asp:BoundField DataField="PostalZip" HeaderText="PostalZip" SortExpression="PostalZip"></asp:BoundField>
                    <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country"></asp:BoundField>
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource runat="server" ID="SqlDataSourceMyLocalDb" ConnectionString="<%$ ConnectionStrings:MyLocalDBConnectionString %>" SelectCommand="SELECT * FROM [ABC_Shipping_Co] ORDER BY [ID]"></asp:SqlDataSource>
        </div>
        <div>
            <h6>Note: Using backend way to get data:</h6>
            <asp:GridView ID="Gv_admin2" runat="server" OnLoad="Gv_admin2_Load"></asp:GridView>
        </div>
    </form>
</body>
</html>
