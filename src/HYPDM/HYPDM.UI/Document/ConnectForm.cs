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
using HYPDM.BLL;
using EAS.Services;
using HYPDM.Entities;

namespace HYPDM.WinUI.Document
{
    public partial class ConnectForm : BaseForm
    {

        PDM_DOCUMENT document = new PDM_DOCUMENT();

        public PDM_DOCUMENT Document
        {
            get { return document; }
            set { document = value; }
        }
        public ConnectForm()
        {
            InitializeComponent();
            this.combQueryType.SelectedIndex = 0;
            this.CenterToParent();
        }

        private void Initialize()
        {
            this.InitList();
        }

        //产品
        private void InitList()
        {
            if (this.Document != null)
            {
                this.dGVProduct.DataSource = new  HYDocumentMS.FileHelper().getDataTableBySql("*,'false' as 'chk'", "  WHERE PRODUCTID NOT IN (SELECT   RELATIONOBJECTID  FROM ObjectRelation WHERE RELATIONOBJECTTYPE='Product' AND MASTEROBJECTTYPE='Document' AND  DEL_FALG='N' AND MASTEROBJECTID='" + this.Document.DOCID + "')", "PDM_ALL_PRODUCT");
                this.ucPaging1.SourceDataGridView = this.dGVProduct;
                this.dgvMaterial.Visible = false;
                this.dGVProduct.Visible = true;
            }
        }
        //物料
        private void InitList1()
        {
            if (this.Document != null)
            {
                this.dgvMaterial.DataSource = new  HYDocumentMS.FileHelper().getDataTableBySql("*,'false' as 'chk'", "WHERE MATERIALID NOT IN (SELECT   RELATIONOBJECTID  FROM ObjectRelation WHERE RELATIONOBJECTTYPE='Material' AND MASTEROBJECTTYPE='Document' AND  DEL_FALG='N' AND MASTEROBJECTID='" + this.Document.DOCID + "')", "PDM_MATERAIL");
                this.ucPaging1.SourceDataGridView = this.dgvMaterial;
                this.dGVProduct.Visible = false;
                this.dgvMaterial.Visible = true;
            }
        }
        //半成品
        private void InitList2()
        {
            //this.dgvMaterial.DataSource = new  FileHelper().getDataTableBySql("*,'false' as 'chk'", "", "PDM_MATERAIL");
            //this.ucPaging1.SourceDataGridView = this.dgvMaterial;
            //this.dGVProduct.Visible = false;
        }

        Boolean bl; //用来表示是否选中的标示
        /// <summary>
        /// 存放选中的信息
        /// </summary>
        private IList<ObjectRelation> listObjectRelation = new List<ObjectRelation>();

