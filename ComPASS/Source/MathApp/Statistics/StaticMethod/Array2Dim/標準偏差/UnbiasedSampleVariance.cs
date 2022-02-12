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
        /// <param name="array2Dim"></param>
        /// <returns></returns>
        public static T[] UnbiasedSampleVariance(T[,] array2Dim)
        {
            T[] unbiasedSampleVariance = Statistics<T>.SumOfSquaredDeviations(array2Dim);
            int nMinus1 = array2Dim.GetLength(0) - 1;

            for (int j = 0; j < unbiasedSampleVariance.Length; j++)
            {
                unbiasedSampleVariance[j] /= (dynamic)nMinus1;
            }

            return unbiasedSampleVariance;
        }


    }
}
