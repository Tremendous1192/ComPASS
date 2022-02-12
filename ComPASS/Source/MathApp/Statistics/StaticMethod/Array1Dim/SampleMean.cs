using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Statistics<T>
        where T : struct
    {


        /// <summary>
        /// 標本平均を計算する。
        /// </summary>
        /// <param name="columnVector"></param>
        /// <returns></returns>
        public static T SampleMean(T[] columnVector)
        {
            return (dynamic)Statistics<T>.SimpleSum(columnVector) / columnVector.Length;
        }



    }
}
