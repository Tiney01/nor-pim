﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 9:16:16 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class ProductReferenceAttributeUnitSearchWithFilter {
        
        public List<ProductReferenceAttributeUnitSearchWithFilterContract> ProductReferenceAttributeUnitSearchWithFilterFromDal(List<ProductReferenceAttributeUnitSearchWithFilterData> dataList) {
           var list = new List<ProductReferenceAttributeUnitSearchWithFilterContract>();

           foreach (ProductReferenceAttributeUnitSearchWithFilterData data in dataList) {
               var contract = new ProductReferenceAttributeUnitSearchWithFilterContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(ProductReferenceAttributeUnitSearchWithFilterData dalProductReferenceAttributeUnitSearchWithFilter, ProductReferenceAttributeUnitSearchWithFilterContract dataContract) {
            dataContract.ProductAttributeUnitName = dalProductReferenceAttributeUnitSearchWithFilter.ProductAttributeUnitName;
            dataContract.ProductAttributeUnitRcd = dalProductReferenceAttributeUnitSearchWithFilter.ProductAttributeUnitRcd;
            dataContract.DateTime = dalProductReferenceAttributeUnitSearchWithFilter.DateTime;
        }
    }
}
