using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Matrix<T>
        where T : struct
    {

        /// <summary>
        /// 転置行列を生成する
        /// </summary>
        /// <returns></returns>
        public Matrix<T> Transpose()
        {
            Matrix<T> result = new Matrix<T>(this.ColumnCount, this.RowCount);
            for (int i=0;i<this.RowCount;i++){
                for (int j = 0; j < this.ColumnCount; j++){
                    result[j, i] = this[i, j];
                }
            }

            return result;
        }


        /// <summary>
        /// 転置行列を生成する
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static Matrix<T> Transpose(Matrix<T> matrix)
        {
            Matrix<T> result = new Matrix<T>(matrix.ColumnCount, matrix.RowCount);
            for (int i = 0; i < matrix.RowCount; i++){
                for (int j = 0; j < matrix.ColumnCount; j++){
                    result[j, i] = matrix[i, j];
                }
            }

            return result;
        }


    }
}
