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
        public void MultiplyInnerProductDecimalTest()
        {

            Console.WriteLine("ベクトルの和のテストメソッド");
            decimal[] copediArray01 = new decimal[4] { 0.3m, 1.3m, 2.3m, 3.3m };
            decimal[] copediArray02 = new decimal[4] { 1.3m, 2.3m, 3.3m, 4.3m };

            var vector_a = new ColumnVector<decimal>(copediArray01);
            var vector_b = new ColumnVector<decimal>(copediArray02);

            Console.WriteLine("\nベクトル a");
            for (int i = 0; i < vector_a.Dimension; i++) { Console.WriteLine(vector_a[i]); }

            Console.WriteLine("\nベクトル b");
            for (int i = 0; i < vector_b.Dimension; i++) { Console.WriteLine(vector_b[i]); }

            Console.WriteLine("\nベクトルの内積 ab");
            Console.WriteLine(vector_a.MultiplyInnerProduct(vector_b));


            Console.WriteLine("\n");
            Console.WriteLine("staticメソッド");
            Console.WriteLine(ColumnVector<decimal>.Multiply(vector_a, vector_b));


            Console.WriteLine("\n");
            Console.WriteLine("* 演算子のオーバーロードをベクトルの内積とする");
            Console.WriteLine(vector_a * vector_b);


        }

    }
}
