﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Monitoring.MonitorRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MonitorRef.IMonitor")]
    public interface IMonitor {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMonitor/GetRequestNumber", ReplyAction="http://tempuri.org/IMonitor/GetRequestNumberResponse")]
        int GetRequestNumber();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMonitor/GetRequestNumber", ReplyAction="http://tempuri.org/IMonitor/GetRequestNumberResponse")]
        System.Threading.Tasks.Task<int> GetRequestNumberAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMonitor/GetCacheRequestNumber", ReplyAction="http://tempuri.org/IMonitor/GetCacheRequestNumberResponse")]
        int GetCacheRequestNumber();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMonitor/GetCacheRequestNumber", ReplyAction="http://tempuri.org/IMonitor/GetCacheRequestNumberResponse")]
        System.Threading.Tasks.Task<int> GetCacheRequestNumberAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMonitor/GetCacheContent", ReplyAction="http://tempuri.org/IMonitor/GetCacheContentResponse")]
        string[] GetCacheContent();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMonitor/GetCacheContent", ReplyAction="http://tempuri.org/IMonitor/GetCacheContentResponse")]
        System.Threading.Tasks.Task<string[]> GetCacheContentAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMonitorChannel : Monitoring.MonitorRef.IMonitor, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MonitorClient : System.ServiceModel.ClientBase<Monitoring.MonitorRef.IMonitor>, Monitoring.MonitorRef.IMonitor {
        
        public MonitorClient() {
        }
        
        public MonitorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MonitorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MonitorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MonitorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetRequestNumber() {
            return base.Channel.GetRequestNumber();
        }
        
        public System.Threading.Tasks.Task<int> GetRequestNumberAsync() {
            return base.Channel.GetRequestNumberAsync();
        }
        
        public int GetCacheRequestNumber() {
            return base.Channel.GetCacheRequestNumber();
        }
        
        public System.Threading.Tasks.Task<int> GetCacheRequestNumberAsync() {
            return base.Channel.GetCacheRequestNumberAsync();
        }
        
        public string[] GetCacheContent() {
            return base.Channel.GetCacheContent();
        }
        
        public System.Threading.Tasks.Task<string[]> GetCacheContentAsync() {
            return base.Channel.GetCacheContentAsync();
        }
    }
}