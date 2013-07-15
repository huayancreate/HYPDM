using System;
using System.Windows.Forms;
using EAS.Data.ORM;
using EAS.Explorer;
using EAS.Modularization;
using EAS.Services;
using HYPDM.BLL;
using System.ComponentModel;
using System.Data;
using AdvancedDataGridView;
using System.Drawing;

namespace HYPDM.WinUI.parts
{
    public partial class ProductRegForm : Form
    {
        public static string productID;

        protected int closed = 0;
        protected bool valueChanged = false;
        IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;
        IProductService _proService = ServiceContainer.GetService<IProductService>();
        private HYPDM.Entities.PDM_PRODUCT product;

        public ProductRegForm()
        {
            InitializeComponent();
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

        private void btnRegPart_Click(object sender, EventArgs e)
        {
            SaveProduct();
        }

        public HYPDM.Entities.PDM_PRODUCT Product
        {
            get { return this.product; }
            set
            {
                this.product = value;
                if (value != null)
                    this.InitProductInfo();
            }
        }

        private void InitProductInfo()
        {
            if (this.Product != null)
            {
                this.txtProductNo.Text = this.Product.PRONO;
                this.txtProductName.Text = this.Product.PRODUCTNAME;
                this.txtModelNo.Text = this.Product.MODELNO;
                this.txtSize.Text = this.Product.SIZE;
                this.cmbMatertial.Text = this.Product.MATERIAL;
                this.txtTechName.Text = this.Product.TECHNAME;
                this.txtTechInstruction.Text = this.Product.TECHINSTRUCTION;
                this.cmbProductNoAttr.Text = this.Product.PRODUCTNOATTR;
                this.cmbUnit.Text = this.Product.UNIT;
                this.txtProperty.Text = this.Product.PROPERTY;
                this.txtWorkCenter.Text = this.Product.WORKCENTER;
                this.txtStatus.Text = this.Product.PRODUCTSTATUS;
                this.txtLastUpdateUser.Text = this.Product.LASTUPDATEUSER;
                this.txtCreateDate.Text = this.Product.CREATEDATE;
                this.txtLastUpdateDate.Text = this.Product.LASTUPDATEDATE;
                this.txtRemark.Text = this.Product.REMARK;
            }
        }


        /// <summary>
        /// 保存产品基本属性
        /// </summary>
        public void SaveProduct()
        {
            #region 产品
            HYPDM.Entities.PDM_PRODUCT product;
            string msg = "";
            if (this.product == null)
            {
                product = new HYPDM.Entities.PDM_PRODUCT();
                product.PRODUCTID = _proService.GetMaxID().ToString();
                // 创建时间
                product.CREATEDATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                msg = "数据记录添加成功！";
            }
            else
            {
                product = this.Product;
                product.LASTUPDATEDATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                product.LASTUPDATEUSER = LoginInfo.LoginID;
                msg = "数据记录修改成功！";
            }

            product.PRONO = txtProductNo.Text;
            product.PRODUCTNAME = txtProductName.Text;
            product.MODELNO = txtModelNo.Text;
            product.SIZE = txtSize.Text;
            product.MATERIAL = cmbMatertial.Text;
            product.TECHNAME = txtTechName.Text;
            product.TECHINSTRUCTION = txtTechInstruction.Text;
            product.PRODUCTNOATTR = cmbProductNoAttr.Text;
            product.UNIT = cmbUnit.Text;
            product.PROPERTY = txtProperty.Text;
            product.WORKCENTER = txtWorkCenter.Text;
            product.PRODUCTSTATUS = txtStatus.Text;
            product.REMARK = txtRemark.Text;
            product.VERSION = "";
            product.Save();
            #endregion
            this.closed = 1;
            MessageBox.Show(msg);
            this.Product = product;
            this.DialogResult = DialogResult.OK;
        }

        private void btnAddDoc_Click(object sender, EventArgs e)
        {
            productID = this.Product.PRODUCTID;
            ConnectForm connectForm = new ConnectForm();
            connectForm.StartPosition = FormStartPosition.CenterParent;
            connectForm.ShowDialog();
        }

    }
}
