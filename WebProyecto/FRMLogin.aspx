<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FRMLogin.aspx.cs" Inherits="WebProyecto.FRMLogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sistema de Abarrotes</title>
    <link rel="stylesheet" type="text/css" href="estilos/estilo.css">

</head>
    
<body>
  <div class="container">
    <h2>INICIAR SESION</h2>
    <form runat="server" method="POST">
      <div class="form-group">
        <label for="username">Nombre de usuario:</label>
        <asp:TextBox runat="server" ID="txtUsuario"></asp:TextBox>
      </div>
      <div class="form-group">
        <label for="password">Contraseña:</label>
        <asp:TextBox ID="txtContra" runat="server" TextMode="Password" ></asp:TextBox>
      </div>
      <div class="form-group">
        <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass="btn" OnClick="btnIngresar_Click" />
      </div>
      <div class="form-group">
        <asp:Button ID="btnRegistrar" runat="server" Text="Registrarse" CssClass="btn" OnClick="btnRegistrarse_Click" />
      </div>
        <div class="form-group">
            <asp:Label runat="server" ID="lbingresar"></asp:Label>
        </div>

    </form>
  </div>
</body>
</html>
