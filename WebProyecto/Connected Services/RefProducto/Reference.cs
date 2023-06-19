﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebProyecto.RefProducto {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Producto", Namespace="http://schemas.datacontract.org/2004/07/WCFProyecto")]
    [System.SerializableAttribute()]
    public partial class Producto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PrecioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductoIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StockField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Precio {
            get {
                return this.PrecioField;
            }
            set {
                if ((this.PrecioField.Equals(value) != true)) {
                    this.PrecioField = value;
                    this.RaisePropertyChanged("Precio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductoID {
            get {
                return this.ProductoIDField;
            }
            set {
                if ((this.ProductoIDField.Equals(value) != true)) {
                    this.ProductoIDField = value;
                    this.RaisePropertyChanged("ProductoID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Stock {
            get {
                return this.StockField;
            }
            set {
                if ((this.StockField.Equals(value) != true)) {
                    this.StockField = value;
                    this.RaisePropertyChanged("Stock");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RefProducto.IServProducto")]
    public interface IServProducto {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServProducto/InsertarProducto", ReplyAction="http://tempuri.org/IServProducto/InsertarProductoResponse")]
        string InsertarProducto(WebProyecto.RefProducto.Producto regdet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServProducto/InsertarProducto", ReplyAction="http://tempuri.org/IServProducto/InsertarProductoResponse")]
        System.Threading.Tasks.Task<string> InsertarProductoAsync(WebProyecto.RefProducto.Producto regdet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServProducto/ObtenerDetallesProducto", ReplyAction="http://tempuri.org/IServProducto/ObtenerDetallesProductoResponse")]
        System.Data.DataSet ObtenerDetallesProducto();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServProducto/ObtenerDetallesProducto", ReplyAction="http://tempuri.org/IServProducto/ObtenerDetallesProductoResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ObtenerDetallesProductoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServProducto/ObtenerProdActualizado", ReplyAction="http://tempuri.org/IServProducto/ObtenerProdActualizadoResponse")]
        System.Data.DataSet ObtenerProdActualizado(WebProyecto.RefProducto.Producto regdet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServProducto/ObtenerProdActualizado", ReplyAction="http://tempuri.org/IServProducto/ObtenerProdActualizadoResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ObtenerProdActualizadoAsync(WebProyecto.RefProducto.Producto regdet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServProducto/ActualizarProducto", ReplyAction="http://tempuri.org/IServProducto/ActualizarProductoResponse")]
        string ActualizarProducto(WebProyecto.RefProducto.Producto regdet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServProducto/ActualizarProducto", ReplyAction="http://tempuri.org/IServProducto/ActualizarProductoResponse")]
        System.Threading.Tasks.Task<string> ActualizarProductoAsync(WebProyecto.RefProducto.Producto regdet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServProducto/EliminarProducto", ReplyAction="http://tempuri.org/IServProducto/EliminarProductoResponse")]
        bool EliminarProducto(WebProyecto.RefProducto.Producto regdet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServProducto/EliminarProducto", ReplyAction="http://tempuri.org/IServProducto/EliminarProductoResponse")]
        System.Threading.Tasks.Task<bool> EliminarProductoAsync(WebProyecto.RefProducto.Producto regdet);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServProductoChannel : WebProyecto.RefProducto.IServProducto, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServProductoClient : System.ServiceModel.ClientBase<WebProyecto.RefProducto.IServProducto>, WebProyecto.RefProducto.IServProducto {
        
        public ServProductoClient() {
        }
        
        public ServProductoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServProductoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServProductoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServProductoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string InsertarProducto(WebProyecto.RefProducto.Producto regdet) {
            return base.Channel.InsertarProducto(regdet);
        }
        
        public System.Threading.Tasks.Task<string> InsertarProductoAsync(WebProyecto.RefProducto.Producto regdet) {
            return base.Channel.InsertarProductoAsync(regdet);
        }
        
        public System.Data.DataSet ObtenerDetallesProducto() {
            return base.Channel.ObtenerDetallesProducto();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ObtenerDetallesProductoAsync() {
            return base.Channel.ObtenerDetallesProductoAsync();
        }
        
        public System.Data.DataSet ObtenerProdActualizado(WebProyecto.RefProducto.Producto regdet) {
            return base.Channel.ObtenerProdActualizado(regdet);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ObtenerProdActualizadoAsync(WebProyecto.RefProducto.Producto regdet) {
            return base.Channel.ObtenerProdActualizadoAsync(regdet);
        }
        
        public string ActualizarProducto(WebProyecto.RefProducto.Producto regdet) {
            return base.Channel.ActualizarProducto(regdet);
        }
        
        public System.Threading.Tasks.Task<string> ActualizarProductoAsync(WebProyecto.RefProducto.Producto regdet) {
            return base.Channel.ActualizarProductoAsync(regdet);
        }
        
        public bool EliminarProducto(WebProyecto.RefProducto.Producto regdet) {
            return base.Channel.EliminarProducto(regdet);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarProductoAsync(WebProyecto.RefProducto.Producto regdet) {
            return base.Channel.EliminarProductoAsync(regdet);
        }
    }
}