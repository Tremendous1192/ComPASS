using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{

    public partial class RowVector<T>
        where T : struct
    {

        /// <summary>
        /// 列ベクトルを返す.
        /// </summary>
        /// <returns></returns>
        public ColumnVector<T> Transpose()
        {
            return new ColumnVector<T>(this.vector);
        }



    }
}
