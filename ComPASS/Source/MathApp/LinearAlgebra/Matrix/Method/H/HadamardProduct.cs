using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Matrix<T>
        where T : struct
    {

        /// <summary>
        /// アダマール積を計算する.
        /// </summary>
        /// <param name="otherMatrix"></param>
        /// <returns></returns>
        public Matrix<T> HadamardProduct(Matrix<T> otherMatrix)
        {

            if (this.RowCount != otherMatrix.RowCount)
            {
                throw new FormatException("行数が揃っていません");
            }
            if (this.ColumnCount != otherMatrix.ColumnCount)
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
                    result[i][j] = (dynamic)matrix[i][j] * otherMatrix[i, j];
                }
            }

            return new Matrix<T>(result);
        }


        /// <summary>
        /// アダマール積を計算する.
        /// </summary>
        /// <param name="matrix01"></param>
        /// <param name="matrix02"></param>
        /// <returns></returns>
        public static Matrix<T> HadamardProduct(Matrix<T> matrix01, Matrix<T> matrix02)
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
