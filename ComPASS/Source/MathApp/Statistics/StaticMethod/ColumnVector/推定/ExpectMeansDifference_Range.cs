using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{


    public partial class Statistics<T>
        where T : struct
    {
        /// <summary>
        /// 母分散が既知の場合の, 母平均の差の区間推定を行う.
        /// </summary>
        /// <param name="alpha"></param>
        /// <param name="group1"></param>
        /// <param name="group2"></param>
        /// <param name="std1"></param>
        /// <param name="std2"></param>
        /// <returns></returns>
        public static T[] ExpectMeansDifference(double alpha, ColumnVector<T> group1, ColumnVector<T> group2, T std1, T std2)
        {
            double Kp = TableOfNormalDistribution_2Side_PValuetoKp(alpha);

            ColumnVector<T> summary1 = Summary(group1);
            ColumnVector<T> summary2 = Summary(group2);

            double difference = (dynamic)summary1[6] - summary2[6];
            double std = Math.Sqrt((dynamic)std1 / group1.Dimension + (dynamic)std2 / group2.Dimension);

            return new T[2] { difference - (dynamic)Kp * std, difference + (dynamic)Kp * std };
        }

    }
}
