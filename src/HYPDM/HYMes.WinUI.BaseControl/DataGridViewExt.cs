using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HYPDM.BaseControl
{   
    /// <summary>
    /// 
    /// </summary>
    public partial class DataGridViewExt : DataGridView
    {  
        /// <summary>
        /// 
        /// </summary>
        public DataGridViewExt()
            :base()
        {
            InitializeComponent();
            this.AllowUserToAddRows = false;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            //this.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DefaultCellStyle = dataGridViewCellStyle1;
            this.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void DataGridViewExt_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }
        /// <summary>
        /// 增加datagridview前面的序列号
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle =
                new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, this.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, Convert.ToInt32(e.RowIndex + 1).ToString(), this.RowHeadersDefaultCellStyle.Font, rectangle, this.
            RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
            base.OnRowPostPaint(e);
        }
    }
}
