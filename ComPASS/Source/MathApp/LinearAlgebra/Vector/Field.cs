using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    /// <summary>
    /// ベクトル計算用のクラス。各要素は配列[ ]で表す。
    /// 基本的に、行ベクトルと列ベクトルを区別しない。
    /// the class calculating Vector. Vector is defined as double[].
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class Vector<T>
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
