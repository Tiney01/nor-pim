/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:53:24 PM
  Template: sql2x.TemplateByServiceTableCrudGenerator.ProxyUsing
*/
using System;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IProductReferenceCategoryService")]
    public partial interface IProductReferenceCategoryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductReferenceCategoryService/ProductReferenceCategoryCompl" +
            "eteGet", ReplyAction="http://tempuri.org/IProductReferenceCategoryService/ProductReferenceCategoryCompl" +
            "eteGetResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceCategoryContract ProductReferenceCategoryCompleteGet(System.Guid productCategoryId, System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductReferenceCategoryService/ProductReferenceCategoryCompl" +
            "eteUpdate", ReplyAction="http://tempuri.org/IProductReferenceCategoryService/ProductReferenceCategoryCompl" +
            "eteUpdateResponse")]
        System.Guid ProductReferenceCategoryCompleteUpdate(System.Guid productCategoryId, SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceCategoryContract productContract, System.Guid userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductReferenceCategoryServiceChannel : IProductReferenceCategoryService, System.ServiceModel.IClientChannel {
    }
    
    public class ProductReferenceCategoryServiceClient : System.ServiceModel.ClientBase<IProductReferenceCategoryService>, IProductReferenceCategoryService {
        
        public ProductReferenceCategoryServiceClient() {
        }
        
        public ProductReferenceCategoryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductReferenceCategoryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductReferenceCategoryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductReferenceCategoryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceCategoryContract ProductReferenceCategoryCompleteGet(System.Guid productCategoryId, System.Guid userId) {
            return base.Channel.ProductReferenceCategoryCompleteGet(productCategoryId, userId);
        }
        
        public System.Guid ProductReferenceCategoryCompleteUpdate(System.Guid productCategoryId, SolutionNorSolutionPim.BusinessLogicLayer.ProductReferenceCategoryContract productContract, System.Guid userId) {
            return base.Channel.ProductReferenceCategoryCompleteUpdate(productCategoryId, productContract, userId);
        }
    }
}
