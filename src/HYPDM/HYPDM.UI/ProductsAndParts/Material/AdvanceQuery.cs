using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HYPDM.Entities;
using HYPDM.BLL;
using HYPDM.WinUI.Util;
namespace HYPDM.WinUI.ProductsAndParts.Material
{
    public partial class AdvanceQuery : AddObjectParams.FrmAdvanceQuery
    {
        public AdvanceQuery()
          
        {
            InitializeComponent();
            this.MasterTableName = "PDM_MATERAIL";
        }
        IMaterailService m_materailService = EAS.Services.ServiceContainer.GetService<IMaterailService>();
        public DataTable m_dt;
        private void bt_query_Click(object sender, EventArgs e)
        {
            PDM_MATERAIL t_materail = new PDM_MATERAIL();
            t_materail.MATERIALNO = this.tb_materailNo.Text;
            t_materail.MODELTYPE = this.tb_modelType.Text;
            t_materail.MATERIALSRC = this.tb_materailSrc.Text;
            t_materail.MATERIALTYPE = this.tb_materailType.Text;
            t_materail.MEMO_ZH = this.tb_memoZh.Text;
            t_materail.MEMO_EN = this.tb_memoEn.Text;
            t_materail.CREATER = this.tb_creater.Text;
            t_materail.RAWMATERIAL = this.tb_rawMaterail.Text.Trim();
            m_dt = m_materailService.GetMaterailList(t_materail, this.AdvanceQueryString);
            this.DialogResult = DialogResult.OK;
        }
    }
}
