using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lianliankan
{
    public partial class GameForm : Form
    {
        //private int global.IMGSIZE = 60;//图片尺寸
       // private const int global.IMGNUM = 4;//图片数目
       // private int NOIMAGE = 0;//0表示没有图片
        private int[,] m_anMap = new int[global.IMGNUM, global.IMGNUM] ;
        //从1到20，
        bool m_bFirstPoint = true;
        //标记是否是第一次选的图片
        Point m_ptSelFirst, m_ptSelSec;
        //第一次选择的位置，第二次选择的位置
        bool IsPainGameMap = false;
        public GameForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           // label1.Text;
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {

        }

        private void BtnBegin_Click(object sender, EventArgs e)
        {
           int[,] anMap = new int[,] {  { 1, 2, 3, 4 }, { 2, 3, 4, 5 }, { 3, 4, 5, 6 }, { 1, 3,4, 6} };
            //int[,] anMap = new int[global.IMGNUM, global.IMGNUM] { { 17, 18,19, 20 }, { 5, 6, 7, 8}, { 9, 10, 11, 12 }, {13, 14, 15, 16 } };

            Array.Copy(anMap, m_anMap, anMap.Length);
            IsPainGameMap = true;
            panel1.Refresh();
      
            
        }
        private bool PaintGameMap(PaintEventArgs e)
        {
            int length0, length1;
            length0 = m_anMap.GetLength(0);
            length1 = m_anMap.GetLength(1);
            Graphics g = e.Graphics;

            for (int i = 0; i < length0; i++)
            {
                for (int j = 0; j < length1; j++)
                {   
                    if (m_anMap[i, j] >= 1 && m_anMap[i, j] <= 20)
                    {
                         string str = global.RESOURSEPATH + m_anMap[i, j] + ".jpg";
                       
                        Bitmap bitmap = new Bitmap(str);
                        bitmap.MakeTransparent(Color.White);
                        g.DrawImage(bitmap, new Rectangle(j * global.IMGSIZE, i * global.IMGSIZE, global.IMGSIZE, global.IMGSIZE));

                        // g.DrawImage(bitmap, new Rectangle(new Point(j * global.IMGSIZE, i * global.IMGSIZE), new Size(global.IMGSIZE, global.IMGSIZE)));
                        //j*global.IMGSIZE:据左侧的距离，i*global.IMGSIZE：据顶部的距离


                    }
                    else
                    {
                        string str = global.RESOURSEPATH+"0.jpg";
                        Bitmap bitmap = new Bitmap(str);
                        bitmap.MakeTransparent(Color.White);
                        g.DrawImage(bitmap, new Rectangle(j * global.IMGSIZE, i * global.IMGSIZE, global.IMGSIZE, global.IMGSIZE));
                    }
                }
            }           
            return true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if(IsPainGameMap)
            {
                m_ptSelFirst = new Point(-1,0);
                m_ptSelSec = new Point(0, -1);
                m_bFirstPoint = true;
                PaintGameMap(e);

            }
           
        }
        /// <summary>
        /// 当m_ptSelFirst和m_ptSelSec选择的图片相同，而且不是同一张的时候返回true
        /// </summary>
        /// <returns></returns>
        bool IsSameImg()
        {
            
            if(m_ptSelFirst.X<= global.IMGNUM * global.IMGSIZE &&m_ptSelFirst.X>= 0&& m_ptSelFirst.Y<= global.IMGNUM * global.IMGSIZE&&m_ptSelFirst.Y>= 0)
                  if (m_ptSelSec.X <= global.IMGNUM * global.IMGSIZE && m_ptSelSec.X >= 0 && m_ptSelSec.Y <= global.IMGNUM * global.IMGSIZE && m_ptSelSec.Y >= 0)
                return !m_ptSelFirst.Equals(m_ptSelSec)&& m_anMap[ m_ptSelFirst.Y/ global.IMGSIZE, m_ptSelFirst.X / global.IMGSIZE] == m_anMap[ m_ptSelSec.Y/ global.IMGSIZE, m_ptSelSec.X / global.IMGSIZE];
            return false;

        }
        void DrawTipFrame(Pen m_pen,Point pt)//画矩形提示框
        {
            Graphics g = panel1.CreateGraphics();
           
            g.DrawRectangle(m_pen, pt.X, pt.Y, global.IMGSIZE, global.IMGSIZE);
            //g.DrawLines(m_pen, pts);
        }

        private void BtnReboot_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Point panel1point = e.Location;            
            //鼠标相对panel左上角的坐标
                
                if (panel1point.X <= global.IMGSIZE * global.IMGNUM && panel1point.Y <= global.IMGSIZE * global.IMGNUM)
                {//坐标在游戏地图里面
                   
                    
                if (m_bFirstPoint)
                    {
                        m_ptSelFirst.X = (panel1point.X / global.IMGSIZE) * global.IMGSIZE;
                        m_ptSelFirst.Y = (panel1point.Y / global.IMGSIZE) * global.IMGSIZE;
                        DrawTipFrame(Pens.Red, m_ptSelFirst);//画矩形提示框
                        m_bFirstPoint = false;
                    }
                    else
                    {
                        m_ptSelSec.X = (panel1point.X / global.IMGSIZE)*global.IMGSIZE;
                        m_ptSelSec.Y =( panel1point.Y / global.IMGSIZE)*global.IMGSIZE;
                        DrawTipFrame(Pens.Red,m_ptSelSec);//画矩形提示框
                        m_bFirstPoint = true;
                    }
                 }
            Graphics g = panel1.CreateGraphics();
            int x = m_ptSelFirst.X / global.IMGSIZE;
            int y = m_ptSelFirst.Y / global.IMGSIZE;
            if (IsSameImg()&& m_anMap[y, x] != 0)
            {                   
                    m_anMap[y, x] = global.NOIMAGE;
                    x = m_ptSelSec.X / global.IMGSIZE;
                    y = m_ptSelSec.Y / global.IMGSIZE;
                    m_anMap[y, x] = global.NOIMAGE;
                    g.DrawLine(Pens.Blue, m_ptSelFirst.X + global.IMGSIZE / 2, m_ptSelFirst.Y + global.IMGSIZE / 2, m_ptSelSec.X + global.IMGSIZE / 2, m_ptSelSec.Y + global.IMGSIZE / 2);
                    System.Threading.Thread.Sleep(1000);
                    panel1.Refresh();
             }
             else
             {

                if (m_bFirstPoint)
                {
                    System.Threading.Thread.Sleep(500);
                    m_bFirstPoint = true;
                    panel1.Refresh();
                }

            }
            
        }
    }
}
