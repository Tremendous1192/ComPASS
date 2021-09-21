using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.CoMPASS.MathApp;

namespace Test.Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class MatrixTest
    {
        /// <summary>
        /// コンストラクターのテストメソッド。
        /// Matrix＜double＞を生成して、各要素を確認する。
        /// </summary>
        public void ConstructorDoubleTest() 
        {
            //コンストラクターのテスト 1
            int row = 3;
            int column = 5;
            Console.WriteLine(row + "行" + column + "列の零行列を生成します");
            Matrix<double> matrix_1 = new Matrix<double>(3, 5);

            for (int i = 0; i < matrix_1.RowCount; i++)
            {
                for (int j = 0; j < matrix_1.ColumnCount; j++)
                {
                    Console.Write(matrix_1[i, j] + "\t");
                }
                Console.WriteLine("");
            }


            //改行
            Console.WriteLine("\n \n");


            //コンストラクターのテスト 2
            double[,] copiedArray_1 = new double[4, 5];
            Console.WriteLine(copiedArray_1 .GetLength(0)+ "行" + copiedArray_1.GetLength(1)+ "列の2重配列を引数にして、行列を生成します");
            for (int i = 0; i < copiedArray_1.GetLength(0); i++)
            {
                for (int j = 0; j < copiedArray_1.GetLength(1); j++)
                {
                    copiedArray_1[i, j] = 2 * (i + j) * Math.Pow(-1.0, 1.0 * (i + j));
                }
            }
            Matrix<double> matrix_2 = new Matrix<double>(copiedArray_1);
            for (int i = 0; i < matrix_2.RowCount; i++)
            {
                for (int j = 0; j < matrix_2.ColumnCount; j++)
                {
                    Console.Write(matrix_2[i, j] + "\t");
                }
                Console.WriteLine("");
            }


            //改行
            Console.WriteLine("\n \n");


            //コンストラクターのテスト 3
            //ジャグ配列は、長方形になるように要素数を増やす
            double[][] copiedArray_2 = new double[5][];
            column = 0;
            for (int i = 0; i < copiedArray_2.Length; i++)
            {
                copiedArray_2[i] = new double[2 + i];
                column = Math.Max(column, copiedArray_2[i].Length);
                for (int j = 0; j < copiedArray_2[i].Length; j++)
                {
                    copiedArray_2[i][j] = (i + j) * Math.Pow(-1.0, 1.0 * (i + j));
                }
            }
            Console.WriteLine("ジャグ配列を引数にして、行列を生成します");
            Console.WriteLine("この行列の行数は、配列の要素数"+copiedArray_2.Length + "行で、列数は各配列の要素数の最大値" + column+ "列です");
            Matrix<double> matrix_3 = new Matrix<double>(copiedArray_2);
            for (int i = 0; i < matrix_3.RowCount; i++)
            {
                for (int j = 0; j < matrix_3.ColumnCount; j++)
                {
                    Console.Write(matrix_3[i, j] + "\t");
                }
                Console.WriteLine("");
            }


        }

    }
}
