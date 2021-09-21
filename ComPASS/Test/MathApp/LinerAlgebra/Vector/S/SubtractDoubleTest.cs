using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.CoMPASS.MathApp;

namespace Test.Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class VectorTest
    {
        /// <summary>
        /// ベクトルの加算のテスト.
        /// </summary>
        public void SubtractDoubleTest()
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

            var vector_c = vector_a.Add(vector_b);
            Console.WriteLine("\nベクトル c = a + b");
            for (int i = 0; i < vector_c.Dimension; i++) { Console.WriteLine(vector_c[i]); }


            var vector_d = Vector<double>.Subtract(vector_a, vector_b);
            Console.WriteLine("\nベクトル d = a - b");
            Console.WriteLine("staticメソッド");
            for (int i = 0; i < vector_d.Dimension; i++) { Console.WriteLine(vector_d[i]); }



            var vector_e = vector_a - vector_b;
            Console.WriteLine("\nベクトル e = a - b");
            Console.WriteLine("- 演算子のオーバーロード");
            for (int i = 0; i < vector_e.Dimension; i++) { Console.WriteLine(vector_e[i]); }


            var vector_f = vector_a - vector_b - vector_c;
            Console.WriteLine("\nベクトル f = a - b - c");
            Console.WriteLine("- 演算子のオーバーロード");
            Console.WriteLine("3項の計算のテスト");
            for (int i = 0; i < vector_f.Dimension; i++) { Console.WriteLine(vector_f[i]); }


        }

    }
}
