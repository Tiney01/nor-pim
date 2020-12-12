﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/12/2020 5:03:07 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

// Data Access Layer
// the DataAccessLayer is the first layer that has access to data coming from
//  sql server after being streamed over a net or internal process
// links:
//   https://en.wikipedia.org/wiki/Data_access_layer: data access layer
namespace SolutionNorSolutionPim.DataAccessLayer {

    // this class serves as a data access layer between c# and sql server
    // it is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of product_category's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/: serialization
    [Serializable()]
    public partial class CrudeProductCategoryData {
        
        public System.Guid ProductCategoryId { get; set; }
        
        public System.Guid ProductCategoryBecameId { get; set; }
        
        public System.Guid ProductCategoryParentId { get; set; }
        
        public string ProductCategoryCode { get; set; }
        
        public string ProductCategoryName { get; set; }
        
        public int ProductCategoryPosition { get; set; }
        
        public string StateRcd { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productCategoryId: primary key of table product_category
        public void FetchByProductCategoryId(System.Guid productCategoryId) {
            // create query against product_category
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time
                            from [product_category]
                            where product_category_id = @product_category_id
                            order by product_category_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                // dirty read
                // starting a transaction seems to be the only way of doing a dirty read
                // a dirty read means a row is read even if it is marked
                //   as locked by another database transaction
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = productCategoryId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        // fetch by Primary key into new class instance
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productCategoryId: primary key of table product_category
        public static CrudeProductCategoryData GetByProductCategoryId(System.Guid productCategoryId) {
            // create query against product_category
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time
                            from [product_category]
                            where product_category_id = @product_category_id
                            order by product_category_name";

            var ret = new CrudeProductCategoryData();

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = productCategoryId;

                    // execute query against product_category
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serialized class if a row was found
                    if (reader.Read())
                        ret.Populate(reader);
                }
            }

            return ret;
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeProductCategoryData> FetchByProductCategoryBecameId(System.Guid productCategoryBecameId) {
            var dataList = new List<CrudeProductCategoryData>();

            // create query against product_category
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time
                            from [product_category]
                            where product_category_became_id = @product_category_became_id
                              
                            order by product_category_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@product_category_became_id", SqlDbType.UniqueIdentifier).Value = productCategoryBecameId;

                    // execute query against product_category
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of product_category
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeProductCategoryData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeProductCategoryData> FetchByProductCategoryParentId(System.Guid productCategoryParentId) {
            var dataList = new List<CrudeProductCategoryData>();

            // create query against product_category
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time
                            from [product_category]
                            where product_category_parent_id = @product_category_parent_id
                              
                            order by product_category_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@product_category_parent_id", SqlDbType.UniqueIdentifier).Value = productCategoryParentId;

                    // execute query against product_category
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of product_category
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeProductCategoryData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeProductCategoryData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductCategoryData>();

            // create query against product_category
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time
                            from [product_category]
                            where user_id = @user_id
                              
                            order by product_category_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    // execute query against product_category
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of product_category
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeProductCategoryData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeProductCategoryData> FetchByStateRcd(string stateRcd) {
            var dataList = new List<CrudeProductCategoryData>();

            // create query against product_category
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time
                            from [product_category]
                            where state_rcd = @state_rcd
                              
                            order by product_category_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@state_rcd", SqlDbType.NVarChar).Value = stateRcd.Replace("'","''");

                    // execute query against product_category
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of product_category
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeProductCategoryData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Picker Member into new class instance
        public void FetchByProductCategoryName(string productCategoryName) {
            // create query against product_category
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time
                            from [product_category]
                            where product_category_name like '%' + @productCategoryName + '%'
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                    // add search column
                    // this search column will be used together with the prepared ansi sql statement
                command.Parameters.Add("@productCategoryName",SqlDbType.NVarChar).Value = productCategoryName;

                // execute query against product_category
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        // fetch all rows from table product_category into new List of class instances
        public static List<CrudeProductCategoryData> FetchAll() {
            var dataList = new List<CrudeProductCategoryData>();

            // create query against product_category
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time
                            from [product_category]
                            order by product_category_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against product_category
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of product_category
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeProductCategoryData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public static List<CrudeProductCategoryData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductCategoryData>();

            // create query against product_category
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top " + limit.ToString() + @" product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time
                            from [product_category]
                            order by product_category_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against product_category
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of product_category
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeProductCategoryData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public static List<CrudeProductCategoryData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductCategoryData>();

            // create query against product_category
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time
                            from [product_category]
                            order by product_category_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against product_category
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    // read all rows returned from the query of product_category
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductCategoryData();
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
        
        // get a count of rows in table
        public static int FetchAllCount() {
            // create query against product_category
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select count(*) as count from [product_category]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                int count = 0;

                using (var command = new SqlCommand(sql, conn)) {
                    // execute query against product_category
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    reader.Read();
                    count = (System.Int32) reader["count"];
                }

                return count;
            }
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public static List<CrudeProductCategoryData> FetchWithFilter(System.Guid productCategoryId, System.Guid productCategoryBecameId, System.Guid productCategoryParentId, string productCategoryCode, string productCategoryName, int productCategoryPosition, string stateRcd, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductCategoryData>();

            // create query against product_category
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time
                            from [product_category]
                            where 1 = 1";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add search column(s) if they are not null or empty
                    // this search column(s) will be used together with the prepared ansi sql statement
                    if (productCategoryId != Guid.Empty) {
                        sql += "  and product_category_id = @product_category_id";
                        command.Parameters.Add("@product_category_id", SqlDbType.UniqueIdentifier).Value = productCategoryId;
                    }
                    if (productCategoryBecameId != Guid.Empty) {
                        sql += "  and product_category_became_id = @product_category_became_id";
                        command.Parameters.Add("@product_category_became_id", SqlDbType.UniqueIdentifier).Value = productCategoryBecameId;
                    }
                    if (productCategoryParentId != Guid.Empty) {
                        sql += "  and product_category_parent_id = @product_category_parent_id";
                        command.Parameters.Add("@product_category_parent_id", SqlDbType.UniqueIdentifier).Value = productCategoryParentId;
                    }
                    if (!string.IsNullOrEmpty(productCategoryCode)) {
                        sql += "  and product_category_code like '%' + @product_category_code + '%'";
                        command.Parameters.Add("@product_category_code", SqlDbType.NVarChar).Value = productCategoryCode.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(productCategoryName)) {
                        sql += "  and product_category_name like '%' + @product_category_name + '%'";
                        command.Parameters.Add("@product_category_name", SqlDbType.NVarChar).Value = productCategoryName.Replace("'","''");
                    }
                    if (productCategoryPosition != 0) {
                        sql += "  and product_category_position = @product_category_position";
                        command.Parameters.Add("@product_category_position", SqlDbType.Int).Value = productCategoryPosition;
                    }
                    if (!string.IsNullOrEmpty(stateRcd)) {
                        sql += "  and state_rcd like '%' + @state_rcd + '%'";
                        command.Parameters.Add("@state_rcd", SqlDbType.NVarChar).Value = stateRcd.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by product_category_name";

                    command.CommandText = sql;

                    // execute query against product_category
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of product_category
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeProductCategoryData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // read all columns out and populate object members
        public void Populate(IDataReader reader) {
            if (reader["product_category_id"] != System.DBNull.Value) ProductCategoryId = (System.Guid) reader["product_category_id"];
            if (reader["product_category_became_id"] != System.DBNull.Value) ProductCategoryBecameId = (System.Guid) reader["product_category_became_id"];
            if (reader["product_category_parent_id"] != System.DBNull.Value) ProductCategoryParentId = (System.Guid) reader["product_category_parent_id"];
            if (reader["product_category_code"] != System.DBNull.Value) ProductCategoryCode = (System.String) reader["product_category_code"];
            if (reader["product_category_name"] != System.DBNull.Value) ProductCategoryName = (System.String) reader["product_category_name"];
            if (reader["product_category_position"] != System.DBNull.Value) ProductCategoryPosition = (System.Int32) reader["product_category_position"];
            if (reader["state_rcd"] != System.DBNull.Value) StateRcd = (System.String) reader["state_rcd"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        // insert all object members as a new row in table
        public void Insert() {

            if (ProductCategoryId == Guid.Empty)
                ProductCategoryId = Guid.NewGuid();

            // create query against product_category
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [product_category] (product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time)";
            sql += "            values (@product_category_id, @product_category_became_id, @product_category_parent_id, @product_category_code, @product_category_name, @product_category_position, @state_rcd, @user_id, @date_time)";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    // add column(s) to insert as parameter
                    // the insert column(s) will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductCategoryId;
                    command.Parameters.Add("@product_category_became_id",SqlDbType.UniqueIdentifier).Value = (ProductCategoryBecameId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductCategoryBecameId);
                    command.Parameters.Add("@product_category_parent_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductCategoryParentId;
                    command.Parameters.Add("@product_category_code",SqlDbType.NVarChar).Value = (System.String)ProductCategoryCode;
                    command.Parameters.Add("@product_category_name",SqlDbType.NVarChar).Value = (System.String)ProductCategoryName;
                    command.Parameters.Add("@product_category_position",SqlDbType.Int).Value = (System.Int32)ProductCategoryPosition;
                    command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = (System.String)StateRcd;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    // execute query against product_category
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductCategoryId == Guid.Empty)
                ProductCategoryId = Guid.NewGuid();

            // create query against product_category
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [product_category] (product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time)";
            sql += "            values (@product_category_id, @product_category_became_id, @product_category_parent_id, @product_category_code, @product_category_name, @product_category_position, @state_rcd, @user_id, @date_time)";

            // use passed in connection
            // transaction scope etc is determined by caller
            // there are no result from this action, SqlClient will raise an exception in case
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to insert as parameter(s)
                // the insert column(s) will be used together with the prepared ansi sql statement
                command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductCategoryId;
                command.Parameters.Add("@product_category_became_id",SqlDbType.UniqueIdentifier).Value = (ProductCategoryBecameId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductCategoryBecameId);
                command.Parameters.Add("@product_category_parent_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductCategoryParentId;
                command.Parameters.Add("@product_category_code",SqlDbType.NVarChar).Value = (System.String)ProductCategoryCode;
                command.Parameters.Add("@product_category_name",SqlDbType.NVarChar).Value = (System.String)ProductCategoryName;
                command.Parameters.Add("@product_category_position",SqlDbType.Int).Value = (System.Int32)ProductCategoryPosition;
                command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = (System.String)StateRcd;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                // execute query against product_category
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // update all object members on a row in table based on primary key
        public void Update() {
            // create query against product_category
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" update [product_category] set
                 product_category_id = @product_category_id
                ,product_category_became_id = @product_category_became_id
                ,product_category_parent_id = @product_category_parent_id
                ,product_category_code = @product_category_code
                ,product_category_name = @product_category_name
                ,product_category_position = @product_category_position
                ,state_rcd = @state_rcd
                ,user_id = @user_id
                ,date_time = @date_time
            where product_category_id = @product_category_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // add column(s) to update as parameter(s)
                    // the update column(s) will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductCategoryId;
                    command.Parameters.Add("@product_category_became_id",SqlDbType.UniqueIdentifier).Value = (ProductCategoryBecameId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductCategoryBecameId);
                    command.Parameters.Add("@product_category_parent_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductCategoryParentId;
                    command.Parameters.Add("@product_category_code",SqlDbType.NVarChar).Value = (System.String)ProductCategoryCode;
                    command.Parameters.Add("@product_category_name",SqlDbType.NVarChar).Value = (System.String)ProductCategoryName;
                    command.Parameters.Add("@product_category_position",SqlDbType.Int).Value = (System.Int32)ProductCategoryPosition;
                    command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = (System.String)StateRcd;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    // execute query against product_category
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            // create query against product_category
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" update [product_category] set
                 product_category_id = @product_category_id
                ,product_category_became_id = @product_category_became_id
                ,product_category_parent_id = @product_category_parent_id
                ,product_category_code = @product_category_code
                ,product_category_name = @product_category_name
                ,product_category_position = @product_category_position
                ,state_rcd = @state_rcd
                ,user_id = @user_id
                ,date_time = @date_time
            where product_category_id = @product_category_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to update as parameter
                // the update column(s) will be used together with the prepared ansi sql statement
                command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductCategoryId;
                command.Parameters.Add("@product_category_became_id",SqlDbType.UniqueIdentifier).Value = (ProductCategoryBecameId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductCategoryBecameId);
                command.Parameters.Add("@product_category_parent_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductCategoryParentId;
                command.Parameters.Add("@product_category_code",SqlDbType.NVarChar).Value = (System.String)ProductCategoryCode;
                command.Parameters.Add("@product_category_name",SqlDbType.NVarChar).Value = (System.String)ProductCategoryName;
                command.Parameters.Add("@product_category_position",SqlDbType.Int).Value = (System.Int32)ProductCategoryPosition;
                command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = (System.String)StateRcd;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                // execute query against product_category
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // delete a row in table based on primary key
        public static void Delete(System.Guid productCategoryId) {
            // create query against product_category
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" delete [product_category] 
                where product_category_id = @product_category_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = productCategoryId;
                    // execute query against product_category
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
