using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.DBSchema.Mysql.InformationSchema
{
    /// <summary>
    /// INFORMATION_SCHEMA.STATISTICS
    /// https://dev.mysql.com/doc/mysql-infoschema-excerpt/8.0/en/information-schema-statistics-table.html
    /// </summary>
    public class Statistics
    {
        /// <summary>
        /// The name of the catalog to which the table containing the index belongs. This value is always def.
        /// </summary>
        public string TABLE_CATALOG { get; set; }

        /// <summary>
        /// The name of the schema (database) to which the table containing the index belongs.
        /// </summary>
        public string TABLE_SCHEMA { get; set; }

        /// <summary>
        /// The name of the table containing the index.
        /// </summary>
        public string TABLE_NAME { get; set; }

        /// <summary>
        /// 0 if the index cannot contain duplicates, 1 if it can.
        /// </summary>
        public int NON_UNIQUE { get; set; }

        /// <summary>
        /// The name of the schema (database) to which the index belongs.
        /// </summary>
        public string INDEX_SCHEMA { get; set; }

        /// <summary>
        /// The name of the index. If the index is the primary key, the name is always PRIMARY.
        /// </summary>
        public string INDEX_NAME { get; set; }

        /// <summary>
        /// The column sequence number in the index, starting with 1.
        /// </summary>
        public uint SEQ_IN_INDEX { get; set; }

        /// <summary>
        /// The column name. See also the description for the EXPRESSION column.
        /// </summary>
        public string COLUMN_NAME { get; set; }

        /// <summary>
        /// How the column is sorted in the index. This can have values A (ascending), D (descending), or NULL (not sorted).
        /// </summary>
        public string COLLATION { get; set; }

        /// <summary>
        /// An estimate of the number of unique values in the index. To update this number, run ANALYZE TABLE or (for MyISAM tables) myisamchk -a.
        /// CARDINALITY is counted based on statistics stored as integers, so the value is not necessarily exact even for small tables.
        /// The higher the cardinality, the greater the chance that MySQL uses the index when doing joins.
        /// </summary>
        public string CARDINALITY { get; set; }

        /// <summary>
        /// The index prefix. That is, the number of indexed characters if the column is only partly indexed, NULL if the entire column is indexed.
        /// </summary>
        public string SUB_PART { get; set; }

        /// <summary>
        /// Indicates how the key is packed. NULL if it is not.
        /// </summary>
        public string PACKED { get; set; }

        /// <summary>
        /// Contains YES if the column may contain NULL values and '' if not.
        /// </summary>
        public string NULLABLE { get; set; }

        /// <summary>
        /// The index method used (BTREE, FULLTEXT, HASH, RTREE).
        /// </summary>
        public string INDEX_TYPE { get; set; }

        /// <summary>
        /// Information about the index not described in its own column, such as disabled if the index is disabled.
        /// </summary>
        public string COMMENT { get; set; }

        /// <summary>
        /// Any comment provided for the index with a COMMENT attribute when the index was created.
        /// </summary>
        public string INDEX_COMMENT { get; set; }

        /// <summary>
        /// Whether the index is visible to the optimizer. See Invisible Indexes.
        /// </summary>
        public string IS_VISIBLE { get; set; }

        /// <summary>
        /// MySQL 8.0.13 and higher supports functional key parts
        /// </summary>
        public string EXPRESSION { get; set; }
    }
}
