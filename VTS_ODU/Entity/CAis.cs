﻿using AxYIMAENCLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vts_odu
{
    [Serializable]
    public class CAis
    {
        public int aisID { get; set; } //AIS基站ID
        public String aisName { get; set; }    //AIS基站名称
        public int aisScanRadius { get; set; }   //AIS基站扫描半径
        public double aisPixelRadius { get; set; }   //AIS基站像素半径
        public int aisGeoPosX { get; set; }    //AIS基站经纬度坐标X
        public int aisGeoPosY { get; set; }   //AIS基站经纬度坐标Y
        public int aisMapPos { get; set; }
        public int aisUseOrNot { get; set; }  //AIS基站是否启用

        public CAis() { }

        public CAis(int _aisID, String _aisName, int _aisScanRadius,
            int _aisGeoPosX,int _aisGeoPosY,int _aisUseOrNot)
        {
            aisID = _aisID;
            aisName = _aisName;
            aisScanRadius = _aisScanRadius;
            aisGeoPosX = _aisGeoPosX;
            aisGeoPosY = _aisGeoPosY;
            aisUseOrNot = _aisUseOrNot;
        }

        /// <summary>
        /// 显示AIS基站的扫描范围
        /// </summary>
        /// <param name="yimaEnc"></param>
        public void ShowBoundary(AxYimaEnc yimaEnc)
        {
            this.aisPixelRadius = yimaEnc.GetScrnLenFromGeoLen((float)(this.aisScanRadius * 1000 * 1000));
            int ScrnPoX = 0, ScrnPoY = 0;
            yimaEnc.GetScrnPoFromGeoPo(this.aisGeoPosX, this.aisGeoPosY, ref ScrnPoX, ref ScrnPoY);
            yimaEnc.SetCurrentPen(2, new M_COLOR(0, 0, 255).ToInt());
            yimaEnc.DrawCircle(ScrnPoX, ScrnPoY, (int)this.aisPixelRadius / 2, false, true);
            yimaEnc.DrawCircle(ScrnPoX, ScrnPoY, (int)this.aisPixelRadius, false, true);
        }

        /// <summary>
        /// 判断两个AIS基站相同
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if ((obj.GetType().Equals(this.GetType())) == false)
            {
                return false;
            }
            CAis ais = (CAis)obj;
            return this.aisID.Equals(ais.aisID);
        }

        /// <summary>
        /// 重写GetHashCode方法（重写Equals方法必须重写GetHashCode方法，否则发生警告
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.aisID.GetHashCode();
        }
    }
}
