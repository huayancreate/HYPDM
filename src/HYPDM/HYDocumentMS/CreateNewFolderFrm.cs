using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HYPDM.Entities;
using HYPDM.BLL;
using EAS.Data.Linq;
using EAS.Services;

namespace HYDocumentMS
{
    public partial class CreateNewFolderFrm : Form
    {
        private string saveFilepath = "";
        private String saveFileKey = "";
        private Boolean blAddFlg = false;

        public Boolean BlAddFlg
        {
            get { return blAddFlg; }
            set { blAddFlg = value; }
        }
        private String docName = "";

        public String DocName
        {
            get { return docName; }
            set { docName = value; }
        }


        public String SaveFileKey
        {
            get { return saveFileKey; }
            set { saveFileKey = value; }
        }
        public string SaveFilepath
        {
            get { return saveFilepath; }
            set { saveFilepath = value; }
        }

        public CreateNewFolderFrm()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void Cancel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateNewFolderFrm_Load(object sender, EventArgs e)
        {

            if (this.blAddFlg == true)
            {
                this.txtLastFolder.Text = this.SaveFilepath;

            }
            else
            {
                this.label_Name.Text = "修改文件夹";
                this.txtLastFolder.Text = this.SaveFilepath;
                this.panel_Title.BackgroundImage = global::HYDocumentMS.Properties.Resources.F1;
            }

        }

        private void OK_Paint(object sender, PaintEventArgs e)
        {


        }

        private void panel_Title_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNewFolder_TextChanged(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {  


            if (this.blAddFlg == true)
            { 
               
                
                //添加
                IDocumentDirService _docService = ServiceContainer.GetService<DocumentDirService>();
                bool ok = false;
                DOC_FILE_DIR dir = new DOC_FILE_DIR();
                dir.DFD_ID = Guid.NewGuid().ToString();
                dir.DFD_ROOT_DIR = null;
                dir.DFD_PATH_NAME = this.txtNewFolder.Text.ToString();
                dir.DFD_PARENT_DIR_ID = saveFileKey;//
                dir.DEL_FLAG = "N";

                ok = _docService.addDocumentDir(dir);
                if (ok == true)
                { 
                    FileSockClient.FolderOperSocketClient folder=new FileSockClient.FolderOperSocketClient("add",new FileHelper().getDocumentAllPathByPathID(dir.DFD_ID.ToString()),"");
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                //修改

                DOC_FILE_DIR doc = new DOC_FILE_DIR();
                IDocumentDirService docS = ServiceContainer.GetService<DocumentDirService>();
                Boolean ok = false;
                doc = docS.findDoc(saveFileKey);
                string oldPath = new FileHelper().getDocumentAllPathByPathID(doc.DFD_ID.ToString());
                doc.DFD_PATH_NAME = this.txtNewFolder.Text.Trim();
                ok = docS.updateDocumentDir(doc);
                if (ok == true)
                {
                    FileSockClient.FolderOperSocketClient folder = new FileSockClient.FolderOperSocketClient("modify",oldPath, new FileHelper().getDocumentAllPathByPathID(doc.DFD_ID.ToString()));
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }

            }


        }

        private void txtLastFolder_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
