using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.DatabaseServices;
using AutoCAD;
using services = Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Windows;
using AutoCadPlugins.Common;
using AutoCadPlugins.Client;
using System.Windows.Forms;
using System.Threading;

[assembly: CommandClass(typeof(Common))]
namespace AutoCadPlugins.Common
{
	public class Common : Autodesk.AutoCAD.Runtime.IExtensionApplication
	{
		public void Initialize()
		{
			AddMenuBar();//添加自定义菜单
		}

		/// <summary>
		/// 卸载方法
		/// </summary>
		public void Terminate()
		{
			throw new NotImplementedException();
		}

		private void AddMenuBar()
		{
			try
			{
				//COM方式获取AutoCAD应用程序对象
				AcadApplication acadApp = (AcadApplication)services.Application.AcadApplication;
				//为AutoCAD添加一个新的菜单
				AcadPopupMenu pm = acadApp.MenuGroups.Item(0).Menus.Add("PDM");
				//声明一个AutoCAD弹出菜单项，用于获取添加的菜单项对象
				AcadPopupMenuItem pmi;
				//在新建的菜单中添加新的菜单
				string[] strMenu = { "登录", "注销", "当前状态", "|", "图纸初始化", "清除初始化信息", "图纸复用", "编辑图纸信息", "编辑主关联零部件", "查看主关联零部件", "|", "图纸检入", "图纸查看", "图纸检出", "取消图纸检出", "|", "明细表填写", "|", "关于" };
				string[] menuCmd = { "login ", "logout ", "status ", "|", "Init ", "clearInit ", "copy ", "editDrawing ", "editParts ", "viewParts ", "|", "drawingIn ", "drawingView ", "drawingOut ", "cancelOut ", "|", "addDrawingInfo ", "|", "about " };
				for (int i = 0; i < strMenu.Length; i++)
				{
					if (!strMenu[i].Equals("|")){
						pmi = pm.AddMenuItem(pm.Count + 1, strMenu[i], menuCmd[i]);
						if (i != 0)
						{
							pmi.Enable = false;
						}
					}
					else
						pm.AddSeparator(pm.Count + 1);
				}
				pm.InsertInMenuBar(acadApp.MenuBar.Count + 1);
			}
			catch (Autodesk.AutoCAD.Runtime.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		/// <summary>
		/// 登录窗体命令
		/// </summary>
		[CommandMethod("login")]
		public static void Login()
		{
			LoginForm f = new LoginForm();
			Autodesk.AutoCAD.ApplicationServices.Application.ShowModelessDialog(null, f, false);
			//f.ShowDialog();
		}

		/// <summary>
		/// 图纸初始化窗体命令
		/// </summary>
		[CommandMethod("Init")]
		public static void Init()
		{
			InitForm f = new InitForm();
			Autodesk.AutoCAD.ApplicationServices.Application.ShowModelessDialog(null, f, false);
			//f.ShowDialog();
			//HYPDM.WinUI.Document.DocRegForm f = new HYPDM.WinUI.Document.DocRegForm();
			//Autodesk.AutoCAD.ApplicationServices.Application.ShowModelessDialog(null, f, false);
		}

		/// <summary>
		/// 清除初始化信息命令
		/// </summary>
		[CommandMethod("clearInit")]
		public static void ClearInit()
		{
		}

		/// <summary>
		/// 清除初始化信息命令
		/// </summary>
		[CommandMethod("logout")]
		public static void LogOut()
		{
		}

		/// <summary>
		/// 清除初始化信息命令
		/// </summary>
		[CommandMethod("drawingIn")]
		public static void DrawingIn()
		{
		}
	}
}
