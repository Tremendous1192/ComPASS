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
        /// <param name="columnVector"></param>
        /// <returns></returns>
        public static T SampleMean(ColumnVector<T> columnVector)
        {
            T sampleMean = Statistics<T>.SimpleSum(columnVector);
            int n = columnVector.Dimension;

            sampleMean /= (dynamic)n;

            return sampleMean;
        }



    }
}
