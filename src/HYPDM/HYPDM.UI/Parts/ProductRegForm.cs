using System;
using System.Windows.Forms;
using EAS.Data.ORM;
using EAS.Explorer;
using EAS.Modularization;
using EAS.Services;
using HYPDM.BLL;
using System.ComponentModel;
using System.Data;
using AdvancedDataGridView;
using System.Drawing;
using System.Collections.Generic;
using HYPDM.Entities;
using HYPDM.WinUI.Document;

namespace HYPDM.WinUI.Parts
{
    public partial class ProductRegForm : Form
    {
        public static string productID;
        IProductDocumentService _proDocService = ServiceContainer.GetService<IProductDocumentService>();
        IProductStructService _proStructService = ServiceContainer.GetService<IProductStructService>();
        protected int closed = 0;
        protected bool valueChanged = false;
        IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;
        IProductService _proService = ServiceContainer.GetService<IProductService>();
        private HYPDM.Entities.PDM_PRODUCT product;

        public ProductRegForm()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            e.Cancel = this.closed == -1;
            if (this.closed == -1)
            {
                this.closed = 0;
            }
        }

        private void btnRegPart_Click(object sender, EventArgs e)
        {
            SaveProduct();
        }

        public HYPDM.Entities.PDM_PRODUCT Product
        {
            get { return this.product; }
            set
            {
                this.product = value;
                if (value != null)
                    this.InitProductInfo();
            }
        }

        private IList<HYPDM.Entities.PDM_PRODUCT_DOCUMENT> proDocList;
        private List<HYPDM.Entities.PDM_DOCUMENT> documentList = new List<HYPDM.Entities.PDM_DOCUMENT>();
        private IList<HYPDM.Entities.PDM_PRODUCT_STRUCT> proStructList = new List<HYPDM.Entities.PDM_PRODUCT_STRUCT>();
        private IList<HYPDM.Entities.PDM_PARTS> partsList = new List<HYPDM.Entities.PDM_PARTS>();
        

        private void InitProductInfo()
        {
            // 产品已存在
            if (this.Product != null)
            {
                this.Text = "产品  " + this.Product.PRONO;
                // 清除按钮不可用
                this.btnClear.Enabled = false;
                this.txtProductNo.Text = this.Product.PRONO;
                this.txtDescription.Text = this.Product.DESCRIPTION;
                this.txtEngDescription.Text = this.Product.ENGDESCRIPTION;
                this.txtProType.Text = this.Product.PRODUCTTYPE;
                this.txtModelNo.Text = this.Product.MODELNO;
                this.txtStatus.Text = this.Product.PRODUCTSTATUS;
                this.txtLastUpdateUser.Text = this.Product.LASTUPDATEUSER;
                this.txtCreateDate.Text = this.Product.CREATEDATE;
                this.txtLastUpdateDate.Text = this.Product.LASTUPDATEDATE;
                this.txtRemark.Text = this.Product.REMARK;

                this.proDocList = _proDocService.GetProDocList(this.Product.PRODUCTID);
                foreach (PDM_PRODUCT_DOCUMENT proDoc in proDocList)
                {
                    String docID = proDoc.DOCUMENTID;
                    IList<HYPDM.Entities.PDM_DOCUMENT> docList =
                        ServiceContainer.GetService<IDocumentService>().GetDocListByID(docID);
                    if (docList.Count > 0)
                    {
                        documentList.Add(docList[0]);
                    }

                }
                this.docBindingSource.DataSource = null;
                this.docBindingSource.DataSource = documentList;

                this.proStructList = _proStructService.GetProStructList(this.Product.PRODUCTID);
                foreach (PDM_PRODUCT_STRUCT proStruct in proStructList)
                {
                    String partsID = proStruct.PARTSID;
                    IList<HYPDM.Entities.PDM_PARTS> parList =
                        ServiceContainer.GetService<IPartsService>().GetPartsListByID(partsID);
                    if (parList.Count > 0)
                    {
                        partsList.Add(parList[0]);
                    }
                }
                this.partsBindingSource.DataSource = null;
                this.partsBindingSource.DataSource = partsList;

            }
        }


