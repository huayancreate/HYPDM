using EAS.Modularization;
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
using EAS.Services;
using HYPDM.BLL;
using HYPDM.WinUI.BaseUI;
using EAS.Explorer;
using AdvancedDataGridView;
using System.IO;
using System.Configuration;
using System.Collections;


namespace HYPDM.WinUI.Document
{
    public partial class DocRegForm : Form
    {
        protected int closed = 0;
        protected bool valueChanged = false;
        IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;
        IPhysicalFileService _physicalService = ServiceContainer.GetService<IPhysicalFileService>();
        IDocumentService _docService = ServiceContainer.GetService<IDocumentService>();

        public DocRegForm()
        {
            InitializeComponent();
            tbcContent.TabPages.Remove(tpFile);
            tbcContent.TabPages.Remove(tpVersion);
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


        private HYPDM.Entities.PDM_DOCUMENT document;
        public HYPDM.Entities.PDM_DOCUMENT Document
        {
            get { return this.document; }
            set
            {
                this.document = value;
                if (value != null)
                    this.InitDocumentInfo();
            }
        }

        /// <summary>
        /// 保存文档基本属性
        /// </summary>
        public void SaveDocment()
        {
            #region 文件
            HYPDM.Entities.PDM_DOCUMENT document;
            string msg = "";
            if (this.document == null)
            {
                document = new HYPDM.Entities.PDM_DOCUMENT();
                document.DOCID = _docService.GetMaxID().ToString();
                document.CREATEDATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                msg = "数据记录添加成功！";
            }
            else
            {
                document = this.Document;
                document.LASTUPDATEDATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                document.LASTUPDATEUSER = LoginInfo.LoginID;
                msg = "数据记录修改成功！";
            }

            document.DOCNAME = txtDocName.Text;
            document.DOCNO = txtDocNo.Text;
            document.DOCSTATUS = "已创建";
            document.CUSTOMERNAME = txtCustName.Text;
            document.CUSTOMERPRONO = txtCustNo.Text;
            document.REMARK = txtRemark.Text;
            document.VERSION = "";
            IList<PDM_DOCUMENT> documentList = new List<PDM_DOCUMENT>();
            documentList.Add(document);
            #endregion
            #region 物理文件
            var fileList = _physicalService.GetList(document.DOCID);
            IList<PDM_PHYSICAL_FILE> physicalList = new List<PDM_PHYSICAL_FILE>();
            if (fileList.Count <= 0)
            {
                PDM_PHYSICAL_FILE physicalfile = new PDM_PHYSICAL_FILE();
                physicalfile.PHYSICALID = _physicalService.GetMaxID().ToString();
                physicalfile.PAPERS = txtDocNo.Text;
                physicalfile.OPERATEUSER = LoginInfo.LoginID;
                physicalfile.PARENT = "0";
                physicalfile.FILEID = document.DOCID;
                physicalList.Add(physicalfile);
            }

            _docService.DocSave(documentList, physicalList);
            #endregion
            this.closed = 1;
            MessageBox.Show(msg);

            this.Document = document;
            this.DialogResult = DialogResult.OK;
        }

        private void btnDocAdd_Click(object sender, EventArgs e)
        {
            SaveDocment();
        }

        private void InitDocumentInfo()
        {
            if (this.Document != null)
            {
                tbcContent.TabPages.Add(tpFile);
                tbcContent.TabPages.Add(tpVersion);
                this.txtDocNo.Text = this.Document.DOCNO;
                this.txtDocName.Text = this.Document.DOCNAME;
                this.txtCustNo.Text = this.Document.CUSTOMERPRONO;
                this.txtCustName.Text = this.Document.CUSTOMERNAME;
                this.txtRemark.Text = this.Document.REMARK;
                this.txtStatus.Text = this.Document.DOCSTATUS;
                this.txtUpdateDate.Text = this.Document.LASTUPDATEDATE;
                this.txtUpdateUser.Text = this.Document.LASTUPDATEUSER;
                this.txtCreateDate.Text = this.Document.CREATEDATE;
                this.BindData();
            }
        }

        private DataTable dt;

        private void btnRegPhysicalFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdFile = new OpenFileDialog();
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                var path = ofdFile.FileName;
                var file = ConfigurationManager.AppSettings["file"].ToString();
                Util.FTPDownUp ftp = Util.Common.FtpInfo();
                FileInfo fi = new FileInfo(path);
                var info = "";
                var result = ftp.FTPUpload(file, "", fi, out info);
                if (result)
                {
                    var extension = Path.GetExtension(path);
                    HYPDM.WinUI.Util.Common u = new HYPDM.WinUI.Util.Common();
                    var type = u.GetExtensionToType(extension);
                    #region 物理文件
                    var dto = _physicalService.GetPhysicalFile("", type);
                    PDM_PHYSICAL_FILE physicalfileType = new PDM_PHYSICAL_FILE();
                    if (dto == null)
                    {
                        physicalfileType.PHYSICALID = _physicalService.GetMaxID().ToString();
                        physicalfileType.PAPERS = type;
                        physicalfileType.FILENAME = "";
                        physicalfileType.OPERATEUSER = LoginInfo.LoginID;
                        if (tvFileList.Rows.Count > 0)
                            physicalfileType.PARENT = (string)tvFileList.Rows[0].Cells["PHYSICALID"].Value;
                        else
                            physicalfileType.PARENT = "0";
                        physicalfileType.FILEID = document.DOCID;
                        physicalfileType.Save();
                    }

                    PDM_PHYSICAL_FILE physicalfile = new PDM_PHYSICAL_FILE();
                    physicalfile.PHYSICALID = _physicalService.GetMaxID().ToString();
                    physicalfile.FILENAME = ofdFile.SafeFileName;
                    physicalfile.FILETYPE = type;
                    physicalfile.FILEVERSION = "0";
                    physicalfile.DESCRIPTION = "";
                    physicalfile.FILEPATH = "ftp://" + ftp.ServerAddr + ":" + ftp.ServerPort + "/" + file + ofdFile.SafeFileName;
                    physicalfile.OPERATEUSER = LoginInfo.LoginID;
                    if (dto != null)
                        physicalfile.PARENT = dto.PHYSICALID;
                    else
                        physicalfile.PARENT = physicalfileType.PHYSICALID;
                    physicalfile.FILEID = document.DOCID;
                    physicalfile.Save();
                    #endregion

                    MessageBox.Show("文件上传成功!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("文件上传失败,具体原因为" + info, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void BindData()
        {
            IPhysicalFileService service = ServiceContainer.GetService<IPhysicalFileService>();
            dt = service.GetDataTable(document.DOCID);
            BindTreeListView(new TreeGridNode(), "0");
        }
        public void BindTreeListView(TreeGridNode node, string parentId)
        {
            Font boldFont = new Font(tvFileList.DefaultCellStyle.Font, FontStyle.Bold);
            DataView dv = new DataView(dt);
            dv.RowFilter = "[PARENT]=" + parentId;
            foreach (DataRowView dr in dv)
            {
                if (parentId == "0")
                {
                    node = tvFileList.Nodes.Add((string)dr["PAPERS"], "", "", "", "", "", (string)dr["PHYSICALID"]);
                    node.DefaultCellStyle.Font = boldFont;
                    BindChildNode(node, (string)dr["PHYSICALID"]);
                }
            }
        }
        public void BindChildNode(TreeGridNode node, string parentId)
        {
            if (parentId != "")
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = "[PARENT]=" + parentId;
                for (int i = 0; i < dv.Count; i++)
                {
                    var fileName = (string)dv[i]["FILENAME"];
                    var papers = (string)dv[i]["PAPERS"];
                    if (fileName == "")
                        fileName = papers;
                    if (i == 0)
                        node = node.Nodes.Add(fileName, (string)dv[i]["FILENAME"],
                            (string)dv[i]["DESCRIPTION"], (string)dv[i]["FILEVERSION"],
                            dv[i]["CHECKIN"].ToString(), (string)dv[i]["CHECKOUT"].ToString(),
                            (string)dv[i]["PHYSICALID"]);
                    else
                        node = node.Parent.Nodes.Add(fileName, (string)dv[i]["FILENAME"],
                            (string)dv[i]["DESCRIPTION"], (string)dv[i]["FILEVERSION"],
                            dv[i]["CHECKIN"].ToString(), dv[i]["CHECKOUT"].ToString(),
                            (string)dv[i]["PHYSICALID"]);
                    BindChildNode(node, (string)dv[i]["PHYSICALID"]);
                }
            }
        }
        private void tvTaskList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (tvFileList.CurrentRow == null) return;
            if (e.RowIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {
                    //弹出操作菜单
                    cmPhysical.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        /// <summary>
        /// 查看文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnView_Click(object sender, EventArgs e)
        {
            int rowIndex = tvFileList.CurrentCell.RowIndex;

            if (rowIndex < 0)
                return;
            DataGridViewRow row = tvFileList.Rows[rowIndex];
            var fileName = row.Cells["FileName"].Value.ToString();
            var temp = System.Environment.GetEnvironmentVariable("TEMP");
            Util.FTPHelper helper = Util.Common.FtpHepler();
            var info = "";
            var tempFilePath = temp + "\\" + fileName;
            var result = helper.DownloadFile(temp, fileName, out info);
            if (result)
            {
                System.Diagnostics.Process.Start(tempFilePath);
            }
            else
            {
                MessageBox.Show("文件查看失败,具体原因为：" + info, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 检出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            int rowIndex = tvFileList.CurrentCell.RowIndex;

            if (rowIndex < 0)
                return;
            DataGridViewRow row = tvFileList.Rows[rowIndex];
            var Id = row.Cells["PHYSICALID"].Value.ToString();

            HYPDM.Entities.PDM_PHYSICAL_FILE physicalfile = _physicalService.GetPhysicalFile(Id, "");
            if (physicalfile == null) return;
            DetectionForm form = new DetectionForm();
            form.PhysicalFile = physicalfile;

            if (form.ShowDialog() == DialogResult.OK)
            {
                HYPDM.Entities.PDM_PHYSICAL_FILE file = form.PhysicalFile;
                row.Cells["FileName"].Value = file.FILENAME;
            }
        }

        /// <summary>
        /// 检入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckIN_Click(object sender, EventArgs e)
        {
            int rowIndex = tvFileList.CurrentCell.RowIndex;

            if (rowIndex < 0)
                return;
            DataGridViewRow row = tvFileList.Rows[rowIndex];
            var Id = row.Cells["PHYSICALID"].Value.ToString();

            HYPDM.Entities.PDM_PHYSICAL_FILE physicalfile = _physicalService.GetPhysicalFile(Id, "");
            if (physicalfile == null) return;
            CheckInForm form = new CheckInForm();
            form.PhysicalFile = physicalfile;

            if (form.ShowDialog() == DialogResult.OK)
            {
                HYPDM.Entities.PDM_PHYSICAL_FILE file = form.PhysicalFile;
                row.Cells["FileName"].Value = file.FILENAME;
            }
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("所选择的文件将被删除，是否确定？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                int rowIndex = tvFileList.CurrentCell.RowIndex;

                if (rowIndex < 0)
                    return;
                DataGridViewRow row = tvFileList.Rows[rowIndex];
                var Id = row.Cells["PHYSICALID"].Value.ToString();
                var file = _physicalService.GetPhysicalFile(Id, "");
                file.Delete();
                MessageBox.Show("所选择的文件已被删除！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        IList<PDM_PHYSICAL_FILE> physicalFileList = new List<PDM_PHYSICAL_FILE>();
    }
}