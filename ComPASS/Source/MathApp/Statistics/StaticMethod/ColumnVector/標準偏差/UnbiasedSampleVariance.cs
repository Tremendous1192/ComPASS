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
        /// <param name="columnVector"></param>
        /// <returns></returns>
        public static T UnbiasedSampleVariance(ColumnVector<T> columnVector)
        {
            int nMinus1 = columnVector.Dimension - 1;
            T unbiasedSampleVariance = (dynamic)Statistics<T>.SumOfSquaredDeviations(columnVector) / nMinus1;

            return unbiasedSampleVariance;
        }


    }
}
