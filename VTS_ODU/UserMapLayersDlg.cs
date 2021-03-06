﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vts_odu
{
    public partial class UserMapLayersDlg : Form
    {
        public int m_iEditingLayerNum;

        public UserMapLayersDlg()
        {
            InitializeComponent();
            m_iEditingLayerNum = -1;
        }

        private void UserMapLayersDlg_Load(object sender, EventArgs e)
        {
            int layerCount=((FormMain)this.Owner).ymEncCtrl.tmGetLayerCount();
            for (int layerNum = 0; layerNum < layerCount; layerNum++)
            {
                string layerName = new string('1', 255);
                ((FormMain)this.Owner).ymEncCtrl.tmGetLayerName(layerNum, ref layerName);
                listBox1.Items.Add(layerName);
            }

            if (m_iEditingLayerNum != -1)
            {
                listBox1.SetSelected(m_iEditingLayerNum, true);
                RefreshSelectedLayerInfo();
            }
        }

        private void RefreshSelectedLayerInfo()
        {
            int layerNum = listBox1.SelectedIndex;

            string layerName = new string('1', 255);
            ((FormMain)this.Owner).ymEncCtrl.tmGetLayerName(layerNum, ref layerName);

            LAYER_GEO_TYPE layerGeoType = (LAYER_GEO_TYPE)((FormMain)this.Owner).ymEncCtrl.tmGetLayerGeoType(layerNum);

            this.editingLayerNameText.Text = layerName;

            if (layerGeoType == LAYER_GEO_TYPE.ALL_POINT)
            {
                this.editingLayerGeoTypeText.Text = "点";
            }
            else if (layerGeoType == LAYER_GEO_TYPE.ALL_LINE)
            {
                this.editingLayerGeoTypeText.Text = "线";
            }
            else if (layerGeoType == LAYER_GEO_TYPE.ALL_FACE)
            {
                this.editingLayerGeoTypeText.Text = "面";
            }
            else
            {
                this.editingLayerGeoTypeText.Text = "";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSelectedLayerInfo();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            m_iEditingLayerNum = listBox1.SelectedIndex;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}