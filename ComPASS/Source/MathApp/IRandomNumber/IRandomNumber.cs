using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    /// <summary>
    /// 乱数を生成するインターフェース。
    /// 基本となる一様乱数はメルセンヌ・ツイスタに従って生成される。
    /// </summary>
    public interface IRandomNumber
    {
        double NextDouble();
    }
}
