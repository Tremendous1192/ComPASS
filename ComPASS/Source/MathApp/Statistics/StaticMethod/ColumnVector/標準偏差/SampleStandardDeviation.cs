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
        /// <param name="columnVector"></param>
        /// <returns></returns>
        public static T SampleStandardDeviation(ColumnVector<T> columnVector)
        {
            T sampleStandardDeviation = Statistics<T>.UnbiasedSampleVariance(columnVector);
            return (dynamic)Math.Sqrt((dynamic)sampleStandardDeviation);
        }


    }
}
