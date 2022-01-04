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
        public static RowVector<T> MakeVectorForLinerRegression(RowVector<T> vectorWithoutConstant)
        {
            var vector = new RowVector<T>(vectorWithoutConstant.Dimension + 1);

            vector[0] = (dynamic)1;
            for (int i = 0; i < vectorWithoutConstant.Dimension; i++)
            {
                vector[i + 1] = vectorWithoutConstant[i];
            }

            return vector;
        }


        /// <summary>
        /// 計画行列を生成する
        /// </summary>
        /// <param name="matrixWithoutConstant"></param>
        /// <returns></returns>
        public static Matrix<T> MakeDesignMatrixWithConstant(Matrix<T> matrixWithoutConstant)
        {
            var designMatrix = new Matrix<T>(matrixWithoutConstant.RowCount, matrixWithoutConstant.ColumnCount + 1);
            for (int i = 0; i < matrixWithoutConstant.RowCount; i++)
            {

                designMatrix[i, 0] = (dynamic)1;
                for (int j = 0; j < matrixWithoutConstant.ColumnCount; j++)
                {
                    designMatrix[i, j + 1] = matrixWithoutConstant[i, j];
                }
            }

            return designMatrix;
        }


    }
}
