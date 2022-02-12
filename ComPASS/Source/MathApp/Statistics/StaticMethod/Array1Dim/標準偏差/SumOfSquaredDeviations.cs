using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Statistics<T>
        where T : struct
    {

        /// <summary>
        /// 偏差平方和を返す.
        /// </summary>
        /// <param name="array1Dim"></param>
        /// <returns></returns>
        public static T SumOfSquaredDeviations(T[] array1Dim)
        {
            T simpleSum = Statistics<T>.SimpleSum(array1Dim);
            T sumOfSquares = Statistics<T>.SumOfSquares(array1Dim);

            int n = array1Dim.Length;

            return (dynamic)sumOfSquares - (dynamic)simpleSum * simpleSum / n;
        }


    }
}
