using Dapper;
using MySql.Data.MySqlClient;
using Panosen.DBSchema.Mysql.InformationSchema;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Panosen.DBSchema.Mysql
{
    /// <summary>
    /// 读取Mysql架构
    /// </summary>
    public class SchemaRepository
    {
        private readonly MySqlConnection connection;

        /// <summary>
        /// 读取Mysql架构
        /// </summary>
        /// <param name="connection"></param>
        public SchemaRepository(MySqlConnection connection)
        {
            this.connection = connection;
        }

        /// <summary>
        /// 获取所有数据库
        /// </summary>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public List<Table> GetTables(string dbName)
        {
            string sql = @"
select
    *
from information_schema.tables
where
    TABLE_SCHEMA = @DBName and TABLE_TYPE = 'BASE TABLE';";

            return connection.Query<Table>(sql, new { DBName = dbName }).ToList();
        }

        /// <summary>
        /// 获取数据库所有字段(表+视图)
        /// </summary>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public List<Column> GetColumns(string dbName)
        {
            string sql = @"
select
    *
from information_schema.columns
where
    TABLE_SCHEMA = @DBName;";

            return connection.Query<Column>(sql, new { DBName = dbName }).ToList();
        }

        /// <summary>
        /// 获取数据库指定表的字段
        /// </summary>
        /// <param name="dbName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public List<Column> GetColumns(string dbName, string tableName)
        {
            string sql = @"
select
    *
from information_schema.columns
where
    TABLE_SCHEMA = @DBName and TABLE_NAME = @TableName;";

            return connection.Query<Column>(sql, new { DBName = dbName, TableName = tableName }).ToList();
        }

        /// <summary>
        /// 获取数据库所有约束
        /// </summary>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public List<KeyColumnUsage> GetKeyColumnUsages(string dbName)
        {
            string sql = @"
select
    *
from INFORMATION_SCHEMA.KEY_COLUMN_USAGE
where
    TABLE_SCHEMA = @DBName;";

            return connection.Query<KeyColumnUsage>(sql, new { DBName = dbName }).ToList();
        }

        /// <summary>
        /// 获取数据库指定表的字段
        /// </summary>
        /// <param name="dbName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public List<KeyColumnUsage> GetKeyColumnUsages(string dbName, string tableName)
        {
            string sql = @"
select
    *
from INFORMATION_SCHEMA.KEY_COLUMN_USAGE
where
    TABLE_SCHEMA = @DBName and TABLE_NAME = @TableName;";

            return connection.Query<KeyColumnUsage>(sql, new { DBName = dbName, TableName = tableName }).ToList();
        }

        /// <summary>
        /// 获取数据库所有统计
        /// </summary>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public List<Statistics> GetStatistics(string dbName)
        {
            string sql = @"
select
    *
from INFORMATION_SCHEMA.STATISTICS
where
    TABLE_SCHEMA = @DBName;";

            return connection.Query<Statistics>(sql, new { DBName = dbName }).ToList();
        }

        /// <summary>
        /// 获取数据库指定表的统计
        /// </summary>
        /// <param name="dbName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public List<Statistics> GetStatistics(string dbName, string tableName)
        {
            string sql = @"
select
    *
from INFORMATION_SCHEMA.STATISTICS
where
    TABLE_SCHEMA = @DBName and TABLE_NAME = @TableName;";

            return connection.Query<Statistics>(sql, new { DBName = dbName, TableName = tableName }).ToList();
        }
    }
}
