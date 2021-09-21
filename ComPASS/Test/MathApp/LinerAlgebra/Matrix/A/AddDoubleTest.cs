using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.CoMPASS.MathApp;


namespace Test.Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class MatrixTest
    {
        /// <summary>
        /// 行列の加算のテスト関数
        /// </summary>
        public void AddDoubleTest()
        {

            Console.WriteLine("行列の和のテストメソッド");
            Matrix<double> matrix_A = new Matrix<double>(2, 3);
            Matrix<double> matrix_B = new Matrix<double>(2, 3);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix_A[i, j] = i + j + 0.3;
                    matrix_B[i, j] = i + j * 2 + 0.3;
                }
            }

            Console.WriteLine("\n行列 A");
            for (int i = 0; i < matrix_A.RowCount; i++)
            {
                for (int j = 0; j < matrix_A.ColumnCount; j++)
                {
                    Console.Write(matrix_A[i, j] + "\t");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\n行列 B");
            for (int i = 0; i < matrix_B.RowCount; i++)
            {
                for (int j = 0; j < matrix_B.ColumnCount; j++)
                {
                    Console.Write(matrix_B[i, j] + "\t");
                }
                Console.WriteLine("");
            }


            var matrix_C = matrix_A.Add(matrix_B);
            Console.WriteLine("\n行列 C = A + B");
            for (int i = 0; i < matrix_C.RowCount; i++)
            {
                for (int j = 0; j < matrix_C.ColumnCount; j++)
                {
                    Console.Write(matrix_C[i, j] + "\t");
                }
                Console.WriteLine("");
            }


            var matrix_D = Matrix<double>.Add(matrix_A, matrix_C);
            Console.WriteLine("\n行列 D = A + C");
            Console.WriteLine("行列の加算のstaticメソッド");
            for (int i = 0; i < matrix_D.RowCount; i++)
            {
                for (int j = 0; j < matrix_D.ColumnCount; j++)
                {
                    Console.Write(matrix_D[i, j] + "\t");
                }
                Console.WriteLine("");
            }

            var matrix_E = matrix_B + matrix_D;
            Console.WriteLine("\n行列 E = B + D");
            Console.WriteLine("行列の加算の + 演算子のオーバーロード");
            for (int i = 0; i < matrix_E.RowCount; i++)
            {
                for (int j = 0; j < matrix_E.ColumnCount; j++)
                {
                    Console.Write(matrix_E[i, j] + "\t");
                }
                Console.WriteLine("");
            }


            var matrix_F = matrix_A + matrix_B + matrix_C;
            Console.WriteLine("\n行列 F = A + B + C");
            Console.WriteLine("行列の加算の + 演算子のオーバーロード");
            Console.WriteLine("3項の計算のテスト");
            for (int i = 0; i < matrix_F.RowCount; i++)
            {
                for (int j = 0; j < matrix_F.ColumnCount; j++)
                {
                    Console.Write(matrix_F[i, j] + "\t");
                }
                Console.WriteLine("");
            }


        }


    }
}
