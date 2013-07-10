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

namespace HYPDM.WinUI.parts
{
    public partial class ConnectForm : BaseForm
    {
        public ConnectForm()
        {
            InitializeComponent();
            this.Initialize();
        }

        private void Initialize()
        {
            this.InitTreeView();
            this.InitDataGridView();
            this.InitList();
        }

        private void InitTreeView()
        {
            TreeNode node= new TreeNode("文档管理");
            //node.Text = "test";
            this.tvContent.Nodes.Add(node);
            TreeNode node1 = new TreeNode("文档");
            node.Nodes.Add(node1);
        }

        private void InitDataGridView()
        {
            DataTable dt = new DataTable();
            DataColumn dc = new DataColumn("编号");

            dt.Columns.Add(new DataColumn("id"));
            dt.Columns.Add();
            this.dgvSearchResult.DataSource = dt;
        }

        private IList<HYPDM.Entities.PDM_DOCUMENT> documentList;
        private void InitList()
        {
            DateTime d0 = DateTime.Now;
            this.documentList = EAS.Services.ServiceContainer.GetService<IDocumentService>().GetDocumentList();
            this.InitList(documentList);
        }

        /// <summary>
        /// 将指定的数据源中的记录绑定到列表。
        /// </summary>
        internal void InitList(IList<HYPDM.Entities.PDM_DOCUMENT> list)
        {
            this.docBindingSource.DataSource = null;
            this.docBindingSource.DataSource = list;
        }

    }
}
