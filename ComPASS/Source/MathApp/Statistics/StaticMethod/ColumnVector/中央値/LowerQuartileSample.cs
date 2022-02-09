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
        public static T LowerQuartileSample(ColumnVector<T> columnVector)
        {

            //昇順に並べ替えた配列。
            T[] sorted = Statistics<T>.Sort(columnVector);



            T lowerQuartile = columnVector[0];

            //四分位数は、要素数を4で割ったときのあまりで計算が異なる。
            int lower_quartile_point = sorted.GetLength(0) / 4;
            if (sorted.GetLength(0) % 4 < 2)
            {
                lowerQuartile = ((dynamic)sorted[lower_quartile_point] + sorted[Math.Max(lower_quartile_point - 1, 0)]) / 2;
            }
            else
            {
                lowerQuartile = sorted[lower_quartile_point];
            }

            return lowerQuartile;

        }


    }
}
