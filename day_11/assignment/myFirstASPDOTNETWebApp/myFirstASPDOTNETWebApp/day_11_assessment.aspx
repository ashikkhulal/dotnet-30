<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="day_11_assessment.aspx.vb" Inherits="myFirstASPDOTNETWebApp.day_11_assessment" %>

<!DOCTYPE html>
<br class="Apple-interchange-newline">

<html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <title>Day 11 Assessment</title>
    </head>
    <body>
        <form runat="server">
            <asp:Label ID="FirstNameLabel" runat="server" Text="First Name"></asp:Label> <asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox> <br> <br>
            <asp:Label ID="LastNameLabel" runat="server" Text="Last Name"></asp:Label> <asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox> <br> <br>
            <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
        </form>
    </body>

</html>
