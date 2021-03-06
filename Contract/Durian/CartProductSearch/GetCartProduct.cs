﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:30:55 PM
  From Machine: DESKTOP-KE5CSN3
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public class GetCartProductContract {
        
        [DataMember()]
        public System.Guid ClientId { get; set; }
        
        [DataMember()]
        public string ProductName { get; set; }
        
        [DataMember()]
        public string ProductStateRcd { get; set; }
        
        [DataMember()]
        public System.Guid ProductId { get; set; }
        
        [DataMember()]
        public string FinancialCurrencyTypeRcd { get; set; }
        
        [DataMember()]
        public string FinancialCurrencyAgainstFinancialCurrencyTypeRcd { get; set; }
        
        [DataMember()]
        public string FinancialCurrencyTypeCode { get; set; }
        
        [DataMember()]
        public string FinancialCurrencyTypeName { get; set; }
        
        [DataMember()]
        public System.Guid FinancialCurrencyId { get; set; }
        
        [DataMember()]
        public decimal Amount { get; set; }
        
        [DataMember()]
        public string CartProductStateRcd { get; set; }
        
        [DataMember()]
        public string ImageBlobFilename { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public string DefaultUserName { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
        
        [DataMember()]
        public System.Guid CartProductId { get; set; }
        
        [DataMember()]
        public string SessionIdentificator { get; set; }
    }
}
