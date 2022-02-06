using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Statistics<T>
        where T : struct
    {

  
        /// <summary>
        /// 各要素の自乗の和を返す.
        /// </summary>
        /// <param name="designMatrix"></param>
        /// <returns></returns>
        public static RowVector<T> SumOfSquares(Matrix<T> designMatrix)
        {
            RowVector<T> sumOfSquares = new RowVector<T>(designMatrix.ColumnCount);
            for (int i = 0; i < designMatrix.RowCount; i++)
            {
                for (int j = 0; j < designMatrix.ColumnCount; j++)
                {
                    sumOfSquares[j] += (dynamic)designMatrix[i, j] * designMatrix[i, j];
                }
            }

            return sumOfSquares;
        }


    }
}
