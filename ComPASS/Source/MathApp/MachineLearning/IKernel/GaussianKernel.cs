using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{

    public class GaussianKernel<T> : IKernel<T>
        where T : struct
    {

        bool set;
        Matrix<T> inverseVarianceCovarianceMatrix;
        T coefficient;

        public GaussianKernel()
        {
            set = false;
        }

        /// <summary>
        /// 計画行列の分散共・分散行列の逆行列をセットする。
        /// </summary>
        /// <param name="designMatrix"></param>
        public void SetDesignMatrix(Matrix<T> designMatrix) {
            set = true;
            Matrix<T> varianceCovarianceMatrix = DesignMatrix<T>.VarianceCovarianceMatrix(designMatrix);
            inverseVarianceCovarianceMatrix = varianceCovarianceMatrix.Inverse();
            coefficient = (dynamic)Math.Pow(2 * Math.PI, varianceCovarianceMatrix.ColumnCount / 2) * varianceCovarianceMatrix.Determinant();
        }

        /// <summary>
        /// 計画行列の分散共・分散行列の逆行列をセットする。
        /// </summary>
        /// <param name="varianceCovarianceMatrix"></param>
        public void SetVarianceCovarianceMatrix(Matrix<T> varianceCovarianceMatrix)
        {
            set = true;
            inverseVarianceCovarianceMatrix = varianceCovarianceMatrix.Inverse();
            coefficient = (dynamic)Math.Pow(2 * Math.PI, varianceCovarianceMatrix.ColumnCount / 2) * varianceCovarianceMatrix.Determinant();
        }

        /// <summary>
        /// カーネル関数を計算する。
        /// </summary>
        /// <param name="vector01"></param>
        /// <param name="vector02"></param>
        /// <returns></returns>
        public T Calculate(RowVector<T> vector01, RowVector<T> vector02)
        {
            RowVector<T> deltaRowVector = vector01 - vector02;
            if (set)
            {
                var product = deltaRowVector * inverseVarianceCovarianceMatrix * deltaRowVector;
                return (dynamic)Math.Exp(-(dynamic)product / 2) / coefficient;
            }
            else
            {
                T norm = deltaRowVector.Norm_L2();
                return (dynamic)Math.Exp(-(dynamic)norm * norm / 2.0) / Math.Pow(2 * Math.PI, 1.0 / 2.0);
            }

        }


    }



}
