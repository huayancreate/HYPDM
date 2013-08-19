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
namespace HYPDM.WinUI.ProductsAndParts.Products
{
    public partial class ProductsProRecordAddForm : Form
    {
        public ProductsProRecordAddForm()
        {
            InitializeComponent();
        }
        //一条生产记录
        HYPDM.Entities.PDM_PRODUCT_PRORECORD record;
        public HYPDM.Entities.PDM_PRODUCT_PRORECORD Record
        {
            get { return this.record; }
            set
            {
                this.record = value;
                if (value != null)
                {
                    control_init();
                }
            }
        }
        //初始化控件
        private void control_init() {
            if (this.record!=null)
            {
                this.ProRecordId.Text = record.PRORECORDID.ToString();
                this.ProductID.Text = record.PRUDUCTID;
                this.startTime.Value = record.STARTTIME;
                this.endTime.Value = record.ENDTIME;
                this.ProductNum.Text = record.PRODUCTNUM.ToString();
                this.workShop.Text = record.WORKSHOP;
                this.wsDirector.Text = record.WORKSHOPDIRECTOR;
            } else{
                this.ProRecordId.Text="";
                this.ProductID.Text = _productId;
                this.startTime.Value = new DateTime();
                this.endTime.Value=new DateTime();
                this.ProductNum.Text="";
                this.workShop.Text="";
                this.wsDirector.Text="";
            }
        
        }

        //对应的产品ID
        string _productId;
        public String _ProductId
        {
            get { return this._productId; }
            set
            {
                this._productId = value;
                if (value != null)
                {
                    this.ProductID.Text = value;
                }
            }
        }
        //保存按钮操作
        private void saveButton_Click(object sender, EventArgs e)
        {
            HYPDM.Entities.PDM_PRODUCT_PRORECORD temp = new HYPDM.Entities.PDM_PRODUCT_PRORECORD();
            
            temp.PRORECORDID = Convert.ToInt64(this.ProRecordId.Text);
            temp.PRUDUCTID = this.ProductID.Text;
            temp.STARTTIME = this.startTime.Value;
            temp.ENDTIME = this.endTime.Value;
            temp.PRODUCTNUM = Convert.ToInt32(this.ProductNum.Text);
            temp.WORKSHOP = this.workShop.Text;
            temp.WORKSHOPDIRECTOR = this.wsDirector.Text;
            temp.Save();
            MessageBox.Show("保存成功");
            this.record = temp;
            this.DialogResult = DialogResult.OK;
        }
        //取消按钮操作
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
