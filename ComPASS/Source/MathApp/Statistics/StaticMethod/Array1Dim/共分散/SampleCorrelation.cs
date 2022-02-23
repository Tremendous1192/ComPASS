using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Statistics<T>
        where T : struct
    {

        /// <summary>
        /// 標本相関係数行列を返す
        /// </summary>
        /// <param name="array2Dim"></param>
        /// <returns></returns>
        public static T SampleCorrelation(T[] array1, T[] array2)
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

            //標本分散・共分散行列
            T[,] correlationMatrix = Statistics<T>.SampleVarianceCovarianceMatrix(array2Dim);

            //標準偏差計算する
            T[] std = new T[array2Dim.GetLength(1)];
            for (int j = 0; j < correlationMatrix.GetLength(0); j++)
            {
                std[j] = Math.Sqrt((dynamic)correlationMatrix[j, j]);
            }

            //相関係数を計算する。
            for (int j = 0; j < correlationMatrix.GetLength(0); j++)
            {
                for (int k = 0; k < correlationMatrix.GetLength(1); k++)
                {
                    correlationMatrix[j, k] /= (dynamic)std[j] * std[k];
                }
            }

            return correlationMatrix[0, 1];
        }



    }
}
