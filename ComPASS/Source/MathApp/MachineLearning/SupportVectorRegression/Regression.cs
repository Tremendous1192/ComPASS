using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class SupportVectorRegression<T>
        where T : struct
    {

        /// <summary>
        /// 回帰分析で、結果を予測する
        /// </summary>
        /// <param name="designMatrixWithoutConstant"></param>
        /// <param name="iKernel"></param>
        /// <param name="coefficientsA"></param>
        /// <param name="rowVector"></param>
        /// <returns></returns>
        public static T Regression(Matrix<T> designMatrixWithoutConstant, IKernel<T> iKernel, ColumnVector<T> coefficientsA, RowVector<T> rowVector)
        {
            //カーネルのセット
            iKernel.SetDesignMatrix(designMatrixWithoutConstant);


            //カーネル計算のベクトル
            RowVector<T> kernelVector = new RowVector<T>(designMatrixWithoutConstant.RowCount);

            //カーネルを計算する
            for (int i = 0; i < designMatrixWithoutConstant.RowCount; i++)
            {
                RowVector<T> r_i = designMatrixWithoutConstant.PickUpRowVector(i);
                kernelVector[i] = iKernel.Calculate(rowVector, r_i);
            }

            return kernelVector * coefficientsA;

        }

    }
}
