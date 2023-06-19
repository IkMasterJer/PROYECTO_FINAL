<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FRMListProductos.aspx.cs" Inherits="WebProyecto.FRMListProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registrar Porducto</title>
    <link rel="stylesheet" type="text/css" href="../estilos/estilo.css">
    <style type="text/css">
        .auto-style2 {
            height: 20px;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">

        <div>
            <fieldset style="width: 500px">
                <legend>REGISTRAR PRODUCTO </legend>
                <table>
                    <tr>
                        <td>Nombre Del Producto</td>
                        <td>
                            <asp:TextBox ID="txtNombre" runat="server" Style="margin-right: 59px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Precio</td>
                        <td>
                            <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Stock</td>
                        <td>
                            <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td>&nbsp;</td>
                        <td class="style1">
                            <asp:Button ID="btnSubmit" runat="server" Text="Volver"
                                OnClick="btnSubmit_Click" />
                            <asp:Button ID="btnCancel" runat="server" Text="Cancelar"
                                OnClick="btnCancel_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2"></td>
                        <td class="auto-style2">
                            <asp:Label ID="lblStatus" runat="server" Text="" Style="color: #FF3300"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:GridView ID="grdWcfTest" runat="server" AutoGenerateColumns="False"
                                DataKeyNames="ProductoID" CellPadding="5" ForeColor="#333333">
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                <Columns>
                                    <asp:TemplateField HeaderText="Nombre" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:Label ID="lblName" runat="server" Text='<%#Eval("Nombre") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="Precio" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:Label ID="lblPrecio" runat="server" Text='<%#Eval("Precio") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="Stock" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:Label ID="lblStock" runat="server" Text='<%#Eval("Stock") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="Editar" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:ImageButton ID="imgBtn" runat="server" CausesValidation="false" CommandArgument='<%#Eval("ProductoID") %>'
                                                OnCommand="imgEdit_Command" ImageUrl="~/Images/edit.png"
                                                ToolTip="Edit" />
                                        </ItemTemplate>

                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>

                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="Eliminar" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">

                                        <ItemTemplate>
                                            <asp:ImageButton ID="imgDel" runat="server" CausesValidation="false" CommandArgument='<%#Eval("ProductoID") %>'
                                                CommandName="Delete" OnCommand="imgDel_Command" ImageUrl="~/Images/delete.png"
                                                ToolTip="Delete" OnClientClick="return confirm('Are you sure you want to delete?')" />
                                        </ItemTemplate>

                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>

                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:TemplateField>
                                </Columns>
                                <EditRowStyle BackColor="#999999" />
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </fieldset>
        </div>


    </form>

</body>
</html>
