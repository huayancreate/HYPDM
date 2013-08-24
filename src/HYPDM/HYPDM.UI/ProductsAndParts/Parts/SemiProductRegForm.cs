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
using EAS.Data.ORM;

namespace HYPDM.WinUI.Parts
{
    public partial class SemiProductRegForm : BaseForm
    {
        private HYPDM.Entities.PDM_PARTS parts;
        public static string partsID;
        public static int rowIndex;
        // 打开连接零部件画面，是为了新增还是替换产品关系。true：新增；false：替换
        public static bool addFlg;
        public static string proStructID;
        IProductDocumentService _proDocService = ServiceContainer.GetService<IProductDocumentService>();
        IProductStructService _proStructService = ServiceContainer.GetService<IProductStructService>();
        IPartsService _partsService = ServiceContainer.GetService<IPartsService>();
        IPartsDocumentService _partsDocService = ServiceContainer.GetService<IPartsDocumentService>();
        IFilterService _filterService = ServiceContainer.GetService<IFilterService>();
        IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;
        private Dictionary<int, PDM_FILTER> dic = new Dictionary<int, PDM_FILTER>();
        private IList<HYPDM.Entities.PDM_PRODUCT_DOCUMENT> proDocList = new List<HYPDM.Entities.PDM_PRODUCT_DOCUMENT>();
        private List<HYPDM.Entities.PDM_DOCUMENT> documentList = new List<HYPDM.Entities.PDM_DOCUMENT>();
        private IList<HYPDM.Entities.PDM_PRODUCT_STRUCT> proStructList = new List<HYPDM.Entities.PDM_PRODUCT_STRUCT>();
        private IList<HYPDM.Entities.PartsDetail> partsDetailList = new List<HYPDM.Entities.PartsDetail>();
        private IList<HYPDM.Entities.PDM_PARTS_DOCUMENT> partsDocList = new List<HYPDM.Entities.PDM_PARTS_DOCUMENT>();

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
                // 清除按钮不可用
                this.tsBtnClear.Enabled = false;
                this.txtPartsNo.Text = parts.PARTSNO;
                this.txtSpecificationCode.Text = parts.SPECIFICATIONCODE;
                this.txtDescription.Text = parts.DESCRIPTION;
                this.txtEngDescription.Text = parts.ENGDESCRIPTION;
                this.cobPartsType.Text = parts.PARTSTYPE;
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

            // 初始化产品结构列表
            InitProStructList();

            reloadDocumentList();

            // 初始化过滤器列表
            InitFilterList();
        }

        // 初始化过滤器列表
        private void InitFilterList()
        {
            IList<PDM_FILTER> filterList;
            int index = 1;
            if (this.parts != null)
            {
                // 添加空白行
                tsCobFilter.Items.Add("");
                filterList = _filterService.getFilterList(this.Parts.PARTSID, "0");
                foreach (PDM_FILTER filter in filterList)
                {
                    tsCobFilter.Items.Add("[" + filter.FILTERNAME + "," + filter.OWNERSHIP + "]");
                    dic.Add(index, filter);
                    index++;
                }
                tsCobFilter.SelectedIndex = 0;
            }
        }

        // 初始化产品结构列表
        private void InitProStructList()
        {
            this.partsDetailList.Clear();
            this.proStructList = _proStructService.GetProStructList(this.Parts.PARTSID , "0");
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

        // 清空所填信息
        private void tsBtnClear_Click(object sender, EventArgs e)
        {
            this.txtPartsNo.Text = "";
            this.txtSpecificationCode.Text = "";
            this.txtDescription.Text = "";
            this.txtEngDescription.Text = "";
            this.cobPartsType.Text = "";
            this.cobMaterial.Text = "";
            this.cobTexture.Text = "";
            this.cobUnit.Text = "";
            this.txtSingleNetWeight.Text = "";
            this.txtStatus.Text = "";
            this.txtRemark.Text = "";
        }

        // 保存零部件信息
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
                // 分类为半成品
                tempParts.PARTSCLASSFICATION = "半成品";
                // 创建时间
                tempParts.CREATEDATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                msg = "数据记录添加成功！";
            }
            else
            {
                tempParts = this.Parts;
                tempParts.STATUS = "已修改";
                tempParts.LASTUPDATEDATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                tempParts.LASTUPDATEUSER = LoginInfo.LoginID;
                msg = "数据记录修改成功！";
            }

