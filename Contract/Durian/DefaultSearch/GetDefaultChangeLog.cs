﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:34:29 PM
  From Machine: DESKTOP-KE5CSN3
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public class GetDefaultChangeLogContract {
        
        [DataMember()]
        public string DefaultChangeName { get; set; }
        
        [DataMember()]
        public string DefaultChangeDescription { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
        
        [DataMember()]
        public string DefaultChangeLogTypeRcd { get; set; }
        
        [DataMember()]
        public string DefaultChangeLogTypeName { get; set; }
        
        [DataMember()]
        public System.Guid DefaultIssueId { get; set; }
        
        [DataMember()]
        public string IssueName { get; set; }
        
        [DataMember()]
        public System.Guid DefaultChangeLogId { get; set; }
    }
}
