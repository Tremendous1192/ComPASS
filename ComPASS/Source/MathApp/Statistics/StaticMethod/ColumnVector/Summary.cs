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
        /// [0] 最小値,  
        /// [1] 第一四分位数,  
        /// [2] 中央値,  
        /// [3] 第三四分位数,  
        /// [4] 最大値,  
        /// [5] 平均値,  
        /// [6] 偏差平方和,  
        /// [7] 不偏標本分散,  
        /// [8] 標本標準偏差,  
        /// [9] 標本標準誤差
        /// </summary>
        /// <param name="columnVector"></param>
        /// <returns></returns>
        public static ColumnVector<T> Summary(ColumnVector<T> columnVector)
        {
            //昇順に並べ替えた配列。
            T[] sorted = Statistics<T>.Sort(columnVector);

            //解析結果
            T[] summary = new T[10];

            //[0] 最小値
            //[4] 最大値
            summary[0] = sorted[0];
            summary[4] = sorted[sorted.GetLength(0) - 1];

            //[2] 中央値
            int median_point = sorted.GetLength(0) / 2;
            if (sorted.GetLength(0) % 2 == 0)
            {
                summary[2] = ((dynamic)sorted[median_point] + sorted[Math.Max(median_point - 1, 0)]) / 2;
            }
            else
            {
                summary[2] = sorted[median_point];
            }

            //[1] 第一四分位数
            //[3] 第三四分位数
            int lowerQuartilePoint = sorted.GetLength(0) / 4;
            int upperQuartilePoint = Math.Max(sorted.GetLength(0) - sorted.GetLength(0) / 4, 0);
            if (sorted.GetLength(0) % 4 < 2)
            {
                summary[1] = ((dynamic)sorted[lowerQuartilePoint] + sorted[Math.Max(lowerQuartilePoint - 1, 0)]) / 2;
                summary[3] = ((dynamic)sorted[upperQuartilePoint] + sorted[Math.Max(upperQuartilePoint - 1, 0)]) / 2;
            }
            else
            {
                upperQuartilePoint = Math.Max(upperQuartilePoint - 1, 0);
                summary[1] = sorted[lowerQuartilePoint];
                summary[3] = sorted[upperQuartilePoint];
            }

            //[5] 平均値
            T mean = Statistics<T>.SampleMean(columnVector);
            summary[5] = mean;

            //[6] 偏差平方和
            T unbiasedSampleVariance = Statistics<T>.UnbiasedSampleVariance(columnVector);
            summary[6] = unbiasedSampleVariance;

            //[7] 不偏標本分散
            //[8] 標本標準偏差
            //[9] 標本標準誤差
            int nMinus1 = columnVector.Dimension - 1;
            double dataNumberSQRT = (dynamic)Math.Sqrt((dynamic)columnVector.Dimension);
            summary[7] = (dynamic)summary[6] / nMinus1;
            summary[8] = (dynamic)Math.Sqrt((dynamic)summary[7]);
            summary[9] = (dynamic)summary[8] / dataNumberSQRT;

            return new ColumnVector<T>(summary);
        }



    }
}
