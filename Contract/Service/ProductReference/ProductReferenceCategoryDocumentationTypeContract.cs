﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:39:53 PM
  From Machine: DESKTOP-KE5CSN3
  Template: sql2x.TemplateByServiceTableCrudGenerator.ContractUsing
*/
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class ProductReferenceCategoryDocumentationTypeContract {
        
        [DataMember()]
        public List<CrudeProductCategoryDocumentationTypeRefContract> ProductCategoryDocumentationTypeRef { get; set; }
        
        [DataMember()]
        public CrudeProductCategoryDocumentationTypeRefContract ProductCategoryDocumentationTypeRefNew { get; set; }
        
        [DataMember()]
        public int ChecksumAfterGet { get; set; }
        
        // Gets checksum from parent and children
        public int Checksum() {
            // check parent
            int hash = new {
            }.GetHashCode();

              foreach (CrudeProductCategoryDocumentationTypeRefContract productCategoryDocumentationTypeRef in ProductCategoryDocumentationTypeRef)
                  hash += new {
                      productCategoryDocumentationTypeRef.ProductCategoryDocumentationTypeRcd,
                      productCategoryDocumentationTypeRef.ProductCategoryDocumentationTypeName                  
                  }.GetHashCode();

            return hash;
        }
    }
}