        /// <summary>
        /// 保存产品基本属性
        /// </summary>
        public void SaveProduct()
        {
            #region 产品
            HYPDM.Entities.PDM_PRODUCT product;
            if (txtDescription.Text.ToString().Trim() == "")
            {
                MessageBox.Show("描述不能为空");
                return;
            }
            string msg = "";
            if (this.product == null)
            {
                product = new HYPDM.Entities.PDM_PRODUCT();
                product.PRODUCTID = _proService.GetMaxID().ToString();
                // 创建时间
                product.CREATEDATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                msg = "数据记录添加成功！";
            }
            else
            {
                product = this.Product;
                product.LASTUPDATEDATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                product.LASTUPDATEUSER = LoginInfo.LoginID;
                msg = "数据记录修改成功！";
            }

            product.PRONO = txtProductNo.Text;
            product.DESCRIPTION = txtDescription.Text;
            product.ENGDESCRIPTION = txtEngDescription.Text;
            product.PRODUCTTYPE = txtProType.Text;
            product.MODELNO = txtModelNo.Text;
            product.PRODUCTSTATUS = txtStatus.Text;
            product.REMARK = txtRemark.Text;
            product.VERSION = "";
            product.Save();
            #endregion
            this.closed = 1;
            MessageBox.Show(msg);
            this.Product = product;
            this.DialogResult = DialogResult.OK;
        }

        private void btnAddDoc_Click(object sender, EventArgs e)
        {
            // 将产品ID传给连接form
            productID = this.Product.PRODUCTID;
            ConnectForm connectForm = new ConnectForm();
            connectForm.StartPosition = FormStartPosition.CenterParent;
            if (connectForm.ShowDialog() == DialogResult.OK)
            {
                this.reloadProDocList();
            }
        }

        private void reloadProDocList()
        {
            documentList.Clear();
            this.proDocList = _proDocService.GetProDocList(this.Product.PRODUCTID);
            foreach (PDM_PRODUCT_DOCUMENT proDoc in proDocList)
            {
                String docID = proDoc.DOCUMENTID;
                IList<HYPDM.Entities.PDM_DOCUMENT> docList =
                    ServiceContainer.GetService<IDocumentService>().GetDocListByID(docID);
                if (docList.Count > 0)
                {
                    documentList.Add(docList[0]);
                }

            }
            this.docBindingSource.DataSource = null;
            this.docBindingSource.DataSource = documentList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.proDocDelete();
        }

        // 产品-文档关联关系删除
        private void proDocDelete()
        {
            IList<PDM_PRODUCT_DOCUMENT> proDocList;
            for (int i = 0; i < dgvDoc.RowCount; i++)
            {
                if ((bool)dgvDoc.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    String docID = dgvDoc.Rows[i].Cells["DocID"].Value.ToString();
                    proDocList = _proDocService.getProdocByDocID(this.Product.PRODUCTID, docID);
                    if (proDocList.Count > 0)
                    {
                        _proDocService.delProDoc(proDocList);
                        dgvDoc.Rows.RemoveAt(i);
                    }
                    break;
                }
            }
        }

