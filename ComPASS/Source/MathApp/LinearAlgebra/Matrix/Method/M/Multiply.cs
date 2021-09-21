using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Matrix<T>
        where T : struct
    {

        /// <summary>
        /// 行列の乗算
        /// </summary>
        /// <param name="matrixMultiplier"></param>
        /// <returns></returns>
        public Matrix<T> Multiply(Matrix<T> matrixMultiplier)
        {
            if (this.ColumnCount != matrixMultiplier.RowCount)
            {
                throw new FormatException("かけられる行列の列数と、かける行列の行数が揃っていません");
            }

            T[][] result = new T[this.RowCount][];
            for (int i = 0; i < this.RowCount; i++)
            {
                result[i] = new T[matrixMultiplier.ColumnCount];
                for (int j = 0; j < matrixMultiplier.ColumnCount; j++)
                {
                    for (int k=0;k<this.ColumnCount;k++) {
                        //dynamic を使用するときは、Microsoft.CSharpをnugetでダウンロードしておく
                        result[i][j] += (dynamic)matrix[i][k] * matrixMultiplier[k, j];
                    }
                }
            }

            return new Matrix<T>(result);
        }


        /// <summary>
        /// 行列の乗算を行う。演算子 "*" のオーバーロード
        /// </summary>
        /// <param name="matrixMultiplicand"></param>
        /// <param name="matrixMultiplier"></param>
        /// <returns></returns>
        public static Matrix<T> operator *(Matrix<T> matrixMultiplicand, Matrix<T> matrixMultiplier)
        {
            return matrixMultiplicand.Multiply(matrixMultiplier);
        }



        /// <summary>
        /// 行列の乗算
        /// </summary>
        /// <param name="matrixLeftSide"></param>
        /// <param name="matrixRightSide"></param>
        /// <returns></returns>
        public static Matrix<T> Multiply(Matrix<T> matrixLeftSide, Matrix<T> matrixRightSide)
        {
            return matrixLeftSide.Multiply(matrixRightSide);
        }





    }
}
