using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFProyecto
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServUsuario" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServUsuario
    {
        [OperationContract]
        string validaLogin(string usua, string pass);

        [OperationContract]
        string RegistrarUsuario(string nombre, string contra, string celular, string correo);
    }
}
