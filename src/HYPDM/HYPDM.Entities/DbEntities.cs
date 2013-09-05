using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EAS.Data;
using EAS.Data.Access;
using EAS.Data.ORM;
using EAS.Data.Linq;

namespace HYPDM.Entities
{
    /// <summary>
    /// 数据上下文。
    /// </summary>
    public class DbEntities : DataContext
    {
        #region 字段定义

        private DataEntityQuery<PDM_DOCUMENT> m_PDM_DOCUMENTs;
        private DataEntityQuery<PDM_DOCUMENT_TYPE> m_PDM_DOCUMENT_TYPEs;
        private DataEntityQuery<PDM_DRAWING> m_PDM_DRAWINGs;
        private DataEntityQuery<PDM_DRAWING_TYPE> m_PDM_DRAWING_TYPEs;
        private DataEntityQuery<PDM_PARTS_TYPE> m_PDM_PARTS_TYPEs;
        private DataEntityQuery<PDM_PRODUCT_STRUCT> m_PDM_PRODUCT_STRUCTs;
        private DataEntityQuery<PDM_VERSION_HISTORY> m_PDM_VERSION_HISTORYs;
        private DataEntityQuery<PDM_CHANGE_HISTORY> m_PDM_CHANGE_HISTORYs;
        private DataEntityQuery<ComboBoxValue> m_ComboBoxValues;
        private DataEntityQuery<ObjectRelation> m_ObjectRelations;
        private DataEntityQuery<WF_TEMPLATES_STEP> m_WF_TEMPLATES_STEPs;
        private DataEntityQuery<WF_TEMPLATES> m_WF_TEMPLATESs;

        public DataEntityQuery<WF_TEMPLATES> WF_TEMPLATESs
        {
            get { return m_WF_TEMPLATESs; }
            set { m_WF_TEMPLATESs = value; }
        }
        public DataEntityQuery<WF_TEMPLATES_STEP> WF_TEMPLATES_STEPs
        {
            get { return m_WF_TEMPLATES_STEPs; }
            set { m_WF_TEMPLATES_STEPs = value; }
        }
        public DataEntityQuery<ObjectRelation> ObjectRelations
        {
            get { return m_ObjectRelations; }
            set { m_ObjectRelations = value; }
        }

        public DataEntityQuery<ComboBoxValue> ComboBoxValues
        {
            get { return m_ComboBoxValues; }
            set { m_ComboBoxValues = value; }
        }
        #endregion

        #region 构造函数

        /// <summary>
        /// 初始化DbEntities对象实例。
        /// </summary>
        public DbEntities()
        {
        }

        /// <summary>
        /// 初始化DbEntities对象实例。
        /// </summary>
        /// <param name="dbProvider">数据库访问程序提供者。</param>
        public DbEntities(IDbProvider dbProvider)
            : base(dbProvider)
        {

        }

        /// <summary>
        /// 初始化DbEntities对象实例。
        /// </summary>
        /// <param name="dataAccessor">数据访问器。</param>
        public DbEntities(IDataAccessor dataAccessor)
            : base(dataAccessor)
        {

        }

        /// <summary>
        /// 初始化DbEntities对象实例。
        /// </summary>
        /// <param name="dataAccessor">数据访问器。</param>
        /// <param name="ormAccessor">Orm访问器。</param>
        public DbEntities(IDataAccessor dataAccessor, IOrmAccessor ormAccessor)
            : base(dataAccessor, ormAccessor)
        {

        }

        #endregion

        #region 查询定义

        /// <summary>
        /// 文档。
        /// </summary>
        public DataEntityQuery<PDM_DOCUMENT> PDM_DOCUMENTs
        {
            get
            {
                if (this.m_PDM_DOCUMENTs == null)
                {
                    this.m_PDM_DOCUMENTs = base.CreateQuery<PDM_DOCUMENT>();
                }
                return this.m_PDM_DOCUMENTs;
            }
        }

        /// <summary>
        /// 文档类型。
        /// </summary>
        public DataEntityQuery<PDM_DOCUMENT_TYPE> PDM_DOCUMENT_TYPEs
        {
            get
            {
                if (this.m_PDM_DOCUMENT_TYPEs == null)
                {
                    this.m_PDM_DOCUMENT_TYPEs = base.CreateQuery<PDM_DOCUMENT_TYPE>();
                }
                return this.m_PDM_DOCUMENT_TYPEs;
            }
        }

        /// <summary>
        /// 图纸。
        /// </summary>
        public DataEntityQuery<PDM_DRAWING> PDM_DRAWINGs
        {
            get
            {
                if (this.m_PDM_DRAWINGs == null)
                {
                    this.m_PDM_DRAWINGs = base.CreateQuery<PDM_DRAWING>();
                }
                return this.m_PDM_DRAWINGs;
            }
        }

        /// <summary>
        /// 图纸类型。
        /// </summary>
        public DataEntityQuery<PDM_DRAWING_TYPE> PDM_DRAWING_TYPEs
        {
            get
            {
                if (this.m_PDM_DRAWING_TYPEs == null)
                {
                    this.m_PDM_DRAWING_TYPEs = base.CreateQuery<PDM_DRAWING_TYPE>();
                }
                return this.m_PDM_DRAWING_TYPEs;
            }
        }


        /// <summary>
        /// 零件类型。
        /// </summary>
        public DataEntityQuery<PDM_PARTS_TYPE> PDM_PARTS_TYPEs
        {
            get
            {
                if (this.m_PDM_PARTS_TYPEs == null)
                {
                    this.m_PDM_PARTS_TYPEs = base.CreateQuery<PDM_PARTS_TYPE>();
                }
                return this.m_PDM_PARTS_TYPEs;
            }
        }


        /// <summary>
        /// 产品结构。
        /// </summary>
        public DataEntityQuery<PDM_PRODUCT_STRUCT> PDM_PRODUCT_STRUCTs
        {
            get
            {
                if (this.m_PDM_PRODUCT_STRUCTs == null)
                {
                    this.m_PDM_PRODUCT_STRUCTs = base.CreateQuery<PDM_PRODUCT_STRUCT>();
                }
                return this.m_PDM_PRODUCT_STRUCTs;
            }
        }


        /// <summary>
        /// 检入检出记录。
        /// </summary>
        public DataEntityQuery<PDM_VERSION_HISTORY> PDM_VERSION_HISTORYs
        {
            get
            {
                if (this.m_PDM_VERSION_HISTORYs == null)
                {
                    this.m_PDM_VERSION_HISTORYs = base.CreateQuery<PDM_VERSION_HISTORY>();
                }
                return this.m_PDM_VERSION_HISTORYs;
            }
        }

        /// <summary>
        /// 变更记录。
        /// </summary>
        public DataEntityQuery<PDM_CHANGE_HISTORY> PDM_CHANGE_HISTORYs
        {
            get
            {
                if (this.m_PDM_CHANGE_HISTORYs == null)
                {
                    this.m_PDM_CHANGE_HISTORYs = base.CreateQuery<PDM_CHANGE_HISTORY>();
                }
                return this.m_PDM_CHANGE_HISTORYs;
            }
        }


        #endregion

    }
}
