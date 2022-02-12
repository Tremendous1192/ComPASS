using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Statistics<T>
        where T : struct
    {

        /// <summary>
        /// 各要素の和を返す.
        /// </summary>
        /// <param name="columnVector"></param>
        /// <returns></returns>
        public static T SimpleSum(T[] columnVector)
        {
            T simpleSum = (dynamic)0;
            for (int i = 0; i < columnVector.Length; i++)
            {
                simpleSum += (dynamic)columnVector[i];
            }

            return simpleSum;
        }


    }
}
