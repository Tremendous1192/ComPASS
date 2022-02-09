using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Statistics<T>
        where T : struct
    {

        /// <summary>
        /// 標本分散・標本共分散行列を計算する
        /// </summary>
        /// <param name="designMatrix"></param>
        /// <returns></returns>
        public static Matrix<T> SampleVarianceCovarianceMatrix(Matrix<T> designMatrix)
        {
            //各要素の和
            RowVector<T> simpleSum = Statistics<T>.SimpleSum(designMatrix);

            Matrix<T> sampleVarianceCovarianceMatrix = new Matrix<T>(designMatrix.ColumnCount, designMatrix.ColumnCount);
            //各要素の積和を計算する Σ(XY)
            for (int i = 0; i < designMatrix.RowCount; i++)
            {
                for (int j = 0; j < designMatrix.ColumnCount; j++)
                {
                    for (int j2 = 0; j2 < designMatrix.ColumnCount; j2++)
                    {
                        sampleVarianceCovarianceMatrix[j, j2] += (dynamic)designMatrix[i, j] * designMatrix[i, j2];
                    }
                }
            }
            //各要素の和の積を引く Σ(XY) - (ΣX)(ΣY)/n
            int n = designMatrix.RowCount;
            for (int j = 0; j < designMatrix.ColumnCount; j++)
            {
                for (int j2 = 0; j2 < designMatrix.ColumnCount; j2++)
                {
                    sampleVarianceCovarianceMatrix[j, j2] -= (dynamic)simpleSum[j] * simpleSum[j2] / n;
                }
            }

            int nMinus1 = designMatrix.RowCount - 1;
            for (int j = 0; j < designMatrix.ColumnCount; j++)
            {
                for (int j2 = 0; j2 < designMatrix.ColumnCount; j2++)
                {
                    sampleVarianceCovarianceMatrix[j, j2] /= (dynamic)nMinus1;
                }
            }

            return sampleVarianceCovarianceMatrix;
        }




    }
}
