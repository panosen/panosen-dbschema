using System;
using System.Collections.Generic;
using System.Text;

namespace Panosen.DBSchema.Mysql.InformationSchema
{
    /// <summary>
    /// 字段
    /// information_schema.columns
    /// </summary>
    public class Column
    {
        /// <summary>
        /// 固定值def
        /// </summary>
        public string TABLE_CATALOG { get; set; }

        /// <summary>
        /// 表名
        /// </summary>
        public string TABLE_SCHEMA { get; set; }

        /// <summary>
        /// 表名
        /// </summary>
        public string TABLE_NAME { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string COLUMN_NAME { get; set; }

        /// <summary>
        /// 列排序
        /// </summary>
        public ulong ORDINAL_POSITION { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        public string COLUMN_DEFAULT { get; set; }

        /// <summary>
        /// 字段是否可为空
        /// YES 或 NO
        /// </summary>
        public string IS_NULLABLE { get; set; }

        /// <summary>
        /// 数据类型
        /// 比如 varchar, int, bigint 不包含长度
        /// </summary>
        public string DATA_TYPE { get; set; }

        /// <summary>
        /// 字段的最大字符数。
        /// 假如字段设置为varchar(50)，那么这一列记录的值就是50。
        /// 该列只适用于二进制数据，字符，文本，图像数据。其他类型数据比如int，float，datetime等，在该列显示为NULL。
        /// </summary>
        public ulong? CHARACTER_MAXIMUM_LENGTH { get; set; }

        /// <summary>
        /// 字段的最大字节数。
        /// 和最大字符数一样，只适用于二进制数据，字符，文本，图像数据，其他类型显示为NULL。
        /// 和最大字符数的数值有比例关系，和字符集有关。比如UTF8类型的表，最大字节数就是最大字符数的3倍。
        /// </summary>
        public ulong? CHARACTER_OCTET_LENGTH { get; set; }

        /// <summary>
        /// 数字精度。
        /// 适用于各种数字类型比如int，float之类的。
        /// 如果字段设置为int(10)，那么在该列保存的数值是9，少一位，还没有研究原因。
        /// 如果字段设置为float(10,3)，那么在该列报错的数值是10。
        /// 非数字类型显示为在该列NULL。
        /// </summary>
        public ulong? NUMERIC_PRECISION { get; set; }

        /// <summary>
        /// 小数位数。
        /// 和数字精度一样，适用于各种数字类型比如int，float之类。
        /// 如果字段设置为int(10)，那么在该列保存的数值是0，代表没有小数。
        /// 如果字段设置为float(10,3)，那么在该列报错的数值是3。
        /// 非数字类型显示为在该列NULL。
        /// </summary>
        public ulong? NUMERIC_SCALE { get; set; }

        /// <summary>
        /// datetime类型和SQL-92interval类型数据库的子类型代码。
        /// 我本地datetime类型的字段在该列显示为0。
        /// 其他类型显示为NULL。
        /// </summary>
        public ulong? DATETIME_PRECISION { get; set; }

        /// <summary>
        /// 字段字符集名称。比如utf8。
        /// </summary>
        public string CHARACTER_SET_NAME { get; set; }

        /// <summary>
        /// 字符集排序规则。
        /// 比如utf8_general_ci，是不区分大小写一种排序规则。utf8_general_cs，是区分大小写的排序规则。
        /// </summary>
        public string COLLATION_NAME { get; set; }

        /// <summary>
        /// 字段类型。
        /// 比如 varchar(10), int(11), bigint(20) 包含长度
        /// </summary>
        public string COLUMN_TYPE { get; set; }

        /// <summary>
        /// 索引类型。
        /// 可包含的值有PRI，代表主键，UNI，代表唯一键，MUL，可重复。
        /// </summary>
        public string COLUMN_KEY { get; set; }

        /// <summary>
        /// 额外的信息
        /// 示例：自增长的列(auto increment)
        /// </summary>
        public string EXTRA { get; set; }

        /// <summary>
        /// 权限
        /// 多个权限用逗号隔开，比如 select, insert, update, references
        /// </summary>
        public string PRIVILEGES { get; set; }

        /// <summary>
        /// 字段注释
        /// </summary>
        public string COLUMN_COMMENT { get; set; }

        /// <summary>
        /// 组合字段的公式。
        /// </summary>
        public string GENERATION_EXPRESSION { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SRS_ID { get; set; }
    }
}
