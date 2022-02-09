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
        /// <param name="columnVector"></param>
        /// <returns></returns>
        public static T MedianSample(ColumnVector<T> columnVector)
        {
            //昇順に並べ替えた配列。
            T[] sorted = Statistics<T>.Sort(columnVector);

            T median = columnVector[0];

            //中央値は、要素数を2で割ったときのあまりで計算が異なる。
            int median_point = sorted.GetLength(0) / 2;
            if (sorted.GetLength(0) % 2 == 0)
            {
                median = ((dynamic)sorted[median_point] + sorted[Math.Max(median_point - 1, 0)]) / 2;
            }
            else
            {
                median = sorted[median_point];
            }

            return median;
        }



    }
}
