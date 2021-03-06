﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vts_odu
{
    public partial class AISAddForm : Form
    {
        private CAis editAis = null;
        public int useOrNot = 0;
        public AISAddForm(CAis _editAis)
        {
            InitializeComponent();
            this.editAis = _editAis;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(CheckDataISLegal())
            {
                if (editAis != null)
                {
                    editAis.aisName = m_aisName.Text;
                    editAis.aisScanRadius = Convert.ToInt32(m_aisScanRadius.Text);
                    if (m_aisUseOrNot.CheckState == CheckState.Checked)
                    {
                        editAis.aisUseOrNot = 1;
                    }
                }
                if (m_aisUseOrNot.CheckState == CheckState.Checked)
                    useOrNot = 1;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        /// <summary>
        /// 插件控件数据是否合法
        /// </summary>
        /// <returns></returns>
        private bool CheckDataISLegal()
        {
            if (m_aisName.Text == null || m_aisName.Text.Equals(""))
            {
                MessageBox.Show("AIS基站名称不能为空！");
                return false;
            }
            else if (m_aisScanRadius.Text == null || m_aisScanRadius.Text.Equals(""))
            {
                MessageBox.Show("AIS基站扫描半径不能为空！");
                return false;
            }
            else if (!Common.IsNumeric(m_aisScanRadius.Text.ToString()))
            {
                MessageBox.Show("AIS基站扫描半径据无效，请检查！");
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AISAddForm_Load(object sender, EventArgs e)
        {
            if(editAis != null)
            {
                this.m_aisName.Text = editAis.aisName;
                this.m_aisGeoPosX.Text = Convert.ToString(editAis.aisGeoPosX);
                this.m_aisGeoPosY.Text = Convert.ToString(editAis.aisGeoPosY);
                this.m_aisScanRadius.Text = Convert.ToString(editAis.aisScanRadius);
                m_aisUseOrNot.Checked = Convert.ToBoolean(editAis.aisUseOrNot);
                this.lat.Text = "经度:" + InteropEncDotNet.GetDegreeStringFromGeoCoor_new(true, editAis.aisGeoPosX, 10000000, 3);
                this.log.Text = "纬度:" + InteropEncDotNet.GetDegreeStringFromGeoCoor_new(false, editAis.aisGeoPosY, 10000000, 3);
            }
        }
    }
}
