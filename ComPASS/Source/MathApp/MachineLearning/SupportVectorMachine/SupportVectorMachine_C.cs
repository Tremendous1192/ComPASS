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
        /// <param name="CoefficientsA"></param>
        /// <param name="rowVector"></param>
        /// <returns></returns>
        public static T Classify(Vector<T> labelsY, Matrix<T> designMatrixWithoutConstant, IKernel<T> iKernel, Vector<T> CoefficientsA, Vector<T> rowVector)
        {

            //カーネルのセット
            iKernel.SetDesignMatrix(designMatrixWithoutConstant);


            //カーネル用の行列
            //予測計算では1列しか使用しないため、ベクトルで代用できる(要素番号は[j,0]を指定している)
            Vector<T> kernelMatrix = new Vector<T>(designMatrixWithoutConstant.RowCount);

            //カーネルを計算する
            for (int j = 0; j < designMatrixWithoutConstant.RowCount; j++)
            {
                Vector<T> r_j = designMatrixWithoutConstant.PickUpRowVector(j);
                kernelMatrix[j] = iKernel.Calculate(rowVector, r_j);
            }


            //予測値の計算
            //予測値の符号 = Σ( for j ) 教師ラベル[Y]j * 係数[A]j * カーネル K( x , [X]j )
            T[] hadamard = new T[designMatrixWithoutConstant.RowCount];
            for (int j = 0; j < designMatrixWithoutConstant.RowCount; j++)
            {
                hadamard[j] = (dynamic)labelsY[j] * CoefficientsA[j] * kernelMatrix[j];
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
