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
    public partial class ProductStructForm : BaseForm
    {
        public static string productID;
        IProductStructService _proStructService = ServiceContainer.GetService<IProductStructService>();
        public ProductStructForm()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            IList<PDM_PRODUCT_STRUCT> proStructList = new List<PDM_PRODUCT_STRUCT>();
            for (int i = 0; i < this.dgvSearchResult.RowCount; i++)
            {
                PDM_PRODUCT_STRUCT proStruct = new PDM_PRODUCT_STRUCT();
                if ((bool)dgvSearchResult.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    UseMsgForm useMsgForm = new UseMsgForm();
                    useMsgForm.StartPosition = FormStartPosition.CenterParent;
                    if (useMsgForm.DialogResult == DialogResult.OK)
                    {
                        proStruct.SORTCODE = useMsgForm.Order;
                        proStruct.QUANTITY = useMsgForm.Quantity;
                        proStruct.REMARK = useMsgForm.Remark;
                    }
                    proStruct.ID = _proStructService.GetMaxID().ToString();
                    proStruct.PRODUCTID = productID;
                    proStruct.PARTSID = dgvSearchResult.Rows[i].Cells["PartsID"].Value.ToString();
                    // "1":产品;"0":零部件
                    proStruct.ISPRODUCT = "1";
                    proStruct.PARTSCLASSFICATION = dgvSearchResult.Rows[i].Cells["PartsClassfication"].Value.ToString();
                    proStructList.Add(proStruct);
                }
            }
            _proStructService.ProStructSave(proStructList);
            this.DialogResult = DialogResult.OK;
        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
