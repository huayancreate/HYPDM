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
        private string productID;
        private int rowIndex;
        private bool addFlg;
        private string proStructID;
        IProductStructService _proStructService = ServiceContainer.GetService<IProductStructService>();
        private IList<HYPDM.Entities.PDM_PARTS> partsList;
        public ProductStructForm()
        {
            InitializeComponent();
            this.Initialize();
        }

        private void Initialize()
        {
            productID = ProductRegForm.productID;
            rowIndex = ProductRegForm.rowIndex;
            proStructID = ProductRegForm.proStructID;
            this.partsList = EAS.Services.ServiceContainer.GetService<IPartsService>().GetPartsList();
            this.partsBindingSource.DataSource = null;
            this.partsBindingSource.DataSource = partsList;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            IList<PDM_PRODUCT_STRUCT> proStructList = _proStructService.GetProStructList(this.productID);
            for (int i = 0; i < this.dgvSearchResult.RowCount; i++)
            {
                PDM_PRODUCT_STRUCT proStruct = new PDM_PRODUCT_STRUCT();
                if ((bool)dgvSearchResult.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    if (ProductRegForm.addFlg)
                    {
                        UseMsgForm useMsgForm = new UseMsgForm();
                        useMsgForm.StartPosition = FormStartPosition.CenterParent;
                        if (useMsgForm.ShowDialog() == DialogResult.OK)
                        {
                            //proStruct.SORTCODE = rowIndex.ToString();
                            proStruct.QUANTITY = useMsgForm.Quantity;
                            proStruct.REMARK = useMsgForm.Remark;
                            proStruct.ID = _proStructService.GetMaxID().ToString();
                            proStruct.PRODUCTID = productID;
                            proStruct.PARTSID = dgvSearchResult.Rows[i].Cells["PartsID"].Value.ToString();
                            // "1":产品;"0":零部件
                            proStruct.ISPRODUCT = "1";
                            proStruct.PARTSCLASSFICATION = dgvSearchResult.Rows[i].Cells["PartsClassfication"].Value.ToString();
                            proStructList.Insert(rowIndex, proStruct);
                            for (int j = 0; j < proStructList.Count; j++)
                            {
                                PDM_PRODUCT_STRUCT proStr = proStructList[j];
                                proStr.SORTCODE = j.ToString();
                            }
                            _proStructService.ProStructSave(proStructList);
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        proStructList = _proStructService.getProStructListByID(proStructID);
                        if (proStructList.Count > 0)
                        {
                            proStructList[0].PARTSID = dgvSearchResult.Rows[i].Cells["PartsID"].Value.ToString();
                            proStructList[0].PARTSCLASSFICATION = dgvSearchResult.Rows[i].Cells["PartsClassfication"].Value.ToString();
                            _proStructService.ProStructSave(proStructList);
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    break;
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSearchResult.RowCount; i++)
            {
                if ((bool)dgvSearchResult.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    String partsID = dgvSearchResult.Rows[i].Cells["PartsID"].Value.ToString();
                    DataGridViewRow row = dgvSearchResult.Rows[i];

                    HYPDM.Entities.PDM_PARTS parts = row.DataBoundItem as HYPDM.Entities.PDM_PARTS;

                    if (parts == null)
                    {
                        return;
                    }
                    // 半成品
                    if(parts.PARTSCLASSFICATION == "半成品")
                    {
                        SemiProductRegForm o = new SemiProductRegForm();
                        o.StartPosition = FormStartPosition.CenterParent;
                        o.Parts = parts;

                        if (o.ShowDialog() == DialogResult.OK)
                        {
                            HYPDM.Entities.PDM_PARTS par = o.Parts;
                            row.Cells["PartsNo"].Value = par.PARTSNO;
                            row.Cells["Version"].Value = par.VERSION;
                            row.Cells["SpecificationCode"].Value = par.SPECIFICATIONCODE;
                            row.Cells["Description"].Value = par.DESCRIPTION;
                            row.Cells["PartsType"].Value = par.PARTSTYPE;
                            row.Cells["PartsClassfication"].Value = par.PARTSCLASSFICATION;
                            row.Cells["Status"].Value = par.STATUS;
                            row.Cells["LastUpdateUser"].Value = par.LASTUPDATEUSER;
                            row.Cells["LastUpdateDate"].Value = par.LASTUPDATEDATE;
                        }
                    }

                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dgvSearchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
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
                }
            }
        }
    }
}
