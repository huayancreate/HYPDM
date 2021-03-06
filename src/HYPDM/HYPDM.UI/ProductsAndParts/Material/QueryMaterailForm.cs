﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Data.ORM;
using HYPDM.Entities;
using HYPDM.BLL;
using HYPDM.WinUI.Util;
namespace HYPDM.WinUI.ProductsAndParts.Material
{
    public partial class QueryMaterailForm : Form
    {
        
        public QueryMaterailForm()
        {
            InitializeComponent();
        }

        IMaterailService m_materailService = EAS.Services.ServiceContainer.GetService<IMaterailService>();
        public DataTable m_dt;

        //查询按钮操作
        private void bt_query_Click(object sender, EventArgs e)
        {
            /*Condition condition = PDM_MATERAIL.Create().CreateCondition();
            
            if (!string.IsNullOrEmpty(this.tb_materailNo.Text))
            {
                condition.AddElement("MATERIALNO", this.tb_materailNo.Text, ElementType.Match);
            }
            if (!string.IsNullOrEmpty(this.tb_modelType.Text))
            {
                condition.AddElement("MODELTYPE", this.tb_modelType.Text);
            }
            if (!string.IsNullOrEmpty(this.tb_materailSrc.Text))
            {
                condition.AddElement("MATERIALSRC", tb_materailSrc.Text);
            }
            if (!string.IsNullOrEmpty(this.tb_materailType.Text))
            {
                condition.AddElement("MATERIALTYPE", tb_materailType.Text);
            }
            if (!string.IsNullOrEmpty(this.tb_memoEn.Text))
            {
                condition.AddElement("MEMO_ZH", this.tb_memoEn.Text, ElementType.Match);
            }
            if (!string.IsNullOrEmpty(this.tb_memoEn.Text))
            {
                condition.AddElement("MEMO_EN", this.tb_memoEn.Text);
            }
            if (!string.IsNullOrEmpty(this.tb_creater.Text))
            {
                condition.AddElement("CREATER", this.tb_creater.Text);
            }*/

            PDM_MATERAIL t_materail = new PDM_MATERAIL();
            t_materail.MATERIALNO = this.tb_materailNo.Text;
            t_materail.MODELTYPE = this.tb_modelType.Text;
            t_materail.MATERIALSRC = this.tb_materailSrc.Text;
            t_materail.MATERIALTYPE= this.tb_materailType.Text;
            t_materail.MEMO_ZH= this.tb_memoZh.Text;
            t_materail.MEMO_EN = this.tb_memoEn.Text;
            t_materail.CREATER = this.tb_creater.Text;
            t_materail.RAWMATERIAL = this.tb_rawMaterail.Text.Trim();
            m_dt = m_materailService.GetMaterailList(t_materail);
            this.DialogResult = DialogResult.OK;
        }
    }
}
