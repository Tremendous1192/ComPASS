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
        /// <param name="array1Dim"></param>
        /// <returns></returns>
        public static T SampleMean(T[] array1Dim)
        {
            return (dynamic)Statistics<T>.SimpleSum(array1Dim) / array1Dim.Length;
        }



    }
}
