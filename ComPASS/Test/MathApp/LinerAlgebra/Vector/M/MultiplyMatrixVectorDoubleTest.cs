using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.CoMPASS.MathApp;


namespace Test.Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class VectorTest
    {

        /// <summary>
        /// 行列とベクトルの積のテスト
        /// </summary>
        public void MultiplyMatrixVectorDoubleTest()
        {

            Matrix<double> matrix_A = new Matrix<double>(2, 3);
            matrix_A[0, 0] = 1.3;
            matrix_A[0, 1] = 2.3;
            matrix_A[0, 2] = 3.3;
            matrix_A[1, 0] = 3.3;
            matrix_A[1, 1] = 2.3;
            matrix_A[1, 2] = 1.3;
            Console.WriteLine("\n行列 A");
            for (int i = 0; i < matrix_A.RowCount; i++)
            {
                for (int j = 0; j < matrix_A.ColumnCount; j++)
                {
                    Console.Write(matrix_A[i, j] + "\t");
                }
                Console.WriteLine("");
            }


            double[] copediArray_b = new double[3] { 0.3, 1.3, 2.3 };
            var vector_b = new Vector<double>(copediArray_b);
            Console.WriteLine("\nベクトル b");
            for (int i = 0; i < vector_b.Dimension; i++) { Console.WriteLine(vector_b[i]); }


            Console.WriteLine("\nベクトル c = Ab");
            var vector_c = vector_b.MultiplyMatrixVector(matrix_A);
            for (int i = 0; i < vector_c.Dimension; i++) { Console.WriteLine(vector_c[i]); }


            Console.WriteLine("\nベクトル d = Ab");
            Console.WriteLine("* 演算子のオーバーロード");
            var vector_d = matrix_A * vector_b;
            for (int i = 0; i < vector_d.Dimension; i++) { Console.WriteLine(vector_d[i]); }


            Console.WriteLine("\nベクトル e = Ab");
            Console.WriteLine("staticメソッド");
            var vector_e = Vector<double>.Multiply(matrix_A, vector_b);
            for (int i = 0; i < vector_e.Dimension; i++) { Console.WriteLine(vector_e[i]); }




            double[] copediArray_f = new double[2] { 0.3, 1.3 };
            var vector_f = new Vector<double>(copediArray_f);
            Console.WriteLine("\nベクトル f");
            for (int i = 0; i < vector_f.Dimension; i++) { Console.WriteLine(vector_f[i]); }


            var g = vector_f * matrix_A * vector_b;
            Console.WriteLine("\n内積 fAb");
            Console.WriteLine(g);


        }


    }
}
