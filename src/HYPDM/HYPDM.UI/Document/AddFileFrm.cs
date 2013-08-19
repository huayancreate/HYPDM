using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HYPDM.WinUI.Document
{   
    /// <summary>
    /// 
    /// </summary>
    public partial class AddFileFrm : Form
    {

        private string saveFilepath = "";
        private ListView listViewFile = null;

        public ListView ListViewFile
        {
            get { return listViewFile; }
            set { listViewFile = value; }
        }


        public string SaveFilepath
        {
            get { return saveFilepath; }
            set { saveFilepath = value; }
        }



        /// <summary>
        /// 
        /// </summary>
        public AddFileFrm()
        {
            InitializeComponent();
            this.CenterToParent();
           
        }

        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        private void panel_ADD_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void panel_ADD_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Fdir = openFileDialog1.FileName;
                for (int i = 0; i < listView_Dir.Items.Count; i++)
                {
                    if (Fdir == listView_Dir.Items[i].Text)
                    {
                        MessageBox.Show("该文件已存在，无法添加。");
                        return;
                    }
                }
                ListViewItem lvi = new ListViewItem(Fdir);//实例化一个项

                //if (Fdir.Length > listView_Dir.Width)
                //    listView_Dir.Width = Fdir.Length;
                //lvi.ToolTipText = Fdir;
                listView_Dir.Items.Add(lvi);//添加列信息
               // listView_Dir.Items.Add(Fdir);
                //MessageBox.Show(listView_Dir.Width.ToString());
            }
        }

        private void panel_Delete_Click(object sender, EventArgs e)
        {
            if (listView_Dir.SelectedItems.Count > 0)
            {
                ListViewItem HLVI = listView_Dir.SelectedItems[0];
                HLVI.Remove();
            }
            else
            {
                MessageBox.Show("请选择要删除的文件。");
            }
        }

        private void CreateNewFileFrm_Load(object sender, EventArgs e)
        {
           // this.lblSavePath.Text = "文件将被保存的路径:" + this.SaveFilepath;
            //this.listView_Dir.Columns[0].Text = "保存路径:" + this.SaveFilepath;
        }

        private void panel_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            listViewFile = this.listView_Dir; //存放需要添加的文件清单
        }
    }
}
