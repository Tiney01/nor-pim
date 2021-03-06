/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:31:50 PM
  From Machine: DESKTOP-KE5CSN3
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IDefaultSearchService")]
    public interface IDefaultSearchService {
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultResourceDatabaseStatistics", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultResourceDatabaseStatisticsResponse")]
        List<DefaultResourceDatabaseStatisticsContract> DefaultResourceDatabaseStatistics ();
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultResourceStatistics", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultResourceStatisticsResponse")]
        List<DefaultResourceStatisticsContract> DefaultResourceStatistics ();
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/GetDefaultChangeLog", ReplyAction="http://tempuri.org/IDefaultSearchService/GetDefaultChangeLogResponse")]
        List<GetDefaultChangeLogContract> GetDefaultChangeLog (System.String defaultChangeName,System.String defaultChangeLogTypeRcd,System.Guid defaultIssueId,System.Guid defaultChangeLogId);
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultUserListForDashboard", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultUserListForDashboardResponse")]
        List<DefaultUserListForDashboardContract> DefaultUserListForDashboard ();
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultUserList", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultUserListResponse")]
        List<DefaultUserListContract> DefaultUserList ();
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultUserActivityGroupedByAddress", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultUserActivityGroupedByAddressResponse")]
        List<DefaultUserActivityGroupedByAddressContract> DefaultUserActivityGroupedByAddress ();
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultUserActivityGrouped", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultUserActivityGroupedResponse")]
        List<DefaultUserActivityGroupedContract> DefaultUserActivityGrouped ();
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultUserActivityOnAddress", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultUserActivityOnAddressResponse")]
        List<DefaultUserActivityOnAddressContract> DefaultUserActivityOnAddress (System.String originatingAddress);
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultUserActivityRecent", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultUserActivityRecentResponse")]
        List<DefaultUserActivityRecentContract> DefaultUserActivityRecent (System.Guid defaultUserId);
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultPerformanceTimeCommands", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultPerformanceTimeCommandsResponse")]
        List<DefaultPerformanceTimeCommandsContract> DefaultPerformanceTimeCommands ();
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultPerformanceTimes", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultPerformanceTimesResponse")]
        List<DefaultPerformanceTimesContract> DefaultPerformanceTimes (System.String commandName);
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultStatisticsTop5", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultStatisticsTop5Response")]
        List<DefaultStatisticsTop5Contract> DefaultStatisticsTop5 ();
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultStatisticsByMonth", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultStatisticsByMonthResponse")]
        List<DefaultStatisticsByMonthContract> DefaultStatisticsByMonth ();
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultUserActivityByHour", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultUserActivityByHourResponse")]
        List<DefaultUserActivityByHourContract> DefaultUserActivityByHour ();
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultStatistics", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultStatisticsResponse")]
        List<DefaultStatisticsContract> DefaultStatistics ();
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultPerformanceIndicators", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultPerformanceIndicatorsResponse")]
        List<DefaultPerformanceIndicatorsContract> DefaultPerformanceIndicators ();
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultErrorOverview", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultErrorOverviewResponse")]
        List<DefaultErrorOverviewContract> DefaultErrorOverview ();
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultIssueWithFilter", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultIssueWithFilterResponse")]
        List<DefaultIssueWithFilterContract> DefaultIssueWithFilter (System.String defaultIssueTypeRcd,System.String defaultIssueStatusRcd);
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultPerformanceIssueFetchWithFilter", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultPerformanceIssueFetchWithFilterResponse")]
        List<DefaultPerformanceIssueFetchWithFilterContract> DefaultPerformanceIssueFetchWithFilter (System.String commandName);
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DashboardCounts", ReplyAction="http://tempuri.org/IDefaultSearchService/DashboardCountsResponse")]
        List<DashboardCountsContract> DashboardCounts (System.String dashboardLayoutRcd);
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultTestOverview", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultTestOverviewResponse")]
        List<DefaultTestOverviewContract> DefaultTestOverview (System.String commandName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDefaultSearchServiceChannel : IDefaultSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class DefaultSearchService : System.ServiceModel.ClientBase<IDefaultSearchService>, IDefaultSearchService {
        public List<DefaultResourceDatabaseStatisticsContract> DefaultResourceDatabaseStatistics () {
            return base.Channel.DefaultResourceDatabaseStatistics();
        }
        public List<DefaultResourceStatisticsContract> DefaultResourceStatistics () {
            return base.Channel.DefaultResourceStatistics();
        }
        public List<GetDefaultChangeLogContract> GetDefaultChangeLog (System.String defaultChangeName,System.String defaultChangeLogTypeRcd,System.Guid defaultIssueId,System.Guid defaultChangeLogId) {
            return base.Channel.GetDefaultChangeLog(defaultChangeName, defaultChangeLogTypeRcd, defaultIssueId, defaultChangeLogId);
        }
        public List<DefaultUserListForDashboardContract> DefaultUserListForDashboard () {
            return base.Channel.DefaultUserListForDashboard();
        }
        public List<DefaultUserListContract> DefaultUserList () {
            return base.Channel.DefaultUserList();
        }
        public List<DefaultUserActivityGroupedByAddressContract> DefaultUserActivityGroupedByAddress () {
            return base.Channel.DefaultUserActivityGroupedByAddress();
        }
        public List<DefaultUserActivityGroupedContract> DefaultUserActivityGrouped () {
            return base.Channel.DefaultUserActivityGrouped();
        }
        public List<DefaultUserActivityOnAddressContract> DefaultUserActivityOnAddress (System.String originatingAddress) {
            return base.Channel.DefaultUserActivityOnAddress(originatingAddress);
        }
        public List<DefaultUserActivityRecentContract> DefaultUserActivityRecent (System.Guid defaultUserId) {
            return base.Channel.DefaultUserActivityRecent(defaultUserId);
        }
        public List<DefaultPerformanceTimeCommandsContract> DefaultPerformanceTimeCommands () {
            return base.Channel.DefaultPerformanceTimeCommands();
        }
        public List<DefaultPerformanceTimesContract> DefaultPerformanceTimes (System.String commandName) {
            return base.Channel.DefaultPerformanceTimes(commandName);
        }
        public List<DefaultStatisticsTop5Contract> DefaultStatisticsTop5 () {
            return base.Channel.DefaultStatisticsTop5();
        }
        public List<DefaultStatisticsByMonthContract> DefaultStatisticsByMonth () {
            return base.Channel.DefaultStatisticsByMonth();
        }
        public List<DefaultUserActivityByHourContract> DefaultUserActivityByHour () {
            return base.Channel.DefaultUserActivityByHour();
        }
        public List<DefaultStatisticsContract> DefaultStatistics () {
            return base.Channel.DefaultStatistics();
        }
        public List<DefaultPerformanceIndicatorsContract> DefaultPerformanceIndicators () {
            return base.Channel.DefaultPerformanceIndicators();
        }
        public List<DefaultErrorOverviewContract> DefaultErrorOverview () {
            return base.Channel.DefaultErrorOverview();
        }
        public List<DefaultIssueWithFilterContract> DefaultIssueWithFilter (System.String defaultIssueTypeRcd,System.String defaultIssueStatusRcd) {
            return base.Channel.DefaultIssueWithFilter(defaultIssueTypeRcd, defaultIssueStatusRcd);
        }
        public List<DefaultPerformanceIssueFetchWithFilterContract> DefaultPerformanceIssueFetchWithFilter (System.String commandName) {
            return base.Channel.DefaultPerformanceIssueFetchWithFilter(commandName);
        }
        public List<DashboardCountsContract> DashboardCounts (System.String dashboardLayoutRcd) {
            return base.Channel.DashboardCounts(dashboardLayoutRcd);
        }
        public List<DefaultTestOverviewContract> DefaultTestOverview (System.String commandName) {
            return base.Channel.DefaultTestOverview(commandName);
        }
        
        public DefaultSearchService() {
        }
        
        public DefaultSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DefaultSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DefaultSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DefaultSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
