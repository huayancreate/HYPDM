﻿#region AgileEAS.NET-generated
//------------------------------------------------------------------------------
//     AgileEAS.NET应用开发平台，是基于敏捷并行开发思想以及.NET构件技术而开发的一个应用系统快速开发平台，用于帮助中小软件企业
//建立一条适合快速变化的开发团队，以达到节省开发成本、缩短开发时间，快速适应市场变化的目的。
//     AgileEAS.NET应用开发平台包含基础类库、资源管理平台、运行容器、开发辅助工具等四大部分，资源管理平台为敏捷并行开发提供了
//设计、实现、测试等开发过程的并行，应用系统的各个业务功能子系统，在系统体系结构设计的过程中被设计成各个原子功能模块，各个子
//功能模块按照业务功能组织成单独的程序集文件，各子系统开发完成后，由AgileEAS.NET资源管理平台进行统一的集成部署。
//
//     AgileEAS.NET SOA 中间件平台是一套免费的快速开发工具，可以不受限制的用于各种非商业开发之中，商业应用请向作者获取商业授权，
//商业授权也是免费的，但是对于非授权的商业应用视为侵权，开发人员可以参考官方网站和博客园等专业网站获取公开的技术资料，也可以向
//AgileEAS.NET官方团队请求技术支持。
//
// 官方网站：http://www.smarteas.net
// 团队网站：http://www.agilelab.cn
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由AgileEAS.NET数据模型设计工具生成。
//     运行时版本:4.0.30319.1
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
#endregion

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
   /// 实体对象 PDM_ALL_PRODUCT(产品及半成品表)。
   /// </summary>
   [Serializable()]
   [Table("PDM_ALL_PRODUCT","产品及半成品表")]
    partial class PDM_ALL_PRODUCT : DataEntity<PDM_ALL_PRODUCT>, IDataEntity<PDM_ALL_PRODUCT>
   {
       public PDM_ALL_PRODUCT()
       {
       }
       
       protected PDM_ALL_PRODUCT(SerializationInfo info, StreamingContext context)
           : base(info, context)
       {
       }
       
       #region O/R映射成员

       /// <summary>
       /// 主键GUID生成 。
       /// </summary>
       [Column("PRODUCTID","主键GUID生成"),DataSize(128),PrimaryKey]
       [DisplayName("主键GUID生成")]
       public string PRODUCTID
       {
           get;
           set;
       }

       /// <summary>
       /// 编号 。
       /// </summary>
       [Column("PRODUCTNO","编号"),DataSize(128)]
       [DisplayName("编号")]
       public string PRODUCTNO
       {
           get;
           set;
       }

       /// <summary>
       /// 型号 。
       /// </summary>
       [Column("MODELTYPE","型号"),DataSize(128)]
       [DisplayName("型号")]
       public string MODELTYPE
       {
           get;
           set;
       }

       /// <summary>
       /// 类型 。
       /// </summary>
       [Column("PRODUCTTYPE","类型"),DataSize(128)]
       [DisplayName("类型")]
       public string PRODUCTTYPE
       {
           get;
           set;
       }

       /// <summary>
       /// 级别 。
       /// </summary>
       [Column("PRODUCTLEVEL","级别")]
       [DisplayName("级别")]
       public int PRODUCTLEVEL
       {
           get;
           set;
       }

       /// <summary>
       /// 版本 。
       /// </summary>
       [Column("VERSION","版本"),DataSize(128)]
       [DisplayName("版本")]
       public string VERSION
       {
           get;
           set;
       }

       /// <summary>
       /// 状态 。
       /// </summary>
       [Column("STATUS","状态"),DataSize(128)]
       [DisplayName("状态")]
       public string STATUS
       {
           get;
           set;
       }

       /// <summary>
       /// 创建者 。
       /// </summary>
       [Column("CREATER","创建者"),DataSize(128)]
       [DisplayName("创建者")]
       public string CREATER
       {
           get;
           set;
       }

       /// <summary>
       /// 修改者 。
       /// </summary>
       [Column("MODIFIER","修改者"),DataSize(128)]
       [DisplayName("修改者")]
       public string MODIFIER
       {
           get;
           set;
       }

       /// <summary>
       /// 创建时间 。
       /// </summary>
       [Column("CREATETIME","创建时间")]
       [DisplayName("创建时间")]
       public string CREATETIME
       {
           get;
           set;
       }

       /// <summary>
       /// 修改时间 。
       /// </summary>
       [Column("MODIFYTIME","修改时间")]
       [DisplayName("修改时间")]
       public string MODIFYTIME
       {
           get;
           set;
       }

       /// <summary>
       /// 中文描述 。
       /// </summary>
       [Column("MEMO_ZH","中文描述"),DataSize(128)]
       [DisplayName("中文描述")]
       public string MEMO_ZH
       {
           get;
           set;
       }

       /// <summary>
       /// 英文描述 。
       /// </summary>
       [Column("MEMO_EN","英文描述"),DataSize(128)]
       [DisplayName("英文描述")]
       public string MEMO_EN
       {
           get;
           set;
       }

       /// <summary>
       /// 备注 。
       /// </summary>
       [Column("MEMO","备注"),DataSize(524)]
       [DisplayName("备注")]
       public string MEMO
       {
           get;
           set;
       }
       /// <summary>
       /// 删除标识 。
       /// </summary>
       [Column("DEL_FLAG", "删除标识"), DataSize(4)]
       [DisplayName("删除标识")]
       public string DEL_FLAG
       {
           get;
           set;
       }  
       #endregion
   }
}
