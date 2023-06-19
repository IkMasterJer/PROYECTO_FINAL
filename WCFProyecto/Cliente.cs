using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFProyecto
{
    [DataContract]
    public class Cliente
    {
        int clienteID;
        string nombre = string.Empty;
        string apellido = string.Empty;
        string direccion = string.Empty;
        string telefono = string.Empty;

        [DataMember]
        public int ClienteID
        {
            get { return clienteID; }
            set { clienteID = value; }
        }
        [DataMember]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        [DataMember]
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        [DataMember]
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        [DataMember]
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }


        }
    }
}