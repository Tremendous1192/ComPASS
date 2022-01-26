using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class SupportVectorMachine<T>
        where T : struct
    {





        /// <summary>
        /// 係数Aを学習する .
        /// Learn coefficient A .
        /// </summary>
        /// <param name="labelsY"></param>
        /// <param name="designMatrixWithoutConstant"></param>
        /// <param name="iKernel"></param>
        /// <returns></returns>
        public static ColumnVector<T> Learn(ColumnVector<T> labelsY, Matrix<T> designMatrixWithoutConstant, IKernel<T> iKernel)
        {
            //カーネルのセット
            iKernel.SetDesignMatrix(designMatrixWithoutConstant);


            //カーネル行列
            Matrix<T> kernel_Matrix = new Matrix<T>(designMatrixWithoutConstant.RowCount, designMatrixWithoutConstant.RowCount);

            //ハイパーパラメータ
            T hyperParameterC = (dynamic)1.0 / designMatrixWithoutConstant.RowCount;

            //カーネルを計算しておく
            for (int i = 0; i < designMatrixWithoutConstant.RowCount; i++)
            {
                RowVector<T> r_i = designMatrixWithoutConstant.PickUpRowVector(i);
                for (int j = i; j < designMatrixWithoutConstant.RowCount; j++)
                {
                    RowVector<T> r_j = designMatrixWithoutConstant.PickUpRowVector(j);

                    var k_ij = iKernel.Calculate(r_i, r_j);

                    kernel_Matrix[i, j] = k_ij;
                    kernel_Matrix[j, i] = k_ij;
                }
            }


            //係数の初期化
            ColumnVector<T> coefficientsA = new ColumnVector<T>(designMatrixWithoutConstant.RowCount);
            T initial_a = (dynamic)0;
            for (int j = 0; j < coefficientsA.Dimension; j++)
            { coefficientsA[j] = initial_a; }

            //更新用の小数のインスタンス
            T a_i = (dynamic)0;
            T a_j = (dynamic)0;
            T predict_i = (dynamic)0;
            T predict_j = (dynamic)0;
            T min = (dynamic)0;
            T max = (dynamic)0;

            //学習
            //2点のデータを選択する
            for (int i = 0; i < designMatrixWithoutConstant.RowCount; i++)
            {
                //計画行列からj行目のベクトルを取り出す
                RowVector<T> r_j = designMatrixWithoutConstant.PickUpRowVector(i);
                for (int j = i + 1; j < designMatrixWithoutConstant.RowCount; j++)
                {
                    //計画行列からk行目のベクトルを取り出す
                    RowVector<T> r_k = designMatrixWithoutConstant.PickUpRowVector(j);

                    //ベクトルr_j r_kの予測計算を行う
                    predict_i = (dynamic)0;
                    for (int i2 = 0; i2 < kernel_Matrix.ColumnCount; i2++)
                    { predict_i += (dynamic)coefficientsA[i2] * labelsY[i2] * kernel_Matrix[i, i2]; }
                    predict_j = (dynamic)0;
                    for (int j2 = 0; j2 < kernel_Matrix.ColumnCount; j2++)
                    { predict_j += (dynamic)coefficientsA[j2] * labelsY[j2] * kernel_Matrix[j, j2]; }


                    //ベクトルk の係数(仮)を計算する
                    a_j = (dynamic)coefficientsA[j]
                        + labelsY[j] *
                        (
                            ((dynamic)predict_i - labelsY[i]) - ((dynamic)predict_j - labelsY[j])
                        )
                        / ((dynamic)kernel_Matrix[i, i] + kernel_Matrix[j, j] - (dynamic)2 * kernel_Matrix[i, j]);


                    //場合分け
                    if ((dynamic)labelsY[i] * labelsY[j] > 0)
                    {
                        min = Math.Min((dynamic)hyperParameterC, (dynamic)coefficientsA[i] + coefficientsA[j]);
                        max = Math.Max(0, (dynamic)coefficientsA[i] + coefficientsA[j] - hyperParameterC);
                        if (min < (dynamic)coefficientsA[j])
                        {
                            a_j = min;
                        }
                        else if ((dynamic)max < a_j && (dynamic)a_j < min)
                        {
                            //a_k = a_k;
                        }
                        else
                        {
                            a_j = max;
                        }
                    }
                    else
                    {
                        min = Math.Min((dynamic)hyperParameterC, (dynamic)hyperParameterC - coefficientsA[i] + coefficientsA[j]);
                        max = Math.Max(0, (dynamic)0 - coefficientsA[i] + coefficientsA[j]);
                        if ((dynamic)min < a_j)
                        {
                            a_j = min;
                        }
                        else if ((dynamic)max < a_j && (dynamic)a_j < min)
                        {
                            //a_k = a_k;
                        }
                        else
                        {
                            a_j = max;
                        }
                    }

                    a_i = (dynamic)coefficientsA[i] + (dynamic)labelsY[i] * labelsY[j] * ((dynamic)coefficientsA[j] - a_j);

                    //係数の更新
                    coefficientsA[i] = a_i;
                    coefficientsA[j] = a_j;
                }
            }

            //学習終わり
            return coefficientsA;
        }



    }
}
