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
        /// <param name="hyperParameterExponent"></param>
        /// <returns></returns>
        public static ColumnVector<T> Learn(ColumnVector<T> labelsY, Matrix<T> designMatrixWithoutConstant, IKernel<T> iKernel, int hyperParameterExponent)
        {
            //カーネルのセット
            iKernel.SetDesignMatrix(designMatrixWithoutConstant);

            //係数の最大値(ハイパーパラメーター)
            double hyperParameterC = Math.Pow(2, hyperParameterExponent);

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


            //係数の初期化
            ColumnVector<T> coefficientsA = new ColumnVector<T>(designMatrixWithoutConstant.RowCount);
            T initial_a = (dynamic)0;
            for (int j = 0; j < coefficientsA.Dimension; j++)
            { coefficientsA[j] = initial_a; }

            //更新用の小数のインスタンス
            T a_j = (dynamic)0;
            T a_k = (dynamic)0;
            T predict_j = (dynamic)0;
            T predict_k = (dynamic)0;
            T min = (dynamic)0;
            T max = (dynamic)0;

            //学習
            //2点のデータを選択する
            for (int j = 0; j < designMatrixWithoutConstant.RowCount; j++)
            {
                //計画行列からj行目のベクトルを取り出す
                RowVector<T> r_j = designMatrixWithoutConstant.PickUpRowVector(j);
                for (int k = j + 1; k < designMatrixWithoutConstant.RowCount; k++)
                {
                    //計画行列からk行目のベクトルを取り出す
                    RowVector<T> r_k = designMatrixWithoutConstant.PickUpRowVector(k);

                    //ベクトルr_j r_kの予測計算を行う
                    predict_j = (dynamic)0;
                    for (int j2 = 0; j2 < kernel_Matrix.ColumnCount; j2++)
                    { predict_j += (dynamic)coefficientsA[j2] * labelsY[j2] * kernel_Matrix[j, j2]; }
                    predict_k = (dynamic)0;
                    for (int k2 = 0; k2 < kernel_Matrix.ColumnCount; k2++)
                    { predict_k += (dynamic)coefficientsA[k2] * labelsY[k2] * kernel_Matrix[k, k2]; }


                    //ベクトルk の係数(仮)を計算する
                    a_k = (dynamic)coefficientsA[k]
                        + labelsY[k] *
                        (
                            ((dynamic)predict_j - labelsY[j]) - ((dynamic)predict_k - labelsY[k])
                        )
                        / ((dynamic)kernel_Matrix[j, j] + kernel_Matrix[k, k] - (dynamic)2 * kernel_Matrix[j, k]);


                    //場合分け
                    if ((dynamic)labelsY[j] * labelsY[k] > 0)
                    {
                        min = Math.Min(hyperParameterC, (dynamic)coefficientsA[j] + coefficientsA[k]);
                        max = Math.Max(0, (dynamic)coefficientsA[j] + coefficientsA[k] - hyperParameterC);
                        if (min < (dynamic)coefficientsA[k])
                        {
                            a_k = min;
                        }
                        else if ((dynamic)max < a_k && (dynamic)a_k < min)
                        {
                            //a_k = a_k;
                        }
                        else
                        {
                            a_k = max;
                        }
                    }
                    else
                    {
                        min = Math.Min(hyperParameterC, (dynamic)hyperParameterC - coefficientsA[j] + coefficientsA[k]);
                        max = Math.Max(0, (dynamic)0 - coefficientsA[j] + coefficientsA[k]);
                        if ((dynamic)min < a_k)
                        {
                            a_k = min;
                        }
                        else if ((dynamic)max < a_k && (dynamic)a_k < min)
                        {
                            //a_k = a_k;
                        }
                        else
                        {
                            a_k = max;
                        }
                    }

                    a_j = (dynamic)coefficientsA[j] + (dynamic)labelsY[j] * labelsY[k] * ((dynamic)coefficientsA[k] - a_k);

                    //係数の更新
                    coefficientsA[j] = a_j;
                    coefficientsA[k] = a_k;
                }
            }

            //学習終わり
            return coefficientsA;
        }



    }
}
