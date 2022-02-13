using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.CoMPASS.MathApp;

namespace Test.Tremendous1192.SelfEmployed.CoMPASS.Books
{
    public partial class BasicOfStatisticalDataAnalysis
    {

        public void Example02_02()
        {
            BasicOfStatisticalDataAnalysis.Quote();


            Console.WriteLine("例題2.2を解きます。");
            Console.WriteLine("引用(数式は改変)\n");
            Console.Write("次のデータ(a)について,平均x_average,メジアンx_median,偏差平方和S,分散s^2,標準偏差sを計算しなさい。");
            Console.Write("次にデータ(b)から(d)のそれぞれについて,x_average,x_median,S,s^2,sを求めなさい。");
            Console.Write("その際、(b)のデータは(a)のデータに100を加えている。");
            Console.Write("(c)のデータは平均からの偏差が倍であるなどの特徴に着目して計算しなさい。\n\n");

            double[,] designMatrix = new double[9, 4];
            designMatrix[0, 0] = 53; designMatrix[1, 0] = 55; designMatrix[2, 0] = 52;
            designMatrix[3, 0] = 57; designMatrix[4, 0] = 51; designMatrix[5, 0] = 56;
            designMatrix[6, 0] = 58; designMatrix[7, 0] = 59; designMatrix[8, 0] = 54;

            designMatrix[0, 1] = 153; designMatrix[1, 1] = 155; designMatrix[2, 1] = 152;
            designMatrix[3, 1] = 157; designMatrix[4, 1] = 151; designMatrix[5, 1] = 156;
            designMatrix[6, 1] = 158; designMatrix[7, 1] = 159; designMatrix[8, 1] = 154;

            designMatrix[0, 2] = 51; designMatrix[1, 2] = 55; designMatrix[2, 2] = 49;
            designMatrix[3, 2] = 59; designMatrix[4, 2] = 47; designMatrix[5, 2] = 57;
            designMatrix[6, 2] = 61; designMatrix[7, 2] = 63; designMatrix[8, 2] = 53;

            designMatrix[0, 3] = 53; designMatrix[1, 3] = 55; designMatrix[2, 3] = 52;
            designMatrix[3, 3] = 57; designMatrix[4, 3] = 51; designMatrix[5, 3] = 56;
            designMatrix[6, 3] = 58; designMatrix[7, 3] = 149; designMatrix[8, 3] = 54;


            Console.WriteLine("(a)\t(b)\t(c)\t(d)");
            for (int j = 0; j < designMatrix.GetLength(0); j++)
            {
                for (int k = 0; k < designMatrix.GetLength(1); k++)
                {
                    Console.Write(designMatrix[j, k] + "\t");
                }
                Console.WriteLine("");
            }


            Console.WriteLine("\n\n引用終わり(数式は改変)\n");


            double[,] summary = Statistics<double>.Summary(designMatrix);
            Console.Write("[0,*] 最小値\t\t");
            for (int k = 0; k < summary.GetLength(1); k++)
            {
                Console.Write(summary[0, k] + "\t");
            }
            Console.WriteLine("");

            Console.Write("[1,*] 第一四分位数\t");
            for (int k = 0; k < summary.GetLength(1); k++)
            {
                Console.Write(summary[1, k] + "\t");
            }
            Console.WriteLine("");

            Console.Write("[2,*] 中央値\t\t");
            for (int k = 0; k < summary.GetLength(1); k++)
            {
                Console.Write(summary[2, k] + "\t");
            }
            Console.WriteLine("");

            Console.Write("[3,*] 第三四分位数\t");
            for (int k = 0; k < summary.GetLength(1); k++)
            {
                Console.Write(summary[3, k] + "\t");
            }
            Console.WriteLine("");

            Console.Write("[4,*] 最大値\t\t");
            for (int k = 0; k < summary.GetLength(1); k++)
            {
                Console.Write(summary[4, k] + "\t");
            }
            Console.WriteLine("");

            Console.Write("[5,*] 平均値\t\t");
            for (int k = 0; k < summary.GetLength(1); k++)
            {
                Console.Write(summary[5, k] + "\t");
            }
            Console.WriteLine("");

            Console.Write("[6,*] 偏差平方和\t");
            for (int k = 0; k < summary.GetLength(1); k++)
            {
                Console.Write(summary[6, k] + "\t");
            }
            Console.WriteLine("");

            Console.Write("[7,*] 標本分散\t\t");
            for (int k = 0; k < summary.GetLength(1); k++)
            {
                Console.Write(summary[7, k] + "\t");
            }
            Console.WriteLine("");

            Console.Write("[8,*] 標本標準偏差\t");
            for (int k = 0; k < summary.GetLength(1); k++)
            {
                Console.Write(summary[8, k].ToString("G3") + "\t");
            }
            Console.WriteLine("");
        }


    }
}
