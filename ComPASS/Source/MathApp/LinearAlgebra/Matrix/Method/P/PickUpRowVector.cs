using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Matrix<T>
        where T : struct
    {

        /// <summary>
        /// 行ベクトルを返す
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public RowVector<T> PickUpRowVector(int row){
            if (row < 0 || this.RowCount <= row){
                throw new FormatException("行の指定が不適切です");
            }


            RowVector<T> result = new RowVector<T>(this.ColumnCount);
            for (int j = 0; j < this.ColumnCount; j++){
                result[j] = this[row, j];
            }

            return result;
        }

        /// <summary>
        /// 行ベクトルを返す
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        public static RowVector<T> PickUpRowVector(Matrix<T> matrix, int row){
            if (row < 0 || matrix.RowCount <= row)
            {
                throw new FormatException("行の指定が不適切です");
            }


            RowVector<T> result = new RowVector<T>(matrix.ColumnCount);
            for (int j = 0; j < matrix.ColumnCount; j++)
            {
                result[j] = matrix[row, j];
            }

            return result;
        }


    }
}
