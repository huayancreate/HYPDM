using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Data;
using EAS.Data.ORM;
using EAS.Data.Linq;
using EAS.Modularization;
using System.IO;
using System.Runtime.Serialization;
using EAS.Data.Access;
using System.ComponentModel;

namespace HYPDM.Entities
{
     /// <summary>
   /// 实体对象 WF_ TEMPLATES_STEP(WF_ TEMPLATES_STEP)。
   /// </summary>
   [Serializable()]
   [Table("dbo.WF_TEMPLATES_STEP","WF_TEMPLATES_STEP")]
    public partial class WF_TEMPLATES_STEP : DataEntity<WF_TEMPLATES_STEP>, IDataEntity<WF_TEMPLATES_STEP>
   {
       public WF_TEMPLATES_STEP()
       {
       }
       
       protected WF_TEMPLATES_STEP(SerializationInfo info, StreamingContext context)
           : base(info, context)
       {
       }
       
       #region O/R映射成员

       /// <summary>
       /// WFT_STEP_ID 。
       /// </summary>
       [Column("WFT_STEP_ID","WFT_STEP_ID"),DataSize(50),PrimaryKey]
       [DisplayName("WFT_STEP_ID")]
       public string WFT_STEP_ID
       {
           get;
           set;
       }

       /// <summary>
       /// WFT_CURRENT_STEP_ID 。
       /// </summary>
       [Column("WFT_CURRENT_STEP_ID","WFT_CURRENT_STEP_ID"),DataSize(50)]
       [DisplayName("WFT_CURRENT_STEP_ID")]
       public string WFT_CURRENT_STEP_ID
       {
           get;
           set;
       }

       /// <summary>
       /// WFT_CURRENT_STEP_USERID 。
       /// </summary>
       [Column("WFT_CURRENT_STEP_USERID","WFT_CURRENT_STEP_USERID"),DataSize(50)]
       [DisplayName("WFT_CURRENT_STEP_USERID")]
       public string WFT_CURRENT_STEP_USERID
       {
           get;
           set;
       }

       /// <summary>
       /// WFT_CURRENT_STEP_USERTYPE 。
       /// </summary>
       [Column("WFT_CURRENT_STEP_USERTYPE","WFT_CURRENT_STEP_USERTYPE"),DataSize(50)]
       [DisplayName("WFT_CURRENT_STEP_USERTYPE")]
       public string WFT_CURRENT_STEP_USERTYPE
       {
           get;
           set;
       }

       /// <summary>
       /// WFT_NEXT_STEP_ID 。
       /// </summary>
       [Column("WFT_NEXT_STEP_ID","WFT_NEXT_STEP_ID"),DataSize(50)]
       [DisplayName("WFT_NEXT_STEP_ID")]
       public string WFT_NEXT_STEP_ID
       {
           get;
           set;
       }

       /// <summary>
       /// IS_START_STEP 。
       /// </summary>
       [Column("IS_START_STEP","IS_START_STEP"),DataSize(1)]
       [DisplayName("IS_START_STEP")]
       public string IS_START_STEP
       {
           get;
           set;
       }

       /// <summary>
       /// IS_ALLOW_EDIT 。
       /// </summary>
       [Column("IS_ALLOW_EDIT","IS_ALLOW_EDIT"),DataSize(1)]
       [DisplayName("IS_ALLOW_EDIT")]
       public string IS_ALLOW_EDIT
       {
           get;
           set;
       }

       /// <summary>
       /// IS_ALLOW_DELETE 。
       /// </summary>
       [Column("IS_ALLOW_DELETE","IS_ALLOW_DELETE"),DataSize(1)]
       [DisplayName("IS_ALLOW_DELETE")]
       public string IS_ALLOW_DELETE
       {
           get;
           set;
       }

       /// <summary>
       /// IS_NOTE_STARTUSER 。
       /// </summary>
       [Column("IS_NOTE_STARTUSER","IS_NOTE_STARTUSER"),DataSize(1)]
       [DisplayName("IS_NOTE_STARTUSER")]
       public string IS_NOTE_STARTUSER
       {
           get;
           set;
       }

       /// <summary>
       /// IS_OPT1 。
       /// </summary>
       [Column("IS_OPT1","IS_OPT1"),DataSize(1)]
       [DisplayName("IS_OPT1")]
       public string IS_OPT1
       {
           get;
           set;
       }

       /// <summary>
       /// IS_OPT2 。
       /// </summary>
       [Column("IS_OPT2","IS_OPT2"),DataSize(1)]
       [DisplayName("IS_OPT2")]
       public string IS_OPT2
       {
           get;
           set;
       }

       /// <summary>
       /// IS_OPT3 。
       /// </summary>
       [Column("IS_OPT3","IS_OPT3"),DataSize(1)]
       [DisplayName("IS_OPT3")]
       public string IS_OPT3
       {
           get;
           set;
       }

       /// <summary>
       /// CREATEDATE 。
       /// </summary>
       [Column("CREATEDATE","CREATEDATE"),DataSize(50)]
       [DisplayName("CREATEDATE")]
       public string CREATEDATE
       {
           get;
           set;
       }

       /// <summary>
       /// CREATEUSER 。
       /// </summary>
       [Column("CREATEUSER","CREATEUSER"),DataSize(50)]
       [DisplayName("CREATEUSER")]
       public string CREATEUSER
       {
           get;
           set;
       }

       /// <summary>
       /// LASTUPDATEUSER 。
       /// </summary>
       [Column("LASTUPDATEUSER","LASTUPDATEUSER"),DataSize(50)]
       [DisplayName("LASTUPDATEUSER")]
       public string LASTUPDATEUSER
       {
           get;
           set;
       }

       /// <summary>
       /// LASTUPDATEDATE 。
       /// </summary>
       [Column("LASTUPDATEDATE","LASTUPDATEDATE"),DataSize(50)]
       [DisplayName("LASTUPDATEDATE")]
       public string LASTUPDATEDATE
       {
           get;
           set;
       }

       /// <summary>
       /// DEL_FLAG 。
       /// </summary>
       [Column("DEL_FLAG","DEL_FLAG"),DataSize(1)]
       [DisplayName("DEL_FLAG")]
       public string DEL_FLAG
       {
           get;
           set;
       }

       /// <summary>
       /// WFT_STEP_DESC 。
       /// </summary>
       [Column("WFT_STEP_DESC","WFT_STEP_DESC"),DataSize(50)]
       [DisplayName("WFT_STEP_DESC")]
       public string WFT_STEP_DESC
       {
           get;
           set;
       }
       /// <summary>
       /// WFT_ID 。
       /// </summary>
       [Column("WFT_ID", "WFT_ID"), DataSize(50)]
       [DisplayName("WFT_STEP_DESC")]
       public string WFT_ID
       {
           get;
           set;
       }
       /// <summary>
       /// IS_END_STEP 。
       /// </summary>
       [Column("IS_END_STEP", "IS_END_STEP"), DataSize(1)]
       [DisplayName("IS_END_STEP")]
       public string IS_END_STEP
       {
           get;
           set;
       }
       #endregion
   }
}
