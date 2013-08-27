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
    public partial class SearchForm : Form
    {
        IDocumentService _docService = EAS.Services.ServiceContainer.GetService<IDocumentService>();
        public IList<PDM_DOCUMENT> _docList;
        public SearchForm()
        {
            InitializeComponent();
            DateTimePickeEmpty();
            this.CenterToParent();
        }

        public Dictionary<string, string> di;
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Condition condition = PDM_DOCUMENT.Create().CreateCondition();
            if (!string.IsNullOrEmpty(txtDocNo.Text))
            {
                condition.AddElement("DOCNO", txtDocNo.Text, ElementType.Match);
            }
            if (!string.IsNullOrEmpty(txtVersion.Text))
            {
                condition.AddElement("VERSION", txtVersion.Text);
            }
            if (!string.IsNullOrEmpty(cobFileType.Text))
            {
                condition.AddElement("FILETYPE", cobFileType.Text);
            }
            if (!string.IsNullOrEmpty(txtDesc.Text))
            {
                condition.AddElement("DESCRIPTION", txtDesc.Text);
            }
            if (!string.IsNullOrEmpty(txtStatus.Text))
            {
                condition.AddElement("DOCSTATUS", txtStatus.Text, ElementType.Match);
            }
            if (!string.IsNullOrEmpty(txtUpdateUser.Text))
            {
                condition.AddElement("LASTUPDATEUSER", txtUpdateUser.Text);
            }
            if (!string.IsNullOrEmpty(dtpCreateDate.Text.Trim()))
            {
                condition.AddElement("CREATEDATE", dtpCreateDate.Text + " 00:00:00", ElementType.GreaterThanAndEqualTo);
                condition.AddElement("CREATEDATE", dtpCreateDate.Text + " 23:59:59", ElementType.LessThanAndEqualTo);
            }
            if (!string.IsNullOrEmpty(dtpUpdateDate.Text.Trim()))
            {
                condition.AddElement("LASTUPDATEDATE", dtpUpdateDate.Text + " 00:00:00", ElementType.GreaterThanAndEqualTo);
                condition.AddElement("LASTUPDATEDATE", dtpUpdateDate.Text + " 23:59:59", ElementType.LessThanAndEqualTo);
            }
            BindData(condition);
            this.DialogResult = DialogResult.OK;
        }

        public void BindData(Condition c)
        {
            var list = _docService.GetDocList(c);
            _docList = list;
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

        private void DateTimePickeEmpty()
        {
            this.dtpCreateDate.Format = DateTimePickerFormat.Custom;
            this.dtpCreateDate.CustomFormat = " ";
            this.dtpUpdateDate.Format = DateTimePickerFormat.Custom;
            this.dtpUpdateDate.CustomFormat = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
               // MessageBox.Show(ctl.GetType().Name);
                //if (ctl.GetType().Name == "TextBox")
                //{
                //    ((TextBox)ctl).Text = "";
                //}
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
    }
}
