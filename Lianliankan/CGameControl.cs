using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lianliankan
{
    class CGameControl
    {        
        public int[,] m_anMap =new int [global.MAPRAMNK, global.MAPRAMNK];
        private Vertex m_svSelFst;//第一个点
        private Vertex m_svSelSec;//第二个点
      
        public CGameControl()
        {
            
            m_svSelFst = new Vertex();
            m_svSelSec = new Vertex();
            
        }
       
        //private CGameLogic gameLogic;
        public void StartGame()
        {
          //int[,] anMap = new int[,] { { 1, 2, 3, 4 }, { 2, 3, 4, 5 }, { 3, 4, 5, 6 }, { 1, 3, 4, 6 } };
            //int[,] anMap = new int[,] { { 1,1,1,1 }, { -1,-1,-1,-1}, { 1, 1, 2, 3 }, { 1, 2, 3, 3 } };
            int[,] anMap = new int[,] { { 1, 1, 1, 1 }, {1 , 1, 1, 2 }, { 1, 1, 2, 3 }, { 1, 2, 3, 3 } };

            Array.Copy(anMap, m_anMap, anMap.Length);
            CGameLogic gameLogic=new CGameLogic();
            gameLogic.InitMap(m_anMap);
        }
        public int GetElement(int nRow,int nCol)
        {
             return m_anMap[nRow, nCol];
        }
        public void SetElement(int nRow, int nCol,int value)
        {
            m_anMap[nRow, nCol] = value;
        }
        
        public void SetFirstPoint(int nRow,int nCol)
        {
            m_svSelFst.row = nRow;
            m_svSelFst.col = nCol;
        }
        public void SetSecPoint(int nRow,int nCol)
        {
            m_svSelSec.row = nRow;
            m_svSelSec.col = nCol;
        }
        /// <summary>
        /// 未完成，ref待查
        /// </summary>
        /// <param name="avPath"></param>
        /// <returns></returns>
        public bool Link(ref Vertex[] avPath,ref int nVexnum)
        {
          
            ///两者是同一位置的图片
            if (m_svSelFst.col==m_svSelSec.col&&m_svSelFst.row==m_svSelSec.row)
                return false;
            ///图片不相同
            if (m_anMap[m_svSelFst.row, m_svSelFst.col] != m_anMap[m_svSelSec.row, m_svSelSec.col])
                return false;
            CGameLogic gameLogic=new CGameLogic();
            if (gameLogic.IsLink(m_anMap, m_svSelFst, m_svSelSec))
            {
                gameLogic.Clear(ref m_anMap, m_svSelFst, m_svSelSec);
                nVexnum = gameLogic.GetVexPath( ref avPath);
                return true;               
            }
            return false;
        }
    }
}
