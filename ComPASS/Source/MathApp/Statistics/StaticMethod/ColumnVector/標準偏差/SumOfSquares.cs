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
        /// <param name="columnVector"></param>
        /// <returns></returns>
        public static T SumOfSquares(ColumnVector<T> columnVector)
        {
            T sumOfSquares = (dynamic)0;
            for (int i = 0; i < columnVector.Dimension; i++)
            {
                sumOfSquares += (dynamic)columnVector[i] * columnVector[i];
            }

            return sumOfSquares;
        }


    }
}
