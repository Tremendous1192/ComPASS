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
        /// <param name="designMatrix"></param>
        /// <returns></returns>
        public static RowVector<T> SimpleSum(Matrix<T> designMatrix)
        {
            RowVector<T> simpleSum = new RowVector<T>(designMatrix.ColumnCount);
            for (int i = 0; i < designMatrix.RowCount; i++)
            {
                for (int j = 0; j < designMatrix.ColumnCount; j++)
                {
                    simpleSum[j] += (dynamic)designMatrix[i, j];
                }
            }

            return simpleSum;
        }


    }
}
