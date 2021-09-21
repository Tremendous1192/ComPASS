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
        /// <param name="vectorRightSide"></param>
        /// <returns></returns>
        public Vector<T> MultiplyMatrixVector(Vector<T> vectorRightSide)
        {
            if (this.ColumnCount != vectorRightSide.Dimension)
            {
                throw new FormatException("行列の列数と、ベクトルの次元が揃っていません");
            }

            T[] result = new T[this.RowCount];
            for (int i = 0; i < this.RowCount; i++)
            {
                for (int j = 0; j < this.ColumnCount; j++)
                {

                    result[i] += (dynamic)matrix[i][j] * vectorRightSide[j];
                }
            }

            return new Vector<T>(result);
        }


        /// <summary>
        /// 行列とベクトルの乗算を行う。演算子 "*" のオーバーロード
        /// </summary>
        /// <param name="matrixLeftSide"></param>
        /// <param name="vectorRightSide"></param>
        /// <returns></returns>
        public static Vector<T> operator *(Matrix<T> matrixLeftSide, Vector<T> vectorRightSide)
        {
            return matrixLeftSide.MultiplyMatrixVector(vectorRightSide);
        }


        /// <summary>
        /// 行列とベクトルの積
        /// </summary>
        /// <param name="matrixLeftSide"></param>
        /// <param name="vectorRightSide"></param>
        /// <returns></returns>
        public static Vector<T> Multiply(Matrix<T> matrixLeftSide, Vector<T> vectorRightSide)
        {
            return matrixLeftSide.MultiplyMatrixVector(vectorRightSide);
        }




    }
}
