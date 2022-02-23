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

        public void Exercise_6_2()
        {
            BasicOfStatisticalDataAnalysis.Quote();

            Console.Write("第6章 1つの母集団に関する統計的推定");
            Console.WriteLine("演習問題2を解きます。");
            Console.WriteLine("引用(数式は改変. 問題文を(a), (b)などで小分けにした)\n");

            Console.WriteLine("ある値域における20歳の男性の身長(単位はcm)の分布が正規分布 N(μ, 8^2)であるとみなすことができるとする.");
            Console.WriteLine("この値域の20歳の男性を無作為に25人選んで身長を測ったところ,  標本平均は172.5cm であった");
            Console.WriteLine("(a) 母平均μの90%の信頼区間を求めなさい.");
            Console.WriteLine("(b) 母平均μの95%の信頼区間を求めなさい.");
            Console.WriteLine("(c) 母平均μの99%の信頼区間を求めなさい.");
            Console.WriteLine("\n");

            double number = 25;
            double mean = 172.5;
            double std = 8;
            double z90 = 1.65;
            double z95 = 1.96;
            double z99 = 2.58;


            Console.WriteLine("(a) 母平均μの90%の信頼区間を求めなさい.");
            Console.WriteLine("90%信頼区間は,  (xBar - 1.65σ/ √n ,  xBar + 1.65σ/ √n)");
            Console.WriteLine("すなわち, (" + (mean - z90 * std / Math.Sqrt(number)).ToString("G4") + ",  " + (mean + z90 * std / Math.Sqrt(number)).ToString("G4") + ")");
            Console.WriteLine("");


            Console.WriteLine("(b) 母平均μの95%の信頼区間を求めなさい.");
            Console.WriteLine("95%信頼区間は,  (xBar - 1.96σ/ √n ,  xBar + 1.96σ/ √n)");
            Console.WriteLine("すなわち, (" + (mean - z95 * std / Math.Sqrt(number)).ToString("G4") + ",  " + (mean + z95 * std / Math.Sqrt(number)).ToString("G4") + ")");
            Console.WriteLine("");


            Console.WriteLine("(c) 母平均μの99%の信頼区間を求めなさい.");
            Console.WriteLine("99%信頼区間は,  (xBar - 2.58σ/ √n ,  xBar + 2.58σ/ √n)");
            Console.WriteLine("すなわち, (" + (mean - z99 * std / Math.Sqrt(number)).ToString("G4") + ",  " + (mean + z99 * std / Math.Sqrt(number)).ToString("G4") + ")");
        }


    }
}
