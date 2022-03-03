using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{

    public partial class Statistics<T>
        where T : struct
    {
        /// <summary>
        /// 母分散が既知の場合の, 母平均の差の検定を行う.
        /// group1MeanIsHiger に true を選択し場合, group1の母平均の方が大きいことを検証する.
        /// </summary>
        /// <param name="alpha"></param>
        /// <param name="group1"></param>
        /// <param name="group2"></param>
        /// <param name="std1"></param>
        /// <param name="std2"></param>
        /// <returns></returns>
        public static bool TestMeansDifference(double alpha, ColumnVector<T> group1, ColumnVector<T> group2, T std1, T std2, bool group1MeanIsHiger)
        {
            double Kp = TableOfNormalDistribution_1Side_PValuetoKp(alpha);

            ColumnVector<T> summary1 = Summary(group1);
            ColumnVector<T> summary2 = Summary(group2);

            double z = (dynamic)((dynamic)summary1[6] - summary2[6]) / Math.Sqrt((dynamic)std1 / group1.Dimension + (dynamic)std2 / group2.Dimension);

            if (group1MeanIsHiger)
            {
                return z > Kp;
            }
            return z < Kp;
        }

    }
}
