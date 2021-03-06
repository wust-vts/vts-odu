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
    public partial class UserMapObjectAttributesDlg : Form
    {
        public M_GEO_OBJ_POS m_usrMapObjPos;
        public int attrCount;
        public bool isDisAttributes = false;
        public UserMapObjectAttributesDlg()
        {
            InitializeComponent();
            attrCount = 0;
            m_usrMapObjPos = new M_GEO_OBJ_POS();
        }

        private void UserMapObjectAttributesDlg_Load(object sender, EventArgs e)
        {
            if (isDisAttributes)
            {
                this.btn_del.Visible = true;
            }
            if (attrCount > 0)
            {
                this.labels = new System.Windows.Forms.Label[attrCount];
                this.textBoxs = new System.Windows.Forms.TextBox[attrCount];
                for (int attrNum = 0; attrNum < attrCount; attrNum++)
                { 
                    // 
                    // label i
                    // 
                    this.labels[attrNum] = new System.Windows.Forms.Label();
                    this.labels[attrNum].AutoSize = true;
                    this.labels[attrNum].Location = new System.Drawing.Point(22, 60 + attrNum * 40);
                    this.labels[attrNum].Name = "labels" + attrNum.ToString();
                    this.labels[attrNum].Size = new System.Drawing.Size(20, 12);
                    this.labels[attrNum].TabIndex = 0;

                    string attrName = new string('1', 255);
                    ((FormMain)this.Owner).ymEncCtrl.tmGetLayerObjectAttrName(m_usrMapObjPos.layerPos, attrNum, ref attrName);
                    this.labels[attrNum].Text = attrName;
                    // 
                    // textBox i
                    // 
                    this.textBoxs[attrNum] = new System.Windows.Forms.TextBox();
                    this.textBoxs[attrNum].Location = new System.Drawing.Point(79, 57 + attrNum*40);
                    this.textBoxs[attrNum].Name = "textBoxs" + attrNum.ToString();
                    this.textBoxs[attrNum].Size = new System.Drawing.Size(189, 21);
                    this.textBoxs[attrNum].TabIndex = 1;

                    string attrVal = new string('1', 255);
                    ((FormMain)this.Owner).ymEncCtrl.tmGetObjectAttrValueString(m_usrMapObjPos.layerPos, m_usrMapObjPos.innerLayerObjectPos, attrNum, ref attrVal);
                    this.textBoxs[attrNum].Text = attrVal;

                    string layerName = new string('1', 255);
                    ((FormMain)this.Owner).ymEncCtrl.tmGetLayerName(m_usrMapObjPos.layerPos, ref layerName);
      
                    string[] str = Regex.Split(layerName,"__");

                    int count = str.Length;
                    if (str.Length > 1)
                    {
                        if (FormMain.isDisplayLangCh)
                        {
                            this.layerNameText.Text = str[0].ToString();
                        }
                        else
                        {
                            this.layerNameText.Text = str[1].ToString();
                        }

                    }
                    else
                    {
                        this.layerNameText.Text = layerName;
                    }
                    

                    LAYER_GEO_TYPE layerGeoType = (LAYER_GEO_TYPE)((FormMain)this.Owner).ymEncCtrl.tmGetLayerGeoType(m_usrMapObjPos.layerPos); 

                    if (layerGeoType == LAYER_GEO_TYPE.ALL_POINT)
                    {
                        this.geoTypeText.Text = "点";
                    }
                    else if (layerGeoType == LAYER_GEO_TYPE.ALL_LINE)
                    {
                        this.geoTypeText.Text = "线";
                    }
                    else if (layerGeoType == LAYER_GEO_TYPE.ALL_FACE)
                    {
                        this.geoTypeText.Text = "面";
                    }

                    this.Controls.Add(this.textBoxs[attrNum]);
                    this.Controls.Add(this.labels[attrNum]);
                }
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            for (int attrNum = 0; attrNum < attrCount; attrNum++)
            { 
                ((FormMain)this.Owner).ymEncCtrl.tmSetObjectAttrValueString(m_usrMapObjPos.layerPos, m_usrMapObjPos.innerLayerObjectPos, attrNum, this.textBoxs[attrNum].Text);  
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Owner).ymEncCtrl.tmDeleteGeoObject(m_usrMapObjPos.layerPos, m_usrMapObjPos.innerLayerObjectPos);
            this.Close();
        }       
    }
}