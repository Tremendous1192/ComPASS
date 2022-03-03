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

        public void Exercise_8_1()
        {
            BasicOfStatisticalDataAnalysis.Quote();

            Console.Write("第8章 計量値データにおける2つの母集団の比較");
            Console.WriteLine("演習問題1を解きます。");
            Console.WriteLine("引用(数式は改変. )\n");

            Console.WriteLine("母集団P1, P2からの下記データで,σ1 = 2.0, σ2 = 2.5とし,");
            Console.WriteLine("μ1 - μ2 の点推定値, 95%の信頼区間を求め, ");
            Console.WriteLine("α= 0.05, H1: μ1 ≠ μ2 で検定しなさい.");
            Console.WriteLine("\n");


            double[] group1 = new double[6] { 23, 25, 20, 21, 24, 25 };
            double[] group2 = new double[8] { 21, 20, 15, 18, 21, 21, 23, 20 };
            double sigma1 = 2;
            double sigma2 = 2.5;

            Console.WriteLine("点推定値 μ1 - μ2 = \t" + Statistics<double>.ExpectMeansDifference(group1, group2).ToString("G3"));
            double[] reliableRange = Statistics<double>.ExpectMeansDifference(0.05, group1, group2, sigma1, sigma2);
            Console.WriteLine("95%信頼区間 μ1 - μ2 ± Kp(0.05)V = \t" + reliableRange[0].ToString("G3") + ",  " + reliableRange[1].ToString("G3"));

            Console.WriteLine("\n"+"検定を行う");
            if (Statistics<double>.TestMeansDifference(0.05,group1,group2,sigma1,sigma2))
            {
                Console.WriteLine("母集団P1, P2の平均値の差は0ではない.");
            }
            Console.WriteLine("母集団P1, P2の平均値の差は0ではないとはいえない.");
        }


    }
}
