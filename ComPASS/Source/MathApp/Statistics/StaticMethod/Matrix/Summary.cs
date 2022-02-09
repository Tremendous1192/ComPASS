using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Statistics<T>
        where T : struct
    {



        /// <summary>
        /// 基本的な統計量を返す.
        /// [0,*] 最小値
        /// [1,*] 第一四分位数
        /// [2,*] 中央値
        /// [3,*] 第三四分位数
        /// [4,*] 最大値
        /// [5,*] 平均値
        /// [6,*] 偏差平方和
        /// [7,*] 不偏標本分散
        /// [8,*] 標本標準偏差
        /// [9,*] 標本標準誤差
        /// </summary>
        /// <param name="designMatrix"></param>
        /// <returns></returns>
        public static Matrix<T> Summary(Matrix<T> designMatrix)
        {
            //昇順に並べ替えた配列。
            T[,] sorted = Statistics<T>.Sort(designMatrix);


            //解析結果
            T[,] summary = new T[10, sorted.GetLength(1)];


            //[0,*] 最小値
            //[4,*] 最大値
            for (int k = 0; k < summary.GetLength(1); k++)
            {
                summary[0, k] = sorted[0, k];
                summary[4, k] = sorted[sorted.GetLength(0) - 1, k];
            }


            //[2,*] 中央値
            int median_point = sorted.GetLength(0) / 2;
            if (sorted.GetLength(0) % 2 == 0)
            {
                for (int k = 0; k < sorted.GetLength(1); k++)
                {
                    summary[2, k] = ((dynamic)sorted[median_point, k] + sorted[Math.Max(median_point - 1, 0), k]) / 2;
                }
            }
            else
            {
                for (int k = 0; k < sorted.GetLength(1); k++)
                {
                    summary[2, k] = sorted[median_point, k];
                }
            }

            //[1,*] 第一四分位数
            //[3,*] 第三四分位数
            int lower_quartile_point = sorted.GetLength(0) / 4;
            int upper_quartile_point = Math.Max(sorted.GetLength(0) - sorted.GetLength(0) / 4, 0);
            if (sorted.GetLength(0) % 4 < 2)
            {
                for (int k = 0; k < sorted.GetLength(1); k++)
                {
                    summary[1, k] = ((dynamic)sorted[lower_quartile_point, k] + sorted[Math.Max(lower_quartile_point - 1, 0), k]) / 2;
                    summary[3, k] = ((dynamic)sorted[upper_quartile_point, k] + sorted[Math.Max(upper_quartile_point - 1, 0), k]) / 2;
                }
            }
            else
            {
                upper_quartile_point = Math.Max(upper_quartile_point - 1, 0);
                for (int k = 0; k < sorted.GetLength(1); k++)
                {
                    summary[1, k] = sorted[lower_quartile_point, k];
                    summary[3, k] = sorted[upper_quartile_point, k];
                }
            }


            //[5,*] 平均値
            RowVector<T> mean = Statistics<T>.SampleMean(designMatrix);
            for (int j = 0; j < mean.Dimension; j++)
            {
                summary[5, j] = mean[j];
            }


            //[6,*] 偏差平方和
            RowVector<T> unbiasedSampleVariance = Statistics<T>.UnbiasedSampleVariance(designMatrix);
            for (int j = 0; j < unbiasedSampleVariance.Dimension; j++)
            {
                summary[6, j] = unbiasedSampleVariance[j];
            }


            //[7,*] 不偏標本分散
            //[8,*] 標本標準偏差
            //[9,*] 標本標準誤差
            int nMinus1 = designMatrix.RowCount - 1;
            double dataNumberSQRT = (dynamic)Math.Sqrt((dynamic)designMatrix.RowCount);
            for (int k = 0; k < designMatrix.ColumnCount; k++)
            {
                summary[7, k] = (dynamic)summary[6, k] / nMinus1;
                summary[8, k] = (dynamic)Math.Sqrt((dynamic)summary[7, k]);
                summary[9, k] = (dynamic)summary[8, k] / dataNumberSQRT;
            }


            return new Matrix<T>(summary);
        }



    }
}
