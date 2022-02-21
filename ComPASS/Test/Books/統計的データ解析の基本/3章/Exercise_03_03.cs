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

        public void Exercise_3_3()
        {
            BasicOfStatisticalDataAnalysis.Quote();

            Console.Write("第3章 2変数データの記述統計量と視覚的表現");
            Console.WriteLine("演習問題3を解きます。");
            Console.WriteLine("引用(数式は改変)\n");

            Console.WriteLine("下記は,50m走の練習法A, Bを1週間続けたときに,走力が向上したかどうかまとめたものである.");
            Console.WriteLine("これを(2 x 2)分割表にまとめ, オッズ比, 連関係数を求めなさい");

            List<string> methodList = new List<string>();
            methodList.Add("B"); methodList.Add("A"); methodList.Add("A"); methodList.Add("A"); methodList.Add("A");
            methodList.Add("A"); methodList.Add("A"); methodList.Add("B"); methodList.Add("B"); methodList.Add("B");
            methodList.Add("B");
            List<bool> improveList = new List<bool>();
            improveList.Add(true); improveList.Add(false); improveList.Add(true); improveList.Add(false); improveList.Add(false);
            improveList.Add(false); improveList.Add(false); improveList.Add(true); improveList.Add(true); improveList.Add(false);
            improveList.Add(true);

            double[,] TwoByTwoArray = new double[2, 2];
            for (int i = 0; i < methodList.Count; i++)
            {
                Console.Write("No." + (1 + i) + "\t");

                int method = 0;
                if (methodList[i] == "B") { method = 1; }
                Console.Write(methodList[i] + "\t");

                int improve = 0;
                if (improveList[i]) { Console.Write("効果あり"); }
                else { improve = 1; Console.Write("効果なし"); }
                Console.WriteLine();

                TwoByTwoArray[method, improve] += 1;
            }
            Console.WriteLine("\n");

            Console.WriteLine("分割表を記します.");
            Console.WriteLine("効果" + "\t\t" + "有" + "\t" + "無");
            Console.WriteLine("練習法 A" + "\t" + TwoByTwoArray[0, 0] + "\t" + TwoByTwoArray[0, 1]);
            Console.WriteLine("練習法 B" + "\t" + TwoByTwoArray[1, 0] + "\t" + TwoByTwoArray[1, 1]);
            Console.WriteLine("\n");

            Console.WriteLine("分割表を見ると,明らかに練習法 Bの方が効果がありそうです.");
            Console.WriteLine("オッズ比も 0 に近くて, 連関係数も1に近いため,2つの練習法には差がありそうです");
            Console.WriteLine("オッズ比" + "\t" + ((TwoByTwoArray[0, 0] / TwoByTwoArray[0, 1]) / (TwoByTwoArray[1, 0] / TwoByTwoArray[1, 1])).ToString("G3"));
            Console.WriteLine("連関係数" + "\t" + ((TwoByTwoArray[0, 0] * TwoByTwoArray[1, 1] - TwoByTwoArray[0, 1]* TwoByTwoArray[1, 0]) / (TwoByTwoArray[0, 0] * TwoByTwoArray[1, 1] - TwoByTwoArray[0, 1] * TwoByTwoArray[1, 0])).ToString("G3"));

        }


    }
}
