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
        /// <param name="array1Dim"></param>
        /// <returns></returns>
        public static T Minimum(T[] array1Dim)
        {
            //昇順に並べ替えた配列。
            T[] sorted = Statistics<T>.Sort(array1Dim);

            return sorted[0];
        }

    }
}
