<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="taskE6.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Task E6</h1>
        <asp:Label ID="Label1" runat="server" Text="Give An Integer"></asp:Label>
        <asp:TextBox ID="int1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btn63" runat="server" Text="Calculate Factorial" OnClick="BtnE6Clicked" />
        <asp:Label ID="fac" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
