using System;
using System.Collections.Generic;
using System.Text;


namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    /// <summary>
    /// 行列計算用のクラス。行列の要素は2重配列[ , ]で表す。 
    /// the class clculating Matrix. Matrix is defined as 2 dim array[ , ].
    /// </summary>
    public partial class Matrix<T>
        where T : struct
    {

        //行列を格納する.
        T[][] matrix;
        int rowCount;
        int columnCount;

    }
}