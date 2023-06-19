using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebProyecto.RefCliente;

namespace WebProyecto.FRMCliente
{
    public partial class FRMRegCliente : System.Web.UI.Page
    {
        RefCliente.ServClienteClient obj = new RefCliente.ServClienteClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNomCliente.Text) &&
                !string.IsNullOrWhiteSpace(txtApellido.Text) &&
                !string.IsNullOrWhiteSpace(txtDireccion.Text) &&
                !string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                Cliente regDet = new Cliente();
                regDet.Nombre = txtNomCliente.Text.Trim();
                regDet.Apellido = txtApellido.Text.Trim();
                regDet.Direccion = txtDireccion.Text.Trim();
                regDet.Telefono = txtTelefono.Text.Trim();

                lbregistrar.Text = obj.InsertarCliente(regDet);
                ClearControls();
            }
            else
            {
                lbregistrar.Text = "Llene todos los campos";
            }
        }

        private void ClearControls()
        {
            txtNomCliente.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtNomCliente.Text = string.Empty;
        }

        protected void btnvolver_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("../FRMPrincipal.aspx");
        }
    }
}