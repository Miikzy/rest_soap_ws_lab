﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientConsole.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Contract", Namespace="http://schemas.datacontract.org/2004/07/IWS_Soap")]
    [System.SerializableAttribute()]
    public partial class Contract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string country_codeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
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
        public string country_code {
            get {
                return this.country_codeField;
            }
            set {
                if ((object.ReferenceEquals(this.country_codeField, value) != true)) {
                    this.country_codeField = value;
                    this.RaisePropertyChanged("country_code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Station", Namespace="http://schemas.datacontract.org/2004/07/IWS_Soap")]
    [System.SerializableAttribute()]
    public partial class Station : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int available_bike_standsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int available_bikesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int bike_standsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string contact_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int numberField;
        
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
        public string address {
            get {
                return this.addressField;
            }
            set {
                if ((object.ReferenceEquals(this.addressField, value) != true)) {
                    this.addressField = value;
                    this.RaisePropertyChanged("address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int available_bike_stands {
            get {
                return this.available_bike_standsField;
            }
            set {
                if ((this.available_bike_standsField.Equals(value) != true)) {
                    this.available_bike_standsField = value;
                    this.RaisePropertyChanged("available_bike_stands");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int available_bikes {
            get {
                return this.available_bikesField;
            }
            set {
                if ((this.available_bikesField.Equals(value) != true)) {
                    this.available_bikesField = value;
                    this.RaisePropertyChanged("available_bikes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int bike_stands {
            get {
                return this.bike_standsField;
            }
            set {
                if ((this.bike_standsField.Equals(value) != true)) {
                    this.bike_standsField = value;
                    this.RaisePropertyChanged("bike_stands");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string contact_name {
            get {
                return this.contact_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.contact_nameField, value) != true)) {
                    this.contact_nameField = value;
                    this.RaisePropertyChanged("contact_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int number {
            get {
                return this.numberField;
            }
            set {
                if ((this.numberField.Equals(value) != true)) {
                    this.numberField = value;
                    this.RaisePropertyChanged("number");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCities", ReplyAction="http://tempuri.org/IService1/GetCitiesResponse")]
        ClientConsole.ServiceReference1.Contract[] GetCities();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCities", ReplyAction="http://tempuri.org/IService1/GetCitiesResponse")]
        System.Threading.Tasks.Task<ClientConsole.ServiceReference1.Contract[]> GetCitiesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStationsByCity", ReplyAction="http://tempuri.org/IService1/GetStationsByCityResponse")]
        ClientConsole.ServiceReference1.Station[] GetStationsByCity(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStationsByCity", ReplyAction="http://tempuri.org/IService1/GetStationsByCityResponse")]
        System.Threading.Tasks.Task<ClientConsole.ServiceReference1.Station[]> GetStationsByCityAsync(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetInfoByStation", ReplyAction="http://tempuri.org/IService1/GetInfoByStationResponse")]
        ClientConsole.ServiceReference1.Station GetInfoByStation(string name, string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetInfoByStation", ReplyAction="http://tempuri.org/IService1/GetInfoByStationResponse")]
        System.Threading.Tasks.Task<ClientConsole.ServiceReference1.Station> GetInfoByStationAsync(string name, string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RefreshCache", ReplyAction="http://tempuri.org/IService1/RefreshCacheResponse")]
        void RefreshCache(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RefreshCache", ReplyAction="http://tempuri.org/IService1/RefreshCacheResponse")]
        System.Threading.Tasks.Task RefreshCacheAsync(string city);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ClientConsole.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ClientConsole.ServiceReference1.IService1>, ClientConsole.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClientConsole.ServiceReference1.Contract[] GetCities() {
            return base.Channel.GetCities();
        }
        
        public System.Threading.Tasks.Task<ClientConsole.ServiceReference1.Contract[]> GetCitiesAsync() {
            return base.Channel.GetCitiesAsync();
        }
        
        public ClientConsole.ServiceReference1.Station[] GetStationsByCity(string city) {
            return base.Channel.GetStationsByCity(city);
        }
        
        public System.Threading.Tasks.Task<ClientConsole.ServiceReference1.Station[]> GetStationsByCityAsync(string city) {
            return base.Channel.GetStationsByCityAsync(city);
        }
        
        public ClientConsole.ServiceReference1.Station GetInfoByStation(string name, string city) {
            return base.Channel.GetInfoByStation(name, city);
        }
        
        public System.Threading.Tasks.Task<ClientConsole.ServiceReference1.Station> GetInfoByStationAsync(string name, string city) {
            return base.Channel.GetInfoByStationAsync(name, city);
        }
        
        public void RefreshCache(string city) {
            base.Channel.RefreshCache(city);
        }
        
        public System.Threading.Tasks.Task RefreshCacheAsync(string city) {
            return base.Channel.RefreshCacheAsync(city);
        }
    }
}
