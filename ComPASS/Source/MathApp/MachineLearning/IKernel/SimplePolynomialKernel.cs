using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public class SimplePolynomialKernel<T> : IKernel<T>
                where T : struct
    {

        public SimplePolynomialKernel()
        {
        }

        /// <summary>
        /// 計画行列の分散共・分散行列の逆行列をセットする。
        /// Simple Polynomial Kernel はこの逆行列を使用しないので、何も処理しない。
        /// </summary>
        /// <param name="designMatrix"></param>
        public void SetDesignMatrix(Matrix<T> designMatrix)
        {
        }

        /// <summary>
        /// 計画行列の分散共・分散行列の逆行列をセットする。
        /// Simple Polynomial Kernel はこの逆行列を使用しないので、何も処理しない。
        /// </summary>
        /// <param name="varianceCovarianceMatrix"></param>
        public void SetVarianceCovarianceMatrix(Matrix<T> varianceCovarianceMatrix)
        {
        }

        /// <summary>
        /// カーネル関数を計算する。
        /// </summary>
        /// <param name="vector01"></param>
        /// <param name="vector02"></param>
        /// <returns></returns>
        public T Calculate(RowVector<T> vector01, RowVector<T> vector02)
        {
            T innerProduct = (dynamic)vector01 * vector02;

            return (dynamic)(1 + (dynamic)innerProduct) * (1 + (dynamic)innerProduct);
        }


    }
}
