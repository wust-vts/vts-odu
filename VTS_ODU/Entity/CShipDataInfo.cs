﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vts_odu.Entity
{
    [Serializable]
    public class CShipDataInfo
    {
        public int shipMMSI { get; set; } //船ID mmsi
        public int shipID { get; set; } //船索引ID
        public String shipName { get; set; }    //船名称
        public int GeoPoX { get; set; }
        public int GeoPoY { get; set; }
        public double shipHeading { get; set; }   //航首向
        public double shipCourse { get; set; }    //航向
        public float shipRudderAngle { get; set; }  //舵角
        public double shipRateOfTurn { get; set; }     //转速率
    }
}
