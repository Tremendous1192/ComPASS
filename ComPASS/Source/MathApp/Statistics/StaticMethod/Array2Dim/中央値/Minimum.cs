using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Statistics<T>
        where T : struct
    {


   
        /// <summary>
        /// 最小値を返す
        /// </summary>
        /// <param name="array2Dim"></param>
        /// <returns></returns>
        public static T[] Minimum(T[,] array2Dim)
        {
            //昇順に並べ替えた配列。
            T[,] sorted = Statistics<T>.Sort(array2Dim);

            T[] min = new T[sorted.GetLength(1)];
            for (int k = 0; k < sorted.GetLength(1); k++)
            {
                min[k] = sorted[0, k];
            }

            return min;
        }

    }
}
