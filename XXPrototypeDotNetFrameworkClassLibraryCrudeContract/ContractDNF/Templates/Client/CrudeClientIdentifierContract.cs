/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:21:35 PM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeClientIdentifierContract {
        
        [DataMember()]
        public System.Guid ClientIdentifierId { get; set; } //;
        
        [DataMember()]
        public System.Guid ClientId { get; set; } //;
        
        [DataMember()]
        public string ClientIdentifierTypeRcd { get; set; } //;
        
        [DataMember()]
        public string ClientIdentifierCode { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
}
