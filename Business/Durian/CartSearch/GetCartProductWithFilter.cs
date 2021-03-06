﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:37:49 PM
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

    public class GetCartProductWithFilter {
        
        public List<GetCartProductWithFilterContract> GetCartProductWithFilterFromDal(List<GetCartProductWithFilterData> dataList) {
           var list = new List<GetCartProductWithFilterContract>();

           foreach (GetCartProductWithFilterData data in dataList) {
               var contract = new GetCartProductWithFilterContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(GetCartProductWithFilterData dalGetCartProductWithFilter, GetCartProductWithFilterContract dataContract) {
            dataContract.FirstName = dalGetCartProductWithFilter.FirstName;
            dataContract.MiddleName = dalGetCartProductWithFilter.MiddleName;
            dataContract.LastName = dalGetCartProductWithFilter.LastName;
            dataContract.ProductName = dalGetCartProductWithFilter.ProductName;
            dataContract.ImageBlobFilename = dalGetCartProductWithFilter.ImageBlobFilename;
            dataContract.ProductStateRcd = dalGetCartProductWithFilter.ProductStateRcd;
            dataContract.FinancialCurrencyTypeName = dalGetCartProductWithFilter.FinancialCurrencyTypeName;
            dataContract.DefaultUserName = dalGetCartProductWithFilter.DefaultUserName;
            dataContract.ClientId = dalGetCartProductWithFilter.ClientId;
            dataContract.ProductId = dalGetCartProductWithFilter.ProductId;
            dataContract.FinancialCurrencyTypeRcd = dalGetCartProductWithFilter.FinancialCurrencyTypeRcd;
            dataContract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd = dalGetCartProductWithFilter.FinancialCurrencyAgainstFinancialCurrencyTypeRcd;
            dataContract.FinancialCurrencyTypeCode = dalGetCartProductWithFilter.FinancialCurrencyTypeCode;
            dataContract.FinancialCurrencyId = dalGetCartProductWithFilter.FinancialCurrencyId;
            dataContract.Amount = dalGetCartProductWithFilter.Amount;
            dataContract.SessionIdentificator = dalGetCartProductWithFilter.SessionIdentificator;
            dataContract.CartProductStateRcd = dalGetCartProductWithFilter.CartProductStateRcd;
            dataContract.UserId = dalGetCartProductWithFilter.UserId;
            dataContract.DateTime = dalGetCartProductWithFilter.DateTime;
            dataContract.CartProductId = dalGetCartProductWithFilter.CartProductId;
            dataContract.SessionId = dalGetCartProductWithFilter.SessionId;
            dataContract.AspId = dalGetCartProductWithFilter.AspId;
        }
    }
}
