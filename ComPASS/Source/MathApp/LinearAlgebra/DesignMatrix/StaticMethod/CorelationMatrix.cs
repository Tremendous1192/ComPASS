using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class DesignMatrix<T>
        where T : struct
    {


        /// <summary>
        /// 相関係数行列を返す。
        /// </summary>
        /// <param name="designMatrix"></param>
        /// <returns></returns>
        public static Matrix<T> CorelationMatrix(Matrix<T> designMatrix)
        {

            RowVector<T> average = DesignMatrix<T>.Average(designMatrix);

            Matrix<T> corelationMatrix = DesignMatrix<T>.VarianceCovarianceMatrix(designMatrix);


            T[] std = new T[corelationMatrix.RowCount];
            for (int j = 0; j < corelationMatrix.RowCount; j++)
            {
                std[j] = Math.Sqrt((dynamic)corelationMatrix[j, j]);
            }
            for (int j = 0; j < corelationMatrix.RowCount; j++)
            {
                for (int k = 0; k < corelationMatrix.ColumnCount; k++)
                {
                    corelationMatrix[j, k] = (dynamic)corelationMatrix[j, k] / ((dynamic)std[j] * std[k]);
                }
            }

            return corelationMatrix;

        }




    }
}
