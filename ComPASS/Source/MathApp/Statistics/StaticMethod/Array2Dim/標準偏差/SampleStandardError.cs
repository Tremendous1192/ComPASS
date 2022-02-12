using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Statistics<T>
        where T : struct
    {

        /// <summary>
        /// 標準誤差を返す。
        /// </summary>
        /// <param name="array2Dim"></param>
        /// <returns></returns>
        public static T[] SampleStandardError(T[,] array2Dim)
        {
            T dataNumberSQRT = (dynamic)Math.Sqrt((dynamic)array2Dim.GetLength(0));
            T[] standardError = Statistics<T>.SampleStandardDeviation(array2Dim);

            for (int j = 0; j < array2Dim.GetLength(1); j++)
            {
                standardError[j] /= (dynamic)dataNumberSQRT;
            }

            return standardError;
        }


    }
}
