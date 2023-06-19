using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebProyecto.RefUsuarios;

namespace WebProyecto
{
    public partial class FRMLogin : System.Web.UI.Page
    {
        RefUsuarios.ServUsuarioClient objServiceClientobjService = new RefUsuarios.ServUsuarioClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string password = txtContra.Text;
            string result = objServiceClientobjService.validaLogin(user, password);
            if (result == "Bienvenido")
            {
                HttpContext.Current.Response.Redirect("FRMPrincipal.aspx");
            }
            else
            {
                lbingresar.Text = result;
            }
            
            
        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("FRMRegUsuario.aspx");
        }
    }
}