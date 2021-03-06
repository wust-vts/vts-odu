﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AxYIMAENCLib;

namespace vts_odu
{
    [Serializable]
    public class CShip
    {
        public int shipMMSI { get; set; } //船ID mmsi
        public int shipID { get; set; } //船舶列表索引ID  
        public String shipName { get; set; }    //船名称
        public CShipType shipType { get; set; } //船类型
        public double shipSpeed { get; set; }   //航速knot
        public double shipCourse { get; set; }    //航向
        public double shipHeading { get; set; }   //航首向
        public int shipLatitude { get; set; }    //维度
        public int shipLongitude { get; set; }   //经度
        public int shipDataFrom { get; set; } //船数据来源
        public int shipMapID { get; set; } //船在海图上的id
        public int shipMapPos { get; set; } //船在海图上的pos
        public int shipUseOrNot { get; set; }  //船舶是否可用
        public M_POINT[] shipPoint = new M_POINT[5];
        public bool ISStartTrackPlay = false;
        public CShipTrack shipTrack = null;
        public CShipShowBasicShape shipBasicShape = null;
        public bool shipShowTrackOrNot = true; //显示或隐藏航迹

        public CShip()
        {
            shipBasicShape = new CShipShowBasicShape();
            shipTrack = new CShipTrack();
            shipUseOrNot = 1;
        }

        //网络传输后的对象构造器
        public CShip(int _shipMMSI, String _shipName, CShipType _shipType, double _shipCourse,
        double _shipHeading, int _shipLatitude, int _shipLongitude, int _shipUseOrNot,double _shipSpeed)
        {
            this.shipMMSI = _shipMMSI;
            this.shipName = _shipName;
            this.shipType = _shipType;
            this.shipCourse = _shipCourse;
            this.shipHeading = _shipHeading;
            this.shipLatitude = _shipLatitude;
            this.shipLongitude = _shipLongitude;
            shipBasicShape = new CShipShowBasicShape();
            shipTrack = new CShipTrack();
            shipUseOrNot = _shipUseOrNot;
            shipSpeed = _shipSpeed;
        }

        public CShip(int _shipMMSI, String _shipName, CShipType _shipType, double _shipCourse,
        double _shipHeading, int _shipLatitude, int _shipLongitude)
        {
            this.shipMMSI = _shipMMSI;
            this.shipName = _shipName;
            this.shipType = _shipType;
            this.shipCourse = _shipCourse;
            this.shipHeading = _shipHeading;
            this.shipLatitude = _shipLatitude;
            this.shipLongitude = _shipLongitude;
            shipBasicShape = new CShipShowBasicShape();
            shipTrack = new CShipTrack();
            shipUseOrNot = 1;
        }
 
        //获得船舶位置
        public void GetCurGeoPos(ref long curGeoPosX,ref long curGeoPosY)
        {
            curGeoPosX = shipLatitude;
            curGeoPosY = shipLongitude;
        }

        public void ThreadTrackPlay(Object obj)
        {
            AxYimaEnc yimaEnc = (AxYimaEnc)obj;
            while (ISStartTrackPlay)
            {
                for(int i = 0;i < shipTrack.m_trackData.Count;i++)
                {
                    SetCurGeoPosByTrack(yimaEnc, shipTrack.m_trackData[i].x, shipTrack.m_trackData[i].y);
                    yimaEnc.DrawMapsInScreen(0);
                    if(!ISStartTrackPlay)
                    {
                        break;
                    }
                }
                Thread.Sleep(100);
            }
        }

        //开始轨迹回放
        public void StartTrackPlay(AxYimaEnc yimaEnc)
        {
            //开启轨迹回放线程
            ISStartTrackPlay = true;
            Thread thread = new Thread(ThreadTrackPlay);
            thread.Start(yimaEnc);
        }

        //停止轨迹回放
        public void StopTrackPlay()
        {
            ISStartTrackPlay = false;
        }

        //设置船首向
        public void SetCurHeading(AxYimaEnc yimaEnc,double curHeading, bool ifUpdateMotion)
        {
            shipHeading = curHeading;
            while (shipHeading >= 360)
                shipHeading -= 360.0;
            while (shipHeading < 0)
                shipHeading += 360.0;
            shipCourse = shipHeading;
            ReCalculateBoundryPoints(yimaEnc, shipLatitude, shipLongitude, (shipType.shipLength / 1852), (shipType.shipWidth / 1852), shipCourse);
        }

