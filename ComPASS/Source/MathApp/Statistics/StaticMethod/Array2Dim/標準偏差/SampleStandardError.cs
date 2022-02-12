using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Statistics<T>
        where T : struct
    {

        /// <summary>
        /// 標準誤差を返す。
        /// </summary>
        /// <param name="designMatrix"></param>
        /// <returns></returns>
        public static T[] SampleStandardError(T[,] designMatrix)
        {
            T dataNumberSQRT = (dynamic)Math.Sqrt((dynamic)designMatrix.GetLength(0));
            T[] standardError = Statistics<T>.SampleStandardDeviation(designMatrix);

            for (int j = 0; j < designMatrix.GetLength(1); j++)
            {
                standardError[j] /= (dynamic)dataNumberSQRT;
            }

            return standardError;
        }


    }
}
