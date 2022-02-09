using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Statistics<T>
        where T : struct
    {
        /// <summary>
        /// 四分位数を返す.
        /// </summary>
        /// <param name="columnVector"></param>
        /// <returns></returns>
        public static T LowerQuartile(ColumnVector<T> columnVector)
        {
            //昇順に並べ替えた配列。
            T[] sorted = Statistics<T>.Sort(columnVector);

            //四分位数は、要素数を4で割ったときのあまりで計算が異なる。
            int lowerQuartilePoint = sorted.GetLength(0) / 4;
            if (sorted.GetLength(0) % 4 < 2)
            {
                return ((dynamic)sorted[lowerQuartilePoint] + sorted[Math.Max(lowerQuartilePoint - 1, 0)]) / 2;
            }
            else
            {
                return sorted[lowerQuartilePoint];
            }
        }


    }
}
