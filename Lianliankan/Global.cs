using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lianliankan
{
    /// <summary>
    /// 定义全局变量
    /// </summary>
   public static class global
    {
         public static int IMGSIZE = 60;//图片尺寸
         public static  int MAPRAMNK = 4;//地图数组的维数
        public static int IMGNUM = 20;//图片的总数，1至IMGNUM.jpg存在
        public static int NOIMAGE = -1;//-1表示没有图片,在资源文件中用0.jpg代表
        public static string RESOURSEPATH = "..//..//Resources//";//到资源的相对路径
    }
}
