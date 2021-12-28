using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class LinearRegression<T>
        where T : struct
    {

        /// <summary>
        /// 線形回帰用のベクトルを生成する。
        /// </summary>
        /// <param name="vectorWithoutConstant"></param>
        /// <returns></returns>
        public static Vector<T> MakeVectorForLinerRegression(Vector<T> vectorWithoutConstant){
            var vector = new Vector<T>(vectorWithoutConstant.Dimension + 1);

            vector[0] = (dynamic)1;
            for (int i = 0; i < vectorWithoutConstant.Dimension; i++){
                vector[i + 1] = vectorWithoutConstant[i];
            }

            return vector;
        }


        /// <summary>
        /// 計画行列を生成する
        /// </summary>
        /// <param name="matrixWithoutConstant"></param>
        /// <returns></returns>
        public static Matrix<T> MakeDesignMatrixWithConstant(Matrix<T> matrixWithoutConstant) {
            var designMatrix = new Matrix<T>(matrixWithoutConstant.RowCount, matrixWithoutConstant.ColumnCount + 1);
            for (int i=0;i < matrixWithoutConstant.RowCount;i++) {

                designMatrix[i, 0] = (dynamic)1;
                for (int j=0;j < matrixWithoutConstant.ColumnCount;j++){
                    designMatrix[i, j + 1] = matrixWithoutConstant[i, j];
                }
            }

            return designMatrix;
        }

        /// <summary>
        /// 回帰直線の係数を学習する
        /// </summary>
        /// <param name="dsignMatrixWithoutConctant"></param>
        /// <param name="outputYSet"></param>
        /// <returns></returns>
        public static Vector<T> Learn(Matrix<T> dsignMatrixWithoutConctant, Vector<T> outputYSet){

            var X = LinearRegression<T>.MakeDesignMatrixWithConstant(dsignMatrixWithoutConctant);
            var X_T = Matrix<T>.Transpose(X);

            var w = Matrix<T>.Inverse(X_T * X) * X_T * outputYSet;

            return w;
        }

        /// <summary>
        /// 回帰直線の値を予測する
        /// </summary>
        /// <param name="dsignMatrixWithoutConctant"></param>
        /// <param name="coefficientW"></param>
        /// <returns></returns>
        public static Vector<T> Regression(Matrix<T> dsignMatrixWithoutConctant, Vector<T> coefficientW) {
            var X = LinearRegression<T>.MakeDesignMatrixWithConstant(dsignMatrixWithoutConctant);

            return X * coefficientW;
        }

        /// <summary>
        /// 回帰直線の値を予測する
        /// </summary>
        /// <param name="vectorWithoutConctant"></param>
        /// <param name="coefficientW"></param>
        /// <returns></returns>
        public static Vector<T> Regression(Vector<T> vectorWithoutConctant, Vector<T> coefficientW)
        {
            var X = LinearRegression<T>.MakeVectorForLinerRegression(vectorWithoutConctant);

            T[] result = new T[1] { (dynamic)X * coefficientW };


            return new Vector<T>(result);
        }



    }
}
