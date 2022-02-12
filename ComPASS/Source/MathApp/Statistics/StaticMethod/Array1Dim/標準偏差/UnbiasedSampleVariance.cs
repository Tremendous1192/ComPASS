using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Statistics<T>
        where T : struct
    {

        /// <summary>
        /// 不偏分散を返す.
        /// </summary>
        /// <param name="array1Dim"></param>
        /// <returns></returns>
        public static T UnbiasedSampleVariance(T[] array1Dim)
        {
            int nMinus1 = array1Dim.Length - 1;
            return (dynamic)Statistics<T>.SumOfSquaredDeviations(array1Dim) / nMinus1;
        }


    }
}
