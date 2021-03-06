/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:35:28 PM
  From Machine: DESKTOP-KE5CSN3
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IProductSearchService")]
    public interface IProductSearchService {
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductSearchService/ProductSearchByCategoryType4", ReplyAction="http://tempuri.org/IProductSearchService/ProductSearchByCategoryType4Response")]
        List<ProductSearchByCategoryType4Contract> ProductSearchByCategoryType4 (System.Guid productCategoryId,System.Boolean onParent);
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductSearchService/ProductSearchByCategoryType3", ReplyAction="http://tempuri.org/IProductSearchService/ProductSearchByCategoryType3Response")]
        List<ProductSearchByCategoryType3Contract> ProductSearchByCategoryType3 (System.Guid productCategoryId,System.Boolean onParent);
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductSearchService/ProductSearchByCategoryType2", ReplyAction="http://tempuri.org/IProductSearchService/ProductSearchByCategoryType2Response")]
        List<ProductSearchByCategoryType2Contract> ProductSearchByCategoryType2 (System.Guid productCategoryId,System.Boolean onParent);
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductSearchService/ProductSearchByCategoryType1", ReplyAction="http://tempuri.org/IProductSearchService/ProductSearchByCategoryType1Response")]
        List<ProductSearchByCategoryType1Contract> ProductSearchByCategoryType1 (System.Guid productCategoryId,System.Boolean onParent);
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductSearchService/ProductSearchByCategoryCode", ReplyAction="http://tempuri.org/IProductSearchService/ProductSearchByCategoryCodeResponse")]
        List<ProductSearchByCategoryCodeContract> ProductSearchByCategoryCode (System.String productCategoryCode,System.Boolean onParent);
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductSearchService/ProductSearchByCategory", ReplyAction="http://tempuri.org/IProductSearchService/ProductSearchByCategoryResponse")]
        List<ProductSearchByCategoryContract> ProductSearchByCategory (System.Guid productCategoryId,System.Boolean onParent);
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductSearchService/ProductSearchById", ReplyAction="http://tempuri.org/IProductSearchService/ProductSearchByIdResponse")]
        ProductSearchByIdContract ProductSearchById (System.Guid productId);
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductSearchService/ProductSearchByName", ReplyAction="http://tempuri.org/IProductSearchService/ProductSearchByNameResponse")]
        List<ProductSearchByNameContract> ProductSearchByName (System.String productName);
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductSearchService/ProductHistory", ReplyAction="http://tempuri.org/IProductSearchService/ProductHistoryResponse")]
        List<ProductHistoryContract> ProductHistory (System.Guid productId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductSearchServiceChannel : IProductSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class ProductSearchService : System.ServiceModel.ClientBase<IProductSearchService>, IProductSearchService {
        public List<ProductSearchByCategoryType4Contract> ProductSearchByCategoryType4 (System.Guid productCategoryId,System.Boolean onParent) {
            return base.Channel.ProductSearchByCategoryType4(productCategoryId, onParent);
        }
        public List<ProductSearchByCategoryType3Contract> ProductSearchByCategoryType3 (System.Guid productCategoryId,System.Boolean onParent) {
            return base.Channel.ProductSearchByCategoryType3(productCategoryId, onParent);
        }
        public List<ProductSearchByCategoryType2Contract> ProductSearchByCategoryType2 (System.Guid productCategoryId,System.Boolean onParent) {
            return base.Channel.ProductSearchByCategoryType2(productCategoryId, onParent);
        }
        public List<ProductSearchByCategoryType1Contract> ProductSearchByCategoryType1 (System.Guid productCategoryId,System.Boolean onParent) {
            return base.Channel.ProductSearchByCategoryType1(productCategoryId, onParent);
        }
        public List<ProductSearchByCategoryCodeContract> ProductSearchByCategoryCode (System.String productCategoryCode,System.Boolean onParent) {
            return base.Channel.ProductSearchByCategoryCode(productCategoryCode, onParent);
        }
        public List<ProductSearchByCategoryContract> ProductSearchByCategory (System.Guid productCategoryId,System.Boolean onParent) {
            return base.Channel.ProductSearchByCategory(productCategoryId, onParent);
        }
        public ProductSearchByIdContract ProductSearchById (System.Guid productId) {
            return base.Channel.ProductSearchById(productId);
        }
        public List<ProductSearchByNameContract> ProductSearchByName (System.String productName) {
            return base.Channel.ProductSearchByName(productName);
        }
        public List<ProductHistoryContract> ProductHistory (System.Guid productId) {
            return base.Channel.ProductHistory(productId);
        }
        
        public ProductSearchService() {
        }
        
        public ProductSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