        //设置船舶位置
        public void SetCurGeoPos(AxYimaEnc yimaEnc,int curGeoPosX, int curGeoPosY, bool ifUpdateMotion)
        {
            if (shipLatitude == 0 || shipLongitude == 0)
            {
                ReCalculateBoundryPoints(yimaEnc,curGeoPosX, curGeoPosY, (shipType.shipLength/1852), (shipType.shipWidth/1852), shipCourse);
            }
            else
                RefreshBoundryByOffset(yimaEnc,curGeoPosX - shipLatitude, curGeoPosY - shipLongitude);

            shipLatitude = curGeoPosX;
            shipLongitude = curGeoPosY;
        }

        //轨迹回放时设置位置
        public void SetCurGeoPosByTrack(AxYimaEnc yimaEnc, int curGeoPosX, int curGeoPosY)
        {
            shipLatitude = curGeoPosX;
            shipLongitude = curGeoPosY;
            //重新计算船的绘制位置
            ReCalculateBoundryPoints(yimaEnc, shipLatitude, shipLongitude, (shipType.shipLength / 1852), (shipType.shipWidth / 1852), shipCourse);
        }

        /// <summary>
        /// 显示船
        /// </summary>
        /// <param name="yimaEnc"></param>
        /// <param name="hasSelected"></param>
        /// <param name="xOffset"></param>
        /// <param name="yOffset"></param>
        public void Show(AxYimaEnc yimaEnc,bool hasSelected,int xOffset,int yOffset)
        {
            //显示矢量
            //ShowVector(yimaEnc, xOffset, yOffset);
            //显示航迹
            //shipTrack.ShowTrack(yimaEnc, xOffset, yOffset);
            //显示船舶形状
            DrawShape(yimaEnc,shipLatitude,shipLongitude,shipType.shipLength, shipType.shipWidth,shipCourse,hasSelected,xOffset,yOffset);
            //显示船名称
            //ShowShipName(yimaEnc, xOffset, yOffset);
        }
        /// <summary>
        /// 显示矢量
        /// </summary>
        /// <param name="yimaEnc"></param>
        /// <param name="xOffset"></param>
        /// <param name="yOffset"></param>
        private void ShowVector(AxYimaEnc yimaEnc, int xOffset, int yOffset)
        {
            int desPosX = 0, desPosY = 0, desScrX = 0, desScrY = 0;
            yimaEnc.GetDesPointOfCrsAndDist(shipLatitude, shipLongitude, Common.SHOW_VECTOR / 60.0 * shipSpeed, shipCourse,ref desPosX, ref desPosY);
            yimaEnc.GetScrnPoFromGeoPo(desPosX, desPosY, ref desScrX, ref desScrY);

            Pen pen = new Pen(Color.Red);
            int curScrX = 0, curScrY = 0;
            yimaEnc.GetScrnPoFromGeoPo(shipLatitude, shipLongitude, ref curScrX, ref curScrY);
            Graphics graphics = Graphics.FromHdc((IntPtr)yimaEnc.GetDrawerHDC());
            graphics.DrawLine(pen,new Point(curScrX + xOffset, curScrY + yOffset),new Point(desScrX + xOffset, desScrY + yOffset));
            graphics.Dispose();
        }

        /// <summary>
        /// 绘制5个点的轮廓
        /// </summary>
        private void DrawShape(AxYimaEnc yimaEnc, long geoPosX, long geoPosY,
                                    double shipLength, double shipWidth, double shipCourse,
                                    bool hasSelected, int xOffset, int yOffset)
        {
            double radius = Math.Sqrt(shipLength * shipLength + shipWidth * shipWidth) / 2;
            double extraCourse = (Math.Atan(shipWidth / shipLength)) / 3.14159265 * 180;

            short colorModel = yimaEnc.GetColorModel();
            Pen pen = new Pen(Color.Blue);
            SolidBrush solidBrush = new SolidBrush(Color.Blue);
            Graphics graphics = Graphics.FromHdc((IntPtr)yimaEnc.GetDrawerHDC());
            Point[] points = new Point[6];
            int scrPosX = 0,scrPosY = 0;

            for(int i = 0;i<5;i++)
            {
                yimaEnc.GetScrnPoFromGeoPo(shipPoint[i].x, shipPoint[i].y, ref scrPosX, ref scrPosY);
                points[i] = new Point(scrPosX, scrPosY);
            }
            points[5] = points[0];
            graphics.DrawLines(pen, points);
            //graphics.FillPolygon(solidBrush, points);
            graphics.Dispose();
        }
        /// <summary>
        /// 绘制船名
        /// </summary>
        /// <param name="yimaEnc"></param>
        /// <param name="hasSelected"></param>
        /// <param name="xOffset"></param>
        /// <param name="yOffset"></param>
        private void ShowShipName(AxYimaEnc yimaEnc,int xOffset,int yOffset)
        {
            int geoPosX, geoPosY;
            //找出船舶框架所有关键点的最小X和最大Y
            geoPosX = shipPoint[0].x;
            geoPosY = shipPoint[0].y;
            int arrayLen = shipPoint.Length;
            for (int i = 1; i < arrayLen; i++)
            {
                if (geoPosX > shipPoint[i].x)
                {
                    geoPosX = shipPoint[i].x;
                }
                if (geoPosY > shipPoint[i].y)
                {
                    geoPosY = shipPoint[i].y;
                }
            }

            //得到屏幕坐标点
            int scrPosX = 0, scrPosY = 0;
            yimaEnc.GetScrnPoFromGeoPo(geoPosX, geoPosY, ref scrPosX, ref scrPosY);
            scrPosX += 2 + xOffset;
            scrPosY += 2 + yOffset;

            //绘制船名
            short colorModel = yimaEnc.GetColorModel();
            Brush brush = new SolidBrush(Color.FromArgb(colorModel * 30, colorModel * 50, colorModel * 30));
            Font font = new Font("Arial", 12, FontStyle.Bold);
            Graphics graphics = Graphics.FromHdc((IntPtr)yimaEnc.GetDrawerHDC());
            graphics.DrawString(shipName,font,brush, scrPosX, scrPosY);
            graphics.Dispose();
        }


