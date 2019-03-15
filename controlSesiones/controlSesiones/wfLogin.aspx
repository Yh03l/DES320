<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfLogin.aspx.cs" Inherits="controlSesiones.wfIndex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    
.titulo{
    margin-bottom:20px;
    font-size: 40px;
    color: #fff;
    text-align:center;
}

    </style>
</head>
<body>
    <form id="frIndex" runat="server">
        <div class="auto-style1" style="background-color: #1E9FFE; color: #FFFFFF; font-weight: bold">
            <h1 class="titulo">Login</h1>
            <br />
            <asp:TextBox runat="server" ID="txtUser"/>
            <br />
            <asp:TextBox runat="server" ID="txtPass" TextMode="Password" OnTextChanged="txtPass_TextChanged"/>
            <br />
            <br />
            <asp:Button Text="Iniciar Sesión" runat="server" ID="btnIngresar" OnClick="btnIngresar_Click"/>
            <br />
            <asp:Label Text="" runat="server" ID="lblMensaje" Visible="false" />
            <br />
            <asp:Label Text="" runat="server" ID="lblContador" Visible="false" />
        </div>
    </form>
</body>
</html>
