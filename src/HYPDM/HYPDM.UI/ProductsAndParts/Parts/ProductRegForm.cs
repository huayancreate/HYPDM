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
        public static int rowIndex;
        // 打开连接零部件画面，是为了新增还是替换产品关系。true：新增；false：替换
        public static bool addFlg;
        public static string proStructID;
        IProductDocumentService _proDocService = ServiceContainer.GetService<IProductDocumentService>();
        IProductStructService _proStructService = ServiceContainer.GetService<IProductStructService>();
        IPartsService _partsService = ServiceContainer.GetService<IPartsService>();
        IFilterService _filterService = ServiceContainer.GetService<IFilterService>();
        protected int closed = 0;
        protected bool valueChanged = false;
        IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;
        IProductService _proService = ServiceContainer.GetService<IProductService>();
        private HYPDM.Entities.PDM_PRODUCT product;
        private Dictionary<int, PDM_FILTER> dic = new Dictionary<int, PDM_FILTER>();

        public ProductRegForm()
        {
            InitializeComponent();
            tbcContent.TabPages.Remove(tpDoc);
            tbcContent.TabPages.Remove(tpDrawing);
            tbcContent.TabPages.Remove(tpProStruct);
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
        private IList<HYPDM.Entities.PartsDetail> partsDetailList = new List<HYPDM.Entities.PartsDetail>();
        

        private void InitProductInfo()
        {
            // 产品已存在
            if (this.Product != null)
            {
                tbcContent.TabPages.Add(tpDoc);
                tbcContent.TabPages.Add(tpDrawing);
                tbcContent.TabPages.Add(tpProStruct);
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

                // 初始化产品结构列表
                InitProStructList();
                
                // 初始化过滤器列表
                InitFilterList();
            }
        }

        private void InitFilterList()
        {
            IList<PDM_FILTER> filterList;
            int index = 1;
            if (this.product != null)
            {
                tsCobFilter.Items.Add("");
                filterList = _filterService.getFilterList(this.Product.PRODUCTID ,"1");
                foreach (PDM_FILTER filter in filterList)
                {
                    tsCobFilter.Items.Add("["+filter.FILTERNAME + "," + filter.OWNERSHIP + "]");
                    dic.Add(index, filter);
                    index++;
                }
                tsCobFilter.SelectedIndex = 0;
            }
        }

        private void InitProStructList()
        {
            this.partsDetailList.Clear();
            this.proStructList = _proStructService.GetProStructList(this.Product.PRODUCTID , "1");
            foreach (PDM_PRODUCT_STRUCT proStruct in proStructList)
            {
                String partsID = proStruct.PARTSID;
                IList<HYPDM.Entities.PDM_PARTS> parList =
                    ServiceContainer.GetService<IPartsService>().GetPartsListByID(partsID);
                PartsDetail partsDetail = new PartsDetail();

                if (parList.Count > 0)
                {
                    partsDetail.ProStructID = proStruct.ID;
                    partsDetail.PartsID = partsID;
                    partsDetail.PartsNo = parList[0].PARTSNO;
                    partsDetail.PartsType = parList[0].PARTSTYPE;
                    partsDetail.Version = parList[0].VERSION;
                    partsDetail.SpecificationCode = parList[0].SPECIFICATIONCODE;
                    partsDetail.SingleNetweight = parList[0].SINGLENETWEIGHT;
                    partsDetail.Description = parList[0].DESCRIPTION;
                    partsDetail.CreateDate = parList[0].CREATEDATE;
                    partsDetail.LastUpdateDate = parList[0].LASTUPDATEDATE;
                    partsDetail.LastUpdateUser = parList[0].LASTUPDATEUSER;
                    partsDetail.SortCode = proStruct.SORTCODE;
                    partsDetail.Quantity = proStruct.QUANTITY;
                    partsDetail.Remark = proStruct.REMARK;
                    partsDetailList.Add(partsDetail);
                }
            }
            this.partsBindingSource.DataSource = null;
            this.partsBindingSource.DataSource = partsDetailList;
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
            bool hasSelectedFlg = false;
            IList<PDM_PRODUCT_DOCUMENT> proDocList;
            for (int i = 0; i < dgvDoc.RowCount; i++)
            {
                if ((bool)dgvDoc.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    hasSelectedFlg = true;
                    String ProDocID = dgvDoc.Rows[i].Cells["ProDocID"].Value.ToString();
                    proDocList = _proDocService.getProDocByID(ProDocID);
                    if (proDocList.Count > 0)
                    {
                        _proDocService.delProDoc(proDocList);
                        dgvDoc.Rows.RemoveAt(i);
                    }
                    break;
                }
            }
            if(!hasSelectedFlg)
            {
                MessageBox.Show("请选择一条数据");
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
        /// 添加下层产品结构 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            // 没有产品结构时,新增一条数据
            if (this.dgvPartsList.RowCount == 0)
            {
                rowIndex = 0;
                this.proStructAdd();
                return;
            }
            bool hasSelectedFlg = false;
            for (int i = 0; i < this.dgvPartsList.RowCount; i++)
            {
                if ((bool)dgvPartsList.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    rowIndex = i + 1;
                    hasSelectedFlg = true;
                    break;
                }
            }
            if (!hasSelectedFlg)
            {
                MessageBox.Show("请选择一条数据");
                return;
            }
            this.proStructAdd();
        }

        private void proStructAdd()
        {
            // 将产品ID传给连接form
            productID = this.Product.PRODUCTID;
            addFlg = true; ;
            ProductStructForm form = new ProductStructForm();
            form.StartPosition = FormStartPosition.CenterParent;
            // 产品-零部件结构
            form.IsProduct = "1";
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.reloadPartsList();
            }
        }

        private void reloadPartsList()
        {
            partsDetailList.Clear();
            this.proStructList = _proStructService.GetProStructList(this.Product.PRODUCTID , "1");
            foreach (PDM_PRODUCT_STRUCT proStruct in proStructList)
            {
                String partsID = proStruct.PARTSID;
                IList<HYPDM.Entities.PDM_PARTS> parList =
                    ServiceContainer.GetService<IPartsService>().GetPartsListByID(partsID);
                PartsDetail partsDetail = new PartsDetail();
                if (parList.Count > 0)
                {
                    partsDetail.ProStructID = proStruct.ID;
                    partsDetail.PartsID = partsID;
                    partsDetail.PartsNo = parList[0].PARTSNO;
                    partsDetail.PartsType = parList[0].PARTSTYPE;
                    partsDetail.Version = parList[0].VERSION;
                    partsDetail.SpecificationCode = parList[0].SPECIFICATIONCODE;
                    partsDetail.SingleNetweight = parList[0].SINGLENETWEIGHT;
                    partsDetail.Description = parList[0].DESCRIPTION;
                    partsDetail.CreateDate = parList[0].CREATEDATE;
                    partsDetail.LastUpdateDate = parList[0].LASTUPDATEDATE;
                    partsDetail.LastUpdateUser = parList[0].LASTUPDATEUSER;
                    partsDetail.SortCode = proStruct.SORTCODE;
                    partsDetail.Quantity = proStruct.QUANTITY;
                    partsDetail.Remark = proStruct.REMARK;
                    partsDetailList.Add(partsDetail);
                }

            }
            this.partsBindingSource.DataSource = null;
            this.partsBindingSource.DataSource = partsDetailList;
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
                    for (int i = 0; i < this.dgvPartsList.RowCount; i++)
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

        /// <summary>
        /// 删除产品结构
        /// </summary>
        private void delProStructList(String proStructID)
        {
            IList<PDM_PRODUCT_STRUCT> proStrList =
                _proStructService.getProStructListByID(proStructID);
            if (proStrList.Count > 0)
            {
                _proStructService.delProStruct(proStrList);
                this.proStructList = _proStructService.GetProStructList(this.Product.PRODUCTID, "1");
                for (int j = 0; j < this.proStructList.Count; j++)
                {
                    proStructList[j].SORTCODE = j.ToString();
                }
                _proStructService.ProStructSave(this.proStructList);
                InitProStructList();
            }
            
        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            bool hasSelectedFlg = false;
            String proStructID = "";
            for (int i = 0; i < dgvPartsList.RowCount;i++ )
            {
                if ((bool)dgvPartsList.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    proStructID = dgvPartsList.Rows[i].Cells["ProStructID"].Value.ToString();
                    hasSelectedFlg = true;
                    break;
                }
            }
            if (!hasSelectedFlg)
            {
                MessageBox.Show("请选择一条数据");
                return;
            }
            if (MessageBox.Show("所选对象的关联信息将被删除，确定吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.delProStructList(proStructID);
            }
        }

        private void cmStructDelete_Click(object sender, EventArgs e)
        {
            bool hasSelectedFlg = false;
            String proStructID = "";
            for (int i = 0; i < dgvPartsList.RowCount; i++)
            {
                if ((bool)dgvPartsList.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    proStructID = dgvPartsList.Rows[i].Cells["ProStructID"].Value.ToString();
                    hasSelectedFlg = true;
                    break;
                }
            }
            if (!hasSelectedFlg)
            {
                MessageBox.Show("请选择一条数据");
                return;
            }
            if (MessageBox.Show("所选对象的关联信息将被删除，确定吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.delProStructList(proStructID);
            }
        }

        private void tsProStruct_Click(object sender, EventArgs e)
        {
            this.ProStruct();
        }

        private void ProStruct()
        {
            IList<PDM_PRODUCT_STRUCT> proStructList = new List<PDM_PRODUCT_STRUCT>();
            PDM_PRODUCT_STRUCT proStruct = new PDM_PRODUCT_STRUCT();
            bool hasSelectedFlg = false;
            for (int i = 0; i < dgvPartsList.RowCount; i++)
            {
                if ((bool)dgvPartsList.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    hasSelectedFlg = true;
                    DataGridViewRow row = dgvPartsList.Rows[i];
                    // 获取产品结构ID
                    String ID = row.Cells["ProStructID"].Value.ToString();
                    proStructList = _proStructService.getProStructListByID(ID);
                    if (proStructList.Count > 0)
                    {
                        proStruct = proStructList[0];
                        UseMsgForm useMsgForm = new UseMsgForm();
                        useMsgForm.StartPosition = FormStartPosition.CenterParent;
                        useMsgForm.Order = row.Cells["SortCode"].Value.ToString();
                        useMsgForm.Quantity = row.Cells["Quantity"].Value.ToString();
                        useMsgForm.Remark = row.Cells["Remark"].Value.ToString();
                        if (useMsgForm.ShowDialog() == DialogResult.OK)
                        {
                            proStruct.QUANTITY = useMsgForm.Quantity;
                            proStruct.REMARK = useMsgForm.Remark;
                            proStruct.Save();
                            row.Cells["Quantity"].Value = proStruct.QUANTITY;
                            row.Cells["Remark"].Value = proStruct.REMARK;
                        }
                        break;
                    }
                }
            }
            if(!hasSelectedFlg)
            {
                MessageBox.Show("请选择一条数据");
            }
        }

        private void cmProStruct_Click(object sender, EventArgs e)
        {
            this.ProStruct();
        }

        private void btnProStructSearch_Click(object sender, EventArgs e)
        {
            partsDetailList.Clear();
            String queryCondition = this.txtQuery.Text;
            IList<PDM_PARTS> partsList = new List<PDM_PARTS>();
            // 按编号条件查找
            if (this.cobQuery.SelectedIndex == 0)
            {
                partsList = _partsService.GetPartsByPartsNo(queryCondition);
                GetQueryResult(partsList);
            }
            else if(this.cobQuery.SelectedIndex == 1)
            {
                partsList = _partsService.GetPartsByDescription(queryCondition);
                GetQueryResult(partsList);
            }
            
            this.partsBindingSource.DataSource = null;
            this.partsBindingSource.DataSource = partsDetailList;
        }

        private void GetQueryResult(IList<PDM_PARTS> partsList)
        {
            if (partsList.Count > 0)
            {
                foreach (PDM_PARTS parts in partsList)
                {
                    String partsID = parts.PARTSID;
                    IList<PDM_PRODUCT_STRUCT> proStructList =
                        _proStructService.getListByPartsID(this.Product.PRODUCTID, partsID);
                    foreach (PDM_PRODUCT_STRUCT proStruct in proStructList)
                    {
                        PartsDetail partsDetail = new PartsDetail();

                        partsDetail.ProStructID = proStruct.ID;
                        partsDetail.PartsID = partsID;
                        partsDetail.PartsNo = parts.PARTSNO;
                        partsDetail.PartsType = parts.PARTSTYPE;
                        partsDetail.Version = parts.VERSION;
                        partsDetail.SpecificationCode = parts.SPECIFICATIONCODE;
                        partsDetail.SingleNetweight = parts.SINGLENETWEIGHT;
                        partsDetail.Description = parts.DESCRIPTION;
                        partsDetail.SortCode = proStruct.SORTCODE;
                        partsDetail.Quantity = proStruct.QUANTITY;
                        partsDetail.Remark = proStruct.REMARK;
                        partsDetailList.Add(partsDetail);
                    }
                }
            }
        }

        private void cmOpen_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvPartsList.CurrentCell.RowIndex;

            if (rowIndex < 0)
                return;

            DataGridViewRow row = dgvPartsList.Rows[rowIndex];

            HYPDM.Entities.PartsDetail partsDetail = row.DataBoundItem as HYPDM.Entities.PartsDetail;

            if (partsDetail == null)
            {
                return;
            }
            String partsID = partsDetail.PartsID;
            IList<PDM_PARTS> list= _partsService.GetPartsListByID(partsID);
            if(list.Count > 0)
            {
                PDM_PARTS parts = list[0];
                SemiProductRegForm o = new SemiProductRegForm();
                o.StartPosition = FormStartPosition.CenterParent;
                o.Parts = parts;
                if (o.ShowDialog() == DialogResult.OK)
                {
                    parts = o.Parts;
                    row.Cells["PartsNo"].Value = parts.PARTSNO;
                    row.Cells["Version"].Value = parts.VERSION;
                    row.Cells["PartsDescription"].Value = parts.DESCRIPTION;
                    row.Cells["SpecificationCode"].Value = parts.SPECIFICATIONCODE;
                    row.Cells["SingleNetweight"].Value = parts.SINGLENETWEIGHT;
                    row.Cells["PartsStatus"].Value = parts.STATUS;
                }
            }
        }

        private void cmAddNext_Click(object sender, EventArgs e)
        {
            bool hasSelectedFlg = false;
            for (int i = 0; i < this.dgvPartsList.RowCount; i++)
            {
                if ((bool)dgvPartsList.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    rowIndex = i + 1;
                    hasSelectedFlg = true;
                    break;
                }
            }
            if (!hasSelectedFlg)
            {
                MessageBox.Show("请选择一条数据");
                return;
            }
            this.proStructAdd();
        }

        private void tsBtnInsert_Click(object sender, EventArgs e)
        {
            bool hasSelectedFlg = false;
            for (int i = 0; i < this.dgvPartsList.RowCount; i++)
            {
                if ((bool)dgvPartsList.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    rowIndex = i;
                    hasSelectedFlg = true;
                    break;
                }
            }
            if (!hasSelectedFlg)
            {
                MessageBox.Show("请选择一条数据");
                return;
            }
            this.proStructAdd();
        }

        private void cmInsert_Click(object sender, EventArgs e)
        {
            bool hasSelectedFlg = false;
            for (int i = 0; i < this.dgvPartsList.RowCount; i++)
            {
                if ((bool)dgvPartsList.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    rowIndex = i;
                    hasSelectedFlg = true;
                    break;
                }
            }
            if (!hasSelectedFlg)
            {
                MessageBox.Show("请选择一条数据");
                return;
            }
            this.proStructAdd();
        }

        /// <summary>
        /// 替换为
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmReplaceWith_Click(object sender, EventArgs e)
        {
            addFlg = false;
            bool hasSelectedFlg = false;
            for (int i = 0; i < this.dgvPartsList.RowCount; i++)
            {
                if ((bool)dgvPartsList.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    proStructID = dgvPartsList.Rows[i].Cells["ProStructID"].Value.ToString();
                    hasSelectedFlg = true;
                    break;
                }
            }
            if (!hasSelectedFlg)
            {
                MessageBox.Show("请选择一条数据");
                return;
            }
            ProductStructForm o = new ProductStructForm();
            o.StartPosition = FormStartPosition.CenterParent;
            o.IsProduct = "1";
            if(o.ShowDialog() == DialogResult.OK)
            {
                this.reloadPartsList();
            }
        }

        private void tsBtnFilter_Click(object sender, EventArgs e)
        {
            ConnectionFilterForm o = new ConnectionFilterForm(this.Product.PRODUCTID, "1");
            o.StartPosition = FormStartPosition.CenterParent;
            if(o.ShowDialog() == DialogResult.OK)
            {
                PDM_FILTER filter = o.Filter;
                String filterID = filter.ID;
                this.RelodFilterList(filterID);
            }
        }

        private void RelodFilterList(String filterID)
        {
            tsCobFilter.Items.Clear();
            IList<PDM_FILTER> filterList;
            int index = 1;
            bool hasFoundFlg = false;
            if (this.product != null)
            {
                tsCobFilter.Items.Add("");
                dic.Clear();
                filterList = _filterService.getFilterList(this.Product.PRODUCTID , "1");
                foreach (PDM_FILTER filter in filterList)
                {
                    tsCobFilter.Items.Add("[" + filter.FILTERNAME + "," + filter.OWNERSHIP + "]");
                    dic.Add(index, filter);
                    if (!hasFoundFlg)
                    {
                        if (filter.ID == filterID)
                        {
                            hasFoundFlg = true;
                            tsCobFilter.SelectedIndex = index;
                        }
                    }
                    index++;
                }
                
            }
        }

        // 获取过滤器过滤后的查找结果
        private void getFilteredList(PDM_FILTER filter)
        {
            IList<PartsDetail> filteredList = new List<PartsDetail>();
            // 编号过滤
            if (partsDetailList.Count > 0)
            {
                foreach (PartsDetail partsDetail in partsDetailList)
                {
                    // 判定一条数据是否可以被过滤的标志位
                    bool canBeDeleted = false;
                    if (!canBeDeleted && filter.PARTSNO.Trim() != "")
                    {
                        canBeDeleted = canBeDeleted || !filter.PARTSNO.Equals(partsDetail.PartsNo);
                    }
                    if (!canBeDeleted && filter.VERSION.Trim() != "")
                    {
                        canBeDeleted = canBeDeleted || !filter.VERSION.Equals(partsDetail.Version);
                    }
                    if (!canBeDeleted && filter.FROMDATE.Trim() != "")
                    {
                        canBeDeleted = canBeDeleted || !(DateTime.Parse(partsDetail.CreateDate) >= DateTime.Parse(filter.FROMDATE));
                    }
                    if (!canBeDeleted && filter.TODATE.Trim() != "")
                    {
                        canBeDeleted = canBeDeleted || !(DateTime.Parse(partsDetail.CreateDate) <= DateTime.Parse(filter.TODATE));
                    }
                    if (!canBeDeleted && filter.SPECIFICATIONCODE.Trim() != "")
                    {
                        canBeDeleted = canBeDeleted || !filter.SPECIFICATIONCODE.Equals(partsDetail.SpecificationCode);
                    }
                    if (!canBeDeleted && filter.DESCRIPTION.Trim() != "")
                    {
                        canBeDeleted = canBeDeleted || !filter.DESCRIPTION.Equals(partsDetail.Description);
                    }
                    if (!canBeDeleted && filter.SINGLENETWEIGHT.Trim() != "")
                    {
                        canBeDeleted = canBeDeleted || !filter.SINGLENETWEIGHT.Equals(partsDetail.SingleNetweight);
                    }
                    if (!canBeDeleted && filter.SURFACESOLVE.Trim() != "")
                    {
                        canBeDeleted = canBeDeleted || !filter.SURFACESOLVE.Equals(partsDetail.SurfaceSolve);
                    }
                    if (!canBeDeleted && filter.SORTCODE.Trim() != "")
                    {
                        canBeDeleted = canBeDeleted || !filter.SORTCODE.Equals(partsDetail.SortCode);
                    }
                    if (!canBeDeleted && filter.QUANTITY.Trim() != "")
                    {
                        canBeDeleted = canBeDeleted || !filter.QUANTITY.Equals(partsDetail.Quantity);
                    }
                    if (!canBeDeleted)
                    {
                        filteredList.Add(partsDetail);
                    }
                }
            }

            this.partsBindingSource.DataSource = null;
            this.partsBindingSource.DataSource = filteredList;
        }

        private void tsCobFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.InitProStructList();
            int selectedIndex = tsCobFilter.SelectedIndex;
            if (selectedIndex > 0)
            {
                PDM_FILTER filter = dic[selectedIndex];
                getFilteredList(filter);
            }
        }
    }
}
