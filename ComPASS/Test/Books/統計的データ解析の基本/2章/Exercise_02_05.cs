using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.CoMPASS.MathApp;

//グラフを描画する
using ChartDirector;
//入出力
using System.IO;

//ChartDirectorのクレジットを記入する
using Test.Tremendous1192.SelfEmployed.CoMPASS.OtherNuGet;

//ScottPlotを使用する.
using ScottPlot;
using System.Linq;

namespace Test.Tremendous1192.SelfEmployed.CoMPASS.Books
{
    public partial class BasicOfStatisticalDataAnalysis
    {

        public void Exercise_2_5()
        {
            BasicOfStatisticalDataAnalysis.Quote();

            Console.Write("第2章 単一変数データの記述統計量と視覚的表現");
            Console.WriteLine("演習問題5を解きます。");
            Console.WriteLine("引用(数式は改変)\n");

            Console.WriteLine("下記は,文部科学省体力・運動能力調査(平成29年度)における18歳男子の握力測定結果(単位:kg)  n = 1042, xBar = 40.98," +
                " sxx = 6.39をもとに,人工的に生成したデータである.");
            Console.WriteLine("このデータに基づいて,ヒストグラムを作成しなさい.");


            //=============================================================
            //    生データを用意する
            //=============================================================

            List<double> listRawData = new List<double>();
            //1-10
            listRawData.Add(43); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(44); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(37); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(28); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(42); Console.Write(listRawData[listRawData.Count - 1] + "\t");

            listRawData.Add(48); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(38); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(35); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(48); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(39); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            Console.WriteLine("");
            //11-20
            listRawData.Add(41); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(43); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(47); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(31); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(44); Console.Write(listRawData[listRawData.Count - 1] + "\t");

            listRawData.Add(40); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(38); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(44); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(48); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(31); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            Console.WriteLine("");
            //21-30
            listRawData.Add(38); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(34); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(36); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(48); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(35); Console.Write(listRawData[listRawData.Count - 1] + "\t");

            listRawData.Add(47); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(41); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(50); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(42); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(52); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            Console.WriteLine("");
            //31-40
            listRawData.Add(59); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(40); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(55); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(41); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(41); Console.Write(listRawData[listRawData.Count - 1] + "\t");

            listRawData.Add(40); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(38); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(39); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(48); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(35); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            Console.WriteLine("");
            //41-50
            listRawData.Add(43); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(44); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(45); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(44); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(45); Console.Write(listRawData[listRawData.Count - 1] + "\t");

            listRawData.Add(43); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(39); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(37); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(36); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(48); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            Console.WriteLine("");
            //
            //51-60
            listRawData.Add(43); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(50); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(45); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(44); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(45); Console.Write(listRawData[listRawData.Count - 1] + "\t");

            listRawData.Add(46); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(42); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(35); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(37); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(43); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            Console.WriteLine("");
            //61-70
            listRawData.Add(39); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(57); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(52); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(51); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(38); Console.Write(listRawData[listRawData.Count - 1] + "\t");

            listRawData.Add(33); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(34); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(50); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(43); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(49); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            Console.WriteLine("");
            //71-80
            listRawData.Add(41); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(41); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(36); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(40); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(46); Console.Write(listRawData[listRawData.Count - 1] + "\t");

            listRawData.Add(46); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(44); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(44); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(37); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(39); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            Console.WriteLine("");
            //81-90
            listRawData.Add(45); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(52); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(40); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(37); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(39); Console.Write(listRawData[listRawData.Count - 1] + "\t");

            listRawData.Add(39); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(30); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(30); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(29); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(46); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            Console.WriteLine("");
            //91-100
            listRawData.Add(46); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(38); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(47); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(38); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(47); Console.Write(listRawData[listRawData.Count - 1] + "\t");

            listRawData.Add(48); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(39); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(38); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(41); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(56); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            Console.WriteLine("");
            //
            //101-110
            listRawData.Add(37); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(34); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(42); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(32); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(35); Console.Write(listRawData[listRawData.Count - 1] + "\t");

            listRawData.Add(41); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(43); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(53); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(43); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(49); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            Console.WriteLine("");
            //111-120
            listRawData.Add(40); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(37); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(36); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(45); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(44); Console.Write(listRawData[listRawData.Count - 1] + "\t");

            listRawData.Add(32); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(49); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(30); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(33); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(49); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            Console.WriteLine("");
            Console.WriteLine("");


            //=============================================================
            //    統計用にデータを加工する
            //=============================================================

            double[] rawDataArray = listRawData.ToArray();
            Console.WriteLine("昇順に入れ替えたデータを表示します.");
            double[] sorted = Statistics<double>.Sort(rawDataArray);
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(sorted[i * 10 + j] + "\t");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("データの統計量を計算します。.");
            double[] summary = Statistics<double>.Summary(sorted);
            Console.WriteLine("最小値" + "\t" + summary[0]);
            Console.WriteLine("第1四分位数" + "\t" + summary[1]);
            Console.WriteLine("中央値" + "\t" + summary[2]);
            Console.WriteLine("第3四分位数" + "\t" + summary[3]);
            Console.WriteLine("最大値" + "\t" + summary[4]);
            Console.WriteLine("平均値" + "\t" + summary[5].ToString("G3"));
            Console.WriteLine("標本標準偏差" + "\t" + summary[8].ToString("G3"));
            Console.WriteLine("");
            Console.WriteLine("");



            int rangeMin = 20;
            int rangeMax = 70;
            double step = Math.Round((summary[4] - summary[0]) / Math.Round(1 + Math.Log(sorted.Length, 2)));
            int length = rangeMax - rangeMin + 1;
            Console.WriteLine("最小値  " + summary[0] + "[kg],  最大値  " + summary[4] + "[kg]であるから,");
            Console.WriteLine("スタージェスの公式によると、階級の数は" + 1 + " + log_2(" + sorted.Length + ") ≒ "
                + (1 + Math.Log(sorted.Length, 2)).ToString("G3") + " ≒ " + Math.Round(1 + Math.Log(sorted.Length, 2)) + "個である.");
            Console.WriteLine("階級の幅は,(" + summary[4] + "-" + summary[0] + ")/" + Math.Round(1 + Math.Log(sorted.Length, 2)) + " ≒ "
                + ((summary[4] - summary[0]) / Math.Round(1 + Math.Log(sorted.Length, 2))).ToString("G3") + " ≒ "
                + step + "[kg]である.");

            Console.WriteLine("");
            Console.WriteLine("しかし,握力は整数値であり,データ数も120個あるので,階級幅を1[kg]としてヒストグラムを作成しても差支えないだろう.");
            // min 20,  max 70
            Console.WriteLine("ヒストグラムの表示範囲を  [" + rangeMin + ", " + rangeMax + "]とする.");


            //=============================================================
            //    グラフを描画する
            //=============================================================

            //キャンバスを作成する.
            var plt = new ScottPlot.Plot(640, 480);

            // タイトルを加える
            plt.Title("統計的データ解析の基本 第2章 演習問題5");


            // create a histogram
            (double[] counts, double[] binEdges) = ScottPlot.Statistics.Common.Histogram(rawDataArray, min: 20, max: 70, binSize: 1);
            double[] leftEdges = binEdges.Take(binEdges.Length - 1).ToArray();

            // display the histogram counts as a bar plot
            var bar = plt.AddBar(values: counts, positions: leftEdges);
            bar.BarWidth = 1;

            // customize the plot style
            plt.YAxis.Label("Count (#)");
            plt.XAxis.Label("握力 (kg)");
            plt.SetAxisLimits(yMin: 0);

            //グラフを保存する.
            string current = System.IO.Directory.GetCurrentDirectory();
            //Console.WriteLine("現在のディレクトリ\t" + current);
            string fileName = "統計的データ解析の基本 第2章 演習問題5.png";
            plt.SaveFig(Path.Combine(current, fileName));

        }


    }
}
