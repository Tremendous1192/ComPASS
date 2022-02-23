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
        /// <param name="array2Dim"></param>
        /// <returns></returns>
        public static T SampleVarianceCovarianceMatrix(T[] array1,T[] array2)
        {
            if (array1.Length != array2.Length)
            {
                throw new FormatException("データ数が揃っていません");
            }

            T[,] array2Dim = new T[array1.Length, 2];
            for (int i = 0; i < array1.Length; i++)
            {
                array2Dim[i, 0] = array1[i];
                array2Dim[i, 1] = array2[i];
            }

            //各要素の和
            T[] simpleSum = Statistics<T>.SimpleSum(array2Dim);

            T[,] sampleVarianceCovarianceMatrix = new T[array2Dim.GetLength(1), array2Dim.GetLength(1)];
            //各要素の積和を計算する Σ(XY)
            for (int i = 0; i < array2Dim.GetLength(0); i++)
            {
                for (int j = 0; j < array2Dim.GetLength(1); j++)
                {
                    for (int j2 = 0; j2 < array2Dim.GetLength(1); j2++)
                    {
                        sampleVarianceCovarianceMatrix[j, j2] += (dynamic)array2Dim[i, j] * array2Dim[i, j2];
                    }
                }
            }
            //各要素の和の積を引く Σ(XY) - (ΣX)(ΣY)/n
            int n = array2Dim.GetLength(0);
            for (int j = 0; j < array2Dim.GetLength(1); j++)
            {
                for (int j2 = 0; j2 < array2Dim.GetLength(1); j2++)
                {
                    sampleVarianceCovarianceMatrix[j, j2] -= (dynamic)simpleSum[j] * simpleSum[j2] / n;
                }
            }

            int nMinus1 = array2Dim.GetLength(0) - 1;
            for (int j = 0; j < array2Dim.GetLength(1); j++)
            {
                for (int j2 = 0; j2 < array2Dim.GetLength(1); j2++)
                {
                    sampleVarianceCovarianceMatrix[j, j2] /= (dynamic)nMinus1;
                }
            }

            return sampleVarianceCovarianceMatrix[0, 1];
        }




    }
}
