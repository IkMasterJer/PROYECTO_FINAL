<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FRMRegUsuario.aspx.cs" Inherits="WebProyecto.FRMRegUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="estilos/estilo.css">
</head>
<body>
    <div class="container">
    <h2>REGISTRARSE</h2>
    <form runat="server" method="POST">
      <div class="form-group">
        <label for="username">Nombre de usuario:</label>
        <asp:TextBox runat="server" ID="txtUsuario" ></asp:TextBox>
      </div>
      <div class="form-group">
        <label for="password">Contraseña:</label>
        <asp:TextBox ID="txtContra" runat="server" TextMode="Password" ></asp:TextBox>
      </div>
      <div class="form-group">
        <label for="celular">Celular:</label>
        <asp:TextBox ID="txtCelular" runat="server" ></asp:TextBox>
      </div>
      <div class="form-group">
        <label for="correo">Correo</label>
        <asp:TextBox ID="txtCorreo" runat="server" ></asp:TextBox>
      </div>
      <div class="form-group">
        <asp:Button ID="btnRegistrarse" runat="server" Text="Registrarse" CssClass="btn" OnClick="btnRegistrarse_Click" />
      </div>
        <div class="form-group">
        <asp:Button ID="btnvolver" runat="server" Text="Volver" CssClass="btn" OnClick="btnVolver_Click" />
      </div>
        <div class="form-group">
            <asp:Label runat="server" ID="lbregistrar"></asp:Label>
        </div>

    </form>
  </div>
</body>
</html>
