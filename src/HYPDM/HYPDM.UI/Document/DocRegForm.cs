﻿using EAS.Modularization;
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
using EAS.Data.Linq;
namespace HYPDM.WinUI.Document
{
    public partial class DocRegForm : Form
    {
        protected int closed = 0;
        protected bool valueChanged = false;
        IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;
        IDocFileListService _docFileListService = ServiceContainer.GetService<DocFileListService>();
        IPhysicalFileService _physicalService = ServiceContainer.GetService<PhysicalFileService>();
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
            if (this.document == null)  //新增
            {
                document = new HYPDM.Entities.PDM_DOCUMENT();
                document.DOCID = _docService.GetMaxID().ToString();
                document.CREATEDATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                document.CREATEUSER = LoginInfo.LoginID; //创建用户
                msg = "数据记录添加成功！";

                document.DOCNO = txtDocNo.Text;
                document.DOCSTATUS = "已创建";
                document.DESCRIPTION = txtDescription.Text;
                document.REMARK = txtRemark.Text;
                document.VERSION = "V1.0";
                document.DOCTYPE = cobDocType.Text;
            }
            else //修改
            {
                document = this.Document;
                document.LASTUPDATEDATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                document.LASTUPDATEUSER = LoginInfo.LoginID;
                msg = "数据记录修改成功！";
                //document.DOCNO = txtDocNo.Text;
                //document.DOCSTATUS = "已创建";
                document.DESCRIPTION = txtDescription.Text;
                document.REMARK = txtRemark.Text;
                //document.VERSION = "V1.0";
                //document.DOCTYPE = cobDocType.Text;
            }


            IList<PDM_DOCUMENT> documentList = new List<PDM_DOCUMENT>();
            documentList.Add(document);
            #endregion
            #region 物理文件
            //var fileList = _physicalService.GetList(document.DOCID);
            //IList<PDM_PHYSICAL_FILE> physicalList = new List<PDM_PHYSICAL_FILE>();
            //if (fileList.Count <= 0)
            //{
            //    PDM_PHYSICAL_FILE physicalfile = new PDM_PHYSICAL_FILE();
            //    physicalfile.PHYSICALID = _physicalService.GetMaxID().ToString();
            //    physicalfile.PAPERS = txtDocNo.Text;
            //    physicalfile.OPERATEUSER = LoginInfo.LoginID;
            //    physicalfile.PARENT = "0";
            //    physicalfile.FILEID = document.DOCID;
            //    physicalList.Add(physicalfile);
            //}

            //_docService.DocSave(documentList, physicalList);
            _docService.DocSave(documentList);
            #endregion
            this.closed = 1;
            MessageBox.Show(msg);

            this.Document = document;
            this.DialogResult = DialogResult.OK;
        }