            tempParts.PARTSNO = txtPartsNo.Text;
            tempParts.SPECIFICATIONCODE = txtSpecificationCode.Text;
            tempParts.DESCRIPTION = txtDescription.Text;
            tempParts.ENGDESCRIPTION = txtEngDescription.Text;
            tempParts.PARTSTYPE = cobPartsType.Text;
            tempParts.MATERIAL = cobMaterial.Text;
            tempParts.TEXTURE = cobTexture.Text;
            tempParts.UNIT = cobUnit.Text;
            tempParts.SINGLENETWEIGHT = txtSingleNetWeight.Text;
            tempParts.REMARK = txtRemark.Text;
            tempParts.Save();
            IList<PDM_PARTS> list = new List<PDM_PARTS>();
            list.Add(tempParts);
            MessageBox.Show(msg);
            this.Parts = tempParts;
            this.DialogResult = DialogResult.OK;
        }



        /// <summary>
        /// 删除产品结构
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsBtnDelete_Click(object sender, EventArgs e)
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
                this.proStructList = _proStructService.GetProStructList(this.Parts.PARTSID, "0");
                for (int j = 0; j < this.proStructList.Count; j++)
                {
                    proStructList[j].SORTCODE = j.ToString();
                }
                _proStructService.ProStructSave(this.proStructList);
                InitProStructList();
            }

        }

        /// <summary>
        /// 插入产品结构
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void btnProStructSearch_Click(object sender, EventArgs e)
        {

        }

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
            partsID = this.Parts.PARTSID;
            addFlg = true;
            ProductStructForm form = new ProductStructForm();
            form.StartPosition = FormStartPosition.CenterParent;
            // 零部件-零部件结构
            form.IsProduct = "0";
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.reloadPartsList();
            }
        }

        private void reloadPartsList()
        {
            partsDetailList.Clear();
            this.proStructList = _proStructService.GetProStructList(this.Parts.PARTSID , "0");
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
        /// 查看/修改选中的产品结构
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsBtnProStruct_Click(object sender, EventArgs e)
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
            if (!hasSelectedFlg)
            {
                MessageBox.Show("请选择一条数据");
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

        private void cmProStruct_Click(object sender, EventArgs e)
        {
            this.ProStruct();
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
            IList<PDM_PARTS> list = _partsService.GetPartsListByID(partsID);
            if (list.Count > 0)
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

        /// <summary>
        /// 右键菜单“插入”押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            o.IsProduct = "0";
            if (o.ShowDialog() == DialogResult.OK)
            {
                this.reloadPartsList();
            }
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

        private void tsBtnFilter_Click(object sender, EventArgs e)
        {
            ConnectionFilterForm o = new ConnectionFilterForm(this.Parts.PARTSID, "0");
            o.StartPosition = FormStartPosition.CenterParent;
            if (o.ShowDialog() == DialogResult.OK)
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
            if (this.parts != null)
            {
                tsCobFilter.Items.Add("");
                dic.Clear();
                filterList = _filterService.getFilterList(this.Parts.PARTSID, "0");
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

        /// <summary>
        /// 加载与半成品相关联的文档列表数据
        /// </summary>
        private void reloadDocumentList()
        {
            this.documentList.Clear();
            this.partsDocList = _partsDocService.GetPartsDocList(this.Parts.PARTSID);
            foreach (PDM_PARTS_DOCUMENT partDoc in partsDocList)
            {
                string docID = partDoc.DOCID;
                IList<HYPDM.Entities.PDM_DOCUMENT> docList = ServiceContainer.GetService<IDocumentService>().GetDocListByID(docID);
                PDM_DOCUMENT doc = new PDM_DOCUMENT();

                if (docList.Count() > 0)
                {
                    doc.DOCID = docList[0].DOCID;
                    doc.DOCNAME = docList[0].DOCNAME;
                    doc.DOCTYPE = docList[0].DOCTYPE;
                    doc.DOCSTATUS = docList[0].DOCSTATUS;
                    doc.LASTUPDATEUSER = docList[0].LASTUPDATEUSER;
                    doc.CREATEDATE = docList[0].CREATEDATE;
                    doc.LASTUPDATEDATE = docList[0].LASTUPDATEDATE;
                    doc.REMARK = docList[0].REMARK;
                    doc.VERSION = docList[0].VERSION;
                    doc.DOCNO = docList[0].DOCNO;
                    doc.DESCRIPTION = docList[0].DESCRIPTION;
                    doc.CREATEUSER = docList[0].CREATEUSER;
                    documentList.Add(doc);
                }
            }
            this.docBindingSource.DataSource = null;
            this.docBindingSource.DataSource = documentList;
        }

        private void tsBtnPartsDocAdd_Click(object sender, EventArgs e)
        {
            //rowIndex = this.dgvDocumentList.RowCount;
            //this.partsDocAdd();
            if (this.dgvDocumentList.RowCount == 0)
            {
                rowIndex = 1;
            }
            else if (this.dgvDocumentList.RowCount > 0)
            {
                rowIndex = this.dgvDocumentList.RowCount + 1;
            }
            this.partsDocAdd();
        }

        private void partsDocAdd()
        {
            addFlg = true;
            ConnectForm connForm = new ConnectForm();
            connForm.PartsID = this.Parts.PARTSID;
            connForm.StartPosition = FormStartPosition.CenterParent;
            if (connForm.ShowDialog() == DialogResult.OK)
            {
                this.reloadDocumentList();
            }
        }

    }
}
