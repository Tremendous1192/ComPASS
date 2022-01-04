using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class DesignMatrix<T>
        where T : struct
    {

        /// <summary>
        /// 分散・共分散行列を返す。
        /// </summary>
        /// <param name="designMatrix"></param>
        /// <returns></returns>
        public static Matrix<T> VarianceCovarianceMatrix(Matrix<T> designMatrix) {

            //Cov(x,y) = E[xy] - E[x]E[y] を計算する。

            RowVector<T> average = DesignMatrix<T>.Average(designMatrix);

            Matrix<T> varianceCovarianceMatrix = new Matrix<T>(designMatrix.ColumnCount, designMatrix.ColumnCount);

            //分散・共分散行列の要素[j,k]を計算する。
            for (int j = 0; j < designMatrix.ColumnCount; j++)
            {
                for (int k = j; k < designMatrix.ColumnCount; k++)
                {

                    //j次元目とk次元目の積の平均値を計算する。 E[XY]
                    for (int n = 0; n < designMatrix.RowCount; n++)
                    {
                        varianceCovarianceMatrix[j, k] += (dynamic)designMatrix[n, j] * designMatrix[n, k];
                    }
                    varianceCovarianceMatrix[j, k] /= (dynamic)designMatrix.RowCount;

                    //j次元目の平均値とk次元目の平均値の積を引く。-E[X]E[Y]
                    varianceCovarianceMatrix[j, k] -= (dynamic)average[j] * average[k];

                    //j , kを入れ替えても値は同じ
                    varianceCovarianceMatrix[k, j] = (dynamic)varianceCovarianceMatrix[j, k];
                }
            }

            return varianceCovarianceMatrix;
        }


    }
}
