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

        public void Exercise_3_4()
        {
            BasicOfStatisticalDataAnalysis.Quote();

            Console.Write("第3章 2変数データの記述統計量と視覚的表現");
            Console.WriteLine("演習問題4を解きます。");
            Console.WriteLine("引用(数式は改変)\n");

            Console.WriteLine("下記は,2015年の木材生産量ときのこ生産量の順位である.");
            Console.WriteLine("スピアマンの順位相関係数, ケンドールの順位相関計数を求めなさい");

            List<string> prefecturesList = new List<string>();
            prefecturesList.Add("北海道");
            prefecturesList.Add("宮城県");
            prefecturesList.Add("東京都");
            prefecturesList.Add("長野県");
            prefecturesList.Add("広島県");

            prefecturesList.Add("佐賀県");

            List<double> woodRankList = new List<double>();
            woodRankList.Add(1); woodRankList.Add(3); woodRankList.Add(6); woodRankList.Add(2); woodRankList.Add(4);
            woodRankList.Add(5);

            List<double> mushroomRankList = new List<double>();
            mushroomRankList.Add(2); mushroomRankList.Add(4); mushroomRankList.Add(5); mushroomRankList.Add(1); mushroomRankList.Add(3);
            mushroomRankList.Add(6);

            double[,] designMatrix = new double[woodRankList.Count, 2];

            Console.WriteLine("県名  " + "\t" + "木材" + "\t" + "きのこ");
            for (int i = 0; i < prefecturesList.Count; i++)
            {
                Console.WriteLine(prefecturesList[i] + "\t" + woodRankList[i] + "\t" + mushroomRankList[i]);

                designMatrix[i, 0] = woodRankList[i];
                designMatrix[i, 1] = mushroomRankList[i];
            }

            double[,] correlationMatrix = Statistics<double>.SampleCorrelationMatrix(designMatrix);
            double spearman = correlationMatrix[0, 1];


            double kendall = 0;
            double plus = 0;
            double minus = 0;
            for (int i = 0; i < woodRankList.Count; i++)
            {
                for (int j = i + 1; j < mushroomRankList.Count; j++)
                {
                    if ((woodRankList[i] - woodRankList[j]) * (mushroomRankList[i] - mushroomRankList[j]) > 0)
                    {
                        plus += 1;
                    }
                    else
                    {
                        minus += 1;
                    }
                }
            }
            kendall = (plus - minus) / (woodRankList.Count * (woodRankList.Count - 1) / 2);

            Console.WriteLine("\n");
            Console.WriteLine("スピアマンの順位相関計数" + "\t" + spearman.ToString("G3"));
            Console.WriteLine("ケンドールの順位相関計数" + "\t" + kendall.ToString("G3"));


            return;


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


            return;

            List<double> xList = new List<double>();
            xList.Add(-5); xList.Add(-4); xList.Add(-3); xList.Add(-2); xList.Add(-1);
            xList.Add(0);
            xList.Add(1); xList.Add(2); xList.Add(3); xList.Add(4); xList.Add(5);

            List<double> yList = new List<double>();
            yList.Add(4); yList.Add(-5); yList.Add(1); yList.Add(-3); yList.Add(-2);
            yList.Add(0);
            yList.Add(5); yList.Add(3); yList.Add(2); yList.Add(-1); yList.Add(-4);

            double[] xArray = xList.ToArray();
            double[] yArray = yList.ToArray();
            double[,] designMatrixArray = new double[xArray.Length, 2];
            for (int i=0;i<xArray.Length;i++)
            {
                designMatrixArray[i, 0] = xArray[i];
                designMatrixArray[i, 1] = yArray[i];
            }

            double[,] correlationMatrixArray = Statistics<double>.SampleCorrelationMatrix(designMatrixArray);

            Console.WriteLine("x" + "\t" + "y");
            for (int i=0;i<xArray.Length;i++)
            {
                Console.WriteLine(xArray[i] + "\t" + yArray[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("相関係数" + correlationMatrixArray[0, 1]);


            //=============================================================
            //    生データのグラフを描画する
            //=============================================================

            //キャンバスを作成する.
            var plt = new ScottPlot.Plot(640, 480);

            // タイトルを加える
            plt.Title("第3章 演習問題1の散布図", true, color: Color.Black, 20);

            // 散布図を加える.
            plt.AddScatter(xArray, yArray, color: Color.Magenta, lineWidth: 0);

            // 軸のラベルを追加する
            plt.XAxis.Label("x", color: Color.Black, 16);
            plt.YAxis.Label("y", color: Color.Black, 16);


            //グラフを保存する.
            string current = System.IO.Directory.GetCurrentDirectory();
            //Console.WriteLine("現在のディレクトリ\t" + current);
            string fileName = "統計的データ解析の基本 第3章 演習問題1.png";

            plt.SaveFig(Path.Combine(current, fileName));


        }


    }
}
