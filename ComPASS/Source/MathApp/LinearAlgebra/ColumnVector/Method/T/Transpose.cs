using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{

    public partial class ColumnVector<T>
        where T : struct
    {

        /// <summary>
        /// 行ベクトルを返す.
        /// </summary>
        /// <returns></returns>
        public RowVector<T> Transpose()
        {
            return new RowVector<T>(this.vector);
        }



    }
}
