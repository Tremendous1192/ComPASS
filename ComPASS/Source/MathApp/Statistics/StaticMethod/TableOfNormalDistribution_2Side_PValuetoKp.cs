using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{


    public partial class Statistics<T>
        where T : struct
    {
        /// <summary>
        /// 正規分布表の両側分布を計算して,  
        /// p値から統計量Kpを計算する.
        /// 統計量の有効数字は4桁なので, doubleで返しても良いだろう.
        /// </summary>
        /// <param name="pValue"></param>
        /// <returns></returns>
        public static double TableOfNormalDistribution_2Side_PValuetoKp(double pValue)
        {
            return TableOfNormalDistribution_1Side_PValuetoKp(pValue / 2.0);
        }

    }
}
