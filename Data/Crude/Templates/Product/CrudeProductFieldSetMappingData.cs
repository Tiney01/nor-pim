﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:21:10 PM
  From Machine: DESKTOP-KE5CSN3
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
    // this class start with an identical representation of product_field_set_mapping's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/: serialization
    [Serializable()]
    public partial class CrudeProductFieldSetMappingData {
        
        public System.Guid ProductFieldSetMappingId { get; set; }
        
        public System.Guid ProductFieldSetId { get; set; }
        
        public string ProductIdentifierRcd { get; set; }
        
        public string ProductAttributeRcd { get; set; }
        
        public string ProductInfoRcd { get; set; }
        
        public string ProductImageTypeRcd { get; set; }
        
        public string ProductDocumentationTypeRcd { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productFieldSetMappingId: primary key of table product_field_set_mapping
        public void FetchByProductFieldSetMappingId(System.Guid productFieldSetMappingId) {
            // create query against product_field_set_mapping
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]
                            where product_field_set_mapping_id = @product_field_set_mapping_id";

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
                    command.Parameters.Add("@product_field_set_mapping_id",SqlDbType.UniqueIdentifier).Value = productFieldSetMappingId;

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
        //   productFieldSetMappingId: primary key of table product_field_set_mapping
        public static CrudeProductFieldSetMappingData GetByProductFieldSetMappingId(System.Guid productFieldSetMappingId) {
            // create query against product_field_set_mapping
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]
                            where product_field_set_mapping_id = @product_field_set_mapping_id";

            var ret = new CrudeProductFieldSetMappingData();

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@product_field_set_mapping_id",SqlDbType.UniqueIdentifier).Value = productFieldSetMappingId;

                    // execute query against product_field_set_mapping
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
        public static List<CrudeProductFieldSetMappingData> FetchByProductFieldSetId(System.Guid productFieldSetId) {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            // create query against product_field_set_mapping
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]
                            where product_field_set_id = @product_field_set_id
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@product_field_set_id", SqlDbType.UniqueIdentifier).Value = productFieldSetId;

                    // execute query against product_field_set_mapping
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of product_field_set_mapping
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeProductFieldSetMappingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeProductFieldSetMappingData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            // create query against product_field_set_mapping
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]
                            where user_id = @user_id
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    // execute query against product_field_set_mapping
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of product_field_set_mapping
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeProductFieldSetMappingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeProductFieldSetMappingData> FetchByProductIdentifierRcd(string productIdentifierRcd) {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            // create query against product_field_set_mapping
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]
                            where product_identifier_rcd = @product_identifier_rcd
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@product_identifier_rcd", SqlDbType.NVarChar).Value = productIdentifierRcd.Replace("'","''");

                    // execute query against product_field_set_mapping
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of product_field_set_mapping
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeProductFieldSetMappingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeProductFieldSetMappingData> FetchByProductAttributeRcd(string productAttributeRcd) {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            // create query against product_field_set_mapping
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]
                            where product_attribute_rcd = @product_attribute_rcd
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@product_attribute_rcd", SqlDbType.NVarChar).Value = productAttributeRcd.Replace("'","''");

                    // execute query against product_field_set_mapping
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of product_field_set_mapping
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeProductFieldSetMappingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeProductFieldSetMappingData> FetchByProductInfoRcd(string productInfoRcd) {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            // create query against product_field_set_mapping
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]
                            where product_info_rcd = @product_info_rcd
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@product_info_rcd", SqlDbType.NVarChar).Value = productInfoRcd.Replace("'","''");

                    // execute query against product_field_set_mapping
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of product_field_set_mapping
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeProductFieldSetMappingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeProductFieldSetMappingData> FetchByProductImageTypeRcd(string productImageTypeRcd) {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            // create query against product_field_set_mapping
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]
                            where product_image_type_rcd = @product_image_type_rcd
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@product_image_type_rcd", SqlDbType.NVarChar).Value = productImageTypeRcd.Replace("'","''");

                    // execute query against product_field_set_mapping
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of product_field_set_mapping
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeProductFieldSetMappingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeProductFieldSetMappingData> FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd) {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            // create query against product_field_set_mapping
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]
                            where product_documentation_type_rcd = @product_documentation_type_rcd
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@product_documentation_type_rcd", SqlDbType.NVarChar).Value = productDocumentationTypeRcd.Replace("'","''");

                    // execute query against product_field_set_mapping
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of product_field_set_mapping
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeProductFieldSetMappingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all rows from table product_field_set_mapping into new List of class instances
        public static List<CrudeProductFieldSetMappingData> FetchAll() {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            // create query against product_field_set_mapping
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against product_field_set_mapping
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of product_field_set_mapping
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeProductFieldSetMappingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public static List<CrudeProductFieldSetMappingData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            // create query against product_field_set_mapping
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top " + limit.ToString() + @" product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against product_field_set_mapping
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of product_field_set_mapping
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeProductFieldSetMappingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public static List<CrudeProductFieldSetMappingData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            // create query against product_field_set_mapping
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against product_field_set_mapping
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    // read all rows returned from the query of product_field_set_mapping
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductFieldSetMappingData();
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
            // create query against product_field_set_mapping
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select count(*) as count from [product_field_set_mapping]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                int count = 0;

                using (var command = new SqlCommand(sql, conn)) {
                    // execute query against product_field_set_mapping
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
        public static List<CrudeProductFieldSetMappingData> FetchWithFilter(System.Guid productFieldSetMappingId, System.Guid productFieldSetId, string productIdentifierRcd, string productAttributeRcd, string productInfoRcd, string productImageTypeRcd, string productDocumentationTypeRcd, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            // create query against product_field_set_mapping
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]
                            where 1 = 1";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add search column(s) if they are not null or empty
                    // this search column(s) will be used together with the prepared ansi sql statement
                    if (productFieldSetMappingId != Guid.Empty) {
                        sql += "  and product_field_set_mapping_id = @product_field_set_mapping_id";
                        command.Parameters.Add("@product_field_set_mapping_id", SqlDbType.UniqueIdentifier).Value = productFieldSetMappingId;
                    }
                    if (productFieldSetId != Guid.Empty) {
                        sql += "  and product_field_set_id = @product_field_set_id";
                        command.Parameters.Add("@product_field_set_id", SqlDbType.UniqueIdentifier).Value = productFieldSetId;
                    }
                    if (!string.IsNullOrEmpty(productIdentifierRcd)) {
                        sql += "  and product_identifier_rcd like '%' + @product_identifier_rcd + '%'";
                        command.Parameters.Add("@product_identifier_rcd", SqlDbType.NVarChar).Value = productIdentifierRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(productAttributeRcd)) {
                        sql += "  and product_attribute_rcd like '%' + @product_attribute_rcd + '%'";
                        command.Parameters.Add("@product_attribute_rcd", SqlDbType.NVarChar).Value = productAttributeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(productInfoRcd)) {
                        sql += "  and product_info_rcd like '%' + @product_info_rcd + '%'";
                        command.Parameters.Add("@product_info_rcd", SqlDbType.NVarChar).Value = productInfoRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(productImageTypeRcd)) {
                        sql += "  and product_image_type_rcd like '%' + @product_image_type_rcd + '%'";
                        command.Parameters.Add("@product_image_type_rcd", SqlDbType.NVarChar).Value = productImageTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(productDocumentationTypeRcd)) {
                        sql += "  and product_documentation_type_rcd like '%' + @product_documentation_type_rcd + '%'";
                        command.Parameters.Add("@product_documentation_type_rcd", SqlDbType.NVarChar).Value = productDocumentationTypeRcd.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    command.CommandText = sql;

                    // execute query against product_field_set_mapping
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of product_field_set_mapping
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeProductFieldSetMappingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // read all columns out and populate object members
        public void Populate(IDataReader reader) {
            if (reader["product_field_set_mapping_id"] != System.DBNull.Value) ProductFieldSetMappingId = (System.Guid) reader["product_field_set_mapping_id"];
            if (reader["product_field_set_id"] != System.DBNull.Value) ProductFieldSetId = (System.Guid) reader["product_field_set_id"];
            if (reader["product_identifier_rcd"] != System.DBNull.Value) ProductIdentifierRcd = (System.String) reader["product_identifier_rcd"];
            if (reader["product_attribute_rcd"] != System.DBNull.Value) ProductAttributeRcd = (System.String) reader["product_attribute_rcd"];
            if (reader["product_info_rcd"] != System.DBNull.Value) ProductInfoRcd = (System.String) reader["product_info_rcd"];
            if (reader["product_image_type_rcd"] != System.DBNull.Value) ProductImageTypeRcd = (System.String) reader["product_image_type_rcd"];
            if (reader["product_documentation_type_rcd"] != System.DBNull.Value) ProductDocumentationTypeRcd = (System.String) reader["product_documentation_type_rcd"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        // insert all object members as a new row in table
        public void Insert() {

            if (ProductFieldSetMappingId == Guid.Empty)
                ProductFieldSetMappingId = Guid.NewGuid();

            // create query against product_field_set_mapping
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [product_field_set_mapping] (product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time)";
            sql += "            values (@product_field_set_mapping_id, @product_field_set_id, @product_identifier_rcd, @product_attribute_rcd, @product_info_rcd, @product_image_type_rcd, @product_documentation_type_rcd, @user_id, @date_time)";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    // add column(s) to insert as parameter
                    // the insert column(s) will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@product_field_set_mapping_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductFieldSetMappingId;
                    command.Parameters.Add("@product_field_set_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductFieldSetId;
                    command.Parameters.Add("@product_identifier_rcd",SqlDbType.NVarChar).Value = (System.String)ProductIdentifierRcd;
                    command.Parameters.Add("@product_attribute_rcd",SqlDbType.NVarChar).Value = (System.String)ProductAttributeRcd;
                    command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = (System.String)ProductInfoRcd;
                    command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductImageTypeRcd;
                    command.Parameters.Add("@product_documentation_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductDocumentationTypeRcd;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    // execute query against product_field_set_mapping
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

            if (ProductFieldSetMappingId == Guid.Empty)
                ProductFieldSetMappingId = Guid.NewGuid();

            // create query against product_field_set_mapping
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [product_field_set_mapping] (product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time)";
            sql += "            values (@product_field_set_mapping_id, @product_field_set_id, @product_identifier_rcd, @product_attribute_rcd, @product_info_rcd, @product_image_type_rcd, @product_documentation_type_rcd, @user_id, @date_time)";

            // use passed in connection
            // transaction scope etc is determined by caller
            // there are no result from this action, SqlClient will raise an exception in case
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to insert as parameter(s)
                // the insert column(s) will be used together with the prepared ansi sql statement
                command.Parameters.Add("@product_field_set_mapping_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductFieldSetMappingId;
                command.Parameters.Add("@product_field_set_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductFieldSetId;
                command.Parameters.Add("@product_identifier_rcd",SqlDbType.NVarChar).Value = (System.String)ProductIdentifierRcd;
                command.Parameters.Add("@product_attribute_rcd",SqlDbType.NVarChar).Value = (System.String)ProductAttributeRcd;
                command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = (System.String)ProductInfoRcd;
                command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductImageTypeRcd;
                command.Parameters.Add("@product_documentation_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductDocumentationTypeRcd;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                // execute query against product_field_set_mapping
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // update all object members on a row in table based on primary key
        public void Update() {
            // create query against product_field_set_mapping
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" update [product_field_set_mapping] set
                 product_field_set_mapping_id = @product_field_set_mapping_id
                ,product_field_set_id = @product_field_set_id
                ,product_identifier_rcd = @product_identifier_rcd
                ,product_attribute_rcd = @product_attribute_rcd
                ,product_info_rcd = @product_info_rcd
                ,product_image_type_rcd = @product_image_type_rcd
                ,product_documentation_type_rcd = @product_documentation_type_rcd
                ,user_id = @user_id
                ,date_time = @date_time
            where product_field_set_mapping_id = @product_field_set_mapping_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // add column(s) to update as parameter(s)
                    // the update column(s) will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@product_field_set_mapping_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductFieldSetMappingId;
                    command.Parameters.Add("@product_field_set_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductFieldSetId;
                    command.Parameters.Add("@product_identifier_rcd",SqlDbType.NVarChar).Value = (System.String)ProductIdentifierRcd;
                    command.Parameters.Add("@product_attribute_rcd",SqlDbType.NVarChar).Value = (System.String)ProductAttributeRcd;
                    command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = (System.String)ProductInfoRcd;
                    command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductImageTypeRcd;
                    command.Parameters.Add("@product_documentation_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductDocumentationTypeRcd;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    // execute query against product_field_set_mapping
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            // create query against product_field_set_mapping
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" update [product_field_set_mapping] set
                 product_field_set_mapping_id = @product_field_set_mapping_id
                ,product_field_set_id = @product_field_set_id
                ,product_identifier_rcd = @product_identifier_rcd
                ,product_attribute_rcd = @product_attribute_rcd
                ,product_info_rcd = @product_info_rcd
                ,product_image_type_rcd = @product_image_type_rcd
                ,product_documentation_type_rcd = @product_documentation_type_rcd
                ,user_id = @user_id
                ,date_time = @date_time
            where product_field_set_mapping_id = @product_field_set_mapping_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to update as parameter
                // the update column(s) will be used together with the prepared ansi sql statement
                command.Parameters.Add("@product_field_set_mapping_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductFieldSetMappingId;
                command.Parameters.Add("@product_field_set_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductFieldSetId;
                command.Parameters.Add("@product_identifier_rcd",SqlDbType.NVarChar).Value = (System.String)ProductIdentifierRcd;
                command.Parameters.Add("@product_attribute_rcd",SqlDbType.NVarChar).Value = (System.String)ProductAttributeRcd;
                command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = (System.String)ProductInfoRcd;
                command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductImageTypeRcd;
                command.Parameters.Add("@product_documentation_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductDocumentationTypeRcd;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                // execute query against product_field_set_mapping
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // delete a row in table based on primary key
        public static void Delete(System.Guid productFieldSetMappingId) {
            // create query against product_field_set_mapping
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" delete [product_field_set_mapping] 
                where product_field_set_mapping_id = @product_field_set_mapping_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@product_field_set_mapping_id",SqlDbType.UniqueIdentifier).Value = productFieldSetMappingId;
                    // execute query against product_field_set_mapping
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
