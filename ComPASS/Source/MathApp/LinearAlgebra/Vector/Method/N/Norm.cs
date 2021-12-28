using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Vector<T>
        where T : struct
    {

        /// <summary>
        /// ベクトルのL2ノルムを返す。
        /// </summary>
        /// <returns></returns>
        public T Norm_L2()
        {
            T result = (dynamic)0;

            foreach (T v in vector) { result += (dynamic)v * v; }

            return (dynamic)Math.Sqrt((dynamic)result);
        }


        /// <summary>
        /// ベクトルのL2ノルムを返す。
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static T Norm_L2(Vector<T> input)
        {
            return input.Norm_L2();
        }


    }
}
