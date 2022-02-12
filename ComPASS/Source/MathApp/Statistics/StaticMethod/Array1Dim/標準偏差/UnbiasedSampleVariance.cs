﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Statistics<T>
        where T : struct
    {

        /// <summary>
        /// 不偏分散を返す.
        /// </summary>
        /// <param name="columnVector"></param>
        /// <returns></returns>
        public static T UnbiasedSampleVariance(T[] columnVector)
        {
            int nMinus1 = columnVector.Length - 1;
            return (dynamic)Statistics<T>.SumOfSquaredDeviations(columnVector) / nMinus1;
        }


    }
}
