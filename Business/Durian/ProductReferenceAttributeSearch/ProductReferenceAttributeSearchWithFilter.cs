﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:39:16 PM
  From Machine: DESKTOP-KE5CSN3
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class ProductReferenceAttributeSearchWithFilter {
        
        public List<ProductReferenceAttributeSearchWithFilterContract> ProductReferenceAttributeSearchWithFilterFromDal(List<ProductReferenceAttributeSearchWithFilterData> dataList) {
           var list = new List<ProductReferenceAttributeSearchWithFilterContract>();

           foreach (ProductReferenceAttributeSearchWithFilterData data in dataList) {
               var contract = new ProductReferenceAttributeSearchWithFilterContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(ProductReferenceAttributeSearchWithFilterData dalProductReferenceAttributeSearchWithFilter, ProductReferenceAttributeSearchWithFilterContract dataContract) {
            dataContract.ProductAttributeName = dalProductReferenceAttributeSearchWithFilter.ProductAttributeName;
            dataContract.ProductAttributeRcd = dalProductReferenceAttributeSearchWithFilter.ProductAttributeRcd;
            dataContract.DateTime = dalProductReferenceAttributeSearchWithFilter.DateTime;
        }
    }
}
