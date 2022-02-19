using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Statistics<T>
        where T : struct
    {


        /// <summary>
        /// 各要素を昇順で入れ替える
        /// </summary>
        /// <param name="designMatrix"></param>
        /// <returns></returns>
        public static T[,] Sort(Matrix<T> designMatrix)
        {
            //並べ替え用の配列。
            //design_matrixを計算に用いると参照渡しになるバグがある。
            T[,] sorted = new T[designMatrix.RowCount, designMatrix.ColumnCount];
            for (int i = 0; i < designMatrix.RowCount; i++)
            {
                for (int j = 0; j < designMatrix.ColumnCount; j++)
                {
                    sorted[i, j] = designMatrix[i, j];
                }
            }

            //昇順に並び替える
            T buffer = (dynamic)0;
            for (int i = 0; i < sorted.GetLength(0); i++)
            {
                for (int i2 = i + 1; i2 < sorted.GetLength(0); i2++)
                {
                    for (int j = 0; j < sorted.GetLength(1); j++)
                    {
                        // i行目のデータが、i2行目のデータより大きい場合、データを入れ替える.
                        if ((dynamic)sorted[i, j] > sorted[i2, j])
                        {
                            buffer = sorted[i, j];
                            sorted[i, j] = sorted[i2, j];
                            sorted[i2, j] = buffer;
                        }
                    }
                }
            }

            return sorted;
        }


    }
}
