using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using WebProyecto.RefProducto;
using System.Data;

namespace WebProyecto
{
    public partial class FRMListProductos : System.Web.UI.Page
    {
        RefProducto.ServProductoClient obj = new RefProducto.ServProductoClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindRegRecordsInGrid();
            }
        }
        private void BindRegRecordsInGrid()
        {
            DataSet ds = new DataSet();
            ds = obj.ObtenerDetallesProducto();
            grdWcfTest.DataSource = ds;
            grdWcfTest.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnSubmit.Text == "Actualizar")
            {
                UpdateRegDetails();
            }
            else
            {
                HttpContext.Current.Response.Redirect("../FRMPrincipal.aspx");
            }
        }

        private void UpdateRegDetails()
        {
            Producto regDet = new Producto();
            regDet.ProductoID = Convert.ToInt32(ViewState["ProductoID"].ToString());
            regDet.Nombre = txtNombre.Text.Trim();
            regDet.Precio = Double.Parse(txtPrecio.Text.Trim());
            regDet.Stock = Int32.Parse(txtStock.Text.Trim());
            obj.ActualizarProducto(regDet);
            lblStatus.Text = obj.ActualizarProducto(regDet);
            ClearControls();
            BindRegRecordsInGrid();
        }

        private void ClearControls()
        {
            txtNombre.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtStock.Text = string.Empty;
            btnSubmit.Text = "Volver";
            txtNombre.Focus();
        }


        protected void imgEdit_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {
            Producto regDet = new Producto();
            regDet.ProductoID = int.Parse(e.CommandArgument.ToString());
            ViewState["ProductoID"] = regDet.ProductoID;
            DataSet ds = new DataSet();
            ds = obj.ObtenerProdActualizado(regDet);

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtNombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
                txtPrecio.Text = ds.Tables[0].Rows[0]["Precio"].ToString();
                txtStock.Text = ds.Tables[0].Rows[0]["Stock"].ToString();
                btnSubmit.Text = "Actualizar";
            }
        }

        protected void imgDel_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {
            Producto regDet = new Producto();
            regDet.ProductoID = int.Parse(e.CommandArgument.ToString());
            if (obj.EliminarProducto(regDet) == true)
            {
                lblStatus.Text = "Eliminado correctamente";
            }
            else
            {
                lblStatus.Text = "No se pudo eliminar";
            }
            BindRegRecordsInGrid();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
            lblStatus.Text = string.Empty;
        }
        
    }
}