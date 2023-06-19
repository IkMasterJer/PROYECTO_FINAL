<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FRMRegProducto.aspx.cs" Inherits="WebProyecto.FRMRegProducto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="../estilos/estilo.css">
</head>
<body>
    <div class="container">
    <h2>REGISTRAR PRODUCTO</h2>
    <form runat="server" method="POST">
      <div class="form-group">
        <label for="nomproduct">Nombre del Producto:</label>
        <asp:TextBox runat="server" ID="txtNomProduct" ></asp:TextBox>
      </div>
      
      <div class="form-group">
        <label for="precio">Precio:</label>
        <asp:TextBox ID="txtPrecio" runat="server" ></asp:TextBox>
      </div>
      <div class="form-group">
        <label for="stock">Stock</label>
        <asp:TextBox ID="txtStock" runat="server" ></asp:TextBox>
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
