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
        /// <param name="columnVectorRightSide"></param>
        /// <returns></returns>
        public ColumnVector<T> MultiplyMatrixVector(ColumnVector<T> columnVectorRightSide)
        {
            if (this.ColumnCount != columnVectorRightSide.Dimension)
            {
                throw new FormatException("行列の列数と、ベクトルの次元が揃っていません");
            }

            T[] result = new T[this.RowCount];
            for (int i = 0; i < this.RowCount; i++)
            {
                for (int j = 0; j < this.ColumnCount; j++)
                {

                    result[i] += (dynamic)matrix[i][j] * columnVectorRightSide[j];
                }
            }

            return new ColumnVector<T>(result);
        }


        /// <summary>
        /// 行列とベクトルの乗算を行う。演算子 "*" のオーバーロード
        /// </summary>
        /// <param name="matrixLeftSide"></param>
        /// <param name="columnVectorRightSide"></param>
        /// <returns></returns>
        public static ColumnVector<T> operator *(Matrix<T> matrixLeftSide, ColumnVector<T> columnVectorRightSide)
        {
            return matrixLeftSide.MultiplyMatrixVector(columnVectorRightSide);
        }


        /// <summary>
        /// 行列とベクトルの積
        /// </summary>
        /// <param name="matrixLeftSide"></param>
        /// <param name="columnVectorRightSide"></param>
        /// <returns></returns>
        public static ColumnVector<T> Multiply(Matrix<T> matrixLeftSide, ColumnVector<T> columnVectorRightSide)
        {
            return matrixLeftSide.MultiplyMatrixVector(columnVectorRightSide);
        }




    }
}
