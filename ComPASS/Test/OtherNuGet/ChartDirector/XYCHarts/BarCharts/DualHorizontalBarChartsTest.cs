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
        /// 2つの横向き棒グラフを並べて人口ピラミッドのグラフを作成して、png画像として保存するテスト関数
        /// </summary>
        public void DualHorizontalBarChartsTest()
        {
            Console.WriteLine("統計ダッシュボード - 人口ピラミッド  の2020年の人口ピラミッドグラフを作成します。");
            Console.WriteLine("https://dashboard.e-stat.go.jp/pyramidGraph?screenCode=00570&regionCode=00000&pyramidAreaType=2");

            // 年齢のラベル
            string[] labels = {"0 - 4", "5 - 9", "10 - 14", "15 - 19", "20 - 24",
                "24 - 29", "30 - 34", "35 - 39", "40 - 44", "44 - 49",
                "50 - 54", "55 - 59", "60 - 64", "65 - 69", "70 - 74",
                "75 - 79", "80+"};

            // 男性の人口分布
            double[] male = {2311189, 2606651, 2742131, 2880029, 3017869,
                3074087, 3297031, 3696855, 4189446, 4862990,
                4277003, 3865303, 3592903, 3910060, 4249286,
                3092860, 4092745};

            // 女性の人口分布
            double[] female = {2204893, 2482442, 2608386, 2737411, 2913437,
                2957877, 3187563, 3614712, 4101631, 4787303,
                4262848, 3902179, 3704287, 4165208, 4762509,
                3838068, 7225069};


            //=============================================================
            //    右側(女性)のグラフを作成する。
            //=============================================================

            // 大きさ320 x 300のグラフを作成する。
            XYChart xYChartRight = new XYChart(320, 300);

            // 位置(50, 0)から大きさ250 x 255 pxで、背景がピンク色(0xffdddd)のチャートを作成する。
            xYChartRight.setPlotArea(50, 0, 250, 255, 0xffdddd);

            // 右上に凡例のテキストを追加する
            xYChartRight.addText(300, 0, "女性", "Times New Roman Bold Italic", 12, 0xa07070).setAlignment(Chart.TopRight);

            // ピンク色(0xf0c0c0)の棒グラフのレイヤー
            BarLayer femaleLayer = xYChartRight.addBarLayer(female, 0xf0c0c0, "女性");

            // x軸とy軸を入れ替えて、横向きの棒グラフに変更する。
            xYChartRight.swapXY(true);

            // 棒グラフの間隔を詰める
            femaleLayer.setBarGap(Chart.TouchBar);

            // 3Dの装飾を加える
            femaleLayer.setBorderColor(-1, 1);

            // 軸を揃えるために、男性の人口分布のデータをグラフに加える。
            //(男性のデータは透明にする)
            xYChartRight.addLineLayer(male, Chart.Transparent);

            // y軸のラベルのフォントをArial Boldにする
            xYChartRight.yAxis().setLabelStyle("Arial Bold");

            // x軸のラベルを設定する
            ChartDirector.TextBox tb = xYChartRight.xAxis().setLabels(labels);

            // ラベルの横幅を 50に設定する。高さは自動。ラベルは中央揃えにする。
            tb.setSize(50, 0);
            tb.setAlignment(Chart.Center);

            // ラベルのフォントをArial Boldにする
            tb.setFontStyle("Arial Bold");

            // x軸のメモリの幅を0にする。(見えなくする)
            xYChartRight.xAxis().setTickLength(0);

            //=============================================================
            //    左側(男性)のグラフを作成する
            //=============================================================

            // 大きさ320 x 300のグラフを作成する。
            XYChart xYChartLeft = new XYChart(280, 300, Chart.Transparent);

            // 位置(20, 0)から大きさ250 x 255 pxで、背景が青色(0xffdddd)のチャートを作成する。
            xYChartLeft.setPlotArea(20, 0, 250, 255, 0xddddff);

            // 左上に凡例のテキストを追加する
            xYChartLeft.addText(20, 0, "男性", "Times New Roman Bold Italic", 12, 0x7070a0);

            // 青色(0xaaaaff)の棒グラフのレイヤー
            BarLayer maleLayer = xYChartLeft.addBarLayer(male, 0xaaaaff, "男性");

            // x軸とy軸を入れ替えて、横向きの棒グラフに変更する。
            xYChartLeft.swapXY(true);

            // y軸の向きを逆にする(棒グラフが左に伸びるほど、y軸の値が大きい)
            xYChartLeft.yAxis().setReverse();

            // 棒グラフの間隔を詰める
            maleLayer.setBarGap(Chart.TouchBar);

            // 3Dの装飾を加える
            maleLayer.setBorderColor(-1, 1);

            // 軸を揃えるために、女性の人口分布のデータをグラフに加える。
            //(女性のデータは透明にする)
            xYChartLeft.addLineLayer(female, Chart.Transparent);

            // y軸のラベルのフォントをArial Boldにする
            xYChartLeft.yAxis().setLabelStyle("Arial Bold");

            // x軸のラベルを設定する
            // 最初に作成した女性用ではTextBoxの戻り値を利用していたが、こちらは戻り値を使用しない。
            // ラベルを用意することで、横軸の間隔が揃う
            xYChartLeft.xAxis().setLabels(labels);

            // x軸のラベルを見えなくする。
            xYChartLeft.xAxis().setColors(0x000000, Chart.Transparent, -1, Chart.Transparent);

            //=============================================================
            //    複数のグラフを張り付ける画像を作成する。
            //=============================================================

            // 大きさ590 x 360のキャンバスを作成する。
            MultiChart multiChart = new MultiChart(590, 320);

            // タイトルを設定する。
            multiChart.addTitle("人口ピラミッド(日本、2020年)", "Arial Bold Italic");

            // 右側のグラフを(270, 25)に配置する
            multiChart.addChart(270, 25, xYChartRight);

            // 左側のグラフ(0, 25)に配置する
            multiChart.addChart(0, 25, xYChartLeft);

            //Console.WriteLine("頂点\t" + Chart.Top);
            //Console.WriteLine("中央\t" + Chart.Center);
            //Console.WriteLine("下部\t" + Chart.Bottom);
            // 下部にタイトルを載せる
            //multiChart.addTitle2(2, "Population (in thousands)", "Arial Bold Italic", 10);


            string current = System.IO.Directory.GetCurrentDirectory();
            //Console.WriteLine("現在のディレクトリ\t" + current);
            string fileName = "DualHorizontalBarChartsTest.png";
            //Console.WriteLine("ファイル名\t" + fileName);
            //Console.WriteLine("フルパス\t" + Path.Combine(current, fileName));

            //グラフを画像として保存する。
            multiChart.makeChart(Path.Combine(current, fileName));


            ChartDirectorTest.NoteCredits();


        }

    }
}
