<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="day_25_lesson.PL.Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>What would you like to do?</h2>
            <table>
                <tr>
                    <td>
                        <asp:HyperLink ID="Hl_AddEmployee" runat="server" NavigateUrl="~/PL/AddEmployee.aspx">Add Employee</asp:HyperLink>
                    </td>
                    <td>
                        <asp:Label ID="Lbl_WhiteSpace" runat="server" Text="&emsp;|&emsp;&emsp;&emsp;&emsp;|&emsp;"></asp:Label>
                    </td>
                    <td>
                        <asp:HyperLink ID="Hl_ShowEmployee" runat="server" NavigateUrl="~/PL/ShowEmployee.aspx">View Employee Info</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
