using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Services;
using EAS.Explorer;
using EAS.Data.ORM;
namespace HYPDM.WinUI.ProductsAndParts.Material
{
    public partial class MaterailAddForm : Form
    {
        public MaterailAddForm()
        {
            InitializeComponent();
        }
        //定义一个原材料类

        HYPDM.Entities.PDM_MATERAIL m_materail;
        public HYPDM.Entities.PDM_MATERAIL Materail
        {
            get { return this.m_materail; }
            set
            {
                this.m_materail = value;
            }
        }

        //保存按钮操作
        private void bt_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb_materailNo.Text)) {
                MessageBox.Show("请填写编号"); return;
            }
            HYPDM.Entities.PDM_MATERAIL temp_materail = new Entities.PDM_MATERAIL();

            temp_materail.MATERIALID = Guid.NewGuid().ToString();
            temp_materail.MATERIALNO = this.tb_materailNo.Text;
            temp_materail.MODELTYPE = this.tb_modelType.Text;
            temp_materail.MATERIALTYPE = this.tb_materailType.Text;
            temp_materail.RAWMATERIAL = this.tb_rawMaterail.Text;
            temp_materail.MATERIALSRC = this.tb_materailSrc.Text;
            temp_materail.VERSION="V"+DateTime.Now.ToString("yyyyMMddHHmm");
            temp_materail.CREATER= CommonVar.userName;
           // temp_materail.MODIFIER=
            temp_materail.CTREATETIME=DateTime.Now.ToString();
            //temp_materail.MODIFYTIME;
            temp_materail.MEMO_ZH=this.tb_memoZh.Text;
            temp_materail.MEMO_EN = this.tb_memoEn.Text;
            temp_materail.MEMO = this.rtb_Memo.Text;
            temp_materail.Save();
            this.m_materail = temp_materail;
            this.DialogResult = DialogResult.OK;
        }
    }
}
