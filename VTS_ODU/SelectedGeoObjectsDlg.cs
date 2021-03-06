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
    public partial class SelectedGeoObjectsDlg : Form
    {
        public int m_curSelectedObjCount; //YIMAENC COMMENT: 当前选中的物标个数
        public bool displayLangEng = false;//当前显示的语言：true为英语，false为中文
        public MEM_GEO_OBJ_POS[] m_pSelectedObjPoses;//YIMAENC COMMENT: 当前选中的所有物标位置指针 

        public SelectedGeoObjectsDlg()
        {
            InitializeComponent();
        }

        private void SelectedObjectDlg_Load(object sender, EventArgs e)
        {
            int lastObjMemMapPos = -1;
            for (int selObjNum = 0; selObjNum < m_curSelectedObjCount; selObjNum++)
            {
                MEM_GEO_OBJ_POS selObjPos = m_pSelectedObjPoses[selObjNum];

                if (lastObjMemMapPos != selObjPos.memMapPos)
                {             
                    string bstrMapName = new string('1', 255);
                    string bstrMapType = new string('1', 50);
                    float a1 = 0;
                    int a2, a3, a4, a5, a6, a7;
                    a2 = a3 = a4 = a5 = a6 = a7 = 0;
                    int memMapCount = ((FormMain)this.Owner).ymEncCtrl.GetMemMapCount();
                    ((FormMain)this.Owner).ymEncCtrl.GetMemMapInfo(selObjPos.memMapPos, ref bstrMapType, ref bstrMapName,
                        ref a1, ref a2, ref a3, ref a4, ref a5, ref a6, ref a7);

                    string strMapName = "Map:";
                    if (bstrMapType.IndexOf("S57 ENC map") > -1)
                    {
                        strMapName = "Map(S57 ENC):";
                    }
                    else if(bstrMapType.IndexOf("VCF map") > -1)
                    {
                        strMapName = "Map(VCF):";
                    }

                    strMapName += bstrMapName;                
                    lastObjMemMapPos = selObjPos.memMapPos;
                    this.m_selGeoObjectList.Items.Add(new ListItem(-1, strMapName));//图层的话，默认ID为-1，物标的话则为物标的编号
                }

                string bstrLayerName = new string('1',255);
                string strToken = new string('1', 255);
                int layerAttrCount = 0;
                ((FormMain)this.Owner).ymEncCtrl.GetLayerInfo(selObjPos.memMapPos, selObjPos.layerPos, ref bstrLayerName, ref strToken, ref layerAttrCount);

                string strGeoObjectInfo = "  |---  Layer:";
                bstrLayerName = bstrLayerName.Substring(0, bstrLayerName.IndexOf("\0"));

                string[] str = Regex.Split(bstrLayerName, "__");
                int count = str.Length;
                if (str.Length > 1)
                {
                    if (FormMain.isDisplayLangCh)
                    {
                        bstrLayerName = str[0].ToString();
                    }
                    else
                    {
                        bstrLayerName = str[1].ToString();
                    }

                }

                strGeoObjectInfo += bstrLayerName;                
                string strObjectPos = ", Object Pos:" + selObjPos.innerLayerPos.ToString();
                strGeoObjectInfo += strObjectPos;
                this.m_selGeoObjectList.Items.Add(new ListItem(selObjNum, strGeoObjectInfo));////图层的话，默认ID为-1，物标的话则为物标的编号
                strGeoObjectInfo += strObjectPos;              
            }

            if (m_curSelectedObjCount > 0)
            {
                m_selGeoObjectList.SetSelected(1, true);
            }

            if (displayLangEng)
            {
                this.CloseForm.Text = "CLOSE";
                this.Text = "Selected Object";
            }
        }

        private void m_selGeoObjectList_DoubleClick(object sender, EventArgs e)
        {
            int selectMemMapPos = ((ListItem)this.m_selGeoObjectList.SelectedItem).ID;
            if (selectMemMapPos != -1)
            {
                GeoObjectInfoDlg objectInfoDlg = new GeoObjectInfoDlg();
                objectInfoDlg.m_memObjPos = m_pSelectedObjPoses[selectMemMapPos];
                //((FormMain)this.Owner).SetHighLightObject(this.m_pSelectedObjPoses[selectMemMapPos]);
                ((FormMain)this.Owner).RedrawMapScreen();
                objectInfoDlg.Owner = this.Owner;
                objectInfoDlg.Show();
            }
        }

        private void m_selGeoObjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selObjPosInArray = ((ListItem)this.m_selGeoObjectList.SelectedItem).ID;
            if (selObjPosInArray != -1)
            { 
                //((FormMain)this.Owner).SetHighLightObject(this.m_pSelectedObjPoses[selObjPosInArray]);
                ((FormMain)this.Owner).RedrawMapScreen();
            }
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}