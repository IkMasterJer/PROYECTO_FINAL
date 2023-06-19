using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFProyecto.ServicioCliente
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServCliente" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServCliente
    {
        [OperationContract]
        string InsertarCliente(Cliente regdet);

        [OperationContract]
        DataSet ObtenerDetallesCliente();

        [OperationContract]
        DataSet ObtenerClienteActualizado(Cliente regdet);

        [OperationContract]
        string ActualizarCliente(Cliente regdet);

        [OperationContract]
        bool EliminarCliente(Cliente regdet);

    }
}
