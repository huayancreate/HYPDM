﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HYPDM.Entities;
using EAS.Data.ORM;

namespace HYPDM.BLL
{
    public interface IAllPartsService
    {

        //*****************************************************************//
        //*********************       半成品操作         ******************//
        //*****************************************************************//
        int GetMaxID();

        /// <summary>
        /// 获取所有半成品记录
        /// </summary>
        /// <returns></returns>
        DataTable  GetProductList();

        /// <summary>
        /// 更加对象查询半成品记录
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        DataTable GetProductList(PDM_ALL_PRODUCT c);

        /// <summary>
        /// 查询符合条件的半成品记录
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        IList<PDM_ALL_PRODUCT> GetProductList2(Condition c);

        /// <summary>
        /// 根据主键查询半成品记录
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        PDM_ALL_PRODUCT GetById(String p_id);

        /// <summary>
        /// 根据半成品编号获取所有该半成品的版本(模糊查询)
        /// </summary>
        /// <returns></returns>
        DataTable GetListByNo(string p_productNo);

        /// <summary>
        /// 根据半成品编号获取所有该半成品的版本（精确查询）
        /// </summary>
        /// <param name="p_productNo"></param>
        /// <returns></returns>
        DataTable GetListByNoDetail(string p_productNo);


        /// <summary>
        /// 根据主键删除半成品记录
        /// </summary>
        /// <param name="p_id"></param>
        void DelProductList(String p_id);

        /// <summary>
        /// 根据半成品对象更新记录
        /// </summary>
        /// <param name="c"></param>
        void UpdateByID(PDM_ALL_PRODUCT c);
    }
}