﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vts_odu
{
    public partial class FormSelectTlayerShowInfo : Form
    {
        public FormSelectTlayerShowInfo()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_displayMode1_CheckedChanged(object sender, EventArgs e)
        {
            //cb_displayMode1.Checked = !cb_displayMode1.Checked;
            if (cb_displayMode1.Checked)
            {
                cb_displayMode2.Checked = false;
                rdBtn_userMode1.Enabled = false;
                rdBtn_userMode2.Enabled = false;
                rdBtn_userMode3.Enabled = false;
                rdBtn_S52mode1.Enabled = true;
                rdBtn_S52mode2.Enabled = true;
                rdBtn_S52mode3.Enabled = true;
            }
            else
            {
                cb_displayMode2.Checked = true;
                rdBtn_userMode1.Enabled = true;
                rdBtn_userMode2.Enabled = true;
                rdBtn_userMode3.Enabled = true;
                rdBtn_S52mode1.Enabled = false;
                rdBtn_S52mode2.Enabled = false;
                rdBtn_S52mode3.Enabled = false;
            
            }            
        }

        private void cb_displayMode2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_displayMode2.Checked)
            {
                cb_displayMode1.Checked = false;
            }
            else
            {
                cb_displayMode1.Checked = true;
            }
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSelectTlayerShowInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
