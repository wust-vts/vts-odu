using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicLibrary;
using MySql.Data.MySqlClient;
using System.Net.Sockets;
using System.Net;

namespace vts_odu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SysConfigJson sysConfig = SysConfigJson.Parse();
            MySqlCustomHelper.Conn = "Database='vts';Data Source='"+ sysConfig.dataBase.dataBaseIp + "';User Id='"+ sysConfig.dataBase.dataBaseUser + "';Password='"+ sysConfig.dataBase.dataBasePass + "';charset='utf8';SslMode=none";
            string loginCommand = string.Format(@"select id,realName,role from userLogin where userName = '{0}' and passWord = '{1}'", userName.Text.Trim(),passWord.Text.Trim());
            MySqlDataReader resultReader = MySqlCustomHelper.ExecuteReader(MySqlCustomHelper.Conn,CommandType.Text, loginCommand, null);
            if(null == resultReader)
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
                    String clientID = System.Guid.NewGuid().ToString("N");
                    FormMain formMain = new FormMain(resultReader[0].ToString(), resultReader[1].ToString(), clientID, resultReader[2].ToString(), sysConfig);
                    formMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或者密码错误，请检查！");
                    passWord.Text = String.Empty;
                }
            }
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            userName.Focus();
        }

        private void SkinButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
