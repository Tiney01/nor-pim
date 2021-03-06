﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:34:48 PM
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

    public class DefaultResourceDatabaseStatistics {
        
        public List<DefaultResourceDatabaseStatisticsContract> DefaultResourceDatabaseStatisticsFromDal(List<DefaultResourceDatabaseStatisticsData> dataList) {
           var list = new List<DefaultResourceDatabaseStatisticsContract>();

           foreach (DefaultResourceDatabaseStatisticsData data in dataList) {
               var contract = new DefaultResourceDatabaseStatisticsContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(DefaultResourceDatabaseStatisticsData dalDefaultResourceDatabaseStatistics, DefaultResourceDatabaseStatisticsContract dataContract) {
            dataContract.ReservedPageCount = dalDefaultResourceDatabaseStatistics.ReservedPageCount;
        }
    }
}
