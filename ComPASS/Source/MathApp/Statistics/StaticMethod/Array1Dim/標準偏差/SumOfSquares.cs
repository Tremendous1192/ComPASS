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
        /// <param name="array1Dim"></param>
        /// <returns></returns>
        public static T SumOfSquares(T[] array1Dim)
        {
            T sumOfSquares = (dynamic)0;
            for (int i = 0; i < array1Dim.Length; i++)
            {
                sumOfSquares += (dynamic)array1Dim[i] * array1Dim[i];
            }

            return sumOfSquares;
        }


    }
}
