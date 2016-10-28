<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="taskD2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Create an array to store 6 Greek letters and correspondent western letters</h2>
        <asp:Button OnClick="btn2Clicked" runat="server" Text="Show Array" />
        <br />
        <asp:TextBox ID="letter" runat="server" width="1000" Height="50"></asp:TextBox>
    </div>
    </form>
</body>
</html>
