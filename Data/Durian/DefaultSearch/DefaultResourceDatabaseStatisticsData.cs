﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/30/2020 6:48:13 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {

    [Serializable()]
    public partial class DefaultResourceDatabaseStatisticsData {
        
        public int ReservedPageCount { get; set; }
        
        public void Populate(IDataReader reader, DefaultResourceDatabaseStatisticsDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ReservedPageCount)) ReservedPageCount = reader.GetInt32(ordinals.ReservedPageCount);
        }
    }
    
    public partial class DefaultResourceDatabaseStatisticsDataOrdinals {
        
        public int ReservedPageCount;
        
        public DefaultResourceDatabaseStatisticsDataOrdinals(IDataReader reader) {
            ReservedPageCount = reader.GetOrdinal("reserved_page_count");
        }
    }
}
