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
    public partial class AISShowSmallBox : Form
    {
        private CAis opAis = null;
        public AISShowSmallBox()
        {
            InitializeComponent();
        }

        private void InitFormStyle()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;//不能修改大小
            this.ControlBox = false;//按钮不显示
            this.ShowInTaskbar = false;//不在底部栏显示
        }

        private void AISShowBox_Load(object sender, EventArgs e)
        {
            InitFormStyle();
            if (((FormMain)this.Owner).UserName.Equals("admin"))
            {
                this.ais_delete_button.Visible = false;
                this.ais_edit_button.Visible = false;
                this.ais_start_button.Visible = false;
                this.ais_stop_button.Visible = false;
            }
        }

        public void setAisInfo(CAis ais, M_POINT mShowScrnPo)
        {
            opAis = ais;
            Point point = ((FormMain)this.Owner).GetLocationOnClient(((FormMain)this.Owner).ymEncCtrl);
            int iTop = point.Y;
            int iLeft = mShowScrnPo.x;
            this.Location = new System.Drawing.Point(iLeft, mShowScrnPo.y + iTop);
            M_POINT mGeoPo = new M_POINT();
            ((FormMain)this.Owner).ymEncCtrl.tmGetPointObjectCoor(0, ais.aisMapPos, ref mGeoPo.x, ref mGeoPo.y);

            this.Text = "AIS:" + ais.aisName.Trim();
            this.label_lon.Text = "经度:" + InteropEncDotNet.GetDegreeStringFromGeoCoor_new(true, mGeoPo.x, 10000000, 3);
            this.label_lat.Text = "纬度:" + InteropEncDotNet.GetDegreeStringFromGeoCoor_new(false, mGeoPo.y, 10000000, 3);
            this.label_radius.Text = "半径:" + ais.aisScanRadius + "(m)";
        }

        public void HiddenFormBox()
        {
            this.Location = new System.Drawing.Point(-1000, 0);
        }

        private void ais_edit_button_Click(object sender, EventArgs e)
        {

        }

        private void ais_delete_button_Click(object sender, EventArgs e)
        {

        }

        private void ais_start_button_Click(object sender, EventArgs e)
        {
            opAis.aisUseOrNot = 1;
        }

        private void ais_stop_button_Click(object sender, EventArgs e)
        {
            opAis.aisUseOrNot = 0;
        }
    }
}
