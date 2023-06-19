using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebProyecto.RefUsuarios;

namespace WebProyecto
{
    public partial class FRMRegUsuario : System.Web.UI.Page
    {
        RefUsuarios.ServUsuarioClient objServiceClientobjService = new RefUsuarios.ServUsuarioClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("FRMLogin.aspx");
        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string password = txtContra.Text;
            string celular = txtCelular.Text;
            string correo = txtCorreo.Text;
            string result = objServiceClientobjService.RegistrarUsuario(user, password, celular, correo);
            lbregistrar.Text = result;
        }
    }
}