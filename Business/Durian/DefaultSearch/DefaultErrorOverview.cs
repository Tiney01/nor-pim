﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 11:33:40 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultErrorOverview {
        
        public List<DefaultErrorOverviewContract> DefaultErrorOverviewFromDal(List<DefaultErrorOverviewData> dataList) {
           var list = new List<DefaultErrorOverviewContract>();

           foreach (DefaultErrorOverviewData data in dataList) {
               var contract = new DefaultErrorOverviewContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(DefaultErrorOverviewData dalDefaultErrorOverview, DefaultErrorOverviewContract dataContract) {
            dataContract.DefaultErrorId = dalDefaultErrorOverview.DefaultErrorId;
            dataContract.DateTime = dalDefaultErrorOverview.DateTime;
            dataContract.DefaultErrorLayerName = dalDefaultErrorOverview.DefaultErrorLayerName;
            dataContract.DefaultErrorTypeName = dalDefaultErrorOverview.DefaultErrorTypeName;
            dataContract.DomainName = dalDefaultErrorOverview.DomainName;
            dataContract.ClassName = dalDefaultErrorOverview.ClassName;
            dataContract.MethodName = dalDefaultErrorOverview.MethodName;
            dataContract.ErrorMessage = dalDefaultErrorOverview.ErrorMessage;
        }
    }
}