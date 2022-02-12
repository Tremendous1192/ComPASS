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
        /// <param name="columnVector"></param>
        /// <returns></returns>
        public static T SumOfSquaredDeviations(T[] columnVector)
        {
            T simpleSum = Statistics<T>.SimpleSum(columnVector);
            T sumOfSquares = Statistics<T>.SumOfSquares(columnVector);

            int n = columnVector.Length;

            return (dynamic)sumOfSquares - (dynamic)simpleSum * simpleSum / n;
        }


    }
}
