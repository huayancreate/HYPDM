using HYPDM.Entities;
/*
 * 由SharpDevelop创建。
 * 用户： wliu
 * 日期: 2013/10/9
 * 时间: 16:16
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using WcfClient;

namespace AutoCadPlugins.Client
{
	public partial class InitForm : Form
	{
		WcfClient.pdmService.IPDMService client = null;
		PDM_DRAWING draw = null;
		public InitForm()
		{
			InitializeComponent();
			InitLoad();
			EnabledControls();
		}

		/// <summary>
		/// 图纸对象创建
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnDrawCreate_Click(object sender, EventArgs e)
		{
			client = Common.Util.Service;
			//draw =client.GetDrawingByID("29152e50-0b0d-4e15-94a9-847aa7f83725");
			//PDM_DRAWING draw = client.GetDrawingByID("e896d90d-55e8-4ef6-af89-4f0333438c04");
			//第一种方式,需要已经知道的对象
			DrawRegForm form = new DrawRegForm(Common.Util.paramsEntity(draw));
			//WcfClient.AddFileFrm f = new WcfClient.AddFileFrm(entity);
			//第二种方式,不需要传对象
			if (DialogResult.OK == form.ShowDialog())
			{
				draw = form.Document;
				lblDrawCode.Text = draw.DOCNO;
			}
		}

		private void btnDrawFind_Click(object sender, EventArgs e)
		{
			client = Common.Util.Service;
			//PDM_DRAWING draw = client.GetDrawingByID("e896d90d-55e8-4ef6-af89-4f0333438c04");
			DrawListControl f = new DrawListControl(Common.Util.paramsEntity(draw));
			
			//ConnectForm f = new ConnectForm(Common.Util.paramsEntity(draw), CommonUntils.RelationType.Product);
			//WcfClient.ConnectForm f = new WcfClient.ConnectForm("192.168.0.8", "8000");
			f.ShowDialog();
		}

		private void btnPartCreate_Click(object sender, EventArgs e)
		{
			client = Common.Util.Service;
			if (lstPartsType.Text.ToString().Equals("产品"))
			{
				ProductsAddForm form = new ProductsAddForm(Common.Util.paramsEntity(draw));
				form.ShowDialog();
			}
			if (lstPartsType.Text.ToString().Equals("半成品"))
			{
				PartsAddForm form = new PartsAddForm(Common.Util.paramsEntity(draw));
				form.ShowDialog();
			}
			if (lstPartsType.Text.ToString().Equals("材料"))
			{
				MaterailAddForm form = new MaterailAddForm(Common.Util.paramsEntity(draw));
				form.ShowDialog();
			}
		}

		private void btnPartFind_Click(object sender, EventArgs e)
		{
			client = Common.Util.Service;
			ConnectForm f = new ConnectForm(Common.Util.paramsEntity(draw), CommonUntils.RelationType.Product);
			f.ShowDialog();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		/// <summary>
		/// 取消
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public void InitLoad()
		{
			client = Common.Util.Service;
			lstDrawType.DataSource = (object)this.client.GetDrawType().DtResult;
			lstDrawType.SelectedItem = null;

			lstPartsType.Items.Clear();
			string[] partsType = new string[Enum.GetNames(typeof(CommonUntils.RelationType)).Length-1];
			partsType[0] = "产品";
			partsType[1] = "半成品";
			partsType[2] = "材料";
			lstPartsType.Items.AddRange(partsType);
			lstPartsType.SelectedItem = null;
		}

		private void lstDrawType_SelectedValueChanged(object sender, EventArgs e)
		{
			if (lstDrawType.SelectedIndex != -1)
			{
				btnDrawCreate.Enabled = true;
			}
		}

		void EnabledControls()
		{
			btnDrawCreate.Enabled = false;
			btnPartCreate.Enabled = false;
		}

		private void lstPartsType_SelectedValueChanged(object sender, EventArgs e)
		{
			if (lstPartsType.SelectedIndex != -1)
			{
				btnPartCreate.Enabled = true;
			}
		}
	}
}
