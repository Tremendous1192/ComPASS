using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class LinearRegression<T>
        where T : struct
    {

        /// <summary>
        /// 回帰直線の値を予測する
        /// </summary>
        /// <param name="dsignMatrixWithoutConctant"></param>
        /// <param name="coefficientW"></param>
        /// <returns></returns>
        public static ColumnVector<T> Regression(Matrix<T> dsignMatrixWithoutConctant, ColumnVector<T> coefficientW)
        {
            var X = LinearRegression<T>.MakeDesignMatrixWithConstant(dsignMatrixWithoutConctant);

            return X * coefficientW;
        }

        /// <summary>
        /// 回帰直線の値を予測する
        /// </summary>
        /// <param name="vectorWithoutConctant"></param>
        /// <param name="coefficientW"></param>
        /// <returns></returns>
        public static T Regression(RowVector<T> vectorWithoutConctant, ColumnVector<T> coefficientW)
        {
            var X = LinearRegression<T>.MakeVectorForLinerRegression(vectorWithoutConctant);

            T[] result = new T[1] { (dynamic)X * coefficientW };


            return (dynamic)X * coefficientW;
        }



    }
}