        public IList<ObjectRelation> ListObjectRelation
        {
            get { return listObjectRelation; }
            set { listObjectRelation = value; }
        }
        ObjectRelation or = null;
        private void btnSelect_Click(object sender, EventArgs e)
        {
            Boolean IsExist = false;
            switch (this.combQueryType.Text.Trim())
            {
                case "产品":
                    {
                        IsExist = false;
                        foreach (DataGridViewRow row in this.dGVProduct.Rows)
                        {
                            string temp = row.Cells["chk"].Value.ToString();
                            bl = Convert.ToBoolean(temp);
                            if (bl == true)
                            {
                                string productid = row.Cells["PRODUCTID"].Value.ToString();
                                for (int i = 0; i < listObjectRelation.Count; i++)
                                {
                                    if (listObjectRelation[i].RELATIONOBJECTID == productid && listObjectRelation[i].RELATIONOBJECTTYPE ==  DataType.RelationObjectType.Material.ToString())
                                    {
                                        IsExist = true;
                                        return;
                                    }
                                }
                                if (!IsExist)
                                {
                                    or = new ObjectRelation();
                                    or.ORID = Guid.NewGuid().ToString();
                                    or.RELATIONOBJECTID = productid;
                                    or.RELATIONOBJECTTYPE =  DataType.RelationObjectType.Product.ToString();
                                    or.RELATIONOBJECTVERSION = row.Cells["VERSION1"].Value.ToString();
                                    or.DEL_FALG = "N";
                                    ListObjectRelation.Add(or);
                                }
                            }
                        }

                        MessageBox.Show("选择成功!!", "讯息", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        break;
                    }
                case "物料":
                    {
                        IsExist = false;
                        foreach (DataGridViewRow row in this.dgvMaterial.Rows)
                        {
                            string temp = row.Cells["chk1"].Value.ToString();
                            bl = Convert.ToBoolean(temp);
                            // PDM_MATERAIL material = null;
                            if (bl == true)
                            {
                                string materid = row.Cells["MATERIALID"].Value.ToString();
                                for (int i = 0; i < listObjectRelation.Count; i++)
                                {
                                    if (listObjectRelation[i].RELATIONOBJECTID == materid && listObjectRelation[i].RELATIONOBJECTTYPE ==  DataType.RelationObjectType.Material.ToString())
                                    {
                                        IsExist = true;
                                        return;
                                    }
                                }
                                if (!IsExist)
                                {
                                    or = new ObjectRelation();
                                    or.ORID = Guid.NewGuid().ToString();
                                    or.RELATIONOBJECTID = materid;
                                    or.RELATIONOBJECTTYPE =  DataType.RelationObjectType.Material.ToString();
                                    or.RELATIONOBJECTVERSION = row.Cells["VERSION"].Value.ToString();
                                    or.DEL_FALG = "N";
                                    ListObjectRelation.Add(or);
                                }
                            }
                        }
                        MessageBox.Show("选择成功!!", "讯息", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void dgvSearchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string iDList = "";
            if (ListObjectRelation == null || ListObjectRelation.Count == 0)
            {
                MessageBox.Show("你目前没有选中任何需要关联的对象!!", "讯息", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                iDList = "";
                foreach (ObjectRelation oo in ListObjectRelation)
                {
                    iDList += "'" + oo.RELATIONOBJECTID + "',";
                }
                iDList = "(" + iDList.Substring(0, iDList.Length - 1) + ")";
            }
            DataTable dtTemp = new  HYDocumentMS.FileHelper().getDataTableBySql("*", "  WHERE A.ID IN" + iDList, "(SELECT  PRODUCTID as ID ,PRODUCTNO as NO ,[VERSION]  ,'产品' as Type FROM PDM_ALL_PRODUCT]UNION ALL SELECT MATERIALID as id  ,MATERIALNO as NO,[VERSION] ,'物料' type FROM PDM_MATERAIL) A");
            FrmShowSelectedObject FrmSelView = new FrmShowSelectedObject();
            FrmSelView.DtDataList = dtTemp;
            FrmSelView.ShowDialog();
        }

        private void ConnectForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void combQueryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.combQueryType.SelectedIndex > -1)
            {
                if (this.combQueryType.Text == "产品")
                {
                    this.InitList();
                }
                else if (this.combQueryType.Text == "物料")
                {
                    this.InitList1();
                }
                else if (this.combQueryType.Text == "半产品")
                {

                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (this.ListObjectRelation != null && this.ListObjectRelation.Count != 0)
            {
                if (DialogResult.OK == MessageBox.Show("关闭后刚才选中的信息将不被保存，请确认是否继续!", "讯息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2))
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (this.combQueryType.SelectedIndex > -1)
            {
                if (this.comboMaterialNo.SelectedIndex < 0)
                {
                    MessageBox.Show("请选择查询字段!!", "讯息", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    comboMaterialNo.Focus();
                    return;
                }
                if (this.txtValue.Text.ToString() == "")
                {
                    MessageBox.Show("请选择查询内容!!", "讯息", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtValue.Focus();
                    return;
                }

                //DataTable dt=null;
                if (this.combQueryType.Text == "产品")
                {
                    //dt = (DataTable)this.dGVProduct.DataSource;
                    //this.dGVProduct.DataSource = dt.Select("PRODUCTNO='{0}'",this.txtValue.Text.ToString());

                    this.dGVProduct.DataSource = new  HYDocumentMS.FileHelper().getDataTableBySql("*,'false' as 'chk'", "  WHERE PRODUCTID NOT IN (SELECT   RELATIONOBJECTID  FROM ObjectRelation WHERE RELATIONOBJECTTYPE='Product' AND MASTEROBJECTTYPE='Document' AND  DEL_FALG='N' AND MASTEROBJECTID='" + this.Document.DOCID + "') AND PRODUCTNO LIKE '%" + this.txtValue.Text.ToString() + "%'", "PDM_ALL_PRODUCT");
                }
                else if (this.combQueryType.Text == "物料")
                {
                    this.dgvMaterial.DataSource = new   HYDocumentMS.FileHelper().getDataTableBySql("*,'false' as 'chk'", "WHERE MATERIALID NOT IN (SELECT   RELATIONOBJECTID  FROM ObjectRelation WHERE RELATIONOBJECTTYPE='Material' AND MASTEROBJECTTYPE='Document' AND  DEL_FALG='N' AND MASTEROBJECTID='" + this.Document.DOCID + "') AND MATERIALNO LIKE '%" + this.txtValue.Text.ToString() + "%'", "PDM_MATERAIL");
                }
                else if (this.combQueryType.Text == "半产品")
                {

                }
            }
            else
            {
                MessageBox.Show("请选择分类!!", "讯息", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtValue_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnQuery_Click(sender, new EventArgs());
            }
        }



    }
}
