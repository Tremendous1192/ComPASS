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
        /// <param name="array1Dim"></param>
        /// <returns></returns>
        static T[] Sort(T[] array1Dim)
        {

            //並べ替え用の配列。
            //design_matrixを計算に用いると参照渡しになるバグがある。
            T[] sorted = new T[array1Dim.Length];
            for (int i = 0; i < array1Dim.Length; i++)
            {
                sorted[i] = array1Dim[i];
            }

            //昇順に並び替える
            T buffer = (dynamic)0;
            for (int i = 0; i < sorted.GetLength(0); i++)
            {
                for (int i2 = i + 1; i2 < sorted.GetLength(0); i2++)
                {
                    // i行目のデータが、i2行目のデータより大きい場合、データを入れ替える.
                    if ((dynamic)sorted[i] > sorted[i2])
                    {
                        buffer = sorted[i];
                        sorted[i] = sorted[i2];
                        sorted[i2] = buffer;
                    }
                }
            }


            return sorted;
        }


    }
}
