﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Vector<T>
        where T : struct
    {
        /// <summary>
        /// ベクトルの加算を行う。
        /// </summary>
        /// <param name="otherVector"></param>
        /// <returns></returns>
        public Vector<T> Add(Vector<T> otherVector)
        {
            if (this.Dimension != otherVector.Dimension)
            {
                throw new FormatException("次元が揃っていません");
            }

            T[] result = new T[this.Dimension];
            for (int i = 0; i < this.Dimension; i++) { result[i] = (dynamic)this[i] + otherVector[i]; }

            return new Vector<T>(result);
        }


        /// <summary>
        /// ベクトルの加算を行う。演算子 "+" のオーバーロード
        /// </summary>
        /// <param name="vector01"></param>
        /// <param name="vector02"></param>
        /// <returns></returns>
        public static Vector<T> operator +(Vector<T> vector01, Vector<T> vector02)
        {
            return vector01.Add(vector02);
        }


        /// <summary>
        /// ベクトルの加算を行う。
        /// </summary>
        /// <param name="vector01"></param>
        /// <param name="vector02"></param>
        /// <returns></returns>
        public static Vector<T> Add(Vector<T> vector01, Vector<T> vector02)
        {
            if (vector01.Dimension != vector02.Dimension)
            {
                throw new FormatException("次元が揃っていません");
            }

            T[] result = new T[vector01.Dimension];
            for (int i = 0; i < vector01.Dimension; i++) { result[i] = (dynamic)vector01[i] + vector02[i]; }

            return new Vector<T>(result);
        }

    }
}