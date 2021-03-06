﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace vts_odu
{
    public partial class Form_LibMapMan : Form
    {
        public Form_LibMapMan()
        {
            InitializeComponent();
        }

        private void Form_LibMapMan_Load(object sender, EventArgs e)
        {
            InitStyle();
            RefreshMapList("");
        }

        private void InitStyle()
        {
            DataGridView curDataGridView = this.dataGridView_MapList;

            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            curDataGridView.AllowUserToAddRows = false;
            curDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            curDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            curDataGridView.BackgroundColor = System.Drawing.Color.White;
            curDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            curDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;

            //头样式

            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            //dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            //dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            curDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            curDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            curDataGridView.EnableHeadersVisualStyles = false;
            curDataGridView.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            curDataGridView.ReadOnly = true;
            curDataGridView.RowHeadersVisible = false;
            //curDataGridView.RowTemplate.Height = 30;
            curDataGridView.RowTemplate.ReadOnly = true;
        }

        private void RefreshMapList(string strNameKey)
        {
            int iCurShowMapCount = 0;
            this.dataGridView_MapList.Rows.Clear();
            int iLibMapCount = ((FormMain)(this.Owner)).ymEncCtrl.GetLibMapCount();

            for (int i = 0; i < iLibMapCount; i++)
            {
                string retStrMapType = new string(' ', 255);
                string retStrMapName = new string(' ', 255);

                float retOriginalScale = 0;
                int retLeftMost = 0;
                int retRightMost = 0;
                int retUpMost = 0;
                int retDownMost = 0;
                int retEditionNum = 0;
                int retUpdateNum = 0;
                int retAgencyNum = 0;
                int retHdat = 0;
                int retVdat = 0;
                int retSdat = 0;
                string retStrMapFileName = new string(' ', 255);


                bool bResult = ((FormMain)(this.Owner)).ymEncCtrl.GetLibMapInfo(i, ref retStrMapType, ref retStrMapName, ref retOriginalScale,
                    ref retLeftMost, ref retRightMost, ref retUpMost, ref retDownMost, ref retEditionNum, ref retUpdateNum,
                    ref retAgencyNum, ref retHdat, ref retVdat, ref retSdat, ref retStrMapFileName);

                if (bResult)
                {
                    if (!strNameKey.Equals(""))
                    {
                        if (retStrMapName.ToUpper().IndexOf(strNameKey.ToUpper().Trim()) == -1)
                        {
                            continue;
                        }
                    }

                    AddRowToList(i, retStrMapName.Trim(), (int)retOriginalScale, retLeftMost, retRightMost, retDownMost, retUpMost, retEditionNum, retUpdateNum);
                    iCurShowMapCount++;
                }
            }

            this.groupBox_List.Text = "(当前查询的图幅数量：" + iCurShowMapCount.ToString()+")";
        }

        private void AddRowToList(int iMapPos, string strMapName, int iMapScale, int iMinGeoX, int iMaxGeoX,
            int iMinGeoY, int iMaxGeoY, int iMapNumber, int iMapUpdateNum)
        {
            //添加行
            int newRowIndex = this.dataGridView_MapList.Rows.Add();
            this.dataGridView_MapList.Rows[newRowIndex].Cells["mapPos"].Value = iMapPos;
            this.dataGridView_MapList.Rows[newRowIndex].Cells["mapName"].Value = strMapName;
            this.dataGridView_MapList.Rows[newRowIndex].Cells["mapScale"].Value = iMapScale;
            this.dataGridView_MapList.Rows[newRowIndex].Cells["mapMinLon"].Value = Math.Round((double)iMinGeoX / 10000000, 5);
            this.dataGridView_MapList.Rows[newRowIndex].Cells["mapMaxLon"].Value = Math.Round((double)iMaxGeoX / 10000000, 5);
            this.dataGridView_MapList.Rows[newRowIndex].Cells["mapMinLat"].Value = Math.Round((double)iMinGeoY / 10000000, 5);
            this.dataGridView_MapList.Rows[newRowIndex].Cells["mapMaxLat"].Value = Math.Round((double)iMinGeoY / 10000000, 5);
            this.dataGridView_MapList.Rows[newRowIndex].Cells["mapNumber"].Value = iMapNumber;
            this.dataGridView_MapList.Rows[newRowIndex].Cells["mapUpdateNum"].Value = iMapUpdateNum;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            RefreshMapList(this.textBox_MapNameKey.Text.Trim());
        }

        private void btn_AddS57Map_Click(object sender, EventArgs e)
        {

            string strKey = this.textBox_key.Text.Trim();
            int lKey = 0;
            if (!strKey.Equals(""))
            {
                try
                {
                    lKey = (int)Convert.ToDouble(strKey);
                    ((FormMain)this.Owner).ymEncCtrl.SetIfYmcFileNeedEncrypt(true);
                    ((FormMain)this.Owner).ymEncCtrl.SetYMCFileEncryptKey(lKey);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("请输入正确的加密密钥，一般为9位数字码");
                    ((FormMain)this.Owner).ymEncCtrl.SetIfYmcFileNeedEncrypt(false);
                    return;
                }
            }
            else
            {

            }

            int addToMapLibCount = 0;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileNames.ToString().Equals("") || openFileDialog1.FileNames.Length == 0)
            {
                return;
            }

            foreach (string fileNamePath in openFileDialog1.FileNames)
            {
                int iResult = ((FormMain)this.Owner).ymEncCtrl.AddMapToLib(fileNamePath);
                if (iResult == 0)
                {
                    addToMapLibCount++;
                }
            }

            this.textBox_MapNameKey.Text = "";
            RefreshMapList("");
            MessageBox.Show("导入完毕,共导入图幅数量为：" + addToMapLibCount);
        }

        private void btn_ViewMap_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_MapList.RowCount == 0)
            {
                MessageBox.Show("当前没有图幅，请先加载图幅.");
                return;
            }
            string strSelMapName = this.dataGridView_MapList.CurrentRow.Cells["mapName"].Value.ToString();

            int iMapPos = ((FormMain)(this.Owner)).ymEncCtrl.GetLibMapPosOfName(strSelMapName); //获取概览图幅的索引
            if (iMapPos > -1)
            {
                ((FormMain)(this.Owner)).ymEncCtrl.OverViewLibMap(iMapPos);
            }
            ((FormMain)(this.Owner)).RedrawMapScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strKey = this.textBox_key.Text.Trim();
            int lKey = 0;
            if (!strKey.Equals(""))
            {
                try
                {
                    lKey = (int)Convert.ToDouble(strKey);
                    ((FormMain)this.Owner).ymEncCtrl.SetIfYmcFileNeedEncrypt(true);
                    ((FormMain)this.Owner).ymEncCtrl.SetYMCFileEncryptKey(lKey);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("请输入正确的加密密钥，一般为9位数字码");
                    ((FormMain)this.Owner).ymEncCtrl.SetIfYmcFileNeedEncrypt(false);
                    return;
                }
            }
            else
            {
                MessageBox.Show("请输入正确的加密密钥，一般为9位数字码");
                ((FormMain)this.Owner).ymEncCtrl.SetIfYmcFileNeedEncrypt(false);
                return;
            }
        }

        private void btn_DelMap_Click(object sender, EventArgs e)
        {
            try
            {
                int index = this.dataGridView_MapList.CurrentRow.Index;
                int mapPos = Convert.ToInt32(this.dataGridView_MapList.CurrentRow.Cells["mapPos"].Value);

                if (mapPos > -1)
                {
                    ((FormMain)this.Owner).ymEncCtrl.DeleteLibMap(mapPos);
                    RefreshMapList(this.textBox_MapNameKey.Text.Trim());
                    ((FormMain)this.Owner).RedrawMapScreen();
                    if(index > 0)
                    {
                        this.dataGridView_MapList.Rows[index - 1].Selected = true;
                    }
                    
                }
            }
            catch (Exception)
            { 
            
            }            
        }

        private void dataGridView_MapList_DoubleClick(object sender, EventArgs e)
        {
            string strSelMapName = this.dataGridView_MapList.CurrentRow.Cells["mapName"].Value.ToString();
            int iMapPos = ((FormMain)(this.Owner)).ymEncCtrl.GetLibMapPosOfName(strSelMapName); //获取概览图幅的索引
            if (iMapPos > -1)
            {
                ((FormMain)(this.Owner)).ymEncCtrl.OverViewLibMap(iMapPos);
            }
            ((FormMain)(this.Owner)).RedrawMapScreen();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strKey = this.textBox_key.Text.Trim();
            int lKey = 0;
            if (!strKey.Equals(""))
            {
                try
                {
                    lKey = (int)Convert.ToDouble(strKey);
                    ((FormMain)this.Owner).ymEncCtrl.SetIfYmcFileNeedEncrypt(true);
                    ((FormMain)this.Owner).ymEncCtrl.SetYMCFileEncryptKey(lKey);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("请输入正确的加密密钥，一般为9位数字码");
                    ((FormMain)this.Owner).ymEncCtrl.SetIfYmcFileNeedEncrypt(false);
                    return;
                }
            }
            else
            {

            }

            int addToMapLibCount = 0;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileNames.ToString().Equals("") || openFileDialog1.FileNames.Length == 0)
            {
                return;
            }

            foreach (string fileNamePath in openFileDialog1.FileNames)
            {
                int iResult = ((FormMain)this.Owner).ymEncCtrl.AddMapToLib(fileNamePath);
                if (iResult == 0)
                {
                    addToMapLibCount++;
                }
            }

            this.textBox_MapNameKey.Text = "";
            RefreshMapList("");
            MessageBox.Show("导入完毕,共导入图幅数量为：" + addToMapLibCount);
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_MapList.RowCount == 0)
            {
                MessageBox.Show("当前没有图幅，请先加载图幅.");
                return;
            }
            string strSelMapName = this.dataGridView_MapList.CurrentRow.Cells["mapName"].Value.ToString();

            int iMapPos = ((FormMain)(this.Owner)).ymEncCtrl.GetLibMapPosOfName(strSelMapName); //获取概览图幅的索引
            if (iMapPos > -1)
            {
                ((FormMain)(this.Owner)).ymEncCtrl.OverViewLibMap(iMapPos);
            }
            ((FormMain)(this.Owner)).RedrawMapScreen();
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int index = this.dataGridView_MapList.CurrentRow.Index;
                int mapPos = Convert.ToInt32(this.dataGridView_MapList.CurrentRow.Cells["mapPos"].Value);

                if (mapPos > -1)
                {
                    ((FormMain)this.Owner).ymEncCtrl.DeleteLibMap(mapPos);
                    RefreshMapList(this.textBox_MapNameKey.Text.Trim());
                    ((FormMain)this.Owner).RedrawMapScreen();
                    if (index > 0)
                    {
                        this.dataGridView_MapList.Rows[index - 1].Selected = true;
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            string strKey = this.textBox_key.Text.Trim();
            int lKey = 0;
            if (!strKey.Equals(""))
            {
                try
                {
                    lKey = (int)Convert.ToDouble(strKey);
                    ((FormMain)this.Owner).ymEncCtrl.SetIfYmcFileNeedEncrypt(true);
                    ((FormMain)this.Owner).ymEncCtrl.SetYMCFileEncryptKey(lKey);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("请输入正确的加密密钥，一般为9位数字码");
                    ((FormMain)this.Owner).ymEncCtrl.SetIfYmcFileNeedEncrypt(false);
                    return;
                }
            }
            else
            {
                MessageBox.Show("请输入正确的加密密钥，一般为9位数字码");
                ((FormMain)this.Owner).ymEncCtrl.SetIfYmcFileNeedEncrypt(false);
                return;
            }
        }
    }
}
