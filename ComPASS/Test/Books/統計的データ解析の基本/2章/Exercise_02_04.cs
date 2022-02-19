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


namespace Test.Tremendous1192.SelfEmployed.CoMPASS.Books
{
    public partial class BasicOfStatisticalDataAnalysis
    {

        public void Exercise_2_4()
        {
            BasicOfStatisticalDataAnalysis.Quote();

            Console.Write("第2章 単一変数データの記述統計量と視覚的表現");
            Console.WriteLine("演習問題4を解きます。");
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
            Console.WriteLine("ヒストグラムの表示範囲を  [" + rangeMin + ", " + rangeMax + "]とする.");


            // ラベルを作成する.
            string[] labels = new string[length];
            for (int i = 0; i < length; i++)
            {
                if ((rangeMin + i) % 5 == 0)
                {
                    labels[i] = (rangeMin + i).ToString();
                }
            }

            //  度数を計算する.
            double[] frequency = new double[length];
            for (int i=0;i<sorted.Length;i++)
            {
                frequency[(int)(sorted[i] - rangeMin)] += 1;
                //Console.WriteLine(i + "\t" + sorted[i] + "\t" + (sorted[i] - rangeMin));
            }



            //=============================================================
            //    グラフを描画する
            //=============================================================


            // 大きさ640 x 480のグラフを作成する。
            XYChart xYChart = new XYChart(640, 480);

            // 位置(50, 0)から大きさ540 x 380 pxで、背景がLightYellow(0xFFFFE0)のチャートを作成する。
            xYChart.setPlotArea(50, 50, 640 - 50 - 50, 480 - 50 - 50, 0xFFFFE0);

            // グラフのタイトルを加える
            xYChart.addTitle(0, "統計的データ解析の基本 第2章 演習問題4", "Arial Bold", 20);

            // LimeGreen(0x32CD32)の棒グラフのレイヤー
            BarLayer barLayer = xYChart.addBarLayer(frequency, 0x32CD32, "握力の度数");

            // 棒グラフの間隔を詰める
            barLayer.setBarGap(Chart.TouchBar);

            // 3Dの装飾を加える
            barLayer.setBorderColor(-1, 1);

            // y軸のラベルのフォントをArial Boldにする
            xYChart.yAxis().setLabelStyle("Arial Bold");
            xYChart.yAxis().setTitle("度数", "Arial Bold", 12);

            // x軸のラベルを設定する
            ChartDirector.TextBox tb = xYChart.xAxis().setLabels(labels);
            xYChart.xAxis().setTitle("握力", "Arial Bold", 12);

            // ラベルは中央揃えにする。
            tb.setAlignment(Chart.Center);


            string current = System.IO.Directory.GetCurrentDirectory();
            //Console.WriteLine("現在のディレクトリ\t" + current);
            string fileName = "統計的データ解析の基本 第2章 演習問題4.png";
            //Console.WriteLine("ファイル名\t" + fileName);
            //Console.WriteLine("フルパス\t" + Path.Combine(current, fileName));

            //グラフを画像として保存する。
            xYChart.makeChart(Path.Combine(current, fileName));


            Console.WriteLine("");
            Console.WriteLine("ヒストグラムの画像を,本メソッドを実行するファイルのディレクトリに保存した.");
            Console.WriteLine("");


            ChartDirectorTest.NoteCredits();



        }


    }
}
