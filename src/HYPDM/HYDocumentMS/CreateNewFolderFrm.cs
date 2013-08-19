using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HYDocumentMS
{
    public partial class CreateNewFolderFrm : Form
    {
        private string saveFilepath = "";
        private String saveFileKey = "";

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
            this.txtLastFolder.Text =this.SaveFilepath;
        }

        private void OK_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
