using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFProyecto
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServUsuario" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServUsuario.svc o ServUsuario.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServUsuario : IServUsuario
    {
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=PROYECTO_FINAL ;integrated security=true");

        public string RegistrarUsuario(string nombre, string contra, string celular, string correo)
        {
            string mensaje = null;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Usuarios(nombre ,contra, celular, correo) VALUES(@nombre, @contra, @celular, @correo)", con);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@contra", contra);
                cmd.Parameters.AddWithValue("@celular", celular);
                cmd.Parameters.AddWithValue("@correo", correo);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    mensaje = "Registrado Correctamente";
                }
                con.Close();

            }
            catch (Exception) { }
            return mensaje;
        }

        public string validaLogin(string usua, string pass)
        {
            String mensaje = "";
            List<string> userPassword = new List<string>();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios WHERE nombre=@user and contra = @pass", con);
                cmd.Parameters.AddWithValue("@user", usua);
                cmd.Parameters.AddWithValue("@pass", pass);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                da.Fill(tb);

                if (tb.Rows.Count > 0)
                {
                    mensaje = "Bienvenido";
                    /*for (int i = 0; i < tb.Rows.Count; i++)
                    {
                        string name = tb.Rows[i]["nombre"].ToString();
                        string password = tb.Rows[i]["contra"].ToString();
                        userPassword.Add(name);
                        userPassword.Add(password);

                    }*/
                }
                else
                {
                    mensaje = "Usuario no encontrado";

                }
                con.Close();


            }
            catch (Exception ex)
            {

            }
            return mensaje;
        }
    }
}
