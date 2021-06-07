using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.DBSchema.Mysql.InformationSchema
{
    /// <summary>
    /// 主键和外键
    /// INFORMATION_SCHEMA.KEY_COLUMN_USAGE
    /// https://dev.mysql.com/doc/mysql-infoschema-excerpt/8.0/en/information-schema-key-column-usage-table.html
    /// </summary>
    public class KeyColumnUsage
    {

        /// <summary>
        /// 约束所属的目录的名称。 该值始终为def
        /// </summary>
        public string CONSTRAINT_CATALOG { get; set; }

        /// <summary>
        /// 约束所属的结构（数据库）的名称
        /// </summary>
        public string CONSTRAINT_SCHEMA { get; set; }

        /// <summary>
        /// 约束名称
        /// </summary>
        public string CONSTRAINT_NAME { get; set; }

        /// <summary>
        /// 包含索引的表所属的目录的名称。 该值始终为def
        /// </summary>
        public string TABLE_CATALOG { get; set; }

        /// <summary>
        /// 具有约束的表的数据库名称
        /// </summary>
        public string TABLE_SCHEMA { get; set; }

        /// <summary>
        /// 具有约束的表的名称
        /// </summary>
        public string TABLE_NAME { get; set; }

        /// <summary>
        /// 具有约束的列的名称。如果约束是外键，那么这是外键的列，而不是外键引用的列
        /// </summary>
        public string COLUMN_NAME { get; set; }

        /// <summary>
        /// 列在约束内的位置，而不是列在表中的位置。 列位置从1开始编号
        /// </summary>
        public uint ORDINAL_POSITION { get; set; }

        /// <summary>
        /// NULL表示唯一和主键约束。 对于外键约束，此列是正在引用的表的键中的序号位置
        /// </summary>
        public string POSITION_IN_UNIQUE_CONSTRAINT { get; set; }

        /// <summary>
        /// 约束引用的结构（数据库）的名称
        /// </summary>
        public string REFERENCED_TABLE_SCHEMA { get; set; }

        /// <summary>
        /// 约束引用的表的名称
        /// </summary>
        public string REFERENCED_TABLE_NAME { get; set; }

        /// <summary>
        /// 约束引用的列的名称
        /// </summary>
        public string REFERENCED_COLUMN_NAME { get; set; }

    }
}
