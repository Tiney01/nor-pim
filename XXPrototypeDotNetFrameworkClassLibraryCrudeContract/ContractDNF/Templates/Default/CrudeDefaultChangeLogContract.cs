/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:23:43 AM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeDefaultChangeLogContract {
        
        [DataMember()]
        public System.Guid DefaultChangeLogId { get; set; } //;
        
        [DataMember()]
        public string DefaultChangeName { get; set; } //;
        
        [DataMember()]
        public string DefaultChangeDescription { get; set; } //;
        
        [DataMember()]
        public System.Guid DefaultUserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
        
        [DataMember()]
        public string DefaultChangeLogTypeRcd { get; set; } //;
        
        [DataMember()]
        public System.Guid DefaultIssueId { get; set; } //;
    }
}