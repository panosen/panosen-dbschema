using System;
using System.Collections.Generic;
using System.Text;

namespace Panosen.DBSchema.Mysql.InformationSchema
{
    /// <summary>
    /// 表
    /// information_schema.tables
    /// </summary>
    public class Table
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string TABLE_NAME { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        public string TABLE_COMMENT { get; set; }
    }
}