        private void btnDocAdd_Click(object sender, EventArgs e)
        {
            if (SaveCheck())
            {
                SaveDocment();
            }
        }
        /// <summary>
        /// 保存前的输入check
        /// </summary>
        private Boolean SaveCheck()
        {
            if (txtDocNo.Text.Trim().Equals(""))
            {
                MessageBox.Show("请输入文档编号!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                this.txtDocNo.Focus();
                return false;
            }
            if (this.cobDocType.SelectedIndex == -1)
            {
                MessageBox.Show("请选择文档类型!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                this.cobDocType.Focus();
                return false;
            }
            return true;
        }

        private void InitDocumentInfo()
        {
            if (this.Document != null)
            {
                tbcContent.TabPages.Add(tpFile);
                tbcContent.TabPages.Add(tpVersion);
                this.txtDocNo.Text = this.Document.DOCNO;
                this.txtDescription.Text = this.Document.DESCRIPTION;
                this.txtRemark.Text = this.Document.REMARK;
                this.txtStatus.Text = this.Document.DOCSTATUS;
                this.txtUpdateDate.Text = this.Document.LASTUPDATEDATE;
                this.txtUpdateUser.Text = this.Document.LASTUPDATEUSER;
                this.txtCreateDate.Text = this.Document.CREATEDATE;
                this.cobDocType.Text = this.Document.DOCTYPE;
                this.txtCreateUser.Text = this.Document.CREATEUSER;
                this.txtVer.Text = this.Document.VERSION;
                //this.BindData();
                BindTreeData();
            }
        }

        //private DataTable dt;


        private void btnRegPhysicalFile_Click(object sender, EventArgs e)
        {
            string savePath = "";
            string savePathID = "";//保存的目标路径的id
            ListView listViewFile = null;
            AddFileFrm frm = new AddFileFrm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //将需要添加的文件信息返回来
                //fileList
                //savePath
                listViewFile = frm.ListViewFile;
                savePath = frm.SaveFilepath; //从弹出窗体返回来的保存路径
                savePathID = frm.SavePathID;//保存的目标路径的id
               // MessageBox.Show(savePath);
                //   FileSockClient.UpLoadFileSocketClient sock = null;
                DataEntityQuery<DOC_FILE_LIST> query = DataEntityQuery<DOC_FILE_LIST>.Create();
                DOC_FILE_LIST file = new DOC_FILE_LIST();
                String path = "";
                foreach (ListViewItem item in listViewFile.Items)
                {
                    // MessageBox.Show(item.Text.ToString());

                    //var path = ofdFile.FileName;
                    path = item.Text.ToString();

                    // IDocFileListService _fileService = ServiceContainer.GetService<DocFileListService>();
                    try
                    {
                        //FileSockClient.UpLoadFileSocketClient sock = new FileSockClient.UpLoadFileSocketClient(path, @"D:\\PDM文件服务器根目录");
                        FileSockClient.UpLoadFileSocketClient sock = new FileSockClient.UpLoadFileSocketClient(path,savePath);
                        
                        // MessageBox.Show("文件添加成功==文件目录" + @"E:\\PDM文件服务器根目录");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("文件添加失败==文件目录" + savePath + "===" + ex.Message.ToString());
                    }
                    finally
                    {
                        file.DFL_ID = Guid.NewGuid().ToString();
                        file.DFL_FILE_NAME = path.Substring(path.LastIndexOf(@"\") + 1);
                        file.DFL_FILE_EXTEND = path.Substring(path.LastIndexOf(@".") + 1);
                        file.DFL_FILE_CHILD_PATH = savePathID;
                        file.DEL_FLAG = "N";
                        file.DFL_VER_LATEST ="V"+DateTime.Now.ToString("yyyyMMddHHmmss");
                        file.DOCID = Document.DOCID; //与文档表关联主键
                        file.CREATEDATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        file.CREATEUSER = LoginInfo.LoginID;
                        file.LASTUPDATEDATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        file.LASTUPDATEUSER = LoginInfo.LoginID;
                        // query.Save(file);
                        query.Insert(file);
                    }
                    this.BindTreeData();
                }
            }
        }
        //遍历文件列表进行存储
        //}
        // OpenFileDialog ofdFile = new OpenFileDialog();
        //if (ofdFile.ShowDialog() == DialogResult.OK)
        //{
        //var path = ofdFile.FileName;
        //IDocFileListService _fileService = ServiceContainer.GetService<DocFileListService>();
        //try
        //{

        //    FileSockClient.UpLoadFileSocketClient sock = new FileSockClient.UpLoadFileSocketClient(path, @"E:\\PDM文件服务器根目录");
        //    // MessageBox.Show("文件添加成功==文件目录" + @"E:\\PDM文件服务器根目录");
        //    DataEntityQuery<DOC_FILE_LIST> query = DataEntityQuery<DOC_FILE_LIST>.Create();
        //    DOC_FILE_LIST file = new DOC_FILE_LIST();
        //    file.DFL_ID = Guid.NewGuid().ToString();

        //    file.DFL_FILE_NAME = path.Substring(path.LastIndexOf(@"\") + 1);
        //    file.DFL_FILE_EXTEND = path.Substring(path.LastIndexOf(@".") + 1);
        //    file.DFL_FILE_CHILD_PATH = "00001";
        //    file.DEL_FLAG = "N";
        //    file.DFL_VER_LATEST = "V1.0";
        //    file.DOCID = Document.DOCID; //与文档表关联主键
        //    file.CREATEDATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        //    file.CREATEUSER = LoginInfo.LoginID;
        //    file.LASTUPDATEDATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        //    file.LASTUPDATEUSER = LoginInfo.LoginID;
        //    // query.Save(file);
        //    query.Insert(file);


        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show("文件添加失败==文件目录" + @"E:\\PDM文件服务器根目录" + "===" + ex.Message.ToString());
        //}
        //finally
        //{

        //}

        #region
        //var file = ConfigurationManager.AppSettings["file"].ToString();
        //Util.FTPDownUp ftp = Util.Common.FtpInfo();
        //FileInfo fi = new FileInfo(path);
        //var info = "";
        //var result = ftp.FTPUpload(file, "", fi, out info);
        //if (result)
        //{
        //    var extension = Path.GetExtension(path);
        //    HYPDM.WinUI.Util.Common u = new HYPDM.WinUI.Util.Common();
        //    var type = u.GetExtensionToType(extension);
        //    #region 物理文件
        //    var dto = _physicalService.GetPhysicalFile("", type);
        //    PDM_PHYSICAL_FILE physicalfileType = new PDM_PHYSICAL_FILE();
        //    if (dto == null)
        //    {
        //        physicalfileType.PHYSICALID = _physicalService.GetMaxID().ToString();
        //        physicalfileType.PAPERS = type;
        //        physicalfileType.FILENAME = "";
        //        physicalfileType.OPERATEUSER = LoginInfo.LoginID;
        //        if (tvFileList.Rows.Count > 0)
        //            physicalfileType.PARENT = (string)tvFileList.Rows[0].Cells["PHYSICALID"].Value;
        //        else
        //            physicalfileType.PARENT = "0";
        //        physicalfileType.FILEID = document.DOCID;
        //        physicalfileType.Save();
        //    }

        //    PDM_PHYSICAL_FILE physicalfile = new PDM_PHYSICAL_FILE();
        //    physicalfile.PHYSICALID = _physicalService.GetMaxID().ToString();
        //    physicalfile.FILENAME = ofdFile.SafeFileName;
        //    physicalfile.FILETYPE = type;
        //    physicalfile.FILEVERSION = "0";
        //    physicalfile.DESCRIPTION = "";
        //    physicalfile.FILEPATH = "ftp://" + ftp.ServerAddr + ":" + ftp.ServerPort + "/" + file + ofdFile.SafeFileName;
        //    physicalfile.OPERATEUSER = LoginInfo.LoginID;
        //    if (dto != null)
        //        physicalfile.PARENT = dto.PHYSICALID;
        //    else
        //        physicalfile.PARENT = physicalfileType.PHYSICALID;
        //    physicalfile.FILEID = document.DOCID;
        //    physicalfile.Save();
        //    #endregion

        //    MessageBox.Show("文件上传成功!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}
        //else
        //{
        //    MessageBox.Show("文件上传失败,具体原因为" + info, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}
        #endregion
        //    }
        //}

        //public void BindData()
        //{
        //    IPhysicalFileService service = ServiceContainer.GetService<IPhysicalFileService>();
        //    dt = service.GetDataTable(document.DOCID);
        //    BindTreeListView(new TreeGridNode(), "0");
        //}
        //public void BindTreeListView(TreeGridNode node, string parentId)
        //{
        //    Font boldFont = new Font(tvFileList.DefaultCellStyle.Font, FontStyle.Bold);
        //    DataView dv = new DataView(dt);
        //    dv.RowFilter = "[PARENT]=" + parentId;
        //    foreach (DataRowView dr in dv)
        //    {
        //        if (parentId == "0")
        //        {
        //            node = tvFileList.Nodes.Add((string)dr["PAPERS"], "", "", "", "", "", (string)dr["PHYSICALID"]);
        //            node.DefaultCellStyle.Font = boldFont;
        //            BindChildNode(node, (string)dr["PHYSICALID"]);
        //        }
        //    }
        //}
        //public void BindChildNode(TreeGridNode node, string parentId)
        //{
        //    if (parentId != "")
        //    {
        //        DataView dv = new DataView(dt);
        //        dv.RowFilter = "[PARENT]=" + parentId;
        //        for (int i = 0; i < dv.Count; i++)
        //        {
        //            var fileName = (string)dv[i]["FILENAME"];
        //            var papers = (string)dv[i]["PAPERS"];
        //            if (fileName == "")
        //                fileName = papers;
        //            if (i == 0)
        //                node = node.Nodes.Add(fileName, (string)dv[i]["FILENAME"],
        //                    (string)dv[i]["DESCRIPTION"], (string)dv[i]["FILEVERSION"],
        //                    dv[i]["CHECKIN"].ToString(), (string)dv[i]["CHECKOUT"].ToString(),
        //                    (string)dv[i]["PHYSICALID"]);
        //            else
        //                node = node.Parent.Nodes.Add(fileName, (string)dv[i]["FILENAME"],
        //                    (string)dv[i]["DESCRIPTION"], (string)dv[i]["FILEVERSION"],
        //                    dv[i]["CHECKIN"].ToString(), dv[i]["CHECKOUT"].ToString(),
        //                    (string)dv[i]["PHYSICALID"]);
        //            BindChildNode(node, (string)dv[i]["PHYSICALID"]);
        //        }
        //    }
        //}
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
            if (physicalfile.FILESTATUS == "0") { MessageBox.Show("当前文档已被检出，不能再次检出，请等待检出人检入！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            DetectionForm form = new DetectionForm();
            form.PhysicalFile = physicalfile;

            if (form.ShowDialog() == DialogResult.OK)
            {
                physicalfile.FILESTATUS = "0";
                physicalfile.Save();

                HYPDM.Entities.PDM_PHYSICAL_FILE file = form.PhysicalFile;
                row.Cells["FileName"].Value = file.FILENAME;
               // VersionSave("0");
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
            String Id = row.Cells["DFL_ID"].Value.ToString();

           // HYPDM.Entities.PDM_PHYSICAL_FILE physicalfile = _physicalService.GetPhysicalFile(Id, "");
            DOC_FILE_LIST docFileEntity = _docFileListService.GetDocFileEntityByDCID(Id);
            if (docFileEntity == null) return;
            if (docFileEntity.CHECKOUTFLG == "N")
            {
                MessageBox.Show("文件名【" + docFileEntity .DFL_FILE_NAME+"】"+"\n"+ "不为检出状态，不能进行检入操作!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                CheckInForm form = new CheckInForm();
                form.DocFileEntity = docFileEntity;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    docFileEntity.CHECKINFLG = "Y";
                    docFileEntity.CHECKINDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    docFileEntity.CHECKOUTFLG = "N";
                    docFileEntity.DFL_VER_LATEST = "V" + DateTime.Now.ToString("yyyyMMddHHmmss");
                    docFileEntity.Save();

                    VersionSave("1", docFileEntity);
                }
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
                string dflID = row.Cells["DFL_ID"].Value.ToString();
                //var file = _physicalService.GetPhysicalFile(Id, "");
               // IDocFileListService serv = new DocFileListService();
                if (_docFileListService.delDocFileByDFLID(dflID))
                {
                    MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("删除失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                this.BindTreeData();
                //serv.
                //file.Delete();
              //  MessageBox.Show("所选择的文件已被删除！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 版本历史记录保存
        /// </summary>
        /// <param name="type">0：检出，1：检入</param>
        private void VersionSave(string type,DOC_FILE_LIST doc)
        {
            PDM_VERSION_HISTORY version = new PDM_VERSION_HISTORY();
            version.ID = Guid.NewGuid().ToString();
            version.VERSIONNO = doc.DFL_VER_LATEST;
            version.VERSIONSTATUS = type;
            version.OPERATORUSER = LoginInfo.LoginID;
            version.OPERATORDATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            version.DFL_ID = doc.DFL_ID;
            version.FILE_NAME = doc.DFL_FILE_NAME;
            version.Insert();
        }

        /// <summary>
        /// 半成品、原材料、工艺装备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHalfProduct_Click(object sender, EventArgs e)
        {
            Parts.ProductRegForm form = new Parts.ProductRegForm();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        /// <summary>
        /// 新建关联
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRelation_Click(object sender, EventArgs e)
        {
            Parts.ConnectForm form = new Parts.ConnectForm();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }
        /// <summary>
        /// 删除关联
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelRelation_Click(object sender, EventArgs e)
        {

        }

        private void DocRegForm_Load(object sender, EventArgs e)
        {
            this.txtDocNo.Focus();
            if (document != null)
            {
                this.txtDocNo.Enabled = false;  //如果为修改界面，则将文档编号设置为不可用状态
                //this.txtRemark.ReadOnly = true;  //remark标记为只读
                this.Text = "文档对象-编辑";
            }
            else
            {
                this.Text = "文档对象-注册";
            }
        }


        //20130819
        TreeGridNode node = null;
        DataTable dtDocFile = null;
        private void BindTreeData()
        {

            this.tvFileList.Nodes.Clear();
            IDocFileListService service = ServiceContainer.GetService<IDocFileListService>();
            dtDocFile = service.GetDocFileDataTableByDCID(Document.DOCID);

            Font boldFont = new Font(tvFileList.DefaultCellStyle.Font, FontStyle.Bold);
        //    DataView dv = new DataView(dt);
            node = new TreeGridNode();
            // dv.RowFilter = "[PARENT]=" + parentId;
            //foreach (DataRowView dr in dv)
            //{
            //    if (parentId == "0")
            //    {
            node = tvFileList.Nodes.Add(Document.DOCNO, "", "", "", "", "","","");
            node.DefaultCellStyle.Font = boldFont;
           
            // BindChildNode(node, (string)dr["PHYSICALID"]);
            HYDocumentMS.IFileHelper file = new HYDocumentMS.FileHelper();
            foreach (DataRow dr in dtDocFile.Rows)
            {
                node.Nodes.Add(dr["DFL_FILE_NAME"].ToString(), file.getDocumentAllPathByPathID(dr["DFL_FILE_CHILD_PATH"].ToString()),
                      dr["DFL_VER_LATEST"].ToString(),
                                          dr["CHECKINFLG"].ToString(), dr["CHECKINDATE"].ToString(), dr["CHECKOUTFLG"].ToString(),
                                          dr["CHECKOUTDATE"].ToString(), dr["DFL_ID"].ToString());
                node.Expand();
            }
            

            //    }
            //}
        }



        /// <summary>
        /// 测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvFileList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex > -1)
           if (e.RowIndex >0) //将第一行去掉，第一行为文档编号
            {
               // MessageBox.Show(this.tvFileList.Nodes[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
             //   MessageBox.Show(this.tvFileList.CurrentRow.Cells[1].Value.ToString() + this.tvFileList.CurrentRow.Cells[0].Value.ToString());
                //MessageBox.Show("列的索引"+e.ColumnIndex.ToString());
                //MessageBox.Show("行的索引" + e.RowIndex.ToString());
              //  MessageBox.Show(this.tvFileList.CurrentNode.Cells[1].Value.ToString() + this.tvFileList.CurrentNode.Cells[0].Value.ToString());
            }
        }

        /// <summary>
        /// 文件下载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tspDownLoad_Click(object sender, EventArgs e)
        {
            downLoadFile();
        }

        private void btnFileDown_Click(object sender, EventArgs e)
        {
            downLoadFile();
        }

        /// <summary>
        /// 文件下载
        /// </summary>
        private void downLoadFile()
        {
            TreeGridNode node = null;//当前选择的节点
            String serverpath = "";
            if (tvFileList.CurrentRow == null)
            {
                MessageBox.Show("请选择需要下载的文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                node = new TreeGridNode();
                node = this.tvFileList.CurrentNode;
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.FileName = node.Cells[0].Value.ToString();
                saveDialog.Filter = @"Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                DialogResult res= saveDialog.ShowDialog();
                if (DialogResult.OK == res)
                {
                    string clientSaveFileAndPath = saveDialog.FileName.ToString();
                    //MessageBox.Show(clientSavepath);
                  
                    int index = node.RowIndex;
                    // MessageBox.Show(index.ToString());
                    if (index > 0) //取消第一行
                    {
                        serverpath = node.Cells[1].Value.ToString() + node.Cells[0].Value.ToString();
                      //  MessageBox.Show(serverpath);

                        //FileSockClient.DownLoadFileSocketClient downSocket = new FileSockClient.DownLoadFileSocketClient(serverpath, @"C:\\" + node.Cells[0].Value.ToString());
                        FileSockClient.DownLoadFileSocketClient downSocket = new FileSockClient.DownLoadFileSocketClient(serverpath, clientSaveFileAndPath);
                    }
                    else
                    {
                        MessageBox.Show("请选择需要下载的文件" + "(" + index + ")", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            //  this.tvFileList.CurrentRow
        }

    }
}