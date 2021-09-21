using System;
using System.Collections.Generic;
using System.Text;
using Tremendous1192.SelfEmployed.CoMPASS.MathApp;

namespace Test.Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class LinearRegressionTest
    {
        /// <summary>
        /// 線形回帰のテスト
        /// </summary>
        public void Test() {

            Console.WriteLine("線形回帰のテスト関数");

            Console.WriteLine("例題①");
            Console.WriteLine("引用 - 回帰分析：統計の基礎知識6 | ものづくり&まちづくり BtoB情報サイト「Tech Note」");

            double[] weight = new double[12];
            weight[0] = 21.8;
            weight[1] = 24.4;
            weight[2] = 27.7;
            weight[3] = 31.2;
            weight[4] = 35.1;

            weight[5] = 39.4;
            weight[6] = 45.4;
            weight[7] = 50.4;
            weight[8] = 55.4;
            weight[9] = 59.7;

            weight[10] = 61.2;
            weight[11] = 62.6;

            Matrix<double> designMatrixWithoutConctant = new Matrix<double>(weight.Length, 1, weight);

            double[] height = new double[12];
            height[0] = 116.7;
            height[1] = 122.5;
            height[2] = 128.1;
            height[3] = 133.6;
            height[4] = 139.1;

            height[5] = 145.3;
            height[6] = 152.9;
            height[7] = 160.0;
            height[8] = 165.5;
            height[9] = 168.6;

            height[10] = 170.1;
            height[11] = 170.8;

            Vector<double> outputYSet = new Vector<double>(height);


            Vector<double> CoefficientW = LinearRegression<double>.Learn(designMatrixWithoutConctant, outputYSet);
            Console.WriteLine("\n" + "y = " + CoefficientW[0].ToString("G3") + " + " + CoefficientW[1].ToString("G3") + "x");
            Console.WriteLine("\n説明変数x" + "\t" + "目的変数y" + "\t" + "予測値Y");
            Console.WriteLine("体重 x    " + "\t" + "身長 y   " + "\t" + "予測値Y");
            for (int i = 0; i < outputYSet.Dimension; i++){
                Vector<double> xWithoutConctant = designMatrixWithoutConctant.PickUpRowVector(i);

                Vector<double> result = LinearRegression<double>.Regression(xWithoutConctant, CoefficientW);

                Console.WriteLine(designMatrixWithoutConctant[i, 0] + "\t\t" + outputYSet[i] + "\t\t" + result[0].ToString("G4"));
            }



            Console.WriteLine("\n\n例題②");
            Console.WriteLine("引用 - 重回帰分析（１/３） :: 株式会社アイスタット｜統計分析研究所");
            double[,] x = new double[6, 2]{
                {5, 6},
                {5, 8},
                {7, 10},
                {4, 13},
                {8, 11},
                {12, 13}
            };
            designMatrixWithoutConctant = new Matrix<double>(x);

            double[] Earnings = new double[6]{
                8,
                9,
                13,
                11,
                14,
                17,
            };
            outputYSet = new Vector<double>(Earnings);

            CoefficientW = LinearRegression<double>.Learn(designMatrixWithoutConctant, outputYSet);
            Console.WriteLine("\n" + "y = " + CoefficientW[0].ToString("G3") + " + " + CoefficientW[1].ToString("G3") + "x1" + " + " + CoefficientW[2].ToString("G3") + "x2");
            Console.WriteLine("\n説明変数x1" + "\t"  + "説明変数x2" + "\t" + "目的変数y" + "\t" + "予測値Y");
            Console.WriteLine("広告費(百万円)" + "\t" + "販売人員数" + "\t" + "売上(百万円)" + "\t" + "予測値Y");
            for (int i = 0; i < outputYSet.Dimension; i++)
            {
                Vector<double> xWithoutConctant = Matrix<double>.PickUpRowVector(designMatrixWithoutConctant, i);

                Vector<double> result = LinearRegression<double>.Regression(xWithoutConctant, CoefficientW);

                Console.WriteLine(designMatrixWithoutConctant[i, 0] + "\t\t" + designMatrixWithoutConctant[i, 1] + "\t\t" + outputYSet[i] + "\t\t" + result[0].ToString("G3"));
            }

        }



    }
}
