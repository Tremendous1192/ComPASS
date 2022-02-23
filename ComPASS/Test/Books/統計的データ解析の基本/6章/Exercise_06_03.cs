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

        public void Exercise_6_3()
        {
            BasicOfStatisticalDataAnalysis.Quote();

            Console.Write("第6章 1つの母集団に関する統計的推定");
            Console.WriteLine("演習問題3を解きます。");
            Console.WriteLine("引用(数式は改変. 問題文を(a), (b)などで小分けにした)\n");

            Console.WriteLine("ある値域の大学生の平均通学時間を調べるため,  無作為に100人を選んで調査したところ,");
            Console.WriteLine("標本平均 xBar = 55分,  標本標準偏差 s = 30分の結果が得られた.");
            Console.WriteLine("母平均をμとおく. ");
            Console.WriteLine("(a) xBarの標準誤差を求めなさい.");
            Console.WriteLine("(b) μの95%信頼区間を求めなさい.");
            Console.WriteLine("\n");

            double number = 100;
            double mean = 55;
            double stdSample = 30;
            double z95 = 1.96;

            Console.WriteLine("母分散σ^2 が未知の場合の推定である.");
            Console.WriteLine("標本標準偏差s を母標準偏差σ の代わりに用いる.");
            Console.WriteLine("");

            Console.WriteLine("(a) xBarの標準誤差を求め.");
            Console.WriteLine("標準誤差は s/ √n = " + (stdSample / Math.Sqrt(number)).ToString("G4"));
            Console.WriteLine("\n");

            Console.WriteLine("(b) μの95%信頼区間を求めなさい.");
            Console.WriteLine("95%信頼区間は,  (xBar - 1.96s/ √n ,  xBar + 1.96s/ √n)");
            Console.WriteLine("すなわち, (" + (mean - z95 * stdSample / Math.Sqrt(number)).ToString("G4") + ",  " + (mean + z95 * stdSample / Math.Sqrt(number)).ToString("G4") + ")");
        }


    }
}
