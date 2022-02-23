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

        public void Exercise_6_1()
        {
            BasicOfStatisticalDataAnalysis.Quote();

            Console.Write("第6章 1つの母集団に関する統計的推定");
            Console.WriteLine("演習問題1を解きます。");
            Console.WriteLine("引用(数式は改変. 問題文を(a), (b)などで小分けにした)\n");

            Console.WriteLine("ある動物の1歳時の重さ (単位はg)の分布が正規分布 N(μ, 1.5^2)であるとみなすことができるとする.");
            Console.WriteLine("母平均μを推定するために無作為に9匹を選んで測定したところ,標本平均はxBar = 10.1 kgであった.");
            Console.WriteLine("(a) xBarの標準誤差を求めなさい.");
            Console.WriteLine("(b) μの95%信頼区間を求めなさい.");
            Console.WriteLine("\n");

            Console.WriteLine("標準誤差は σ/ √n = 1.5/ √9 = " + (1.5 / Math.Sqrt(9)).ToString("G4"));
            Console.WriteLine("");

            Console.WriteLine("95%信頼区間は,  (xBar - 1.96σ/ √n ,  xBar + 1.96σ/ √n)");
            Console.WriteLine("すなわち, (" + (10.1 - 1.96 * 1.5 / Math.Sqrt(9)).ToString("G4") + ",  " + (10.1 + 1.96 * 1.5 / Math.Sqrt(9)).ToString("G4") + ")");
        }


    }
}
