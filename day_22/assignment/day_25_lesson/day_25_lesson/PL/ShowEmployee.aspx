<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowEmployee.aspx.cs" Inherits="day_25_lesson.PL.ShowEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Show Employee (using GridView) Info:</h2>
            <asp:GridView ID="Gv_ShowEmployeeInfo" runat="server" BorderColor="#006600" Font-Bold="True"></asp:GridView>
        </div>
    </form>
</body>
</html>
