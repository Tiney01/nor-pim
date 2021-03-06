﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:32:12 PM
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

    public class DefaultPerformanceIssueFetchWithFilter {
        
        public List<DefaultPerformanceIssueFetchWithFilterContract> DefaultPerformanceIssueFetchWithFilterFromDal(List<DefaultPerformanceIssueFetchWithFilterData> dataList) {
           var list = new List<DefaultPerformanceIssueFetchWithFilterContract>();

           foreach (DefaultPerformanceIssueFetchWithFilterData data in dataList) {
               var contract = new DefaultPerformanceIssueFetchWithFilterContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(DefaultPerformanceIssueFetchWithFilterData dalDefaultPerformanceIssueFetchWithFilter, DefaultPerformanceIssueFetchWithFilterContract dataContract) {
            dataContract.DateTime = dalDefaultPerformanceIssueFetchWithFilter.DateTime;
            dataContract.CommandName = dalDefaultPerformanceIssueFetchWithFilter.CommandName;
            dataContract.Milliseconds = dalDefaultPerformanceIssueFetchWithFilter.Milliseconds;
            dataContract.DefaultPerformanceIssueId = dalDefaultPerformanceIssueFetchWithFilter.DefaultPerformanceIssueId;
        }
    }
}
