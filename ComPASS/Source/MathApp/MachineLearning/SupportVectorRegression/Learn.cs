using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class SupportVectorRegression<T>
        where T : struct
    {

        /// <summary>
        /// 係数ベクトルを学習する。
        /// ハイパーパラメータ λ は正の数。
        /// </summary>
        /// <param name="labelsY"></param>
        /// <param name="designMatrixWithoutConstant"></param>
        /// <param name="iKernel"></param>
        /// <param name="hyperParameterLambda"></param>
        /// <returns></returns>
        public static ColumnVector<T> Learn(ColumnVector<T> labelsY, Matrix<T> designMatrixWithoutConstant, IKernel<T> iKernel, T hyperParameterLambda)
        {
            //カーネルのセット
            iKernel.SetDesignMatrix(designMatrixWithoutConstant);

            //カーネル行列
            Matrix<T> kernel_Matrix = new Matrix<T>(designMatrixWithoutConstant.RowCount, designMatrixWithoutConstant.RowCount);

            //カーネルを計算しておく
            for (int j = 0; j < designMatrixWithoutConstant.RowCount; j++)
            {
                RowVector<T> r_j = designMatrixWithoutConstant.PickUpRowVector(j);
                for (int k = j; k < designMatrixWithoutConstant.RowCount; k++)
                {
                    RowVector<T> r_k = designMatrixWithoutConstant.PickUpRowVector(k);

                    var k_jk = iKernel.Calculate(r_j, r_k);

                    kernel_Matrix[j, k] = k_jk;
                    kernel_Matrix[k, j] = k_jk;
                }
            }


            Matrix<T> matrixLambdaI = new Matrix<T>(kernel_Matrix.RowCount, kernel_Matrix.ColumnCount);
            for (int i=0;i< kernel_Matrix.RowCount;i++)
            {
                matrixLambdaI[i, i] = hyperParameterLambda;
            }


            ColumnVector<T> a = (kernel_Matrix + matrixLambdaI).Inverse() * labelsY;

            return a;
        }

    }
}
