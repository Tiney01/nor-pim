﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:21:04 PM
  From Machine: DESKTOP-KE5CSN3
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class CrudeClientLinkContract {
        
        [DataMember()]
        public System.Guid ClientLinkId { get; set; }
        
        [DataMember()]
        public System.Guid ClientId { get; set; }
        
        [DataMember()]
        public string ClientLinkTypeRcd { get; set; }
        
        [DataMember()]
        public string LinkName { get; set; }
        
        [DataMember()]
        public string Link { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
