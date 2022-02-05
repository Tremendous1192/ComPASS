using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    /// <summary>
    /// 計画行列を計算するクラス。
    /// 全てstaticメソッドにして、引数をMatrixにしている。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class DesignMatrix<T>
        where T : struct
    {

        /// <summary>
        /// 計画行列(行ベクトルの集合)の、平均ベクトルを返す。
        /// </summary>
        /// <param name="designMatrix"></param>
        /// <returns></returns>
        public static RowVector<T> Average(Matrix<T> designMatrix){
            RowVector<T> result = designMatrix.PickUpRowVector(0);

            for (int i = 1; i < designMatrix.RowCount; i++){
                result += designMatrix.PickUpRowVector(i);
            }

            for (int j=0;j<result.Dimension;j++){
                result[j] /= (dynamic)designMatrix.RowCount;
            }

            return result;
        }

    }
}
