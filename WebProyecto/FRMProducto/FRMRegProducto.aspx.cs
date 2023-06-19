using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using WebProyecto.RefProducto;

namespace WebProyecto
{
    public partial class FRMRegProducto : System.Web.UI.Page
    {
        RefProducto.ServProductoClient obj = new RefProducto.ServProductoClient();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNomProduct.Text) &&
                !string.IsNullOrWhiteSpace(txtPrecio.Text) &&
                !string.IsNullOrWhiteSpace(txtStock.Text))
            {
                Producto regDet = new Producto();
                regDet.Nombre = txtNomProduct.Text.Trim();
                regDet.Precio = Double.Parse(txtPrecio.Text.Trim());
                regDet.Stock = Int32.Parse(txtStock.Text.Trim());

                lbregistrar.Text = obj.InsertarProducto(regDet);
                ClearControls();
            }
            else
            {
                lbregistrar.Text = "Llene todos los campos";
            }


        }

        private void ClearControls()
        {
            txtNomProduct.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtNomProduct.Focus();
        }

        protected void btnvolver_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("../FRMPrincipal.aspx");
        }
    }
}