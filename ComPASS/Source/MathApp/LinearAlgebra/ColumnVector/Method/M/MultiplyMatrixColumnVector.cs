using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class ColumnVector<T>
        where T : struct
    {
        /// <summary>
        /// 行列とベクトルの積
        /// </summary>
        /// <param name="matrixLeftSide"></param>
        /// <returns></returns>
        public ColumnVector<T> MultiplyMatrixVector(Matrix<T> matrixLeftSide)
        {
            if (this.Dimension != matrixLeftSide.ColumnCount)
            {
                throw new FormatException("行列の列数と、列ベクトルの次元が揃っていません");
            }

            T[] result = new T[this.Dimension];
            for (int i = 0; i < this.Dimension; i++)
            {
                for (int j = 0; j < matrixLeftSide.RowCount; j++)
                {

                    result[i] += (dynamic)matrixLeftSide[j, i] * this[i];
                }
            }

            return new ColumnVector<T>(result);
        }


        /// <summary>
        /// 行列とベクトルの積
        /// </summary>
        /// <param name="matrixLeftSide"></param>
        /// <param name="vectorRightSide"></param>
        /// <returns></returns>
        public static ColumnVector<T> Multiply(Matrix<T> matrixLeftSide, ColumnVector<T> vectorRightSide)
        {
            return matrixLeftSide.MultiplyMatrixVector(vectorRightSide);
        }


    }
}
