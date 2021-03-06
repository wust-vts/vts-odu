﻿namespace vts_odu
{
    partial class Form_MapLayerMan
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
            this.groupBox_Rcd = new System.Windows.Forms.GroupBox();
            this.dataGridView_List = new System.Windows.Forms.DataGridView();
            this.pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDisplay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_HiddenAllLayer = new System.Windows.Forms.Button();
            this.btn_DrawAllLayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SelName = new System.Windows.Forms.TextBox();
            this.groupBox_Rcd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Rcd
            // 
            this.groupBox_Rcd.Controls.Add(this.dataGridView_List);
            this.groupBox_Rcd.Location = new System.Drawing.Point(0, 36);
            this.groupBox_Rcd.Name = "groupBox_Rcd";
            this.groupBox_Rcd.Size = new System.Drawing.Size(548, 439);
            this.groupBox_Rcd.TabIndex = 14;
            this.groupBox_Rcd.TabStop = false;
            this.groupBox_Rcd.Text = "当前图层数量(36个)";
            // 
            // dataGridView_List
            // 
            this.dataGridView_List.AllowUserToAddRows = false;
            this.dataGridView_List.AllowUserToDeleteRows = false;
            this.dataGridView_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pos,
            this.LayerName,
            this.isDisplay});
            this.dataGridView_List.Location = new System.Drawing.Point(6, 20);
            this.dataGridView_List.Name = "dataGridView_List";
            this.dataGridView_List.RowHeadersVisible = false;
            this.dataGridView_List.RowTemplate.Height = 23;
            this.dataGridView_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_List.Size = new System.Drawing.Size(536, 410);
            this.dataGridView_List.TabIndex = 0;
            this.dataGridView_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_List_CellContentClick);
            this.dataGridView_List.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_List_CellDoubleClick);
            // 
            // pos
            // 
            this.pos.HeaderText = "索引";
            this.pos.Name = "pos";
            this.pos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pos.Width = 80;
            // 
            // LayerName
            // 
            this.LayerName.HeaderText = "图层名称";
            this.LayerName.Name = "LayerName";
            this.LayerName.ReadOnly = true;
            this.LayerName.Width = 300;
            // 
            // isDisplay
            // 
            this.isDisplay.HeaderText = "是否显示";
            this.isDisplay.Name = "isDisplay";
            this.isDisplay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isDisplay.Width = 130;
            // 
            // btn_HiddenAllLayer
            // 
            this.btn_HiddenAllLayer.Location = new System.Drawing.Point(459, 6);
            this.btn_HiddenAllLayer.Name = "btn_HiddenAllLayer";
            this.btn_HiddenAllLayer.Size = new System.Drawing.Size(75, 23);
            this.btn_HiddenAllLayer.TabIndex = 13;
            this.btn_HiddenAllLayer.Text = "全部隐藏";
            this.btn_HiddenAllLayer.UseVisualStyleBackColor = true;
            this.btn_HiddenAllLayer.Click += new System.EventHandler(this.btn_DrawAllLayer_Click);
            // 
            // btn_DrawAllLayer
            // 
            this.btn_DrawAllLayer.Location = new System.Drawing.Point(371, 6);
            this.btn_DrawAllLayer.Name = "btn_DrawAllLayer";
            this.btn_DrawAllLayer.Size = new System.Drawing.Size(75, 23);
            this.btn_DrawAllLayer.TabIndex = 12;
            this.btn_DrawAllLayer.Text = "全部显示";
            this.btn_DrawAllLayer.UseVisualStyleBackColor = true;
            this.btn_DrawAllLayer.Click += new System.EventHandler(this.btn_DrawAllLayer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "图层名称:";
            // 
            // textBox_SelName
            // 
            this.textBox_SelName.Location = new System.Drawing.Point(71, 8);
            this.textBox_SelName.Name = "textBox_SelName";
            this.textBox_SelName.Size = new System.Drawing.Size(294, 21);
            this.textBox_SelName.TabIndex = 10;
            this.textBox_SelName.TextChanged += new System.EventHandler(this.textBox_SelName_TextChanged);
            // 
            // Form_MapLayerMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 473);
            this.Controls.Add(this.groupBox_Rcd);
            this.Controls.Add(this.btn_HiddenAllLayer);
            this.Controls.Add(this.btn_DrawAllLayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_SelName);
            this.Name = "Form_MapLayerMan";
            this.Text = "图层管理";
            this.Load += new System.EventHandler(this.Form_MapLayerMan_Load);
            this.groupBox_Rcd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Rcd;
        private System.Windows.Forms.DataGridView dataGridView_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn LayerName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDisplay;
        private System.Windows.Forms.Button btn_HiddenAllLayer;
        private System.Windows.Forms.Button btn_DrawAllLayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_SelName;
    }
}