﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsumiendoWCF.ServiceHospital {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MedicamentoCLS", Namespace="http://schemas.datacontract.org/2004/07/WCFServiceMedico.Class")]
    [System.SerializableAttribute()]
    public partial class MedicamentoCLS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IIdMedicamentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string concentracionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PrecioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int stockField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string presentacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int habilitadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int iidFormaFarmaceuticaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreFormaFarmaceuticaField;
        
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
        public int IIdMedicamento {
            get {
                return this.IIdMedicamentoField;
            }
            set {
                if ((this.IIdMedicamentoField.Equals(value) != true)) {
                    this.IIdMedicamentoField = value;
                    this.RaisePropertyChanged("IIdMedicamento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string concentracion {
            get {
                return this.concentracionField;
            }
            set {
                if ((object.ReferenceEquals(this.concentracionField, value) != true)) {
                    this.concentracionField = value;
                    this.RaisePropertyChanged("concentracion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public decimal Precio {
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
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int stock {
            get {
                return this.stockField;
            }
            set {
                if ((this.stockField.Equals(value) != true)) {
                    this.stockField = value;
                    this.RaisePropertyChanged("stock");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public string presentacion {
            get {
                return this.presentacionField;
            }
            set {
                if ((object.ReferenceEquals(this.presentacionField, value) != true)) {
                    this.presentacionField = value;
                    this.RaisePropertyChanged("presentacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public int habilitado {
            get {
                return this.habilitadoField;
            }
            set {
                if ((this.habilitadoField.Equals(value) != true)) {
                    this.habilitadoField = value;
                    this.RaisePropertyChanged("habilitado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public int iidFormaFarmaceutica {
            get {
                return this.iidFormaFarmaceuticaField;
            }
            set {
                if ((this.iidFormaFarmaceuticaField.Equals(value) != true)) {
                    this.iidFormaFarmaceuticaField = value;
                    this.RaisePropertyChanged("iidFormaFarmaceutica");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=8)]
        public string nombreFormaFarmaceutica {
            get {
                return this.nombreFormaFarmaceuticaField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreFormaFarmaceuticaField, value) != true)) {
                    this.nombreFormaFarmaceuticaField = value;
                    this.RaisePropertyChanged("nombreFormaFarmaceutica");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FormaFarmaceuticaCLS", Namespace="http://schemas.datacontract.org/2004/07/WCFServiceMedico.Class")]
    [System.SerializableAttribute()]
    public partial class FormaFarmaceuticaCLS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int habilitadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int iidFormafarmaceuticaField;
        
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
        public int habilitado {
            get {
                return this.habilitadoField;
            }
            set {
                if ((this.habilitadoField.Equals(value) != true)) {
                    this.habilitadoField = value;
                    this.RaisePropertyChanged("habilitado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int iidFormafarmaceutica {
            get {
                return this.iidFormafarmaceuticaField;
            }
            set {
                if ((this.iidFormafarmaceuticaField.Equals(value) != true)) {
                    this.iidFormafarmaceuticaField = value;
                    this.RaisePropertyChanged("iidFormafarmaceutica");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceHospital.IServiceHospital")]
    public interface IServiceHospital {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHospital/listarMedicamento", ReplyAction="http://tempuri.org/IServiceHospital/listarMedicamentoResponse")]
        ConsumiendoWCF.ServiceHospital.MedicamentoCLS[] listarMedicamento();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHospital/listarMedicamento", ReplyAction="http://tempuri.org/IServiceHospital/listarMedicamentoResponse")]
        System.Threading.Tasks.Task<ConsumiendoWCF.ServiceHospital.MedicamentoCLS[]> listarMedicamentoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHospital/listarFormaceutica", ReplyAction="http://tempuri.org/IServiceHospital/listarFormaceuticaResponse")]
        ConsumiendoWCF.ServiceHospital.FormaFarmaceuticaCLS[] listarFormaceutica();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHospital/listarFormaceutica", ReplyAction="http://tempuri.org/IServiceHospital/listarFormaceuticaResponse")]
        System.Threading.Tasks.Task<ConsumiendoWCF.ServiceHospital.FormaFarmaceuticaCLS[]> listarFormaceuticaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHospital/recuperarMedicamento", ReplyAction="http://tempuri.org/IServiceHospital/recuperarMedicamentoResponse")]
        ConsumiendoWCF.ServiceHospital.MedicamentoCLS recuperarMedicamento(int iiMedicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHospital/recuperarMedicamento", ReplyAction="http://tempuri.org/IServiceHospital/recuperarMedicamentoResponse")]
        System.Threading.Tasks.Task<ConsumiendoWCF.ServiceHospital.MedicamentoCLS> recuperarMedicamentoAsync(int iiMedicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHospital/agregarYActualizarMedicamento", ReplyAction="http://tempuri.org/IServiceHospital/agregarYActualizarMedicamentoResponse")]
        int agregarYActualizarMedicamento(ConsumiendoWCF.ServiceHospital.MedicamentoCLS medicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHospital/agregarYActualizarMedicamento", ReplyAction="http://tempuri.org/IServiceHospital/agregarYActualizarMedicamentoResponse")]
        System.Threading.Tasks.Task<int> agregarYActualizarMedicamentoAsync(ConsumiendoWCF.ServiceHospital.MedicamentoCLS medicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHospital/eliminarMeidcamento", ReplyAction="http://tempuri.org/IServiceHospital/eliminarMeidcamentoResponse")]
        int eliminarMeidcamento(int iidMedicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHospital/eliminarMeidcamento", ReplyAction="http://tempuri.org/IServiceHospital/eliminarMeidcamentoResponse")]
        System.Threading.Tasks.Task<int> eliminarMeidcamentoAsync(int iidMedicamento);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceHospitalChannel : ConsumiendoWCF.ServiceHospital.IServiceHospital, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceHospitalClient : System.ServiceModel.ClientBase<ConsumiendoWCF.ServiceHospital.IServiceHospital>, ConsumiendoWCF.ServiceHospital.IServiceHospital {
        
        public ServiceHospitalClient() {
        }
        
        public ServiceHospitalClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceHospitalClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceHospitalClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceHospitalClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ConsumiendoWCF.ServiceHospital.MedicamentoCLS[] listarMedicamento() {
            return base.Channel.listarMedicamento();
        }
        
        public System.Threading.Tasks.Task<ConsumiendoWCF.ServiceHospital.MedicamentoCLS[]> listarMedicamentoAsync() {
            return base.Channel.listarMedicamentoAsync();
        }
        
        public ConsumiendoWCF.ServiceHospital.FormaFarmaceuticaCLS[] listarFormaceutica() {
            return base.Channel.listarFormaceutica();
        }
        
        public System.Threading.Tasks.Task<ConsumiendoWCF.ServiceHospital.FormaFarmaceuticaCLS[]> listarFormaceuticaAsync() {
            return base.Channel.listarFormaceuticaAsync();
        }
        
        public ConsumiendoWCF.ServiceHospital.MedicamentoCLS recuperarMedicamento(int iiMedicamento) {
            return base.Channel.recuperarMedicamento(iiMedicamento);
        }
        
        public System.Threading.Tasks.Task<ConsumiendoWCF.ServiceHospital.MedicamentoCLS> recuperarMedicamentoAsync(int iiMedicamento) {
            return base.Channel.recuperarMedicamentoAsync(iiMedicamento);
        }
        
        public int agregarYActualizarMedicamento(ConsumiendoWCF.ServiceHospital.MedicamentoCLS medicamento) {
            return base.Channel.agregarYActualizarMedicamento(medicamento);
        }
        
        public System.Threading.Tasks.Task<int> agregarYActualizarMedicamentoAsync(ConsumiendoWCF.ServiceHospital.MedicamentoCLS medicamento) {
            return base.Channel.agregarYActualizarMedicamentoAsync(medicamento);
        }
        
        public int eliminarMeidcamento(int iidMedicamento) {
            return base.Channel.eliminarMeidcamento(iidMedicamento);
        }
        
        public System.Threading.Tasks.Task<int> eliminarMeidcamentoAsync(int iidMedicamento) {
            return base.Channel.eliminarMeidcamentoAsync(iidMedicamento);
        }
    }
}