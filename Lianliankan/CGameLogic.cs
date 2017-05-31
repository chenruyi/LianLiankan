using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lianliankan
{
    class CGameLogic
    {
        protected Vertex[] m_avPath = new Vertex[4];//保存路径
        protected int m_nVexNum;

        private int[,] m_anMap = new int[global.MAPRAMNK, global.MAPRAMNK];
        //从1到20
        public CGameLogic()
        {
            for (int i = 0; i < 4; i++)
                m_avPath[i] = new Vertex();
            m_nVexNum = 0;
        }
        
        public void PushVertexPath(Vertex v)
        {
            m_avPath[m_nVexNum] = v;
            m_nVexNum++;
        }
        public void PopVertexPath()
        {
            m_nVexNum--;
        }
        public void InitMap(int [,]anMap)
        {
            //int[,] anMap = new int[,] { { 1, 2, 3, 4 }, { 2, 3, 4, 5 }, { 3, 4, 5, 6 }, { 1, 3, 4, 6 } };
            Array.Copy(anMap, m_anMap, anMap.Length);
           
        }

        public bool LinkInRow(int[,] anMap, Vertex v1, Vertex v2)
        {//列号相同判断纵向是否联通

            bool IsLinkInRow = true;
            if (v1.row < v2.row)
            {
                for (int i = v1.row + 1; i < v2.row; i++)
                {
                    if (anMap[ i,v1.col] != global.NOIMAGE)
                    {
                        IsLinkInRow = false;
                    }
                }
            }
            else
            {
                for (int i = v2.row + 1; i < v1.row; i++)
                {
                    if (anMap[ i,v1.col] != global.NOIMAGE)
                    {
                        IsLinkInRow = false;
                    }
                }
            }
            return IsLinkInRow;
        }
        public bool LinkInCol(int[,] anMap, Vertex v1, Vertex v2)
        {//行号相同判断横向是否联通
            bool IsLinkInCol = true;
            if (v1.col < v2.col)
            {
                for (int i = v1.col + 1; i < v2.col; i++)
                {
                    if (anMap[v1.row,i] != global.NOIMAGE)
                    {
                        IsLinkInCol = false;
                    }
                }
            }
            else
            {

                for (int i = v2.col + 1; i < v1.col; i++)
                {
                    if (anMap[v1.row,i] != global.NOIMAGE)
                    {
                        IsLinkInCol = false;
                    }
                }
            }
            return IsLinkInCol;
        }
        /// <summary>
        /// 两条直线消子，判断（nRow1,nCol1)到（nRow1,nCol2)能否联通
        /// </summary>
        /// <param name="anMap"></param>
        /// <param name="nRow"></param>
        /// <param name="Col1">Col1<Col2</param>
        /// <param name="Col2"></param>
        /// <returns></returns>
       public bool LineX(int[,] anMap, int nRow,int Col1,int Col2)
        {
            bool IsLineX = true;
            for(int i=Col1;i<=Col2;i++ )
            {
                if (anMap[nRow, i] != global.NOIMAGE)
                    IsLineX = false;
            }
            return IsLineX;
        }
        /// <summary>
        /// 两条直线消子，判断（nRow1,nCol2)到（nRow2,nCol2)能否联通
        /// </summary>
        /// <param name="anMap"></param>
        /// <param name="nRow1">nrow1< nrow2 </param>
        /// <param name="nRow2"></param>
        /// <param name="nCol"></param>
        /// <returns></returns>
        public bool LineY(int[,] anMap, int nRow1, int nRow2, int nCol)
        {
            bool IsLineY = true;
            for (int i = nRow1; i <=nRow2; i++)
            {
                if (anMap[i,nCol] != global.NOIMAGE)
                    IsLineY = false;
            }
            return IsLineY;
        }
        public bool OneCornerLink(int [,]anMap,Vertex v1,Vertex v2)
        {
            bool IsOneCornerLink = false;
            int nRow1 = v1.row, nRow2 = v2.row;
            int nCol1 = v1.col, nCol2 = v2.col;
            if(nRow1>nRow2)
            {//确保nRow1<nRow2
                int temp = nRow1;
                nRow1 = nRow2;
                nRow2 = temp;
                temp = nCol1;
                nCol1 = nCol2;
                nCol2 = temp;
            }
            if(nCol2<nCol1)
            {//待测试
                //if(LineY(anMap,nRow1+1,nRow2,nCol1)&&LineX(anMap,nRow2,nCol2+1,nCol1))//拐角重复一次
                if (LineY(anMap,nRow1+1,nRow2,nCol1)&&LineX(anMap,nRow2,nCol2+1,nCol1-1))//正好
                {
                    IsOneCornerLink = true;
                    // PushVertexPath(new Vertex(nRow2, nCol1));
                    //未验证
                    PushVertexPath(new Vertex(nCol1,nRow2));
                }
                else if (LineX(anMap,nRow1,nCol2+1,nCol1-1) && LineY(anMap,nRow1,nRow2-1,nCol2))//正好
                {
                    IsOneCornerLink = true;
                    PushVertexPath(new Vertex(  nCol2, nRow1));
                    //未验证
                }
            }
            else
            {
                if (LineY(anMap, nRow1+1, nRow2-1, nCol1) && LineX(anMap, nRow2, nCol1, nCol2-1))
                {
                    IsOneCornerLink = true;
                    PushVertexPath(new Vertex( nCol1, nRow2));
                    //未验证
                }
                else if (LineX(anMap, nRow1, nCol1+1, nCol2-1) && LineY(anMap, nRow1, nRow2-1, nCol2))
                {
                    IsOneCornerLink = true;
                    PushVertexPath(new Vertex( nCol2, nRow1));
                    //未验证
                }
            }

            return IsOneCornerLink;
        }
        public bool TwoConerLink(int[,] anMap, Vertex v1, Vertex v2)
        {
            bool IsTwoConerLink = false;
            //利用之前的函数实现三条直线的消子判断
                for (int i = 0; i < global.MAPRAMNK; i++)
                {
                    if (i != v1.col && anMap[v1.row, i] == global.NOIMAGE)
                    {
                        Vertex v3 = new Vertex(i, v1.row);
                        if (OneCornerLink(anMap, v2, v3))
                        {
                            Vertex v4 = new Vertex();
                            v4 = GetTopVertetPath();
                            PopVertexPath();
                            PushVertexPath(v3);
                            PushVertexPath(v4);
                            IsTwoConerLink = true;
                            break;
                        }
                    }
                }
            if (!IsTwoConerLink)
            {
                for (int i = 0; i < global.MAPRAMNK; i++)
                {
                    if (i != v1.row && anMap[i, v1.col] == global.NOIMAGE)
                    {
                        Vertex v3 = new Vertex(v1.col, i);
                        if (OneCornerLink(anMap, v2, v3))
                        {
                            Vertex v4 = new Vertex();
                            v4 = GetTopVertetPath();
                            PopVertexPath();
                            PushVertexPath(v3);
                            PushVertexPath(v4);
                            IsTwoConerLink = true;
                            break;
                        }
                    }
                }
            }
            return IsTwoConerLink;
        }
        public bool IsLink(int [,] anMap,Vertex v1,Vertex v2)
        {         
         
            PushVertexPath(v1);
            if ((v1.row==v2.row&&LinkInCol(anMap, v1, v2)) || (v1.col==v2.col&&LinkInRow(anMap, v1, v2)))
            {
                PushVertexPath(v2);
                return true;
            }
            else if (OneCornerLink(anMap, v1, v2))
            {
                PushVertexPath(v2);
                return true;
            }
            else if (TwoConerLink(anMap, v1, v2))
            {
                PushVertexPath(v2);
                return true;
            }
            else
            {
                PopVertexPath();
                return false;
            }
        }
        public int GetVexPath(ref Vertex[] avPath)
        {
            for(int i=0;i<m_nVexNum;i++)
            {
                avPath[i] = m_avPath[i];
            }
            return m_nVexNum;
        }
        public void Clear(ref int[,] anMap, Vertex v1,Vertex v2)
        {

            anMap[v1.row, v1.col] = global.NOIMAGE;            
            anMap[v2.row, v2.col] = global.NOIMAGE;

        }
        public Vertex GetTopVertetPath()
        {
            return m_avPath[m_nVexNum-1];
        }
    }
}
