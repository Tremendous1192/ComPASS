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
        /// <param name="array2Dim"></param>
        /// <returns></returns>
        public static T[] SumOfSquaredDeviations(T[,] array2Dim)
        {
            T[] simpleSum = Statistics<T>.SimpleSum(array2Dim);
            T[] sumOfSquares = Statistics<T>.SumOfSquares(array2Dim);

            T[] sumOfSquaredDeviations = new T[array2Dim.GetLength(1)];

            int n = array2Dim.GetLength(0);

            for (int j = 0; j < array2Dim.GetLength(1); j++)
            {
                sumOfSquaredDeviations[j] = (dynamic)sumOfSquares[j] - (dynamic)simpleSum[j] * simpleSum[j] / n;
            }

            return sumOfSquaredDeviations;
        }


    }
}
