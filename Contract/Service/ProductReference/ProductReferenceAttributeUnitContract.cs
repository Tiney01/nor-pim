﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:39:29 PM
  From Machine: DESKTOP-KE5CSN3
  Template: sql2x.TemplateByServiceTableCrudGenerator.ContractUsing
*/
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class ProductReferenceAttributeUnitContract {
        
        [DataMember()]
        public List<CrudeProductAttributeUnitRefContract> ProductAttributeUnitRef { get; set; }
        
        [DataMember()]
        public CrudeProductAttributeUnitRefContract ProductAttributeUnitRefNew { get; set; }
        
        [DataMember()]
        public int ChecksumAfterGet { get; set; }
        
        // Gets checksum from parent and children
        public int Checksum() {
            // check parent
            int hash = new {
            }.GetHashCode();

              foreach (CrudeProductAttributeUnitRefContract productAttributeUnitRef in ProductAttributeUnitRef)
                  hash += new {
                      productAttributeUnitRef.ProductAttributeUnitRcd,
                      productAttributeUnitRef.ProductAttributeUnitName                  
                  }.GetHashCode();

            return hash;
        }
    }
}
