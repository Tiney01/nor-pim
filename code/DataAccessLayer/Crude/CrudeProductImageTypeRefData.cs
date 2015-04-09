using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    public partial class ProductImageTypeRef {
        
        public static string InternalStockPhoto = "ISP";
        
        public static string ProductImageVariableSize = "PI";
    }
    
    [Serializable()]
    public partial class CrudeProductImageTypeRefData {
        
        public string ProductImageTypeRcd { get; set; } //;
        
        public string ProductImageTypeName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductImageTypeRcd(string productImageTypeRcd) {
            string sql = @" select top 1 product_image_type_rcd, product_image_type_name, user_id, date_time
                            from [product_image_type_ref]
                            where product_image_type_rcd = @product_image_type_rcd";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = productImageTypeRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public List<CrudeProductImageTypeRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductImageTypeRefData>();

            string sql = @" select product_image_type_rcd, product_image_type_name, user_id, date_time
                            from [product_image_type_ref]
                            where user_id = @user_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductImageTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductImageTypeRefData> FetchAll() {
            var dataList = new List<CrudeProductImageTypeRefData>();

            string sql = @" select product_image_type_rcd, product_image_type_name, user_id, date_time
                            from [product_image_type_ref]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductImageTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductImageTypeRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductImageTypeRefData>();

            string sql = @" select top " + limit.ToString() + @" product_image_type_rcd, product_image_type_name, user_id, date_time
                            from [product_image_type_ref]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductImageTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductImageTypeRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductImageTypeRefData>();

            string sql = @" select product_image_type_rcd, product_image_type_name, user_id, date_time
                            from [product_image_type_ref]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductImageTypeRefData();
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
        
        public int FetchAllCount() {
            string sql = @" select count(*) as count from [product_image_type_ref]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
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
        
        public List<CrudeProductImageTypeRefData> FetchWithFilter(string productImageTypeRcd, string productImageTypeName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductImageTypeRefData>();

            string sql = @" select product_image_type_rcd, product_image_type_name, user_id, date_time
                            from [product_image_type_ref]
                            where 1 = 1";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productImageTypeRcd != "") {
                        sql += "  and product_image_type_rcd like '%' + @product_image_type_rcd + '%'";
                        command.Parameters.Add("@product_image_type_rcd", SqlDbType.NVarChar).Value = productImageTypeRcd.Replace("'","''");
                    }
                    if (productImageTypeName != "") {
                        sql += "  and product_image_type_name like '%' + @product_image_type_name + '%'";
                        command.Parameters.Add("@product_image_type_name", SqlDbType.NVarChar).Value = productImageTypeName.Replace("'","''");
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

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductImageTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_image_type_rcd"] != System.DBNull.Value) ProductImageTypeRcd = (System.String) reader["product_image_type_rcd"];
            if (reader["product_image_type_name"] != System.DBNull.Value) ProductImageTypeName = (System.String) reader["product_image_type_name"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [product_image_type_ref] (product_image_type_rcd, product_image_type_name, user_id, date_time)";
            sql += "            values (@product_image_type_rcd, @product_image_type_name, @user_id, @date_time)";

            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = (ProductImageTypeRcd == null ? (object)DBNull.Value : (System.String)ProductImageTypeRcd);
                    command.Parameters.Add("@product_image_type_name",SqlDbType.NVarChar).Value = (ProductImageTypeName == null ? (object)DBNull.Value : (System.String)ProductImageTypeName);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [product_image_type_ref] (product_image_type_rcd, product_image_type_name, user_id, date_time)";
            sql += "            values (@product_image_type_rcd, @product_image_type_name, @user_id, @date_time)";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = (ProductImageTypeRcd == null ? (object)DBNull.Value : (System.String)ProductImageTypeRcd);
                command.Parameters.Add("@product_image_type_name",SqlDbType.NVarChar).Value = (ProductImageTypeName == null ? (object)DBNull.Value : (System.String)ProductImageTypeName);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_image_type_ref] set
                 product_image_type_rcd = @product_image_type_rcd
                ,product_image_type_name = @product_image_type_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_image_type_rcd = @product_image_type_rcd";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = (ProductImageTypeRcd == null ? (object)DBNull.Value : (System.String)ProductImageTypeRcd);
                    command.Parameters.Add("@product_image_type_name",SqlDbType.NVarChar).Value = (ProductImageTypeName == null ? (object)DBNull.Value : (System.String)ProductImageTypeName);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_image_type_ref] set
                 product_image_type_rcd = @product_image_type_rcd
                ,product_image_type_name = @product_image_type_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_image_type_rcd = @product_image_type_rcd";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = (ProductImageTypeRcd == null ? (object)DBNull.Value : (System.String)ProductImageTypeRcd);
                command.Parameters.Add("@product_image_type_name",SqlDbType.NVarChar).Value = (ProductImageTypeName == null ? (object)DBNull.Value : (System.String)ProductImageTypeName);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Delete(System.Guid id) {
            string sql = @" delete [product_image_type_ref] 
                where product_image_type_rcd = @product_image_type_rcd";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
