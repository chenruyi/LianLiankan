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
        private CGameControl m_GameC;
         //private int[,] m_anMap = new int[global.MAPRAMNK, global.MAPRAMNK] ;
        //从1到20，
        bool m_bFirstPoint = true;
        //标记是否是第一次选的图片
       // Vertex m_ptSelFirst, m_ptSelSec;
        //第一次选择的位置，第二次选择的位置
        bool IsPainGameMap = false;
        public GameForm()
        {
            InitializeComponent();
            m_GameC = new CGameControl();
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
     
            m_GameC.StartGame();
            IsPainGameMap = true;
            panel1.Refresh();
      
            
        }
        private bool PaintGameMap(PaintEventArgs e)
        {
            //int[,] m_Map  = new int[global.MAPRAMNK, global.MAPRAMNK];
            //int length0, length1;
            //length0 = m_GameC.m_anMap.GetLength(0);
           // length1 = m_GameC.m_anMap.GetLength(1);
            Graphics g = e.Graphics;
            int elem;
            for (int i = 0; i < global.MAPRAMNK; i++)
            {
                for (int j = 0; j < global.MAPRAMNK; j++)
                {
                    elem = m_GameC.GetElement(i, j);
                    if (elem >= 1 && elem <= 20)
                    {
                        string str = global.RESOURSEPATH + elem + ".jpg";
                        Bitmap bitmap = new Bitmap(str);
                        bitmap.MakeTransparent(Color.White);
                        g.DrawImage(bitmap, new Rectangle(j * global.IMGSIZE, i * global.IMGSIZE, global.IMGSIZE, global.IMGSIZE));
                    }
                    else
                    {
                        string str = global.RESOURSEPATH + "0.jpg";
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
            if (IsPainGameMap)
            {
                //m_ptSelFirst = new Vertex(-1, 0);
               // m_ptSelSec = new Vertex(0, -1);
                m_bFirstPoint = true;
                PaintGameMap(e);       
            }

        }


        private void DrawTipFrame(Pen m_pen, Vertex vt)//画矩形提示框
        {
            Graphics g = panel1.CreateGraphics();

            g.DrawRectangle(m_pen, vt.col * global.IMGSIZE, vt.row * global.IMGSIZE, global.IMGSIZE, global.IMGSIZE);
           
        }

        private void DrawTipLine(Pen m_pen, Vertex[] vt,int num)//画提示线
        {
            Graphics g = panel1.CreateGraphics();
            for(int i=0;i<num-1;i++)
             g.DrawLine(Pens.Blue, vt[i].col * global.IMGSIZE + global.IMGSIZE / 2, vt[i].row * global.IMGSIZE + global.IMGSIZE / 2, vt[i+1].col * global.IMGSIZE + global.IMGSIZE / 2, vt[i+1].row * global.IMGSIZE + global.IMGSIZE / 2);

        }

        private void BtnReboot_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Point panel1point = e.Location;
            //鼠标相对panel左上角的坐标
            Vertex vtSel=new Vertex();
            if (panel1point.X <= global.IMGSIZE * global.IMGNUM && panel1point.Y <= global.IMGSIZE * global.IMGNUM)
            {//坐标在游戏地图里面


                if (m_bFirstPoint)
                {
                   
                    vtSel.col = (panel1point.X / global.IMGSIZE) ;
                    vtSel.row = (panel1point.Y / global.IMGSIZE);
                    if (vtSel.row < global.MAPRAMNK && vtSel.col < global.MAPRAMNK )
                    {
                        m_GameC.SetFirstPoint(vtSel.row, vtSel.col);
                        DrawTipFrame(Pens.Red, vtSel);//画矩形提示框
                        m_bFirstPoint = false;
                    }
                }
                else
                {                  
                    vtSel.col = (panel1point.X / global.IMGSIZE);
                    vtSel.row = (panel1point.Y / global.IMGSIZE);
                    if ( m_GameC.m_anMap[vtSel.row, vtSel.col] != global.NOIMAGE)
                    {
                        m_GameC.SetSecPoint(vtSel.row, vtSel.col);
                        DrawTipFrame(Pens.Red, vtSel);//画矩形提示框
                        m_bFirstPoint = true;
                    }
                }
            }
            if (m_bFirstPoint != true) return;
            Graphics g = panel1.CreateGraphics();
            int nVexnum=0;
            Vertex[] aPath = new Vertex[4];
            for (int i = 0; i < 4; i++)
                aPath[i] = new Vertex();
            if (m_GameC.Link(ref aPath,ref nVexnum) )
            {
                DrawTipLine(Pens.Blue, aPath, nVexnum);
                //g.DrawLine(Pens.Blue, aPath[0].col * global.IMGSIZE + global.IMGSIZE / 2, aPath[0].row * global.IMGSIZE + global.IMGSIZE / 2, aPath[1].col * global.IMGSIZE + global.IMGSIZE / 2, aPath[1].row * global.IMGSIZE + global.IMGSIZE / 2);
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
