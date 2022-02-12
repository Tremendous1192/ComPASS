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
        /// <param name="designMatrix"></param>
        /// <returns></returns>
        public static T[] UnbiasedSampleVariance(T[,] designMatrix)
        {
            T[] unbiasedSampleVariance = Statistics<T>.SumOfSquaredDeviations(designMatrix);
            int nMinus1 = designMatrix.GetLength(0) - 1;

            for (int j = 0; j < unbiasedSampleVariance.Length; j++)
            {
                unbiasedSampleVariance[j] /= (dynamic)nMinus1;
            }

            return unbiasedSampleVariance;
        }


    }
}
