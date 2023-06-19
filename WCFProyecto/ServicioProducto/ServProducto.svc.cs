using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WCFProyecto.ServicioProducto
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServProducto" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServProducto.svc o ServProducto.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServProducto : IServProducto
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString);
        public string ActualizarProducto(Producto regdet)
        {
            string Status;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("update Productos set Nombre=@nombre,Precio=@precio,Stock=@stock where ProductoID=@productoid", con);
            cmd.Parameters.AddWithValue("@productoid", regdet.ProductoID);
            cmd.Parameters.AddWithValue("@nombre", regdet.Nombre);
            cmd.Parameters.AddWithValue("@precio", regdet.Precio);
            cmd.Parameters.AddWithValue("@stock", regdet.Stock);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Status = "ACTUALIZADO CORRECTAMENTE";
            }
            else
            {
                Status = "NO SE PUDO ACTUALIZAR";
            }
            con.Close();
            return Status;

        }

        public bool EliminarProducto(Producto regdet)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delete from Productos where ProductoID=@productoid", con);

            cmd.Parameters.AddWithValue("@productoid", regdet.ProductoID);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;

        }

        public string InsertarProducto(Producto regdet)
        {
            string Status;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("insert into Productos(Nombre,Precio,Stock) values(@nombre,@precio,@stock)", con);
            cmd.Parameters.AddWithValue("@nombre", regdet.Nombre);
            cmd.Parameters.AddWithValue("@precio", regdet.Precio);
            cmd.Parameters.AddWithValue("@stock", regdet.Stock);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Status = regdet.Nombre + " REGISTRADO CORRECTAMENTE";
            }
            else
            {
                Status = regdet.Nombre + " NO SE REGISTRO";
            }
            con.Close();
            return Status;

        }

        public DataSet ObtenerDetallesProducto()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * from Productos", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;

        }

        public DataSet ObtenerProdActualizado(Producto regdet)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from Productos where ProductoID=@productoid", con);

            cmd.Parameters.AddWithValue("@productoid", regdet.ProductoID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;

        }
    }
}
