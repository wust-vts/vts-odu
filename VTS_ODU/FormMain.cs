using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
using BasicLibrary;
using System.Net.Sockets;
using System.Net;
using System.Security.Principal;
using MySql.Data.MySqlClient;

namespace vts_odu
{        
    /// <summary>
    /// 记录窗口可操作的状态
    /// </summary>
    public enum CURRENT_SUB_OPERATION:uint
    {
        NO_OPERATION = 0,
        ADD_ISO_POINT = 1,
        ADD_LINE = 0x2,
        ADD_STRING = 0x8,
        ADD_FACE = 0x4,
        AREA_ZOOM_IN = 0x10,
        ADD_WAYPOINT = 0x20,
        ADD_ROUTE = 0x40,
        EDITING_ROUTE = 0x80,
        EDITING_WAY_POINT = 0x100,
        HAND_ROAM = 0x200,
        EDITING_BASIC_OBJECT = 0x2000,
        EDITING_EDGE_MID_PO = 0x4000,
        DRAG_EDITING_OBJECT = 0x8000,
        EDITING_GEO_OBJECT = 0x10000,
        DRAW_EBL = 0x40000,
        ADD_USER_LAYER_OBJ = 0x80000,
        ALL_OPERATION = 0xFFFFFFFF
    };

    /// <summary>
    /// AIS船舶数据
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ShipData
    {
        public int type;
        public int mmsi;
        public int imo;
        public int state;
        public int timestamp;
        public double latitude;
        public double longitude;
        public double speed;
        public double course;
        public double heading;
        public int year;
        public int month;
        public int day;
        public int hour;
        public int minute;
        public int second;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
        public string shipname;
    }

    public partial class FormMain : Form
    {
        private String UserID = String.Empty;   //用户ID
        public String UserName = String.Empty; //用户名称
        private String ClientID = String.Empty; //客户端ID，标识本次运行程序
        private String UserRole = String.Empty; //用户角色
        private String ODU_ID = String.Empty;
        private List<CShipType> shipTypeList = null;    //船舶类型列表
        public List<CShip> shipList = null;    //船舶列表
        private CShip currentMouseShip = null; //当前鼠标操作的船
        private int m_shipOperatorStatus = 0;   //操作状态，是添加船还是编辑船（添加1，编辑2）

        public List<CRadar> radarList = null;  //雷达列表
        private CRadar currentMouseRadar = null; //当前鼠标操作的雷达
        private int m_radarOperatorStatus = 0;   //操作状态，是添加雷达还是编辑雷达（添加1，编辑2）

        public List<CAis> aisList = null;  //AIS基站列表
        private CAis currentMouseAis = null; //当前鼠标操作的AIS基站
        private int m_aisOperatorStatus = 0;   //操作状态，是添加AIS还是编辑AIS基站（添加1，编辑2）

        public List<CShip> radarShipList = null;
        public List<CShip> aisShipList = null;

        int m_GlobalRunStatus = 0; //表示启动状态：0 第一次未启动，1 启动 2 关闭 

        public CShip m_selectedShip = null;     //右键菜单时的船对象
        public CRadar m_selectedRadar = null;   //右键菜单时的雷达对象
        public CAis m_selectedAis = null;   //右键菜单时的AIS对象

        public Socket RecvShipDataClient = null;  //船列表，船位置数据通信
        public EndPoint RecvShipEndPoint = null;  //通信地址和端口

        public TcpListener tcpServer = null;    //TCP雷达列表，雷达图像数据通信
        public TcpClient radarClient = null;

        public EndPoint CoachStationPoint = null;    //发送ip和端口
        public String LOCAL_IP = String.Empty;
        public bool ISTrackPlayRun = false;

        private CShip currentSelectedShip = null; //当前鼠标操作的船
        private CRadar currentSelecteRadar = null; //当前鼠标操作的雷达
        private CAis currentSelecteAis = null; //当前鼠标操作的AIS基站

        const double MOVE_STEP_FACTOR = 0.2;
        const int MAX_SEL_OBJ_COUNT = 255;
        const int ROUTE_WAY_POINTS_MAX_COUNT = 10000;
        const string TEST_ROUTE_FILE_NAME = "Routes.dat";
        const int MAX_EMULATE_OTHER_VESSEL_COUNT = 1000;
        const int MAX_LINE_EDIT_POINT_COUNT = 1000;
        const string Display_Model = "显示模式:";
        const string Display_All = "全部";
        const string Display_Std = "标准";
        const string Display_Bas = "基本";
        const string Display_1 = "明亮";
        const string Display_2 = "亮";
        const string Display_3 = "稍亮";
        const string Display_4 = "暗";
        public string Display_5 ="黑" ;
        public string Display_Model_Color = Display_1;
        public string Display_Model_Info = Display_All;

        CURRENT_SUB_OPERATION m_curOperation;

        // 3个报警参数, 单位均为米：
        public static uint m_isoDangerDistDoor = 0;
        public static uint m_offRouteDistDoor = 0;
        public static uint m_safeContourDistDoor = 0;

        bool isDisplayHistoryTrack = false;//是否显示历史航迹的例子
        public static bool isDisplayLangCh = true;

        Sunisoft.IrisSkin.SkinEngine m_skin = null;
        private bool m_bYimaEncSdkInitResult = false;
        private bool m_bFormShowOk = false;
        public int m_CurFocuseShipid = -1;

        M_MAP_LAYER_DISPLAY_INFO_MODEL m_mapLayerDisplayModeInfo;
        private int m_iLastRefrshMapLayerDisplay;
        private string m_strCurrentProPath = "";//程序当前目录
        public bool g_drawline = false;
        public int startid;
        public int endid;

        public int m_iCurShipHightLightMMSI = 0;//当前高亮的船舶
        public bool m_bOnMouseDown = false;//是否鼠标按下

        public int m_iStartBigShipSignScale = 500000;//开始显示大船舶符号的比例尺

        public static int UNI_GEO_COOR_MULTI_FACTOR = 10000000;

        //----------------线程列表----------------
        public Thread m_threadRecvShipInfoThread = null;//接收船舶数据线程
        public Thread m_threadRecvRadarThread = null;//接收雷达数据线程
        public Thread m_threadLoginThread = null;//登录线程
        public Thread m_threadGetConfigInfoFromDataBase = null;//从数据库获取系统配置信息线程
        public Thread m_threadRecvRadarClientConn = null;   ////创建一个线程监听客户端连接请求
        public Thread m_threadRadarDrawImageConn = null;   ////创建一个线程绘制雷达图像

        //---------------定时维护目标列表--------------
        private System.Timers.Timer whObjectListTimer = null;

        //-----------通信及其他参数配置----------
        public SysConfigJson config = null;

        /// <summary>
        /// 设置当前程序的界面语言
        /// </summary>
        /// <param name="lang">language:zh-CN, en-US</param>
        /// <param name="form">窗体实例</param>
        /// <param name="formType">窗体类型</param>
        public static void SetLang(string lang, Form form, Type formType)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            if (form != null)
            {
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(formType);
                resources.ApplyResources(form, "$this");
                AppLang(form, resources);
            }
        }

        #region AppLang for control
        /// <summary>
        /// 遍历窗体所有控件，针对其设置当前界面语言
        /// </summary>
        /// <param name="control"></param>
        /// <param name="resources"></param>
        private static void AppLang(Control control, System.ComponentModel.ComponentResourceManager resources)
        {
            if (control is MenuStrip)
            {
                resources.ApplyResources(control, control.Name);
                MenuStrip ms = (MenuStrip)control;
                if (ms.Items.Count > 0)
                {
                    foreach (ToolStripMenuItem c in ms.Items)
                    {
                        AppLang(c, resources);
                    }
                }
            }

            foreach (Control c in control.Controls)
            {
                resources.ApplyResources(c, c.Name);
                AppLang(c, resources);
            }
        }
        #endregion

        #region AppLang for menuitem
        /// <summary>
        /// 遍历菜单
        /// </summary>
        /// <param name="item"></param>
        /// <param name="resources"></param>
        private static void AppLang(ToolStripMenuItem item, System.ComponentModel.ComponentResourceManager resources)
        {
            if (item is ToolStripMenuItem)
            {
                resources.ApplyResources(item, item.Name);
                ToolStripMenuItem tsmi = (ToolStripMenuItem)item;
                if (tsmi.DropDownItems.Count > 0)
                {
                    foreach (ToolStripMenuItem c in tsmi.DropDownItems)
                    {
                        AppLang(c, resources);
                    }
                }
            }
        }
        #endregion

        public FormMain(String userID,String userName,String clientID, String userrole, SysConfigJson _sysConfig)
        { 
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲

            UserID = userID;
            UserName = userName;
            ClientID = clientID;
            UserRole = userrole;

            ODU_ID = Convert.ToString(Common.GenerateRandomODUID());

            shipTypeList = new List<CShipType>();
            shipList = new List<CShip>();
            radarList = new List<CRadar>();
            aisList = new List<CAis>();

            radarShipList = new List<CShip>();
            aisShipList = new List<CShip>();

            m_curOperation = CURRENT_SUB_OPERATION.NO_OPERATION; 

            m_skin = new Sunisoft.IrisSkin.SkinEngine();
            RefreshMainStyle("mp10.ssk");

            m_bYimaEncSdkInitResult = false;
            this.WindowState = FormWindowState.Maximized;

            m_mapLayerDisplayModeInfo = new M_MAP_LAYER_DISPLAY_INFO_MODEL(1, 20000000, 50000);
            m_strCurrentProPath = System.Environment.CurrentDirectory;
            RefreshMapLayerDisplayInfo(true);
            m_iLastRefrshMapLayerDisplay = 0;

            config = _sysConfig;
            if ("".Equals(config.localIp))
            {
                LOCAL_IP = NetUtils.GetIpAddress();
            }
            else
            {
                LOCAL_IP = config.localIp;
            }
            whObjectListTimer = new System.Timers.Timer();
        }

        //设置系统显示风格
        public void RefreshMainStyle(string strSskName)
        {
            //数据表格初始化
            InitDataGridViewStyle(); 

            if (m_skin != null)
            {
                string strSskPath = Path.Combine(System.Environment.CurrentDirectory, "skins");
                strSskPath = Path.Combine(strSskPath, strSskName);
                m_skin.SkinFile = strSskPath;
                m_skin.Active = true;
            }
        }

        bool IsOnOperation(CURRENT_SUB_OPERATION subOperation)
        {
            if (subOperation == CURRENT_SUB_OPERATION.NO_OPERATION)
            {
                return m_curOperation == CURRENT_SUB_OPERATION.NO_OPERATION;
            }
            else
            {
                return (m_curOperation & subOperation) != 0;
            }
        }

        void SetOperation(CURRENT_SUB_OPERATION subOperation)
        {
            if (subOperation == CURRENT_SUB_OPERATION.NO_OPERATION)
            {
                m_curOperation = CURRENT_SUB_OPERATION.NO_OPERATION;
            }
            else
            {
                m_curOperation |= subOperation;
            }
        }

        void CancelOperation(CURRENT_SUB_OPERATION subOperation)
        {
            if (subOperation != CURRENT_SUB_OPERATION.NO_OPERATION)
            {
                m_curOperation &= (subOperation ^ CURRENT_SUB_OPERATION.ALL_OPERATION);
            }
        }

        /// <summary>
        /// 加载
        /// </summary>
        private void FormMain_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            string path = Directory.GetCurrentDirectory();
            try
            {
                m_bYimaEncSdkInitResult = ymEncCtrl.Init(path);
            }
            catch
            {
                if (m_bYimaEncSdkInitResult == false)
                {
                    //自动注册控件
                    if(!RegisterDll())
                    {
                        this.Close();
                    }
                    else
                    {
                        m_bYimaEncSdkInitResult = ymEncCtrl.Init(path);
                    }
                }
            }
            if (m_bYimaEncSdkInitResult == false)
            {
                MessageBox.Show("YimaEnc.ocx控件初始化失败，程序不能正常运行。");
                ymEncCtrl.Dispose();
                this.Close();
            }

