﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 6:52:13 PM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultUserActivityGroupedByAddress {
        
        public List<DefaultUserActivityGroupedByAddressContract> DefaultUserActivityGroupedByAddressFromDal(List<DefaultUserActivityGroupedByAddressData> dataList) {
           var list = new List<DefaultUserActivityGroupedByAddressContract>();

           foreach (DefaultUserActivityGroupedByAddressData data in dataList) {
               var contract = new DefaultUserActivityGroupedByAddressContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(DefaultUserActivityGroupedByAddressData dalDefaultUserActivityGroupedByAddress, DefaultUserActivityGroupedByAddressContract dataContract) {
            dataContract.OriginatingAddress = dalDefaultUserActivityGroupedByAddress.OriginatingAddress;
            dataContract.Occurrences = dalDefaultUserActivityGroupedByAddress.Occurrences;
        }
    }
}
