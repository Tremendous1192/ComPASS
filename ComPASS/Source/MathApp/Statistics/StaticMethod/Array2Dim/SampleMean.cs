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
        /// <param name="designMatrix"></param>
        /// <returns></returns>
        public static T[] SampleMean(T[,] designMatrix)
        {
            T[] sampleMean = Statistics<T>.SimpleSum(designMatrix);
            int n = designMatrix.GetLength(0);

            for (int j = 0; j < sampleMean.Length; j++)
            {
                sampleMean[j] /= (dynamic)n;
            }

            return sampleMean;
        }



    }
}
