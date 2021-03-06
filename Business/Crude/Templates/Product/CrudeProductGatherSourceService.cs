﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:21:37 PM
  From Machine: DESKTOP-KE5CSN3
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
    public partial interface ICrudeProductGatherSourceService {
        
        [OperationContract()]
        CrudeProductGatherSourceContract FetchByProductGatherSourceId(System.Guid productGatherSourceId);
        
        [OperationContract()]
        List<CrudeProductGatherSourceContract> FetchByProductGatherId(System.Guid productGatherId);
        
        [OperationContract()]
        List<CrudeProductGatherSourceContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductGatherSourceContract> FetchByProductGatherSourceTypeRcd(string productGatherSourceTypeRcd);
        
        [OperationContract()]
        List<CrudeProductGatherSourceContract> FetchWithFilter(System.Guid productGatherSourceId, System.Guid productGatherId, string productGatherSourceTypeRcd, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductGatherSourceContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductGatherSourceContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductGatherSourceContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductGatherSourceContract contract);
        
        [OperationContract()]
        void Update(CrudeProductGatherSourceContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productGatherSourceId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_gather_source's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductGatherSourceService : ICrudeProductGatherSourceService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productGatherSourceId: primary key of table product_gather_source
        public CrudeProductGatherSourceContract FetchByProductGatherSourceId(System.Guid productGatherSourceId) {
            var dataAccessLayer = new CrudeProductGatherSourceData();
            var contract = new CrudeProductGatherSourceContract();

            dataAccessLayer.FetchByProductGatherSourceId(productGatherSourceId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductGatherSourceContract> FetchByProductGatherId(System.Guid productGatherId) {
            return DataListToContractList(CrudeProductGatherSourceData.FetchByProductGatherId(productGatherId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductGatherSourceContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductGatherSourceData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductGatherSourceContract> FetchByProductGatherSourceTypeRcd(string productGatherSourceTypeRcd) {
            return DataListToContractList(CrudeProductGatherSourceData.FetchByProductGatherSourceTypeRcd(productGatherSourceTypeRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductGatherSourceContract> DataListToContractList(List<CrudeProductGatherSourceData> dataList) {
            var contractList = new List<CrudeProductGatherSourceContract>();

            foreach (CrudeProductGatherSourceData data in dataList) {
                var contract = new CrudeProductGatherSourceContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductGatherSourceContract> contractList, List<CrudeProductGatherSourceData> dataList) {
            foreach (CrudeProductGatherSourceContract contract in contractList) {
                var data = new CrudeProductGatherSourceData();
                CrudeProductGatherSourceService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductGatherSourceData to a List of SOAP Contracts
        public List<CrudeProductGatherSourceContract> FetchAll() {
            var list = new List<CrudeProductGatherSourceContract>();
            List<CrudeProductGatherSourceData> dataList = CrudeProductGatherSourceData.FetchAll();

            foreach (CrudeProductGatherSourceData crudeProductGatherSource in dataList) {
                var contract = new CrudeProductGatherSourceContract();
                DataToContract(crudeProductGatherSource, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductGatherSourceContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductGatherSourceContract>();
            List<CrudeProductGatherSourceData> dataList = CrudeProductGatherSourceData.FetchAllWithLimit(limit);

            foreach (CrudeProductGatherSourceData crudeProductGatherSource in dataList) {
                var contract = new CrudeProductGatherSourceContract();
                DataToContract(crudeProductGatherSource, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductGatherSourceContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductGatherSourceContract>();
            List<CrudeProductGatherSourceData> dataList = CrudeProductGatherSourceData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductGatherSourceData crudeProductGatherSource in dataList) {
                var contract = new CrudeProductGatherSourceContract();
                DataToContract(crudeProductGatherSource, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductGatherSourceData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductGatherSourceContract> FetchWithFilter(System.Guid productGatherSourceId, System.Guid productGatherId, string productGatherSourceTypeRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductGatherSourceContract>();
            List<CrudeProductGatherSourceData> dataList = CrudeProductGatherSourceData.FetchWithFilter(
                productGatherSourceId: productGatherSourceId,
                productGatherId: productGatherId,
                productGatherSourceTypeRcd: productGatherSourceTypeRcd,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductGatherSourceData data in dataList) {
                var crudeProductGatherSourceContract = new CrudeProductGatherSourceContract();
                DataToContract(data, crudeProductGatherSourceContract);
                list.Add(crudeProductGatherSourceContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductGatherSourceContract contract) {
            var data = new CrudeProductGatherSourceData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductGatherSourceContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherSourceData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductGatherSourceContract contract) {
            var data = new CrudeProductGatherSourceData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductGatherSourceContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherSourceData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productGatherSourceId) {
            CrudeProductGatherSourceData.Delete(productGatherSourceId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductGatherSourceContract contract, CrudeProductGatherSourceData data) {
            data.ProductGatherSourceId = contract.ProductGatherSourceId;
            data.ProductGatherId = contract.ProductGatherId;
            data.ProductGatherSourceTypeRcd = contract.ProductGatherSourceTypeRcd;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductGatherSourceData data, CrudeProductGatherSourceContract contract) {
            contract.ProductGatherSourceId = data.ProductGatherSourceId;
            contract.ProductGatherId = data.ProductGatherId;
            contract.ProductGatherSourceTypeRcd = data.ProductGatherSourceTypeRcd;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
