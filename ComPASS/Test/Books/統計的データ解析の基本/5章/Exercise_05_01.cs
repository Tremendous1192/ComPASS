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

        public void Exercise_5_1()
        {
            BasicOfStatisticalDataAnalysis.Quote();

            Console.Write("第5章 正規分布と推測統計の基礎理論");
            Console.WriteLine("演習問題1を解きます。");
            Console.WriteLine("引用(数式は改変)\n");

            Console.WriteLine("ある地域における世帯別の突き当りの米購入量(単位:g)の分布が正規分布 N(6700, 1500^2)であると仮定できるとする.");
            Console.WriteLine("正規分布表を利用して,(a), (b), (c)に答えなさい.");

            Console.WriteLine("(a) 米購入量が9640g以上の世帯の割合はいくらか.");
            Console.WriteLine("(b) 米購入量が5500g以上10000g以下の世帯の割合はいくらか.");
            Console.WriteLine("(c) 米購入量が上位5%の世帯の購入量は何g以上か.");
            Console.WriteLine("\n");

            double mean = 6700;
            double std = 1500;

            // 1.96
            double zA = Math.Abs(9640 - mean) / std;
            Console.WriteLine("(a) 9640gを正規化すると, 9640 ⇒ " + zA + "である.");
            Console.WriteLine("正規分布表を用いると, その値は  0.0250  である.");
            Console.WriteLine("\n");

            // 0.8
            double zBLeft = Math.Abs(5500 - mean) / std;
            // 2.2
            double zBRight = Math.Abs(10000 - mean) / std;
            Console.WriteLine("(a) 5500gと10000gを正規化すると, 5500, 10000 ⇒ " + zBLeft + ", " + zBRight);
            Console.WriteLine("正規分布表を用いると, その値は  0.4681  と  0.0139  である.");
            Console.WriteLine("正規分布表は標準化した値の外側の割合を示しているので, その間に収まる割合は, 1 - 0.4681 - 0.0139 = "+(1 - 0.4681 - 0.0139)+" である.");
            Console.WriteLine("\n");

            Console.WriteLine("(c) 正規分布表より、上位5%の標準化値は," + 2.58 + "である");
            double buy = 2.58 * std + mean;
            Console.WriteLine("もとの系列に変換すると, 2.58 x " + std + " + " + mean + " = " + buy + "gである.");


        }


    }
}
