using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Vector<T>
        where T : struct
    {
        /// <summary>
        /// 行列とベクトルの積
        /// </summary>
        /// <param name="matrixLeftSide"></param>
        /// <returns></returns>
        public Vector<T> MultiplyMatrixVector(Matrix<T> matrixLeftSide)
        {
            if (this.Dimension != matrixLeftSide.ColumnCount)
            {
                throw new FormatException("行列の列数と、ベクトルの次元が揃っていません");
            }

            T[] result = new T[this.Dimension];
            for (int i = 0; i < this.Dimension; i++)
            {
                for (int j = 0; j < matrixLeftSide.RowCount; j++)
                {

                    result[i] += (dynamic)matrixLeftSide[j, i] * this[i];
                }
            }

            return new Vector<T>(result);
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
