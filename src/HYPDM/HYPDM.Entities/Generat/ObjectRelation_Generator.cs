
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
    /// 实体对象 ObjectRelation(ObjectRelation)。
    /// </summary>
    [Serializable()]
    [Table("dbo.ObjectRelation", "ObjectRelation")]
    public partial class ObjectRelation : DataEntity<ObjectRelation>
    {

        public ObjectRelation()
        {
        }

        protected ObjectRelation(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #region O/R映射成员

        /// <summary>
        /// ORID 。
        /// </summary>
        [Column("ORID", "ORID"), DataSize(50), PrimaryKey]
        [DisplayName("ORID")]
        public string ORID
        {
            get;
            set;
        }

        /// <summary>
        /// MASTEROBJECTID 。
        /// </summary>
        [Column("MASTEROBJECTID", "MASTEROBJECTID"), DataSize(50)]
        [DisplayName("MASTEROBJECTID")]
        public string MASTEROBJECTID
        {
            get;
            set;
        }

        /// <summary>
        /// MASTEROBJECTTYPE 。
        /// </summary>
        [Column("MASTEROBJECTTYPE", "MASTEROBJECTTYPE"), DataSize(50)]
        [DisplayName("MASTEROBJECTTYPE")]
        public string MASTEROBJECTTYPE
        {
            get;
            set;
        }

        /// <summary>
        /// MASTEROBJECTVERSION 。
        /// </summary>
        [Column("MASTEROBJECTVERSION", "MASTEROBJECTVERSION"), DataSize(50)]
        [DisplayName("MASTEROBJECTVERSION")]
        public string MASTEROBJECTVERSION
        {
            get;
            set;
        }

        /// <summary>
        /// RELATIONOBJECTID 。
        /// </summary>
        [Column("RELATIONOBJECTID", "RELATIONOBJECTID"), DataSize(50)]
        [DisplayName("RELATIONOBJECTID")]
        public string RELATIONOBJECTID
        {
            get;
            set;
        }

        /// <summary>
        /// RELATIONOBJECTTYPE 。
        /// </summary>
        [Column("RELATIONOBJECTTYPE", "RELATIONOBJECTTYPE"), DataSize(50)]
        [DisplayName("RELATIONOBJECTTYPE")]
        public string RELATIONOBJECTTYPE
        {
            get;
            set;
        }

        /// <summary>
        /// RELATIONOBJECTVERSION 。
        /// </summary>
        [Column("RELATIONOBJECTVERSION", "RELATIONOBJECTVERSION"), DataSize(50)]
        [DisplayName("RELATIONOBJECTVERSION")]
        public string RELATIONOBJECTVERSION
        {
            get;
            set;
        }

        /// <summary>
        /// OPT1 。
        /// </summary>
        [Column("OPT1", "OPT1"), DataSize(50)]
        [DisplayName("OPT1")]
        public string OPT1
        {
            get;
            set;
        }

        /// <summary>
        /// OPT2 。
        /// </summary>
        [Column("OPT2", "OPT2"), DataSize(50)]
        [DisplayName("OPT2")]
        public string OPT2
        {
            get;
            set;
        }
        /// <summary>
        /// OPT2 。
        /// </summary>
        [Column("DEL_FALG", "DEL_FALG"), DataSize(1)]
        [DisplayName("DEL_FALG")]
        public string DEL_FALG
        {
            get;
            set;
        }
        #endregion
    }
}
