using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.CoMPASS.MathApp;

namespace Test.Tremendous1192.SelfEmployed.CoMPASS.Books
{
    public partial class BasicOfStatisticalDataAnalysis
    {

        public void Example02_03()
        {
            BasicOfStatisticalDataAnalysis.Quote();


            Console.WriteLine("例題2.3を解きます。");
            Console.WriteLine("引用(は例題に関係するNo.1から16のみ記載)\n");
            Console.Write("表2.2のうち,No.1から16のデータについて,メジアン,第1四分位数点,第3四分位数点を求めなさい.");
            Console.Write("\n\n");

            double[,] designMatrix = new double[16, 1];
            designMatrix[0, 0] = 565; designMatrix[1, 0] = 685; designMatrix[2, 0] = 714;
            designMatrix[3, 0] = 743; designMatrix[4, 0] = 779; designMatrix[5, 0] = 823;
            designMatrix[6, 0] = 824; designMatrix[7, 0] = 945; designMatrix[8, 0] = 967;

            designMatrix[9, 0] = 996; designMatrix[10, 0] = 1056; designMatrix[11, 0] = 1089;
            designMatrix[12, 0] = 1102; designMatrix[13, 0] = 1147; designMatrix[14, 0] = 1152;
            designMatrix[15, 0] = 1255;

            for (int j = 0; j < designMatrix.GetLength(0); j++)
            {
                for (int k = 0; k < designMatrix.GetLength(1); k++)
                {
                    Console.Write(designMatrix[j, k] + "\t");
                }
                Console.WriteLine("");
            }


            Console.WriteLine("\n\n引用終わり\n");


            double[,] summary = Statistics<double>.Summary(designMatrix);

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

        }


    }
}
