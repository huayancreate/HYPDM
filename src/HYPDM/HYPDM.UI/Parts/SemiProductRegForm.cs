using EAS.Modularization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HYPDM.WinUI.BaseUI;
using HYPDM.Entities;
using HYPDM.BLL;
using EAS.Services;
using EAS.Explorer;

namespace HYPDM.WinUI.Parts
{
    public partial class SemiProductRegForm : BaseForm
    {
        private HYPDM.Entities.PDM_PARTS parts;
        IPartsService _partsService = ServiceContainer.GetService<IPartsService>();
        IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;

        public SemiProductRegForm()
        {
            InitializeComponent();
        }

        public HYPDM.Entities.PDM_PARTS Parts
        {
            get { return this.parts; }
            set
            {
                this.parts = value;
                if (value != null)
                    this.InitPartsInfo();
            }
        }

        public void InitPartsInfo()
        {
            if (this.parts != null)
            {
                this.txtPartsNo.Text = parts.PARTSNO;
                this.txtSpecificationCode.Text = parts.SPECIFICATIONCODE;
                this.txtDescription.Text = parts.DESCRIPTION;
                this.txtEngDescription.Text = parts.ENGDESCRIPTION;
                this.cobPartsType.Text = parts.PARTSTYPE;
                this.cobPartsClassfication.Text = parts.PARTSCLASSFICATION;
                this.cobMaterial.Text = parts.MATERIAL;
                this.cobTexture.Text = parts.TEXTURE;
                this.cobUnit.Text = parts.UNIT;
                this.txtSingleNetWeight.Text = parts.SINGLENETWEIGHT.ToString();
                this.txtStatus.Text = parts.STATUS;
                this.txtLastUpdateUser.Text = parts.LASTUPDATEUSER;
                this.txtCreateDate.Text = parts.CREATEDATE;
                this.txtLastUpdateDate.Text = parts.LASTUPDATEDATE;
                this.txtRemark.Text = parts.REMARK;
            }
        }

        // 清空所填信息
        private void tsBtnClear_Click(object sender, EventArgs e)
        {
            this.txtPartsNo.Text = "";
            this.txtSpecificationCode.Text = "";
            this.txtDescription.Text = "";
            this.txtEngDescription.Text = "";
            this.cobPartsType.Text = "";
            this.cobPartsClassfication.Text = "";
            this.cobMaterial.Text = "";
            this.cobTexture.Text = "";
            this.cobUnit.Text = "";
            this.txtSingleNetWeight.Text = "";
            this.txtStatus.Text = "";
            this.txtRemark.Text = "";
        }

        private void tsBtnSave_Click(object sender, EventArgs e)
        {
            HYPDM.Entities.PDM_PARTS tempParts = new PDM_PARTS();
            if(txtDescription.Text.ToString().Trim() == "")
            {
                MessageBox.Show("描述不能为空");
                return;
            }
            string msg = "";
            if (this.parts == null)
            {
                tempParts = new HYPDM.Entities.PDM_PARTS();
                tempParts.PARTSID = _partsService.GetMaxID().ToString();
                // 状态
                tempParts.STATUS = "新建";
                // 创建时间
                tempParts.CREATEDATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                msg = "数据记录添加成功！";
            }
            else
            {
                tempParts = this.Parts;
                tempParts.STATUS = "已创建";
                tempParts.LASTUPDATEDATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                tempParts.LASTUPDATEUSER = LoginInfo.LoginID;
                msg = "数据记录修改成功！";
            }

            tempParts.PARTSNO = txtPartsNo.Text;
            tempParts.SPECIFICATIONCODE = txtSpecificationCode.Text;
            tempParts.DESCRIPTION = txtDescription.Text;
            tempParts.ENGDESCRIPTION = txtEngDescription.Text;
            tempParts.PARTSTYPE = cobPartsType.Text;
            tempParts.PARTSCLASSFICATION = cobPartsClassfication.Text;
            tempParts.MATERIAL = cobMaterial.Text;
            tempParts.TEXTURE = cobTexture.Text;
            tempParts.UNIT = cobUnit.Text;
            tempParts.SINGLENETWEIGHT = txtSingleNetWeight.Text;
            IList<PDM_PARTS> list = new List<PDM_PARTS>();
            list.Add(tempParts);
            MessageBox.Show(msg);
            this.Parts = tempParts;
            this.DialogResult = DialogResult.OK;
        }
    }
}
