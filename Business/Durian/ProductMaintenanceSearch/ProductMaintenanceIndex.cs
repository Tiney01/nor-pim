﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:38:02 PM
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

    public class ProductMaintenanceIndex {
        
        public List<ProductMaintenanceIndexContract> ProductMaintenanceIndexFromDal(List<ProductMaintenanceIndexData> dataList) {
           var list = new List<ProductMaintenanceIndexContract>();

           foreach (ProductMaintenanceIndexData data in dataList) {
               var contract = new ProductMaintenanceIndexContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(ProductMaintenanceIndexData dalProductMaintenanceIndex, ProductMaintenanceIndexContract dataContract) {
            dataContract.ProductName = dalProductMaintenanceIndex.ProductName;
            dataContract.StateRcd = dalProductMaintenanceIndex.StateRcd;
            dataContract.UserId = dalProductMaintenanceIndex.UserId;
            dataContract.DateTime = dalProductMaintenanceIndex.DateTime;
            dataContract.ProductId = dalProductMaintenanceIndex.ProductId;
            dataContract.DefaultUserName = dalProductMaintenanceIndex.DefaultUserName;
        }
    }
}
