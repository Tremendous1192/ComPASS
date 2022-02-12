using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Statistics<T>
        where T : struct
    {

        /// <summary>
        /// 中央値を計算する
        /// </summary>
        /// <param name="array1Dim"></param>
        /// <returns></returns>
        public static T Median(T[] array1Dim)
        {
            //昇順に並べ替えた配列。
            T[] sorted = Statistics<T>.Sort(array1Dim);

            //中央値は、要素数を2で割ったときのあまりで計算が異なる。
            int medianPoint = sorted.GetLength(0) / 2;
            if (sorted.GetLength(0) % 2 == 0)
            {
                return ((dynamic)sorted[medianPoint] + sorted[Math.Max(medianPoint - 1, 0)]) / 2;
            }
            else
            {
                return sorted[medianPoint];
            }
        }



    }
}
