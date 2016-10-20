<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="taskD1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button OnClick="btnClicked" runat="server" Text="Show Array" />
    <asp:TextBox ID="cityName" runat="server" Width="200" Height="50"></asp:TextBox>
        <br />
    <asp:TextBox ID="numbersList" runat="server" width="1000" Height="50"></asp:TextBox>
    </div>
    </form>
</body>
</html>
