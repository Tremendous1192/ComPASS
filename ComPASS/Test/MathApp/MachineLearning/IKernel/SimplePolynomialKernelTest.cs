using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.CoMPASS.MathApp;

namespace Test.Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class IKernelTest
    {
        public void SimplePolynomialKernelTest()
        {
            Console.WriteLine("カーネル関数のテスト関数");

            Console.WriteLine("\n" + "Simple Polynomial Kernel ( 1 + x・y )^2");
            Console.WriteLine("ベクトルの内積が-1のとき最小値0をとるカーネル関数");
            Console.WriteLine("また、2つのベクトルが直行しているときは、カーネル関数の値は1になる。");
            SimplePolynomialKernel<double> spk = new SimplePolynomialKernel<double>();

            Console.WriteLine("\n" + "下記のベクトルで計算する。");
            RowVector<double> vector01 = new RowVector<double>(2);
            vector01[0] = 1; vector01[1] = 0;
            Console.WriteLine("vector 01" + "\n" + vector01[0] + "\t" + vector01[1]);

            RowVector<double> vector02 = new RowVector<double>(2);
            vector02[0] = 1; vector02[1] = 0;
            Console.WriteLine("\n" + "vector 02" + "\n" + vector02[0] + "\t" + vector02[1]);

            RowVector<double> vector03 = new RowVector<double>(2);
            vector03[0] = 0; vector03[1] = 1;
            Console.WriteLine("\n" + "vector 03" + "\n" + vector03[0] + "\t" + vector03[1]);

            RowVector<double> vector04 = new RowVector<double>(2);
            vector04[0] = 0; vector04[1] = 5;
            Console.WriteLine("\n" + "vector 04" + "\n" + vector04[0] + "\t" + vector04[1]);

            RowVector<double> vector05 = new RowVector<double>(2);
            vector05[0] = -1; vector05[1] = 0;
            Console.WriteLine("\n" + "vector 05" + "\n" + vector05[0] + "\t" + vector05[1]);

            RowVector<double> vector06 = new RowVector<double>(2);
            vector06[0] = -5; vector06[1] = 0;
            Console.WriteLine("\n" + "vector 06" + "\n" + vector06[0] + "\t" + vector06[1]);


            Console.WriteLine("\n" + "カーネル関数の計算結果。");
            Console.WriteLine("k( vector01, vector02 )");
            Console.WriteLine(spk.Calculate(vector01, vector02));

            Console.WriteLine("\n" + "k( vector01, vector03 )");
            Console.WriteLine(spk.Calculate(vector01, vector03));

            Console.WriteLine("\n" + "k( vector01, vector04 )");
            Console.WriteLine(spk.Calculate(vector01, vector04));

            Console.WriteLine("\n" + "k( vector01, vector05 )");
            Console.WriteLine(spk.Calculate(vector01, vector05));

            Console.WriteLine("\n" + "k( vector01, vector06 )");
            Console.WriteLine(spk.Calculate(vector01, vector06));


        }


    }

}
