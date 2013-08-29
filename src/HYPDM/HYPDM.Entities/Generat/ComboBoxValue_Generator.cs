using System;
using System.ComponentModel;
using System.Data;
using EAS.Data;
using EAS.Data.Access;
using EAS.Data.ORM;
using System.Runtime.Serialization;

namespace HYPDM.Entities
{
    /// <summary>
    /// 实体对象 ComboBoxValue(ComboBoxValue)。
    /// </summary>
    [Serializable()]
    [Table("dbo.ComboBoxValue", "ComboBoxValue")]
    partial class ComboBoxValue : DataEntity<ComboBoxValue>, IDataEntity<ComboBoxValue>
    {
        public ComboBoxValue()
        {
        }

        protected ComboBoxValue(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #region O/R映射成员

        /// <summary>
        /// COMBTYPE 。
        /// </summary>
        [Column("COMBTYPE", "COMBTYPE"), DataSize(100)]
        [DisplayName("COMBTYPE")]
        public string COMBTYPE
        {
            get;
            set;
        }

        /// <summary>
        /// COMBID 。
        /// </summary>
        [Column("COMBID", "COMBID"), DataSize(100), PrimaryKey]
        [DisplayName("COMBID")]
        public string COMBID
        {
            get;
            set;
        }

        /// <summary>
        /// COMBTEXT 。
        /// </summary>
        [Column("COMBTEXT", "COMBTEXT"), DataSize(100)]
        [DisplayName("COMBTEXT")]
        public string COMBTEXT
        {
            get;
            set;
        }

        /// <summary>
        /// COMBVALUE 。
        /// </summary>
        [Column("COMBVALUE", "COMBVALUE"), DataSize(100)]
        [DisplayName("COMBVALUE")]
        public string COMBVALUE
        {
            get;
            set;
        }

        /// <summary>
        /// COMBDESC 。
        /// </summary>
        [Column("COMBDESC", "COMBDESC"), DataSize(100)]
        [DisplayName("COMBDESC")]
        public string COMBDESC
        {
            get;
            set;
        }

        #endregion
    }
}
