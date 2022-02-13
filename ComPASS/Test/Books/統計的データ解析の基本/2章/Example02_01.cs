using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.CoMPASS.MathApp;

namespace Test.Tremendous1192.SelfEmployed.CoMPASS.Books
{
    public partial class BasicOfStatisticalDataAnalysis
    {

        public void Example02_01()
        {
            BasicOfStatisticalDataAnalysis.Quote();

            Console.WriteLine("例題2.1を解きます。");
            Console.WriteLine("引用(数式は改変)\n");
            Console.Write("下記は,2015年度の都道府県別栽培きのこ類生産量(単位千円)である。");
            Console.Write("このデータについて、平均x_average,メジアンx_medianを計算しなさい。\n");

            string[,] Label = new string[7, 1];
            Label[0, 0] = "大阪\t";
            Label[1, 0] = "佐賀\t";
            Label[2, 0] = "山口\t";
            Label[3, 0] = "東京\t";
            Label[4, 0] = "山梨\t";
            Label[5, 0] = "神奈川\t";
            Label[6, 0] = "長野\t";

            double[,] designMatrix = new double[7, 1];
            designMatrix[0, 0] = 14;
            designMatrix[1, 0] = 21;
            designMatrix[2, 0] = 22;
            designMatrix[3, 0] = 23;
            designMatrix[4, 0] = 25;
            designMatrix[5, 0] = 39;
            designMatrix[6, 0] = 4955;
            for (int i = 0; i < designMatrix.GetLength(0); i++) { Console.WriteLine(Label[i, 0] + "\t" + designMatrix[i, 0]); }
            Console.Write("\n");

            Console.WriteLine("\n引用終わり(数式は改変)\n");

            double[,] summary = Statistics<double>.Summary(designMatrix);
            Console.WriteLine("[0,*] 最小値\t\t" + summary[0, 0]);
            Console.WriteLine("[1,*] 第一四分位数\t" + summary[1, 0]);
            Console.WriteLine("[2,*] 中央値\t\t" + summary[2, 0]);
            Console.WriteLine("[3,*] 第三四分位数\t" + summary[3, 0]);
            Console.WriteLine("[4,*] 最大値\t\t" + summary[4, 0]);
            Console.WriteLine("[5,*] 平均値\t\t" + summary[5, 0].ToString("G6"));

        }


    }
}
