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
        /// <param name="designMatrix"></param>
        /// <returns></returns>
        public static RowVector<T> Median(Matrix<T> designMatrix)
        {
            //昇順に並べ替えた配列。
            T[,] sorted = Statistics<T>.Sort(designMatrix);

            T[] median = new T[sorted.GetLength(1)];

            //中央値は、要素数を2で割ったときのあまりで計算が異なる。
            int median_point = sorted.GetLength(0) / 2;
            if (sorted.GetLength(0) % 2 == 0)
            {
                for (int k = 0; k < sorted.GetLength(1); k++)
                {
                    median[k] = ((dynamic)sorted[median_point, k] + sorted[Math.Max(median_point - 1, 0), k]) / 2;
                }
            }
            else
            {
                for (int k = 0; k < sorted.GetLength(1); k++)
                {
                    median[k] = sorted[median_point, k];
                }
            }

            return new RowVector<T>(median);
        }



    }
}
