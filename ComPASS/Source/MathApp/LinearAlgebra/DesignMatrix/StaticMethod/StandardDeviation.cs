using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class DesignMatrix<T>
        where T : struct
    {

        /// <summary>
        /// 各要素の標準偏差を返す。
        /// </summary>
        /// <param name="designMatrix"></param>
        /// <returns></returns>
        public static RowVector<T> StandardDeviation(Matrix<T> designMatrix)
        {
            RowVector<T> average = DesignMatrix<T>.Average(designMatrix);
            T[] average_square = new T[designMatrix.ColumnCount];

            for (int j = 0; j < designMatrix.RowCount; j++)
            {
                for (int k = 0; k < designMatrix.ColumnCount; k++)
                {
                    average_square[k] += (dynamic)designMatrix[j, k] * designMatrix[j, k];
                }
            }
            for (int k = 0; k < designMatrix.ColumnCount; k++)
            {
                average_square[k] /= (dynamic)designMatrix.RowCount;
            }


            T[] result = new T[designMatrix.ColumnCount];

            for (int k = 0; k < designMatrix.ColumnCount; k++)
            {
                result[k] = Math.Sqrt((dynamic)average_square[k] - (dynamic)average[k] * average[k]);
            }

            return new RowVector<T>(result);

        }

    }
}
