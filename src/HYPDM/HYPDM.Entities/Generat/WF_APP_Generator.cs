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
   /// 实体对象 WF_APP(工作流实例)。
   /// </summary>
    [Serializable()]
    [Table("dbo.WF_APP", "工作流实例")]
   public  partial class WF_APP : DataEntity<WF_APP>,IDataEntity<WF_APP>
    {
        public WF_APP()
        {
        }

        protected WF_APP(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #region O/R映射成员

        /// <summary>
        /// WFA_ID 。
        /// </summary>
        [Column("WFA_ID", "WFA_ID"), DataSize(50), PrimaryKey]
        [DisplayName("WFA_ID")]
        public string WFA_ID
        {
            get;
            set;
        }

        /// <summary>
        /// 流程模板 。
        /// </summary>
        [Column("WFT_ID", "流程模板"), DataSize(50)]
        [DisplayName("流程模板")]
        public string WFT_ID
        {
            get;
            set;
        }

        /// <summary>
        /// STATUS 。
        /// </summary>
        [Column("STATUS", "STATUS"), DataSize(50)]
        [DisplayName("STATUS")]
        public string STATUS
        {
            get;
            set;
        }

        /// <summary>
        /// 主题 。
        /// </summary>
        [Column("SUBJECT", "主题"), DataSize(150)]
        [DisplayName("主题")]
        public string SUBJECT
        {
            get;
            set;
        }

        /// <summary>
        /// CREATEDATE 。
        /// </summary>
        [Column("CREATEDATE", "CREATEDATE"), DataSize(50)]
        [DisplayName("CREATEDATE")]
        public string CREATEDATE
        {
            get;
            set;
        }

        /// <summary>
        /// CREATEUSER 。
        /// </summary>
        [Column("CREATEUSER", "CREATEUSER"), DataSize(50)]
        [DisplayName("CREATEUSER")]
        public string CREATEUSER
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

        /// <summary>
        /// 删除标识 。
        /// </summary>
        [Column("DEL_FLAG", "删除标识"), DataSize(1)]
        [DisplayName("删除标识")]
        public string DEL_FLAG
        {
            get;
            set;
        }

        /// <summary>
        /// 启动日期 。
        /// </summary>
        [Column("START_DATE", "启动日期"), DataSize(50)]
        [DisplayName("启动日期")]
        public string START_DATE
        {
            get;
            set;
        }

        /// <summary>
        /// OBJECTKEY 。
        /// </summary>
        [Column("OBJECTKEY", "OBJECTKEY"), DataSize(50)]
        [DisplayName("OBJECTKEY")]
        public string OBJECTKEY
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

        #endregion
    }
}
