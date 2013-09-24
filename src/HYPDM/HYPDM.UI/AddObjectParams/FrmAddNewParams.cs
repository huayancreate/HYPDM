using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HYPDM.Entities;
namespace HYPDM.WinUI.AddObjectParams
{
    public partial class FrmAddNewParams : Form
    {
        private PDM_Params m_PDM_Params=new PDM_Params();
        public PDM_Params M_PDM_Params {
            get { return this.m_PDM_Params; }
        }

        private String m_proValue;
        public String M_ProValue {
            get { return this.m_proValue; }
        }

        public FrmAddNewParams(String p_TableName)
        {
            InitializeComponent();
            this.CenterToParent();
            m_PDM_Params.MASTER_TABLE_NAME = p_TableName.Trim().ToUpper();
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            m_PDM_Params.PARAMS_NAME = this.txtParamsColName.Text;
            m_proValue = this.txtParamsValue.Text;

            if (this.btnTxtValue.Checked) m_PDM_Params.PARAMS_DATA_TYPE = DataType.DataColumnType.Text.ToString();
            if (this.btnNumberValue.Checked) m_PDM_Params.PARAMS_DATA_TYPE = DataType.DataColumnType.Number.ToString();
            if (this.btnDateTime.Checked) m_PDM_Params.PARAMS_DATA_TYPE = DataType.DataColumnType.DateTime.ToString();
            this.DialogResult = DialogResult.OK;
        }

    }
   public class WriteValue {
        public String proName;
        public String proValue;
        public String proType;
        public String proTable;
        public String proColumn;
    }
}
