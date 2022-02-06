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
        /// <param name="designMatrix"></param>
        /// <returns></returns>
        public static RowVector<T> MaximumSample(Matrix<T> designMatrix)
        {

            //昇順に並べ替えた配列。
            T[,] sorted = Statistics<T>.Sort(designMatrix);


            T[] max = new T[sorted.GetLength(1)];
            for (int k = 0; k < sorted.GetLength(1); k++)
            {
                max[k] = sorted[sorted.GetLength(0) - 1, k];
            }

            return new RowVector<T>(max);

        }



    }
}
