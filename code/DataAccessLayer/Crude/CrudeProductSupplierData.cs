using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeProductSupplierData {
        
        public System.Guid ProductSupplierId { get; set; } //;
        
        public System.Guid ProductId { get; set; } //;
        
        public string SupplierName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductSupplierId(System.Guid productSupplierId) {
            string sql = @" select top 1 product_supplier_id, product_id, supplier_name, user_id, date_time
                            from [product_supplier]
                            where product_supplier_id = @product_supplier_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_supplier_id",SqlDbType.UniqueIdentifier).Value = productSupplierId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public List<CrudeProductSupplierData> FetchByProductId(System.Guid productId) {
            var dataList = new List<CrudeProductSupplierData>();

            string sql = @" select product_supplier_id, product_id, supplier_name, user_id, date_time
                            from [product_supplier]
                            where product_id = @product_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductSupplierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductSupplierData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductSupplierData>();

            string sql = @" select product_supplier_id, product_id, supplier_name, user_id, date_time
                            from [product_supplier]
                            where user_id = @user_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductSupplierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductSupplierData> FetchAll() {
            var dataList = new List<CrudeProductSupplierData>();

            string sql = @" select product_supplier_id, product_id, supplier_name, user_id, date_time
                            from [product_supplier]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductSupplierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductSupplierData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductSupplierData>();

            string sql = @" select top " + limit.ToString() + @" product_supplier_id, product_id, supplier_name, user_id, date_time
                            from [product_supplier]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductSupplierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductSupplierData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductSupplierData>();

            string sql = @" select product_supplier_id, product_id, supplier_name, user_id, date_time
                            from [product_supplier]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductSupplierData();
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
            string sql = @" select count(*) as count from [product_supplier]";

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
        
        public List<CrudeProductSupplierData> FetchWithFilter(System.Guid productSupplierId, System.Guid productId, string supplierName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductSupplierData>();

            string sql = @" select product_supplier_id, product_id, supplier_name, user_id, date_time
                            from [product_supplier]
                            where 1 = 1";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productSupplierId != Guid.Empty) {
                        sql += "  and product_supplier_id = @product_supplier_id";
                        command.Parameters.Add("@product_supplier_id", SqlDbType.UniqueIdentifier).Value = productSupplierId;
                    }
                    if (productId != Guid.Empty) {
                        sql += "  and product_id = @product_id";
                        command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;
                    }
                    if (supplierName != "") {
                        sql += "  and supplier_name like '%' + @supplier_name + '%'";
                        command.Parameters.Add("@supplier_name", SqlDbType.NVarChar).Value = supplierName.Replace("'","''");
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
                        var data = new CrudeProductSupplierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_supplier_id"] != System.DBNull.Value) ProductSupplierId = (System.Guid) reader["product_supplier_id"];
            if (reader["product_id"] != System.DBNull.Value) ProductId = (System.Guid) reader["product_id"];
            if (reader["supplier_name"] != System.DBNull.Value) SupplierName = (System.String) reader["supplier_name"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ProductSupplierId == Guid.Empty)
                ProductSupplierId = Guid.NewGuid();

            string sql = "insert into [product_supplier] (product_supplier_id, product_id, supplier_name, user_id, date_time)";
            sql += "            values (@product_supplier_id, @product_id, @supplier_name, @user_id, @date_time)";

            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_supplier_id",SqlDbType.UniqueIdentifier).Value = (ProductSupplierId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductSupplierId);
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (ProductId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductId);
                    command.Parameters.Add("@supplier_name",SqlDbType.NVarChar).Value = (SupplierName == null ? (object)DBNull.Value : (System.String)SupplierName);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductSupplierId == Guid.Empty)
                ProductSupplierId = Guid.NewGuid();

            string sql = "insert into [product_supplier] (product_supplier_id, product_id, supplier_name, user_id, date_time)";
            sql += "            values (@product_supplier_id, @product_id, @supplier_name, @user_id, @date_time)";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_supplier_id",SqlDbType.UniqueIdentifier).Value = (ProductSupplierId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductSupplierId);
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (ProductId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductId);
                command.Parameters.Add("@supplier_name",SqlDbType.NVarChar).Value = (SupplierName == null ? (object)DBNull.Value : (System.String)SupplierName);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_supplier] set
                 product_supplier_id = @product_supplier_id
                ,product_id = @product_id
                ,supplier_name = @supplier_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_supplier_id = @product_supplier_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_supplier_id",SqlDbType.UniqueIdentifier).Value = (ProductSupplierId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductSupplierId);
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (ProductId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductId);
                    command.Parameters.Add("@supplier_name",SqlDbType.NVarChar).Value = (SupplierName == null ? (object)DBNull.Value : (System.String)SupplierName);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_supplier] set
                 product_supplier_id = @product_supplier_id
                ,product_id = @product_id
                ,supplier_name = @supplier_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_supplier_id = @product_supplier_id";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_supplier_id",SqlDbType.UniqueIdentifier).Value = (ProductSupplierId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductSupplierId);
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (ProductId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductId);
                command.Parameters.Add("@supplier_name",SqlDbType.NVarChar).Value = (SupplierName == null ? (object)DBNull.Value : (System.String)SupplierName);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Delete(System.Guid id) {
            string sql = @" delete [product_supplier] 
                where product_supplier_id = @product_supplier_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_supplier_id",SqlDbType.UniqueIdentifier).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
