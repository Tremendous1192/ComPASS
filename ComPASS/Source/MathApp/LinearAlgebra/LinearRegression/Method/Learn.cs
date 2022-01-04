using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class LinearRegression<T>
        where T : struct
    {


        /// <summary>
        /// 回帰直線の係数を学習する
        /// </summary>
        /// <param name="dsignMatrixWithoutConctant"></param>
        /// <param name="outputSetY"></param>
        /// <returns></returns>
        public static ColumnVector<T> Learn(Matrix<T> dsignMatrixWithoutConctant, ColumnVector<T> outputSetY)
        {

            var X = LinearRegression<T>.MakeDesignMatrixWithConstant(dsignMatrixWithoutConctant);
            var X_T = Matrix<T>.Transpose(X);

            var w = Matrix<T>.Inverse(X_T * X) * X_T * outputSetY;

            return w;
        }


        /// <summary>
        /// Ridge回帰で回帰直線の係数を学習する.
        /// </summary>
        /// <param name="dsignMatrixWithoutConctant"></param>
        /// <param name="outputSetY"></param>
        /// <param name="lambda"></param>
        /// <returns></returns>
        public static ColumnVector<T> RidgeLearn(Matrix<T> dsignMatrixWithoutConctant, ColumnVector<T> outputSetY,T lambda)
        {
            if ((dynamic)lambda < 0)
            {
                throw new FormatException("ハイパーパラメータλは正の数でなければなりません");
            }

            var X = LinearRegression<T>.MakeDesignMatrixWithConstant(dsignMatrixWithoutConctant);
            var X_T = Matrix<T>.Transpose(X);

            var lambdaI = new Matrix<T>(X.ColumnCount, X.ColumnCount);
            for (int i = 0; i < X.ColumnCount; i++)
            {
                lambdaI[i, i] = lambda;
            }

            var w = Matrix<T>.Inverse(X_T * X + lambdaI) * X_T * outputSetY;

            return w;
        }


        /// <summary>
        /// LASSSO回帰で回帰直線の係数を学習する
        /// </summary>
        /// <param name="dsignMatrixWithoutConctant"></param>
        /// <param name="outputSetY"></param>
        /// <param name="lambda"></param>
        /// <returns></returns>
        public static ColumnVector<T> LASSOLearn(Matrix<T> dsignMatrixWithoutConctant, ColumnVector<T> outputSetY, T lambda)
        {
            if ((dynamic)lambda < 0)
            {
                throw new FormatException("ハイパーパラメータλは正の数でなければなりません");
            }

            var X = LinearRegression<T>.MakeDesignMatrixWithConstant(dsignMatrixWithoutConctant);
            var X_T = Matrix<T>.Transpose(X);

            var w = Matrix<T>.Inverse(X_T * X ) * X_T * outputSetY;

            var lambdaPer2N = (dynamic)lambda / 2 / X.RowCount;

            var wLASSO = new ColumnVector<T>(w.Dimension);
            for (int i = 0; i < wLASSO.Dimension; i++)
            {
                var sign = w[i];
                var abs = w[i];
                if ((dynamic)w[i] < 0)
                {
                    wLASSO[i] = (dynamic)w[i] + lambdaPer2N;
                }
                else
                {
                    wLASSO[i] = (dynamic)w[i] - lambdaPer2N;
                }
            }

            return w;
        }


    }
}
