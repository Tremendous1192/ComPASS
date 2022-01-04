using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class RowVector<T>
        where T : struct
    {




        /// <summary>
        /// ベクトルと行列の積
        /// </summary>
        /// <param name="matrixRightSide"></param>
        /// <returns></returns>
        public RowVector<T> MultiplyRowVectorMatrix( Matrix<T> matrixRightSide)
        {
            if (this.Dimension != matrixRightSide.RowCount)
            {
                throw new FormatException("ベクトルの次元と行列の行数が揃っていません");
            }

            T[] result = new T[matrixRightSide.ColumnCount];
            for (int i = 0; i < this.Dimension; i++)
            {
                for (int j = 0; j < matrixRightSide.ColumnCount; j++)
                {

                    result[j] += (dynamic)this[i] * matrixRightSide[i, j];
                }
            }

            return new RowVector<T>(result);
        }


        /// <summary>
        /// ベクトルと行列の積
        /// </summary>
        /// <param name="rowVectorLeftSide"></param>
        /// <param name="matrixRightSide"></param>
        /// <returns></returns>
        public static RowVector<T> Multiply(RowVector<T> rowVectorLeftSide, Matrix<T> matrixRightSide)
        {
            return matrixRightSide.MultiplyVectorMatrix(rowVectorLeftSide);
        }


    }
}
