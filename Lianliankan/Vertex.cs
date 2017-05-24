using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lianliankan
{
    /// <summary>
    /// Vertex:保存游戏地图的行号和值信息
    /// 
    /// </summary>
     class Vertex
    {
        public  int row;         //行
        public int col;         //列
        public int info;       //信息类
        public Vertex()
        {
            row = global.NOIMAGE;
            col = global.NOIMAGE;
        }
        public Vertex(Vertex v)
        {
            row = v.row;
            col = v.col;
            info = v.info;
        }
        public Vertex(int x,int y)
        {
            row = x;
            col = y;
        }
    }
}
