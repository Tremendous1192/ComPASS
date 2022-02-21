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

        public void Exercise_5_4()
        {
            BasicOfStatisticalDataAnalysis.Quote();

            Console.Write("第5章 正規分布と推測統計の基礎理論");
            Console.WriteLine("演習問題4を解きます。");
            Console.WriteLine("引用(数式は改変)\n");

            Console.WriteLine("ある製品は組み立て工程, 塗装工程, 検査工程の3つの工程を経て出荷される.");
            Console.WriteLine("組み立て工程の所要時間は N(60, 7^2)に,");
            Console.WriteLine("塗装工程の所要時間は N(30, 3^2)に,");
            Console.WriteLine("検査工程の所要時間は N(10, (√6)^2)に独立に従っていると考えることができるとき(単位は分),");
            Console.WriteLine("午前8字開始に開始して午前10時の出荷に間に合わない確率を求めなさい");
            Console.WriteLine("\n");


            // 50
            double meanSum = (60 + 30 + 10);
            // 5^2
            double stdSum = Math.Sqrt(7 * 7 + 3 * 3 + Math.Sqrt(6) * Math.Sqrt(6));
            Console.WriteLine("独立な正規変数の足し合わせの期待値は, それぞれの期待値の和である.");
            Console.WriteLine("40 + 10 =" + meanSum + "分である");
            Console.WriteLine("分散も同様である. 7^2 + 3^2 + (√6)^2 = " + stdSum.ToString("G3") + "^2 である.");
            Console.WriteLine("従って,新しい分布は, N(" + meanSum + ", " + stdSum.ToString("G3") + "^2)である.");
            Console.WriteLine("\n");

            // 2.5
            double zSum = Math.Abs(120 - meanSum) / stdSum;
            Console.WriteLine("120分を正規化すると," + zSum + " である");
            Console.WriteLine("正規分布表より, 120分以上になる確率は, 0.0062 である.");
            Console.WriteLine("\n");


        }


    }
}
