using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{

    public interface IKernel<T>
        where T : struct
    {

        void SetDesignMatrix(Matrix<T> designMatrix);


        void SetVarianceCovarianceMatrix(Matrix<T> varianceCovarianceMatrix);


        T Calculate(RowVector<T> vector01, RowVector<T> vector02);

    }

}
