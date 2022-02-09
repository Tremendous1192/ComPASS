using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Statistics<T>
        where T : struct
    {

        /// <summary>
        /// 最大値を返す.
        /// </summary>
        /// <param name="columnVector"></param>
        /// <returns></returns>
        public static T Maximum(ColumnVector<T> columnVector)
        {
            //昇順に並べ替えた配列。
            T[] sorted = Statistics<T>.Sort(columnVector);

            return sorted[sorted.GetLength(0) - 1];
        }



    }
}
