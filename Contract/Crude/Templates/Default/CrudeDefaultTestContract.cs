﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 9:52:31 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class CrudeDefaultTestContract {
        
        [DataMember()]
        public System.Guid DefaultTestId { get; set; }
        
        [DataMember()]
        public string SystemName { get; set; }
        
        [DataMember()]
        public string TestArea { get; set; }
        
        [DataMember()]
        public string TestSubArea { get; set; }
        
        [DataMember()]
        public string TestAddress { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
