﻿using AxYIMAENCLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vts_odu
{
    [Serializable]
    public class CShipTrack
    {
        public List<M_POINT> m_trackData = new List<M_POINT>();
        public int m_index = 0;
        public int sTrackLength = 1000000;
        
        //添加航迹
        public void AddTrack(int geoX, int geoY)
        {
            if (m_trackData.Count < sTrackLength)
            {
                m_trackData.Add(new M_POINT(geoX, geoY));
                m_index = 0;
            }
            else
            {
                m_trackData[m_index] = new M_POINT(geoX, geoY);
                m_index++;
                if (m_index == m_trackData.Count)
                {
                    m_index = 0;
                }
            }
        }

        //显示航迹
        public void ShowTrack(AxYimaEnc yimaEnc, int xOffset, int yOffset)
        {
            int scrPosX = 0, scrPosY = 0;
            int c = (sTrackLength > m_trackData.Count) ? m_trackData.Count : sTrackLength;
            int index = m_index;
            int j = 0;
            for (int i = 0; i < c; i++)
            {
                index--;
                if (index < 0)
                {
                    index += m_trackData.Count;
                }
                yimaEnc.GetScrnPoFromGeoPo(m_trackData[index].x, m_trackData[index].y,ref scrPosX, ref scrPosY);
                Point point = new Point(scrPosX + xOffset, scrPosY + yOffset);
                if (j > 10)
                {
                    M_COLOR mLineColor = new M_COLOR(0, 0, 255);//线的颜色
                    M_COLOR mFillColor = new M_COLOR(255, 255, 255);//填充颜色
                    yimaEnc.SetCurrentPen(3, mLineColor.ToInt());
                    yimaEnc.SetCurrentBrush(mFillColor.ToInt());
                    yimaEnc.GetScrnPoFromGeoPo(m_trackData[i - 5].x, m_trackData[i - 5].y, ref scrPosX, ref scrPosY);
                    yimaEnc.DrawLine(scrPosX + xOffset, scrPosY + yOffset, point.X, point.Y);
                    //绘制小圆
                    yimaEnc.DrawCircle(point.X, point.Y, 3, false, true);
                    j = 0;
                }
                j++;
            }
        }

        //保存到文件
        public void SaveToFileOrReadFromFile(String filePath, int type)
        {
            //写入
            if(type ==1)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, true))
                {
                    file.WriteLine(m_trackData.Count);
                    for (int i = 0; i < m_trackData.Count; i++)
                    {
                        file.WriteLine(m_trackData[i].x);
                        file.WriteLine(m_trackData[i].y);
                    }
                    file.WriteLine(m_index);
                }
            }
            else
            {
                //读取
                using (System.IO.StreamReader file = new System.IO.StreamReader(filePath))
                {
                    int count = Convert.ToInt32(file.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        m_trackData[i].x = Convert.ToInt32(file.ReadLine());
                        m_trackData[i].y = Convert.ToInt32(file.ReadLine());
                    }
                    m_index = Convert.ToInt32(file.ReadLine());
                }
            }
        }

        //清空航迹
        public void ClearTrack()
        {
            m_trackData.Clear();
            m_index = 0;
        }
    }
}
