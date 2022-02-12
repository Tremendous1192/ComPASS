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
        /// <param name="designMatrix"></param>
        /// <returns></returns>
        public static T[] SumOfSquaredDeviations(T[,] designMatrix)
        {
            T[] simpleSum = Statistics<T>.SimpleSum(designMatrix);
            T[] sumOfSquares = Statistics<T>.SumOfSquares(designMatrix);

            T[] sumOfSquaredDeviations = new T[designMatrix.GetLength(1)];

            int n = designMatrix.GetLength(0);

            for (int j = 0; j < designMatrix.GetLength(1); j++)
            {
                sumOfSquaredDeviations[j] = (dynamic)sumOfSquares[j] - (dynamic)simpleSum[j] * simpleSum[j] / n;
            }

            return sumOfSquaredDeviations;
        }


    }
}
