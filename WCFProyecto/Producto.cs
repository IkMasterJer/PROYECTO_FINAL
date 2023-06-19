using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFProyecto
{
    [DataContract]
    public class Producto
    {
            int productoID;
            string nombre = string.Empty;
            double precio;
            int stock;

            [DataMember]
            public int ProductoID
            {
                get { return productoID; }
                set { productoID = value; }
            }
            [DataMember]
            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }
            [DataMember]
            public double Precio
            {
                get { return precio; }
                set { precio = value; }
            }
            [DataMember]
            public int Stock
            {
                get { return stock; }
                set { stock = value; }
            }

    }
}