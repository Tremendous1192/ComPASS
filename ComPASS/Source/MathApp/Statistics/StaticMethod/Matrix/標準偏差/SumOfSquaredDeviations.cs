using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Statistics<T>
        where T : struct
    {

        /// <summary>
        /// 偏差平方和を返す.
        /// </summary>
        /// <param name="designMatrix"></param>
        /// <returns></returns>
        public static RowVector<T> SumOfSquaredDeviations(Matrix<T> designMatrix)
        {
            RowVector<T> simpleSum = Statistics<T>.SimpleSum(designMatrix);
            RowVector<T> sumOfSquares = Statistics<T>.SumOfSquares(designMatrix);

            RowVector<T> sumOfSquaredDeviations = new RowVector<T>(designMatrix.ColumnCount);

            int n = designMatrix.RowCount;

            for (int j = 0; j < designMatrix.ColumnCount; j++)
            {
                sumOfSquaredDeviations[j] = (dynamic)sumOfSquares[j] - (dynamic)sumOfSquares[j] * sumOfSquares[j] / n;
            }

            return sumOfSquaredDeviations;
        }


    }
}