        /// <summary>
        /// 计算5个包围点
        /// </summary>
        /// <param name="yimaEnc"></param>
        /// <param name="geoPosX"></param>
        /// <param name="geoPosY"></param>
        /// <param name="shipLength"></param>
        /// <param name="shipWidth"></param>
        /// <param name="shipCourse"></param>
        private void ReCalculateBoundryPoints(AxYimaEnc yimaEnc,int geoPosX, int geoPosY, double shipLength, double shipWidth, double shipCourse)
        {
            shipPoint = shipBasicShape.ReCalculateBoundryPoints(yimaEnc, geoPosX, geoPosY, shipLength, shipWidth, shipCourse);
        }

        /// <summary>
        /// 更新5个包围点通过偏移量
        /// </summary>
        /// <param name="yimaEnc"></param>
        /// <param name="xOffset"></param>
        /// <param name="yOffset"></param>
        private void RefreshBoundryByOffset(AxYimaEnc yimaEnc,int xOffset, int yOffset)
        {
            shipPoint = shipBasicShape.RefreshBoundryByOffset(yimaEnc, xOffset, yOffset);
        }

        /// <summary>
        /// 是否选中船舶
        /// </summary>
        /// <param name="yimaEnc"></param>
        /// <param name="mMouseScrnPo"></param>
        /// <returns></returns>
        public bool HasSelected(AxYimaEnc yimaEnc, M_POINT mMouseScrnPo)
        {
            if(shipPoint == null)
            {
                return false;
            }
            PointF inputPoint = new PointF((mMouseScrnPo.x*0.1f), (mMouseScrnPo.y * 0.1f));
            PointF[] points = { new PointF(0.0f,0.0f), new PointF(0.0f, 0.0f), new PointF(0.0f, 0.0f), new PointF(0.0f, 0.0f), new PointF(0.0f, 0.0f) };
            M_POINT[] bPoint = { new M_POINT(0, 0) , new M_POINT(0, 0) , new M_POINT(0, 0) , new M_POINT(0, 0) , new M_POINT(0, 0) };
            for (int i = 0; i < 5; i++)
            {
                yimaEnc.GetScrnPoFromGeoPo(shipPoint[i].x, shipPoint[i].y,ref (bPoint[i].x), ref (bPoint[i].y));
                points[i].X = (bPoint[i].x * 0.1f);
                points[i].Y = (bPoint[i].y * 0.1f);
            }
            GraphicsPath myGraphicsPath = new GraphicsPath();
            Region myRegion = new Region();
            myGraphicsPath.Reset();
            myGraphicsPath.AddPolygon(points);
            myRegion.MakeEmpty();
            myRegion.Union(myGraphicsPath);
            //返回判断点是否在多边形里
            return myRegion.IsVisible(inputPoint);
        }

        /// <summary>
        /// 判断两个船相同
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
            CShip ship = (CShip)obj;
            return this.shipMMSI.Equals(ship.shipMMSI);
        }

        /// <summary>
        /// 重写GetHashCode方法（重写Equals方法必须重写GetHashCode方法，否则发生警告
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.shipMMSI.GetHashCode();
        }

    }
}