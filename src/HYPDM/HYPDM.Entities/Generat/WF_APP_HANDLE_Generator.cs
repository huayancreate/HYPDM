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
    /// 实体对象 WF_APP_HANDLE(WF_APP_HANDLE)。
    /// </summary>
    [Serializable()]
    [Table("dbo.WF_APP_HANDLE", "WF_APP_HANDLE")]
    partial class WF_APP_HANDLE : DataEntity<WF_APP_HANDLE>, IDataEntity<WF_APP_HANDLE>
    {
        public WF_APP_HANDLE()
        {
        }

        protected WF_APP_HANDLE(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #region O/R映射成员

        /// <summary>
        /// WFAH_ID 。
        /// </summary>
        [Column("WFAH_ID", "WFAH_ID"), DataSize(50), PrimaryKey]
        [DisplayName("WFAH_ID")]
        public string WFAH_ID
        {
            get;
            set;
        }

        /// <summary>
        /// WFA_ID 。
        /// </summary>
        [Column("WFA_ID", "WFA_ID"), DataSize(50)]
        [DisplayName("WFA_ID")]
        public string WFA_ID
        {
            get;
            set;
        }

        /// <summary>
        /// OBJECTTYPE 。
        /// </summary>
        [Column("OBJECTTYPE", "OBJECTTYPE"), DataSize(50)]
        [DisplayName("OBJECTTYPE")]
        public string OBJECTTYPE
        {
            get;
            set;
        }

        /// <summary>
        /// OBJECTVALUE 。
        /// </summary>
        [Column("OBJECTVALUE", "OBJECTVALUE"), DataSize(50)]
        [DisplayName("OBJECTVALUE")]
        public string OBJECTVALUE
        {
            get;
            set;
        }

        /// <summary>
        /// DEL_FLAG 。
        /// </summary>
        [Column("DEL_FLAG", "DEL_FLAG"), DataSize(1)]
        [DisplayName("DEL_FLAG")]
        public string DEL_FLAG
        {
            get;
            set;
        }

        /// <summary>
        /// WFT_STEP_ID 。
        /// </summary>
        [Column("WFT_STEP_ID", "WFT_STEP_ID"), DataSize(50)]
        [DisplayName("WFT_STEP_ID")]
        public string WFT_STEP_ID
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
        /// 节点ID 。
        /// </summary>
        [Column("Current_STEP_ID", "节点ID"), DataSize(50)]
        [DisplayName("节点ID")]
        public string Current_STEP_ID
        {
            get;
            set;
        }
           /// <summary>
        ///该节点对该用户是否通过(审批) 。
        /// </summary>
        [Column("IS_THROUGH", "是否通过"), DataSize(1)]
        [DisplayName("是否通过")]
        public string IS_THROUGH
        {
            get;
            set;
        }
        /// <summary>
        ///审批意见。
        /// </summary>
        [Column("MSG", "审批意见"), DataSize(300)]
        [DisplayName("审批意见")]
        public string MSG
        {
            get;
            set;
        }
          /// <summary>
        ///审批意见。
        /// </summary>
        [Column("COMPLEMENTDATE", "完成日期"), DataSize(50)]
        [DisplayName("完成日期")]
        public string COMPLEMENTDATE
        {
            get;
            set;
        }

        
        #endregion
    }
}
