﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 9/12/2020 3:38:00 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class CrudeProductGatherAttributeContract {
        
        [DataMember()]
        public System.Guid ProductGatherAttributeId { get; set; }
        
        [DataMember()]
        public string ProductGatherAttributeValue { get; set; }
        
        [DataMember()]
        public string ProductGatherAttributeTypeRcd { get; set; }
        
        [DataMember()]
        public System.Guid ProductGatherKeyId { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
