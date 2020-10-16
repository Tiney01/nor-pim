﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 1:21:07 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateCrudeSoap.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel.Activation;
using SolutionNorSolutionPim.DataAccessLayer;

// Business Logic Layer
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  SOAP http services, using Windows Communication Framework
// links:
//   https://en.wikipedia.org/wiki/Business_logic: business logic layer
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // this interface is used to expose C# objects as SOAP services using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [ServiceContract()]
    public partial interface ICrudeProductImageTypeRefService {
        
        [OperationContract()]
        CrudeProductImageTypeRefContract FetchByProductImageTypeRcd(string productImageTypeRcd);
        
        [OperationContract()]
        List<CrudeProductImageTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductImageTypeRefContract FetchByProductImageTypeName(string productImageTypeName);
        
        [OperationContract()]
        List<CrudeProductImageTypeRefContract> FetchWithFilter(string productImageTypeRcd, string productImageTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductImageTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductImageTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductImageTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductImageTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductImageTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string productImageTypeRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_image_type_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductImageTypeRefService : ICrudeProductImageTypeRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productImageTypeRcd: primary key of table product_image_type_ref
        public CrudeProductImageTypeRefContract FetchByProductImageTypeRcd(string productImageTypeRcd) {
            var dataAccessLayer = new CrudeProductImageTypeRefData();
            var contract = new CrudeProductImageTypeRefContract();

            dataAccessLayer.FetchByProductImageTypeRcd(productImageTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductImageTypeRefContract FetchByProductImageTypeName(string productImageTypeName) {
            var dataAccessLayer = new CrudeProductImageTypeRefData();
            var contract = new CrudeProductImageTypeRefContract();

            dataAccessLayer.FetchByProductImageTypeName(productImageTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductImageTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductImageTypeRefData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductImageTypeRefContract> DataListToContractList(List<CrudeProductImageTypeRefData> dataList) {
            var contractList = new List<CrudeProductImageTypeRefContract>();

            foreach (CrudeProductImageTypeRefData data in dataList) {
                var contract = new CrudeProductImageTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductImageTypeRefContract> contractList, List<CrudeProductImageTypeRefData> dataList) {
            foreach (CrudeProductImageTypeRefContract contract in contractList) {
                var data = new CrudeProductImageTypeRefData();
                CrudeProductImageTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductImageTypeRefData to a List of SOAP Contracts
        public List<CrudeProductImageTypeRefContract> FetchAll() {
            var list = new List<CrudeProductImageTypeRefContract>();
            List<CrudeProductImageTypeRefData> dataList = CrudeProductImageTypeRefData.FetchAll();

            foreach (CrudeProductImageTypeRefData crudeProductImageTypeRef in dataList) {
                var contract = new CrudeProductImageTypeRefContract();
                DataToContract(crudeProductImageTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductImageTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductImageTypeRefContract>();
            List<CrudeProductImageTypeRefData> dataList = CrudeProductImageTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeProductImageTypeRefData crudeProductImageTypeRef in dataList) {
                var contract = new CrudeProductImageTypeRefContract();
                DataToContract(crudeProductImageTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductImageTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductImageTypeRefContract>();
            List<CrudeProductImageTypeRefData> dataList = CrudeProductImageTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductImageTypeRefData crudeProductImageTypeRef in dataList) {
                var contract = new CrudeProductImageTypeRefContract();
                DataToContract(crudeProductImageTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductImageTypeRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductImageTypeRefContract> FetchWithFilter(string productImageTypeRcd, string productImageTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductImageTypeRefContract>();
            List<CrudeProductImageTypeRefData> dataList = CrudeProductImageTypeRefData.FetchWithFilter(
                productImageTypeRcd: productImageTypeRcd,
                productImageTypeName: productImageTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductImageTypeRefData data in dataList) {
                var crudeProductImageTypeRefContract = new CrudeProductImageTypeRefContract();
                DataToContract(data, crudeProductImageTypeRefContract);
                list.Add(crudeProductImageTypeRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductImageTypeRefContract contract) {
            var data = new CrudeProductImageTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductImageTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductImageTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductImageTypeRefContract contract) {
            var data = new CrudeProductImageTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductImageTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductImageTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string productImageTypeRcd) {
            CrudeProductImageTypeRefData.Delete(productImageTypeRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductImageTypeRefContract contract, CrudeProductImageTypeRefData data) {
            data.ProductImageTypeRcd = contract.ProductImageTypeRcd;
            data.ProductImageTypeName = contract.ProductImageTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductImageTypeRefData data, CrudeProductImageTypeRefContract contract) {
            contract.ProductImageTypeRcd = data.ProductImageTypeRcd;
            contract.ProductImageTypeName = data.ProductImageTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
