using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class SupportVectorMachine<T>
        where T : struct
    {


        /// <summary>
        /// 行ベクトルの識別を行う .
        /// Perform row vector identification .
        /// </summary>
        /// <param name="labelsY"></param>
        /// <param name="designMatrixWithoutConstant"></param>
        /// <param name="iKernel"></param>
        /// <param name="coefficientsA"></param>
        /// <param name="rowVector"></param>
        /// <returns></returns>
        public static T Classify(ColumnVector<T> labelsY, Matrix<T> designMatrixWithoutConstant, IKernel<T> iKernel, ColumnVector<T> coefficientsA, RowVector<T> rowVector)
        {

            //カーネルのセット
            iKernel.SetDesignMatrix(designMatrixWithoutConstant);


            //カーネル用の行列
            //予測計算では1列しか使用しないため、ベクトルで代用できる(要素番号は[j,0]を指定している)
            RowVector<T> kernelMatrix = new RowVector<T>(designMatrixWithoutConstant.RowCount);

            //カーネルを計算する
            for (int i = 0; i < designMatrixWithoutConstant.RowCount; i++)
            {
                RowVector<T> r_i = designMatrixWithoutConstant.PickUpRowVector(i);
                kernelMatrix[i] = iKernel.Calculate(rowVector, r_i);
            }


            //予測値の計算
            //予測値の符号 = Σ( for j ) 教師ラベル[Y]j * 係数[A]j * カーネル K( x , [X]j )
            T[] hadamard = new T[designMatrixWithoutConstant.RowCount];
            for (int i = 0; i < designMatrixWithoutConstant.RowCount; i++)
            {
                hadamard[i] = (dynamic)labelsY[i] * coefficientsA[i] * kernelMatrix[i];
            }



            //Σ( for j )
            T sum = (dynamic)0;
            foreach (var h in hadamard)
            {
                sum += (dynamic)h;
            }

            return sum;
        }



    }
}
