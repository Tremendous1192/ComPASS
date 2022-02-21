using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.CoMPASS.MathApp;


//入出力
using System.IO;

//ScottPlotを使用する.
using ScottPlot;
using System.Drawing;

namespace Test.Tremendous1192.SelfEmployed.CoMPASS.Books
{
    public partial class BasicOfStatisticalDataAnalysis
    {

        public void Exercise_5_3()
        {
            BasicOfStatisticalDataAnalysis.Quote();

            Console.Write("第5章 正規分布と推測統計の基礎理論");
            Console.WriteLine("演習問題3を解きます。");
            Console.WriteLine("引用(数式は改変)\n");

            Console.WriteLine("A君は午前8時に起床し,準備を済ませて徒歩で大学に向かう.");
            Console.WriteLine("準備にかかる時間は N(40, (2√6)^2)に,");
            Console.WriteLine("徒歩通学にかかる時間は N(10, 1^2)に独立に従っていると考えることができるとき(単位は分),");
            Console.WriteLine("午前9字開始の講義に遅刻する確率を求めなさい");
            Console.WriteLine("\n");


            // 50
            double meanSum = (40 + 10);
            // 5^2
            double stdSum = Math.Sqrt((2 * Math.Sqrt(6)) * (2 * Math.Sqrt(6)) + 1 * 1);
            Console.WriteLine("独立な正規変数の足し合わせの期待値は, それぞれの期待値の和である.");
            Console.WriteLine("40 + 10 =" + meanSum + "分である");
            Console.WriteLine("分散も同様である.  (2√6)^2 + 1^2 = " + stdSum.ToString("G3") + "^2 である.");
            Console.WriteLine("従って,新しい分布は, N(" + meanSum + ", " + stdSum.ToString("G3") + "^2)である.");
            Console.WriteLine("\n");

            // 0.2
            double zSum = Math.Abs(60 - meanSum) / stdSum;
            Console.WriteLine("60分を正規化すると," + zSum + " である");
            Console.WriteLine("正規分布表より, 60分以上になる確率は, 0.4920 である.");
            Console.WriteLine("\n");


        }


    }
}
