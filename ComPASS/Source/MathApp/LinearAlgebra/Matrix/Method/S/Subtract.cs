using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Matrix<T>
        where T : struct
    {

        /// <summary>
        /// 行列の減算を行う.
        /// </summary>
        /// <param name="matrixSubtrahend"></param>
        /// <returns></returns>
        public Matrix<T> Subtract(Matrix<T> matrixSubtrahend)
        {

            if (this.RowCount != matrixSubtrahend.RowCount)
            {
                throw new FormatException("行数が揃っていません");
            }
            if (this.ColumnCount != matrixSubtrahend.ColumnCount)
            {
                throw new FormatException("列が揃っていません");
            }


            T[][] result = new T[this.RowCount][];
            for (int i = 0; i < this.RowCount; i++)
            {
                result[i] = new T[this.ColumnCount];
                for (int j = 0; j < this.ColumnCount; j++)
                {
                    //dynamic を使用するときは、Microsoft.CSharpをnugetでダウンロードしておく
                    result[i][j] = (dynamic)matrix[i][j] - matrixSubtrahend[i, j];
                }
            }

            return new Matrix<T>(result);
        }


        /// <summary>
        /// 行列の加算を行う。演算子 "+" のオーバーロード
        /// </summary>
        /// <param name="matrixMinuend"></param>
        /// <param name="matrixSubtrahend"></param>
        /// <returns></returns>
        public static Matrix<T> operator -(Matrix<T> matrixMinuend, Matrix<T> matrixSubtrahend)
        {
            return matrixMinuend.Subtract(matrixSubtrahend);
        }


        /// <summary>
        /// 行列の減算加算を行う.
        /// </summary>
        /// <param name="matrixMinuend"></param>
        /// <param name="matrixSubtrahend"></param>
        /// <returns></returns>
        public static Matrix<T> Subtract(Matrix<T> matrixMinuend, Matrix<T> matrixSubtrahend)
        {

            if (matrixMinuend.RowCount != matrixSubtrahend.RowCount)
            {
                throw new FormatException("行数が揃っていません");
            }
            if (matrixMinuend.ColumnCount != matrixSubtrahend.ColumnCount)
            {
                throw new FormatException("列が揃っていません");
            }


            T[][] result = new T[matrixMinuend.RowCount][];
            for (int i = 0; i < matrixMinuend.RowCount; i++)
            {
                result[i] = new T[matrixMinuend.ColumnCount];
                for (int j = 0; j < matrixMinuend.ColumnCount; j++)
                {
                    //dynamic を使用するときは、Microsoft.CSharpをnugetでダウンロードしておく
                    result[i][j] = (dynamic)matrixMinuend[i, j] - matrixSubtrahend[i, j];
                }
            }

            return new Matrix<T>(result);
        }



    }
}
