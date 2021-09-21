using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Vector<T>
        where T : struct
    {

        /// <summary>
        /// ベクトルの減算を行う。
        /// </summary>
        /// <param name="subtrahendVector"></param>
        /// <returns></returns>
        public Vector<T> Subtract(Vector<T> subtrahendVector)
        {
            if (this.Dimension != subtrahendVector.Dimension)
            {
                throw new FormatException("次元が揃っていません");
            }

            T[] result = new T[this.Dimension];
            for (int i = 0; i < this.Dimension; i++) { result[i] = (dynamic)this[i] - subtrahendVector[i]; }

            return new Vector<T>(result);
        }


        /// <summary>
        /// ベクトルの加算を行う。演算子 "+" のオーバーロード
        /// </summary>
        /// <param name="minuendVector"></param>
        /// <param name="subtrahendVector"></param>
        /// <returns></returns>
        public static Vector<T> operator -(Vector<T> minuendVector, Vector<T> subtrahendVector)
        {
            return minuendVector.Subtract(subtrahendVector);
        }


        /// <summary>
        /// ベクトルの加算を行う。
        /// </summary>
        /// <param name="minuendVector"></param>
        /// <param name="subtrahendVector"></param>
        /// <returns></returns>
        public static Vector<T> Subtract(Vector<T> minuendVector, Vector<T> subtrahendVector)
        {
            if (minuendVector.Dimension != subtrahendVector.Dimension)
            {
                throw new FormatException("次元が揃っていません");
            }

            T[] result = new T[minuendVector.Dimension];
            for (int i = 0; i < minuendVector.Dimension; i++) { result[i] = (dynamic)minuendVector[i] + subtrahendVector[i]; }

            return new Vector<T>(result);
        }


    }
}