            this.ymEncCtrl.Dock = DockStyle.Fill;
            this.ymEncCtrl.SetIfUseGDIPlus(false);
            this.ymEncCtrl.SetIfShowNorthArrow(true);
            this.ymEncCtrl.SetIfShowScaleBar(false);
            this.ymEncCtrl.SetIfShowGrid(false);
            this.ymEncCtrl.SetIfShowMapFrame(false);
            this.ymEncCtrl.SetIfOnDrawRadarMode(false);

            //重置海图大小
            ReSizeMapView();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            ymEncCtrl.SetCurrentScale(100000);
            CheckRefreshMapLayerDisplayModel();
            ymEncCtrl.CenterMap(1215363006, 313443826);

            //状态栏信息
            this.TSSL_Scale.Text = "比例尺:( 1:" + Math.Round((double)this.ymEncCtrl.GetCurrentScale(), 0).ToString().Trim() + ")";
            this.toolStripStatusLabel_user.Text = (UserRole.Equals("0") ? "管理员" : "训练员") + UserName;

            //清除ToolStripMenuItem显示模式的选择
            ClearDisplayCategoryChecked();
            this.ymEncCtrl.SetDisplayCategory((short)DISPLAY_CATEGORY_NUM.DISPLAY_ALL);
            TSMI_Display_AllInfo.Checked = true;
            Display_Model_Info = Display_All;
            //清除ToolStripMenuItem显示场景模式的选择
            ClearDisplayColorChecked();

            //停止轨迹回放
            this.停止回放ToolStripMenuItem.Checked = true;

            //---------------开启线程从数据库获取系统语言，颜色，显示模式，报警信息等配置信息Thread---------------
            m_threadGetConfigInfoFromDataBase = new Thread(GetConfigInfoFromDataBase);
            m_threadGetConfigInfoFromDataBase.Priority = ThreadPriority.Lowest;
            m_threadGetConfigInfoFromDataBase.Start();

            //刷新海图
            RedrawMapScreen();

            //---------------获取雷达列表数据信息Thread---------------
            m_threadRecvShipInfoThread = new Thread(ReceiveShipDataThread);

            //---------------获取雷达列表数据信息Thread---------------
            m_threadRecvRadarThread = new Thread(ReceiveRadarDataThread);

            //---------------接收雷达客户端连接Thread-----------------
            m_threadRecvRadarClientConn = new Thread(RecvRadarClientConnThread);

            //-----------------------------登录Thread-------------------------
            m_threadLoginThread = new Thread(ODULoginThread);

            //---------------接收船舶列表，船舶数据 Socket---------------
            RecvShipDataClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            RecvShipEndPoint = new IPEndPoint(IPAddress.Parse(LOCAL_IP), Convert.ToInt32(config.aisRecvPort));
            RecvShipDataClient.Bind(RecvShipEndPoint);

            //---------------接收雷达列表，雷达数据 Socket---------------
            tcpServer = new TcpListener(new IPEndPoint(IPAddress.Parse(LOCAL_IP), Convert.ToInt32(config.radarRecvPort)));
            tcpServer.Start();

            //---------------开启接收线程---------------
            m_threadLoginThread.Start();
            m_threadRecvShipInfoThread.Start();
            m_threadRecvRadarThread.Start();
            m_threadRecvRadarClientConn.Start();

