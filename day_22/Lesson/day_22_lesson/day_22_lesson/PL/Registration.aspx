<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="day_22_lesson.PL.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Lbl_FirstName" runat="server" Text="FirstName">First Name:</asp:Label>
            <asp:TextBox ID="Txt_FirstName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Lbl_LastName" runat="server" Text="LastName">Last Name:</asp:Label>
            <asp:TextBox ID="Txt_LastName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Lbl_Phone" runat="server" Text="Phone">Phone No.:</asp:Label>
            <asp:TextBox ID="Txt_Phone" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Lbl_Email" runat="server" Text="Email">Email ID:</asp:Label>
            <asp:TextBox ID="Txt_Email" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Lbl_Address" runat="server" Text="Email">Address:</asp:Label>
            <asp:TextBox ID="Txt_Address" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Btn_Submit" runat="server" Text="Register" OnClick="Btn_Submit_Click" />
        </div>

    </form>
</body>
</html>
