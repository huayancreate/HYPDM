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
using System.IO;
namespace HYDocumentMS
{
    public partial class CreateNewFolderFrm : Form
    {  
        /// <summary>
        /// 保存文件路径,添加时候用的
        /// </summary>
        private string saveFilepath = "";
        /// <summary>
        /// 选中文件夹的节点
        /// </summary>
        private String saveFileKey = "";
        /// <summary>
        /// 添加标识
        /// </summary>
        private Boolean blAddFlg = false;
        /// <summary>
        /// 在进行修改的时候，获取修改文件夹的父节点
        /// </summary>
        private string fatherFileKey = "";
        /// <summary>
        /// 修改文件夹的时候，将文件夹原来的名称带过来
        /// </summary>
        private string modifyFolderText = "";

        public string ModifyFolderText
        {
            get { return modifyFolderText; }
            set { modifyFolderText = value; }
        }
        public String FatherFileKey
        {
            get { return fatherFileKey; }
            set { fatherFileKey = value; }
        }
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
                this.txtNewFolder.Text = this.ModifyFolderText;
                this.panel_Title.BackgroundImage = global:: HYDocumentMS.Properties.Resources.F1;
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
                if (addChecking())
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
                        FileSockClient.FolderOperSocketClient folder = new FileSockClient.FolderOperSocketClient("add", new FileHelper().getDocumentAllPathByPathID(dir.DFD_ID.ToString()), "");
                        MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            else
            {
                //修改
                if (modifyChecking())
                {
                    DOC_FILE_DIR doc = new DOC_FILE_DIR();
                    IDocumentDirService docS = ServiceContainer.GetService<DocumentDirService>();
                    Boolean ok = false;
                    doc = docS.findDoc(saveFileKey);
                    string oldPath = new FileHelper().getDocumentAllPathByPathID(doc.DFD_ID.ToString());
                    doc.DFD_PATH_NAME = this.txtNewFolder.Text.Trim();
                    ok = docS.updateDocumentDir(doc);
                    if (ok == true)
                    {
                        FileSockClient.FolderOperSocketClient folder = new FileSockClient.FolderOperSocketClient("modify", oldPath, new FileHelper().getDocumentAllPathByPathID(doc.DFD_ID.ToString()));
                        MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                }

            }


        }

        private void txtLastFolder_TextChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 添加文件夹check
        /// </summary>
        /// <returns></returns>
        public bool addChecking()
        {
            IDocumentDirService _docService = ServiceContainer.GetService<DocumentDirService>();
            if (this.txtNewFolder.Text.ToString() == "")
            {
                MessageBox.Show("文件夹名不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                this.txtNewFolder.SelectAll();
                return false;
            }
            if (this.txtNewFolder.Text.ToString().IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                MessageBox.Show("文件夹名不能包含下列任意字符之一: / : *| “”><", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                this.txtNewFolder.SelectAll();
                return false;
            }
            else if (_docService.findDocments(saveFileKey, this.txtNewFolder.Text) != 0)
            {

                MessageBox.Show("指定文件与现有文件重名，请重新命名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                this.txtNewFolder.SelectAll();
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 验证修改文件夹
        /// </summary>
        /// <returns></returns>
        public bool modifyChecking()
        {
            if (this.txtNewFolder.Text == this.ModifyFolderText)
            {
                MessageBox.Show("文件夹与修改之前的名称一样，无需变动", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }
            IDocumentDirService _docService = ServiceContainer.GetService<DocumentDirService>();
            if (this.txtNewFolder.Text.ToString() == "")
            {
                MessageBox.Show("文件夹名不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (this.txtNewFolder.Text.ToString().IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                MessageBox.Show("文件夹名不能包含下列任意字符之一: / : *| “”><", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (_docService.findDocments(fatherFileKey, this.txtNewFolder.Text) != 0)
            {
                MessageBox.Show("指定文件与现有文件重名，请重新命名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNewFolder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                OK_Click(sender, new EventArgs());
            }
        }


    }
}
