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
        /// <param name="array2Dim"></param>
        /// <returns></returns>
        public static T[] LowerQuartile(T[,] array2Dim)
        {
            //昇順に並べ替えた配列。
            T[,] sorted = Statistics<T>.Sort(array2Dim);

            T[] lowerQuartile = new T[ sorted.GetLength(1)];

            //四分位数は、要素数を4で割ったときのあまりで計算が異なる。
            int lower_quartile_point = sorted.GetLength(0) / 4;
            if (sorted.GetLength(0) % 4 < 2)
            {
                for (int k = 0; k < sorted.GetLength(1); k++)
                {
                    lowerQuartile[k] = ((dynamic)sorted[lower_quartile_point, k] + sorted[Math.Max(lower_quartile_point - 1, 0), k]) / 2;
                }
            }
            else
            {
                for (int k = 0; k < sorted.GetLength(1); k++)
                {
                    lowerQuartile[ k] = sorted[lower_quartile_point, k];
                }
            }

            return lowerQuartile;
        }


    }
}
