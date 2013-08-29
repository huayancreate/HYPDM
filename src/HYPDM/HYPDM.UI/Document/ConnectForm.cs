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
        IAllProductService _productPrdService = ServiceContainer.GetService<AllProductService>();
      

        public ConnectForm()
        {
            InitializeComponent();
            this.Initialize();
            this.combQueryType.SelectedIndex = 0;
        }

        private void Initialize()
        {
            this.InitList();
        }
       
        //产品
        private void InitList()
        {

            this.dGVProduct.DataSource = new HYDocumentMS.FileHelper().getDataTableBySql("*,'false' as 'chk'", "", "PDM_ALL_PRODUCT");
            this.ucPaging1.SourceDataGridView = this.dGVProduct;
            this.dgvMaterial.Visible = false;
            this.dGVProduct.Visible = true;
        }
        //物料
        private void InitList1()
        {
            this.dgvMaterial.DataSource = new HYDocumentMS.FileHelper().getDataTableBySql("*,'false' as 'chk'", "", "PDM_MATERAIL");
            this.ucPaging1.SourceDataGridView = this.dgvMaterial;
            this.dGVProduct.Visible = false;
            this.dgvMaterial.Visible = true;
        }
        //半成品
        private void InitList2()
        {
            //this.dgvMaterial.DataSource = new HYDocumentMS.FileHelper().getDataTableBySql("*,'false' as 'chk'", "", "PDM_MATERAIL");
            //this.ucPaging1.SourceDataGridView = this.dgvMaterial;
            //this.dGVProduct.Visible = false;
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            List<PDM_PARTS_DOCUMENT> partsDocList = new List<PDM_PARTS_DOCUMENT>();
            
            this.DialogResult = DialogResult.OK;
        }

        private void dgvSearchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if ((bool)dgvSearchResult.Rows[e.RowIndex].Cells[0].EditedFormattedValue == false)
            //{
            //    dgvSearchResult.Rows[e.RowIndex].Cells[0].Value = true;
            //}
            //else
            //{
            //    dgvSearchResult.Rows[e.RowIndex].Cells[0].Value = false;
            //    // dgvSearchResult.Rows[e.RowIndex].Selected = false;
            //}
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }

        private void ConnectForm_Load(object sender, EventArgs e)
        {

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

    }
}
