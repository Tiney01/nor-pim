﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace norpim.UserInterface.GatherProxy {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GatherProxy.IGatherService")]
    public interface IGatherService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGatherService/Start", ReplyAction="http://tempuri.org/IGatherService/StartResponse")]
        void Start(System.Guid systemOwnedId, System.Guid userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGatherServiceChannel : norpim.UserInterface.GatherProxy.IGatherService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GatherServiceClient : System.ServiceModel.ClientBase<norpim.UserInterface.GatherProxy.IGatherService>, norpim.UserInterface.GatherProxy.IGatherService {
        
        public GatherServiceClient() {
        }
        
        public GatherServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GatherServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GatherServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GatherServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Start(System.Guid systemOwnedId, System.Guid userId) {
            base.Channel.Start(systemOwnedId, userId);
        }
    }
}
