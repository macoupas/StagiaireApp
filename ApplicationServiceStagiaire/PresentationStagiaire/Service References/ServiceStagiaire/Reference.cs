﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PresentationStagiaire.ServiceStagiaire {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceStagiaire.IServiceStagiaire")]
    public interface IServiceStagiaire {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/ListAllStagiaire", ReplyAction="http://tempuri.org/IServiceStagiaire/ListAllStagiaireResponse")]
        Core.ResponseData<Core.StagiaireDTO[]> ListAllStagiaire();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/ListAllStagiaire", ReplyAction="http://tempuri.org/IServiceStagiaire/ListAllStagiaireResponse")]
        System.Threading.Tasks.Task<Core.ResponseData<Core.StagiaireDTO[]>> ListAllStagiaireAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceStagiaireChannel : PresentationStagiaire.ServiceStagiaire.IServiceStagiaire, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceStagiaireClient : System.ServiceModel.ClientBase<PresentationStagiaire.ServiceStagiaire.IServiceStagiaire>, PresentationStagiaire.ServiceStagiaire.IServiceStagiaire {
        
        public ServiceStagiaireClient() {
        }
        
        public ServiceStagiaireClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceStagiaireClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceStagiaireClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceStagiaireClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Core.ResponseData<Core.StagiaireDTO[]> ListAllStagiaire() {
            return base.Channel.ListAllStagiaire();
        }
        
        public System.Threading.Tasks.Task<Core.ResponseData<Core.StagiaireDTO[]>> ListAllStagiaireAsync() {
            return base.Channel.ListAllStagiaireAsync();
        }
    }
}