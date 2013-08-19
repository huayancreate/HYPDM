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

namespace HYPDM.WinUI.Parts
{
    public partial class ConnectForm : BaseForm
    {
        public static string productID;
        IProductDocumentService _proDocService = ServiceContainer.GetService<IProductDocumentService>();
        protected int closed = 0;

        public ConnectForm()
        {
            InitializeComponent();
            this.Initialize();
        }

        private void Initialize()
        {
            productID = ProductRegForm.productID;
            this.InitList();
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


        private IList<HYPDM.Entities.PDM_DOCUMENT> documentList;
        private void InitList()
        {
            DateTime d0 = DateTime.Now;
            this.documentList = EAS.Services.ServiceContainer.GetService<IDocumentService>().GetDocumentListForList();
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            List<PDM_PRODUCT_DOCUMENT> proDocList = new List<PDM_PRODUCT_DOCUMENT>();
            for (int i = 0; i < this.dgvSearchResult.RowCount; i++)
            {
                PDM_PRODUCT_DOCUMENT proDoc = new PDM_PRODUCT_DOCUMENT();
                if ((bool)dgvSearchResult.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    proDoc.ID = _proDocService.GetMaxID().ToString();
                    proDoc.PRODUCTID = productID;
                    proDoc.DOCUMENTID = dgvSearchResult.Rows[i].Cells["DocID"].Value.ToString();
                    // "1":产品;"0":零部件
                    proDoc.ISPRODUCT = "1";
                    proDocList.Add(proDoc);
                }
            }
            _proDocService.ProDocSave(proDocList);
            this.closed = 1;
            this.DialogResult = DialogResult.OK;
        }

        private void dgvSearchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((bool)dgvSearchResult.Rows[e.RowIndex].Cells[0].EditedFormattedValue == false)
            {
                for (int i = 0; i < this.dgvSearchResult.RowCount; i++)
                {
                    dgvSearchResult.Rows[i].Cells[0].Value = false;
                }
                dgvSearchResult.Rows[e.RowIndex].Cells[0].Value = true;

            }
            else
            {
                dgvSearchResult.Rows[e.RowIndex].Cells[0].Value = false;
                // dgvSearchResult.Rows[e.RowIndex].Selected = false;
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }

    }
}
