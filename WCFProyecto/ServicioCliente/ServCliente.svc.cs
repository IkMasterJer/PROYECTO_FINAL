using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFProyecto.ServicioCliente
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServCliente" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServCliente.svc o ServCliente.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServCliente : IServCliente
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString);
        public string ActualizarCliente(Cliente regdet)
        {
            string Status;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("update Clientes set Nombre=@nombre,Apellido=@apellido,Direccion=@direccion,Telefono=@telefono where ClienteID=@ClienteID", con);
            cmd.Parameters.AddWithValue("@ClienteID", regdet.ClienteID);
            cmd.Parameters.AddWithValue("@nombre", regdet.Nombre);
            cmd.Parameters.AddWithValue("@apellido", regdet.Apellido);
            cmd.Parameters.AddWithValue("@direccion", regdet.Direccion);
            cmd.Parameters.AddWithValue("@telefono", regdet.Telefono);
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

        public bool EliminarCliente(Cliente regdet)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delete from Clientes where ClienteID=@ClienteID", con);

            cmd.Parameters.AddWithValue("@ClienteID", regdet.ClienteID);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;

        }

        public string InsertarCliente(Cliente regdet)
        {
            string Status;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("insert into Clientes(Nombre,Apellido,Direccion,Telefono) values(@nombre,@apellido,@direccion,@telefono)", con);
            cmd.Parameters.AddWithValue("@ClienteID", regdet.ClienteID);
            cmd.Parameters.AddWithValue("@nombre", regdet.Nombre);
            cmd.Parameters.AddWithValue("@apellido", regdet.Apellido);
            cmd.Parameters.AddWithValue("@direccion", regdet.Direccion);
            cmd.Parameters.AddWithValue("@telefono", regdet.Telefono);
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

        public DataSet ObtenerClienteActualizado(Cliente regdet)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from Clientes where ClienteID=@ClienteID", con);

            cmd.Parameters.AddWithValue("@ClienteID", regdet.ClienteID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;

        }

        public DataSet ObtenerDetallesCliente()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * from Clientes", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;

        }
    }
}
