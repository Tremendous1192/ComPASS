using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class RowVector<T>
        where T : struct
    {

        /// <summary>
        /// ベクトルの減算を行う。
        /// </summary>
        /// <param name="subtrahendVector"></param>
        /// <returns></returns>
        public RowVector<T> Subtract(RowVector<T> subtrahendVector)
        {
            if (this.Dimension != subtrahendVector.Dimension)
            {
                throw new FormatException("次元が揃っていません");
            }

            T[] result = new T[this.Dimension];
            for (int i = 0; i < this.Dimension; i++) { result[i] = (dynamic)this[i] - subtrahendVector[i]; }

            return new RowVector<T>(result);
        }


        /// <summary>
        /// ベクトルの加算を行う。演算子 "+" のオーバーロード
        /// </summary>
        /// <param name="minuendVector"></param>
        /// <param name="subtrahendVector"></param>
        /// <returns></returns>
        public static RowVector<T> operator -(RowVector<T> minuendVector, RowVector<T> subtrahendVector)
        {
            return minuendVector.Subtract(subtrahendVector);
        }


        /// <summary>
        /// ベクトルの加算を行う。
        /// </summary>
        /// <param name="minuendVector"></param>
        /// <param name="subtrahendVector"></param>
        /// <returns></returns>
        public static RowVector<T> Subtract(RowVector<T> minuendVector, RowVector<T> subtrahendVector)
        {
            if (minuendVector.Dimension != subtrahendVector.Dimension)
            {
                throw new FormatException("次元が揃っていません");
            }

            T[] result = new T[minuendVector.Dimension];
            for (int i = 0; i < minuendVector.Dimension; i++) { result[i] = (dynamic)minuendVector[i] + subtrahendVector[i]; }

            return new RowVector<T>(result);
        }


    }
}
