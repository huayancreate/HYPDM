using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EAS.Modularization;
using HYPDM.Entities;
using EAS.Services;
using EAS.Data.ORM;
using HYPDM.BLL;
using EAS.Data;
using EAS.Explorer;
using HYPDM.BaseControl;

namespace HYPDM.WinUI.SysConfig
{
     [Module("48543BE9-3365-48F6-8425-8DE3432CF939", "系统配置", "系统配置")]
    public partial class UcSysConfig : UserControl
    {
        public UcSysConfig()
        {
            InitializeComponent();
        }
        [ModuleStart]
        public void StartEx()
        {
            this.Initialize();
          //  gpCommonProperties.Show();
        }

        protected void Initialize()
        {
            this.dGVCommonProperties.DataSource=sys.NewInstance.GetDataTableForParams(DataType.RelationObjectType.ALL);

            Object obj = new object();
            //EAS.Application.Instance.Session.Client as IAccount
            //EAS.Sessions.ISession session = EAS.Application.Instance.Session;
            //MessageBox.Show(session.Client.ID);
          //  obj.
            this.tSCombPObject.TextChanged -= tSCombPObject_TextChanged;
            this.tSCombPObject.Items.Add("产品");
            this.tSCombPObject.Items.Add("物料");
            this.tSCombPObject.Items.Add("文档");
            this.tSCombPObject.TextChanged += tSCombPObject_TextChanged;
            //this.tSCombPObject.Items.Add("产品");
            //this.tSCombPObject.Items.Add("产品");
        }

        private void tSCombPObject_TextChanged(object sender, EventArgs e)
        {
            if (this.tSCombPObject.Text.Trim() != "")
            {
                this.dGVObjectProperties.DataSource = sys.NewInstance.GetDataTableForParams(GetRelationType(this.tSCombPObject.Text.Trim()));
            }
        }

        protected DataType.RelationObjectType GetRelationType(string name)
        {
            DataType.RelationObjectType obj;
            switch (name)
            {
                case  "产品":
                    obj = DataType.RelationObjectType.Product;
                    break;
                case "物料":
                    obj = DataType.RelationObjectType.Material;
                    break;
                case "文档":
                    obj = DataType.RelationObjectType.Document;
                    break;
                default:
                    obj = DataType.RelationObjectType.ALL;
                    break;
            }
            return obj;
        }

        private void BtnAddCommonPro_Click(object sender, EventArgs e)
        {
            PDM_Params properties;
            FrmAddNewProperties addpro = new FrmAddNewProperties("ALL");
            if(addpro.ShowDialog()==DialogResult.OK)
            {
                properties = addpro.M_PDM_Params;
            }
        }

    }
}
