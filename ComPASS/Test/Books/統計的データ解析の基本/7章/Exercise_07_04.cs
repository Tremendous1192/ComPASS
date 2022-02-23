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

        public void Exercise_7_4()
        {
            BasicOfStatisticalDataAnalysis.Quote();

            Console.Write("第7章 1つの母集団に関する統計的検定");
            Console.WriteLine("演習問題4を解きます。");
            Console.WriteLine("引用(数式は改変. )\n");

            Console.WriteLine("帰無仮説 H0: σ^2 = 1.5^2, 仮説H1: σ^2 > 1.5^2を,");
            Console.WriteLine("下記のデータで検定しなさい.");
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
            double sumOfSquaredDeviations = Statistics<double>.SumOfSquaredDeviations(rawData);
            Console.WriteLine("データ数 n =" + number + "\t" + "平均値 m0 = " + mean.ToString("G3") + "\t" + "偏差平方和 S = " + sumOfSquaredDeviations.ToString("G3") + "\t" + "標本標準偏差 s =" + stdSample.ToString("G3"));
            Console.WriteLine("");

            // -2.268
            Console.WriteLine("検定統計量は, S/1.5^2 = " + (sumOfSquaredDeviations / 1.5 * 1.5).ToString("G4"));
            Console.WriteLine("優位水準 α = 0.05 とすると, χ(n-1, α) = 12.59, 検定統計量の絶対値はそれ以上のため,帰無仮説は棄却される.");
        }


    }
}
