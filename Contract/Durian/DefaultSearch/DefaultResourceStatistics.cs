﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 11:34:35 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public class DefaultResourceStatisticsContract {
        
        [DataMember()]
        public string HourNumber { get; set; }
        
        [DataMember()]
        public int ClientWorkingsetBytes { get; set; }
        
        [DataMember()]
        public int BusinessWorkingsetBytes { get; set; }
        
        [DataMember()]
        public int DatabaseSizeBytes { get; set; }
    }
}