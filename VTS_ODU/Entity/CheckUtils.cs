﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vts_odu
{
    public class CheckUtils
    {
        /// <summary>
        /// 检查是否已经添加过船通过MMSI
        /// </summary>
        /// <param name="mmsi"></param>
        /// <returns></returns>
        public static CShip checkIsAddedShipByMMSI(long mmsi,List<CShip> shipList)
        {
            if (mmsi < 0 || shipList == null || shipList.Count == 0)
                return null;
            foreach (CShip ship in shipList)
            {
                if (ship.shipMMSI == mmsi)
                    return ship;
            }
            return null;
        }

        /// <summary>
        /// 检查是否已经添加过雷达通过雷达名称
        /// </summary>
        /// <param name="radarName"></param>
        /// <param name="radarList"></param>
        /// <returns></returns>
        public static CRadar checkIsAddedRadarByRadarName(String radarName,List<CRadar> radarList)
        {
            if (radarName == null || radarName.Equals("") || radarList == null || radarList.Count == 0)
                return null;
            foreach (CRadar radar in radarList)
            {
                if (radar.radarName == radarName)
                    return radar;
            }
            return null;
        }

        /// <summary>
        /// 检查是否已经添加过Ais基站通过Ais名称
        /// </summary>
        /// <param name="radarName"></param>
        /// <param name="radarList"></param>
        /// <returns></returns>
        public static CAis checkIsAddedAisByAisName(String aisName, List<CAis> aisList)
        {
            if (aisName == null || aisName.Equals("") || aisList == null || aisList.Count == 0)
                return null;
            foreach (CAis ais in aisList)
            {
                if (ais.aisName == aisName)
                    return ais;
            }
            return null;
        }
    }
}
