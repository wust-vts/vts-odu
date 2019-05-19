namespace vts_odu
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnLogin = new CCWin.SkinControl.SkinButton();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.userName = new CCWin.SkinControl.SkinTextBox();
            this.passWord = new CCWin.SkinControl.SkinTextBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.btnLogin.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnLogin.DownBack = global::vts_odu.Properties.Resources.小按钮2选中_2x;
            this.btnLogin.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnLogin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(224, 292);
            this.btnLogin.MouseBack = global::vts_odu.Properties.Resources.小按钮2选中_2x;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormlBack = global::vts_odu.Properties.Resources.小按钮2未选中_2x;
            this.btnLogin.Size = new System.Drawing.Size(130, 36);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "登  录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel1.BackgroundImage")));
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(195, 150);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(96, 96);
            this.skinPanel1.TabIndex = 6;
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.Color.Transparent;
            this.userName.DownBack = null;
            this.userName.Icon = ((System.Drawing.Image)(resources.GetObject("userName.Icon")));
            this.userName.IconIsButton = false;
            this.userName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.userName.IsPasswordChat = '\0';
            this.userName.IsSystemPasswordChar = false;
            this.userName.Lines = new string[0];
            this.userName.Location = new System.Drawing.Point(354, 150);
            this.userName.Margin = new System.Windows.Forms.Padding(0);
            this.userName.MaxLength = 32767;
            this.userName.MinimumSize = new System.Drawing.Size(28, 28);
            this.userName.MouseBack = null;
            this.userName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.userName.Multiline = true;
            this.userName.Name = "userName";
            this.userName.NormlBack = null;
            this.userName.Padding = new System.Windows.Forms.Padding(5, 5, 51, 5);
            this.userName.ReadOnly = false;
            this.userName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userName.Size = new System.Drawing.Size(216, 30);
            // 
            // 
            // 
            this.userName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.userName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.userName.SkinTxt.Multiline = true;
            this.userName.SkinTxt.Name = "BaseText";
            this.userName.SkinTxt.Size = new System.Drawing.Size(160, 20);
            this.userName.SkinTxt.TabIndex = 0;
            this.userName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.userName.SkinTxt.WaterText = "用户名";
            this.userName.TabIndex = 5;
            this.userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.userName.WaterText = "用户名";
            this.userName.WordWrap = true;
            // 
            // passWord
            // 
            this.passWord.BackColor = System.Drawing.Color.Transparent;
            this.passWord.DownBack = null;
            this.passWord.Icon = ((System.Drawing.Image)(resources.GetObject("passWord.Icon")));
            this.passWord.IconIsButton = false;
            this.passWord.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.passWord.IsPasswordChat = '●';
            this.passWord.IsSystemPasswordChar = false;
            this.passWord.Lines = new string[0];
            this.passWord.Location = new System.Drawing.Point(354, 216);
            this.passWord.Margin = new System.Windows.Forms.Padding(0);
            this.passWord.MaxLength = 32767;
            this.passWord.MinimumSize = new System.Drawing.Size(28, 28);
            this.passWord.MouseBack = null;
            this.passWord.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.passWord.Multiline = true;
            this.passWord.Name = "passWord";
            this.passWord.NormlBack = null;
            this.passWord.Padding = new System.Windows.Forms.Padding(5, 5, 51, 5);
            this.passWord.ReadOnly = false;
            this.passWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passWord.Size = new System.Drawing.Size(216, 30);
            // 
            // 
            // 
            this.passWord.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passWord.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passWord.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.passWord.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.passWord.SkinTxt.Multiline = true;
            this.passWord.SkinTxt.Name = "BaseText";
            this.passWord.SkinTxt.PasswordChar = '●';
            this.passWord.SkinTxt.Size = new System.Drawing.Size(160, 20);
            this.passWord.SkinTxt.TabIndex = 0;
            this.passWord.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.passWord.SkinTxt.WaterText = "密码";
            this.passWord.TabIndex = 4;
            this.passWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passWord.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.passWord.WaterText = "密码";
            this.passWord.WordWrap = true;
            // 
            // skinButton1
            // 
            this.skinButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.skinButton1.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.skinButton1.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = global::vts_odu.Properties.Resources.小按钮2选中_2x;
            this.skinButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton1.ForeColor = System.Drawing.Color.Black;
            this.skinButton1.Location = new System.Drawing.Point(417, 292);
            this.skinButton1.MouseBack = global::vts_odu.Properties.Resources.小按钮2选中_2x;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = global::vts_odu.Properties.Resources.小按钮2未选中_2x;
            this.skinButton1.Size = new System.Drawing.Size(130, 36);
            this.skinButton1.TabIndex = 10;
            this.skinButton1.Text = "退  出";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.SkinButton1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.skinPanel1);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.passWord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "ODU登录";
            this.Activated += new System.EventHandler(this.Login_Activated);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinTextBox passWord;
        private CCWin.SkinControl.SkinTextBox userName;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinButton btnLogin;
        private CCWin.SkinControl.SkinButton skinButton1;
    }
}