            //---------------计算船舶和雷达列表定时器Timer---------------
            whObjectListTimer.Interval = 30*1000;
            whObjectListTimer.Elapsed += new System.Timers.ElapsedEventHandler(whObjectListTimerFun);
            whObjectListTimer.Enabled = true;
        }

        /// <summary>
        /// 接收客户端连接回调函数
        /// </summary>
        /// <param name="ar"></param>
        private void RecvRadarClientConnThread()
        {
            while (true)
            {
                try
                {
                    radarClient = tcpServer.AcceptTcpClient();
                }
                catch
                {
                    //当单击“停止监听”或者退出此窗体时AcceptTcpClient()会产生异常
                    //因此可以利用此异常退出循环
                    radarClient.Close();
                    continue;
                }
             }
         }

        /// <summary>
        /// 获取船舶列表，船舶数据线程
        /// </summary>
        [DllImport("AISDecode.dll", EntryPoint = "AISDecodeInfo", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern int AISDecodeInfo(String data, int ilen, ref ShipData desdata);
        private void ReceiveShipDataThread()
        {
            EndPoint mainEndPoint = new IPEndPoint(IPAddress.Any, 0);
            CShip recvShip = null;
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[512];//设置缓冲数据流
                    int len = RecvShipDataClient.ReceiveFrom(buffer, ref mainEndPoint); //接收数据,并确把数据设置到缓冲流里面
                    if (len == 0) //count 表示客户端关闭，要退出循环
                    {
                        continue;
                    }
                    String data = Encoding.Default.GetString(buffer, 0, len).Trim();
                    //!AIVDM,1,1,1,A,100000h0388d8wLAp?=QEQ4T0000,0*0C  待解析部分数据：100000h0388d8wLAp?=QEQ4T0000
                    data = data.Substring(7, data.Length - 10);
                    data = data.Split(',')[4];
                    ShipData shipData = new ShipData();
                    int res = AISDecodeInfo(data, data.Length, ref shipData);
                    if (res == -1)
                    {
                        recvShip = new CShip(shipData.mmsi, shipData.shipname + "ship_" + shipData.mmsi, shipTypeList[shipData.type % shipTypeList.Count], shipData.course,
                        shipData.heading, Convert.ToInt32(shipData.longitude * UNI_GEO_COOR_MULTI_FACTOR), Convert.ToInt32(shipData.latitude * UNI_GEO_COOR_MULTI_FACTOR), 1, shipData.speed / 1.852);
                        Common.ShipUpdateOrAdd(ymEncCtrl, shipList, recvShip);
                        //ymEncCtrl.CenterMap(recvShip.shipLatitude,recvShip.shipLongitude);
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show(String.Format("网络异常{0},请重启软件！",e.Message));
                }
                RedrawMapScreen();
                Thread.Sleep(500);
            }
        }

        /// <summary>
        /// 获取雷达列表，雷达数据线程
        /// </summary>
        private void ReceiveRadarDataThread()
        {
            EndPoint mainEndPoint = new IPEndPoint(IPAddress.Any, 0);
            StringBuilder ds = new StringBuilder();
            CRadar radar = null;
            String modStr = String.Empty;
            byte[] buffer = new byte[100000];//设置缓冲数据流
            byte[] data = new byte[100000];
            while (true)
            {
                DateTime beforDT = System.DateTime.Now;
                if (radarClient != null && radarClient.Connected)
                {
                    int bytesRead = 0;
                    int count = 0;
                    NetworkStream streamToClient = radarClient.GetStream();
                    lock (streamToClient)//为了保证数据的完整性以及安全性,锁定数据流
                    {
                        do
                        {
                            bytesRead = streamToClient.Read(buffer, 0, 100000);
                            for (int j = 0; j < bytesRead; j++)
                            {
                                data[count] = buffer[j];
                                count++;
                            }
                        } while (bytesRead > 0);
                    }
                    if (count <= 1) continue;
                    RadarData rd = RadarData.getRadarData(data, count);
                    if(rd.Datas != null)
                    {
                        radar = new CRadar(Convert.ToInt32(rd.Id), "radar_"+rd.Id, rd.Height, rd.Range, Convert.ToInt32(rd.Lng* 10000000), Convert.ToInt32(rd.Lat * 10000000), rd.PointCount, rd.LineCount, rd.Scale, 1)
                        {
                            radarScanRadius = rd.Scale * rd.PointCount,
                            radarShowColor = Color.Red,
                            radarShowType = 1,
                            radarUseOrNot = 1,
                            radarDepth = rd.Depth,
                            radarLines = rd.LineCount,
                            radarPoints = rd.PointCount,
                            radarDatas = rd.Datas
                        };
                        //更新或者添加雷达
                        Common.RadarUpdateOrAdd(ymEncCtrl, radarList, radar);
                        Thread thread = new Thread(new ParameterizedThreadStart(RadarDrawImageThread));
                        thread.Start(radar);
                    }
                }
                RedrawMapScreen();
                Thread.Sleep(500);
            }
        }

        /// <summary>
        /// 绘制雷达图像线程
        /// </summary>
        private void RadarDrawImageThread(object obj)
        {
            CRadar radar = (CRadar)obj;
            if (radar != null)
            {
                //根据雷达在YM上的ID，获取雷达MapPos
                int radarYMPos = ymEncCtrl.GetRadarPosById(radar.radarMapID);
                if (radar.radarUseOrNot == 1)
                {
                    for (int i = 0; i < radar.radarLines; i++)
                    {
                        String radarline = InteropEncDotNet.GetStringFromIntArray(radar.radarDatas[i], radar.radarPoints);
                        this.ymEncCtrl.SetRadarLineDataByPos(radarYMPos, i, ref radarline, radar.radarPoints);
                    }
                }
            }
            RedrawMapScreen();
        }

        /// <summary>
        /// 从数据库获取配置信息
        /// </summary>
        private void GetConfigInfoFromDataBase()
        {
            //获取用户配置信息
            string getInfoCommand = string.Format(@"select language,displayModelColor,displayModelInfo,isoDangerDistDoor,offRouteDistDoor,safeContourDistDoor,isDisplayHistoryTrack from userConfig where uid = '{0}'", UserID);
            MySqlDataReader resultReader = MySqlCustomHelper.ExecuteReader(MySqlCustomHelper.Conn, CommandType.Text, getInfoCommand, null);
            if (null == resultReader)
            {
                if (MessageBox.Show("数据库无法连接，请检查配置文件?", "确认", MessageBoxButtons.YesNo) == (System.Windows.Forms.DialogResult.Yes))
                {
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                if (resultReader.HasRows)
                {
                    resultReader.Read();
                    Display_Model_Color = resultReader.GetString("displayModelColor");
                    Display_Model_Info = resultReader.GetString("displayModelInfo");
                    m_isoDangerDistDoor = resultReader.GetUInt32("isoDangerDistDoor");
                    m_offRouteDistDoor = resultReader.GetUInt32("offRouteDistDoor");
                    m_safeContourDistDoor = resultReader.GetUInt32("safeContourDistDoor");
                    isDisplayHistoryTrack = (resultReader.GetUInt32("isDisplayHistoryTrack") == 0 ? false : true);
                }
                else
                {
                    //初次登录用户，插入数据
                    string setInfoCommand = string.Format(@"insert into userConfig(uid) values('{0}')", UserID);
                    int resultCount = MySqlCustomHelper.ExecuteNonQuery(MySqlCustomHelper.Conn, CommandType.Text, setInfoCommand, null);
                    if (resultCount != 1)
                    {
                        MessageBox.Show("为用户{0}设置配置信息时出错，请检查数据库连接！", UserName);
                    }
                }
                //获取船舶类型列表
                string getshiptypeCommand = string.Format(@"select * from shipType");
                MySqlDataReader resultShipTypeReader = MySqlCustomHelper.ExecuteReader(MySqlCustomHelper.Conn, CommandType.Text, getshiptypeCommand, null);
                int index = 0;
                while (resultShipTypeReader.Read())
                {
                    shipTypeList.Add(new CShipType(index, resultShipTypeReader.GetString("shipTypeName"),
                    resultShipTypeReader.GetDouble("shipDisplacement"), resultShipTypeReader.GetDouble("shipMaxSpeed"), resultShipTypeReader.GetDouble("shipLength"),
                    resultShipTypeReader.GetDouble("shipWidth"), resultShipTypeReader.GetDouble("shipBowDraught"), resultShipTypeReader.GetDouble("shipSternDraught"),
                    resultShipTypeReader.GetDouble("shipControlRoomHeight")));
                    index++;
                }
            }
        }

        /// <summary>
        /// ODU设备上报IP地址和PORT
        /// </summary>
        private void ODULoginThread()
        {
            Common.GenerateRandomMMSI();
            CoachStationPoint = new IPEndPoint(IPAddress.Parse(config.coachStation.coachStationIp), Convert.ToInt32(config.coachStation.coachStationPort));
            while (true)
            {
                String loginMes = "VTSODU-LG;" + ODU_ID + ";" + LOCAL_IP + ";" + config.radarRecvPort + "#";
                if(RecvShipDataClient != null)
                {
                    byte[] buffer = Encoding.Default.GetBytes(loginMes);
                    RecvShipDataClient.SendTo(buffer, CoachStationPoint);
                }
                Thread.Sleep(1000);
            }
        }

        private void InitDataGridViewStyle()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();

            //船舶列表样式
            this.dataGridView_ShipList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//选中整行
            this.dataGridView_ShipList.AllowUserToAddRows = false;
            this.dataGridView_ShipList.AllowUserToDeleteRows = false;
            this.dataGridView_ShipList.BackColor = System.Drawing.Color.LightCyan;
            this.dataGridView_ShipList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ShipList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_ShipList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_ShipList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;

            //头样式
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView_ShipList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_ShipList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ShipList.EnableHeadersVisualStyles = false;
            this.dataGridView_ShipList.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView_ShipList.ReadOnly = true;
            this.dataGridView_ShipList.RowHeadersVisible = false;
            this.dataGridView_ShipList.RowTemplate.ReadOnly = true;

            //雷达列表样式
            this.dataGridView_RadarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//选中整行
            this.dataGridView_RadarList.AllowUserToAddRows = false;
            this.dataGridView_RadarList.AllowUserToDeleteRows = false;
            this.dataGridView_RadarList.BackColor = System.Drawing.Color.LightCyan;
            this.dataGridView_RadarList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_RadarList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_RadarList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_RadarList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;

            //头样式
            this.dataGridView_RadarList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_RadarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RadarList.EnableHeadersVisualStyles = false;
            this.dataGridView_RadarList.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView_RadarList.ReadOnly = true;
            this.dataGridView_RadarList.RowHeadersVisible = false;
            this.dataGridView_RadarList.RowTemplate.ReadOnly = true;
        }


        public void whObjectListTimerFun(object source, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                while (this.dataGridView_ShipList.Rows.Count != 0)
                {
                    this.dataGridView_ShipList.Rows.RemoveAt(0);
                }
                //添加船舶列表
                if (shipList.Count > 0)
                {
                    //遍历所有船
                    foreach (CShip ship in shipList.ToArray())
                    {
                        if(null != ship.shipName)
                        {
                            int index = this.dataGridView_ShipList.Rows.Add();
                            dataGridView_ShipList.Rows[index].Cells[0].Value = ship.shipName;
                            dataGridView_ShipList.Rows[index].Cells[1].Value = ship.shipLongitude;
                            dataGridView_ShipList.Rows[index].Cells[2].Value = ship.shipLatitude;
                        }
                    }
                }
                while (this.dataGridView_RadarList.Rows.Count != 0)
                {
                    this.dataGridView_RadarList.Rows.RemoveAt(0);
                }
                //添加雷达列表
                if (radarList.Count > 0)
                {
                    //遍历所有雷达
                    foreach (CRadar radar in radarList.ToArray())
                    {
                        if(null != radar.radarName)
                        {
                            int index = this.dataGridView_RadarList.Rows.Add();
                            dataGridView_RadarList.Rows[index].Cells[0].Value = radar.radarName;
                            dataGridView_RadarList.Rows[index].Cells[1].Value = radar.radarGeoPosX;
                            dataGridView_RadarList.Rows[index].Cells[2].Value = radar.radarGeoPosY;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("目标列表异常"+ex.Message);
            }
        }

        //绘制
        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            RedrawMapScreen();
        }

        //重新绘制海图
        public void RedrawMapScreen()
        {
            if (m_bYimaEncSdkInitResult)
            {
                if (!(IsOnOperation(CURRENT_SUB_OPERATION.DRAW_EBL)) && !IsOnOperation(CURRENT_SUB_OPERATION.AREA_ZOOM_IN))//画电子电子方位线或拉框放大时不能刷屏 
                {
                    ymEncCtrl.DrawMapsInScreen(0);
                }
            }
        }

        //窗口大小变化时候
        private void FormMain_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                int totalHeight = this.panel_MainInfo.Height;
                tabControl_ShowInfo.Height = totalHeight / 2;
            }
            ReSizeMapView();
            m_bFormShowOk = true;
        }

        //关闭程序
        protected override void OnClosing(CancelEventArgs e)
        {
            if (MessageBox.Show("系统正在使用中,您是否确认退出?", "确认", MessageBoxButtons.YesNo) == (System.Windows.Forms.DialogResult.Yes))
            {
                m_bYimaEncSdkInitResult = false;
                ymEncCtrl.Exit(true);
                this.OnClosed(e);
            }
            else
            {
                e.Cancel = true;
            }
        }

        //测距
        private void AreaZoomInButton_Click(object sender, EventArgs e)
        {
            bool bRetOk = this.ymEncCtrl.ToolMapMeasure((int)M_TOOl_TYPE.TYPE_MEASURE_DIS);
        }

        # region 文件-图库管理
        private void MapLibManMenuItem_Click(object sender, EventArgs e)
        {   
            Form_LibMapMan maplibDlg = new Form_LibMapMan();
            maplibDlg.Owner = this;
            maplibDlg.Show();
        }
        
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("系统正在使用中,您是否确认退出?", "确认", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

        #region 查看功能
        private void 放大ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ymEncCtrl.SetCurrentScale((float)(ymEncCtrl.GetCurrentScale() / 1.5));
            RedrawMapScreen();
            //显示当前比例尺
            TSSL_Scale.Text = " 1:" + Math.Round((double)this.ymEncCtrl.GetCurrentScale(), 0).ToString().Trim();
        }

        private void 缩小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ymEncCtrl.SetCurrentScale((float)(ymEncCtrl.GetCurrentScale() * 1.5));
            RedrawMapScreen();
            //显示当前比例尺
            TSSL_Scale.Text = " 1:" + Math.Round((double)this.ymEncCtrl.GetCurrentScale(), 0).ToString().Trim();
        }

        private void 左移ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ymEncCtrl.SetMapMoreOffset((int)(this.Width * MOVE_STEP_FACTOR), 0);
            RedrawMapScreen(); 
        }

        private void 右移ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ymEncCtrl.SetMapMoreOffset(-(int)(this.Width * MOVE_STEP_FACTOR), 0);
            RedrawMapScreen(); 
        }

        private void 上移ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ymEncCtrl.SetMapMoreOffset(0, (int)(this.Height * MOVE_STEP_FACTOR));
            RedrawMapScreen();
        }

        private void 下移ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ymEncCtrl.SetMapMoreOffset(0, -(int)(this.Height * MOVE_STEP_FACTOR));
            RedrawMapScreen();            
        }

        private void 指定比例尺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSetScale formSetScale = new FormSetScale();
            this.AddOwnedForm(formSetScale);
            formSetScale.Show();
        }

        private void 中心点旋转ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCenterAndRotate f = new FormCenterAndRotate();
            this.AddOwnedForm(f);
            f.Show();
        }

        private void 历史航迹模拟显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        #endregion

        #region 显示选项-显示信息模式的变换
        /// <summary>
        /// 清除ToolStripMenuItem显示模式的选择
        /// </summary>
        private void ClearDisplayCategoryChecked()
        {
            this.TSMI_Display_AllInfo.Checked = false;
            this.TSMI_Display_BaseInfo.Checked = false;
            this.TSMI_Display_StandardInfo.Checked = false;            
        }

        private void TSMI_Display_AllInfo_Click(object sender, EventArgs e)
        {
            ClearDisplayCategoryChecked();
            this.ymEncCtrl.SetDisplayCategory((short)DISPLAY_CATEGORY_NUM.DISPLAY_ALL);
            TSMI_Display_AllInfo.Checked = true;
            Display_Model_Info=Display_All;
            toolStripStatusLabel_model.Text = Display_Model + Display_Model_Info + "    " + Display_Model_Color;
            RedrawMapScreen();
        }

        private void TSMI_Display_StandardInfo_Click(object sender, EventArgs e)
        {
            ClearDisplayCategoryChecked();
            this.ymEncCtrl.SetDisplayCategory((short)DISPLAY_CATEGORY_NUM.DISPLAY_STANDARD);
            TSMI_Display_StandardInfo.Checked = true;
            Display_Model_Info=Display_Std;
            toolStripStatusLabel_model.Text = Display_Model + Display_Model_Info + "    " + Display_Model_Color;
            RedrawMapScreen();
        }

        private void TSMI_Display_BaseInfo_Click(object sender, EventArgs e)
        {
            ClearDisplayCategoryChecked();
            this.ymEncCtrl.SetDisplayCategory((short)DISPLAY_CATEGORY_NUM.DISPLAY_BASE);
            TSMI_Display_BaseInfo.Checked = true;
            Display_Model_Info=Display_Bas;
            toolStripStatusLabel_model.Text = Display_Model + Display_Model_Info + "    " + Display_Model_Color;
            RedrawMapScreen();
        }

        private void TSMI_Display_SelectTlayerShowInfo_Click(object sender, EventArgs e)
        {
            FormSelectTlayerShowInfo f = new FormSelectTlayerShowInfo();
            f.Owner = this;
            f.Show();
        }

        private void 显示经纬度网格ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.显示经纬度网格ToolStripMenuItem.Checked)
            {
                this.显示经纬度网格ToolStripMenuItem.Checked = false;
                this.ymEncCtrl.SetIfShowGrid(false);
            }
            else
            {
                this.显示经纬度网格ToolStripMenuItem.Checked = true;
                this.ymEncCtrl.SetIfShowGrid(true);
            }
        }

        private void 显示历史航迹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isDisplay = !this.显示历史航迹ToolStripMenuItem.Checked;
            this.显示历史航迹ToolStripMenuItem.Checked = isDisplay;
            this.ymEncCtrl.SetShipTrackShowOrNot(false, true, 0, isDisplay);
            this.ymEncCtrl.SetShipTrackShowOrNot(true, true, 0, isDisplay);
        }
        #endregion

        #region 显示场景模式的变换
        /// <summary>
        /// 清除ToolStripMenuItem显示场景模式的选择
        /// </summary>
        private void ClearDisplayColorChecked()
        {
            TSMI_DisplayColor_DayBlackBack.Checked = false;
            TSMI_DisplayColor_DayBright.Checked = false;
            TSMI_DisplayColor_DayBusk.Checked = false;
            TSMI_DisplayColor_DayWhiteBack.Checked = false;
            TSMI_DisplayColor_Night.Checked = false;
            Display_Model_Color = "";
            toolStripStatusLabel_model.Text = Display_Model + Display_Model_Info + "    " + Display_Model_Color;
        }

        private void TSMI_DisplayColor_DayBright_Click(object sender, EventArgs e)
        {
            ClearDisplayColorChecked();
            this.ymEncCtrl.SetColorModel((short)ENC_COLOR_GROUP.DAY_BRIGHT);
            TSMI_DisplayColor_DayBright.Checked = true;
            Display_Model_Color = Display_1;
            toolStripStatusLabel_model.Text = Display_Model + Display_Model_Info + "    " + Display_Model_Color;
            RedrawMapScreen();
        }        

        private void TSMI_DisplayColor_DayWhiteBack_Click(object sender, EventArgs e)
        {
            ClearDisplayColorChecked();
            this.ymEncCtrl.SetColorModel((short)ENC_COLOR_GROUP.DAY_WHITEBACK);
            TSMI_DisplayColor_DayWhiteBack.Checked = true;
            Display_Model_Color = Display_2;
            toolStripStatusLabel_model.Text = Display_Model + Display_Model_Info + "    " + Display_Model_Color;
            RedrawMapScreen();
        }

        private void TSMI_DisplayColor_DayBlackBack_Click(object sender, EventArgs e)
        {
            ClearDisplayColorChecked();
            this.ymEncCtrl.SetColorModel((short)ENC_COLOR_GROUP.DAY_BLACKBACK);
            TSMI_DisplayColor_DayBlackBack.Checked = true;
            Display_Model_Color = Display_3;
            toolStripStatusLabel_model.Text = Display_Model + Display_Model_Info + "    " + Display_Model_Color;
            RedrawMapScreen();
        }

        private void TSMI_DisplayColor_DayBusk_Click(object sender, EventArgs e)
        {
            ClearDisplayColorChecked();
            this.ymEncCtrl.SetColorModel((short)ENC_COLOR_GROUP.DUSK);
            TSMI_DisplayColor_DayBusk.Checked = true;
            Display_Model_Color = Display_4;
            toolStripStatusLabel_model.Text = Display_Model + Display_Model_Info + "    " + Display_Model_Color;
            RedrawMapScreen();
        }

        private void TSMI_DisplayColor_Night_Click(object sender, EventArgs e)
        {
            ClearDisplayColorChecked();
            this.ymEncCtrl.SetColorModel((short)ENC_COLOR_GROUP.NIGHT);
            TSMI_DisplayColor_Night.Checked = true;
            Display_Model_Color = Display_5;
            toolStripStatusLabel_model.Text = Display_Model + Display_Model_Info + "    " + Display_Model_Color;
            RedrawMapScreen();
        }
        #endregion

        #region 显示简单符合还是传统图纸符号
        private void TSMI_DisplaySymbol_Trandition_Click(object sender, EventArgs e)
        {         
            this.ymEncCtrl.SetUseSmpSymbolOrNot(false);
            this.ymEncCtrl.SetUsePlainBndryOrNot(false);
            TSMI_DisplaySymbol_simple.Checked = false;
            TSMI_DisplaySymbol_Trandition.Checked = true;
            RedrawMapScreen();
        }

        private void TSMI_DisplaySymbol_simple_Click(object sender, EventArgs e)
        {
            this.ymEncCtrl.SetUseSmpSymbolOrNot(true);
            this.ymEncCtrl.SetUsePlainBndryOrNot(true);
            TSMI_DisplaySymbol_simple.Checked = true;
            TSMI_DisplaySymbol_Trandition.Checked = false;
        }
        #endregion

        #region 显示文本
        private void TSMI_Display_Text_Click(object sender, EventArgs e)
        {            
            TSMI_Display_Text.Checked = !(TSMI_Display_Text.Checked);
            this.ymEncCtrl.SetIfShowText(TSMI_Display_Text.Checked);
            RedrawMapScreen();
        }
        #endregion

        #region 显示语言设置
        private void TSMI_DisplayLang_CHN_Click(object sender, EventArgs e)//本国语言
        {
            TSMI_DisplayLang_CHN.Checked = true;
            TSMI_DisplayLang_ENG.Checked = false;
            this.ymEncCtrl.SetLanguage(false);
            SetLang("zh-CN", this, this.GetType());
            bool b = ymEncCtrl.ReInitMapMan("");//右键查询的物标信息显示中文
            LanguageSwitch();
            isDisplayLangCh = true;
        }

        private void TSMI_DisplayLang_ENG_Click(object sender, EventArgs e)//英语
        {
            TSMI_DisplayLang_CHN.Checked = false;
            TSMI_DisplayLang_ENG.Checked = true;
            this.ymEncCtrl.SetLanguage(true);
            SetLang("en-US", this, this.GetType());
            bool b = ymEncCtrl.ReInitMapMan("ENG");//右键查询的物标信息显示英文
            LanguageSwitch();
            isDisplayLangCh = false;

            TSMI_DisplayLang_CHN.Checked = false;
            TSMI_DisplayLang_ENG.Checked = true;
            this.ymEncCtrl.SetLanguage(true);
            SetLang("en-US", this, this.GetType());
        }
        #endregion

        #region 安全水深设定
        private void TSMI_Display_SetSafetyDepth_Click(object sender, EventArgs e)
        {
            FormSetSafetyDepth f = new FormSetSafetyDepth();
            f.Owner = this;
            f.Show();
        }
        #endregion

        #region 坐标转换
        private void TSMI_Tool_GEO_CALC_Click(object sender, EventArgs e)
        {
            FormGeographyCalculate f = new FormGeographyCalculate();
            f.Owner = this;
            f.Show();
            //f.ShowDialog();
        }
        #endregion

        #region 保存屏幕图片
        private void 保存屏幕图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog().ToString().Equals("Cancel"))
            {
                return;
            }
            string selectedPath = folderBrowserDialog.SelectedPath.ToString();
            string fileName = "\\SaveEncScreen.bmp";
            fileName = selectedPath + fileName;
            this.ymEncCtrl.SaveScrnToBmpFile(0, 0, this.ymEncCtrl.GetDrawerScreenWidth(), this.ymEncCtrl.GetDrawerScreenHeight(), fileName);
            MessageBox.Show("文件已经被保存到(File Save to)：" + fileName);
        }
        #endregion

        #region 根据屏幕坐标获取地理坐标
        /// <summary>
        /// 根据屏幕坐标获取地理坐标
        /// </summary>
        /// <param name="bLongOrLatiCoor">X:true,Y:false</param>
        /// <param name="coorVal">selWpPoint</param>
        /// <param name="coorMultiFactor">比例因子</param>
        /// <returns>string result</returns>
        private string GetDegreeStringFromGeoCoor(bool bLongOrLatiCoor, int coorVal, int coorMultiFactor)
        {
            string strResult;
            if (coorMultiFactor == 0)
            {
                coorMultiFactor = 10000000;
            }

            double dArcByDegree = coorVal / (double)coorMultiFactor;//度
            double minuteValue = 0;//分
            double secondValue = 0;//秒

            string str_degree;
            string str_minute;
            string str_second;

            if (TSMI_DisplayLang_ENG.Checked)
            {
                str_degree = "degree";
                str_minute = "minute";
                str_second = "second";
            }
            else
            {
                str_degree = "度";
                str_minute = "分";
                str_second = "秒";
            }

            string strSign = "";
            
            if (bLongOrLatiCoor)
            {              
                if (dArcByDegree >= 0)
                {
                    minuteValue = (dArcByDegree - (int)dArcByDegree) * 60;
                    secondValue = (minuteValue - (int)minuteValue) * 60;
                    strSign = "E";
                }
                else
                {
                    minuteValue = ((int)dArcByDegree - dArcByDegree) * 60;
                    secondValue = (minuteValue - (int)minuteValue) * 60;
                    strSign = "W";
                }
            }
            else
            {
                if (dArcByDegree >= 0)
                {
                    minuteValue = (dArcByDegree - (int)dArcByDegree) * 60;
                    secondValue = (minuteValue - (int)minuteValue) * 60;
                    strSign = "N";
                }
                else
                {
                    minuteValue = ((int)dArcByDegree - dArcByDegree) * 60;
                    secondValue = (minuteValue - (int)minuteValue) * 60;
                    strSign = "S";
                }
            }
            string strDegree = ((int)dArcByDegree).ToString();
            string strMinute = ((int)minuteValue).ToString();
            string strSecond = Math.Round(secondValue,1).ToString();
            while (strDegree.Length < 3)
            {
                if (bLongOrLatiCoor == false && strDegree.Length == 2)
                {
                    break;
                }
                strDegree = "0" + strDegree;              
            }

            while (strMinute.Length < 2)
            {
                strMinute = "0" + strMinute;
            }

            if (strSecond.IndexOf(".") == -1)
            {
                strSecond = strSecond + ".0";
            }

            while (strSecond.Length < 3)
            {
                strSecond = "0" + strSecond;
            }


            strResult = strDegree + str_degree + strMinute + str_minute + strSecond + str_second + " " + strSign;
            return strResult;
        }
        #endregion

        #region 视图-工具栏，状态栏
        private void TSMI_VIEW_STATUS_BAR_Click(object sender, EventArgs e)
        {
            TSMI_VIEW_STATUS_BAR.Checked = !TSMI_VIEW_STATUS_BAR.Checked;
            this.SS_STATUS_BAR.Visible = TSMI_VIEW_STATUS_BAR.Checked;
            ReSizeMapView();
        }

        private void TSMI_VIEW_TOOLBAR_Click(object sender, EventArgs e)
        {            
            TSMI_VIEW_TOOLBAR.Checked = !TSMI_VIEW_TOOLBAR.Checked;
            TS_TOOLBAR.Visible = TSMI_VIEW_TOOLBAR.Checked;
            ReSizeMapView();
        }

        private void 全屏显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TSMI_Info.Checked = false;
            this.panel_MainInfo.Visible = TSMI_Info.Checked;

            TSMI_VIEW_STATUS_BAR.Checked = true;
            this.SS_STATUS_BAR.Visible = TSMI_VIEW_STATUS_BAR.Checked;

            TSMI_VIEW_TOOLBAR.Checked = false;
            TS_TOOLBAR.Visible = TSMI_VIEW_TOOLBAR.Checked;
            ReSizeMapView();
        }
        #endregion

        private void TSMI_Info_Click(object sender, EventArgs e)
        {
            TSMI_Info.Checked = !TSMI_Info.Checked;            
            this.panel_MainInfo.Visible = TSMI_Info.Checked;
        }

        public void disScale()
        {
            this.TSSL_Scale.Text = " 1:" + Math.Round((double)this.ymEncCtrl.GetCurrentScale(), 0).ToString().Trim();
        }

        //修改海图窗口的大小
        private void ReSizeMapView()
        {
            if (m_bYimaEncSdkInitResult)//控件YimaEnc.ocx初始化成功后
            {
                int iMainMapViewTop = 0;

                int iButtomSize = 0;
                if (this.TS_TOOLBAR.Visible == true || m_bFormShowOk == false)
                {
                    iMainMapViewTop += this.TS_TOOLBAR.Height;
                }

                if (this.menuStrip1.Visible == true || m_bFormShowOk == false)
                {
                    iMainMapViewTop += this.menuStrip1.Height;
                }

                if (this.SS_STATUS_BAR.Visible == true || m_bFormShowOk == false)
                {
                    iButtomSize = this.SS_STATUS_BAR.Height;
                }
                int hdc = (int)this.Handle;
                int iMapWidth = this.Width + 1;//C#版本这里加1，否则最小化时候就会出错
                int iMapHeight = this.Height + 1;
                this.ymEncCtrl.RefreshDrawer(hdc, this.ymEncCtrl.Width,
                    this.ymEncCtrl.Height, 0, 0);
            }
        }

        //右键菜单项
        private void contextMenuStrip_DataViewList_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(m_GlobalRunStatus != 1)
            {
                if (e.ClickedItem.Text.Trim().Equals("编辑船舶"))
                {
                    if (currentSelectedShip != null)
                    {
                        ShipAddForm editShipDialog = new ShipAddForm(shipTypeList, currentSelectedShip);
                        editShipDialog.ShowDialog();
                        if(editShipDialog.DialogResult == DialogResult.OK)
                        {
                            currentSelectedShip.shipTrack.ClearTrack(); //清除航迹
                            currentSelectedShip.SetCurHeading(ymEncCtrl, currentSelectedShip.shipHeading, true);   //设置船首向
                            shipList[currentSelectedShip.shipID] = currentSelectedShip;
                            currentSelectedShip = null;
                            RedrawMapScreen();
                        }
                    }
                }
                else if (e.ClickedItem.Text.Trim().Equals("删除船舶"))
                {
                    if (currentSelectedShip != null)
                    {
                        for(int i = 0;i<shipList.Count;i++)
                        {
                            if(currentSelectedShip.Equals(shipList[i]))
                            {
                                if (MessageBox.Show("确定要删除删除船舶:" + currentSelectedShip.shipName + "吗？", "删除船舶", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                {
                                    shipList[i].shipUseOrNot = -1;
                                    //bool result = shipList.Remove(currentSelectedShip);
                                    RedrawMapScreen();
                                }
                            }
                        }
                    }
                }
                else if (e.ClickedItem.Text.Trim().Equals("编辑雷达"))
                {
                    if (currentSelecteRadar != null)
                    {
                        RadarAddForm editRadarDialog = new RadarAddForm(currentSelecteRadar);
                        editRadarDialog.ShowDialog();
                        if (editRadarDialog.DialogResult == DialogResult.OK)
                        {
                            //向教练站发送一次修改后雷达的数据
                            String radarMes = "VTSRADAR-S;ER;" + currentSelecteRadar.radarName + ";;;" + Convert.ToDouble(currentSelecteRadar.radarGeoPosX * 1.0 / UNI_GEO_COOR_MULTI_FACTOR) + ";" + Convert.ToDouble(currentSelecteRadar.radarGeoPosY * 1.0 / UNI_GEO_COOR_MULTI_FACTOR) + ";" + currentSelecteRadar.radarHigh + ";" + currentSelecteRadar.radarRange + ";" + currentSelecteRadar.radarDepth + "#";
                            byte[] buffer = Encoding.Default.GetBytes(radarMes);
                            RecvShipDataClient.SendTo(buffer, CoachStationPoint);
                            currentSelecteRadar = null;
                            RedrawMapScreen();
                        }
                    }
                    else
                    {
                        MessageBox.Show("当前操作：编辑雷达，状态：失败，原因：未选中任何雷达目标！");
                    }
                }
                else if (e.ClickedItem.Text.Trim().Equals("开启雷达"))
                {
                    if (currentSelecteRadar != null)
                    {
                        radarList[currentSelecteRadar.radarID].radarUseOrNot = 1;
                        int radarYMPos = ymEncCtrl.GetRadarPosById(radarList[currentSelecteRadar.radarID].radarMapID);
                        ymEncCtrl.SetRadarShowState(radarYMPos, true, Convert.ToBoolean(radarList[currentSelecteRadar.radarID].radarShowType));
                        currentSelecteRadar = null;
                        RedrawMapScreen();
                    }
                    else
                    {
                        MessageBox.Show("当前操作：开启雷达，状态：失败，原因：未选中任何雷达目标！");
                    }
                }
                else if (e.ClickedItem.Text.Trim().Equals("关闭雷达"))
                {
                    if (currentSelecteRadar != null)
                    {
                        radarList[currentSelecteRadar.radarID].radarUseOrNot = 0;
                        int radarYMPos = ymEncCtrl.GetRadarPosById(radarList[currentSelecteRadar.radarID].radarMapID);
                        ymEncCtrl.SetRadarShowState(radarYMPos,false,Convert.ToBoolean(radarList[currentSelecteRadar.radarID].radarShowType));
                        currentSelecteRadar = null;
                        //清空数据
                        RedrawMapScreen();
                    }
                    else
                    {
                        MessageBox.Show("当前操作：关闭雷达，状态：失败，原因：未选中任何雷达目标！");
                    }
                }
                else if (e.ClickedItem.Text.Trim().Equals("删除雷达"))
                {
                    if (currentSelecteRadar != null)
                    {
                        for (int i = 0; i < radarList.Count; i++)
                        {
                            if (currentSelecteRadar.Equals(radarList[i]))
                            {
                                if (MessageBox.Show("确定要删除删除雷达:" + currentSelecteRadar.radarName + "吗？", "删除雷达", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                {
                                    //删除雷达物标
                                    bool removePointObject = ymEncCtrl.tmDeleteGeoObject(Common.RADAR_LAYER_POS, currentSelecteRadar.radarMapPos);
                                    //bool removeObject = radarList.Remove(currentSelecteRadar);
                                    //不删除对象，而是对象置位不可视
                                    radarList[i].radarUseOrNot = -1;
                                    //关闭显示的雷达图像
                                    int radarMapPos = ymEncCtrl.GetRadarPosById(currentSelecteRadar.radarMapID);
                                    ymEncCtrl.SetRadarShowState(radarMapPos, false, Convert.ToBoolean(currentSelecteRadar.radarShowType));
                                    //清空数据
                                  
                                    RedrawMapScreen();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("当前操作：删除雷达，状态：失败，原因：未选中任何雷达目标！");
                    }
                }
                else if (e.ClickedItem.Text.Trim().Equals("编辑AIS"))
                {
                    if (currentSelecteAis != null)
                    {
                        AISAddForm editAisDialog = new AISAddForm(currentSelecteAis);
                        editAisDialog.ShowDialog();
                        if (editAisDialog.DialogResult == DialogResult.OK)
                        {
                            aisList[currentSelecteAis.aisID] = currentSelecteAis;
                            currentSelecteAis = null;
                            RedrawMapScreen();
                        }
                    }
                    else
                    {
                        MessageBox.Show("当前操作：编辑AIS，状态：失败，原因：未选中任何AIS目标！");
                    }
                }
                else if (e.ClickedItem.Text.Trim().Equals("开启AIS"))
                {
                    if (currentSelecteAis != null)
                    {
                        aisList[currentSelecteAis.aisID].aisUseOrNot = 1;
                        currentSelecteAis = null;
                        RedrawMapScreen();
                    }
                    else
                    {
                        MessageBox.Show("当前操作：开启AIS基站，状态：失败，原因：未选中任何AIS基站目标！");
                    }
                }
                else if (e.ClickedItem.Text.Trim().Equals("关闭AIS"))
                {
                    if (currentSelecteAis != null)
                    {
                        aisList[currentSelecteAis.aisID].aisUseOrNot = 0;
                        currentSelecteAis = null;
                        //清空数据
                        RedrawMapScreen();
                    }
                    else
                    {
                        MessageBox.Show("当前操作：关闭AIS基站，状态：失败，原因：未选中任何AIS基站目标！");
                    }
                }
                else if (e.ClickedItem.Text.Trim().Equals("删除AIS"))
                {
                    if (currentSelecteAis != null)
                    {
                        for (int i = 0; i < aisList.Count; i++)
                        {
                            if (currentSelecteAis.Equals(aisList[i]))
                            {
                                if (MessageBox.Show("确定要删除删除AIS基站:" + currentSelecteAis.aisName + "吗？", "删除AIS基站", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                {
                                    bool removePointObject = ymEncCtrl.tmDeleteGeoObject(Common.AIS_LAYER_POS, currentSelecteAis.aisMapPos);
                                    //bool result = aisList.Remove(currentSelecteAis);
                                    aisList[i].aisUseOrNot = -1;
                                    MessageBox.Show("AIS基站：" + currentSelecteAis.aisName + "已经被成功移除！");
                                    RedrawMapScreen();
                                }    
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("当前操作：删除AIS基站，状态：失败，原因：未选中任何AIS基站目标！");
                    }
                }
            }
            else
            {
                MessageBox.Show("请先暂停程序，再进行其他操作！");
            }
        }

        private int SelectShipPosByScrnPo(int iScrnX,int iScrnY,int iCheckScrnLen)
        {
            int iResult = -1;

            int iShipCount = this.ymEncCtrl.GetOtherVesselCount();
            for (int i = 0; i < iShipCount; i++)
            {
                bool bValue = false;
                int iShipGeoX = 0;
                int iShipGeoY = 0;
                float fValue = 0;
                int iValue = 0;
                string strValue = "";
                this.ymEncCtrl.GetOtherVesselCurrentInfo(i, ref bValue, ref iShipGeoX, ref iShipGeoY, ref fValue, ref fValue, ref fValue, ref fValue, ref fValue, ref iValue, ref strValue);
                int iShipScrnX = 0;
                int iShipScrnY = 0;
                this.ymEncCtrl.GetScrnPoFromGeoPo(iShipGeoX, iShipGeoY, ref iShipScrnX, ref iShipScrnY);
                double iScrnDis = Math.Pow((iShipScrnX - iScrnX),2) + Math.Pow((iShipScrnY - iScrnY),2);
                if(iScrnDis < Math.Pow(iCheckScrnLen,2))
                {
                    iResult = i;
                    break;
                }   
            }
            return iResult;
        }

        public void RefreshMapLayerDisplayInfo(bool bGetInfoFormFileOrSave)
        {
            if (bGetInfoFormFileOrSave)
            {
                m_mapLayerDisplayModeInfo.arrMaxHiddenLayerToken.Clear();
                m_mapLayerDisplayModeInfo.arrMidHiddenLayerToken.Clear();
                m_mapLayerDisplayModeInfo.arrMidHiddenLayerToken.Clear();

                string strCurPath = Path.Combine(m_strCurrentProPath, "MapLayerHiddenTokenName.ini");
                string[] arrCurLayerTokenString; //定义读取配置文件数组
                if (File.Exists(strCurPath))    //判断文件config.ini是否存在
                {
                    arrCurLayerTokenString = File.ReadAllLines(strCurPath, Encoding.Default);
                    int iLayerTokenCount = arrCurLayerTokenString.Length;

                    for (int i = 0; i < iLayerTokenCount; i++)
                    {
                        string[] arrLayerToken = arrCurLayerTokenString[i].Replace("，", ",").Split(',');
                        if (arrLayerToken.Length > 1)
                        {
                            string strModelType = arrLayerToken[0];
                            string strLayerToken = arrLayerToken[1];
                            if (strModelType.Equals("useModelType"))
                            {
                                m_mapLayerDisplayModeInfo.iUseModelType = Convert.ToInt32(strLayerToken);
                            }
                            else if (strModelType.Equals("minScale"))
                            {
                                m_mapLayerDisplayModeInfo.iMinScale = Convert.ToInt32(strLayerToken);
                            }
                            else if (strModelType.Equals("maxScale"))
                            {
                                m_mapLayerDisplayModeInfo.iMaxScale = Convert.ToInt32(strLayerToken);
                            }
                            else if (strModelType.Equals("0"))
                            {
                                m_mapLayerDisplayModeInfo.arrMaxHiddenLayerToken.Add(strLayerToken);
                            }
                            else if (strModelType.Equals("1"))
                            {
                                m_mapLayerDisplayModeInfo.arrMidHiddenLayerToken.Add(strLayerToken);
                            }
                            else if (strModelType.Equals("2"))
                            {
                                m_mapLayerDisplayModeInfo.arrMinHiddenLayerToken.Add(strLayerToken);
                            }
                        }
                    }
                }
            }
        }
        
        private void CheckRefreshMapLayerDisplayModel()
        {
            if (m_mapLayerDisplayModeInfo.iUseModelType > 0)
            {
                int iMinCount = m_mapLayerDisplayModeInfo.arrMinHiddenLayerToken.Count;
                int iMidCount = m_mapLayerDisplayModeInfo.arrMidHiddenLayerToken.Count;
                int iMaxCount = m_mapLayerDisplayModeInfo.arrMaxHiddenLayerToken.Count;
                if (iMinCount == 0 && iMidCount == 0 && iMaxCount == 0)
                {
                    return;
                }

                int iShowModelType = 0;
                int iCurScale = (int)this.ymEncCtrl.GetCurrentScale();
                bool bRefreshMapLayerOrNot = false;
                if ((iCurScale > m_mapLayerDisplayModeInfo.iMaxScale) && m_iLastRefrshMapLayerDisplay < m_mapLayerDisplayModeInfo.iMaxScale)
                {
                    bRefreshMapLayerOrNot = true;
                    iShowModelType = 0;
                }
                else if ((iCurScale < m_mapLayerDisplayModeInfo.iMaxScale && iCurScale > m_mapLayerDisplayModeInfo.iMinScale))
                {
                    if (m_iLastRefrshMapLayerDisplay > m_mapLayerDisplayModeInfo.iMaxScale || m_iLastRefrshMapLayerDisplay < m_mapLayerDisplayModeInfo.iMinScale)
                    {
                        bRefreshMapLayerOrNot = true;
                        iShowModelType = 1;
                    }
                }
                else if (iCurScale < m_mapLayerDisplayModeInfo.iMinScale && m_iLastRefrshMapLayerDisplay > m_mapLayerDisplayModeInfo.iMinScale)
                {
                    bRefreshMapLayerOrNot = true;
                    iShowModelType = 2;
                }

                if (bRefreshMapLayerOrNot == true)
                {
                    m_iLastRefrshMapLayerDisplay = iCurScale;
                    int iMapPos = -1;
                    int iAllLayerCount = this.ymEncCtrl.GetLayerCount(iMapPos);
                    for (int i = 0; i < iAllLayerCount; i++)
                    {
                        this.ymEncCtrl.SetLayerDrawOrNot(iMapPos, i, true);
                    }
                    switch (iShowModelType)
                    {
                        case 0:
                            {
                                int iHiddelCount = m_mapLayerDisplayModeInfo.arrMaxHiddenLayerToken.Count;
                                for (int i = 0; i < iHiddelCount; i++)
                                {
                                    int iLayerPos = this.ymEncCtrl.GetLayerPosByToken(iMapPos,(string) m_mapLayerDisplayModeInfo.arrMaxHiddenLayerToken[i]);
                                    this.ymEncCtrl.SetLayerDrawOrNot(iMapPos, iLayerPos, false);
                                }
                                break;
                            }
                        case 1:
                            {
                                int iHiddelCount = m_mapLayerDisplayModeInfo.arrMidHiddenLayerToken.Count;
                                for (int i = 0; i < iHiddelCount; i++)
                                {
                                    int iLayerPos = this.ymEncCtrl.GetLayerPosByToken(iMapPos, (string)m_mapLayerDisplayModeInfo.arrMidHiddenLayerToken[i]);
                                    this.ymEncCtrl.SetLayerDrawOrNot(iMapPos, iLayerPos, false);
                                }
                                break;
                            }
                        case 2:
                            {
                                int iHiddelCount = m_mapLayerDisplayModeInfo.arrMinHiddenLayerToken.Count;
                                for (int i = 0; i < iHiddelCount; i++)
                                {
                                    int iLayerPos = this.ymEncCtrl.GetLayerPosByToken(iMapPos, (string)m_mapLayerDisplayModeInfo.arrMinHiddenLayerToken[i]);
                                    this.ymEncCtrl.SetLayerDrawOrNot(iMapPos, iLayerPos, false);
                                }
                                break;
                            }
                    }
                }
            }
        }
  
        public static bool WriteLog(string strTxtFilePath, string strText)
        {
            bool result = true;

            if (!File.Exists(strTxtFilePath))
            {
                FileStream fs = File.Create(strTxtFilePath);
                fs.Close();
            }

            try
            {
                System.IO.StreamWriter write = new StreamWriter(strTxtFilePath, true, System.Text.Encoding.UTF8);

                write.WriteLine(strText);
                write.Close();
            }
            catch (Exception ex)
            {
                string strMessage = ex.ToString();
                result = false;
            }
            return result;

        }

        //显示船面板，当鼠标移动上去的时候
        public bool ShowShipInfoByMouseMove(M_POINT mMouseScrnPo)
        {
            bool bResult = false;
            CShip selectedShip = null;
            foreach(CShip ship in shipList.ToArray())
            {
                if (ship.HasSelected(ymEncCtrl, mMouseScrnPo))
                {
                    selectedShip = ship;
                    break;
                }
            }
            if (selectedShip != null)
            {
                M_POINT mMouseGeoPo = new M_POINT();
                ymEncCtrl.GetGeoPoFromScrnPo(mMouseScrnPo.x, mMouseScrnPo.y,ref mMouseGeoPo.x,ref mMouseGeoPo.y);
                this.tabPage_BaseInfo.Text = "船(" + selectedShip.shipName + ")基本信息";
                this.label_name.Text = "船MMSI：" + selectedShip.shipMMSI;
                this.label_x.Text = "经度：" + InteropEncDotNet.GetDegreeStringFromGeoCoor_new(true, selectedShip.shipLatitude, 10000000, 3);
                this.label_y.Text = "纬度：" + InteropEncDotNet.GetDegreeStringFromGeoCoor_new(false, selectedShip.shipLongitude, 10000000, 3);
                this.label_time.Text = "当前时间："+DateTime.Now.ToString();
                this.label7.Text = "航向：" + selectedShip.shipCourse + "度";
                this.label6.Text = "船速：" + selectedShip.shipSpeed + "节";
                this.label10.Text = "艏向：" + selectedShip.shipHeading + "度";
                this.label12.Text = "舵角：" + selectedShip.shipHeading + "度";
                this.tabPage_SettingInfo.Text = "参数信息";
                this.label_ship_typename.Text = "类型名称：" + selectedShip.shipType.shipTypeName;
                this.label_ship_heigh.Text = "控制室高度(米)：" + selectedShip.shipType.shipControlRoomHeight;
                this.label_ship_psl.Text = "排水量(吨)：" + selectedShip.shipType.shipSternDraught;
                this.label_ship_wcs.Text = "船尾吃水(米)：" + selectedShip.shipType.shipDisplacement;
                this.label_ship_scs.Text = "船首吃水(米)：" + selectedShip.shipType.shipBowDraught;
                this.label_ship_speed.Text = "最大速度(节)：" + selectedShip.shipType.shipMaxSpeed;
                this.label_ship_width.Text = "宽度(米)：" + selectedShip.shipType.shipWidth;
                this.label_ship_length.Text = "长度(米)：" + selectedShip.shipType.shipLength;
                if (Common.CheckAdmin(UserRole))
                {
                    //显示右键菜单
                    this.contextMenuStrip_DataViewList.Items.Clear();
                    //this.contextMenuStrip_DataViewList.Items.Add("编辑船舶", Properties.Resources.edit);
                    //this.contextMenuStrip_DataViewList.Items.Add("删除船舶", Properties.Resources.Delete);
                    this.contextMenuStrip_DataViewList.Show(this.ymEncCtrl, new Point(mMouseScrnPo.x, mMouseScrnPo.y));
                    this.contextMenuStrip_DataViewList.Visible = true;
                    currentSelectedShip = selectedShip;
                }
                bResult = true;
            }
            return bResult;
        }

        //显示雷达面板，当鼠标移动上去的时候
        public bool ShowRadarBoxByMouseMove(M_POINT mMouseScrnPo, M_POINT mMouseGeoPo, int selectDistVal)
        {
            bool bResult = false;
            int pointObjectPos = GetNearPointObjectIndex(mMouseScrnPo, 0, selectDistVal);
            if(pointObjectPos != -1)
            {
                CRadar selectedRadar = GetRadarObjectByMapPos(pointObjectPos);
                if(selectedRadar != null)
                {
                    this.tabPage_BaseInfo.Text = "雷达(" + selectedRadar.radarName + ")基本信息";
                    this.label_name.Text = "雷达名称:" + selectedRadar.radarName;
                    this.label_x.Text = "经度:" + InteropEncDotNet.GetDegreeStringFromGeoCoor_new(true, selectedRadar.radarGeoPosX, 10000000, 3);
                    this.label_y.Text = "纬度:" + InteropEncDotNet.GetDegreeStringFromGeoCoor_new(false, selectedRadar.radarGeoPosY, 10000000, 3);
                    this.label7.Text = "雷达扫描半径:" + selectedRadar.radarScanRadius + "米(m)";
                    this.label6.Text = "";
                    this.label10.Text = "雷达安装高度:" + selectedRadar.radarHigh + "米";
                    this.label12.Text = "";
                    this.label11.Text = "雷达量程:" + selectedRadar.radarRange + "米";
                    this.tabPage_SettingInfo.Text = "参数信息";
                    this.label_ship_typename.Text = "暂无更多信息！";
                    this.label_ship_heigh.Text = "";
                    this.label_ship_psl.Text = "";
                    this.label_ship_wcs.Text = "";
                    this.label_ship_scs.Text = "";
                    this.label_ship_model.Text = "";
                    this.label_ship_speed.Text = "";
                    this.label_ship_width.Text = "";
                    this.label_ship_length.Text = "";
                    if (Common.CheckAdmin(UserRole))
                    {
                        //显示右键菜单
                        this.contextMenuStrip_DataViewList.Items.Clear();
                        if(Common.CheckAdmin(UserRole))
                        {
                            this.contextMenuStrip_DataViewList.Items.Add("编辑雷达", Properties.Resources.edit);
                            if (selectedRadar.radarUseOrNot == 1)
                            {
                                //this.contextMenuStrip_DataViewList.Items.Add("关闭雷达", Properties.Resources.close);
                            }
                            else if (selectedRadar.radarUseOrNot == 0)
                            {
                                //this.contextMenuStrip_DataViewList.Items.Add("开启雷达", Properties.Resources.yes);
                            }
                            //this.contextMenuStrip_DataViewList.Items.Add("删除雷达", Properties.Resources.Delete);
                        }
                        this.contextMenuStrip_DataViewList.Show(this.ymEncCtrl, new Point(mMouseScrnPo.x, mMouseScrnPo.y));
                        this.contextMenuStrip_DataViewList.Visible = true;
                        currentSelecteRadar = selectedRadar;
                    }
                    bResult = true;
                }
            }
            return bResult;
        }

        //显示AIS面板，当鼠标移动上去的时候
        public bool ShowAisBoxByMouseMove(M_POINT mMouseScrnPo, M_POINT mMouseGeoPo, int selectDistVal)
        {
            bool bResult = false;
            int pointObjectPos = GetNearPointObjectIndex(mMouseScrnPo, 1, selectDistVal);
            if (pointObjectPos != -1)
            {
                CAis selectedAis = GetAisObjectByMapPos(pointObjectPos);
                if (selectedAis != null)
                {
                    this.tabPage_BaseInfo.Text = "AIS(" + selectedAis.aisName + ")基本信息";
                    this.label_name.Text = "AIS基站名称:" + selectedAis.aisName;
                    this.label_x.Text = "经度:" + InteropEncDotNet.GetDegreeStringFromGeoCoor_new(true, selectedAis.aisGeoPosX, 10000000, 3);
                    this.label_y.Text = "纬度:" + InteropEncDotNet.GetDegreeStringFromGeoCoor_new(false, selectedAis.aisGeoPosY, 10000000, 3);
                    this.label7.Text = "AIS扫描半径:" + selectedAis.aisScanRadius + "千米(公里)";
                    this.label6.Text = "";
                    this.label10.Text = "";
                    this.label12.Text = "";
                    this.label11.Text = "";
                    this.tabPage_SettingInfo.Text = "参数信息";
                    this.label_ship_typename.Text = "暂无更多信息！";
                    this.label_ship_heigh.Text = "";
                    this.label_ship_psl.Text = "";
                    this.label_ship_wcs.Text = "";
                    this.label_ship_scs.Text = "";
                    this.label_ship_model.Text = "";
                    this.label_ship_speed.Text = "";
                    this.label_ship_width.Text = "";
                    this.label_ship_length.Text = "";
                    if (Common.CheckAdmin(UserRole))
                    {
                        //显示右键菜单
                        this.contextMenuStrip_DataViewList.Items.Clear();
                        this.contextMenuStrip_DataViewList.Items.Add("编辑AIS", Properties.Resources.edit);
                        if(selectedAis.aisUseOrNot == 1)
                        {
                            this.contextMenuStrip_DataViewList.Items.Add("关闭AIS", Properties.Resources.close);
                        }
                        else if (selectedAis.aisUseOrNot == 0)
                        {
                            this.contextMenuStrip_DataViewList.Items.Add("开启AIS", Properties.Resources.yes);
                        }
                        this.contextMenuStrip_DataViewList.Items.Add("删除AIS", Properties.Resources.Delete);
                        this.contextMenuStrip_DataViewList.Show(this.ymEncCtrl, new Point(mMouseScrnPo.x, mMouseScrnPo.y));
                        this.contextMenuStrip_DataViewList.Visible = true;
                        currentSelecteAis = selectedAis;
                    }
                    bResult = true;
                }
            }
            return bResult;
        }

        /// <summary>
        /// 获取当前坐标点最接近的物标的索引值 
        /// </summary>
        /// <param name="mMouseScrnPo">鼠标位置</param>
        /// <param name="type">type == 0 雷达 type == 1 AIS</param>
        /// <param name="distance">距离因子</param>
        /// <returns></returns>
        private int GetNearPointObjectIndex(M_POINT mMouseScrnPo,int type,int distance)
        {
            M_POINT mGeoPo = new M_POINT();
            String value = String.Empty;
            for (int index = 0;index <= (this.ymEncCtrl.tmGetLayerObjectCount(type) - 1);index++)
            {
                this.ymEncCtrl.tmGetPointObjectCoor(type, index, ref mGeoPo.x, ref mGeoPo.y);
                //判断指定地理坐标距离物标边框的距离
                if (this.ymEncCtrl.IsGeoPointSelectByScrnPoint(mMouseScrnPo.x, mMouseScrnPo.y, mGeoPo.x, mGeoPo.y, distance))
                    return index;
            }
            return -1;
        }

        /// <summary>
        /// 根据物标索引找到CRadar对象
        /// </summary>
        /// <param name="mapPos"></param>
        /// <returns></returns>
        private CRadar GetRadarObjectByMapPos(int mapPos)
        {
            foreach(CRadar radar in radarList.ToArray())
            {
                if (radar.radarMapPos == mapPos)
                    return radar;
            }
            return null;
        }

        /// <summary>
        /// 根据物标索引找到CAis对象
        /// </summary>
        /// <param name="mapPos"></param>
        /// <returns></returns>
        private CAis GetAisObjectByMapPos(int mapPos)
        {
            foreach (CAis ais in aisList.ToArray())
            {
                if (ais.aisMapPos == mapPos)
                    return ais;
            }
            return null;
        }

        /// <summary>
        /// 获取在屏幕上的坐标
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public Point GetLocationOnClient(Control c) 
        { 
            Point retval = new Point(0, 0); 
            for (; c.Parent != null; c = c.Parent) 
            { 
                retval.Offset(c.Location); 
            } 
            return retval; 
        }

        #region ymEncCtrl事件
        private void ymEncCtrl_OnBeginLButtonDown(object sender, AxYIMAENCLib._DYimaEncEvents_OnBeginLButtonDownEvent e)
        {
            M_POINT mMouseScrnPo = new M_POINT(e.pointX, e.pointY);//鼠标屏幕位置
            M_POINT mMouseGeoPo = new M_POINT();//鼠标经纬度位置
            this.ymEncCtrl.GetGeoPoFromScrnPo(mMouseScrnPo.x, mMouseScrnPo.y, ref mMouseGeoPo.x, ref mMouseGeoPo.y);
            if (this.ymEncCtrl.ToolIsNoOperate())
            {
                this.ymEncCtrl.ToolClearCache();
            }
            //鼠标操作船舶
            if (currentMouseShip != null)
            {
                if (m_shipOperatorStatus == 1)
                {
                    currentMouseShip.SetCurGeoPos(this.ymEncCtrl, mMouseGeoPo.x, mMouseGeoPo.y,true);
                    currentMouseShip.shipID = shipList.Count;//设置船索引ID
                    shipList.Add(currentMouseShip);
                    currentMouseShip = null;
                    m_shipOperatorStatus = 0;
                    RedrawMapScreen();
                }
            }

            //鼠标操作雷达
            if(currentMouseRadar != null)
            {
                if(m_radarOperatorStatus == 1)
                {
                    currentMouseRadar.radarGeoPosX = mMouseGeoPo.x;
                    currentMouseRadar.radarGeoPosY = mMouseGeoPo.y;
                    //添加雷达物标
                    this.ymEncCtrl.tmAppendObjectInLayer(0, (int)M_GEO_TYPE.TYPE_POINT);
                    currentMouseRadar.radarMapPos = this.ymEncCtrl.tmGetLayerObjectCount(0) - 1;
                    this.ymEncCtrl.tmSetPointObjectCoor(0, currentMouseRadar.radarMapPos, currentMouseRadar.radarGeoPosX, currentMouseRadar.radarGeoPosY);
                    this.ymEncCtrl.tmSetPointObjectStyleRefLib(0, currentMouseRadar.radarMapPos, 57, false, 0, 1, 0);
                    this.ymEncCtrl.tmSetObjectAttrValueString(0, currentMouseRadar.radarMapPos, 0, "11");
                    //设置ym雷达对象
                    currentMouseRadar.radarMapID = this.ymEncCtrl.AddOneRadar();
                    //通过雷达ID获取雷达POS
                    int radarMapPos = ymEncCtrl.GetRadarPosById(currentMouseRadar.radarMapID); 
                    //设置雷达显示状态 bShowOrNot:(in) 是否显示雷达 bShowAllInfoOrFadingColor: (in) 完全显示或者余晖效果
                    if(currentMouseRadar.radarUseOrNot == 1)
                    {
                        ymEncCtrl.SetRadarShowState(radarMapPos, true, Convert.ToBoolean(currentMouseRadar.radarShowType));
                    }
                    else
                    {
                        ymEncCtrl.SetRadarShowState(radarMapPos, false, Convert.ToBoolean(currentMouseRadar.radarShowType));
                    }
                    //雷达扫描半径 千米*1000/512 = 节点间距
                    //int radarWidth = (int)(currentMouseRadar.radarScanRadius * 1000 / (Common.SCAN_LINE_NODE_NUM * 1.0));
                    //设置雷达基础信息，扫描线密度，节点数量，节点间距，雷达整体颜色
                    this.ymEncCtrl.SetRadarBaseInfo(radarMapPos, Common.SCAN_LINE_NUM, Common.SCAN_LINE_NODE_NUM, (int)currentMouseRadar.radarScanRadius, Color.Red.ToArgb());
                    //设置雷达的位置
                    this.ymEncCtrl.SetRadarCenterGeoPo(radarMapPos, currentMouseRadar.radarGeoPosX, currentMouseRadar.radarGeoPosY);
                    radarList.Add(currentMouseRadar);
                    currentMouseRadar = null;
                    m_radarOperatorStatus = 0;
                    RedrawMapScreen();
                }
            }

            //鼠标操作AIS
            if(currentMouseAis != null)
            {
                if (m_aisOperatorStatus == 1)
                {
                    currentMouseAis.aisGeoPosX = mMouseGeoPo.x;
                    currentMouseAis.aisGeoPosY = mMouseGeoPo.y;
                    //添加AIS基站物标
                    this.ymEncCtrl.tmAppendObjectInLayer(1, (int)M_GEO_TYPE.TYPE_POINT);
                    currentMouseAis.aisMapPos = this.ymEncCtrl.tmGetLayerObjectCount(1) - 1;
                    this.ymEncCtrl.tmSetPointObjectCoor(1, currentMouseAis.aisMapPos, currentMouseAis.aisGeoPosX, currentMouseAis.aisGeoPosY);
                    //物标样式
                    this.ymEncCtrl.tmSetPointObjectStyleRefLib(1, currentMouseAis.aisMapPos, 64, false, 0, 1, 0);
                    //物标属性值
                    this.ymEncCtrl.tmSetObjectAttrValueString(1, currentMouseAis.aisMapPos, 0, "22");
                    currentMouseAis.aisPixelRadius = ymEncCtrl.GetScrnLenFromGeoLen((float)(currentMouseAis.aisScanRadius * 1000 * 1000));
                    aisList.Add(currentMouseAis);
                    currentMouseAis = null;
                    m_aisOperatorStatus = 0;
                    RedrawMapScreen();
                }
            }
        }

        private void ymEncCtrl_OnBeginLButtonUp(object sender, AxYIMAENCLib._DYimaEncEvents_OnBeginLButtonUpEvent e)
        {
            this.m_bOnMouseDown = false;
        }

        private void ymEncCtrl_OnBeginMouseWheel(object sender, AxYIMAENCLib._DYimaEncEvents_OnBeginMouseWheelEvent e)
        {
            float curScale = this.ymEncCtrl.GetCurrentScale();

            if (curScale < 10000)
            {
                this.ymEncCtrl.SetDisplayCategory((short)DISPLAY_CATEGORY_NUM.DISPLAY_ALL);
            }
            else if (curScale < 500000)
            {
                this.ymEncCtrl.SetDisplayCategory((short)DISPLAY_CATEGORY_NUM.DISPLAY_STANDARD);
            }
            else
            {
                this.ymEncCtrl.SetDisplayCategory((short)DISPLAY_CATEGORY_NUM.DISPLAY_BASE);
            }

            TSSL_Scale.Text = "比例尺:( 1:" + ((int)curScale).ToString()+")";
        }

        private void ymEncCtrl_OnBeginMouseMove(object sender, AxYIMAENCLib._DYimaEncEvents_OnBeginMouseMoveEvent e)
        {
            M_POINT mMouseScrnPo = new M_POINT(e.pointX, e.pointY);//鼠标屏幕位置
            M_POINT mMouseGeoPo = new M_POINT();//鼠标经纬度位置

            this.ymEncCtrl.GetGeoPoFromScrnPo(mMouseScrnPo.x, mMouseScrnPo.y, ref mMouseGeoPo.x, ref mMouseGeoPo.y);

            string strLon = InteropEncDotNet.GetDegreeStringFromGeoCoor_new(true, mMouseGeoPo.x, UNI_GEO_COOR_MULTI_FACTOR, 3);
            string strLat = InteropEncDotNet.GetDegreeStringFromGeoCoor_new(false, mMouseGeoPo.y, UNI_GEO_COOR_MULTI_FACTOR, 3);
            string strLonLat = "";
            strLonLat += "经度:" + Convert.ToDouble(mMouseGeoPo.x * 1.0 / UNI_GEO_COOR_MULTI_FACTOR);
            strLonLat += ",纬度:" + Convert.ToDouble(mMouseGeoPo.y * 1.0 / UNI_GEO_COOR_MULTI_FACTOR);
            this.toolStripStatusLabel_lonlat.Text = strLonLat;
        }

        private void ymEncCtrl_OnBeginRButtonDown(object sender, AxYIMAENCLib._DYimaEncEvents_OnBeginRButtonDownEvent e)
        {
            M_POINT mMouseScrnPo = new M_POINT(e.pointX, e.pointY);//鼠标屏幕位置
            M_POINT mMouseGeoPo = new M_POINT();//鼠标经纬度位置
            this.ymEncCtrl.GetGeoPoFromScrnPo(mMouseScrnPo.x, mMouseScrnPo.y, ref mMouseGeoPo.x, ref mMouseGeoPo.y);

            float curScale = this.ymEncCtrl.GetCurrentScale();
            if (curScale < this.m_iStartBigShipSignScale)
            {
                //轨迹回访时不显示右键菜单
                if (ISTrackPlayRun == false)
                {
                    //是否选中船舶
                    ShowShipInfoByMouseMove(mMouseScrnPo);

                    //是否选中雷达
                    ShowRadarBoxByMouseMove(mMouseScrnPo, mMouseGeoPo, Common.MOUSE_MOVE_POINT_DISTANCE);

                    //是否选中AIS
                    ShowAisBoxByMouseMove(mMouseScrnPo, mMouseGeoPo, Common.MOUSE_MOVE_POINT_DISTANCE);
                }
            }
        }

        private void ymEncCtrl_AfterDrawMap(object sender, AxYIMAENCLib._DYimaEncEvents_AfterDrawMapEvent e)
        {
            //绘制船
            foreach (CShip ship in shipList.ToArray())
            {
                if (ship.shipUseOrNot > 0)
                {
                    ship.Show(this.ymEncCtrl, false, 0, 0);
                }
            }
        }
        #endregion

        /// <summary>
        /// 添加船舶
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_AddShip_Click(object sender, EventArgs e)
		{
            if (currentMouseShip != null)
            {
                currentMouseShip = null;
            }

            ShipAddForm addShipDialog = new ShipAddForm(shipTypeList,null);
            addShipDialog.ShowDialog();

            //确定添加
            if(addShipDialog.DialogResult == DialogResult.OK)
            {
                CShip ship = CheckUtils.checkIsAddedShipByMMSI(long.Parse(addShipDialog.shipmmsi.Text),shipList);
                if (ship != null)
                {
                    //已添加船
                    this.ymEncCtrl.CenterMap((int)ship.shipLatitude, (int)ship.shipLongitude);
                    RedrawMapScreen();
                }
                else
                {
                    //新添加
                    currentMouseShip = new CShip(Convert.ToInt32(addShipDialog.shipmmsi.Text), addShipDialog.shipname.Text, addShipDialog.currentShipType, Convert.ToDouble(addShipDialog.shipcourse.Text), Convert.ToDouble(addShipDialog.shipheading.Text), 0, 0);
                    //状态1添加船
                    m_shipOperatorStatus = 1;
                }
            }
        }

        /// <summary>
        /// 添加雷达
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_AddRadar_Click(object sender, EventArgs e)
		{
            if (currentMouseRadar != null)
            {
                currentMouseRadar = null;
            }

            RadarAddForm addRadarDialog = new RadarAddForm(null);
            addRadarDialog.ShowDialog();

            //确定添加
            if (addRadarDialog.DialogResult == DialogResult.OK)
            {
                CRadar radar = CheckUtils.checkIsAddedRadarByRadarName(addRadarDialog.m_radarName.Text,radarList);
                if (radar != null)
                {
                    //已添加雷达
                    this.ymEncCtrl.CenterMap((int)radar.radarGeoPosX, (int)radar.radarGeoPosY);
                    RedrawMapScreen();
                }
                else
                {
                    //新添加雷达
                    int radarID = radarList.Count;
                    currentMouseRadar = new CRadar();
                    currentMouseRadar.radarShowType = addRadarDialog.showType;
                    currentMouseRadar.radarShowColor = addRadarDialog.showColor;
                    currentMouseRadar.radarPixelRadius = ymEncCtrl.GetScrnLenFromGeoLen((float)(currentMouseRadar.radarScanRadius * 1000 * 1000));
                    m_radarOperatorStatus = 1;
                }
            }
        }

        /// <summary>
        /// 添加AIS基站
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_AddAis_Click(object sender, EventArgs e)
		{
            if (currentMouseAis != null)
            {
                currentMouseAis = null;
            }

            AISAddForm addAisDialog = new AISAddForm(null);
            addAisDialog.ShowDialog();
            //确定添加
            if (addAisDialog.DialogResult == DialogResult.OK)
            {
                CAis ais = CheckUtils.checkIsAddedAisByAisName(addAisDialog.m_aisName.Text, aisList);
                if (ais != null)
                {
                    //已添加Ais
                    this.ymEncCtrl.CenterMap((int)ais.aisGeoPosX, (int)ais.aisGeoPosY);
                    RedrawMapScreen();
                }
                else
                {
                    //新添加Ais
                    int AisID = aisList.Count;
                    currentMouseAis = new CAis(AisID, addAisDialog.m_aisName.Text, Convert.ToInt32(addAisDialog.m_aisScanRadius.Text),Convert.ToInt32(addAisDialog.m_aisGeoPosX.Text), Convert.ToInt32(addAisDialog.m_aisGeoPosY.Text),addAisDialog.useOrNot);
                    m_aisOperatorStatus = 1;
                }
            }
        }

        /// <summary>
        /// 绘制电子方位线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_EBL_Click(object sender, EventArgs e)
		{
            bool bRetOk = this.ymEncCtrl.ToolMapMeasure((int)M_TOOl_TYPE.TYPE_EBL);
            if (bRetOk == false)
            {
                MessageBox.Show("请先退出其他操作！");
            }
        }

        /// <summary>
        /// 启动或者关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(shipList.Count == 0)
            {
                MessageBox.Show("请先添加船舶，雷达和AIS基站！");
                return;
            }
            if(m_GlobalRunStatus == 0)
            {
                this.StartOrStop.Image = Properties.Resources.stop;
                this.StartOrStop.Text = "停止";
                m_GlobalRunStatus = 1;
            }
            else if(m_GlobalRunStatus == 1)
            {
                //已经启动，需要停止
                this.StartOrStop.Image = Properties.Resources.start;
                this.StartOrStop.Text = "启动";
                m_GlobalRunStatus = 2;
            }
            else if (m_GlobalRunStatus == 2)
            {
                //已经停止，需要启动
                this.StartOrStop.Image = Properties.Resources.stop;
                this.StartOrStop.Text = "停止";
                m_GlobalRunStatus = 1;
            }
        }

        /// <summary>
        /// 开始轨迹回放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 开始回放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool status = this.开始回放ToolStripMenuItem.Checked;
            if(status == false)
            {
                this.开始回放ToolStripMenuItem.Checked = true;
                this.StartOrStop.Enabled = false;
                this.StartOrStop.Image = Properties.Resources.start;
                this.StartOrStop.Text = "启动";
                m_GlobalRunStatus = 2;
                ISTrackPlayRun = true; //设置轨迹回放启动状态
                //遍历开启船舶的轨迹回放
                foreach (CShip ship in shipList.ToArray())
                {
                    //开始轨迹回放
                    ship.StartTrackPlay(this.ymEncCtrl);
                }
                this.开始回放ToolStripMenuItem.Checked = true;
                this.停止回放ToolStripMenuItem.Checked = false;
            }
        }

        /// <summary>
        /// 停止轨迹回放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 停止回放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool status = this.停止回放ToolStripMenuItem.Checked;
            if (status == false)
            {
                this.StartOrStop.Image = Properties.Resources.stop;
                this.StartOrStop.Text = "停止";
                m_GlobalRunStatus = 1;
                //遍历开启船舶的轨迹回放
                foreach (CShip ship in shipList.ToArray())
                {
                    //开始轨迹回放
                    ship.StopTrackPlay();
                }
                ISTrackPlayRun = false; //设置轨迹回放启动状态
                this.StartOrStop.Enabled = true;
                this.停止回放ToolStripMenuItem.Checked = true;
                this.开始回放ToolStripMenuItem.Checked = false;
            }
            else
            {
                MessageBox.Show("未开启轨迹回放！");
            }
        }

        /// <summary>
        /// 通信设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 主通信设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SysConfig sysConfig = new SysConfig(config);
            sysConfig.ShowDialog();
            if(sysConfig.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("配置文件已经更改，重启ODU后新的配置文件将生效！");
            }
            if (MessageBox.Show("配置文件已更改，重启后生效，是否重启?", "确认", MessageBoxButtons.YesNo) == (System.Windows.Forms.DialogResult.Yes))
            {
                Application.Restart();
            }
            else
            {
                this.Close();
            }
        }

        /// <summary>
        /// 注册YimaEnc.ocx控件
        /// </summary>
        /// <returns></returns>
        private bool RegisterDll()
        {
            bool result = true;
            try
            {
                //获得要注册的dll的物理路径
                String dllPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "YimaEnc.ocx");
                if (!File.Exists(dllPath))
                {
                    MessageBox.Show(""+string.Format("“{0}”目录下无“XXX.dll”文件！", AppDomain.CurrentDomain.BaseDirectory));
                    return false;
                }
                //拼接命令参数
                String startArgs = string.Format("/s \"{0}\"", dllPath);

                Process p = new Process();//创建一个新进程，以执行注册动作
                p.StartInfo.FileName = "regsvr32";
                p.StartInfo.Arguments = startArgs;

                //以管理员权限注册dll文件
                WindowsIdentity winIdentity = WindowsIdentity.GetCurrent(); //引用命名空间 System.Security.Principal
                WindowsPrincipal winPrincipal = new WindowsPrincipal(winIdentity);
                if (!winPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
                {
                    p.StartInfo.Verb = "runas";//管理员权限运行
                }
                p.Start();
                p.WaitForExit();
                p.Close();
                p.Dispose();
            }
            catch (Exception ex)
            {
                result = false;
                //logger.Info("意玛注册控件失败！请手动注册YimaEnc.ocx！"+ ex.Message);
            }
            return result;
        }

        private void toolStripButton_ZoomIn_MouseMove_1(object sender, MouseEventArgs e)
        {
            this.toolStripButton_ZoomIn.Image = Properties.Resources.zoomIn21;
        }

        private void toolStripButton_ZoomIn_MouseLeave(object sender, EventArgs e)
        {
            this.toolStripButton_ZoomIn.Image = Properties.Resources.zoomIn11;
        }

        private void toolStripButton_ZoomOut_MouseMove(object sender, MouseEventArgs e)
        {
            this.toolStripButton_ZoomOut.Image = Properties.Resources.zoomOut21;
        }

        private void toolStripButton_ZoomOut_MouseLeave(object sender, EventArgs e)
        {
            this.toolStripButton_ZoomOut.Image = Properties.Resources.zoomOut11;
        }

        private void toolStripButton_MoveLeft_MouseMove(object sender, MouseEventArgs e)
        {
            this.toolStripButton_MoveLeft.Image = Properties.Resources.left21;
        }

        private void toolStripButton_MoveLeft_MouseLeave(object sender, EventArgs e)
        {
            this.toolStripButton_MoveLeft.Image = Properties.Resources.left11;
        }

        private void toolStripButton_MoveRight_MouseMove(object sender, MouseEventArgs e)
        {
            this.toolStripButton_MoveRight.Image = Properties.Resources.right21;
        }

        private void toolStripButton_MoveRight_MouseLeave(object sender, EventArgs e)
        {
            this.toolStripButton_MoveRight.Image = Properties.Resources.right11;
        }

        private void toolStripButton_MoveUp_MouseLeave(object sender, EventArgs e)
        {
            this.toolStripButton_MoveUp.Image = Properties.Resources.up11;
        }

        private void toolStripButton_MoveUp_MouseMove(object sender, MouseEventArgs e)
        {
            this.toolStripButton_MoveUp.Image = Properties.Resources.up21;
        }

        private void toolStripButton_MoveDown_MouseMove(object sender, MouseEventArgs e)
        {
            this.toolStripButton_MoveDown.Image = Properties.Resources.down21;
        }

        private void toolStripButton_MoveDown_MouseLeave(object sender, EventArgs e)
        {
            this.toolStripButton_MoveDown.Image = Properties.Resources.down11;
        }

        private void toolStripButton_ZoomByRect_MouseMove(object sender, MouseEventArgs e)
        {
            this.toolStripButton_ZoomByRect.Image = Properties.Resources.dingwei21;
        }

        private void toolStripButton_ZoomByRect_MouseLeave(object sender, EventArgs e)
        {
            this.toolStripButton_ZoomByRect.Image = Properties.Resources.dingwei11;
        }

        private void toolStripButton_LibMapMan_MouseMove(object sender, MouseEventArgs e)
        {
            this.toolStripButton_LibMapMan.Image = Properties.Resources.wenjian21;
        }

        private void toolStripButton_LibMapMan_MouseLeave(object sender, EventArgs e)
        {
            this.toolStripButton_LibMapMan.Image = Properties.Resources.wenjian11;
        }

        private void toolStripButton_DrawEBL_MouseMove(object sender, MouseEventArgs e)
        {
            this.toolStripButton_DrawEBL.Image = Properties.Resources.jiasuan22;
        }

        private void toolStripButton_DrawEBL_MouseLeave(object sender, EventArgs e)
        {
            this.toolStripButton_DrawEBL.Image = Properties.Resources.jiasuan11;
        }

        private void aIS数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AisList aisList = new AisList();
            aisList.ShowDialog();
        }

        private void DataGridView_ShipList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int iRowPos = e.RowIndex;
            if (iRowPos > -1)
            {
                int longitude = (int)this.dataGridView_ShipList.Rows[iRowPos].Cells[1].Value;
                int latitude = (int)this.dataGridView_ShipList.Rows[iRowPos].Cells[2].Value;
                ymEncCtrl.CenterMap(latitude, longitude);
                RedrawMapScreen();
            }
        }

        private void DataGridView_RadarList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int iRowPos = e.RowIndex;
            if (iRowPos > -1)
            {
                int longitude = (int)this.dataGridView_RadarList.Rows[iRowPos].Cells[1].Value;
                int latitude = (int)this.dataGridView_RadarList.Rows[iRowPos].Cells[2].Value;
                ymEncCtrl.CenterMap(longitude, latitude);
                RedrawMapScreen();
            }
        }
    }
}

