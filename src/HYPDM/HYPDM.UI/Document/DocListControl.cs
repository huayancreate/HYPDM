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
using HYPDM.BLL;
using EAS.Data.ORM;

namespace HYPDM.WinUI.Document
{
    [Module("CED0FF76-5C3B-4951-8285-A66AA8ADA3BE", "文档列表", "文档管理")]
    public partial class DocListControl : UserControl
    {
        public event EventHandler Close;

        public IList<PDM_DOCUMENT> _docList;

        public DocListControl()
        {
            InitializeComponent();
        }

        [ModuleStart]
        public void StartEx()
        {
            this.Initialize();
        }

        private void Initialize()
        {
            this.InitList();
        }

        private void EnabledDrugTypeMenu(bool p)
        {
            throw new NotImplementedException();
        }

        private IList<HYPDM.Entities.PDM_DOCUMENT> documentList;
        private void InitList()
        {
            DateTime d0 = DateTime.Now;
         //   this.documentList = EAS.Services.ServiceContainer.GetService<IDocumentService>().GetDocumentList();
            this.documentList = EAS.Services.ServiceContainer.GetService<IDocumentService>().GetDocumentListForList();
            this.InitList(documentList);

        }
        /// <summary>
        /// 将指定的数据源中的记录绑定到列表。
        /// </summary>
        internal void InitList(IList<HYPDM.Entities.PDM_DOCUMENT> list)
        {
            this.docBindingSource.DataSource = null;
            this.dgvDocList.DataSource = list;
            BindDataFile();
        }

        private void btnDocToAdd_Click(object sender, EventArgs e)
        {
            this.DocAdd();
        }

        private void cmDocAdd_Click(object sender, EventArgs e)
        {
            this.DocAdd();
        }

        /// 记录添加。
        /// </summary>
        protected void DocAdd()
        {
            DocRegForm o = new DocRegForm();

            if (o.ShowDialog() == DialogResult.OK)
            {
                //重新加载列表
                InitList();
            }
        }

        /// <summary>
        /// 触发 Exited 事件。
        /// </summary>
        /// <param name="e">事件参数。</param>
        protected void OnExited(EventArgs e)
        {
            if (this.Close != null)
            {
                this.Close(this, e);
            }
        }

        private void btnDocDelete_Click(object sender, EventArgs e)
        {
            this.DocDelete();
        }

        /// <summary>
        /// 记录删除
        /// </summary>
        protected void DocDelete()
        {
            int rowIndex = dgvDocList.CurrentCell.RowIndex;

            if (rowIndex < 0)
                return;

            DataGridViewRow row = dgvDocList.Rows[rowIndex];
            IDocumentService _docService = ServiceContainer.GetService<IDocumentService>();
            HYPDM.Entities.PDM_DOCUMENT doc = row.DataBoundItem as HYPDM.Entities.PDM_DOCUMENT;
            IList<PDM_DOCUMENT> docList = new List<PDM_DOCUMENT>();
            docList.Add(doc);
            IList<PDM_PHYSICAL_FILE> fileList = new List<PDM_PHYSICAL_FILE>();
            fileList = EAS.Services.ServiceContainer.GetService<IPhysicalFileService>().GetList(doc.DOCID);

            if (doc == null) return;

            if (MessageBox.Show("您确认要删除所选择的文档记录么？\n删除文档记录可能造成历史数据的查询错误。\n请确认您的操作。", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                _docService.DocDel(docList, fileList);

                this.dgvDocList.Rows.Remove(row);
            }
        }

        /// <summary>
        /// 行双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDocList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDocList.SelectedRows.Count != 0)
            {
                DocProperty();
            }
        }

        /// <summary>
        /// 记录属性。
        /// </summary>
        protected void DocProperty()
        {
            int rowIndex = dgvDocList.CurrentCell.RowIndex;

            if (rowIndex < 0)
                return;

            DataGridViewRow row = dgvDocList.Rows[rowIndex];

            HYPDM.Entities.PDM_DOCUMENT document = row.DataBoundItem as HYPDM.Entities.PDM_DOCUMENT;

            if (document == null) return;

            DocRegForm o = new DocRegForm();
            o.Document = document;

            if (o.ShowDialog() == DialogResult.OK)
            {
                HYPDM.Entities.PDM_DOCUMENT doc = o.Document;
                row.Cells["DocType"].Value = doc.DOCTYPE.ToString();
                row.Cells["Description"].Value = doc.DESCRIPTION.ToString();
            }
        }

        private void btnDocProperty_Click(object sender, EventArgs e)
        {
            this.DocProperty();
        }

        private void dgvDocList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    if (dgvDocList.Rows[e.RowIndex].Selected == false)
                    {
                        dgvDocList.ClearSelection();
                        dgvDocList.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (dgvDocList.SelectedRows.Count == 1)
                    {
                        dgvDocList.CurrentCell = dgvDocList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    cmDocument.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm form = new SearchForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _docList = form._docList;
                this.LoadDoc();
            }
        }

        private void LoadDoc()
        {
            this.dgvDocList.DataSource = _docList;
            BindDataFile();
        }

        private void BindDataFile()
        {
            for (int i = 0; i < dgvDocList.Rows.Count; i++)
            {
                var count = ServiceContainer.GetService<IPhysicalFileService>().GetList(dgvDocList.Rows[i].Cells["DocID"].Value.ToString()).Count;
                dgvDocList.Rows[i].Cells["File"].Value = count > 2 ? "有文件" : "无文件";
            }
        }
    }
}
