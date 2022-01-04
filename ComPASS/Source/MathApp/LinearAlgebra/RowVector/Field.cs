using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    /// <summary>
    /// 行ベクトル計算用のクラス。各要素は配列[ ]で表す。
    /// the row vector class. Vector is defined like double[].
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class RowVector<T>
        where T : struct
    {

        /// <summary>
        /// ベクトルを格納する配列
        /// </summary>
        T[] vector;

        /// <summary>
        /// ベクトルの次元
        /// </summary>
        int dimensionCount;


    }
}
