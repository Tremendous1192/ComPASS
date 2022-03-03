using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{

    public partial class Statistics<T>
        where T : struct
    {

        /// <summary>
        /// 母分散が既知の場合の, 母平均の差の点推定を行う.
        /// </summary>
        /// <param name="alpha"></param>
        /// <param name="group1"></param>
        /// <param name="group2"></param>
        /// <returns></returns>
        public static T ExpectMeansDifference(T[] group1, T[] group2)
        {
            T[] summary1 = Summary(group1);
            T[] summary2 = Summary(group2);

            return (dynamic)summary1[6] - summary2[6];
        }

    }
}
