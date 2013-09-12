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
    /// 实体对象 WF_DETAIL(工作流实例明细)。
    /// </summary>
    [Serializable()]
    [Table("dbo.WF_DETAIL", "工作流实例明细")]
    partial class WF_DETAIL : DataEntity<WF_DETAIL>, IDataEntity<WF_DETAIL>
    {
        public WF_DETAIL()
        {
        }

        protected WF_DETAIL(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #region O/R映射成员

        /// <summary>
        /// WFD_ID 。
        /// </summary>
        [Column("WFD_ID", "WFD_ID"), DataSize(50), PrimaryKey]
        [DisplayName("WFD_ID")]
        public string WFD_ID
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
        /// CURRENT_STEP_ID 。
        /// </summary>
        [Column("Current_STEP_ID", "Current_STEP_ID"), DataSize(50)]
        [DisplayName("Current_STEP_ID")]
        public string Current_STEP_ID
        {
            get;
            set;
        }

        /// <summary>
        /// 接收日期 。
        /// </summary>
        [Column("RECIVEDATE", "接收日期"), DataSize(50)]
        [DisplayName("接收日期")]
        public string RECIVEDATE
        {
            get;
            set;
        }

        /// <summary>
        /// 完成日期 。
        /// </summary>
        [Column("COMPLEMENTDATE", "完成日期"), DataSize(50)]
        [DisplayName("完成日期")]
        public string COMPLEMENTDATE
        {
            get;
            set;
        }

        /// <summary>
        /// 是否通过 。
        /// </summary>
        [Column("IS_Through", "是否退回"), DataSize(1)]
        [DisplayName("是否通过")]
        public string IS_Through
        {
            get;
            set;
        }
        /// <summary>
        /// 是否通过 。
        /// </summary>
        [Column("MSG", "是否退回"), DataSize(300)]
        [DisplayName("描述")]
        public string MSG
        {
            get;
            set;
        }
        /// <summary>
        /// 节点表中的主键 。
        /// </summary>
        [Column("WFT_STEP_ID", ""), DataSize(50)]
        [DisplayName("节点表中的主键")]
        public string WFT_STEP_ID
        {
            get;
            set;
        }

            /// <summary>
        /// 删除标识 。
        /// </summary>
        [Column("DEL_FLAG", ""), DataSize(1)]
        [DisplayName("删除标识")]
        public string DEL_FLAG
        {
            get;
            set;
        }
        
        #endregion
    }
}
