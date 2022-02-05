using System;
using System.Collections.Generic;
using System.Text;
//グラフを描画する
using ChartDirector;
//入出力
using System.IO;

namespace Test.Tremendous1192.SelfEmployed.CoMPASS.OtherNuGet
{
    public partial class ChartDirectorTest
    {
        /// <summary>
        /// 簡単な散布図を作成して、png画像として保存するテスト関数
        /// </summary>
        public void ScatterChartTest()
        {
            Console.WriteLine("層別散布図の作成 with Excel" + "\t" + "の層別散布図を作成する。");
            Console.WriteLine("https://hitorimarketing.net/tools/grouped-scatterplot.html");

            // The XY points for the scatter chart
            // RS 1
            double[] dataX0 = { 14, 17, 20, 22, 30,
                                13, 23, 26 };
            double[] dataY0 = { 48, 41, 52, 47, 33,
                                53, 39, 27 };

            //RS 2
            double[] dataX1 = { 14, 4, 12, 17, 4,
                                10, 21, 29 };
            double[] dataY1 = { 52, 40, 51, 60, 45,
                                52, 62, 62 };

            //RS 3
            double[] dataX2 = { 1, 12, 8, 10, 9,
                                26, 5, 7 };
            double[] dataY2 = { 51, 32, 42, 42, 49,
                                50, 52, 58};

            //軸の範囲
            double[] rangeX = { 0, 40 };
            double[] rangeY = { 0, 100 };


            // 大きさ450, 420pxのキャンバスを作成する。
            XYChart xYChart = new XYChart(450, 420);

            // 位置(55, 65)から大きさ350 x 300 pxで、背景が明るい灰色(0xc0c0c0)のチャートを作成する。
            // 横軸と縦軸も明るい灰色(0xc0c0c0)にする。
            xYChart.setPlotArea(55, 65, 350, 300, -1, -1, 0xc0c0c0, 0xc0c0c0, -1);

            // 凡例を位置(50, 30)に配置する
            // 凡例を横に並べる
            // Times Bold Italic、
            // フォントサイズ12pt
            // 凡例の背景色は透明にする。
            xYChart.addLegend(50, 30, false, "Times New Roman Bold Italic", 12).setBackground(
                Chart.Transparent);

            // タイトルを加える
            xYChart.addTitle("有給取得日数と、意欲点の関係", "Times New Roman Bold Italic", 18);

            // y軸のラベルを加える
            xYChart.yAxis().setTitle("意欲点", "Arial Bold Italic", 12);

            // 横軸のラベルを加える
            xYChart.xAxis().setTitle("有給取得日数", "Arial Bold Italic", 12);

            // 軸の幅を 3 px にする
            xYChart.xAxis().setWidth(3);
            xYChart.yAxis().setWidth(3);

            // RS 1のデータを加える
            // ひし形(Chart.DiamondSymbol)
            // データ点の大きさ 13
            // オレンジ色(0xff9933)
            xYChart.addScatterLayer(dataX0, dataY0, "RS 1", Chart.DiamondSymbol, 13, 0xff9933);

            // RS 2のデータを加える
            // 三角形(Chart.TriangleSymbol)
            // データ点の大きさ 11
            // 緑色(0x33ff33)
            xYChart.addScatterLayer(dataX1, dataY1, "RS 2", Chart.TriangleSymbol, 11, 0x33ff33);

            // RS 3のデータを加える
            // 円(Chart.CircleShape)
            // データ点の大きさ 11
            // マゼンタ(0xFF00FF)
            xYChart.addScatterLayer(dataX2, dataY2, "RS 3", Chart.CircleShape, 11, 0xFF00FF);

            //軸の上端下端
            xYChart.addScatterLayer(rangeX, rangeY, "", Chart.CircleShape, 0, 0xc0c0c0);




            string current = System.IO.Directory.GetCurrentDirectory();
            //Console.WriteLine("現在のディレクトリ\t"+current);
            string fileName = "ScatterChartTest.png";
            //Console.WriteLine("ファイル名\t" + fileName);
            //Console.WriteLine("フルパス\t" + Path.Combine(current, fileName));


            Console.WriteLine("グラフを保存します");
            xYChart.makeChart(Path.Combine(current, fileName));



            ChartDirectorTest.NoteCredits();


        }


    }
}
