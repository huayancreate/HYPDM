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
using HYPDM.BLL;
namespace HYPDM.WinUI.ProductsAndParts.Material
{
    public partial class MaterailAddForm : Form
    {
        IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;
        private IMaterailService m_MaterailService;      //材料服务类
        public MaterailAddForm()
        {
            InitializeComponent();
            m_MaterailService = EAS.Services.ServiceContainer.GetService<IMaterailService>();
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

            DataTable dt = m_MaterailService.GetListByNoDetail(this.tb_materailNo.Text.Trim());

            //1.判断产品是否存在，如果存在是否生产新版本
            if (dt.Rows.Count > 0)
            {
                if (MessageBox.Show("该编号材料已存在，是否生成新版本?\n如果不是请更改产品编号!", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
            }

            HYPDM.Entities.PDM_MATERAIL temp_materail = new Entities.PDM_MATERAIL();

            temp_materail.MATERIALID = Guid.NewGuid().ToString();
            temp_materail.MATERIALNO = this.tb_materailNo.Text;
            temp_materail.MODELTYPE = this.tb_modelType.Text;
            temp_materail.MATERIALTYPE = this.tb_materailType.Text;
            temp_materail.RAWMATERIAL = this.tb_rawMaterail.Text;
            temp_materail.MATERIALSRC = this.tb_materailSrc.Text;
            temp_materail.VERSION="V"+DateTime.Now.ToString("yyyyMMddHHmmss");
            temp_materail.CREATER = LoginInfo.LoginID;// CommonVar.userName;
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

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
