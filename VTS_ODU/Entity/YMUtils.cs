﻿using AxYIMAENCLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vts_odu
{
    public class YMUtils
    {
        public static M_POINT[] GetShipBoundaryFromGeoCoor(AxYimaEnc yimaEnc, int geoPosX, int geoPosY, double shipLength, double shipWidth, double shipCourse)
        {
            double dist = Math.Sqrt(shipLength * shipLength + shipWidth * shipWidth) / 2;
            double extraCourse = (Math.Atan(shipWidth / shipLength)) / 3.14159265 * 180;

            M_POINT[] point = { new M_POINT(0, 0), new M_POINT(0, 0), new M_POINT(0, 0), new M_POINT(0, 0), new M_POINT(0, 0) };
            double course = shipCourse;
            yimaEnc.GetDesPointOfCrsAndDist(geoPosX, geoPosY, shipLength, course, ref point[0].x, ref point[0].y);
            //pYimaEncCtrl->GetScrnPoFromGeoPo(point[0].x, point[0].y, &(point[0].x), &(point[0].y));
            course = shipCourse + extraCourse;
            while (course >= 360)
                course -= 360;
            yimaEnc.GetDesPointOfCrsAndDist(geoPosX, geoPosY, dist, course, ref point[1].x, ref point[1].y);
            //pYimaEncCtrl->GetScrnPoFromGeoPo(point[1].x, point[1].y, &(point[1].x), &(point[1].y));
            course = shipCourse + 180 - extraCourse;
            while (course >= 360)
                course -= 360;
            yimaEnc.GetDesPointOfCrsAndDist(geoPosX, geoPosY, dist, course, ref point[2].x, ref point[2].y);
            //pYimaEncCtrl->GetScrnPoFromGeoPo(point[2].x, point[2].y, &(point[2].x), &(point[2].y));
            course = shipCourse + 180 + extraCourse;
            while (course >= 360)
                course -= 360;
            yimaEnc.GetDesPointOfCrsAndDist(geoPosX, geoPosY, dist, course, ref point[3].x, ref point[3].y);
            //pYimaEncCtrl->GetScrnPoFromGeoPo(point[3].x, point[3].y, &(point[3].x), &(point[3].y));
            course = shipCourse + 360 - extraCourse;
            while (course >= 360)
                course -= 360;
            yimaEnc.GetDesPointOfCrsAndDist(geoPosX, geoPosY, dist, course, ref point[4].x, ref point[4].y);
            //pYimaEncCtrl->GetScrnPoFromGeoPo(point[4].x, point[4].y, &(point[4].x), &(point[4].y));
            //point[5].x = point[0].x;
            //point[5].x = point[0]x;
            return point;
        }
        
    }
}
