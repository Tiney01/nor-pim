/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 2:56:57 PM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeDefaultErrorTypeRefContract {
        
        [DataMember()]
        public string DefaultErrorTypeRcd { get; set; } //;
        
        [DataMember()]
        public string DefaultErrorTypeName { get; set; } //;
        
        [DataMember()]
        public System.Guid DefaultUserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
}
