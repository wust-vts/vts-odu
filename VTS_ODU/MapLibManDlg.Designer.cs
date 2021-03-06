﻿namespace vts_odu
{
    partial class MapLibManDlg
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
            this.mapLibList = new System.Windows.Forms.ListBox();
            this.LoadMapFileToLibButton = new System.Windows.Forms.Button();
            this.DeleteMapButton = new System.Windows.Forms.Button();
            this.OverViewMapButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OrgScaleText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.editionText = new System.Windows.Forms.TextBox();
            this.upMostText = new System.Windows.Forms.TextBox();
            this.downMostText = new System.Windows.Forms.TextBox();
            this.leftMostText = new System.Windows.Forms.TextBox();
            this.rightMostText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_UpdateNum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapLibList
            // 
            this.mapLibList.FormattingEnabled = true;
            this.mapLibList.ItemHeight = 12;
            this.mapLibList.Location = new System.Drawing.Point(19, 36);
            this.mapLibList.Name = "mapLibList";
            this.mapLibList.Size = new System.Drawing.Size(154, 232);
            this.mapLibList.TabIndex = 0;
            this.mapLibList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mapLibList_MouseDoubleClick);
            this.mapLibList.SelectedIndexChanged += new System.EventHandler(this.mapLibList_SelectedIndexChanged);
            // 
            // LoadMapFileToLibButton
            // 
            this.LoadMapFileToLibButton.Location = new System.Drawing.Point(199, 164);
            this.LoadMapFileToLibButton.Name = "LoadMapFileToLibButton";
            this.LoadMapFileToLibButton.Size = new System.Drawing.Size(62, 21);
            this.LoadMapFileToLibButton.TabIndex = 1;
            this.LoadMapFileToLibButton.Text = "加载..";
            this.LoadMapFileToLibButton.UseVisualStyleBackColor = true;
            this.LoadMapFileToLibButton.Click += new System.EventHandler(this.LoadMapFileToLibButton_Click);
            // 
            // DeleteMapButton
            // 
            this.DeleteMapButton.Location = new System.Drawing.Point(199, 189);
            this.DeleteMapButton.Name = "DeleteMapButton";
            this.DeleteMapButton.Size = new System.Drawing.Size(62, 21);
            this.DeleteMapButton.TabIndex = 2;
            this.DeleteMapButton.Text = "删除";
            this.DeleteMapButton.UseVisualStyleBackColor = true;
            this.DeleteMapButton.Click += new System.EventHandler(this.DeleteMapButton_Click);
            // 
            // OverViewMapButton
            // 
            this.OverViewMapButton.Location = new System.Drawing.Point(199, 214);
            this.OverViewMapButton.Name = "OverViewMapButton";
            this.OverViewMapButton.Size = new System.Drawing.Size(62, 21);
            this.OverViewMapButton.TabIndex = 3;
            this.OverViewMapButton.Text = "概览";
            this.OverViewMapButton.UseVisualStyleBackColor = true;
            this.OverViewMapButton.Click += new System.EventHandler(this.OverviewMapButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "原始比例尺：";
            // 
            // OrgScaleText
            // 
            this.OrgScaleText.Location = new System.Drawing.Point(375, 58);
            this.OrgScaleText.Name = "OrgScaleText";
            this.OrgScaleText.Size = new System.Drawing.Size(187, 21);
            this.OrgScaleText.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "版本号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "上边：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "下边：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "左边：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "右边：";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            // 
            // editionText
            // 
            this.editionText.Location = new System.Drawing.Point(375, 87);
            this.editionText.Name = "editionText";
            this.editionText.Size = new System.Drawing.Size(187, 21);
            this.editionText.TabIndex = 11;
            // 
            // upMostText
            // 
            this.upMostText.Location = new System.Drawing.Point(71, 20);
            this.upMostText.Name = "upMostText";
            this.upMostText.Size = new System.Drawing.Size(203, 21);
            this.upMostText.TabIndex = 12;
            // 
            // downMostText
            // 
            this.downMostText.Location = new System.Drawing.Point(71, 48);
            this.downMostText.Name = "downMostText";
            this.downMostText.Size = new System.Drawing.Size(203, 21);
            this.downMostText.TabIndex = 13;
            // 
            // leftMostText
            // 
            this.leftMostText.Location = new System.Drawing.Point(71, 74);
            this.leftMostText.Name = "leftMostText";
            this.leftMostText.Size = new System.Drawing.Size(203, 21);
            this.leftMostText.TabIndex = 14;
            // 
            // rightMostText
            // 
            this.rightMostText.Location = new System.Drawing.Point(71, 102);
            this.rightMostText.Name = "rightMostText";
            this.rightMostText.Size = new System.Drawing.Size(203, 21);
            this.rightMostText.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "升级版本号：";
            // 
            // tb_UpdateNum
            // 
            this.tb_UpdateNum.Location = new System.Drawing.Point(375, 116);
            this.tb_UpdateNum.Name = "tb_UpdateNum";
            this.tb_UpdateNum.Size = new System.Drawing.Size(187, 21);
            this.tb_UpdateNum.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rightMostText);
            this.groupBox1.Controls.Add(this.upMostText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.leftMostText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.downMostText);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(288, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 133);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 21);
            this.button1.TabIndex = 19;
            this.button1.Text = " 取消 ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MapLibManDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_UpdateNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.editionText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrgScaleText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OverViewMapButton);
            this.Controls.Add(this.DeleteMapButton);
            this.Controls.Add(this.LoadMapFileToLibButton);
            this.Controls.Add(this.mapLibList);
            this.Name = "MapLibManDlg";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "图库信息";
            this.Load += new System.EventHandler(this.MapLibManDlg_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox mapLibList;
        private System.Windows.Forms.Button LoadMapFileToLibButton;
        private System.Windows.Forms.Button DeleteMapButton;
        private System.Windows.Forms.Button OverViewMapButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OrgScaleText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox editionText;
        private System.Windows.Forms.TextBox upMostText;
        private System.Windows.Forms.TextBox downMostText;
        private System.Windows.Forms.TextBox leftMostText;
        private System.Windows.Forms.TextBox rightMostText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_UpdateNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}