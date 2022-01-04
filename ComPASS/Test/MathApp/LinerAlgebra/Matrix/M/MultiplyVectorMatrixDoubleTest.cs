using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.CoMPASS.MathApp;

namespace Test.Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class MatrixTest
    {

        /// <summary>
        /// ベクトルと行列の積のテスト
        /// </summary>
        public void MultiplyVectorMatrixDoubleTest()
        {

            double[] copediArray_a = new double[2] { 0.3, 1.3 };
            var vector_a = new RowVector<double>(copediArray_a);
            Console.WriteLine("\nベクトル a");
            for (int i = 0; i < vector_a.Dimension; i++) { Console.WriteLine(vector_a[i]); }



            Matrix<double> matrix_B = new Matrix<double>(2, 3);
            matrix_B[0, 0] = 1.3;
            matrix_B[0, 1] = 2.3;
            matrix_B[0, 2] = 3.3;
            matrix_B[1, 0] = 3.3;
            matrix_B[1, 1] = 2.3;
            matrix_B[1, 2] = 1.3;
            Console.WriteLine("\n行列 A");
            for (int i = 0; i < matrix_B.RowCount; i++)
            {
                for (int j = 0; j < matrix_B.ColumnCount; j++)
                {
                    Console.Write(matrix_B[i, j] + "\t");
                }
                Console.WriteLine("");
            }


            Console.WriteLine("\nベクトル c = Ab");
            var vector_c = matrix_B.MultiplyVectorMatrix(vector_a);
            for (int i = 0; i < vector_c.Dimension; i++) { Console.WriteLine(vector_c[i]); }


            Console.WriteLine("\nベクトル d = Ab");
            Console.WriteLine("* 演算子のオーバーロード");
            var vector_d = vector_a * matrix_B;
            for (int i = 0; i < vector_d.Dimension; i++) { Console.WriteLine(vector_d[i]); }


            Console.WriteLine("\nベクトル e = Ab");
            Console.WriteLine("staticメソッド");
            var vector_e = Matrix<double>.Multiply(vector_a, matrix_B);
            for (int i = 0; i < vector_e.Dimension; i++) { Console.WriteLine(vector_e[i]); }

        }



    }
}
