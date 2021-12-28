using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.CoMPASS.MathApp;

namespace Test.Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class IKernelTest
    {


        public void GaussianKernelTest()
        {
            Console.WriteLine("カーネル関数のテスト関数");

            Console.WriteLine("\n" + "Simple Polynomial Kernel ( 1 + x・y )^2");
            Console.WriteLine("ベクトルの内積が-1のとき最小値0をとるカーネル関数");
            Console.WriteLine("また、2つのベクトルが直行しているときは、カーネル関数の値は1になる。");
            GaussianKernel<double> gk = new GaussianKernel<double>();

            Console.WriteLine("\n" + "下記のベクトルで計算する。");
            Vector<double> vector01 = new Vector<double>(2);
            vector01[0] = 1; vector01[1] = 0;
            Console.WriteLine("vector 01" + "\n" + vector01[0] + "\t" + vector01[1]);

            Vector<double> vector02 = new Vector<double>(2);
            vector02[0] = 1; vector02[1] = 0;
            Console.WriteLine("\n" + "vector 02" + "\n" + vector02[0] + "\t" + vector02[1]);

            Vector<double> vector03 = new Vector<double>(2);
            vector03[0] = 0; vector03[1] = 1;
            Console.WriteLine("\n" + "vector 03" + "\n" + vector03[0] + "\t" + vector03[1]);

            Vector<double> vector04 = new Vector<double>(2);
            vector04[0] = 0; vector04[1] = 5;
            Console.WriteLine("\n" + "vector 04" + "\n" + vector04[0] + "\t" + vector04[1]);

            Vector<double> vector05 = new Vector<double>(2);
            vector05[0] = -1; vector05[1] = 0;
            Console.WriteLine("\n" + "vector 05" + "\n" + vector05[0] + "\t" + vector05[1]);

            Vector<double> vector06 = new Vector<double>(2);
            vector06[0] = -5; vector06[1] = 0;
            Console.WriteLine("\n" + "vector 06" + "\n" + vector06[0] + "\t" + vector06[1]);


            Matrix<double> designMatrix = new Matrix<double>(6,2);
            designMatrix[0, 0] = vector01[0]; designMatrix[0, 1] = vector01[1];
            designMatrix[1, 0] = vector02[0]; designMatrix[1, 1] = vector02[1];
            designMatrix[2, 0] = vector03[0]; designMatrix[2, 1] = vector03[1];
            designMatrix[3, 0] = vector04[0]; designMatrix[3, 1] = vector04[1];
            designMatrix[4, 0] = vector05[0]; designMatrix[4, 1] = vector05[1];

            designMatrix[5, 0] = vector06[0]; designMatrix[5, 1] = vector06[1];

            gk.SetDesignMatrix(designMatrix);


            Console.WriteLine("\n" + "カーネル関数の計算結果。");
            Console.WriteLine("k( vector01, vector02 )");
            Console.WriteLine(gk.Calculate(vector01, vector02));

            Console.WriteLine("\n" + "k( vector01, vector03 )");
            Console.WriteLine(gk.Calculate(vector01, vector03));

            Console.WriteLine("\n" + "k( vector01, vector04 )");
            Console.WriteLine(gk.Calculate(vector01, vector04));

            Console.WriteLine("\n" + "k( vector01, vector05 )");
            Console.WriteLine(gk.Calculate(vector01, vector05));

            Console.WriteLine("\n" + "k( vector01, vector06 )");
            Console.WriteLine(gk.Calculate(vector01, vector06));


        }


    }
}
