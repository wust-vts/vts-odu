﻿namespace vts_odu
{
    partial class SelectedGeoObjectsDlg
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.m_selGeoObjectList = new System.Windows.Forms.ListBox();
            this.CloseForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // m_selGeoObjectList
            // 
            this.m_selGeoObjectList.FormattingEnabled = true;
            this.m_selGeoObjectList.ItemHeight = 12;
            this.m_selGeoObjectList.Location = new System.Drawing.Point(12, 14);
            this.m_selGeoObjectList.Name = "m_selGeoObjectList";
            this.m_selGeoObjectList.Size = new System.Drawing.Size(266, 232);
            this.m_selGeoObjectList.TabIndex = 0;
            this.m_selGeoObjectList.SelectedIndexChanged += new System.EventHandler(this.m_selGeoObjectList_SelectedIndexChanged);
            this.m_selGeoObjectList.DoubleClick += new System.EventHandler(this.m_selGeoObjectList_DoubleClick);
            // 
            // CloseForm
            // 
            this.CloseForm.Location = new System.Drawing.Point(287, 222);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(78, 24);
            this.CloseForm.TabIndex = 1;
            this.CloseForm.Text = "关闭";
            this.CloseForm.UseVisualStyleBackColor = true;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // SelectedGeoObjectsDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 263);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.m_selGeoObjectList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectedGeoObjectsDlg";
            this.ShowInTaskbar = false;
            this.Text = "选中物标";
            this.Load += new System.EventHandler(this.SelectedObjectDlg_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox m_selGeoObjectList;
        private System.Windows.Forms.Button CloseForm;
    }
}