using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Statistics<T>
        where T : struct
    {

        /// <summary>
        /// 不偏分散を返す.
        /// </summary>
        /// <param name="designMatrix"></param>
        /// <returns></returns>
        public static RowVector<T> UnbiasedSampleVariance(Matrix<T> designMatrix)
        {
            RowVector<T> unbiasedSampleVariance = Statistics<T>.SumOfSquaredDeviations(designMatrix);
            int nMinus1 = designMatrix.RowCount - 1;

            for (int j = 0; j < unbiasedSampleVariance.Dimension; j++)
            {
                unbiasedSampleVariance[j] /= (dynamic)nMinus1;
            }

            return unbiasedSampleVariance;
        }


    }
}
