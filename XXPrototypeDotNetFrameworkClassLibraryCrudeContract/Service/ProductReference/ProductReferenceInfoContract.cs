/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:37:18 AM
  Template: sql2x.TemplateByServiceTableCrudGenerator.ContractUsing
*/
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class ProductReferenceInfoContract {
        
        [DataMember()]
        public List<CrudeProductInfoRefContract> ProductInfoRef { get; set; } //;
        
        [DataMember()]
        public CrudeProductInfoRefContract ProductInfoRefNew { get; set; } //;
        
        [DataMember()]
        public int ChecksumAfterGet { get; set; } //;
        
        // Gets checksum from parent and children
        public int Checksum() {
            // check parent
            int hash = new {
            }.GetHashCode();

              foreach (CrudeProductInfoRefContract productInfoRef in ProductInfoRef)
                  hash += new {
                      productInfoRef.ProductInfoRcd,
                      productInfoRef.ProductInfoName                  
                  }.GetHashCode();

            return hash;
        }
    }
}