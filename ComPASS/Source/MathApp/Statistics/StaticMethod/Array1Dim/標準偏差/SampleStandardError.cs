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
        /// <param name="array1Dim"></param>
        /// <returns></returns>
        public static T SampleStandardError(T[] array1Dim)
        {
            return (dynamic)Statistics<T>.SampleStandardDeviation(array1Dim) / Math.Sqrt((dynamic)array1Dim.Length);
        }


    }
}
