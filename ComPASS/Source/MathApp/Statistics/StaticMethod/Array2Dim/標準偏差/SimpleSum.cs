using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Statistics<T>
        where T : struct
    {

        /// <summary>
        /// 各要素の和を返す.
        /// </summary>
        /// <param name="array2Dim"></param>
        /// <returns></returns>
        public static T[] SimpleSum(T[,] array2Dim)
        {
            T[] simpleSum = new T[array2Dim.GetLength(1)];
            for (int i = 0; i < array2Dim.GetLength(0); i++)
            {
                for (int j = 0; j < array2Dim.GetLength(1); j++)
                {
                    simpleSum[j] += (dynamic)array2Dim[i, j];
                }
            }

            return simpleSum;
        }


    }
}
