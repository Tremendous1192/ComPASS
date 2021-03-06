using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Matrix<T>
        where T : struct
    {


        /// <summary>
        /// 行列とベクトルの積
        /// </summary>
        /// <param name="vectorLeftSide"></param>
        /// <returns></returns>
        public RowVector<T> MultiplyVectorMatrix(RowVector<T> vectorLeftSide)
        {
            if (this.RowCount != vectorLeftSide.Dimension)
            {
                throw new FormatException("ベクトルの次元と行列の行数が揃っていません");
            }

            T[] result = new T[this.ColumnCount];
            for (int i = 0; i < this.RowCount; i++)
            {
                for (int j = 0; j < this.ColumnCount; j++)
                {

                    result[j] += (dynamic)vectorLeftSide[i] * matrix[i][j];
                }
            }

            return new RowVector<T>(result);
        }


        /// <summary>
        /// ベクトルと行列の乗算を行う。演算子 "*" のオーバーロード
        /// </summary>
        /// <param name="rowVectorLeftSide"></param>
        /// <param name="matrixRightSide"></param>
        /// <returns></returns>
        public static RowVector<T> operator *(RowVector<T> rowVectorLeftSide, Matrix<T> matrixRightSide)
        {
            return matrixRightSide.MultiplyVectorMatrix(rowVectorLeftSide);
        }


        /// <summary>
        /// ベクトルと行列の積
        /// </summary>
        /// <param name="vectorLeftSide"></param>
        /// <param name="matrixRightSide"></param>
        /// <returns></returns>
        public static RowVector<T> Multiply(RowVector<T> vectorLeftSide, Matrix<T> matrixRightSide)
        {
            return matrixRightSide.MultiplyVectorMatrix(vectorLeftSide);
        }

    }
}
