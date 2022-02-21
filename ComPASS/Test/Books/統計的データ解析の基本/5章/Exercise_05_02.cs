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

        public void Exercise_5_2()
        {
            BasicOfStatisticalDataAnalysis.Quote();

            Console.Write("第5章 正規分布と推測統計の基礎理論");
            Console.WriteLine("演習問題2を解きます。");
            Console.WriteLine("引用(数式は改変)\n");

            Console.WriteLine("A君の100m背泳ぎのタイムは正規分布 Na(62, 1.2^2),");
            Console.WriteLine("B君の100m平泳ぎのタイムは正規分布 Nb(65, 1.2^2),");
            Console.WriteLine("C君の100mバタフライのタイムは正規分布 Nc(59, 1.6^2),");
            Console.WriteLine("D君の100m自由形のタイムは正規分布 Nd(51, 0.9^2)");
            Console.WriteLine("に従うとみなせるとする(単位は秒). この4人で 4 x 100 m メドレーリレーを行うとする.");

            Console.WriteLine("(a) メドレーリレーのタイムは, 単純に上記の4つの確率変数の和と考えてよいとするとき,");
            Console.WriteLine("メドレーリレーのタイムが従う分布を答えなさい.ただし,4人のそれぞれのタイムは互いに独立であるとする.");
            Console.WriteLine("(b) 4分(=240秒)を切るタイムが出る確率を求めなさい.");
            Console.WriteLine("(c) 3分50秒(=230秒)を切るタイムが出る確率を求めなさい.");
            Console.WriteLine("\n");


            // 237
            double meanSum = (62 + 65 + 59 + 51);
            // 2.5^2
            double stdSum = Math.Sqrt(1.2 * 1.2 + 1.2 * 1.2 + 1.6 * 1.6 + 0.9 * 0.9);
            Console.WriteLine("(a) 独立な正規変数の足し合わせの期待値は, それぞれの期待値の和である.");
            Console.WriteLine("62 + 65 + 59 + 51 =" + meanSum + "秒である");
            Console.WriteLine("分散も同様である.  1.2^2 + 1.2^2 + 1.6^2 + 0.9^2 = " + stdSum.ToString("G3") + "^2 である.");
            Console.WriteLine("従って,新しい分布は, N(" + meanSum + ", " + stdSum.ToString("G3") + "^2)である.");
            Console.WriteLine("\n");

            // 1.2
            double zSum = Math.Abs(240 - meanSum) / stdSum;
            Console.WriteLine("(b) 240秒を正規化すると," + zSum + " である");
            Console.WriteLine("正規分布表より, 4分(=240秒)以下になる確率は, 0.1151 である.");
            Console.WriteLine("\n");

            //
            double zSum2 = Math.Abs(230 - meanSum) / stdSum;
            Console.WriteLine("(b) 240秒を正規化すると," + zSum2 + " である");
            Console.WriteLine("正規分布表より, 3分50秒(=230秒)以下になる確率は, 0.0026 である.");
            Console.WriteLine("\n");


        }


    }
}
