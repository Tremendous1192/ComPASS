using System;
using System.Collections.Generic;
using System.Text;
using Tremendous1192.SelfEmployed.CoMPASS.MathApp;

namespace Test.Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class MatrixTest
    {

        /// <summary>
        /// 逆行列の計算のテスト
        /// </summary>
        public void InverseDoubleTest()
        {
            Matrix<double> matrix_A = new Matrix<double>(3, 3);
            matrix_A[0, 0] = 1; matrix_A[0, 1] = 1; matrix_A[0, 2] = -1;
            matrix_A[1, 0] = -2; matrix_A[1, 1] = -1; matrix_A[1, 2] = 1;
            matrix_A[2, 0] = -1; matrix_A[2, 1] = -2; matrix_A[2, 2] = 1;
            Console.WriteLine("\n行列 A");
            Console.WriteLine("引用 - 3行3列の逆行列の求め方   - 理数アラカルト -");
            for (int i = 0; i < matrix_A.RowCount; i++)
            {
                for (int j = 0; j < matrix_A.ColumnCount; j++)
                {
                    Console.Write(matrix_A[i, j] + "\t");
                }
                Console.WriteLine("");
            }

            var matrix_AI = matrix_A.Inverse();
            Console.WriteLine("\n行列の逆行列 A^(-1)");
            for (int i = 0; i < matrix_AI.RowCount; i++)
            {
                for (int j = 0; j < matrix_AI.ColumnCount; j++)
                {
                    Console.Write(matrix_AI[i, j] + "\t");
                }
                Console.WriteLine("");
            }


            Matrix<double> matrix_B = new Matrix<double>(4, 4);
            matrix_B[0, 0] = 1; matrix_B[0, 1] = 1; matrix_B[0, 2] = 1; matrix_B[0, 3] = -1;
            matrix_B[1, 0] = 1; matrix_B[1, 1] = 1; matrix_B[1, 2] = -1; matrix_B[1, 3] = 1;
            matrix_B[2, 0] = 1; matrix_B[2, 1] = -1; matrix_B[2, 2] = 1; matrix_B[2, 3] = 1;
            matrix_B[3, 0] = -1; matrix_B[3, 1] = 1; matrix_B[3, 2] = 1; matrix_B[3, 3] = 1;
            Console.WriteLine("\n行列 B");
            Console.WriteLine("引用 - 4行4列の逆行列の求め方   - 理数アラカルト -");
            for (int i = 0; i < matrix_B.RowCount; i++)
            {
                for (int j = 0; j < matrix_B.ColumnCount; j++)
                {
                    Console.Write(matrix_B[i, j] + "\t");
                }
                Console.WriteLine("");
            }

            var matrix_BI = Matrix<double>.Inverse(matrix_B);
            Console.WriteLine("\n行列の逆行列 B^(-1)");
            for (int i = 0; i < matrix_BI.RowCount; i++)
            {
                for (int j = 0; j < matrix_BI.ColumnCount; j++)
                {
                    Console.Write(matrix_BI[i, j] + "\t");
                }
                Console.WriteLine("");
            }



            Matrix<double> matrix_C = new Matrix<double>(5, 5);
            matrix_C[0, 0] = 1; matrix_C[0, 1] = 1; matrix_C[0, 2] = 1; matrix_C[0, 3] = 1; matrix_C[0, 4] = 1;
            matrix_C[1, 0] = 1; matrix_C[1, 1] = 2; matrix_C[1, 2] = 2; matrix_C[1, 3] = 2; matrix_C[1, 4] = 2;
            matrix_C[2, 0] = 1; matrix_C[2, 1] = 2; matrix_C[2, 2] = 3; matrix_C[2, 3] = 3; matrix_C[2, 4] = 3;
            matrix_C[3, 0] = 1; matrix_C[3, 1] = 2; matrix_C[3, 2] = 3; matrix_C[3, 3] = 4; matrix_C[3, 4] = 4;
            matrix_C[4, 0] = 1; matrix_C[4, 1] = 2; matrix_C[4, 2] = 3; matrix_C[4, 3] = 4; matrix_C[4, 4] = 5;
            Console.WriteLine("\n行列 C");
            Console.WriteLine("引用 - ☆ただひたすらに逆行列～掃き出し法☆その６　大学院入試問題に挑戦（青山学院大・院）　　（大学の数学　超入門シリーズ）");
            for (int i = 0; i < matrix_C.RowCount; i++)
            {
                for (int j = 0; j < matrix_C.ColumnCount; j++)
                {
                    Console.Write(matrix_C[i, j] + "\t");
                }
                Console.WriteLine("");
            }

            var matrix_CI = Matrix<double>.Inverse(matrix_C);
            Console.WriteLine("\n行列の逆行列 C^(-1)");
            for (int i = 0; i < matrix_CI.RowCount; i++)
            {
                for (int j = 0; j < matrix_CI.ColumnCount; j++)
                {
                    Console.Write(matrix_CI[i, j] + "\t");
                }
                Console.WriteLine("");
            }



        }





    }
}
