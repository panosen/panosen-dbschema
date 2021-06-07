using System;
using System.Collections.Generic;
using System.Text;

namespace Panosen.DBSchema.Sqlite
{
    /// <summary>
    /// FieldEntity
    /// </summary>
    public class FieldEntity
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// NotNull
        /// </summary>
        public bool NotNull { get; set; }

        /// <summary>
        /// DefaultValue
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// PK
        /// </summary>
        public bool PK { get; set; }
    }
}
