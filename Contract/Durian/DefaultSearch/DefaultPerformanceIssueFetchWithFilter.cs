﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 11:33:32 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public class DefaultPerformanceIssueFetchWithFilterContract {
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
        
        [DataMember()]
        public string CommandName { get; set; }
        
        [DataMember()]
        public int Milliseconds { get; set; }
        
        [DataMember()]
        public System.Guid DefaultPerformanceIssueId { get; set; }
    }
}