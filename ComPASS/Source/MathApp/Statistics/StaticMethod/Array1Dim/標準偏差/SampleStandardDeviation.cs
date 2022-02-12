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
        /// <param name="array1Dim"></param>
        /// <returns></returns>
        public static T SampleStandardDeviation(T[] array1Dim)
        {
            T sampleStandardDeviation = Statistics<T>.UnbiasedSampleVariance(array1Dim);
            return (dynamic)Math.Sqrt((dynamic)sampleStandardDeviation);
        }


    }
}
