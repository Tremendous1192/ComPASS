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
        public static T SampleCorrelation(ColumnVector<T> columnVector1, ColumnVector<T> columnVector2)
        {

            if (columnVector1.Dimension != columnVector2.Dimension)
            {
                throw new FormatException("データ数が揃っていません");
            }
            Matrix<T> designMatrix = new Matrix<T>(columnVector1.Dimension, 2);
            for (int i = 0; i < columnVector1.Dimension; i++)
            {
                designMatrix[i, 0] = columnVector1[i];
                designMatrix[i, 1] = columnVector2[i];
            }


            //標本分散・共分散行列
            Matrix<T> correlationMatrix = Statistics<T>.SampleVarianceCovarianceMatrix(designMatrix);

            //標準偏差計算する
            T[] std = new T[designMatrix.ColumnCount];
            for (int j = 0; j < correlationMatrix.RowCount; j++)
            {
                std[j] = Math.Sqrt((dynamic)correlationMatrix[j, j]);
            }

            //相関係数を計算する。
            for (int j = 0; j < correlationMatrix.RowCount; j++)
            {
                for (int k = 0; k < correlationMatrix.ColumnCount; k++)
                {
                    correlationMatrix[j, k] /= (dynamic)std[j] * std[k];
                }
            }

            return correlationMatrix[0, 1];
        }



    }
}
