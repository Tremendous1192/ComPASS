using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Matrix<T>
        where T : struct
    {

        /// <summary>
        /// 行列式を返す。
        /// </summary>
        /// <returns></returns>
        public T Determinant()
        {

            if (this.RowCount != this.ColumnCount)
            {
                throw new FormatException("正方行列ではない行列を計算しようとしています。");
            }


            T[,] sweeped = new T[this.RowCount, this.ColumnCount];
            for (int i = 0; i < this.RowCount; i++)
            {
                for (int j = 0; j < this.ColumnCount; j++)
                {
                    sweeped[i, j] = this[i, j];
                }
            }


            T upper = (dynamic)1;
            T lower = (dynamic)1;

            //掃き出し法の計算
            // [i , i ]を基準とする。
            // [i2 , i ]を掛けて、i2 行を全て引き算する。
            for (int i = 0; i < this.RowCount; i++)
            {

                // [ i, i] の要素が0だった場合、同じ列にある下の行の中で、要素が0ではない行と入れ替える。
                double compare = 1.0 / Math.Abs((double)((dynamic)sweeped[i, i]));
                if (double.IsInfinity(compare) || double.IsNaN(compare))
                {
                    for (int i2 = i + 1; i2 < sweeped.GetLength(0); i2++)
                    {
                        compare = 1.0 / Math.Abs((double)((dynamic)sweeped[i2, i]));
                        if (double.IsInfinity(compare) || double.IsNaN(compare)) { }
                        else
                        {
                            for (int j = 0; j < sweeped.GetLength(1); j++)
                            {
                                var temp = sweeped[i, j];
                                sweeped[i, j] = sweeped[i2, j];
                                sweeped[i2, j] = temp;
                            }
                            break;
                        }
                    }
                }
                //行の入れ替えを行っても[ i, i] の要素が0だった場合、行の引き算の意味がないので、スキップする。
                compare = 1.0 / Math.Abs((double)((dynamic)sweeped[i, i]));
                if (double.IsInfinity(compare) || double.IsNaN(compare))
                {
                    continue;
                }


                //要素[ i , i ] の成分が 1 になるように、　i 行目の値を除算する
                var this_low = sweeped[i, i];
                lower *= (dynamic)this[i, i];
                for (int j = i; j < sweeped.GetLength(1); j++)
                {
                    sweeped[i, j] /= (dynamic)this_low;
                }

                // i2 行目の成分に関して、i列目の値が 0になるように、各列の値を減算する
                for (int i2 = 0; i2 < matrix.GetLength(0); i2++)
                {
                    if (i == i2) { }
                    else
                    {
                        T this_subtracter = this[i2, i];
                        for (int j = i; j < sweeped.GetLength(1); j++)
                        {
                            sweeped[i2, j] -= (dynamic)this_subtracter * sweeped[i, j];
                        }
                    }
                }
            }

            for (int i = 0; i < sweeped.GetLength(0); i++)
            {
                upper *= (dynamic)sweeped[i, i];
            }


            return (dynamic)lower / upper;

        }


        /// <summary>
        /// 行列式を返す。
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static T Determinant(Matrix<T> matrix)
        {
            return matrix.Determinant();
        }



    }
}
