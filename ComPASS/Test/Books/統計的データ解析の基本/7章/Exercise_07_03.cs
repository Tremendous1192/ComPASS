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

        public void Exercise_7_3()
        {
            BasicOfStatisticalDataAnalysis.Quote();

            Console.Write("第7章 1つの母集団に関する統計的検定");
            Console.WriteLine("演習問題3を解きます。");
            Console.WriteLine("引用(数式は改変. )\n");

            Console.WriteLine("帰無仮説 H0: μ=50, 仮説H1: μ ≠ 50を, σ^2 を未知として,");
            Console.WriteLine("α= 0.05で次のデータにより検定しなさい.");
            Console.WriteLine("\n");


            double[] rawData = new double[7];
            rawData[0] = 53; rawData[1] = 55; rawData[2] = 52; rawData[3] = 54; rawData[4] = 51;
            rawData[5] = 54; rawData[6] = 49;
            for (int i = 0; i < rawData.Length - 1; i++)
            {
                Console.Write(rawData[i] + "\t");
            }
            Console.Write(rawData[rawData.Length - 1]);
            Console.WriteLine("");


            double number = rawData.Length;
            double mean = Statistics<double>.SampleMean(rawData);
            double stdSample = Statistics<double>.SampleStandardDeviation(rawData);
            Console.WriteLine("データ数 n =" + number + "\t" + "平均値 m0 = " + mean.ToString("G3") + "\t" + "標本標準偏差 s =" + stdSample.ToString("G3"));
            Console.WriteLine("");

            // -3.268
            Console.WriteLine("検定統計量は, (xBar - m0)/(s/√n) = " + ((50 - mean) / (stdSample / Math.Sqrt(number))).ToString("G4"));
            Console.WriteLine("優位水準 α = 0.05 とすると, 棄却域は 1.96 以上であり, 検定統計量の絶対値はそれ以上のため,帰無仮説は棄却される.");
        }


    }
}
