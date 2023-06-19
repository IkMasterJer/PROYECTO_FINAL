<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FRMRegCliente.aspx.cs" Inherits="WebProyecto.FRMCliente.FRMRegCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="../estilos/estilo.css">
</head>
<body>
    <div class="container">
    <h2>REGISTRAR CLIENTE</h2>
    <form runat="server" method="POST">
      <div class="form-group">
        <label for="nomcliente">Nombre:</label>
        <asp:TextBox runat="server" ID="txtNomCliente" ></asp:TextBox>
      </div>
      
      <div class="form-group">
        <label for="precio">Apellido:</label>
        <asp:TextBox ID="txtApellido" runat="server" ></asp:TextBox>
      </div>
      <div class="form-group">
        <label for="dirreccion">Direccion</label>
        <asp:TextBox ID="txtDireccion" runat="server" ></asp:TextBox>
      </div>
        <div class="form-group">
        <label for="telefono">Telefono</label>
        <asp:TextBox ID="txtTelefono" runat="server" ></asp:TextBox>
      </div>
      <div class="form-group">
        <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" CssClass="btn" OnClick="btnRegistrar_Click" />
      </div>
        <div class="form-group">
        <asp:Button ID="btnvolver" runat="server" Text="Volver" CssClass="btn" OnClick="btnvolver_Click" />
      </div>
        <div class="form-group">
            <asp:Label runat="server" ID="lbregistrar"></asp:Label>
        </div>

    </form>
  </div>
</body>
</html>
