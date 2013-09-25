using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Data.ORM;
using HYPDM.Entities;
using HYPDM.BLL;
using HYPDM.WinUI.Util;

namespace HYPDM.WinUI.Document
{
    public partial class FrmDocumentQuery : AddObjectParams.FrmAdvanceQuery
    {
        IDocumentService _docService = EAS.Services.ServiceContainer.GetService<IDocumentService>();
       // public IList<PDM_DOCUMENT> _docList;
        public DataTable  _docList;
        public FrmDocumentQuery()
            : base("PDM_DOCUMENT")
        {
            InitializeComponent();
            //MessageBox.Show(this.MasterTableName.ToString());
        }

        private void FrmDocumentQuery_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            DateTimePickeEmpty();
            new HYDocumentMS.FileHelper().SetComboBoxValue(cobFileType, "DocType", -1);
        }

        private void DateTimePickeEmpty()
        {
            this.dtpCreateDate.Format = DateTimePickerFormat.Custom;
            this.dtpCreateDate.CustomFormat = " ";
            this.dtpUpdateDate.Format = DateTimePickerFormat.Custom;
            this.dtpUpdateDate.CustomFormat = " ";
        }

        private void dtpCreateDate_ValueChanged(object sender, EventArgs e)
        {
            this.dtpCreateDate.Format = DateTimePickerFormat.Custom;
            this.dtpCreateDate.CustomFormat = "yyyy-MM-dd";
        }

        private void dtpUpdateDate_ValueChanged(object sender, EventArgs e)
        {
            this.dtpUpdateDate.Format = DateTimePickerFormat.Custom;
            this.dtpUpdateDate.CustomFormat = "yyyy-MM-dd";
        }

        //public void BindData(Condition c)
        public void BindData(string  c)
        {
            //var list = _docService.GetDocList(c);
            if (this.AdvanceQueryString != "")
            {
                c += this.AdvanceQueryString;
            }
            DataTable  dt = DocQuery.NewInstance.GetQueryResultForDataTable(c);
            _docList = dt;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                switch (ctl.GetType().Name)
                {
                    case "TextBox":
                        ((TextBox)ctl).Text = "";
                        break;
                    case "ComboBox":
                        ((ComboBox)ctl).SelectedIndex = -1;
                        break;
                    case "DateTimePicker":
                        ((DateTimePicker)ctl).Value = System.DateTime.Now;
                        break;

                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StringBuilder stbQueryFields = new StringBuilder("1=1");
            Condition condition = PDM_DOCUMENT.Create().CreateCondition();
            if (!string.IsNullOrEmpty(txtDocNo.Text))
            {
               // condition.AddElement("DOCNO", txtDocNo.Text, ElementType.Match);
                stbQueryFields.AppendFormat("AND DOCNO='{0}'", txtDocNo.Text);
            }
            if (!string.IsNullOrEmpty(txtVersion.Text))
            {
                //condition.AddElement("VERSION", txtVersion.Text);
                stbQueryFields.AppendFormat("AND VERSION='{0}'", txtVersion.Text);
            }
            if (!string.IsNullOrEmpty(cobFileType.Text))
            {
                //condition.AddElement("FILETYPE", cobFileType.Text);
                stbQueryFields.AppendFormat("AND DOCTYPE='{0}'", cobFileType.SelectedValue.ToString());
            }
            if (!string.IsNullOrEmpty(txtDesc.Text))
            {
                //condition.AddElement("DESCRIPTION", txtDesc.Text);
                stbQueryFields.AppendFormat("AND DESCRIPTION='{0}'", txtDesc.Text);
            }
            if (!string.IsNullOrEmpty(txtStatus.Text))
            {
                //condition.AddElement("DOCSTATUS", txtStatus.Text, ElementType.Match);
                stbQueryFields.AppendFormat("AND DOCSTATUS='{0}'", txtStatus.Text);
            }
            if (!string.IsNullOrEmpty(txtUpdateUser.Text))
            {
                //condition.AddElement("LASTUPDATEUSER", txtUpdateUser.Text);
                stbQueryFields.AppendFormat("AND LASTUPDATEUSER='{0}'", txtUpdateUser.Text);
            }
            if (!string.IsNullOrEmpty(dtpCreateDate.Text.Trim()))
            {
                //condition.AddElement("CREATEDATE", dtpCreateDate.Text + " 00:00:00", ElementType.GreaterThanAndEqualTo);
                //condition.AddElement("CREATEDATE", dtpCreateDate.Text + " 23:59:59", ElementType.LessThanAndEqualTo);
                stbQueryFields.AppendFormat("AND CREATEDATE BETWEEN '{0}' AND '{1}'", dtpCreateDate.Text + " 00:00:00", dtpCreateDate.Text + " 23:59:59");
            }
            if (!string.IsNullOrEmpty(dtpUpdateDate.Text.Trim()))
            {
                //condition.AddElement("LASTUPDATEDATE", dtpUpdateDate.Text + " 00:00:00", ElementType.GreaterThanAndEqualTo);
                //condition.AddElement("LASTUPDATEDATE", dtpUpdateDate.Text + " 23:59:59", ElementType.LessThanAndEqualTo);

                stbQueryFields.AppendFormat("AND LASTUPDATEDATE BETWEEN '{0}' AND '{1}'", dtpUpdateDate.Text + " 00:00:00", dtpUpdateDate.Text + " 23:59:59");
            }
            //BindData(condition);
            BindData(stbQueryFields.ToString());
            this.DialogResult = DialogResult.OK;
        }
    }
}
