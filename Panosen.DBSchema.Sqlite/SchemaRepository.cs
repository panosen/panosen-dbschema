using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace Panosen.DBSchema.Sqlite
{
    /// <summary>
    /// SchemaRepository
    /// </summary>
    public class SchemaRepository
    {
        /// <summary>
        /// GetTableEntityList
        /// </summary>
        /// <param name="conn"></param>
        /// <returns></returns>
        public static List<TableEntity> GetTableEntityList(SQLiteConnection conn)
        {
            string sql = "select name from sqlite_master where name != 'sqlite_sequence' order by name asc;";

            return conn.Query<TableEntity>(sql).ToList();
        }

        /// <summary>
        /// GetFieldEntityList
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static List<FieldEntity> GetFieldEntityList(SQLiteConnection conn, string tableName)
        {
            string sql = $"PRAGMA  table_info([{tableName}]);";

            return conn.Query<FieldEntity>(sql).ToList();
        }
    }
}
