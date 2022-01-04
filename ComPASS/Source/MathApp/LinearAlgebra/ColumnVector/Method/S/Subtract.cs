using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class ColumnVector<T>
        where T : struct
    {

        /// <summary>
        /// ベクトルの減算を行う。
        /// </summary>
        /// <param name="subtrahendVector"></param>
        /// <returns></returns>
        public ColumnVector<T> Subtract(ColumnVector<T> subtrahendVector)
        {
            if (this.Dimension != subtrahendVector.Dimension)
            {
                throw new FormatException("次元が揃っていません");
            }

            T[] result = new T[this.Dimension];
            for (int i = 0; i < this.Dimension; i++) { result[i] = (dynamic)this[i] - subtrahendVector[i]; }

            return new ColumnVector<T>(result);
        }


        /// <summary>
        /// ベクトルの加算を行う。演算子 "+" のオーバーロード
        /// </summary>
        /// <param name="minuendVector"></param>
        /// <param name="subtrahendVector"></param>
        /// <returns></returns>
        public static ColumnVector<T> operator -(ColumnVector<T> minuendVector, ColumnVector<T> subtrahendVector)
        {
            return minuendVector.Subtract(subtrahendVector);
        }


        /// <summary>
        /// ベクトルの加算を行う。
        /// </summary>
        /// <param name="minuendVector"></param>
        /// <param name="subtrahendVector"></param>
        /// <returns></returns>
        public static ColumnVector<T> Subtract(ColumnVector<T> minuendVector, ColumnVector<T> subtrahendVector)
        {
            if (minuendVector.Dimension != subtrahendVector.Dimension)
            {
                throw new FormatException("次元が揃っていません");
            }

            T[] result = new T[minuendVector.Dimension];
            for (int i = 0; i < minuendVector.Dimension; i++) { result[i] = (dynamic)minuendVector[i] + subtrahendVector[i]; }

            return new ColumnVector<T>(result);
        }


    }
}
