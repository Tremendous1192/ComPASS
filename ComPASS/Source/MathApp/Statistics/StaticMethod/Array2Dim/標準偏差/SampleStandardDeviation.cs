using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Statistics<T>
        where T : struct
    {

        /// <summary>
        /// 標準偏差を返す。
        /// </summary>
        /// <param name="array2Dim"></param>
        /// <returns></returns>
        public static T[] SampleStandardDeviation(T[,] array2Dim)
        {
            T[] sampleStandardDeviation = Statistics<T>.UnbiasedSampleVariance(array2Dim);
            for (int j = 0; j < array2Dim.GetLength(1); j++)
            {
                sampleStandardDeviation[j] = (dynamic)Math.Sqrt((dynamic)sampleStandardDeviation[j]);
            }

            return sampleStandardDeviation;
        }


    }
}
