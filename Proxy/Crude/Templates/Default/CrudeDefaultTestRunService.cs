﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:21:43 PM
  From Machine: DESKTOP-KE5CSN3
  Filename: DefaultTestRun.json
  MethodName: sql2x.TemplateCrudeProxy.CrudeProxy
  Template Style: DotNetFrameworkCrudeProxy
  Documentation:
    WCF Client Proxy layer for accessing Azure Storage Tables through
      CIFUDE ( Create Insert Fetch Update Delete and Extra Operations )
      Works for dotNetFramework
*/
using System.Runtime.Serialization;
using System.Collections.Generic;

// Client Proxy Layer
// the ClientProxyLayer is where the SOAP services ties into the Client layer
//  this layer is used for, among other technologies, dotNetFramework WinForm,
//  ASP and TypeScript User Interfaces or from one business layer to another
// links:
//   https://en.wikipedia.org/wiki/Business_logic: business logic layer
//   https://www.c-sharpcorner.com/UploadFile/8a67c0/proxy-class-for-the-wcf-service/: client Proxy
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // this interface is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultTestRunService")]
    public partial interface ICrudeDefaultTestRunService {
        
        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchByDefaultTestRunId", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchByDefaultTestRunIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract FetchByDefaultTestRunId(System.Guid defaultTestRunId);
        
        // fetch all rows matching foreign key: DefaultTestId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchByDefaultTestId", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchByDefaultTestIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchByDefaultTestId(System.Guid defaultTestId);
        
        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchByUserId(System.Guid userId);
        
        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchByDefaultTestRunResultRcd", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchByDefaultTestRunResultRcdResp" +
            "onse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchByDefaultTestRunResultRcd(string defaultTestRunResultRcd);
        
        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract contract);
        
        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract contract);
        
        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/DeleteResponse")]
        void Delete(System.Guid defaultTestRunId);
        
        // fetch all rows from table default_test_run into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchAll();
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchAllWithLimit(int limit);
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchAllWithLimitAndOffsetResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchAllCountResponse")]
        int FetchAllCount();
        
        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchWithFilter(System.Guid defaultTestRunId, System.Guid defaultTestId, string defaultTestRunResultRcd, string result, System.DateTime startDateTime, System.DateTime endDateTime, int elapsedMilliseconds, System.Guid userId, System.DateTime dateTime);
    }
    
    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultTestRunServiceChannel : ICrudeDefaultTestRunService, System.ServiceModel.IClientChannel {
    }
    
    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeDefaultTestRunServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultTestRunService>, ICrudeDefaultTestRunService {
        
        public CrudeDefaultTestRunServiceClient() {
        }
        
        // constructors for end point address, binding and contracts
        public CrudeDefaultTestRunServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultTestRunServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultTestRunServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultTestRunServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract FetchByDefaultTestRunId(System.Guid defaultTestRunId) {
            return base.Channel.FetchByDefaultTestRunId(defaultTestRunId);
        }
        
        // fetch all rows matching foreign key: DefaultTestId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchByDefaultTestId(System.Guid defaultTestId) {
            return base.Channel.FetchByDefaultTestId(defaultTestId);
        }
        
        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        // fetch all rows matching foreign key: DefaultTestRunResultRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchByDefaultTestRunResultRcd(string defaultTestRunResultRcd) {
            return base.Channel.FetchByDefaultTestRunResultRcd(defaultTestRunResultRcd);
        }
        
        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract contract) {
            base.Channel.Insert(contract);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract contract) {
            base.Channel.Update(contract);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid defaultTestRunId) {
            base.Channel.Delete(defaultTestRunId);
        }
        
        // fetch all rows from table default_test_run into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchWithFilter(System.Guid defaultTestRunId, System.Guid defaultTestId, string defaultTestRunResultRcd, string result, System.DateTime startDateTime, System.DateTime endDateTime, int elapsedMilliseconds, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultTestRunId: defaultTestRunId,
                defaultTestId: defaultTestId,
                defaultTestRunResultRcd: defaultTestRunResultRcd,
                result: result,
                startDateTime: startDateTime,
                endDateTime: endDateTime,
                elapsedMilliseconds: elapsedMilliseconds,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
