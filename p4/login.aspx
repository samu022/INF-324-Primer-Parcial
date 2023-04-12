<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="p2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="css/login.css">
    <title>LOGIN FCPN</title>
</head>
<body>
    <form id="form1" runat="server" method="POST" action="">
        <h1>LOGIN FCPN</h1>
        <asp:Label ID="lblUsuario" runat="server" Text="Usuario: "></asp:Label>
        <asp:TextBox ID="Busuario" runat="server"></asp:TextBox><br />
        <asp:Label ID="lblpass" runat="server" Text="Password: "></asp:Label>
        <asp:TextBox ID="Bcontrasena" runat="server" TextMode="Password" ></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Aceptar" OnClick="Button1_Click" />
    </form>
</body>
</html>