        private void dgvDoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if ((bool)dgvDoc.Rows[e.RowIndex].Cells[0].EditedFormattedValue == false)
                {
                    for (int i = 0; i < this.dgvDoc.RowCount; i++)
                    {
                        dgvDoc.Rows[i].Cells[0].Value = false;
                    }
                    dgvDoc.Rows[e.RowIndex].Cells[0].Value = true;

                }
                else
                {
                    dgvDoc.Rows[e.RowIndex].Cells[0].Value = false;
                }
            }
        }

        // 产品-文档关联关系删除
        private void cmProDocDelete_Click(object sender, EventArgs e)
        {
            this.proDocDelete();
        }

        private void cmDocAdd_Click(object sender, EventArgs e)
        {
            productID = this.Product.PRODUCTID;
            DocRegForm docRegForm = new DocRegForm();
            docRegForm.StartPosition = FormStartPosition.CenterParent;
            if(docRegForm.ShowDialog() == DialogResult.OK)
            {
                HYPDM.Entities.PDM_DOCUMENT document = docRegForm.Document;
                HYPDM.Entities.PDM_PRODUCT_DOCUMENT proDoc = new PDM_PRODUCT_DOCUMENT();
                List<PDM_PRODUCT_DOCUMENT> proDocList = new List<PDM_PRODUCT_DOCUMENT>();
                proDoc.ID = _proDocService.GetMaxID().ToString();
                proDoc.PRODUCTID = productID;
                proDoc.DOCUMENTID = document.DOCID;
                // "1":产品;"0":零部件
                proDoc.ISPRODUCT = "1";
                proDocList.Add(proDoc);
                _proDocService.ProDocSave(proDocList);
                this.reloadProDocList();
            }
        }

        private void dgvDoc_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    for (int i = 0; i < this.dgvDoc.RowCount; i++)
                    {
                        dgvDoc.Rows[i].Cells[0].Value = false;
                    }
                    dgvDoc.Rows[e.RowIndex].Cells[0].Value = true;
                    //若行已是选中状态就不再进行设置
                    if (dgvDoc.Rows[e.RowIndex].Selected == false)
                    {
                        dgvDoc.ClearSelection();
                        dgvDoc.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (dgvDoc.SelectedRows.Count == 1)
                    {
                        dgvDoc.CurrentCell = dgvDoc.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    cmDocument.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtProductNo.Text = "";
            this.txtDescription.Text = "";
            this.txtEngDescription.Text = "";
            this.txtProType.Text = "";
            this.txtModelNo.Text = "";
            this.txtStatus.Text = "";
            this.txtRemark.Text = "";
        }

        /// <summary>
        /// 添加产品结构 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            // 将产品ID传给连接form
            productID = this.Product.PRODUCTID;
            ProductStructForm form = new ProductStructForm();
            form.StartPosition = FormStartPosition.CenterParent;
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.reloadPartsList();
            }
        }

        private void reloadPartsList()
        {
            partsList.Clear();
            this.proStructList = _proStructService.GetProStructList(this.Product.PRODUCTID);
            foreach (PDM_PRODUCT_STRUCT proStruct in proStructList)
            {
                String partsID = proStruct.PARTSID;
                IList<HYPDM.Entities.PDM_PARTS> parList =
                    ServiceContainer.GetService<IPartsService>().GetPartsListByID(partsID);
                if (parList.Count > 0)
                {
                    partsList.Add(parList[0]);
                }

            }
            this.partsBindingSource.DataSource = null;
            this.partsBindingSource.DataSource = partsList;
        }

        private void dgvPartsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if ((bool)dgvPartsList.Rows[e.RowIndex].Cells[0].EditedFormattedValue == false)
                {
                    for (int i = 0; i < this.dgvPartsList.RowCount; i++)
                    {
                        dgvPartsList.Rows[i].Cells[0].Value = false;
                    }
                    dgvPartsList.Rows[e.RowIndex].Cells[0].Value = true;

                }
                else
                {
                    dgvPartsList.Rows[e.RowIndex].Cells[0].Value = false;
                }
            }
        }

        private void dgvPartsList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    for (int i = 0; i < this.dgvDoc.RowCount; i++)
                    {
                        dgvPartsList.Rows[i].Cells[0].Value = false;
                    }
                    dgvPartsList.Rows[e.RowIndex].Cells[0].Value = true;
                    //若行已是选中状态就不再进行设置
                    if (dgvPartsList.Rows[e.RowIndex].Selected == false)
                    {
                        dgvPartsList.ClearSelection();
                        dgvPartsList.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (dgvPartsList.SelectedRows.Count == 1)
                    {
                        dgvPartsList.CurrentCell = dgvPartsList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    cmParts.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void cmPartsAdd_Click(object sender, EventArgs e)
        {

        }

        private void cmPartDelete_Click(object sender, EventArgs e)
        {

        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvPartsList.RowCount; i++)
            {
                if ((bool)dgvPartsList.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    String partsID = dgvPartsList.Rows[i].Cells["PartsID"].Value.ToString();
                    IList<PDM_PRODUCT_STRUCT> proStructList = 
                        _proStructService.getProStructListByPartsID(this.Product.PRODUCTID, partsID);
                    if (proDocList.Count > 0)
                    {
                        _proDocService.delProDoc(proDocList);
                        dgvPartsList.Rows.RemoveAt(i);
                    }
                    break;
                }
            }
        }

    }
}
