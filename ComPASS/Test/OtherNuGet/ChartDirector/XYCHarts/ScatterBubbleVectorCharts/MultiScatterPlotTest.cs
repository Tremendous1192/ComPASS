using System;
using System.Collections.Generic;
using System.Text;
//グラフを描画する
using ChartDirector;
//入出力
using System.IO;

using Tremendous1192.SelfEmployed.CoMPASS.MathApp;

namespace Test.Tremendous1192.SelfEmployed.CoMPASS.OtherNuGet
{
    public partial class ChartDirectorTest
    {

        public void MultiScatterPlotTest()
        {

            Console.WriteLine("Rのサマリー関数のように、各変数のヒストグラムと散布図を作成するテスト関数");

            int length = 1000;
            double mean = 10;
            double standardDeviation = 5;
            Console.WriteLine("データ数 " + length + ", 平均値 " + mean + ", 標準偏差 " + standardDeviation + ", の正規分布と、等しい標準偏差の半正規分布のデータを用いる");

            NormalDistribution normalDistribution01 = new NormalDistribution(1, 2);
            double[] dataSet01 = new double[length];

            HalfNormalDistribution logNormalDistribution02 = new HalfNormalDistribution(10, 5);
            double[] dataSet02 = new double[length];

            for (int i = 0; i < length; i++)
            {
                dataSet01[i] = normalDistribution01.NextDouble(mean, standardDeviation);
                dataSet02[i] = logNormalDistribution02.NextDouble(standardDeviation);
            }


            // ヒストグラムの上限と下限を計算する
            // 分かりやすさのため、整数でデータを区切る
            double min01 = double.MaxValue;
            double max01 = double.MinValue;
            foreach (double d in dataSet01)
            {
                min01 = Math.Min(min01, d);
                max01 = Math.Max(max01, d);
            }
            min01 = Math.Floor(min01);
            max01 = Math.Ceiling(max01);
            Console.WriteLine("Data Set 01の最小値 " + min01 + ", 最大値 " + max01);

            double min02 = double.MaxValue;
            double max02 = double.MinValue;
            foreach (double d in dataSet02)
            {
                min02 = Math.Min(min02, d);
                max02 = Math.Max(max02, d);
            }
            min02 = Math.Floor(min02);
            max02 = Math.Ceiling(max02);
            Console.WriteLine("Data Set 02の最小値 " + min02 + ", 最大値 " + max02);


            //ヒストグラムを作成する
            double[] histgram01 = new double[(int)Math.Ceiling(max01 - min01) + 2];
            foreach (double d in dataSet01)
            {
                histgram01[(int)Math.Round(d - min01)]++;
            }
            string[] labels01 = new string[histgram01.Length];
            for (int i = 0; i < labels01.Length; i++)
            {
                if (i + min01 < 0)
                {
                    if ((int)Math.Abs(Math.Round(i + min01)) % 5 == 0)
                    {
                        labels01[i] = (Math.Round(i + min01)).ToString();
                    }
                }
                else
                {
                    if ((int)Math.Round(i + min01) % 5 == 0)
                    {
                        labels01[i] = (Math.Round(i + min01)).ToString();
                    }
                }
            }

            double[] histgram02 = new double[(int)Math.Ceiling(max02 - min02) + 2];
            foreach (double d in dataSet02)
            {
                histgram02[(int)Math.Round(d - min02)]++;
            }
            string[] labels02 = new string[histgram02.Length];
            for (int i = 0; i < labels02.Length; i++)
            {
                if (i + min02 < 0)
                {
                    if ((int)Math.Abs(Math.Round(i + min02)) % 5 == 0)
                    {
                        labels02[i] = (Math.Round(i + min02)).ToString();
                    }
                }
                else
                {
                    if ((int)Math.Round(i + min02) % 5 == 0)
                    {
                        labels02[i] = (Math.Round(i + min02)).ToString();
                    }
                }
            }

            ////////////////////
            ////データセット01のヒストグラムのグラフを作成する。
            // 大きさ420 x 297のグラフを作成する。
            XYChart xYChart01_01 = new XYChart(420, 297);

            // 位置(50, 25)から大きさ297 x 210 pxで、背景がCoral(FF7F50)のチャートを作成する。
            xYChart01_01.setPlotArea(50, 25, 297, 210, 0xFF7F50);

            // 右上に凡例のテキストを追加する
            xYChart01_01.addText(300, 0, "データセット 01", "Times New Roman Bold Italic", 12, 0xa07070).setAlignment(Chart.TopRight);

            // インディゴ(0x4B0082)の棒グラフのレイヤー
            BarLayer dataSet01Layer = xYChart01_01.addBarLayer(histgram01, 0x4B0082, "Data Set 01");

            // 棒グラフの間隔を詰める
            dataSet01Layer.setBarGap(Chart.TouchBar);

            // y軸のラベルのフォントをArial Boldにする
            xYChart01_01.yAxis().setLabelStyle("Arial Bold");

            // x軸のラベルを設定する
            ChartDirector.TextBox tb01 = xYChart01_01.xAxis().setLabels(labels01);

            // ラベルの横幅を 50に設定する。高さは自動。ラベルは中央揃えにする。
            //tb01.setSize(50, 0);
            //tb01.setAlignment(Chart.Center);

            // ラベルのフォントをArial Boldにする
            tb01.setFontStyle("Arial Bold");

            // x軸のメモリの幅を0にする。(見えなくする)
            //xYChart01_01.xAxis().setTickLength(0);

            // 横軸のラベルを加える
            xYChart01_01.xAxis().setTitle("データセット 01", "Arial Bold Italic", 12);

            // 縦軸のラベルを加える
            xYChart01_01.yAxis().setTitle("頻度", "Arial Bold Italic", 12);

            ////////////////////
            ////データセット02のヒストグラムのグラフを作成する。
            // 大きさ420 x 297のグラフを作成する。
            XYChart xYChart02_02 = new XYChart(420, 297);

            // 位置(50, 25)から大きさ297 x 210 pxで、背景がCoral(FF7F50)のチャートを作成する。
            xYChart02_02.setPlotArea(50, 25, 297, 210, 0xFF7F50);

            // 右上に凡例のテキストを追加する
            xYChart02_02.addText(300, 0, "データセット 02", "Times New Roman Bold Italic", 12, 0xa07070).setAlignment(Chart.TopRight);

            // インディゴ(0x4B0082)の棒グラフのレイヤー
            BarLayer dataSet02Layer = xYChart02_02.addBarLayer(histgram02, 0x4B0082, "Data Set 02");

            // 棒グラフの間隔を詰める
            dataSet02Layer.setBarGap(Chart.TouchBar);

            // y軸のラベルのフォントをArial Boldにする
            xYChart02_02.yAxis().setLabelStyle("Arial Bold");

            // x軸のラベルを設定する
            ChartDirector.TextBox tb02 = xYChart02_02.xAxis().setLabels(labels02);

            // ラベルの横幅を 50に設定する。高さは自動。ラベルは中央揃えにする。
            tb02.setSize(50, 0);
            tb02.setAlignment(Chart.Center);

            // ラベルのフォントをArial Boldにする
            tb02.setFontStyle("Arial Bold");

            // x軸のメモリの幅を0にする。(見えなくする)
            xYChart02_02.xAxis().setTickLength(0);

            // 横軸のラベルを加える
            xYChart02_02.xAxis().setTitle("データセット 02", "Arial Bold Italic", 12);

            // 縦軸のラベルを加える
            xYChart02_02.yAxis().setTitle("頻度", "Arial Bold Italic", 12);


            ////////////////////
            ////横軸がデータセット01、縦軸がデータセット02の散布図を作成する。
            // 大きさ420 x 297のグラフを作成する。
            XYChart xYChart01_02 = new XYChart(420, 297);

            // 位置(50, 25)から大きさ297 x 210 pxで、背景がCoral(FF7F50)のチャートを作成する。
            xYChart01_02.setPlotArea(50, 25, 297, 210, 0xFF7F50);

            // 横軸のラベルを加える
            xYChart01_02.xAxis().setTitle("データセット 01", "Arial Bold Italic", 12);

            // y軸のラベルを加える
            xYChart01_02.yAxis().setTitle("データセット 02", "Arial Bold Italic", 12);

            // 軸の幅を 3 px にする
            xYChart01_02.xAxis().setWidth(3);
            xYChart01_02.yAxis().setWidth(3);

            // 散布図のデータをキャンバスに加える
            // 三角形(Chart.TriangleSymbol)
            // データ点の大きさ 5
            // インディゴ(0x4B0082)
            xYChart01_02.addScatterLayer(dataSet01, dataSet02, "横軸01、縦軸02", Chart.TriangleSymbol, 5, 0x4B0082);


            ////////////////////
            ////横軸がデータセット02、縦軸がデータセット01の散布図を作成する。
            // 大きさ420 x 297のグラフを作成する。
            XYChart xYChart02_01 = new XYChart(420, 297);

            // 位置(50, 25)から大きさ297 x 210 pxで、背景がCoral(FF7F50)のチャートを作成する。
            xYChart02_01.setPlotArea(50, 25, 297, 210, 0xFF7F50);

            // 横軸のラベルを加える
            xYChart02_01.xAxis().setTitle("データセット 02", "Arial Bold Italic", 12);

            // y軸のラベルを加える
            xYChart02_01.yAxis().setTitle("データセット 01", "Arial Bold Italic", 12);

            // 軸の幅を 3 px にする
            xYChart02_01.xAxis().setWidth(3);
            xYChart02_01.yAxis().setWidth(3);

            // 散布図のデータをキャンバスに加える
            // 三角形(Chart.TriangleSymbol)
            // データ点の大きさ 5
            // インディゴ(0x4B0082)
            xYChart02_01.addScatterLayer(dataSet02, dataSet01, "横軸02、縦軸01", Chart.TriangleSymbol, 5, 0x4B0082);


            ////////////////////
            // 大きさ840 x 644のキャンバスを作成する。
            // 横幅 420 x 2
            // 立幅 297 x 2 + 50
            MultiChart multiChart = new MultiChart(840, 644);


            // タイトルを設定する。
            multiChart.addTitle("データセット 01 と02の要約", "Arial Bold Italic");

            // データセット01のヒストグラムを(270, 25)に配置する
            multiChart.addChart(0, 25, xYChart01_01);

            // データセット01のヒストグラムを(420, 25 + 297)に配置する
            multiChart.addChart(420, 25 + 297, xYChart02_02);

            // データセット01と02の散布図を(420, 25)に配置する
            multiChart.addChart(420, 25, xYChart01_02);

            // データセット02と01の散布図を(420, 25)に配置する
            multiChart.addChart(0, 25 + 297, xYChart02_01);



            string current = System.IO.Directory.GetCurrentDirectory();
            //Console.WriteLine("現在のディレクトリ\t" + current);
            string fileName01_01 = "Multi Scatter Plot Test 01 01 Histgram.png";
            string fileName02_02 = "Multi Scatter Plot Test 02 02 Histgram.png";
            string fileName01_02 = "Multi Scatter Plot Test 01 02 Scatter.png";
            string fileName02_01 = "Multi Scatter Plot Test 02 01 Scatter.png";
            string fileNameMulti = "Multi Scatter Plot Test.png";
            //Console.WriteLine("ファイル名\t" + fileName);
            //Console.WriteLine("フルパス\t" + Path.Combine(current, fileName));

            //グラフを画像として保存する。
            xYChart01_01.makeChart(Path.Combine(current, fileName01_01));
            xYChart02_02.makeChart(Path.Combine(current, fileName02_02));
            xYChart01_02.makeChart(Path.Combine(current, fileName01_02));
            xYChart02_01.makeChart(Path.Combine(current, fileName02_01));
            multiChart.makeChart(Path.Combine(current, fileNameMulti));


            ChartDirectorTest.NoteCredits();
        }

    }
}
