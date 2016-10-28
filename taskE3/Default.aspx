<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="taskE3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Task E3</h1>
        <asp:Label ID="Label1" runat="server" Text="First Integer"></asp:Label>
        <asp:TextBox ID="int1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Second Integer"></asp:Label>
        <asp:TextBox ID="int2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnE3" runat="server" Text="Calculate Average" OnClick="BtnE3Clicked" />
        <asp:Label ID="avg" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
