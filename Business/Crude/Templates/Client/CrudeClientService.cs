﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:40:05 AM
  From Machine: DESKTOP-517I8BU
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
    public partial interface ICrudeClientService {
        
        [OperationContract()]
        CrudeClientContract FetchByClientId(System.Guid clientId);
        
        [OperationContract()]
        List<CrudeClientContract> FetchByClientAddressId(System.Guid clientAddressId);
        
        [OperationContract()]
        List<CrudeClientContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeClientContract> FetchByClientTypeRcd(string clientTypeRcd);
        
        [OperationContract()]
        List<CrudeClientContract> FetchByClientNationalityRcd(string clientNationalityRcd);
        
        [OperationContract()]
        List<CrudeClientContract> FetchByClientGenderRcd(string clientGenderRcd);
        
        [OperationContract()]
        List<CrudeClientContract> FetchByClientTitleRcd(string clientTitleRcd);
        
        [OperationContract()]
        CrudeClientContract FetchByFirstName(string firstName);
        
        [OperationContract()]
        List<CrudeClientContract> FetchWithFilter(System.Guid clientId, string clientTypeRcd, string clientNationalityRcd, string clientGenderRcd, string clientTitleRcd, System.Guid clientAddressId, string firstName, string middleName, string lastName, byte[] image, string imageBlobFilename, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientContract contract);
        
        [OperationContract()]
        void Update(CrudeClientContract contract);
        
        [OperationContract()]
        void Delete(System.Guid clientId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of client's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeClientService : ICrudeClientService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   clientId: primary key of table client
        public CrudeClientContract FetchByClientId(System.Guid clientId) {
            var dataAccessLayer = new CrudeClientData();
            var contract = new CrudeClientContract();

            dataAccessLayer.FetchByClientId(clientId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientContract FetchByFirstName(string firstName) {
            var dataAccessLayer = new CrudeClientData();
            var contract = new CrudeClientContract();

            dataAccessLayer.FetchByFirstName(firstName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientContract> FetchByClientAddressId(System.Guid clientAddressId) {
            return DataListToContractList(CrudeClientData.FetchByClientAddressId(clientAddressId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientContract> FetchByClientTypeRcd(string clientTypeRcd) {
            return DataListToContractList(CrudeClientData.FetchByClientTypeRcd(clientTypeRcd));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientContract> FetchByClientNationalityRcd(string clientNationalityRcd) {
            return DataListToContractList(CrudeClientData.FetchByClientNationalityRcd(clientNationalityRcd));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientContract> FetchByClientGenderRcd(string clientGenderRcd) {
            return DataListToContractList(CrudeClientData.FetchByClientGenderRcd(clientGenderRcd));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientContract> FetchByClientTitleRcd(string clientTitleRcd) {
            return DataListToContractList(CrudeClientData.FetchByClientTitleRcd(clientTitleRcd));
        }
        
        public static List<CrudeClientContract> DataListToContractList(List<CrudeClientData> dataList) {
            var contractList = new List<CrudeClientContract>();

            foreach (CrudeClientData data in dataList) {
                var contract = new CrudeClientContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeClientContract> contractList, List<CrudeClientData> dataList) {
            foreach (CrudeClientContract contract in contractList) {
                var data = new CrudeClientData();
                CrudeClientService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientContract> FetchAll() {
            var list = new List<CrudeClientContract>();
            List<CrudeClientData> dataList = CrudeClientData.FetchAll();

            foreach (CrudeClientData crudeClient in dataList) {
                var contract = new CrudeClientContract();
                DataToContract(crudeClient, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientContract>();
            List<CrudeClientData> dataList = CrudeClientData.FetchAllWithLimit(limit);

            foreach (CrudeClientData crudeClient in dataList) {
                var contract = new CrudeClientContract();
                DataToContract(crudeClient, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientContract>();
            List<CrudeClientData> dataList = CrudeClientData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientData crudeClient in dataList) {
                var contract = new CrudeClientContract();
                DataToContract(crudeClient, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientData.FetchAllCount();
        }
        
        public List<CrudeClientContract> FetchWithFilter(System.Guid clientId, string clientTypeRcd, string clientNationalityRcd, string clientGenderRcd, string clientTitleRcd, System.Guid clientAddressId, string firstName, string middleName, string lastName, byte[] image, string imageBlobFilename, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientContract>();
            List<CrudeClientData> dataList = CrudeClientData.FetchWithFilter(
                clientId: clientId,
                clientTypeRcd: clientTypeRcd,
                clientNationalityRcd: clientNationalityRcd,
                clientGenderRcd: clientGenderRcd,
                clientTitleRcd: clientTitleRcd,
                clientAddressId: clientAddressId,
                firstName: firstName,
                middleName: middleName,
                lastName: lastName,
                image: image,
                imageBlobFilename: imageBlobFilename,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientData data in dataList) {
                var crudeClientContract = new CrudeClientContract();
                DataToContract(data, crudeClientContract);
                list.Add(crudeClientContract);
            }

            return list;
        }
        
        public void Insert(CrudeClientContract contract) {
            var data = new CrudeClientData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientContract contract) {
            var data = new CrudeClientData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeClientContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid clientId) {
            CrudeClientData.Delete(clientId);
        }
        
        public static void ContractToData(CrudeClientContract contract, CrudeClientData data) {
            data.ClientId = contract.ClientId;
            data.ClientTypeRcd = contract.ClientTypeRcd;
            data.ClientNationalityRcd = contract.ClientNationalityRcd;
            data.ClientGenderRcd = contract.ClientGenderRcd;
            data.ClientTitleRcd = contract.ClientTitleRcd;
            data.ClientAddressId = contract.ClientAddressId;
            data.FirstName = contract.FirstName;
            data.MiddleName = contract.MiddleName;
            data.LastName = contract.LastName;
            data.Image = contract.Image;
            data.ImageBlobFilename = contract.ImageBlobFilename;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeClientData data, CrudeClientContract contract) {
            contract.ClientId = data.ClientId;
            contract.ClientTypeRcd = data.ClientTypeRcd;
            contract.ClientNationalityRcd = data.ClientNationalityRcd;
            contract.ClientGenderRcd = data.ClientGenderRcd;
            contract.ClientTitleRcd = data.ClientTitleRcd;
            contract.ClientAddressId = data.ClientAddressId;
            contract.FirstName = data.FirstName;
            contract.MiddleName = data.MiddleName;
            contract.LastName = data.LastName;
            contract.Image = data.Image;
            contract.ImageBlobFilename = data.ImageBlobFilename;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
