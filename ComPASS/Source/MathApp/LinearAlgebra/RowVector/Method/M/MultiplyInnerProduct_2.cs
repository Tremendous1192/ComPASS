using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class RowVector<T>
        where T : struct
    {

        /// <summary>
        /// ベクトルの内積を返す.
        /// </summary>
        /// <param name="otherVector"></param>
        /// <returns></returns>
        public T MultiplyInnerProduct(ColumnVector<T> otherVector)
        {

            if (this.Dimension != otherVector.Dimension)
            {
                throw new FormatException("次元が揃っていません");
            }

            T result = (dynamic)this[0] * 0;
            for (int i = 0; i < this.Dimension; i++) { result += (dynamic)this[i] * otherVector[i]; }

            return result;
        }


        //列ベクトルの  *  オーバーロードとかぶるので、こちらは封印する
        /*
        /// <summary>
        /// ベクトルの内積を返す.演算子 "*" のオーバーロード
        /// </summary>
        /// <param name="vector01"></param>
        /// <param name="vector02"></param>
        /// <returns></returns>
        public static T operator *(RowVector<T> vector01, ColumnVector<T> vector02)
        {
            if (vector01.Dimension != vector02.Dimension)
            {
                throw new FormatException("次元が揃っていません");
            }

            T result = (dynamic)vector01[0] * 0;
            for (int i = 0; i < vector01.Dimension; i++) { result += (dynamic)vector01[i] * vector02[i]; }

            return result;
        }
        */


        /// <summary>
        /// ベクトルの内積を計算する。
        /// </summary>
        /// <param name="vector01"></param>
        /// <param name="vector02"></param>
        /// <returns></returns>
        public static T Multiply(RowVector<T> vector01, ColumnVector<T> vector02)
        {
            if (vector01.Dimension != vector02.Dimension)
            {
                throw new FormatException("次元が揃っていません");
            }

            T result = (dynamic)vector01[0] * 0;
            for (int i = 0; i < vector01.Dimension; i++) { result += (dynamic)vector01[i] * vector02[i]; }

            return result;

        }



    }
}
