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

        public void Exercise_6_4()
        {
            BasicOfStatisticalDataAnalysis.Quote();

            Console.Write("第6章 1つの母集団に関する統計的推定");
            Console.WriteLine("演習問題4を解きます。");
            Console.WriteLine("引用(数式は改変. 問題文を(a), (b)などで小分けにした)\n");

            Console.WriteLine("ある製品の最大耐荷重(単位はkg)の分布が正規分布 N(μ, σ^2)であるとみなすことができるとする.");
            Console.WriteLine("この製品を無作為に10声ランで調べたところ, 標本平均 xBar = 285,  標本分散 s^2 = 360であった.");
            Console.WriteLine("(a) μの95%信頼区間を求めなさい.");
            Console.WriteLine("(b) 母分散σ^2 および母標準偏差σ それぞれの95%信頼区間を求めなさい.");
            Console.WriteLine("\n");

            double number = 10;
            double mean = 285;
            double stdSample = 360;


            Console.WriteLine("母分散σ^2 が未知の場合の推定である.");
            Console.WriteLine("標本標準偏差s を母標準偏差σ の代わりに用いる.");
            Console.WriteLine("");

            Console.WriteLine("(a) このとき, μの95%信頼区間を求めなさい.");
            double z95 = 1.96;
            Console.WriteLine("母平均μの95%信頼区間は,  (xBar - 1.96s/ √n ,  xBar + 1.96s/ √n)");
            Console.WriteLine("すなわち, (" + (mean - z95 * stdSample / Math.Sqrt(number)).ToString("G4") + ",  " + (mean + z95 * stdSample / Math.Sqrt(number)).ToString("G4") + ")");
            Console.WriteLine("\n");


            Console.WriteLine("(b) 母分散σ^2 および母標準偏差σ それぞれの95%信頼区間を求めなさい.");
            double kai_n9_025 = 19.2;
            double kai_n9_975 = 2.7;
            Console.WriteLine("母分散σ^2の95%信頼区間は,  (s^2/ χ(n-1, 0.025),  s^2/ χ(n-1, 0.975) )");
            Console.WriteLine("すなわち, (" + (stdSample / kai_n9_025).ToString("G4") + ",  " + (stdSample / kai_n9_975).ToString("G4") + ")");
            Console.WriteLine("");

            Console.WriteLine("母標準偏差σの95%信頼区間は,  (s/ √χ(n-1, 0.025),  s/ √χ(n-1, 0.975) )");
            Console.WriteLine("すなわち, (" + Math.Sqrt(stdSample / kai_n9_025).ToString("G4") + ",  " + Math.Sqrt(stdSample / kai_n9_975).ToString("G4") + ")");
        }


    }
}
