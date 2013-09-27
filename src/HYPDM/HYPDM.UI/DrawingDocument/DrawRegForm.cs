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
using EAS.Data.Linq;
using HYDocumentMS;
using HYPDM;
namespace HYPDM.WinUI.DrawingDocument
{

    public partial class DrawRegForm : Form
    {
        protected int closed = 0;
        protected bool valueChanged = false;
        protected Boolean IsWFViewDetail = false;//表明是否是在工作流中进行查看
        IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;
        IDocFileListService _docFileListService = ServiceContainer.GetService<DocFileListService>();
        // IPhysicalFileService _physicalService = ServiceContainer.GetService<PhysicalFileService>();
        IDRAWINGService _docService = ServiceContainer.GetService<DRAWINGService>();

        private Boolean isAddedTab = false; //记录是否已经进行过tab页面的添加
        public DrawRegForm()
        {
            InitializeComponent();

            tbcContent.TabPages.Remove(tpVersion);
            tbcContent.TabPages.Remove(tpParts);
            tbcContent.TabPages.Remove(tabCad);

            tbcContent.TabPages.Remove(tpgExtandsProperties);
            new HYDocumentMS.FileHelper().SetComboBoxValue(cobDocType, "DrawingType", -1);
        }
        public DrawRegForm(Boolean isWFViewDetail)
        {
            InitializeComponent();
            //tbcContent.TabPages.Remove(tpFile);
            tbcContent.TabPages.Remove(tpVersion);
            tbcContent.TabPages.Remove(tpParts);
            tbcContent.TabPages.Remove(tabCad);
            tbcContent.TabPages.Remove(tpgExtandsProperties);
            new HYDocumentMS.FileHelper().SetComboBoxValue(cobDocType, "DrawingType", -1);
            IsWFViewDetail = isWFViewDetail;
            if (IsWFViewDetail)
            {
                this.tsToolbar.Enabled = false;
                //this.tsp.Enabled = false;
                this.menuStrip1.Enabled = false;
                this.toolStrip1.Enabled = false;
                this.tspExtands.Enabled = false;
            }
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


        private HYPDM.Entities.PDM_DRAWING document;
        public HYPDM.Entities.PDM_DRAWING Document
        {
            get { return this.document; }
            set
            {
                this.document = value;
                if (value != null)

                    // isAddedTab = true;
                    this.InitDocumentInfo();
            }
        }

        /// <summary>
        /// 保存文档基本属性
        /// </summary>
        public void SaveDocment()
        {
            #region 文件
            HYPDM.Entities.PDM_DRAWING document;
            string msg = "";
            if (this.document == null)  //新增
            {
                document = new HYPDM.Entities.PDM_DRAWING();
                document.DOCID = Guid.NewGuid().ToString();
                document.CREATEDATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                document.CREATEUSER = LoginInfo.LoginID; //创建用户
                msg = "数据记录添加成功！";

                document.DOCNO = txtDocNo.Text;
                document.DOCSTATUS = "已创建";
                document.DESCRIPTION = txtDescription.Text;
                document.REMARK = txtRemark.Text;
                document.VERSION = new FileHelper().getNewVer("V");
                document.DOCTYPE = cobDocType.SelectedValue.ToString();
                document.DEL_FLAG = "N";
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
                document.DOCTYPE = cobDocType.SelectedValue.ToString();
            }


            IList<PDM_DRAWING> documentList = new List<PDM_DRAWING>();
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

            //  this.DialogResult = DialogResult.OK;
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
                if (!isAddedTab)
                {
                    tbcContent.TabPages.Add(tpParts);
                    // tbcContent.TabPages.Add(tpFile);
                    tbcContent.TabPages.Add(tabCad);
                    tbcContent.TabPages.Add(tpVersion);
                    tbcContent.TabPages.Add(tpgExtandsProperties);
                    isAddedTab = true;
                }
                UpdateExtProperties();
                this.txtDocNo.Text = this.Document.DOCNO;
                this.txtDescription.Text = this.Document.DESCRIPTION;
                this.txtRemark.Text = this.Document.REMARK;
                this.txtStatus.Text = this.Document.DOCSTATUS;
                this.txtUpdateDate.Text = this.Document.LASTUPDATEDATE;
                this.txtUpdateUser.Text = this.Document.LASTUPDATEUSER;
                this.txtCreateDate.Text = this.Document.CREATEDATE;
                this.cobDocType.SelectedValue = this.Document.DOCTYPE;
                this.txtCreateUser.Text = this.Document.CREATEUSER;
                this.txtVer.Text = this.Document.VERSION;
                // this.BindData();

                BindTreeData();
                InitialObjectRelation();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private void BindTreeData()
        {
            // BindFileTreeData(this.tvFileList, DataType.FileType.ProcessFile); //绑定工艺文件
            BindFileTreeData(this.tvCad, DataType.FileType.Drawing); //绑定图纸文档
        }
        //private DataTable dt;

        ///// <summary>
        ///// 查看文件
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnView_Click(object sender, EventArgs e)
        //{

        //    ViewFile(this.tvFileList, DataType.FileType.ProcessFile);
        //}
        ///// <summary>
        ///// 工艺文件注册
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnRegPhysicalFile_Click(object sender, EventArgs e)
        //{
        //    //注册工艺文件
        //    RegFile(DataType.FileType.ProcessFile);
        //}
        ///// <summary>
        ///// 删除文件
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnDel_Click(object sender, EventArgs e)
        //{
        //    delFile(this.tvFileList, DataType.FileType.ProcessFile);
        //}
        ///// <summary>
        ///// 检入
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnCheckIN_Click(object sender, EventArgs e)
        //{
        //    CheckInFile(this.tvFileList, DataType.FileType.ProcessFile);
        //}
        ///// <summary>
        ///// 检出
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnCheckOut_Click(object sender, EventArgs e)
        //{
        //    CheckOut(this.tvFileList, DataType.FileType.ProcessFile);
        //}
        /// <summary>
        /// 物理文件注册
        /// </summary>
        /// <param name="fileType"></param>
        private void RegFile(DataType.FileType fileType)
        {
            string savePath = "";
            string savePathID = "";//保存的目标路径的id
            ListView listViewFile = null;
            HYPDM.WinUI.Document.AddFileFrm frm = new HYPDM.WinUI.Document.AddFileFrm();
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
                //DataEntityQuery<DOC_FILE_LIST> query = DataEntityQuery<DOC_FILE_LIST>.Create();
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
                        FileSockClient.UpLoadFileSocketClient uploadSocket = new FileSockClient.UpLoadFileSocketClient(path, savePath);
                        if (!uploadSocket.AckStatus)
                        {
                            return;
                        }
                        // MessageBox.Show("文件添加成功==文件目录" + @"E:\\PDM文件服务器根目录");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("文件添加失败==文件目录" + savePath + "===" + ex.Message.ToString());
                    }
                    finally
                    {

                    }
                    try
                    {
                        file.DFL_ID = Guid.NewGuid().ToString();
                        file.DFL_FILE_NAME = path.Substring(path.LastIndexOf(@"\") + 1);
                        file.DFL_FILE_EXTEND = path.Substring(path.LastIndexOf(@".") + 1);
                        file.DFL_FILE_CHILD_PATH = savePathID;
                        file.DEL_FLAG = "N";
                        //file.DFL_VER_LATEST = "V" + DateTime.Now.ToString("yyyyMMddHHmmss");
                        file.DFL_VER_LATEST = new HYDocumentMS.FileHelper().getNewVer("V");
                        file.DOCID = Document.DOCID; //与文档表关联主键
                        file.CREATEDATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        file.CREATEUSER = LoginInfo.LoginID;
                        file.LASTUPDATEDATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        file.LASTUPDATEUSER = LoginInfo.LoginID;
                        file.CHECKOUTFLG = "N";
                        file.CHECKINFLG = "Y";
                        // query.Save(file);
                        //query.Insert(file);
                        file.FILE_TYPE = fileType.ToString();
                        file.Save();
                        MessageBox.Show("文件注册成功,文件目录" + savePath, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("文件注册失败【注册到数据库失败】," + ex.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        return;
                    }

                    this.BindTreeData();
                }
            }
        }

        /// <summary>
        /// 查看文件
        /// </summary>
        /// <param name="tgv"></param>
        /// <param name="fileType"></param>
        private void ViewFile(TreeGridView tgv, DataType.FileType fileType)
        {
            int rowIndex = tgv.CurrentCell.RowIndex;


            if (rowIndex <= 0)
            {
                MessageBox.Show("请选择文件", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {


                //  dr["DFL_FILE_NAME"].ToString()
                DataGridViewRow row = tgv.Rows[rowIndex];
                //   string ff = row.Cells[0].Value.ToString();

                HYDocumentMS.IFileHelper file = new FileHelper();
                Boolean bl = file.isHasAuth(DataType.AuthParmsType.View, LoginInfo.LoginID, row.Cells["DFL_ID"].Value.ToString());
                if (bl == false)
                {
                    MessageBox.Show("你没有权限查看此文件!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                String fileName = Path.ChangeExtension(row.Cells["DFL_FILE_NAME"].Value.ToString(), "swf");
                string viewPath = System.Configuration.ConfigurationManager.AppSettings["viewFilePath"].ToString();
                ViewFileFrm fileView = new ViewFileFrm();
                fileView.FileName = fileName;
                //fileView.ViewFilePathAndName = @"D:\swf\Java网络编程精解.swf";
                fileView.ViewFilePath = viewPath;
                fileView.ShowDialog();
            }
        }


        /// <summary>
        /// 检出文件
        /// </summary>
        /// <param name="tgv"></param>
        /// <param name="fileType"></param>
        private void CheckOut(TreeGridView tgv, DataType.FileType fileType)
        {
            int rowIndex = tgv.CurrentCell.RowIndex;


            if (rowIndex <= 0)
            {
                MessageBox.Show("请选择文件", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            DataGridViewRow row = tgv.Rows[rowIndex];
            HYDocumentMS.IFileHelper file = new FileHelper();
            Boolean bl = file.isHasAuth(DataType.AuthParmsType.CheckOut, LoginInfo.LoginID, row.Cells["DFL_ID"].Value.ToString());
            if (bl == false)
            {
                MessageBox.Show("你没有权限检出此文件!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            String Id = row.Cells["DFL_ID"].Value.ToString();
            DOC_FILE_LIST docFileEntity = _docFileListService.GetDocFileEntityByDCID(Id);

            // HYPDM.Entities.PDM_PHYSICAL_FILE physicalfile = _physicalService.GetPhysicalFile(Id, "");
            if (docFileEntity == null) return;
            if (docFileEntity.CHECKOUTFLG == "Y")
            {
                MessageBox.Show("当前文档已被检出，不能再次检出，请等待检出人检入！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            HYPDM.WinUI.Document.DetectionForm form = new HYPDM.WinUI.Document.DetectionForm();
            form.DocFileEntity = docFileEntity;

            if (form.ShowDialog() == DialogResult.OK)
            {
                docFileEntity.CHECKOUTFLG = "Y";
                docFileEntity.CHECKINFLG = "N";
                docFileEntity.CHECKOUTDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                docFileEntity.LASTUPDATEDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                docFileEntity.LASTUPDATEUSER = LoginInfo.LoginID;
                docFileEntity.Save();

                try
                {
                    VersionSave("0", docFileEntity);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    MessageBox.Show("文件检出成功!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// checkin文件
        /// </summary>
        /// <param name="tgv"></param>
        /// <param name="fileType"></param>
        private void CheckInFile(TreeGridView tgv, DataType.FileType fileType)
        {
            int rowIndex = tgv.CurrentCell.RowIndex;

            if (rowIndex <= 0)
            {
                MessageBox.Show("请选择文件", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataGridViewRow row = tgv.Rows[rowIndex];
            String Id = row.Cells["DFL_ID"].Value.ToString();
            DOC_FILE_LIST docFileEntity = _docFileListService.GetDocFileEntityByDCID(Id);
            // HYPDM.Entities.PDM_PHYSICAL_FILE physicalfile = _physicalService.GetPhysicalFile(Id, "");
            HYDocumentMS.IFileHelper file = new FileHelper();
            Boolean bl = file.isHasAuth(DataType.AuthParmsType.CheckIn, LoginInfo.LoginID, row.Cells["DFL_ID"].Value.ToString());
            if (bl == false)
            {
                MessageBox.Show("你没有权限检入此文件!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (docFileEntity == null) return;
            if (docFileEntity.CHECKOUTFLG == "N")
            {
                MessageBox.Show("文件名【" + docFileEntity.DFL_FILE_NAME + "】" + "\n" + "不为检出状态，不能进行检入操作!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                HYPDM.WinUI.Document.CheckInForm form = new HYPDM.WinUI.Document.CheckInForm();
                form.DocFileEntity = docFileEntity;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (form.FileServerAckReult1)
                    {
                        docFileEntity.CHECKINFLG = "Y";
                        docFileEntity.CHECKINDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        docFileEntity.CHECKOUTFLG = "N";
                        docFileEntity.DFL_VER_LATEST = "V" + DateTime.Now.ToString("yyyyMMddHHmmss");
                        docFileEntity.LASTUPDATEDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        docFileEntity.LASTUPDATEUSER = LoginInfo.LoginID;
                        docFileEntity.Save();

                        VersionSave("1", docFileEntity);
                        MessageBox.Show("文件检入成功!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        this.DialogResult = DialogResult.No;
                        MessageBox.Show("文件检入失败", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        private void delFile(TreeGridView tgv, DataType.FileType fileType)
        {

            int rowIndex = tgv.CurrentCell.RowIndex;


            if (rowIndex <= 0)
            {
                MessageBox.Show("请选择文件", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            HYDocumentMS.IFileHelper file = new FileHelper();
            Boolean bl = file.isHasAuth(DataType.AuthParmsType.Delete, LoginInfo.LoginID, tgv.CurrentRow.Cells["DFL_ID"].Value.ToString());
            if (bl == false)
            {
                MessageBox.Show("你没有权限删除此文件!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("所选择的文件将被删除，是否确定？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DataGridViewRow row = tgv.Rows[rowIndex];
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
        private void VersionSave(string type, DOC_FILE_LIST doc)
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
            ProductsAndParts.Parts.PartsConfForm FrmProduct = new ProductsAndParts.Parts.PartsConfForm(2);  //2为半成品  1为成品
            FrmProduct.StartPosition = FormStartPosition.CenterParent;
            FrmProduct.ShowDialog();
        }

        /// <summary>
        /// 新建关联
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRelation_Click(object sender, EventArgs e)
        {
            //    List<PDM_ALL_PRODUCT> pdmAllSelectedProduct = null;
            //    List<PDM_MATERAIL> pdmSelectedMaterial = null;
            //     DataType.RelationObjectType relationObjectType;
            ObjectRelation or = new ObjectRelation();
            IObjectRelationService orS = ServiceContainer.GetService<ObjectRelationService>();
            IList<ObjectRelation> listObjectRelation = new List<ObjectRelation>();
            HYPDM.WinUI.Document.ConnectForm frmConnect = new HYPDM.WinUI.Document.ConnectForm();
            frmConnect.DocumentDrawing = this.Document;
            if (frmConnect.ShowDialog() == DialogResult.OK)
            {
                listObjectRelation = frmConnect.ListObjectRelation;

                try
                {
                    foreach (ObjectRelation objRelation in listObjectRelation)
                    {
                        objRelation.MASTEROBJECTID = this.Document.DOCID;
                        objRelation.MASTEROBJECTTYPE = DataType.RelationObjectType.Drawing.ToString();
                        objRelation.MASTEROBJECTVERSION = this.Document.VERSION;
                        objRelation.Save();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                finally
                {
                    InitialObjectRelation();

                }
            }
        }
        /// <summary>
        /// 删除关联
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelRelation_Click(object sender, EventArgs e)
        {
            //tabProduct
            //  MessageBox.Show(this.tabControl2.SelectedTab.Name.ToString());
            if (this.tabControl2.SelectedTab.Name.ToString() == "tabProduct")
            {
                if (this.dGVProduct.CurrentRow == null)
                {
                    MessageBox.Show("当前没有选中任何可以删除的对象，请确认!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    ObjectRelation or = new ObjectRelation();

                    IObjectRelationService _orDocProd = ServiceContainer.GetService<ObjectRelationService>();
                    or = _orDocProd.getObjectRelation(DataType.RelationObjectType.Drawing.ToString(), this.document.DOCID, DataType.RelationObjectType.Product.ToString(), this.dGVProduct.CurrentRow.Cells["PRODUCTID"].Value.ToString());
                    if (or != null)
                    {
                        or.DEL_FALG = "Y";
                        or.Save();
                        MessageBox.Show("关联删除成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        InitialObjectRelation();
                    }


                }
            }
            else if (this.tabControl2.SelectedTab.Name.ToString() == "tabMaterial")
            {
                if (this.dgvMaterial.CurrentRow == null)
                {
                    MessageBox.Show("当前没有选中任何可以删除的对象，请确认!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    ObjectRelation or = new ObjectRelation();

                    IObjectRelationService _orDocProd = ServiceContainer.GetService<ObjectRelationService>();
                    // or = _orDocProd.getDocMaterialObjectRelation(this.Document.DOCID, this.dgvMaterial.CurrentRow.Cells["MATERIALID"].Value.ToString());
                    or = _orDocProd.getObjectRelation(DataType.RelationObjectType.Drawing.ToString(), this.document.DOCID, DataType.RelationObjectType.Material.ToString(), this.dgvMaterial.CurrentRow.Cells["MATERIALID"].Value.ToString());
                    if (or != null)
                    {
                        or.DEL_FALG = "Y";
                        or.Save();
                        MessageBox.Show("关联删除成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        InitialObjectRelation();
                    }
                }
            }
            else
            {

            }
        }

        private void DocRegForm_Load(object sender, EventArgs e)
        {
            //  new  FileHelper().SetComboBoxValue(cobDocType, "DocType", -1);
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
                this.txtDocNo.Text = System.DateTime.Now.ToString("yyyyMMddHHmmss");
            }
        }


        //20130819
        TreeGridNode node = null;
        DataTable dtDocFile = null;
        private void BindFileTreeData(TreeGridView tgv, DataType.FileType fileType)
        {
            //this.tvFileList.Nodes.Clear();
            tgv.Nodes.Clear();
            IDocFileListService service = ServiceContainer.GetService<IDocFileListService>();
            dtDocFile = service.GetDocFileDataTableByDCID(Document.DOCID, fileType.ToString());

            //  Font boldFont = new Font(tvFileList.DefaultCellStyle.Font, FontStyle.Bold);
            Font boldFont = new Font(tgv.DefaultCellStyle.Font, FontStyle.Bold);
            //    DataView dv = new DataView(dt);
            node = new TreeGridNode();
            // dv.RowFilter = "[PARENT]=" + parentId;
            //foreach (DataRowView dr in dv)
            //{
            //    if (parentId == "0")
            //    {
            // node = tvFileList.Nodes.Add(Document.DOCNO, "", "", "", "", "", "", "");
            node = tgv.Nodes.Add(Document.DOCNO, "", "", "", "", "", "", "");
            node.DefaultCellStyle.Font = boldFont;

            // BindChildNode(node, (string)dr["PHYSICALID"]);
            HYDocumentMS.IFileHelper file = new FileHelper();
            foreach (DataRow dr in dtDocFile.Rows)
            {
                node.Nodes.Add(dr["DFL_FILE_NAME"].ToString(), file.getDocumentAllPathByPathID(dr["DFL_FILE_CHILD_PATH"].ToString()),
                      dr["DFL_VER_LATEST"].ToString(),
                                          dr["CHECKINFLG"].ToString(), dr["CHECKINDATE"].ToString(), dr["CHECKOUTFLG"].ToString(),
                                          dr["CHECKOUTDATE"].ToString(), dr["DFL_ID"].ToString());
                node.Expand();
            }
        }

        /// <summary>
        /// 文件下载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tspDownLoad_Click(object sender, EventArgs e)
        {
            //downLoadFile();
        }

        //private void btnFileDown_Click(object sender, EventArgs e)
        //{
        //    ///工艺文件下载
        //    downLoadFile(this.tvFileList, DataType.FileType.ProcessFile);
        //}

        /// <summary>
        /// 文件下载
        /// </summary>
        private void downLoadFile(TreeGridView tgv, DataType.FileType fileType)
        {
            TreeGridNode node = null;//当前选择的节点
            String serverpath = "";
            node = new TreeGridNode();
            //node = this.tvFileList.CurrentNode;
            node = tgv.CurrentNode;
            int index = node.RowIndex;

            if (index <= 0)
            {
                MessageBox.Show("请选择需要下载的文件" + "(" + index + ")", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tgv.CurrentRow == null)
            {
                MessageBox.Show("请选择需要下载的文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                HYDocumentMS.IFileHelper file = new FileHelper();

                Boolean bl = file.isHasAuth(DataType.AuthParmsType.DownLoad, LoginInfo.LoginID, tgv.CurrentRow.Cells["DFL_ID"].Value.ToString());
                if (bl == false)
                {
                    MessageBox.Show("你没有权限下载此文件!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.FileName = node.Cells[0].Value.ToString();
                saveDialog.Filter = @"Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                DialogResult res = saveDialog.ShowDialog();
                if (DialogResult.OK == res)
                {
                    string clientSaveFileAndPath = saveDialog.FileName.ToString();
                    //MessageBox.Show(clientSavepath);


                    // MessageBox.Show(index.ToString());
                    if (index > 0) //取消第一行
                    {
                        serverpath = node.Cells[1].Value.ToString() + node.Cells[0].Value.ToString();
                        //  MessageBox.Show(serverpath);

                        //FileSockClient.DownLoadFileSocketClient downSocket = new FileSockClient.DownLoadFileSocketClient(serverpath, @"C:\\" + node.Cells[0].Value.ToString());
                        FileSockClient.DownLoadFileSocketClient downSocket = new FileSockClient.DownLoadFileSocketClient(serverpath, clientSaveFileAndPath);
                        if (!downSocket.AckStatus)
                        {
                            return;
                        }
                        else
                        {
                            MessageBox.Show("下载成功,保存路径:" + "\n" + clientSaveFileAndPath, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("请选择需要下载的文件" + "(" + index + ")", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            //  this.tvFileList.CurrentRow
        }

        //private void btnCancel_Click(object sender, EventArgs e)
        //{
        //    CheckOutCancel(this.tvFileList, DataType.FileType.ProcessFile);

        //}

        /// <summary>
        /// 取消检出
        /// </summary>
        /// <param name="tgv"></param>
        /// <param name="fileType"></param>
        private void CheckOutCancel(TreeGridView tgv, DataType.FileType fileType)
        {
            int rowIndex = tgv.CurrentCell.RowIndex;


            if (rowIndex <= 0)
            {
                MessageBox.Show("请选择文件", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow row = tgv.Rows[rowIndex];
            String Id = row.Cells["DFL_ID"].Value.ToString();
            DOC_FILE_LIST docFileEntity = _docFileListService.GetDocFileEntityByDCID(Id);
            if (docFileEntity.CREATEUSER.ToString() != LoginInfo.LoginID.ToString())
            {
                MessageBox.Show("当前不为文件的检出用户，不能进行取消动作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            if (docFileEntity == null) return;

            docFileEntity.CHECKOUTFLG = "N";
            docFileEntity.CHECKINFLG = "Y";
            docFileEntity.LASTUPDATEUSER = LoginInfo.LoginID;
            docFileEntity.LASTUPDATEDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            try
            {
                docFileEntity.Save();
                VersionSave("qx", docFileEntity);
                MessageBox.Show("文件检出取消成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }
            finally
            {

            }
        }
        private void DocRegForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductsAndParts.Products.ProductsConfForm FrmProduct = new ProductsAndParts.Products.ProductsConfForm(1);  //2为半成品  1为成品
            FrmProduct.StartPosition = FormStartPosition.CenterParent;
            FrmProduct.ShowDialog();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            ProductsAndParts.Material.MaterialConfForm FrmMat = new ProductsAndParts.Material.MaterialConfForm();
            FrmMat.StartPosition = FormStartPosition.CenterParent;
            FrmMat.ShowDialog();
        }


        /// <summary>
        /// 初始化文档关联的对象信息
        /// </summary>
        private void InitialObjectRelation()
        {
            if (this.Document != null)
            {
                this.dGVProduct.DataSource = new FileHelper().getDataTableBySql("*", "WHERE PRODUCTID IN (SELECT RELATIONOBJECTID FROM ObjectRelation WHERE MASTEROBJECTTYPE='" + DataType.RelationObjectType.Drawing + "' AND RELATIONOBJECTTYPE='Product' AND DEL_FALG='N' AND MASTEROBJECTID='" + this.Document.DOCID + "')", "PDM_ALL_PRODUCT");
                this.dgvMaterial.DataSource = new FileHelper().getDataTableBySql("*", "WHERE MATERIALID IN (SELECT RELATIONOBJECTID FROM ObjectRelation WHERE MASTEROBJECTTYPE='" + DataType.RelationObjectType.Drawing + "' AND RELATIONOBJECTTYPE='Material' AND DEL_FALG='N' AND MASTEROBJECTID='" + this.Document.DOCID + "')", "PDM_MATERAIL");
            }
        }

        private void btnAddProperties_Click(object sender, EventArgs e)
        {
            AddObjectParams.FrmAddParms parms = new AddObjectParams.FrmAddParms("PDM_DRAWING", document.DOCID, "DOCID");
            parms.ShowDialog();
            UpdateExtProperties();
        }

        private void tspBtnQuery_Click(object sender, EventArgs e)
        {
            // AddObjectParams.FrmAdvanceQuery query = new AddObjectParams.FrmAdvanceQuery();
            AddObjectParams.FrmTest query = new AddObjectParams.FrmTest();
            query.MasterTableName = "PDM_DOCUMENT";
            query.ShowDialog();
        }

        private void UpdateExtProperties()
        {
            this.dgvExptendProperties.DataSource = AddObjectParams.ObjectParams.NewInstance.GetExtendsProperties("PDM_DRAWING", document.DOCID, "DOCID");
        }

        private void tspCadDownLoad_Click(object sender, EventArgs e)
        {
            ///图纸文件下载
            downLoadFile(this.tvCad, DataType.FileType.Drawing);
        }

        private void tspRegPhysicCad_Click(object sender, EventArgs e)
        {
            ///注册图纸文件
            RegFile(DataType.FileType.Drawing);
        }

        private void menuCadView_Click(object sender, EventArgs e)
        {
            //图纸文件查看
            ViewFile(this.tvCad, DataType.FileType.Drawing);
        }

        private void menuCadDownLoad_Click(object sender, EventArgs e)
        {
            ///图纸文件下载
            downLoadFile(this.tvCad, DataType.FileType.Drawing);
        }

        private void menuCadCheckIn_Click(object sender, EventArgs e)
        {
            //图纸文件的checkin
            CheckInFile(this.tvCad, DataType.FileType.Drawing);
        }

        private void menuCadCheckOut_Click(object sender, EventArgs e)
        {
            ///图纸文件的checkout
            CheckOut(this.tvCad, DataType.FileType.Drawing);
        }

        private void menuCadCancelCheckOut_Click(object sender, EventArgs e)
        {
            ///图纸文件的取消检出动作
            CheckOutCancel(this.tvCad, DataType.FileType.Drawing);
        }

        private void menuCadFileDelete_Click(object sender, EventArgs e)
        {
            ///图纸文件的删除
            delFile(this.tvCad, DataType.FileType.Drawing);
        }


    }
}