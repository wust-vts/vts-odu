﻿namespace vts_odu
{
    partial class GeoObjectInfoDlg
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
            this.ObjectAttrListCtrl = new System.Windows.Forms.ListBox();
            this.geoTypeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.layerNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ObjectAttrListCtrl
            // 
            this.ObjectAttrListCtrl.FormattingEnabled = true;
            this.ObjectAttrListCtrl.ItemHeight = 12;
            this.ObjectAttrListCtrl.Location = new System.Drawing.Point(39, 83);
            this.ObjectAttrListCtrl.Name = "ObjectAttrListCtrl";
            this.ObjectAttrListCtrl.Size = new System.Drawing.Size(382, 244);
            this.ObjectAttrListCtrl.TabIndex = 0;
            // 
            // geoTypeTextBox
            // 
            this.geoTypeTextBox.Location = new System.Drawing.Point(107, 37);
            this.geoTypeTextBox.Name = "geoTypeTextBox";
            this.geoTypeTextBox.Size = new System.Drawing.Size(314, 21);
            this.geoTypeTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "地理类型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "物标类别：";
            // 
            // layerNameTextBox
            // 
            this.layerNameTextBox.Location = new System.Drawing.Point(107, 12);
            this.layerNameTextBox.Name = "layerNameTextBox";
            this.layerNameTextBox.Size = new System.Drawing.Size(314, 21);
            this.layerNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "物标属性：";
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.closeButton.Location = new System.Drawing.Point(440, 302);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(70, 25);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "关闭";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // GeoObjectInfoDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 339);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.layerNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.geoTypeTextBox);
            this.Controls.Add(this.ObjectAttrListCtrl);
            this.Name = "GeoObjectInfoDlg";
            this.ShowInTaskbar = false;
            this.Text = "地理物标信息";
            this.Load += new System.EventHandler(this.GeoObjectInfoDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ObjectAttrListCtrl;
        private System.Windows.Forms.TextBox geoTypeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox layerNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button closeButton;
    }
}