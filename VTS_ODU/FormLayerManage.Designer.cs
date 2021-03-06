﻿namespace vts_odu
{
    partial class FormLayerManage
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
            this.lb_layersInfo = new System.Windows.Forms.ListBox();
            this.btn_allDisplay = new System.Windows.Forms.Button();
            this.btn_allHide = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.cb_isDisplay = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lb_layersInfo
            // 
            this.lb_layersInfo.FormattingEnabled = true;
            this.lb_layersInfo.ItemHeight = 12;
            this.lb_layersInfo.Location = new System.Drawing.Point(12, 12);
            this.lb_layersInfo.Name = "lb_layersInfo";
            this.lb_layersInfo.Size = new System.Drawing.Size(251, 340);
            this.lb_layersInfo.TabIndex = 0;
            this.lb_layersInfo.SelectedIndexChanged += new System.EventHandler(this.lb_layersInfo_SelectedIndexChanged);
            // 
            // btn_allDisplay
            // 
            this.btn_allDisplay.Location = new System.Drawing.Point(269, 113);
            this.btn_allDisplay.Name = "btn_allDisplay";
            this.btn_allDisplay.Size = new System.Drawing.Size(75, 23);
            this.btn_allDisplay.TabIndex = 1;
            this.btn_allDisplay.Text = "全部显示";
            this.btn_allDisplay.UseVisualStyleBackColor = true;
            this.btn_allDisplay.Click += new System.EventHandler(this.btn_allDisplay_Click);
            // 
            // btn_allHide
            // 
            this.btn_allHide.Location = new System.Drawing.Point(269, 142);
            this.btn_allHide.Name = "btn_allHide";
            this.btn_allHide.Size = new System.Drawing.Size(75, 23);
            this.btn_allHide.TabIndex = 2;
            this.btn_allHide.Text = "全部隐藏";
            this.btn_allHide.UseVisualStyleBackColor = true;
            this.btn_allHide.Click += new System.EventHandler(this.btn_allHide_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(271, 329);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // cb_isDisplay
            // 
            this.cb_isDisplay.AutoSize = true;
            this.cb_isDisplay.Location = new System.Drawing.Point(283, 79);
            this.cb_isDisplay.Name = "cb_isDisplay";
            this.cb_isDisplay.Size = new System.Drawing.Size(48, 16);
            this.cb_isDisplay.TabIndex = 5;
            this.cb_isDisplay.Text = "显示";
            this.cb_isDisplay.UseVisualStyleBackColor = true;
            this.cb_isDisplay.CheckedChanged += new System.EventHandler(this.cb_isDisplay_CheckedChanged);
            // 
            // FormLayerManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 370);
            this.Controls.Add(this.cb_isDisplay);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_allHide);
            this.Controls.Add(this.btn_allDisplay);
            this.Controls.Add(this.lb_layersInfo);
            this.Name = "FormLayerManage";
            this.Text = "图层信息";
            this.Load += new System.EventHandler(this.FormLayerManage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_layersInfo;
        private System.Windows.Forms.Button btn_allDisplay;
        private System.Windows.Forms.Button btn_allHide;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.CheckBox cb_isDisplay;
    }
}