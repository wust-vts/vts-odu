﻿namespace vts_odu
{
    partial class UserMapObjectAttributesDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMapObjectAttributesDlg));
            this.OkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.layerNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.geoTypeText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.axMSFlexGrid1 = new AxMSFlexGridLib.AxMSFlexGrid();
            this.btn_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axMSFlexGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(359, 61);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(65, 26);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "确定";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "所属图层：";
            // 
            // layerNameText
            // 
            this.layerNameText.Location = new System.Drawing.Point(86, 15);
            this.layerNameText.Name = "layerNameText";
            this.layerNameText.Size = new System.Drawing.Size(138, 21);
            this.layerNameText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "地理类型：";
            // 
            // geoTypeText
            // 
            this.geoTypeText.Location = new System.Drawing.Point(311, 14);
            this.geoTypeText.Name = "geoTypeText";
            this.geoTypeText.Size = new System.Drawing.Size(110, 21);
            this.geoTypeText.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // axMSFlexGrid1
            // 
            this.axMSFlexGrid1.Location = new System.Drawing.Point(12, 165);
            this.axMSFlexGrid1.Name = "axMSFlexGrid1";
            this.axMSFlexGrid1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMSFlexGrid1.OcxState")));
            this.axMSFlexGrid1.Size = new System.Drawing.Size(419, 187);
            this.axMSFlexGrid1.TabIndex = 4;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(359, 125);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(65, 23);
            this.btn_del.TabIndex = 6;
            this.btn_del.Text = "删除";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Visible = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // UserMapObjectAttributesDlg
            // 
            this.ClientSize = new System.Drawing.Size(442, 364);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axMSFlexGrid1);
            this.Controls.Add(this.geoTypeText);
            this.Controls.Add(this.layerNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OkButton);
            this.Name = "UserMapObjectAttributesDlg";
            this.ShowInTaskbar = false;
            this.Text = "编辑自定义海图对象";
            this.Load += new System.EventHandler(this.UserMapObjectAttributesDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axMSFlexGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label[] labels;
        private System.Windows.Forms.TextBox[] textBoxs;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox layerNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox geoTypeText;
        private AxMSFlexGridLib.AxMSFlexGrid axMSFlexGrid1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_del;
    }
}