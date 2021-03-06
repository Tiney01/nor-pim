/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:31:16 PM
  From Machine: DESKTOP-KE5CSN3
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICartSearchService")]
    public interface ICartSearchService {
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartSearchService/GetCartProductWithFilter", ReplyAction="http://tempuri.org/ICartSearchService/GetCartProductWithFilterResponse")]
        List<GetCartProductWithFilterContract> GetCartProductWithFilter ();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICartSearchServiceChannel : ICartSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class CartSearchService : System.ServiceModel.ClientBase<ICartSearchService>, ICartSearchService {
        public List<GetCartProductWithFilterContract> GetCartProductWithFilter () {
            return base.Channel.GetCartProductWithFilter();
        }
        
        public CartSearchService() {
        }
        
        public CartSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CartSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CartSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CartSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
