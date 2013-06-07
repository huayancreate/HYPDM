using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HYPDM.parts
{
    public partial class ConnectForm : Form
    {
        public ConnectForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                Form useMsgForm = new parts.UseMsgForm();
                useMsgForm.StartPosition = FormStartPosition.CenterParent;
                useMsgForm.ShowDialog();
                useMsgForm.Focus();
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        //private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        //{
        //    if (e.Button != MouseButtons.Right) return;
        //    if (e.Node == null || e.Node.Level == 0) return;
        //    // initMenu();
        //    popupMenu.Show(treeView1,e.X,e.Y);
        //}

        //private void initMenu() {
        //    popupMenu = new ContextMenuStrip();
        //    ToolStripMenuItem tmiEditRoutStation = new ToolStripMenuItem("编辑飞行站点");
        //    // tmiEditRoutStation.Click += new EventHandler(tmiEditRoutStation_Click);
        //    popupMenu.Items.Add(tmiEditRoutStation);
        //    ToolStripMenuItem tmiMoveRouteStation = new ToolStripMenuItem("更改位置");
        //    // tmiMoveRouteStation.Click += new EventHandler(tmiMoveRouteStation_Click);
        //    popupMenu.Items.Add(tmiMoveRouteStation);
        //    ToolStripMenuItem tmiDeleRouteStation = new ToolStripMenuItem("删除飞行站点");
        //    // tmiDeleRouteStation.Click += new EventHandler(tmiDeleRouteStation_Click);
        //    popupMenu.Items.Add(tmiDeleRouteStation);
        //}

    }
}
