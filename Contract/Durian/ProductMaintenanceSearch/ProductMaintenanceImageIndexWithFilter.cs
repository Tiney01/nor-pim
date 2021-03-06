﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:38:52 PM
  From Machine: DESKTOP-KE5CSN3
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public class ProductMaintenanceImageIndexWithFilterContract {
        
        [DataMember()]
        public string ProductName { get; set; }
        
        [DataMember()]
        public string StateRcd { get; set; }
        
        [DataMember()]
        public string ProductImageTypeName { get; set; }
        
        [DataMember()]
        public string ImageFileName { get; set; }
        
        [DataMember()]
        public string DefaultUserName { get; set; }
        
        [DataMember()]
        public System.Guid ProductId { get; set; }
        
        [DataMember()]
        public string ProductImageTypeRcd { get; set; }
        
        [DataMember()]
        public byte[] Image { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
        
        [DataMember()]
        public System.Guid ProductImageId { get; set; }
    }
}
