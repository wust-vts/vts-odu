﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace vts_odu
{
    public partial class GeoObjectInfoDlg : Form
    {
        public MEM_GEO_OBJ_POS m_memObjPos;

        public GeoObjectInfoDlg()
        {
            m_memObjPos = new MEM_GEO_OBJ_POS();
            InitializeComponent();
        }

        private void GeoObjectInfoDlg_Load(object sender, EventArgs e)
        {
            string layerName = new string('1', 255);
            string layerNameToken = new string('1', 255);
            int attrCount = 0;
            if (!((FormMain)this.Owner).ymEncCtrl.GetLayerInfo(m_memObjPos.memMapPos, m_memObjPos.layerPos, ref layerName, ref layerNameToken, ref attrCount))
            {
                return;
            }

            string[] str = Regex.Split(layerName, "__");

            int count = str.Length;
            if (str.Length > 1)
            {
                if (FormMain.isDisplayLangCh)
                {
                    this.layerNameTextBox.Text = str[0].ToString();
                }
                else
                {
                    this.layerNameTextBox.Text = str[1].ToString();
                }

            }
            else
            {
                this.layerNameTextBox.Text = layerName;
            }

            //this.layerNameTextBox.Text = layerName;

            string strObjPos = InteropEncDotNet.GetStringFromMemGeoObjPos(m_memObjPos);
            M_GEO_TYPE geoType = (M_GEO_TYPE)((FormMain)this.Owner).ymEncCtrl.GetObjectGeoType(ref strObjPos);
            if (geoType == M_GEO_TYPE.TYPE_POINT)
            {
                this.geoTypeTextBox.Text = "POINT";
            }
            else if (geoType == M_GEO_TYPE.TYPE_LINE)
            {
                this.geoTypeTextBox.Text = "LINE";
            }
            else if (geoType == M_GEO_TYPE.TYPE_FACE)
            {
                this.geoTypeTextBox.Text = "FACE";
            }

            for (int attrNum = 0; attrNum < attrCount; attrNum++)
            {
                string attrName = new string(' ', 255);
                int dataType = 0;
                string attrToken = new string(' ', 255);
                string attrValString = new string(' ', 255);
                ((FormMain)this.Owner).ymEncCtrl.GetLayerObjectAttrInfo(m_memObjPos.memMapPos, this.m_memObjPos.layerPos, attrNum, ref dataType, ref attrName, ref attrToken);

                ((FormMain)this.Owner).ymEncCtrl.GetObjectAttrString(ref strObjPos, attrNum, ref attrValString);

                string listItem = attrName.Substring(0, attrName.LastIndexOf((char)0));//注意！由于.net 里的ｓｔｒｉｎｇ不能自动按照"0x0000"的字符结束，所以这里要手工把它截断，否则后面的字符串加不起来
                listItem += " --- 值: ";
                listItem += attrValString;

                this.ObjectAttrListCtrl.Items.Add(listItem);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}