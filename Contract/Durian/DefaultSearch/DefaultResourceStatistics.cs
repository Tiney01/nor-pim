﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 5:08:41 PM
  From Machine: DESKTOP-742U247
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
