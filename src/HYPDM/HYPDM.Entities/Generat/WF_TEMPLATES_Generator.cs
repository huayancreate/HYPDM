using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Data;
using EAS.Data.ORM;
using System.ComponentModel;
using System.Runtime.Serialization;
namespace HYPDM.Entities
{
   /// <summary>
   /// 实体对象 WF_ TEMPLATES(WF_ TEMPLATES)。
   /// </summary>
   [Serializable()]
   [Table("dbo.WF_TEMPLATES","WF_TEMPLATES")]
   public partial class WF_TEMPLATES : DataEntity<WF_TEMPLATES>, IDataEntity<WF_TEMPLATES>
   {
       public WF_TEMPLATES()
       {
       }
       
       protected WF_TEMPLATES(SerializationInfo info, StreamingContext context)
           : base(info, context)
       {

       }
       
       #region O/R映射成员

       /// <summary>
       /// WFT_ID 。
       /// </summary>
       [Column("WFT_ID","WFT_ID"),DataSize(50),PrimaryKey]
       [DisplayName("WFT_ID")]
       public string WFT_ID
       {
           get;
           set;
       }

       /// <summary>
       /// WFT_NAME 。
       /// </summary>
       [Column("WFT_NAME","WFT_NAME"),DataSize(100)]
       [DisplayName("WFT_NAME")]
       public string WFT_NAME
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
       
       #endregion
   }
}
