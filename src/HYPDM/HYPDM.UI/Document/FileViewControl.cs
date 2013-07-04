using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Modularization;
using HYPDM.BLL;
using EAS.Services;
using HYPDM.Entities;
using EAS.Data.ORM;

namespace HYPDM.WinUI.document
{
    [Module("A95AFCDB-3799-490F-A758-C29FA3321D56", "查看文件信息", "文档管理")]
    public partial class FileViewControl : UserControl
    {
        public FileViewControl()
        {
            InitializeComponent();
        }
        [ModuleStart]
        public void StartEx()
        {
            //txtDocNo.Text = ServiceContainer.GetService<IDocumentService>().GetMaxID().ToString();
        }

        private HYPDM.Entities.PDM_DOCUMENT doc;
        public HYPDM.Entities.PDM_DOCUMENT Document
        {
            get
            {
                return this.doc;
            }
            set
            {
                if (value == null)
                    return;
                this.doc = value;
                this.InitDocInfo(this.doc);
            }
        }

        private void InitDocInfo(HYPDM.Entities.PDM_DOCUMENT document)
        {
            
            //throw new NotImplementedException();
        }

        private void btnAddDoc_Click(object sender, EventArgs e)
        {
            HYPDM.Entities.PDM_DOCUMENT doc = new HYPDM.Entities.PDM_DOCUMENT();
            doc.DOCID = ServiceContainer.GetService<IDocumentService>().GetMaxID().ToString();
            doc.Save();
        }
    }
}
