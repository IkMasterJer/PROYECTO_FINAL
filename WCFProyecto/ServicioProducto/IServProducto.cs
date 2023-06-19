using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFProyecto.ServicioProducto
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServProducto" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServProducto
    {
        [OperationContract]
        string InsertarProducto(Producto regdet);

        [OperationContract]
        DataSet ObtenerDetallesProducto();

        [OperationContract]
        DataSet ObtenerProdActualizado(Producto regdet);

        [OperationContract]
        string ActualizarProducto(Producto regdet);

        [OperationContract]
        bool EliminarProducto(Producto regdet);
    }
}
