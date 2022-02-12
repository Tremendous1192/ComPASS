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
        public static T[,] SampleVarianceCovarianceMatrix(T[,] designMatrix)
        {
            //各要素の和
            T[] simpleSum = Statistics<T>.SimpleSum(designMatrix);

            T[,] sampleVarianceCovarianceMatrix = new T[designMatrix.GetLength(1), designMatrix.GetLength(1)];
            //各要素の積和を計算する Σ(XY)
            for (int i = 0; i < designMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < designMatrix.GetLength(1); j++)
                {
                    for (int j2 = 0; j2 < designMatrix.GetLength(1); j2++)
                    {
                        sampleVarianceCovarianceMatrix[j, j2] += (dynamic)designMatrix[i, j] * designMatrix[i, j2];
                    }
                }
            }
            //各要素の和の積を引く Σ(XY) - (ΣX)(ΣY)/n
            int n = designMatrix.GetLength(0);
            for (int j = 0; j < designMatrix.GetLength(1); j++)
            {
                for (int j2 = 0; j2 < designMatrix.GetLength(1); j2++)
                {
                    sampleVarianceCovarianceMatrix[j, j2] -= (dynamic)simpleSum[j] * simpleSum[j2] / n;
                }
            }

            int nMinus1 = designMatrix.GetLength(0) - 1;
            for (int j = 0; j < designMatrix.GetLength(1); j++)
            {
                for (int j2 = 0; j2 < designMatrix.GetLength(1); j2++)
                {
                    sampleVarianceCovarianceMatrix[j, j2] /= (dynamic)nMinus1;
                }
            }

            return sampleVarianceCovarianceMatrix;
        }




    }
}
