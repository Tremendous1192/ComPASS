using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Statistics<T>
        where T : struct
    {


        /// <summary>
        /// 各要素の自乗の和を返す.
        /// </summary>
        /// <param name="designMatrix"></param>
        /// <returns></returns>
        public static T[] SumOfSquares(T[,] designMatrix)
        {
            T[] sumOfSquares = new T[designMatrix.GetLength(1)];
            for (int i = 0; i < designMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < designMatrix.GetLength(1); j++)
                {
                    sumOfSquares[j] += (dynamic)designMatrix[i, j] * designMatrix[i, j];
                }
            }

            return sumOfSquares;
        }


    }
}
