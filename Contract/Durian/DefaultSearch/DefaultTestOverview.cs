﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 5:07:43 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public class DefaultTestOverviewContract {
        
        [DataMember()]
        public string TestArea { get; set; }
        
        [DataMember()]
        public System.DateTime StartDateTime { get; set; }
        
        [DataMember()]
        public string DefaultTestRunResultRcd { get; set; }
    }
}
