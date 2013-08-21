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
   /// 实体对象 DOC_FILE_LIST(DOC_FILE_LIST)。
   /// </summary>
   [Serializable()]
   [Table("dbo.DOC_FILE_LIST","DOC_FILE_LIST")]
   partial class DOC_FILE_LIST: DataEntity<DOC_FILE_LIST>, IDataEntity<DOC_FILE_LIST>
   {
       public DOC_FILE_LIST()
       {
       }
       
       protected DOC_FILE_LIST(SerializationInfo info, StreamingContext context)
           : base(info, context)
       {
          
       }
       
       #region O/R映射成员

       /// <summary>
       /// 主键 。
       /// </summary>
       [Column("DFL_ID","主键"),DataSize(50),PrimaryKey]
       [DisplayName("主键")]
       public string DFL_ID
       {
           get;
           set;
       }

       /// <summary>
       /// 文件名称 。
       /// </summary>
       [Column("DFL_FILE_NAME","文件名称"),DataSize(100)]
       [DisplayName("文件名称")]
       public string DFL_FILE_NAME
       {
           get;
           set;
       }

       /// <summary>
       /// 扩展名\后缀 。
       /// </summary>
       [Column("DFL_FILE_EXTEND","扩展名后缀"),DataSize(10)]
       [DisplayName("扩展名后缀")]
       public string DFL_FILE_EXTEND
       {
           get;
           set;
       }

       /// <summary>
       /// 子路径、子目录 。
       /// </summary>
       [Column("DFL_FILE_CHILD_PATH","子路径、子目录"),DataSize(300)]
       [DisplayName("子路径、子目录")]
       public string DFL_FILE_CHILD_PATH
       {
           get;
           set;
       }

       /// <summary>
       /// 最新版本号 。
       /// </summary>
       [Column("DFL_VER_LATEST","最新版本号"),DataSize(20)]
       [DisplayName("最新版本号")]
       public string DFL_VER_LATEST
       {
           get;
           set;
       }

       /// <summary>
       /// 删除标示 。
       /// </summary>
       [Column("DEL_FLAG","删除标示"),DataSize(1)]
       [DisplayName("删除标示")]
       public string DEL_FLAG
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
       /// DOCID 。
       /// </summary>
       [Column("DOCID", "DOCID"), DataSize(128)]
       [DisplayName("DOCID")]
       public string DOCID
       {
           get;
           set;
       }
       /// <summary>
       /// CHECKINFLG 。
       /// </summary>
       [Column("CHECKINFLG", "CHECKINFLG"), DataSize(1)]
       [DisplayName("CHECKINFLG")]
       public string CHECKINFLG
       {
           get;
           set;
       }
       /// <summary>
       /// CHECKOUTFLG 。
       /// </summary>
       [Column("CHECKOUTFLG", "CHECKOUTFLG"), DataSize(1)]
       [DisplayName("CHECKOUTFLG")]
       public string CHECKOUTFLG
       {
           get;
           set;
       }
       /// <summary>
       /// CHECKINDATE 。
       /// </summary>
       [Column("CHECKINDATE", "CHECKINDATE"), DataSize(50)]
       [DisplayName("CHECKINDATE")]
       public string CHECKINDATE
       {
           get;
           set;
       }
       /// <summary>
       /// CHECKOUTDATE 。
       /// </summary>
       [Column("CHECKOUTDATE", "CHECKOUTDATE"), DataSize(50)]
       [DisplayName("CHECKOUTDATE")]
       public string CHECKOUTDATE
       {
           get;
           set;
       }
       #endregion
   }
}
