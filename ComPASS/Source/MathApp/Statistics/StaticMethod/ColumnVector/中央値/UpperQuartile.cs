using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Statistics<T>
        where T : struct
    {

        /// <summary>
        /// 第3四分位数を計算する。
        /// </summary>
        /// <param name="columnVector"></param>
        /// <returns></returns>
        public static T UpperQuartile(ColumnVector<T> columnVector)
        {
            //並べ替え用の配列。
            //design_matrixを計算に用いると参照渡しになるバグがある。
            T[] sorted = Statistics<T>.Sort(columnVector);

            T upperQuartile = columnVector[0];
            //第3四分位数は、要素数を4で割ったときのあまりで計算が異なる。
            int upperQuartilePoint = Math.Max(sorted.GetLength(0) - sorted.GetLength(0) / 4, 0);
            if (sorted.GetLength(0) % 4 < 2)
            {
                return ((dynamic)sorted[upperQuartilePoint] + sorted[Math.Max(upperQuartilePoint - 1, 0)]) / 2;
            }
            else
            {
                upperQuartilePoint = Math.Max(upperQuartilePoint - 1, 0);
                return sorted[upperQuartilePoint];
            }
        }

    }
}
