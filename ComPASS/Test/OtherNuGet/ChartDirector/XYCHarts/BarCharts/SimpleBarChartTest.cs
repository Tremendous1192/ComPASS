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
        public void SimpleBarChartTest()
        {
            Console.WriteLine("グラフ描画用のクラスを定義します。画像サイズは、(640px, 480px)です");
            XYChart xYChart = new XYChart(640, 480);


            // 棒グラフの値
            double[] data = { 1, 5, 3, 4, 2 };

            // ラベル
            string[] labels = { "月", "火", "水", "木", "金" };


            Console.WriteLine("ラフを描画する領域を定義する (30px, 20px)から(580px, 400px)の領域に描画する");
            xYChart.setPlotArea(60, 20, 560, 400);

 
            Console.WriteLine("グラフタイトルを追加します");
            xYChart.addTitle("棒グラフのテスト");

            Console.WriteLine("Y軸の軸名を加えます。");
            xYChart.yAxis().setTitle("Y axis", "normal", 16, Chart.CColor(System.Drawing.Color.Black));


            Console.WriteLine("グラフにデータを加えます");
            xYChart.addBarLayer(data);
            

            Console.WriteLine("グラフにラベルを加えます");
            xYChart.xAxis().setLabels(labels);


            string current = System.IO.Directory.GetCurrentDirectory();
            //Console.WriteLine("現在のディレクトリ\t"+current);
            string fileName = "SimpleBarChartTest.png";
            //Console.WriteLine("ファイル名\t" + fileName);
            //Console.WriteLine("フルパス\t" + Path.Combine(current, fileName));


            Console.WriteLine("グラフを保存します");
            xYChart.makeChart(Path.Combine(current, fileName));



            ChartDirectorTest.NoteCredits();

        }

    }
}
