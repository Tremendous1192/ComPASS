using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.CoMPASS.MathApp;


//入出力
using System.IO;

//ScottPlotを使用する.
using ScottPlot;

namespace Test.Tremendous1192.SelfEmployed.CoMPASS.Books
{
    public partial class BasicOfStatisticalDataAnalysis
    {

        public void Exercise_2_6()
        {
            BasicOfStatisticalDataAnalysis.Quote();

            Console.Write("第2章 単一変数データの記述統計量と視覚的表現");
            Console.WriteLine("演習問題6を解きます。");
            Console.WriteLine("引用(数式は改変)\n");

            Console.WriteLine("2015年都道府県別栽培きのこ類生産量(単位:千万円)を,生産量が「少ない順に示す.");
            Console.WriteLine("(a)生産量, (b)対数変換後の生産量の箱ひげ図を作成しなさい.");


            List<string> prefecturesList = new List<string>();
            //1-10
            prefecturesList.Add("大阪府");Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("佐賀県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("山口県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("東京都"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("山梨県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");

            prefecturesList.Add("神奈川"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("青森県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("福井県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("滋賀県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("沖縄県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            Console.WriteLine("");
            //11-20
            prefecturesList.Add("奈良県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("鳥取県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("和歌山"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("愛知県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("岡山県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");

            prefecturesList.Add("千葉県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("京都府"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("高知県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("埼玉県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("兵庫県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            Console.WriteLine("");
            //21-30
            prefecturesList.Add("石川県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("愛媛県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("島根県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("富山県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("鹿児島"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");

            prefecturesList.Add("三重県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("熊本県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("茨城県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("岐阜県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("福島県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            Console.WriteLine("");
            //31-40
            prefecturesList.Add("栃木県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("宮城県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("香川県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("宮崎県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("広島県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");

            prefecturesList.Add("群馬県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("岩手県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("秋田県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("山形県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("長崎県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            Console.WriteLine("");
            //41-50
            prefecturesList.Add("静岡県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("大分県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("徳島県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("福岡県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("北海道"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");

            prefecturesList.Add("新潟県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            prefecturesList.Add("長野県"); Console.Write(prefecturesList[prefecturesList.Count - 1] + "\t");
            Console.WriteLine("");
            Console.WriteLine("");


            //=============================================================
            //    生データを用意する
            //=============================================================

            List<double> listRawData = new List<double>();
            //1-10
            listRawData.Add(14); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(21); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(22); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(23); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(25); Console.Write(listRawData[listRawData.Count - 1] + "\t");

            listRawData.Add(39); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(43); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(43); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(52); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(55); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            Console.WriteLine("");
            //11-20
            listRawData.Add(58); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(83); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(90); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(91); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(104); Console.Write(listRawData[listRawData.Count - 1] + "\t");

            listRawData.Add(105); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(105); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(112); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(127); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(137); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            Console.WriteLine("");
            //21-30
            listRawData.Add(140); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(156); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(167); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(183); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(186); Console.Write(listRawData[listRawData.Count - 1] + "\t");

            listRawData.Add(187); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(245); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(248); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(262); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(286); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            Console.WriteLine("");
            //31-40
            listRawData.Add(322); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(360); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(414); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(425); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(441); Console.Write(listRawData[listRawData.Count - 1] + "\t");

            listRawData.Add(443); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(509); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(509); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(509); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(628); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            Console.WriteLine("");
            //41-50
            listRawData.Add(675); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(747); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(839); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(963); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(1088); Console.Write(listRawData[listRawData.Count - 1] + "\t");

            listRawData.Add(3860); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            listRawData.Add(4955); Console.Write(listRawData[listRawData.Count - 1] + "\t");
            Console.WriteLine("");
            Console.WriteLine("");


            //=============================================================
            //    統計用にデータを加工する
            //=============================================================

            double[] rawDataArray = listRawData.ToArray();
            double[] logNaturalArray = new double[rawDataArray.Length];
            for (int i = 0; i < logNaturalArray.Length; i++)
            {
                logNaturalArray[i] = Math.Log(rawDataArray[i]);
            }

            Console.WriteLine("きのこの生産量を自然対数に変換します.");
            for (int i = 0; i < logNaturalArray.Length; i++)
            {
                Console.WriteLine(prefecturesList[i] + "\t" + rawDataArray[i] + "\t" + logNaturalArray[i].ToString("G3"));
            }
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("データの統計量を計算します.");
            double[] summaryRawData = Statistics<double>.Summary(rawDataArray);
            double[] summaryLogNatural = Statistics<double>.Summary(logNaturalArray);

            Console.WriteLine("最小値" + "\t\t" + summaryRawData[0] + "\t" + summaryLogNatural[0].ToString("G3"));
            Console.WriteLine("第1四分位数" + "\t" + summaryRawData[1] + "\t" + summaryLogNatural[1].ToString("G3"));
            Console.WriteLine("中央値" + "\t\t" + summaryRawData[2] + "\t" + summaryLogNatural[2].ToString("G3"));
            Console.WriteLine("第3四分位数" + "\t" + summaryRawData[3] + "\t" + summaryLogNatural[3].ToString("G3"));
            Console.WriteLine("最大値" + "\t\t" + summaryRawData[4] + "\t" + summaryLogNatural[4].ToString("G3"));
            Console.WriteLine("平均値" + "\t\t" + summaryRawData[5].ToString("G3") + "\t" + summaryLogNatural[5].ToString("G3"));
            Console.WriteLine("標本標準偏差" + "\t" + summaryRawData[8].ToString("G3") + "\t" + summaryLogNatural[8].ToString("G3"));
            Console.WriteLine("");
            Console.WriteLine("");







            //=============================================================
            //    生データのグラフを描画する
            //=============================================================

            //キャンバスを作成する.
            var plt = new ScottPlot.Plot(640, 480);

            // タイトルを加える
            plt.Title("(a)生データの箱ひげ図");


            // 生データを分布データに変換する.
            var pop = new ScottPlot.Statistics.Population(rawDataArray);


            // キャンバスに分布を描画する.
            // 凡例を加えたいので、複数のグループの描画方法を利用する.
            var poulationsRawData = new ScottPlot.Statistics.Population[] { pop};
            plt.AddPopulations(poulationsRawData);

            // 凡例をx軸の目盛りに加える.
            string[] populationNames = { "生データ" };
            plt.XAxis.Grid(false);
            plt.XTicks(populationNames);

            // y軸
            plt.YAxis.Label("生産量(千万円)");

            // x軸とy軸の描画範囲を設定する.
            plt.SetAxisLimits(-1, +1, 0, 5000);


            //グラフを保存する.
            string current = System.IO.Directory.GetCurrentDirectory();
            //Console.WriteLine("現在のディレクトリ\t" + current);
            string fileName = "統計的データ解析の基本 第2章 演習問題6 (a).png";

            plt.SaveFig(Path.Combine(current, fileName));


            //=============================================================
            //    対数変換データのグラフを描画する
            //=============================================================

            //キャンバスを作成する.
            var pltLog = new ScottPlot.Plot(640, 480);

            // タイトルを加える
            pltLog.Title("(b)対数変換データの箱ひげ図");


            // 生データを分布データに変換する.
            var popLog = new ScottPlot.Statistics.Population(logNaturalArray);


            // キャンバスに分布を描画する.
            // 凡例を加えたいので、複数のグループの描画方法を利用する.
            var poulationsLog = new ScottPlot.Statistics.Population[] { popLog };
            pltLog.AddPopulations(poulationsLog);

            // 凡例をx軸の目盛りに加える.
            string[] populationNamesLog = { "対数変換データ" };
            pltLog.XAxis.Grid(false);
            pltLog.XTicks(populationNamesLog);

            // y軸
            pltLog.YAxis.Label("ln生産量(ln千万円)");

            // x軸とy軸の描画範囲を設定する.
            pltLog.SetAxisLimits(-1, +1, 0, 10);


            //グラフを保存する.
            //Console.WriteLine("現在のディレクトリ\t" + current);
            string fileNameLog = "統計的データ解析の基本 第2章 演習問題6 (b).png";

            pltLog.SaveFig(Path.Combine(current, fileNameLog));


            //=============================================================
            //    箱ひげ図を描画する
            //=============================================================


            var mp = new ScottPlot.MultiPlot(width: 800, height: 600, rows: 1, cols: 2);

            mp.subplots[0].Title("(a)  生データ");
            mp.subplots[0].AddPopulations(poulationsRawData);
            mp.subplots[0].YAxis.Label("生産量  (千万円)");
            mp.subplots[0].XTicks(populationNames);
            mp.subplots[0].SetAxisLimits(-1, +1, 0, 5000);
            mp.subplots[0].XAxis.Grid(false);

            mp.subplots[1].Title("(b)  対数変換データ");
            mp.subplots[1].AddPopulations(poulationsLog);
            mp.subplots[1].YAxis.Label("ln生産量  (ln千万円)");
            mp.subplots[1].XTicks(populationNamesLog);
            mp.subplots[1].SetAxisLimits(-1, +1, 0, 10);
            mp.subplots[1].XAxis.Grid(false);


            string fileNameMulti = "統計的データ解析の基本 第2章 演習問題6.png";


            mp.SaveFig(Path.Combine(current, fileNameMulti));


        }


    }
}
