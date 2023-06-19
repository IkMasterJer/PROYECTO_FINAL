<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FRMPrincipal.aspx.cs" Inherits="WebProyecto.FRMPrincipal" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Sistema de Abarrotes</title>

    <link rel="stylesheet" type="text/css" href="estilos/estilocuerpo.css">

</head>

<body>
    <header>
        <h1>INFANTI STORE</h1>
    </header>

    <nav>
        <form runat="server" method="POST">
            <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" CssClass="menu">
                <Items>
                    <asp:MenuItem Text="Inicio" NavigateUrl="FRMPrincipal.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Productos">
                        <asp:MenuItem Text="Agregar Producto" NavigateUrl="~/FRMProducto/FRMRegProducto.aspx"></asp:MenuItem>
                        <asp:MenuItem Text="Listar Productos" NavigateUrl="~/FRMProducto/FRMListProductos.aspx"></asp:MenuItem>
                    </asp:MenuItem>
                    
                    <asp:MenuItem Text="Proveedores">
                        <asp:MenuItem Text="Agregar Proveedores" NavigateUrl="FRMRegProveedores.aspx"></asp:MenuItem>
                        <asp:MenuItem Text="Listar Proveedores" NavigateUrl="FRMListProveedores.aspx"></asp:MenuItem>
                    </asp:MenuItem>

                    <asp:MenuItem Text="Empleados">
                        <asp:MenuItem Text="Agregar Empleados" NavigateUrl="FRMRegEmpleados.aspx"></asp:MenuItem>
                        <asp:MenuItem Text="Listar Empleados" NavigateUrl="FRMListEmpleados.aspx"></asp:MenuItem>
                    </asp:MenuItem>

                    <asp:MenuItem Text="Clientes">
                        <asp:MenuItem Text="Agregar Clientes" NavigateUrl="~/FRMCliente/FRMRegCliente.aspx"></asp:MenuItem>
                        <asp:MenuItem Text="Listar Clientes" NavigateUrl="FRMListClientes.aspx"></asp:MenuItem>
                    </asp:MenuItem>

                    <asp:MenuItem Text="Venta">
                        <asp:MenuItem Text="Agregar Venta" NavigateUrl="FRMRegVenta.aspx"></asp:MenuItem>
                        <asp:MenuItem Text="Listar Venta" NavigateUrl="FRMListVenta.aspx"></asp:MenuItem>
                    </asp:MenuItem>
                </Items>
            </asp:Menu>

        </form>

    </nav>

    <section>
    </section>

    <footer>
        <p>Derechos de autor &copy; 2023 Sistema de Ventas</p>
    </footer>
</body>
</html>

