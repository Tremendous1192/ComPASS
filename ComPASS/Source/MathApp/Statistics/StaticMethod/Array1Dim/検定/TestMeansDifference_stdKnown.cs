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
        /// 2群の母平均の差が 0 ではないことを検証する.
        /// </summary>
        /// <param name="alpha"></param>
        /// <param name="group1"></param>
        /// <param name="group2"></param>
        /// <param name="std1"></param>
        /// <param name="std2"></param>
        /// <returns></returns>
        public static bool TestMeansDifference(double alpha, T[] group1, T[] group2, T std1, T std2)
        {
            double Kp = TableOfNormalDistribution_2Side_PValuetoKp(alpha);

            T[] summary1 = Summary(group1);
            T[] summary2 = Summary(group2);

            double z = (dynamic)Math.Abs((dynamic)summary1[6] - summary2[6]) / Math.Sqrt((dynamic)std1 / group1.Length + (dynamic)std2 / group2.Length);

            return z > Kp;
        }

    }
}
