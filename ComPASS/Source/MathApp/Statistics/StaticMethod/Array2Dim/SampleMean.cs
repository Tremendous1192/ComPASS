using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Statistics<T>
        where T : struct
    {


        /// <summary>
        /// 標本平均を計算する。
        /// </summary>
        /// <param name="array2Dim"></param>
        /// <returns></returns>
        public static T[] SampleMean(T[,] array2Dim)
        {
            T[] sampleMean = Statistics<T>.SimpleSum(array2Dim);
            int n = array2Dim.GetLength(0);

            for (int j = 0; j < sampleMean.Length; j++)
            {
                sampleMean[j] /= (dynamic)n;
            }

            return sampleMean;
        }



    }
}
