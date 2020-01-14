/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:23:49 AM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeProductCategoryContract {
        
        [DataMember()]
        public System.Guid ProductCategoryId { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductCategoryBecameId { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductCategoryParentId { get; set; } //;
        
        [DataMember()]
        public string ProductCategoryCode { get; set; } //;
        
        [DataMember()]
        public string ProductCategoryName { get; set; } //;
        
        [DataMember()]
        public int ProductCategoryPosition { get; set; } //;
        
        [DataMember()]
        public string StateRcd { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
}