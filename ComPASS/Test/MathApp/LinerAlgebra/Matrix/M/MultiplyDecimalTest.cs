using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.CoMPASS.MathApp;

namespace Test.Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class MatrixTest
    {

        /// <summary>
        /// 行列の乗算のテスト関数
        /// </summary>
        public void MultiplyDecimalTest()
        {

            Console.WriteLine("行列の積のテストメソッド");

            Matrix<decimal> matrix_A = new Matrix<decimal>(2, 2);
            matrix_A[0, 0] = 1m;
            matrix_A[0, 1] = 2m;
            matrix_A[1, 0] = 2m;
            matrix_A[1, 1] = 1m;
            Console.WriteLine("\n行列 A");
            for (int i = 0; i < matrix_A.RowCount; i++)
            {
                for (int j = 0; j < matrix_A.ColumnCount; j++)
                {
                    Console.Write(matrix_A[i, j] + "\t");
                }
                Console.WriteLine("");
            }


            Matrix<decimal> matrix_B = new Matrix<decimal>(2, 3);
            matrix_B[0, 0] = 1m;
            matrix_B[0, 1] = 2m;
            matrix_B[0, 2] = 3m;
            matrix_B[1, 0] = 3m;
            matrix_B[1, 1] = 2m;
            matrix_B[1, 2] = 1m;
            Console.WriteLine("\n行列 B");
            for (int i = 0; i < matrix_B.RowCount; i++)
            {
                for (int j = 0; j < matrix_B.ColumnCount; j++)
                {
                    Console.Write(matrix_B[i, j] + "\t");
                }
                Console.WriteLine("");
            }


            Console.WriteLine("\n行列 C = AB");
            var matrix_C = matrix_A.Multiply(matrix_B);
            for (int i = 0; i < matrix_C.RowCount; i++)
            {
                for (int j = 0; j < matrix_C.ColumnCount; j++)
                {
                    Console.Write(matrix_C[i, j] + "\t");
                }
                Console.WriteLine("");
            }


            Console.WriteLine("\n行列 D = AB");
            Console.WriteLine("行列の乗算のstaticメソッド");
            Console.WriteLine("検算が大変なので、行列Eは行列Cと同じ計算とする。");
            var matrix_D = Matrix<decimal>.Multiply(matrix_A, matrix_B);
            for (int i = 0; i < matrix_D.RowCount; i++)
            {
                for (int j = 0; j < matrix_D.ColumnCount; j++)
                {
                    Console.Write(matrix_D[i, j] + "\t");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\n行列 E = A * B");
            Console.WriteLine("行列の乗算の * 演算子のオーバーロード");
            Console.WriteLine("検算が大変なので、行列Eは行列Cと同じ計算とする。");
            var matrix_E = matrix_A * matrix_B;
            for (int i = 0; i < matrix_E.RowCount; i++)
            {
                for (int j = 0; j < matrix_E.ColumnCount; j++)
                {
                    Console.Write(matrix_E[i, j] + "\t");
                }
                Console.WriteLine("");
            }


            Matrix<decimal> matrix_F = new Matrix<decimal>(3, 2);
            matrix_F[0, 0] = 1m;
            matrix_F[0, 1] = 2m;
            matrix_F[1, 0] = 2m;
            matrix_F[1, 1] = 1m;
            matrix_F[2, 0] = 1m;
            matrix_F[2, 1] = 2m;
            Console.WriteLine("\n行列 F。3項の行列の積のために用意した。");
            for (int i = 0; i < matrix_F.RowCount; i++)
            {
                for (int j = 0; j < matrix_F.ColumnCount; j++)
                {
                    Console.Write(matrix_F[i, j] + "\t");
                }
                Console.WriteLine("");
            }


            var matrix_G = matrix_A * matrix_B * matrix_F;
            Console.WriteLine("\n行列 G = A * B * F = E * F");
            Console.WriteLine("行列の乗算の * 演算子のオーバーロード");
            Console.WriteLine("3項の計算のテスト");
            for (int i = 0; i < matrix_G.RowCount; i++)
            {
                for (int j = 0; j < matrix_G.ColumnCount; j++)
                {
                    Console.Write(matrix_G[i, j] + "\t");
                }
                Console.WriteLine("");
            }


        }


    }
}
