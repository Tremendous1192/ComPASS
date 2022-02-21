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

        public void Exercise_3_1()
        {
            BasicOfStatisticalDataAnalysis.Quote();

            Console.Write("第3章 2変数データの記述統計量と視覚的表現");
            Console.WriteLine("演習問題1を解きます。");
            Console.WriteLine("引用(数式は改変)\n");

            Console.WriteLine("次のデータについて,散布図を作成しなさい.  また,xBar = yBar =0 であることを利用して,相関係数を計算しなさい.");

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
