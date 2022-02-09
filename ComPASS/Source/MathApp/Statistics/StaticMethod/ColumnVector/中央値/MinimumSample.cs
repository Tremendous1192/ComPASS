using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Statistics<T>
        where T : struct
    {

        /// <summary>
        /// 最小値を返す
        /// </summary>
        /// <param name="columnVector"></param>
        /// <returns></returns>
        public static T MinimumSample(ColumnVector<T> columnVector)
        {
            //昇順に並べ替えた配列。
            T[] sorted = Statistics<T>.Sort(columnVector);

            T min = columnVector[0];
            min = sorted[0];

            return min;
        }

    }
}
