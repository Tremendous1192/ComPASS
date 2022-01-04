using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class ColumnVector<T>
        where T : struct
    {

        /// <summary>
        /// ベクトルの積を返す.
        /// </summary>
        /// <param name="otherVector"></param>
        /// <returns></returns>
        public Matrix<T> MultiplyColumnVectorRowVector(RowVector<T> otherVector)
        {
            Matrix<T> result = new Matrix<T>(this.Dimension, otherVector.Dimension);
            for (int i=0;i<this.Dimension;i++) 
            {
                for (int j=0;j<otherVector.Dimension;j++)
                {
                    result[i, j] = (dynamic)this[i] * otherVector[j];
                }
            }

            return result;
        }


        /// <summary>
        /// ベクトルの積を返す.演算子 "*" のオーバーロード
        /// </summary>
        /// <param name="columnVector"></param>
        /// <param name="rowVector"></param>
        /// <returns></returns>
        public static Matrix<T> operator *(ColumnVector<T> columnVector, RowVector<T> rowVector)
        {
            Matrix<T> result = new Matrix<T>(columnVector.Dimension, rowVector.Dimension);
            for (int i = 0; i < columnVector.Dimension; i++)
            {
                for (int j = 0; j < rowVector.Dimension; j++)
                {
                    result[i, j] = (dynamic)columnVector[i] * rowVector[j];
                }
            }

            return result;
        }


        /// <summary>
        /// ベクトルの積を計算する。
        /// </summary>
        /// <param name="vector01"></param>
        /// <param name="vector02"></param>
        /// <returns></returns>
        public static Matrix<T> Multiply(ColumnVector<T> columnVector, RowVector<T> rowVector)
        {
            Matrix<T> result = new Matrix<T>(columnVector.Dimension, rowVector.Dimension);
            for (int i = 0; i < columnVector.Dimension; i++)
            {
                for (int j = 0; j < rowVector.Dimension; j++)
                {
                    result[i, j] = (dynamic)columnVector[i] * rowVector[j];
                }
            }

            return result;
        }



    }
}
