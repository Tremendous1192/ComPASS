using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.CoMPASS.MathApp;

namespace Test.Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class VectorTest
    {
        /// <summary>
        /// ベクトルの内積のテスト.
        /// </summary>
        public void MultiplyInnerProductDoubleTest()
        {

            Console.WriteLine("ベクトルの和のテストメソッド");
            double[] copediArray01 = new double[4] { 0.3, 1.3, 2.3, 3.3 };
            double[] copediArray02 = new double[4] { 1.3, 2.3, 3.3, 4.3 };

            var vector_a = new Vector<double>(copediArray01);
            var vector_b = new Vector<double>(copediArray02);

            Console.WriteLine("\nベクトル a");
            for (int i = 0; i < vector_a.Dimension; i++) { Console.WriteLine(vector_a[i]); }

            Console.WriteLine("\nベクトル b");
            for (int i = 0; i < vector_b.Dimension; i++) { Console.WriteLine(vector_b[i]); }

            Console.WriteLine("\nベクトルの内積 ab");
            Console.WriteLine(vector_a.MultiplyInnerProduct(vector_b));


            Console.WriteLine("\n");
            Console.WriteLine("staticメソッド");
            Console.WriteLine(Vector<double>.Multiply(vector_a, vector_b));


            Console.WriteLine("\n");
            Console.WriteLine("* 演算子のオーバーロードをベクトルの内積とする");
            Console.WriteLine(vector_a * vector_b);


        }

    }
}
