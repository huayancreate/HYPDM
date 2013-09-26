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
using HYPDM.Entities;
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
            this.dGVCommonProperties.DataSource = sys.NewInstance.GetDataTableForParams(DataType.RelationObjectType.ALL);

            //  Object obj = new object();
            //EAS.Application.Instance.Session.Client as IAccount
            //EAS.Sessions.ISession session = EAS.Application.Instance.Session;
            //MessageBox.Show(session.Client.ID);
            //  obj.
            this.tSCombPObject.TextChanged -= tSCombPObject_TextChanged;
            this.tSCombPObject.Items.Clear();
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
                case "产品":
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

            FrmAddNewProperties addpro = new FrmAddNewProperties("ALL");

            if (addpro.ShowDialog() == DialogResult.OK)
            {
                this.dGVCommonProperties.DataSource = sys.NewInstance.GetDataTableForParams(DataType.RelationObjectType.ALL);
            }
        }

        private void BtnEditCommonPro_Click(object sender, EventArgs e)
        {
            bool isSelectRecord = true;
            if (this.dGVCommonProperties.RowCount <= 0) { isSelectRecord = false; }
            int rowIndex = this.dGVCommonProperties.CurrentRow.Index;
            if (rowIndex < 0) { isSelectRecord = false; }
            if (!isSelectRecord) { MessageBox.Show("请选择一条记录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            PDM_Params temp = new PDM_Params();
            temp.MASTER_TABLE_NAME = "ALL";
            temp.PARAMS_DATA_TYPE = this.dGVCommonProperties.CurrentRow.Cells["PARAMS_DATA_TYPE"].Value.ToString();
            temp.PARAMS_NAME = this.dGVCommonProperties.CurrentRow.Cells["PARAMS_NAME"].Value.ToString();
            
            
            FrmAddNewProperties addpro = new FrmAddNewProperties(temp);
            if (addpro.ShowDialog() == DialogResult.OK)
            {
                sys.NewInstance.UpdateExtPro(temp,addpro.M_PDM_Params);
                this.dGVCommonProperties.DataSource = sys.NewInstance.GetDataTableForParams(DataType.RelationObjectType.ALL);
            }
        }

        private void BtnAddObjectPro_Click(object sender, EventArgs e)
        {
            if (this.tSCombPObject.Text.Trim() != "")
            {

                try
                {
                    DataType.RelationObjectType obj = GetRelationType(this.tSCombPObject.Text.Trim());
                    FrmAddNewProperties addpro = new FrmAddNewProperties(sys.NewInstance.GetTableName(obj));


                    if (addpro.ShowDialog() == DialogResult.OK)
                    {
                        this.dGVObjectProperties.DataSource = sys.NewInstance.GetDataTableForParams(GetRelationType(this.tSCombPObject.Text.Trim()));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("请确认选择正确的对象:" + ex.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void tSCombPObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            tSCombPObject_TextChanged(sender, e);
        }

        private void BtnEditObjectPro_Click(object sender, EventArgs e)
        {
            if (this.tSCombPObject.Text.Trim() != "")
            {
                bool isSelectRecord = true;
                if (this.dGVObjectProperties.RowCount <= 0) { isSelectRecord = false; }
                int rowIndex = this.dGVObjectProperties.CurrentCell.RowIndex;
                if (rowIndex < 0) { isSelectRecord = false; }
                if (!isSelectRecord) { MessageBox.Show("请选择一条记录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                PDM_Params temp = new PDM_Params();

                DataType.RelationObjectType obj = GetRelationType(this.tSCombPObject.Text.Trim());              
                temp.MASTER_TABLE_NAME = sys.NewInstance.GetTableName(obj);
                temp.PARAMS_DATA_TYPE = this.dGVObjectProperties.CurrentRow.Cells["PARAMS_DATA_TYPE1"].Value.ToString();
                temp.PARAMS_NAME = this.dGVObjectProperties.CurrentRow.Cells["PARAMS_NAME1"].Value.ToString();


                FrmAddNewProperties addpro = new FrmAddNewProperties(temp);
                if (addpro.ShowDialog() == DialogResult.OK)
                {
                    sys.NewInstance.UpdateExtPro(temp, addpro.M_PDM_Params);
                    this.dGVObjectProperties.DataSource = sys.NewInstance.GetDataTableForParams(GetRelationType(this.tSCombPObject.Text.Trim()));
                }
            }
        }
    }
}
