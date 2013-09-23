using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HYPDM.BLL;
using HYPDM.Entities;
using EAS.Data.ORM;
namespace HYPDM.WinUI.ProductsAndParts.Products
{
    public partial class DocAddForm : Form
    {
        public DocAddForm(String p_ProductId)
        {
            InitializeComponent();
            m_AllProductService = EAS.Services.ServiceContainer.GetService<IAllProductService>();
            m_Product = m_AllProductService.GetById(p_ProductId);
            this.tsb_type.SelectedIndex = 0;
            DocList_Init();
        }

        private IAllProductService m_AllProductService;      //材料服务类
        private PDM_ALL_PRODUCT m_Product= new PDM_ALL_PRODUCT();
        private void DocList_Init() {
            this.dgv_DocList.DataSource = m_AllProductService.GetDocList(m_Product.PRODUCTID, m_Product.VERSION, 0, null);
            this.ucPaging1.SourceDataGridView = this.dgv_DocList;
        }

        private void tsb_select_Click(object sender, EventArgs e)
        {
            if(this.dgv_DocList.RowCount<=0)return;

            int rowIndex = this.dgv_DocList.CurrentCell.RowIndex;
            if (rowIndex < 0)return;

            if (MessageBox.Show("您确认要添加此关联文档？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                DataGridViewRow row = dgv_DocList.Rows[rowIndex];
                ObjectRelation objrl = new ObjectRelation();

                objrl.ORID=Guid.NewGuid().ToString();
                objrl.MASTEROBJECTID = row.Cells["DOCID"].Value.ToString();
                objrl.MASTEROBJECTTYPE="Document";
                objrl.MASTEROBJECTVERSION = row.Cells["DOCVERSION"].Value.ToString();
                objrl.RELATIONOBJECTID = this.m_Product.PRODUCTID;
                objrl.RELATIONOBJECTTYPE = "Product";
                objrl.RELATIONOBJECTVERSION = this.m_Product.VERSION;
                objrl.DEL_FALG = "N";
                try
                {
                    objrl.Save();
                    MessageBox.Show("添加成功");
                    DocList_Init();
                }catch(Exception e1){
                    MessageBox.Show("添加失败："+ e1.Message);
                }
            }
        }

        private void tsb_query_Click(object sender, EventArgs e)
        {
            if (this.tsb_type.Text.Equals("编号")) {
                this.dgv_DocList.DataSource = m_AllProductService.GetDocList(m_Product.PRODUCTID, m_Product.VERSION, 1, this.tsb_value.Text); 
            }
            if (this.tsb_type.Text.Equals("描述"))
            {
                this.dgv_DocList.DataSource = m_AllProductService.GetDocList(m_Product.PRODUCTID, m_Product.VERSION, 2, this.tsb_value.Text); 
            }
            //DocList_Init();
        }

    }
}
