/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:34:23 AM
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [ServiceContract()]
    public partial interface ICartSearchService
    {
        [OperationContract()]
        List<GetCartProductWithFilterContract> GetCartProductWithFilter();
    }

    public partial class CartSearchService : ICartSearchService
    {
        public List<GetCartProductWithFilterContract> GetCartProductWithFilter()
        {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.CartSearch();
            var businessLogicLayer = new GetCartProductWithFilter();
            return businessLogicLayer.GetCartProductWithFilterFromDal(dataAccessLayer.GetCartProductWithFilter());
        }
    }
}