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

        public void Exercise_6_5()
        {
            BasicOfStatisticalDataAnalysis.Quote();

            Console.Write("第6章 1つの母集団に関する統計的推定");
            Console.WriteLine("演習問題5を解きます。");
            Console.WriteLine("引用(数式は改変. 問題文を(a), (b)などで小分けにした)\n");

            Console.WriteLine("ある果物における可食部100g中のビタミンCの量(単位はmg)について,その分布が正規分布 N(μ, σ^2)であるとみなすことができるとする.");
            Console.WriteLine("この果物を無作為に6つ選んで可食部100g中のビタミンCの量を測ったところ,");
            double[] rawData = new double[6];
            rawData[0] = 62; rawData[0] = 70; rawData[0] = 58; rawData[0] = 64; rawData[0] = 71;
            rawData[0] = 65;
            for (int i=0;i<rawData.Length-1;i++)
            {
                Console.Write(rawData[i] + ", ");
            }
            Console.WriteLine(rawData[rawData.Length - 1]);
            Console.WriteLine("という観測値が得られた.");
            Console.WriteLine("");

            Console.WriteLine("(a) 母平均μの90%信頼区間を求めなさい.");
            Console.WriteLine("(b) 母平均μの95%信頼区間を求めなさい.");
            Console.WriteLine("(c) 母平均μの99%信頼区間を求めなさい.");
            Console.WriteLine("(d) 母分散σ^2 および母標準偏差σ の90%信頼区間を求めなさい.");
            Console.WriteLine("(e) 母分散σ^2 および母標準偏差σ の95%信頼区間を求めなさい.");
            Console.WriteLine("(f) 母分散σ^2 および母標準偏差σ の99%信頼区間を求めなさい.");
            Console.WriteLine("\n");

            double number = rawData.Length;
            double mean = Statistics<double>.SampleMean(rawData);
            double stdSample = Statistics<double>.SampleStandardDeviation(rawData);

            Console.WriteLine("母分散σ^2 が未知の場合の推定である.");
            Console.WriteLine("標本標準偏差s を母標準偏差σ の代わりに用いる.");
            Console.WriteLine("");


            Console.WriteLine("(a) 母平均μの90%信頼区間を求めなさい.");
            double z90 = 1.65;
            Console.WriteLine("90%信頼区間は,  (xBar - 1.65σ/ √n ,  xBar + 1.65σ/ √n)");
            Console.WriteLine("すなわち, (" + (mean - z90 * stdSample / Math.Sqrt(number)).ToString("G4") + ",  " + (mean + z90 * stdSample / Math.Sqrt(number)).ToString("G4") + ")");
            Console.WriteLine("");


            Console.WriteLine("(b) 母平均μの95%信頼区間を求めなさい.");
            double z95 = 1.96;
            Console.WriteLine("95%信頼区間は,  (xBar - 1.96σ/ √n ,  xBar + 1.96σ/ √n)");
            Console.WriteLine("すなわち, (" + (mean - z95 * stdSample / Math.Sqrt(number)).ToString("G4") + ",  " + (mean + z95 * stdSample / Math.Sqrt(number)).ToString("G4") + ")");
            Console.WriteLine("");


            Console.WriteLine("(c) 母平均μの99%信頼区間を求めなさい.");
            double z99 = 2.58;
            Console.WriteLine("99%信頼区間は,  (xBar - 2.58σ/ √n ,  xBar + 2.58σ/ √n)");
            Console.WriteLine("すなわち, (" + (mean - z99 * stdSample / Math.Sqrt(number)).ToString("G4") + ",  " + (mean + z99 * stdSample / Math.Sqrt(number)).ToString("G4") + ")");
            Console.WriteLine("\n");


            Console.WriteLine("(d) 母分散σ^2 および母標準偏差σ の90%信頼区間を求めなさい.");
            double kai_n9_05 = 16.92;
            double kai_n9_95 = 3.33;
            Console.WriteLine("母分散σ^2の90%信頼区間は,  (s^2/ χ(n-1, 0.05),  s^2/ χ(n-1, 0.95) )");
            Console.WriteLine("すなわち, (" + (stdSample / kai_n9_05).ToString("G4") + ",  " + (stdSample / kai_n9_95).ToString("G4") + ")");
            Console.WriteLine("");

            Console.WriteLine("母標準偏差σの90%信頼区間は,  (s/ √χ(n-1, 0.05),  s/ √χ(n-1, 0.95) )");
            Console.WriteLine("すなわち, (" + Math.Sqrt(stdSample / kai_n9_05).ToString("G4") + ",  " + Math.Sqrt(stdSample / kai_n9_95).ToString("G4") + ")");
            Console.WriteLine("\n");


            Console.WriteLine("(e) 母分散σ^2 および母標準偏差σ の95%信頼区間を求めなさい.");
            double kai_n9_025 = 19.2;
            double kai_n9_975 = 2.7;
            Console.WriteLine("母分散σ^2の95%信頼区間は,  (s^2/ χ(n-1, 0.025),  s^2/ χ(n-1, 0.975) )");
            Console.WriteLine("すなわち, (" + (stdSample / kai_n9_025).ToString("G4") + ",  " + (stdSample / kai_n9_975).ToString("G4") + ")");
            Console.WriteLine("");

            Console.WriteLine("母標準偏差σの95%信頼区間は,  (s/ √χ(n-1, 0.025),  s/ √χ(n-1, 0.975) )");
            Console.WriteLine("すなわち, (" + Math.Sqrt(stdSample / kai_n9_025).ToString("G4") + ",  " + Math.Sqrt(stdSample / kai_n9_975).ToString("G4") + ")");
            Console.WriteLine("\n");


            Console.WriteLine("(f) 母分散σ^2 および母標準偏差σ の99%信頼区間を求めなさい.");
            double kai_n9_005 = 23.6;
            double kai_n9_995 = 1.735;
            Console.WriteLine("母分散σ^2の95%信頼区間は,  (s^2/ χ(n-1, 0.005),  s^2/ χ(n-1, 0.995) )");
            Console.WriteLine("すなわち, (" + (stdSample / kai_n9_005).ToString("G4") + ",  " + (stdSample / kai_n9_995).ToString("G4") + ")");
            Console.WriteLine("");

            Console.WriteLine("母標準偏差σの95%信頼区間は,  (s/ √χ(n-1, 0.005),  s/ √χ(n-1, 0.995) )");
            Console.WriteLine("すなわち, (" + Math.Sqrt(stdSample / kai_n9_005).ToString("G4") + ",  " + Math.Sqrt(stdSample / kai_n9_995).ToString("G4") + ")");
            Console.WriteLine("\n");

        }


    }
}
