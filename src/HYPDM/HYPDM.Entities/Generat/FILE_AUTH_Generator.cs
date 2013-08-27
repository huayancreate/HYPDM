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
   /// 实体对象 FILE_AUTH(FILE_AUTH)。
   /// </summary>
    [Serializable()]
    [Table("dbo.FILE_AUTH", "FILE_AUTH")]
    partial class FILE_AUTH : DataEntity<FILE_AUTH>, IDataEntity<FILE_AUTH>
    {
        public FILE_AUTH()
        {
        }

        protected FILE_AUTH(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #region O/R映射成员

        /// <summary>
        /// FAU_ID 。
        /// </summary>
        [Column("FAU_ID", "FAU_ID"), DataSize(50), PrimaryKey]
        [DisplayName("FAU_ID")]
        public string FAU_ID
        {
            get;
            set;
        }

        /// <summary>
        /// DFL_ID 。
        /// </summary>
        [Column("DFL_ID", "DFL_ID"), DataSize(50)]
        [DisplayName("DFL_ID")]
        public string DFL_ID
        {
            get;
            set;
        }

        /// <summary>
        /// FAU_OBJ_VALUE 。
        /// </summary>
        [Column("FAU_OBJ_VALUE", "FAU_OBJ_VALUE"), DataSize(100)]
        [DisplayName("FAU_OBJ_VALUE")]
        public string FAU_OBJ_VALUE
        {
            get;
            set;
        }

        /// <summary>
        /// FAU_OBJ_TYPE 。
        /// </summary>
        [Column("FAU_OBJ_TYPE", "FAU_OBJ_TYPE"), DataSize(50)]
        [DisplayName("FAU_OBJ_TYPE")]
        public string FAU_OBJ_TYPE
        {
            get;
            set;
        }

        /// <summary>
        /// FAU_IS_FOLDER 。
        /// </summary>
        [Column("FAU_IS_FOLDER", "FAU_IS_FOLDER"), DataSize(1)]
        [DisplayName("FAU_IS_FOLDER")]
        public string FAU_IS_FOLDER
        {
            get;
            set;
        }

        /// <summary>
        /// FAU_VIEW 。
        /// </summary>
        [Column("FAU_VIEW", "FAU_VIEW"), DataSize(1)]
        [DisplayName("FAU_VIEW")]
        public string FAU_VIEW
        {
            get;
            set;
        }

        /// <summary>
        /// FAU_EDIT 。
        /// </summary>
        [Column("FAU_EDIT", "FAU_EDIT"), DataSize(1)]
        [DisplayName("FAU_EDIT")]
        public string FAU_EDIT
        {
            get;
            set;
        }

        /// <summary>
        /// FAU_DELETE 。
        /// </summary>
        [Column("FAU_DELETE", "FAU_DELETE"), DataSize(1)]
        [DisplayName("FAU_DELETE")]
        public string FAU_DELETE
        {
            get;
            set;
        }

        /// <summary>
        /// FAU_DOWNLOAD 。
        /// </summary>
        [Column("FAU_DOWNLOAD", "FAU_DOWNLOAD"), DataSize(1)]
        [DisplayName("FAU_DOWNLOAD")]
        public string FAU_DOWNLOAD
        {
            get;
            set;
        }

        /// <summary>
        /// FAU_UPLOAD 。
        /// </summary>
        [Column("FAU_UPLOAD", "FAU_UPLOAD"), DataSize(1)]
        [DisplayName("FAU_UPLOAD")]
        public string FAU_UPLOAD
        {
            get;
            set;
        }

        /// <summary>
        /// FAU_CHECKIN 。
        /// </summary>
        [Column("FAU_CHECKIN", "FAU_CHECKIN"), DataSize(1)]
        [DisplayName("FAU_CHECKIN")]
        public string FAU_CHECKIN
        {
            get;
            set;
        }

        /// <summary>
        /// FAU_CHECKOUT 。
        /// </summary>
        [Column("FAU_CHECKOUT", "FAU_CHECKOUT"), DataSize(1)]
        [DisplayName("FAU_CHECKOUT")]
        public string FAU_CHECKOUT
        {
            get;
            set;
        }

        /// <summary>
        /// OPT1 。
        /// </summary>
        [Column("OPT1", "OPT1"), DataSize(10)]
        [DisplayName("OPT1")]
        public string OPT1
        {
            get;
            set;
        }

        /// <summary>
        /// OPT2 。
        /// </summary>
        [Column("OPT2", "OPT2"), DataSize(10)]
        [DisplayName("OPT2")]
        public string OPT2
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
        /// FOLDERCREATE 。
        /// </summary>
        [Column("FOLDERCREATE", "FOLDERCREATE"), DataSize(1)]
        [DisplayName("FOLDERCREATE")]
        public string FOLDERCREATE
        {
            get;
            set;
        }

        /// <summary>
        /// FOLDERDELETE 。
        /// </summary>
        [Column("FOLDERDELETE", "FOLDERDELETE"), DataSize(1)]
        [DisplayName("FOLDERDELETE")]
        public string FOLDERDELETE
        {
            get;
            set;
        }

        /// <summary>
        /// FOLDEREDIT 。
        /// </summary>
        [Column("FOLDEREDIT", "FOLDEREDIT"), DataSize(1)]
        [DisplayName("FOLDEREDIT")]
        public string FOLDEREDIT
        {
            get;
            set;
        }

        #endregion
    }
}
