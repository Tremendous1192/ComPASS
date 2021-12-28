using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class DesignMatrix<T>
        where T : struct
    {
        /// <summary>
        /// 分散・共分散行列の逆行列を返す。
        /// </summary>
        /// <param name="designMatrix"></param>
        /// <returns></returns>
        public static Matrix<T> InverseVarianceCovarianceMatrix(Matrix<T> designMatrix)
        {
            return DesignMatrix<T>.VarianceCovarianceMatrix(designMatrix).Inverse();
        }

    }
}
