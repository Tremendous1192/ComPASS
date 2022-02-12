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
        /// <param name="designMatrix"></param>
        /// <returns></returns>
        public static T[,] SampleCorrelationMatrix(T[,] designMatrix)
        {
            //標本分散・共分散行列
            T[,] correlationMatrix = Statistics<T>.SampleVarianceCovarianceMatrix(designMatrix);

            //標準偏差計算する
            T[] std = new T[designMatrix.GetLength(1)];
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

            return correlationMatrix;
        }



    }
}
