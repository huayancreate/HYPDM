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
    /// 实体对象 WF_TEMPLATES_OBJECT(WF_TEMPLATES_OBJECT)。
    /// </summary>
    [Serializable()]
    [Table("dbo.WF_TEMPLATES_OBJECT", "WF_TEMPLATES_OBJECT")]
   public  partial class WF_TEMPLATES_OBJECT : DataEntity<WF_TEMPLATES_OBJECT>
    {
        public WF_TEMPLATES_OBJECT()
        {
        }

        protected WF_TEMPLATES_OBJECT(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #region O/R映射成员

        /// <summary>
        /// OBJECTVALUE 。
        /// </summary>
        [Column("OBJECTVALUE", "OBJECTVALUE"), DataSize(50), PrimaryKey]
        [DisplayName("OBJECTVALUE")]
        public string OBJECTVALUE
        {
            get;
            set;
        }

        /// <summary>
        /// OBJECTDESC 。
        /// </summary>
        [Column("OBJECTDESC", "OBJECTDESC"), DataSize(50)]
        [DisplayName("OBJECTDESC")]
        public string OBJECTDESC
        {
            get;
            set;
        }

        /// <summary>
        /// WFT_ID 。
        /// </summary>
        [Column("WFT_ID", "WFT_ID"), DataSize(50)]
        [DisplayName("WFT_ID")]
        public string WFT_ID
        {
            get;
            set;
        }

        /// <summary>
        /// LASTUPDATEUSER 。
        /// </summary>
        [Column("LASTUPDATEUSER", "LASTUPDATEUSER"), DataSize(50)]
        [DisplayName("LASTUPDATEUSER")]
        public string LASTUPDATEUSER
        {
            get;
            set;
        }

        /// <summary>
        /// LASTUPDATEDATE 。
        /// </summary>
        [Column("LASTUPDATEDATE", "LASTUPDATEDATE"), DataSize(50)]
        [DisplayName("LASTUPDATEDATE")]
        public string LASTUPDATEDATE
        {
            get;
            set;
        }

        #endregion
    }
}
