using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class Statistics<T>
        where T : struct
    {

        /// <summary>
        /// 標準誤差を返す。
        /// </summary>
        /// <param name="columnVector"></param>
        /// <returns></returns>
        public static T SampleStandardError(ColumnVector<T> columnVector)
        {
            T dataNumberSQRT = (dynamic)Math.Sqrt((dynamic)columnVector.Dimension);
            T standardError = Statistics<T>.SampleStandardDeviation(columnVector);

            standardError /= (dynamic)dataNumberSQRT;

            return standardError;
        }


    }
}
