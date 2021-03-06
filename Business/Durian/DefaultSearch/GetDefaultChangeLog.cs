﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:34:30 PM
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

    public class GetDefaultChangeLog {
        
        public List<GetDefaultChangeLogContract> GetDefaultChangeLogFromDal(List<GetDefaultChangeLogData> dataList) {
           var list = new List<GetDefaultChangeLogContract>();

           foreach (GetDefaultChangeLogData data in dataList) {
               var contract = new GetDefaultChangeLogContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(GetDefaultChangeLogData dalGetDefaultChangeLog, GetDefaultChangeLogContract dataContract) {
            dataContract.DefaultChangeName = dalGetDefaultChangeLog.DefaultChangeName;
            dataContract.DefaultChangeDescription = dalGetDefaultChangeLog.DefaultChangeDescription;
            dataContract.DateTime = dalGetDefaultChangeLog.DateTime;
            dataContract.DefaultChangeLogTypeRcd = dalGetDefaultChangeLog.DefaultChangeLogTypeRcd;
            dataContract.DefaultChangeLogTypeName = dalGetDefaultChangeLog.DefaultChangeLogTypeName;
            dataContract.DefaultIssueId = dalGetDefaultChangeLog.DefaultIssueId;
            dataContract.IssueName = dalGetDefaultChangeLog.IssueName;
            dataContract.DefaultChangeLogId = dalGetDefaultChangeLog.DefaultChangeLogId;
        }
    }
}
