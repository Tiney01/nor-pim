﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 10:52:09 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public class DefaultStatisticsByMonthContract {
        
        [DataMember()]
        public string ActivityDate { get; set; }
        
        [DataMember()]
        public int DayCount { get; set; }
    }
}
