using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Matrix<T>
        where T : struct
    {

        /// <summary>
        /// 行列の加算を行う.
        /// </summary>
        /// <param name="otherMatrix"></param>
        /// <returns></returns>
        public Matrix<T> Add(Matrix<T> otherMatrix) {

            if (this.RowCount != otherMatrix.RowCount) {
                throw new FormatException("行数が揃っていません");
            }
            if (this.ColumnCount != otherMatrix.ColumnCount)
            {
                throw new FormatException("列が揃っていません");
            }


            T[][] result = new T[this.RowCount][];
            for (int i=0;i<this.RowCount;i++) {
                result[i] = new T[this.ColumnCount];
                for (int j=0;j<this.ColumnCount;j++) {
                    //dynamic を使用するときは、Microsoft.CSharpをnugetでダウンロードしておく
                    result[i][j] = (dynamic)matrix[i][j] + otherMatrix[i, j];
                }
            }

            return new Matrix<T>(result);
        }


        /// <summary>
        /// 行列の加算を行う。演算子 "+" のオーバーロード
        /// </summary>
        /// <param name="matrix01"></param>
        /// <param name="matrix02"></param>
        /// <returns></returns>
        public static Matrix<T> operator +(Matrix<T> matrix01, Matrix<T> matrix02)
        {
            return matrix01.Add(matrix02);
        }



        /// <summary>
        /// 行列の加算を行う.
        /// </summary>
        /// <param name="matrix01"></param>
        /// <param name="matrix02"></param>
        /// <returns></returns>
        public static Matrix<T> Add(Matrix<T> matrix01, Matrix<T> matrix02)
        {

            if (matrix01.RowCount != matrix02.RowCount)
            {
                throw new FormatException("行数が揃っていません");
            }
            if (matrix01.ColumnCount != matrix02.ColumnCount)
            {
                throw new FormatException("列が揃っていません");
            }


            T[][] result = new T[matrix01.RowCount][];
            for (int i = 0; i < matrix01.RowCount; i++)
            {
                result[i] = new T[matrix01.ColumnCount];
                for (int j = 0; j < matrix01.ColumnCount; j++)
                {
                    //dynamic を使用するときは、Microsoft.CSharpをnugetでダウンロードしておく
                    result[i][j] = (dynamic)matrix01[i, j] + matrix02[i, j];
                }
            }

            return new Matrix<T>(result);
        }


    }
}
