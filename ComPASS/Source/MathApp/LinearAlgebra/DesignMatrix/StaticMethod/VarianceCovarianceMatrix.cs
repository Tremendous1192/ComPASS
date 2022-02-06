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
        public static Matrix<T> VarianceCovarianceMatrix(Matrix<T> designMatrix)
        {

            //Cov(x,y) = E[xy] - E[x]E[y] を計算する。

            //平均ベクトル
            RowVector<T> average = DesignMatrix<T>.Average(designMatrix);

            Matrix<T> varianceCovarianceMatrix = new Matrix<T>(designMatrix.ColumnCount, designMatrix.ColumnCount);

            //j次元目とk次元目の成分の積の平均値を計算する。 E[XY]
            for (int i = 0; i < designMatrix.RowCount; i++)
            {
                for (int j = 0; j < designMatrix.ColumnCount; j++)
                {
                    for (int j2 = j; j2 < designMatrix.ColumnCount; j2++)
                    {
                        varianceCovarianceMatrix[j, j2] += (dynamic)designMatrix[i, j] * designMatrix[i, j2];
                    }
                }
            }
            int n = designMatrix.RowCount;
            for (int j = 0; j < designMatrix.ColumnCount; j++)
            {
                for (int j2 = j; j2 < designMatrix.ColumnCount; j2++)
                {
                    varianceCovarianceMatrix[j, j2] /= (dynamic)n;
                }
            }

            //j次元目の平均値とk次元目の平均値の積を引く。-E[X]E[Y]
            for (int j = 0; j < designMatrix.ColumnCount; j++)
            {
                for (int j2 = j; j2 < designMatrix.ColumnCount; j2++)
                {
                    varianceCovarianceMatrix[j, j2] -= (dynamic)average[j] * average[j2];

                    //j次元目の要素とj2次元目の要素を入れ替えても同じ
                    varianceCovarianceMatrix[j2, j] = varianceCovarianceMatrix[j, j2];
                }
            }

            return varianceCovarianceMatrix;
        }


    }
}
