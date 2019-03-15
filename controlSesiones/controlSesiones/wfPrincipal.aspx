<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfPrincipal.aspx.cs" Inherits="controlSesiones.wfPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="frPrincipal" runat="server">
        <div>
            <asp:Label Text="Bienvenido " runat="server" ID="lbBienvenida"/>
            <br />
            <asp:Label Text="Usuario" runat="server" ID="lblUser"/>
            <br />
        </div>
        <div>
            <asp:Button Text="Cerrar Sesión" runat="server" ID="btnSalir" OnClick="btnSalir_Click"/>
        </div>
    </form>
</body>
</html>
