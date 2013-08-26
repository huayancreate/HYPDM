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
        IPartsDocumentService _partsDocService = ServiceContainer.GetService<PartsDocumentService>();
        protected int closed = 0;
        private string partsID;

        public String PartsID
        {
            get { return partsID; }
            set { partsID = value; }
        }

        public ConnectForm()
        {
            InitializeComponent();
            this.Initialize();
        }

        public ConnectForm(string partsID)
        {
            this.PartsID = partsID;
            InitializeComponent();
            this.Initialize();
        }

        private void Initialize()
        {
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
            IList<HYPDM.Entities.PDM_DOCUMENT> tempList = null;
            tempList = EAS.Services.ServiceContainer.GetService<IDocumentService>().GetDocumentListForList();
            this.documentList = delExistsDoc(tempList); 
            this.InitList(documentList);
        }

        /// <summary>
        /// 移除 tempList 中已关联半成品的文档
        /// </summary>
        /// <param name="tempList"></param>
        /// <returns></returns>
        private IList<HYPDM.Entities.PDM_DOCUMENT> delExistsDoc(IList<HYPDM.Entities.PDM_DOCUMENT> tempList)
        {
            // 获取partsID
            string partsID = this.PartsID;
           // MessageBox.Show(partsID);
            // 根据partsID获取关联PDM_PARTS_DOCUMENT列表
            IPartsDocumentService _partsDocService = ServiceContainer.GetService<PartsDocumentService>();
            IList<HYPDM.Entities.PDM_PARTS_DOCUMENT> existsPartsDocList = _partsDocService.GetPartsDocList(partsID);

            // 移除已关联的PDM_DOCUMENT
            foreach (PDM_PARTS_DOCUMENT partsDoc in existsPartsDocList)
            {
                for (int i = 0; i < tempList.Count; i++)
                {
                    if (partsDoc.DOCID == tempList[i].DOCID)
                    {
                        tempList.Remove(tempList[i]);
                    }
                }
            }
            return tempList;
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
            List<PDM_PARTS_DOCUMENT> partsDocList = new List<PDM_PARTS_DOCUMENT>();
            
            for (int i = 0; i < this.dgvSearchResult.RowCount; i++)
            {
                PDM_PARTS_DOCUMENT partsDoc = new PDM_PARTS_DOCUMENT();
                if ((bool)dgvSearchResult.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    partsDoc.ID = Convert.ToString(_partsDocService.GetMaxID());
                    partsDoc.PARTSID = this.PartsID;
                    partsDoc.DOCID = dgvSearchResult.Rows[i].Cells["DocID"].Value.ToString();
                    partsDocList.Add(partsDoc);
                }
            }
            _partsDocService.PartsDocSave(partsDocList);
            this.closed = 1;
            this.DialogResult = DialogResult.OK;
        }

        private void dgvSearchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((bool)dgvSearchResult.Rows[e.RowIndex].Cells[0].EditedFormattedValue == false)
            {
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
