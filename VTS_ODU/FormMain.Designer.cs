

namespace vts_odu
{
	partial class FormMain
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.SS_STATUS_BAR = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_lonlat = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSL_Scale = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_model = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_user = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_TOOLBAR = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton_ZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_ZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_MoveLeft = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_MoveRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_MoveUp = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_MoveDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_ZoomByRect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_LibMapMan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_DrawEBL = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_AddShip = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_AddRadar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_AddAis = new System.Windows.Forms.ToolStripButton();
            this.StartOrStop = new System.Windows.Forms.ToolStripButton();
            this.panel_MainInfo = new System.Windows.Forms.Panel();
            this.tabControl_ShowInfo = new System.Windows.Forms.TabControl();
            this.tabPage_BaseInfo = new System.Windows.Forms.TabPage();
            this.label_name = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.label_x = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage_SettingInfo = new System.Windows.Forms.TabPage();
            this.label_ship_heigh = new System.Windows.Forms.Label();
            this.label_ship_psl = new System.Windows.Forms.Label();
            this.label_ship_wcs = new System.Windows.Forms.Label();
            this.label_ship_scs = new System.Windows.Forms.Label();
            this.label_ship_typename = new System.Windows.Forms.Label();
            this.label_ship_speed = new System.Windows.Forms.Label();
            this.label_ship_width = new System.Windows.Forms.Label();
            this.label_ship_model = new System.Windows.Forms.Label();
            this.label_ship_length = new System.Windows.Forms.Label();
            this.panel_mapView = new System.Windows.Forms.Panel();
            this.panel_MainMap = new System.Windows.Forms.Panel();
            this.ymEncCtrl = new AxYIMAENCLib.AxYimaEnc();
            this.contextMenuStrip_DataViewList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MapLibManMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.放大ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缩小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.指定比例尺ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.左移ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.右移ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上移ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下移ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中心点旋转ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.历史航迹模拟显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Display_AllInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Display_StandardInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Display_BaseInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DisplayColor_DayBright = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DisplayColor_DayWhiteBack = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DisplayColor_DayBlackBack = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DisplayColor_DayBusk = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DisplayColor_Night = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DisplaySymbol_Trandition = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DisplaySymbol_simple = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Display_SetSafetyDepth = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DisplayLang_ENG = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DisplayLang_CHN = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Display_Text = new System.Windows.Forms.ToolStripMenuItem();
            this.显示经纬度网格ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示历史航迹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.通信设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Tool_GEO_CALC = new System.Windows.Forms.ToolStripMenuItem();
            this.保存屏幕图片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_VIEW_TOOLBAR = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_VIEW_STATUS_BAR = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.全屏显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.轨迹回放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始回放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止回放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.aIS数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SS_STATUS_BAR.SuspendLayout();
            this.TS_TOOLBAR.SuspendLayout();
            this.panel_MainInfo.SuspendLayout();
            this.tabControl_ShowInfo.SuspendLayout();
            this.tabPage_BaseInfo.SuspendLayout();
            this.tabPage_SettingInfo.SuspendLayout();
            this.panel_mapView.SuspendLayout();
            this.panel_MainMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ymEncCtrl)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SS_STATUS_BAR
            // 
            resources.ApplyResources(this.SS_STATUS_BAR, "SS_STATUS_BAR");
            this.SS_STATUS_BAR.BackColor = System.Drawing.SystemColors.Control;
            this.SS_STATUS_BAR.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_lonlat,
            this.TSSL_Scale,
            this.toolStripStatusLabel_model,
            this.toolStripStatusLabel_user});
            this.SS_STATUS_BAR.Name = "SS_STATUS_BAR";
            // 
            // toolStripStatusLabel_lonlat
            // 
            this.toolStripStatusLabel_lonlat.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            resources.ApplyResources(this.toolStripStatusLabel_lonlat, "toolStripStatusLabel_lonlat");
            this.toolStripStatusLabel_lonlat.Name = "toolStripStatusLabel_lonlat";
            this.toolStripStatusLabel_lonlat.Spring = true;
            // 
            // TSSL_Scale
            // 
            this.TSSL_Scale.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.TSSL_Scale.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.TSSL_Scale, "TSSL_Scale");
            this.TSSL_Scale.Name = "TSSL_Scale";
            this.TSSL_Scale.Spring = true;
            // 
            // toolStripStatusLabel_model
            // 
            this.toolStripStatusLabel_model.Name = "toolStripStatusLabel_model";
            resources.ApplyResources(this.toolStripStatusLabel_model, "toolStripStatusLabel_model");
            // 
            // toolStripStatusLabel_user
            // 
            this.toolStripStatusLabel_user.Name = "toolStripStatusLabel_user";
            resources.ApplyResources(this.toolStripStatusLabel_user, "toolStripStatusLabel_user");
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            resources.ApplyResources(this.toolStripSeparator10, "toolStripSeparator10");
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            resources.ApplyResources(this.toolStripSeparator11, "toolStripSeparator11");
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            resources.ApplyResources(this.toolStripSeparator12, "toolStripSeparator12");
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            resources.ApplyResources(this.toolStripSeparator13, "toolStripSeparator13");
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // TS_TOOLBAR
            // 
            resources.ApplyResources(this.TS_TOOLBAR, "TS_TOOLBAR");
            this.TS_TOOLBAR.BackColor = System.Drawing.SystemColors.Control;
            this.TS_TOOLBAR.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton_ZoomIn,
            this.toolStripSeparator8,
            this.toolStripButton_ZoomOut,
            this.toolStripSeparator9,
            this.toolStripButton_MoveLeft,
            this.toolStripSeparator10,
            this.toolStripButton_MoveRight,
            this.toolStripSeparator11,
            this.toolStripButton_MoveUp,
            this.toolStripSeparator12,
            this.toolStripButton_MoveDown,
            this.toolStripSeparator13,
            this.toolStripButton_ZoomByRect,
            this.toolStripSeparator4,
            this.toolStripButton_LibMapMan,
            this.toolStripSeparator7,
            this.toolStripButton_DrawEBL,
            this.toolStripButton_AddShip,
            this.toolStripButton_AddRadar,
            this.toolStripButton_AddAis,
            this.StartOrStop});
            this.TS_TOOLBAR.Name = "TS_TOOLBAR";
            this.TS_TOOLBAR.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Name = "toolStripButton1";
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            // 
            // toolStripButton_ZoomIn
            // 
            resources.ApplyResources(this.toolStripButton_ZoomIn, "toolStripButton_ZoomIn");
            this.toolStripButton_ZoomIn.BackColor = System.Drawing.Color.White;
            this.toolStripButton_ZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_ZoomIn.Image = global::vts_odu.Properties.Resources.zoomIn11;
            this.toolStripButton_ZoomIn.Name = "toolStripButton_ZoomIn";
            this.toolStripButton_ZoomIn.Click += new System.EventHandler(this.放大ToolStripMenuItem_Click);
            this.toolStripButton_ZoomIn.MouseLeave += new System.EventHandler(this.toolStripButton_ZoomIn_MouseLeave);
            this.toolStripButton_ZoomIn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_ZoomIn_MouseMove_1);
            // 
            // toolStripButton_ZoomOut
            // 
            resources.ApplyResources(this.toolStripButton_ZoomOut, "toolStripButton_ZoomOut");
            this.toolStripButton_ZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_ZoomOut.Image = global::vts_odu.Properties.Resources.zoomOut11;
            this.toolStripButton_ZoomOut.Name = "toolStripButton_ZoomOut";
            this.toolStripButton_ZoomOut.Click += new System.EventHandler(this.缩小ToolStripMenuItem_Click);
            this.toolStripButton_ZoomOut.MouseLeave += new System.EventHandler(this.toolStripButton_ZoomOut_MouseLeave);
            this.toolStripButton_ZoomOut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_ZoomOut_MouseMove);
            // 
            // toolStripButton_MoveLeft
            // 
            resources.ApplyResources(this.toolStripButton_MoveLeft, "toolStripButton_MoveLeft");
            this.toolStripButton_MoveLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_MoveLeft.Image = global::vts_odu.Properties.Resources.left11;
            this.toolStripButton_MoveLeft.Name = "toolStripButton_MoveLeft";
            this.toolStripButton_MoveLeft.Click += new System.EventHandler(this.左移ToolStripMenuItem_Click);
            this.toolStripButton_MoveLeft.MouseLeave += new System.EventHandler(this.toolStripButton_MoveLeft_MouseLeave);
            this.toolStripButton_MoveLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MoveLeft_MouseMove);
            // 
            // toolStripButton_MoveRight
            // 
            resources.ApplyResources(this.toolStripButton_MoveRight, "toolStripButton_MoveRight");
            this.toolStripButton_MoveRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_MoveRight.Image = global::vts_odu.Properties.Resources.right11;
            this.toolStripButton_MoveRight.Name = "toolStripButton_MoveRight";
            this.toolStripButton_MoveRight.Click += new System.EventHandler(this.右移ToolStripMenuItem_Click);
            this.toolStripButton_MoveRight.MouseLeave += new System.EventHandler(this.toolStripButton_MoveRight_MouseLeave);
            this.toolStripButton_MoveRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MoveRight_MouseMove);
            // 
            // toolStripButton_MoveUp
            // 
            resources.ApplyResources(this.toolStripButton_MoveUp, "toolStripButton_MoveUp");
            this.toolStripButton_MoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_MoveUp.Image = global::vts_odu.Properties.Resources.up11;
            this.toolStripButton_MoveUp.Name = "toolStripButton_MoveUp";
            this.toolStripButton_MoveUp.Click += new System.EventHandler(this.上移ToolStripMenuItem_Click);
            this.toolStripButton_MoveUp.MouseLeave += new System.EventHandler(this.toolStripButton_MoveUp_MouseLeave);
            this.toolStripButton_MoveUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MoveUp_MouseMove);
            // 
            // toolStripButton_MoveDown
            // 
            resources.ApplyResources(this.toolStripButton_MoveDown, "toolStripButton_MoveDown");
            this.toolStripButton_MoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_MoveDown.Image = global::vts_odu.Properties.Resources.down11;
            this.toolStripButton_MoveDown.Name = "toolStripButton_MoveDown";
            this.toolStripButton_MoveDown.Click += new System.EventHandler(this.下移ToolStripMenuItem_Click);
            this.toolStripButton_MoveDown.MouseLeave += new System.EventHandler(this.toolStripButton_MoveDown_MouseLeave);
            this.toolStripButton_MoveDown.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_MoveDown_MouseMove);
            // 
            // toolStripButton_ZoomByRect
            // 
            resources.ApplyResources(this.toolStripButton_ZoomByRect, "toolStripButton_ZoomByRect");
            this.toolStripButton_ZoomByRect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_ZoomByRect.Image = global::vts_odu.Properties.Resources.dingwei11;
            this.toolStripButton_ZoomByRect.Name = "toolStripButton_ZoomByRect";
            this.toolStripButton_ZoomByRect.Click += new System.EventHandler(this.AreaZoomInButton_Click);
            this.toolStripButton_ZoomByRect.MouseLeave += new System.EventHandler(this.toolStripButton_ZoomByRect_MouseLeave);
            this.toolStripButton_ZoomByRect.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_ZoomByRect_MouseMove);
            // 
            // toolStripButton_LibMapMan
            // 
            resources.ApplyResources(this.toolStripButton_LibMapMan, "toolStripButton_LibMapMan");
            this.toolStripButton_LibMapMan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_LibMapMan.Image = global::vts_odu.Properties.Resources.wenjian11;
            this.toolStripButton_LibMapMan.Name = "toolStripButton_LibMapMan";
            this.toolStripButton_LibMapMan.Click += new System.EventHandler(this.MapLibManMenuItem_Click);
            this.toolStripButton_LibMapMan.MouseLeave += new System.EventHandler(this.toolStripButton_LibMapMan_MouseLeave);
            this.toolStripButton_LibMapMan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_LibMapMan_MouseMove);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // toolStripButton_DrawEBL
            // 
            resources.ApplyResources(this.toolStripButton_DrawEBL, "toolStripButton_DrawEBL");
            this.toolStripButton_DrawEBL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_DrawEBL.Image = global::vts_odu.Properties.Resources.jiasuan11;
            this.toolStripButton_DrawEBL.Name = "toolStripButton_DrawEBL";
            this.toolStripButton_DrawEBL.Click += new System.EventHandler(this.toolStripButton_EBL_Click);
            this.toolStripButton_DrawEBL.MouseLeave += new System.EventHandler(this.toolStripButton_DrawEBL_MouseLeave);
            this.toolStripButton_DrawEBL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_DrawEBL_MouseMove);
            // 
            // toolStripButton_AddShip
            // 
            resources.ApplyResources(this.toolStripButton_AddShip, "toolStripButton_AddShip");
            this.toolStripButton_AddShip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton_AddShip.Name = "toolStripButton_AddShip";
            this.toolStripButton_AddShip.Click += new System.EventHandler(this.toolStripButton_AddShip_Click);
            // 
            // toolStripButton_AddRadar
            // 
            resources.ApplyResources(this.toolStripButton_AddRadar, "toolStripButton_AddRadar");
            this.toolStripButton_AddRadar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton_AddRadar.Name = "toolStripButton_AddRadar";
            this.toolStripButton_AddRadar.Click += new System.EventHandler(this.toolStripButton_AddRadar_Click);
            // 
            // toolStripButton_AddAis
            // 
            resources.ApplyResources(this.toolStripButton_AddAis, "toolStripButton_AddAis");
            this.toolStripButton_AddAis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton_AddAis.Name = "toolStripButton_AddAis";
            this.toolStripButton_AddAis.Click += new System.EventHandler(this.toolStripButton_AddAis_Click);
            // 
            // StartOrStop
            // 
            resources.ApplyResources(this.StartOrStop, "StartOrStop");
            this.StartOrStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.StartOrStop.Name = "StartOrStop";
            this.StartOrStop.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // panel_MainInfo
            // 
            this.panel_MainInfo.Controls.Add(this.tabControl_ShowInfo);
            resources.ApplyResources(this.panel_MainInfo, "panel_MainInfo");
            this.panel_MainInfo.Name = "panel_MainInfo";
            // 
            // tabControl_ShowInfo
            // 
            this.tabControl_ShowInfo.Controls.Add(this.tabPage_BaseInfo);
            this.tabControl_ShowInfo.Controls.Add(this.tabPage_SettingInfo);
            resources.ApplyResources(this.tabControl_ShowInfo, "tabControl_ShowInfo");
            this.tabControl_ShowInfo.Name = "tabControl_ShowInfo";
            this.tabControl_ShowInfo.SelectedIndex = 0;
            // 
            // tabPage_BaseInfo
            // 
            this.tabPage_BaseInfo.Controls.Add(this.label_name);
            this.tabPage_BaseInfo.Controls.Add(this.label_time);
            this.tabPage_BaseInfo.Controls.Add(this.label_y);
            this.tabPage_BaseInfo.Controls.Add(this.label_x);
            this.tabPage_BaseInfo.Controls.Add(this.label6);
            this.tabPage_BaseInfo.Controls.Add(this.label7);
            this.tabPage_BaseInfo.Controls.Add(this.label10);
            this.tabPage_BaseInfo.Controls.Add(this.label11);
            this.tabPage_BaseInfo.Controls.Add(this.label12);
            resources.ApplyResources(this.tabPage_BaseInfo, "tabPage_BaseInfo");
            this.tabPage_BaseInfo.Name = "tabPage_BaseInfo";
            this.tabPage_BaseInfo.UseVisualStyleBackColor = true;
            // 
            // label_name
            // 
            resources.ApplyResources(this.label_name, "label_name");
            this.label_name.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_name.Name = "label_name";
            // 
            // label_time
            // 
            resources.ApplyResources(this.label_time, "label_time");
            this.label_time.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_time.Name = "label_time";
            // 
            // label_y
            // 
            resources.ApplyResources(this.label_y, "label_y");
            this.label_y.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_y.Name = "label_y";
            // 
            // label_x
            // 
            resources.ApplyResources(this.label_x, "label_x");
            this.label_x.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_x.Name = "label_x";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Name = "label7";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Name = "label12";
            // 
            // tabPage_SettingInfo
            // 
            this.tabPage_SettingInfo.Controls.Add(this.label_ship_heigh);
            this.tabPage_SettingInfo.Controls.Add(this.label_ship_psl);
            this.tabPage_SettingInfo.Controls.Add(this.label_ship_wcs);
            this.tabPage_SettingInfo.Controls.Add(this.label_ship_scs);
            this.tabPage_SettingInfo.Controls.Add(this.label_ship_typename);
            this.tabPage_SettingInfo.Controls.Add(this.label_ship_speed);
            this.tabPage_SettingInfo.Controls.Add(this.label_ship_width);
            this.tabPage_SettingInfo.Controls.Add(this.label_ship_model);
            this.tabPage_SettingInfo.Controls.Add(this.label_ship_length);
            resources.ApplyResources(this.tabPage_SettingInfo, "tabPage_SettingInfo");
            this.tabPage_SettingInfo.Name = "tabPage_SettingInfo";
            this.tabPage_SettingInfo.UseVisualStyleBackColor = true;
            // 
            // label_ship_heigh
            // 
            resources.ApplyResources(this.label_ship_heigh, "label_ship_heigh");
            this.label_ship_heigh.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_ship_heigh.Name = "label_ship_heigh";
            // 
            // label_ship_psl
            // 
            resources.ApplyResources(this.label_ship_psl, "label_ship_psl");
            this.label_ship_psl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_ship_psl.Name = "label_ship_psl";
            // 
            // label_ship_wcs
            // 
            resources.ApplyResources(this.label_ship_wcs, "label_ship_wcs");
            this.label_ship_wcs.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_ship_wcs.Name = "label_ship_wcs";
            // 
            // label_ship_scs
            // 
            resources.ApplyResources(this.label_ship_scs, "label_ship_scs");
            this.label_ship_scs.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_ship_scs.Name = "label_ship_scs";
            // 
            // label_ship_typename
            // 
            resources.ApplyResources(this.label_ship_typename, "label_ship_typename");
            this.label_ship_typename.BackColor = System.Drawing.Color.Transparent;
            this.label_ship_typename.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_ship_typename.Name = "label_ship_typename";
            // 
            // label_ship_speed
            // 
            resources.ApplyResources(this.label_ship_speed, "label_ship_speed");
            this.label_ship_speed.BackColor = System.Drawing.Color.Transparent;
            this.label_ship_speed.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_ship_speed.Name = "label_ship_speed";
            // 
            // label_ship_width
            // 
            resources.ApplyResources(this.label_ship_width, "label_ship_width");
            this.label_ship_width.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_ship_width.Name = "label_ship_width";
            // 
            // label_ship_model
            // 
            resources.ApplyResources(this.label_ship_model, "label_ship_model");
            this.label_ship_model.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_ship_model.Name = "label_ship_model";
            // 
            // label_ship_length
            // 
            resources.ApplyResources(this.label_ship_length, "label_ship_length");
            this.label_ship_length.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_ship_length.Name = "label_ship_length";
            // 
            // panel_mapView
            // 
            this.panel_mapView.Controls.Add(this.panel_MainMap);
            this.panel_mapView.Controls.Add(this.panel_MainInfo);
            resources.ApplyResources(this.panel_mapView, "panel_mapView");
            this.panel_mapView.Name = "panel_mapView";
            // 
            // panel_MainMap
            // 
            this.panel_MainMap.Controls.Add(this.ymEncCtrl);
            resources.ApplyResources(this.panel_MainMap, "panel_MainMap");
            this.panel_MainMap.Name = "panel_MainMap";
            // 
            // ymEncCtrl
            // 
            resources.ApplyResources(this.ymEncCtrl, "ymEncCtrl");
            this.ymEncCtrl.Name = "ymEncCtrl";
            this.ymEncCtrl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ymEncCtrl.OcxState")));
            this.ymEncCtrl.AfterDrawMap += new AxYIMAENCLib._DYimaEncEvents_AfterDrawMapEventHandler(this.ymEncCtrl_AfterDrawMap);
            this.ymEncCtrl.OnBeginMouseWheel += new AxYIMAENCLib._DYimaEncEvents_OnBeginMouseWheelEventHandler(this.ymEncCtrl_OnBeginMouseWheel);
            this.ymEncCtrl.OnBeginLButtonDown += new AxYIMAENCLib._DYimaEncEvents_OnBeginLButtonDownEventHandler(this.ymEncCtrl_OnBeginLButtonDown);
            this.ymEncCtrl.OnBeginLButtonUp += new AxYIMAENCLib._DYimaEncEvents_OnBeginLButtonUpEventHandler(this.ymEncCtrl_OnBeginLButtonUp);
            this.ymEncCtrl.OnBeginRButtonDown += new AxYIMAENCLib._DYimaEncEvents_OnBeginRButtonDownEventHandler(this.ymEncCtrl_OnBeginRButtonDown);
            this.ymEncCtrl.OnBeginMouseMove += new AxYIMAENCLib._DYimaEncEvents_OnBeginMouseMoveEventHandler(this.ymEncCtrl_OnBeginMouseMove);
            // 
            // contextMenuStrip_DataViewList
            // 
            resources.ApplyResources(this.contextMenuStrip_DataViewList, "contextMenuStrip_DataViewList");
            this.contextMenuStrip_DataViewList.Name = "contextMenuStrip_DataViewList";
            this.contextMenuStrip_DataViewList.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_DataViewList_ItemClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.查看ToolStripMenuItem,
            this.显示选项ToolStripMenuItem,
            this.系统设置ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.轨迹回放ToolStripMenuItem,
            this.aIS数据ToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.BackColor = System.Drawing.SystemColors.Control;
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MapLibManMenu,
            this.退出ToolStripMenuItem});
            resources.ApplyResources(this.FileMenu, "FileMenu");
            this.FileMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FileMenu.Name = "FileMenu";
            // 
            // MapLibManMenu
            // 
            this.MapLibManMenu.BackColor = System.Drawing.SystemColors.Control;
            this.MapLibManMenu.BackgroundImage = global::vts_odu.Properties.Resources.wenjian1;
            resources.ApplyResources(this.MapLibManMenu, "MapLibManMenu");
            this.MapLibManMenu.Name = "MapLibManMenu";
            this.MapLibManMenu.Click += new System.EventHandler(this.MapLibManMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.退出ToolStripMenuItem.BackgroundImage = global::vts_odu.Properties.Resources.close1;
            resources.ApplyResources(this.退出ToolStripMenuItem, "退出ToolStripMenuItem");
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.放大ToolStripMenuItem,
            this.缩小ToolStripMenuItem,
            this.指定比例尺ToolStripMenuItem,
            this.左移ToolStripMenuItem,
            this.右移ToolStripMenuItem,
            this.上移ToolStripMenuItem,
            this.下移ToolStripMenuItem,
            this.中心点旋转ToolStripMenuItem,
            this.历史航迹模拟显示ToolStripMenuItem});
            resources.ApplyResources(this.查看ToolStripMenuItem, "查看ToolStripMenuItem");
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            // 
            // 放大ToolStripMenuItem
            // 
            this.放大ToolStripMenuItem.BackgroundImage = global::vts_odu.Properties.Resources.zoomIn1;
            resources.ApplyResources(this.放大ToolStripMenuItem, "放大ToolStripMenuItem");
            this.放大ToolStripMenuItem.Name = "放大ToolStripMenuItem";
            this.放大ToolStripMenuItem.Tag = "";
            this.放大ToolStripMenuItem.Click += new System.EventHandler(this.放大ToolStripMenuItem_Click);
            // 
            // 缩小ToolStripMenuItem
            // 
            this.缩小ToolStripMenuItem.BackgroundImage = global::vts_odu.Properties.Resources.zoomOut1;
            resources.ApplyResources(this.缩小ToolStripMenuItem, "缩小ToolStripMenuItem");
            this.缩小ToolStripMenuItem.Name = "缩小ToolStripMenuItem";
            this.缩小ToolStripMenuItem.Click += new System.EventHandler(this.缩小ToolStripMenuItem_Click);
            // 
            // 指定比例尺ToolStripMenuItem
            // 
            this.指定比例尺ToolStripMenuItem.Name = "指定比例尺ToolStripMenuItem";
            resources.ApplyResources(this.指定比例尺ToolStripMenuItem, "指定比例尺ToolStripMenuItem");
            this.指定比例尺ToolStripMenuItem.Click += new System.EventHandler(this.指定比例尺ToolStripMenuItem_Click);
            // 
            // 左移ToolStripMenuItem
            // 
            this.左移ToolStripMenuItem.BackgroundImage = global::vts_odu.Properties.Resources.left1;
            resources.ApplyResources(this.左移ToolStripMenuItem, "左移ToolStripMenuItem");
            this.左移ToolStripMenuItem.Name = "左移ToolStripMenuItem";
            this.左移ToolStripMenuItem.Click += new System.EventHandler(this.左移ToolStripMenuItem_Click);
            // 
            // 右移ToolStripMenuItem
            // 
            this.右移ToolStripMenuItem.BackgroundImage = global::vts_odu.Properties.Resources.right1;
            resources.ApplyResources(this.右移ToolStripMenuItem, "右移ToolStripMenuItem");
            this.右移ToolStripMenuItem.Name = "右移ToolStripMenuItem";
            this.右移ToolStripMenuItem.Click += new System.EventHandler(this.右移ToolStripMenuItem_Click);
            // 
            // 上移ToolStripMenuItem
            // 
            this.上移ToolStripMenuItem.BackgroundImage = global::vts_odu.Properties.Resources.up1;
            resources.ApplyResources(this.上移ToolStripMenuItem, "上移ToolStripMenuItem");
            this.上移ToolStripMenuItem.Name = "上移ToolStripMenuItem";
            this.上移ToolStripMenuItem.Click += new System.EventHandler(this.上移ToolStripMenuItem_Click);
            // 
            // 下移ToolStripMenuItem
            // 
            this.下移ToolStripMenuItem.BackgroundImage = global::vts_odu.Properties.Resources.down1;
            resources.ApplyResources(this.下移ToolStripMenuItem, "下移ToolStripMenuItem");
            this.下移ToolStripMenuItem.Name = "下移ToolStripMenuItem";
            this.下移ToolStripMenuItem.Click += new System.EventHandler(this.下移ToolStripMenuItem_Click);
            // 
            // 中心点旋转ToolStripMenuItem
            // 
            this.中心点旋转ToolStripMenuItem.Name = "中心点旋转ToolStripMenuItem";
            resources.ApplyResources(this.中心点旋转ToolStripMenuItem, "中心点旋转ToolStripMenuItem");
            this.中心点旋转ToolStripMenuItem.Click += new System.EventHandler(this.中心点旋转ToolStripMenuItem_Click);
            // 
            // 历史航迹模拟显示ToolStripMenuItem
            // 
            this.历史航迹模拟显示ToolStripMenuItem.Name = "历史航迹模拟显示ToolStripMenuItem";
            resources.ApplyResources(this.历史航迹模拟显示ToolStripMenuItem, "历史航迹模拟显示ToolStripMenuItem");
            this.历史航迹模拟显示ToolStripMenuItem.Click += new System.EventHandler(this.历史航迹模拟显示ToolStripMenuItem_Click);
            // 
            // 显示选项ToolStripMenuItem
            // 
            this.显示选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Display_AllInfo,
            this.TSMI_Display_StandardInfo,
            this.TSMI_Display_BaseInfo,
            this.TSMI_DisplayColor_DayBright,
            this.TSMI_DisplayColor_DayWhiteBack,
            this.TSMI_DisplayColor_DayBlackBack,
            this.TSMI_DisplayColor_DayBusk,
            this.TSMI_DisplayColor_Night,
            this.TSMI_DisplaySymbol_Trandition,
            this.TSMI_DisplaySymbol_simple,
            this.TSMI_Display_SetSafetyDepth,
            this.TSMI_DisplayLang_ENG,
            this.TSMI_DisplayLang_CHN,
            this.TSMI_Display_Text,
            this.显示经纬度网格ToolStripMenuItem,
            this.显示历史航迹ToolStripMenuItem});
            resources.ApplyResources(this.显示选项ToolStripMenuItem, "显示选项ToolStripMenuItem");
            this.显示选项ToolStripMenuItem.Name = "显示选项ToolStripMenuItem";
            // 
            // TSMI_Display_AllInfo
            // 
            this.TSMI_Display_AllInfo.Name = "TSMI_Display_AllInfo";
            resources.ApplyResources(this.TSMI_Display_AllInfo, "TSMI_Display_AllInfo");
            this.TSMI_Display_AllInfo.Click += new System.EventHandler(this.TSMI_Display_AllInfo_Click);
            // 
            // TSMI_Display_StandardInfo
            // 
            this.TSMI_Display_StandardInfo.Checked = true;
            this.TSMI_Display_StandardInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMI_Display_StandardInfo.Name = "TSMI_Display_StandardInfo";
            resources.ApplyResources(this.TSMI_Display_StandardInfo, "TSMI_Display_StandardInfo");
            this.TSMI_Display_StandardInfo.Click += new System.EventHandler(this.TSMI_Display_StandardInfo_Click);
            // 
            // TSMI_Display_BaseInfo
            // 
            this.TSMI_Display_BaseInfo.Name = "TSMI_Display_BaseInfo";
            resources.ApplyResources(this.TSMI_Display_BaseInfo, "TSMI_Display_BaseInfo");
            this.TSMI_Display_BaseInfo.Click += new System.EventHandler(this.TSMI_Display_BaseInfo_Click);
            // 
            // TSMI_DisplayColor_DayBright
            // 
            this.TSMI_DisplayColor_DayBright.Checked = true;
            this.TSMI_DisplayColor_DayBright.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMI_DisplayColor_DayBright.Name = "TSMI_DisplayColor_DayBright";
            resources.ApplyResources(this.TSMI_DisplayColor_DayBright, "TSMI_DisplayColor_DayBright");
            this.TSMI_DisplayColor_DayBright.Click += new System.EventHandler(this.TSMI_DisplayColor_DayBright_Click);
            // 
            // TSMI_DisplayColor_DayWhiteBack
            // 
            this.TSMI_DisplayColor_DayWhiteBack.Name = "TSMI_DisplayColor_DayWhiteBack";
            resources.ApplyResources(this.TSMI_DisplayColor_DayWhiteBack, "TSMI_DisplayColor_DayWhiteBack");
            this.TSMI_DisplayColor_DayWhiteBack.Click += new System.EventHandler(this.TSMI_DisplayColor_DayWhiteBack_Click);
            // 
            // TSMI_DisplayColor_DayBlackBack
            // 
            this.TSMI_DisplayColor_DayBlackBack.Name = "TSMI_DisplayColor_DayBlackBack";
            resources.ApplyResources(this.TSMI_DisplayColor_DayBlackBack, "TSMI_DisplayColor_DayBlackBack");
            this.TSMI_DisplayColor_DayBlackBack.Click += new System.EventHandler(this.TSMI_DisplayColor_DayBlackBack_Click);
            // 
            // TSMI_DisplayColor_DayBusk
            // 
            this.TSMI_DisplayColor_DayBusk.Name = "TSMI_DisplayColor_DayBusk";
            resources.ApplyResources(this.TSMI_DisplayColor_DayBusk, "TSMI_DisplayColor_DayBusk");
            this.TSMI_DisplayColor_DayBusk.Click += new System.EventHandler(this.TSMI_DisplayColor_DayBusk_Click);
            // 
            // TSMI_DisplayColor_Night
            // 
            this.TSMI_DisplayColor_Night.Name = "TSMI_DisplayColor_Night";
            resources.ApplyResources(this.TSMI_DisplayColor_Night, "TSMI_DisplayColor_Night");
            this.TSMI_DisplayColor_Night.Click += new System.EventHandler(this.TSMI_DisplayColor_Night_Click);
            // 
            // TSMI_DisplaySymbol_Trandition
            // 
            this.TSMI_DisplaySymbol_Trandition.Name = "TSMI_DisplaySymbol_Trandition";
            resources.ApplyResources(this.TSMI_DisplaySymbol_Trandition, "TSMI_DisplaySymbol_Trandition");
            this.TSMI_DisplaySymbol_Trandition.Click += new System.EventHandler(this.TSMI_DisplaySymbol_Trandition_Click);
            // 
            // TSMI_DisplaySymbol_simple
            // 
            this.TSMI_DisplaySymbol_simple.Checked = true;
            this.TSMI_DisplaySymbol_simple.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMI_DisplaySymbol_simple.Name = "TSMI_DisplaySymbol_simple";
            resources.ApplyResources(this.TSMI_DisplaySymbol_simple, "TSMI_DisplaySymbol_simple");
            this.TSMI_DisplaySymbol_simple.Click += new System.EventHandler(this.TSMI_DisplaySymbol_simple_Click);
            // 
            // TSMI_Display_SetSafetyDepth
            // 
            this.TSMI_Display_SetSafetyDepth.Name = "TSMI_Display_SetSafetyDepth";
            resources.ApplyResources(this.TSMI_Display_SetSafetyDepth, "TSMI_Display_SetSafetyDepth");
            this.TSMI_Display_SetSafetyDepth.Click += new System.EventHandler(this.TSMI_Display_SetSafetyDepth_Click);
            // 
            // TSMI_DisplayLang_ENG
            // 
            resources.ApplyResources(this.TSMI_DisplayLang_ENG, "TSMI_DisplayLang_ENG");
            this.TSMI_DisplayLang_ENG.Name = "TSMI_DisplayLang_ENG";
            this.TSMI_DisplayLang_ENG.Click += new System.EventHandler(this.TSMI_DisplayLang_ENG_Click);
            // 
            // TSMI_DisplayLang_CHN
            // 
            this.TSMI_DisplayLang_CHN.Checked = true;
            this.TSMI_DisplayLang_CHN.CheckState = System.Windows.Forms.CheckState.Checked;
            resources.ApplyResources(this.TSMI_DisplayLang_CHN, "TSMI_DisplayLang_CHN");
            this.TSMI_DisplayLang_CHN.Name = "TSMI_DisplayLang_CHN";
            this.TSMI_DisplayLang_CHN.Click += new System.EventHandler(this.TSMI_DisplayLang_CHN_Click);
            // 
            // TSMI_Display_Text
            // 
            this.TSMI_Display_Text.Checked = true;
            this.TSMI_Display_Text.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMI_Display_Text.Name = "TSMI_Display_Text";
            resources.ApplyResources(this.TSMI_Display_Text, "TSMI_Display_Text");
            this.TSMI_Display_Text.Click += new System.EventHandler(this.TSMI_Display_Text_Click);
            // 
            // 显示经纬度网格ToolStripMenuItem
            // 
            this.显示经纬度网格ToolStripMenuItem.Checked = true;
            this.显示经纬度网格ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.显示经纬度网格ToolStripMenuItem.Name = "显示经纬度网格ToolStripMenuItem";
            resources.ApplyResources(this.显示经纬度网格ToolStripMenuItem, "显示经纬度网格ToolStripMenuItem");
            this.显示经纬度网格ToolStripMenuItem.Click += new System.EventHandler(this.显示经纬度网格ToolStripMenuItem_Click);
            // 
            // 显示历史航迹ToolStripMenuItem
            // 
            this.显示历史航迹ToolStripMenuItem.Name = "显示历史航迹ToolStripMenuItem";
            resources.ApplyResources(this.显示历史航迹ToolStripMenuItem, "显示历史航迹ToolStripMenuItem");
            this.显示历史航迹ToolStripMenuItem.Click += new System.EventHandler(this.显示历史航迹ToolStripMenuItem_Click);
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.通信设置ToolStripMenuItem});
            resources.ApplyResources(this.系统设置ToolStripMenuItem, "系统设置ToolStripMenuItem");
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            // 
            // 通信设置ToolStripMenuItem
            // 
            this.通信设置ToolStripMenuItem.Name = "通信设置ToolStripMenuItem";
            resources.ApplyResources(this.通信设置ToolStripMenuItem, "通信设置ToolStripMenuItem");
            this.通信设置ToolStripMenuItem.Click += new System.EventHandler(this.主通信设置ToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Tool_GEO_CALC,
            this.保存屏幕图片ToolStripMenuItem});
            resources.ApplyResources(this.工具ToolStripMenuItem, "工具ToolStripMenuItem");
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            // 
            // TSMI_Tool_GEO_CALC
            // 
            this.TSMI_Tool_GEO_CALC.BackgroundImage = global::vts_odu.Properties.Resources.jiasuan1;
            resources.ApplyResources(this.TSMI_Tool_GEO_CALC, "TSMI_Tool_GEO_CALC");
            this.TSMI_Tool_GEO_CALC.Name = "TSMI_Tool_GEO_CALC";
            this.TSMI_Tool_GEO_CALC.Click += new System.EventHandler(this.TSMI_Tool_GEO_CALC_Click);
            // 
            // 保存屏幕图片ToolStripMenuItem
            // 
            this.保存屏幕图片ToolStripMenuItem.Name = "保存屏幕图片ToolStripMenuItem";
            resources.ApplyResources(this.保存屏幕图片ToolStripMenuItem, "保存屏幕图片ToolStripMenuItem");
            this.保存屏幕图片ToolStripMenuItem.Click += new System.EventHandler(this.保存屏幕图片ToolStripMenuItem_Click);
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_VIEW_TOOLBAR,
            this.TSMI_VIEW_STATUS_BAR,
            this.TSMI_Info,
            this.全屏显示ToolStripMenuItem});
            resources.ApplyResources(this.视图ToolStripMenuItem, "视图ToolStripMenuItem");
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            // 
            // TSMI_VIEW_TOOLBAR
            // 
            this.TSMI_VIEW_TOOLBAR.Checked = true;
            this.TSMI_VIEW_TOOLBAR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMI_VIEW_TOOLBAR.Name = "TSMI_VIEW_TOOLBAR";
            resources.ApplyResources(this.TSMI_VIEW_TOOLBAR, "TSMI_VIEW_TOOLBAR");
            this.TSMI_VIEW_TOOLBAR.Click += new System.EventHandler(this.TSMI_VIEW_TOOLBAR_Click);
            // 
            // TSMI_VIEW_STATUS_BAR
            // 
            this.TSMI_VIEW_STATUS_BAR.Checked = true;
            this.TSMI_VIEW_STATUS_BAR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMI_VIEW_STATUS_BAR.Name = "TSMI_VIEW_STATUS_BAR";
            resources.ApplyResources(this.TSMI_VIEW_STATUS_BAR, "TSMI_VIEW_STATUS_BAR");
            this.TSMI_VIEW_STATUS_BAR.Click += new System.EventHandler(this.TSMI_VIEW_STATUS_BAR_Click);
            // 
            // TSMI_Info
            // 
            this.TSMI_Info.Checked = true;
            this.TSMI_Info.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMI_Info.Name = "TSMI_Info";
            resources.ApplyResources(this.TSMI_Info, "TSMI_Info");
            this.TSMI_Info.Click += new System.EventHandler(this.TSMI_Info_Click);
            // 
            // 全屏显示ToolStripMenuItem
            // 
            this.全屏显示ToolStripMenuItem.Name = "全屏显示ToolStripMenuItem";
            resources.ApplyResources(this.全屏显示ToolStripMenuItem, "全屏显示ToolStripMenuItem");
            this.全屏显示ToolStripMenuItem.Click += new System.EventHandler(this.全屏显示ToolStripMenuItem_Click);
            // 
            // 轨迹回放ToolStripMenuItem
            // 
            this.轨迹回放ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始回放ToolStripMenuItem,
            this.停止回放ToolStripMenuItem});
            resources.ApplyResources(this.轨迹回放ToolStripMenuItem, "轨迹回放ToolStripMenuItem");
            this.轨迹回放ToolStripMenuItem.Name = "轨迹回放ToolStripMenuItem";
            // 
            // 开始回放ToolStripMenuItem
            // 
            this.开始回放ToolStripMenuItem.Name = "开始回放ToolStripMenuItem";
            resources.ApplyResources(this.开始回放ToolStripMenuItem, "开始回放ToolStripMenuItem");
            this.开始回放ToolStripMenuItem.Click += new System.EventHandler(this.开始回放ToolStripMenuItem_Click);
            // 
            // 停止回放ToolStripMenuItem
            // 
            this.停止回放ToolStripMenuItem.Name = "停止回放ToolStripMenuItem";
            resources.ApplyResources(this.停止回放ToolStripMenuItem, "停止回放ToolStripMenuItem");
            this.停止回放ToolStripMenuItem.Click += new System.EventHandler(this.停止回放ToolStripMenuItem_Click);
            // 
            // aIS数据ToolStripMenuItem
            // 
            resources.ApplyResources(this.aIS数据ToolStripMenuItem, "aIS数据ToolStripMenuItem");
            this.aIS数据ToolStripMenuItem.Name = "aIS数据ToolStripMenuItem";
            this.aIS数据ToolStripMenuItem.Click += new System.EventHandler(this.aIS数据ToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel_mapView);
            this.Controls.Add(this.TS_TOOLBAR);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.SS_STATUS_BAR);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.SS_STATUS_BAR.ResumeLayout(false);
            this.SS_STATUS_BAR.PerformLayout();
            this.TS_TOOLBAR.ResumeLayout(false);
            this.TS_TOOLBAR.PerformLayout();
            this.panel_MainInfo.ResumeLayout(false);
            this.tabControl_ShowInfo.ResumeLayout(false);
            this.tabPage_BaseInfo.ResumeLayout(false);
            this.tabPage_BaseInfo.PerformLayout();
            this.tabPage_SettingInfo.ResumeLayout(false);
            this.tabPage_SettingInfo.PerformLayout();
            this.panel_mapView.ResumeLayout(false);
            this.panel_MainMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ymEncCtrl)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private void LanguageSwitch()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.TS_TOOLBAR.SuspendLayout();
			this.SS_STATUS_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ymEncCtrl)).BeginInit();
			this.panel_MainInfo.SuspendLayout();
			//this.groupBox1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TS_TOOLBAR
			// 

			resources.ApplyResources(this.TS_TOOLBAR, "TS_TOOLBAR");
			this.TS_TOOLBAR.Name = "TS_TOOLBAR";

			// 
			// toolStripButton1
			// 

			resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
			this.toolStripButton1.Name = "toolStripButton1";

			// ZoomInTBtn
			// 

			resources.ApplyResources(this.toolStripButton_ZoomIn, "ZoomInTBtn");
			this.toolStripButton_ZoomIn.Name = "ZoomInTBtn";

			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");

			this.toolStripButton_ZoomIn.Name = "toolStripButton2";
			resources.ApplyResources(this.toolStripButton_ZoomIn, "toolStripButton2");
			// 
			// timer1
			// 

			// 
			// SS_STATUS_BAR
			// 

			resources.ApplyResources(this.SS_STATUS_BAR, "SS_STATUS_BAR");
			this.SS_STATUS_BAR.Name = "SS_STATUS_BAR";
			// 
			// TSSL_Scale
			// 
			resources.ApplyResources(this.TSSL_Scale, "TSSL_Scale");
			this.TSSL_Scale.Name = "TSSL_Scale";

			// 
			resources.ApplyResources(this.ymEncCtrl, "ymEncCtrl");
			this.ymEncCtrl.Name = "ymEncCtrl";
			// 
			// FileMenu
			// 
			this.FileMenu.Name = "FileMenu";
			resources.ApplyResources(this.FileMenu, "FileMenu");
			// 
			// MapLibManMenu
			// 
			this.MapLibManMenu.Name = "MapLibManMenu";
			resources.ApplyResources(this.MapLibManMenu, "MapLibManMenu");
			// 
			// 退出ToolStripMenuItem
			// 
			this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
			resources.ApplyResources(this.退出ToolStripMenuItem, "退出ToolStripMenuItem");
			// 
			// 查看ToolStripMenuItem
			// 
			this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
			resources.ApplyResources(this.查看ToolStripMenuItem, "查看ToolStripMenuItem");
			// 
			// 放大ToolStripMenuItem
			// 
			this.放大ToolStripMenuItem.Name = "放大ToolStripMenuItem";
			resources.ApplyResources(this.放大ToolStripMenuItem, "放大ToolStripMenuItem");
			// 
			// 缩小ToolStripMenuItem
			// 
			this.缩小ToolStripMenuItem.Name = "缩小ToolStripMenuItem";
			resources.ApplyResources(this.缩小ToolStripMenuItem, "缩小ToolStripMenuItem");
			// 
			// 指定比例尺ToolStripMenuItem
			// 
			this.指定比例尺ToolStripMenuItem.Name = "指定比例尺ToolStripMenuItem";
			resources.ApplyResources(this.指定比例尺ToolStripMenuItem, "指定比例尺ToolStripMenuItem");
			// 
			// 左移ToolStripMenuItem
			// 
			this.左移ToolStripMenuItem.Name = "左移ToolStripMenuItem";
			resources.ApplyResources(this.左移ToolStripMenuItem, "左移ToolStripMenuItem");
			// 
			// 右移ToolStripMenuItem
			// 
			this.右移ToolStripMenuItem.Name = "右移ToolStripMenuItem";
			resources.ApplyResources(this.右移ToolStripMenuItem, "右移ToolStripMenuItem");
			// 
			// 上移ToolStripMenuItem
			// 
			this.上移ToolStripMenuItem.Name = "上移ToolStripMenuItem";
			resources.ApplyResources(this.上移ToolStripMenuItem, "上移ToolStripMenuItem");
			// 
			// 下移ToolStripMenuItem
			// 
			this.下移ToolStripMenuItem.Name = "下移ToolStripMenuItem";
			resources.ApplyResources(this.下移ToolStripMenuItem, "下移ToolStripMenuItem");
			// 
			// 中心点旋转ToolStripMenuItem
			// 
			this.中心点旋转ToolStripMenuItem.Name = "中心点旋转ToolStripMenuItem";
			resources.ApplyResources(this.中心点旋转ToolStripMenuItem, "中心点旋转ToolStripMenuItem");
			// 
			// 显示选项ToolStripMenuItem
			// 
			this.显示选项ToolStripMenuItem.Name = "显示选项ToolStripMenuItem";
			resources.ApplyResources(this.显示选项ToolStripMenuItem, "显示选项ToolStripMenuItem");
			// 
			// TSMI_Display_AllInfo
			// 
			this.TSMI_Display_AllInfo.Name = "TSMI_Display_AllInfo";
			resources.ApplyResources(this.TSMI_Display_AllInfo, "TSMI_Display_AllInfo");
			// 
			// TSMI_Display_StandardInfo
			// 
			this.TSMI_Display_StandardInfo.Name = "TSMI_Display_StandardInfo";
			resources.ApplyResources(this.TSMI_Display_StandardInfo, "TSMI_Display_StandardInfo");
			// 
			// TSMI_Display_BaseInfo
			// 
			this.TSMI_Display_BaseInfo.Name = "TSMI_Display_BaseInfo";
			resources.ApplyResources(this.TSMI_Display_BaseInfo, "TSMI_Display_BaseInfo");
			// 
			// TSMI_DisplayColor_DayBright
			// 
			resources.ApplyResources(this.TSMI_DisplayColor_DayBright, "TSMI_DisplayColor_DayBright");
			this.TSMI_DisplayColor_DayBright.Click += new System.EventHandler(this.TSMI_DisplayColor_DayBright_Click);
			// 
			// TSMI_DisplayColor_DayWhiteBack
			// 
			this.TSMI_DisplayColor_DayWhiteBack.Name = "TSMI_DisplayColor_DayWhiteBack";
			resources.ApplyResources(this.TSMI_DisplayColor_DayWhiteBack, "TSMI_DisplayColor_DayWhiteBack");
			// 
			// TSMI_DisplayColor_DayBlackBack
			// 
			this.TSMI_DisplayColor_DayBlackBack.Name = "TSMI_DisplayColor_DayBlackBack";
			resources.ApplyResources(this.TSMI_DisplayColor_DayBlackBack, "TSMI_DisplayColor_DayBlackBack");
			// 
			// TSMI_DisplayColor_DayBusk
			// 
			this.TSMI_DisplayColor_DayBusk.Name = "TSMI_DisplayColor_DayBusk";
			resources.ApplyResources(this.TSMI_DisplayColor_DayBusk, "TSMI_DisplayColor_DayBusk");
			// 
			// TSMI_DisplayColor_Night
			// 
			this.TSMI_DisplayColor_Night.Name = "TSMI_DisplayColor_Night";
			resources.ApplyResources(this.TSMI_DisplayColor_Night, "TSMI_DisplayColor_Night");
			// 
			// TSMI_DisplaySymbol_Trandition
			// 
			this.TSMI_DisplaySymbol_Trandition.Name = "TSMI_DisplaySymbol_Trandition";
			resources.ApplyResources(this.TSMI_DisplaySymbol_Trandition, "TSMI_DisplaySymbol_Trandition");
			// 
			// TSMI_DisplaySymbol_simple
			// 
			this.TSMI_DisplaySymbol_simple.Name = "TSMI_DisplaySymbol_simple";
			resources.ApplyResources(this.TSMI_DisplaySymbol_simple, "TSMI_DisplaySymbol_simple");
			// 
			// TSMI_Display_SetSafetyDepth
			// 
			this.TSMI_Display_SetSafetyDepth.Name = "TSMI_Display_SetSafetyDepth";
			resources.ApplyResources(this.TSMI_Display_SetSafetyDepth, "TSMI_Display_SetSafetyDepth");
			// 
			// TSMI_DisplayLang_ENG
			// 
			this.TSMI_DisplayLang_ENG.Name = "TSMI_DisplayLang_ENG";
			resources.ApplyResources(this.TSMI_DisplayLang_ENG, "TSMI_DisplayLang_ENG");
			// 
			// TSMI_DisplayLang_CHN
			// 
			this.TSMI_DisplayLang_CHN.Name = "TSMI_DisplayLang_CHN";
			resources.ApplyResources(this.TSMI_DisplayLang_CHN, "TSMI_DisplayLang_CHN");
			// 
			// TSMI_Display_Text
			// 
			this.TSMI_Display_Text.Name = "TSMI_Display_Text";
			resources.ApplyResources(this.TSMI_Display_Text, "TSMI_Display_Text");
			// 
			// 显示经纬度网格ToolStripMenuItem
			// 
			this.显示经纬度网格ToolStripMenuItem.Name = "显示经纬度网格ToolStripMenuItem";
			resources.ApplyResources(this.显示经纬度网格ToolStripMenuItem, "显示经纬度网格ToolStripMenuItem");
			// 
			// 显示历史航迹ToolStripMenuItem
			// 
			this.显示历史航迹ToolStripMenuItem.Name = "显示历史航迹ToolStripMenuItem";
			resources.ApplyResources(this.显示历史航迹ToolStripMenuItem, "显示历史航迹ToolStripMenuItem");
			// 
			// 工具ToolStripMenuItem
			// 
			this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
			resources.ApplyResources(this.工具ToolStripMenuItem, "工具ToolStripMenuItem");
			// 
			// TSMI_Tool_GEO_CALC
			// 
			this.TSMI_Tool_GEO_CALC.Name = "TSMI_Tool_GEO_CALC";
			resources.ApplyResources(this.TSMI_Tool_GEO_CALC, "TSMI_Tool_GEO_CALC");
			// 
			// 视图ToolStripMenuItem
			// 
			this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
			resources.ApplyResources(this.视图ToolStripMenuItem, "视图ToolStripMenuItem");
			// 
			// TSMI_VIEW_TOOLBAR
			// 
			this.TSMI_VIEW_TOOLBAR.Name = "TSMI_VIEW_TOOLBAR";
			resources.ApplyResources(this.TSMI_VIEW_TOOLBAR, "TSMI_VIEW_TOOLBAR");
			// 
			// TSMI_VIEW_STATUS_BAR
			// 
			this.TSMI_VIEW_STATUS_BAR.Name = "TSMI_VIEW_STATUS_BAR";
			resources.ApplyResources(this.TSMI_VIEW_STATUS_BAR, "TSMI_VIEW_STATUS_BAR");
			// 
			// TSMI_Info
			// 
			this.TSMI_Info.Name = "TSMI_Info";
			resources.ApplyResources(this.TSMI_Info, "TSMI_Info");
			// 
			// menuStrip1
			// 
			resources.ApplyResources(this.menuStrip1, "menuStrip1");
			this.menuStrip1.Name = "menuStrip1";
		}
		#endregion
		private System.Windows.Forms.StatusStrip SS_STATUS_BAR;
        private System.Windows.Forms.ToolStripButton toolStripButton_ZoomIn;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripButton toolStripButton_ZoomOut;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripButton toolStripButton_MoveLeft;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
		private System.Windows.Forms.ToolStripButton toolStripButton_MoveRight;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
		private System.Windows.Forms.ToolStripButton toolStripButton_MoveUp;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
		private System.Windows.Forms.ToolStripButton toolStripButton_MoveDown;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
		private System.Windows.Forms.ToolStripButton toolStripButton_ZoomByRect;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton toolStripButton_LibMapMan;
		private System.Windows.Forms.ToolStrip TS_TOOLBAR;
		private System.Windows.Forms.Panel panel_MainInfo;
		private System.Windows.Forms.TabControl tabControl_ShowInfo;
		private System.Windows.Forms.TabPage tabPage_BaseInfo;
		private System.Windows.Forms.TabPage tabPage_SettingInfo;
		private System.Windows.Forms.Panel panel_mapView;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_lonlat;
		public System.Windows.Forms.Panel panel_MainMap;
		public AxYIMAENCLib.AxYimaEnc ymEncCtrl; //注意要声明成静态以供其他的类来调用之
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_DataViewList;
		private System.Windows.Forms.ToolStripStatusLabel TSSL_Scale;
		private System.Windows.Forms.ToolStripLabel toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton_AddShip;
		private System.Windows.Forms.ToolStripButton toolStripButton_AddRadar;
		private System.Windows.Forms.ToolStripButton toolStripButton_AddAis;
		private System.Windows.Forms.ToolStripButton toolStripButton_DrawEBL;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_user;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_model;
        private System.Windows.Forms.ToolStripButton StartOrStop;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem MapLibManMenu;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 放大ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 缩小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 指定比例尺ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 左移ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 右移ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上移ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下移ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中心点旋转ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 历史航迹模拟显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Display_AllInfo;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Display_StandardInfo;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Display_BaseInfo;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DisplayColor_DayBright;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DisplayColor_DayWhiteBack;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DisplayColor_DayBlackBack;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DisplayColor_DayBusk;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DisplayColor_Night;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DisplaySymbol_Trandition;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DisplaySymbol_simple;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Display_SetSafetyDepth;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DisplayLang_ENG;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DisplayLang_CHN;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Display_Text;
        private System.Windows.Forms.ToolStripMenuItem 显示经纬度网格ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示历史航迹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Tool_GEO_CALC;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_VIEW_TOOLBAR;
        private System.Windows.Forms.ToolStripMenuItem TSMI_VIEW_STATUS_BAR;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Info;
        private System.Windows.Forms.ToolStripMenuItem 全屏显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 通信设置ToolStripMenuItem;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_ship_heigh;
        private System.Windows.Forms.Label label_ship_psl;
        private System.Windows.Forms.Label label_ship_wcs;
        private System.Windows.Forms.Label label_ship_scs;
        private System.Windows.Forms.Label label_ship_typename;
        private System.Windows.Forms.Label label_ship_speed;
        private System.Windows.Forms.Label label_ship_width;
        private System.Windows.Forms.Label label_ship_model;
        private System.Windows.Forms.Label label_ship_length;
        private System.Windows.Forms.ToolStripMenuItem 轨迹回放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存屏幕图片ToolStripMenuItem;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.ToolStripMenuItem 开始回放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止回放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aIS数据ToolStripMenuItem;
    }
}

