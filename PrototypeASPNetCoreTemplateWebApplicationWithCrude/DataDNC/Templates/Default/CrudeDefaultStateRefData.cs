﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:29:02 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public partial class DefaultStateRef {
        
        public const string Created = "C";
        
        public const string Invalidated = "I";
        
        public const string Updated = "U";
    }
    
    //[Serializable()]
    public partial class CrudeDefaultStateRefData {
        
        public string DefaultStateRcd { get; set; } //;
        
        public string DefaultStateName { get; set; } //;
        
        public System.Guid DefaultUserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByDefaultStateRcd(string defaultStateRcd) {
            string sql = @" select top 1 default_state_rcd, default_state_name, default_user_id, date_time
                            from [default_state_ref]
                            where default_state_rcd = @default_state_rcd
                            order by default_state_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@default_state_rcd",SqlDbType.NVarChar).Value = defaultStateRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeDefaultStateRefData GetByDefaultStateRcd(string defaultStateRcd) {
            string sql = @" select top 1 default_state_rcd, default_state_name, default_user_id, date_time
                            from [default_state_ref]
                            where default_state_rcd = @default_state_rcd
                            order by default_state_name";

            var ret = new CrudeDefaultStateRefData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_state_rcd",SqlDbType.NVarChar).Value = defaultStateRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeDefaultStateRefData> FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataList = new List<CrudeDefaultStateRefData>();

            string sql = @" select default_state_rcd, default_state_name, default_user_id, date_time
                            from [default_state_ref]
                            where default_user_id = @default_user_id
                              
                            order by default_state_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultStateRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByDefaultStateName(string defaultStateName) {
            string sql = @" select top 1 default_state_rcd, default_state_name, default_user_id, date_time
                            from [default_state_ref]
                            where default_state_name like '%' + @defaultStateName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@defaultStateName",SqlDbType.NVarChar).Value = defaultStateName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeDefaultStateRefData> FetchAll() {
            var dataList = new List<CrudeDefaultStateRefData>();

            string sql = @" select default_state_rcd, default_state_name, default_user_id, date_time
                            from [default_state_ref]
                            order by default_state_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultStateRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultStateRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultStateRefData>();

            string sql = @" select top " + limit.ToString() + @" default_state_rcd, default_state_name, default_user_id, date_time
                            from [default_state_ref]
                            order by default_state_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultStateRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultStateRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultStateRefData>();

            string sql = @" select default_state_rcd, default_state_name, default_user_id, date_time
                            from [default_state_ref]
                            order by default_state_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultStateRefData();
                            data.Populate(reader);
                            dataList.Add(data);
                        }
                        count++;
                        if (count > limit + offset) break;
                    }
                }
                
                return dataList;
            }
        }
        
        public static int FetchAllCount() {
            string sql = @" select count(*) as count from [default_state_ref]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                int count = 0;

                using (var command = new SqlCommand(sql, conn)) {
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    reader.Read();
                    count = (System.Int32) reader["count"];
                }

                return count;
            }
        }
        
        public static List<CrudeDefaultStateRefData> FetchWithFilter(string defaultStateRcd, string defaultStateName, System.Guid defaultUserId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultStateRefData>();

            string sql = @" select default_state_rcd, default_state_name, default_user_id, date_time
                            from [default_state_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(defaultStateRcd)) {
                        sql += "  and default_state_rcd like '%' + @default_state_rcd + '%'";
                        command.Parameters.Add("@default_state_rcd", SqlDbType.NVarChar).Value = defaultStateRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(defaultStateName)) {
                        sql += "  and default_state_name like '%' + @default_state_name + '%'";
                        command.Parameters.Add("@default_state_name", SqlDbType.NVarChar).Value = defaultStateName.Replace("'","''");
                    }
                    if (defaultUserId != Guid.Empty) {
                        sql += "  and default_user_id = @default_user_id";
                        command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by default_state_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultStateRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["default_state_rcd"] != System.DBNull.Value) DefaultStateRcd = (System.String) reader["default_state_rcd"];
            if (reader["default_state_name"] != System.DBNull.Value) DefaultStateName = (System.String) reader["default_state_name"];
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [default_state_ref] (default_state_rcd, default_state_name, default_user_id, date_time)";
            sql += "            values (@default_state_rcd, @default_state_name, @default_user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@default_state_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultStateRcd;
                    command.Parameters.Add("@default_state_name",SqlDbType.NVarChar).Value = (System.String)DefaultStateName;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [default_state_ref] (default_state_rcd, default_state_name, default_user_id, date_time)";
            sql += "            values (@default_state_rcd, @default_state_name, @default_user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_state_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultStateRcd;
                command.Parameters.Add("@default_state_name",SqlDbType.NVarChar).Value = (System.String)DefaultStateName;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [default_state_ref] set
                 default_state_rcd = @default_state_rcd
                ,default_state_name = @default_state_name
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_state_rcd = @default_state_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@default_state_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultStateRcd;
                    command.Parameters.Add("@default_state_name",SqlDbType.NVarChar).Value = (System.String)DefaultStateName;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [default_state_ref] set
                 default_state_rcd = @default_state_rcd
                ,default_state_name = @default_state_name
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_state_rcd = @default_state_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_state_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultStateRcd;
                command.Parameters.Add("@default_state_name",SqlDbType.NVarChar).Value = (System.String)DefaultStateName;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string defaultStateRcd) {
            string sql = @" delete [default_state_ref] 
                where default_state_rcd = @default_state_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_state_rcd",SqlDbType.NVarChar).Value = defaultStateRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}