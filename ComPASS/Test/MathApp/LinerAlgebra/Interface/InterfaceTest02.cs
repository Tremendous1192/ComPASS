using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.CoMPASS.MathApp;

namespace Test.Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class InterfaceTest
    {


        public void Study02()
        {
            TestInterfaceClass<double> tifc = new TestInterfaceClass<double>();
            var result = tifc.ConstructionTest01(10, 10);
            for (int i=0;i<result.RowCount;i++) {
                for (int j=0;j<result.ColumnCount;j++) {
                    Console.Write(result[i, j] + "\t");
                }
                Console.WriteLine();
            }


        }
    }

    /// <summary>
    /// interfaceのテストinterface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface iInterfaceTest<T>
        where T : struct
    {
        Matrix<T> ConstructionTest01(int row, int column);

        Matrix<T> ConstructionTest02(Matrix<T> input);

    }

    /// <summary>
    /// interfaceのテストclass
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TestInterfaceClass<T> : iInterfaceTest<T>
                where T : struct
    {
        public Matrix<T> ConstructionTest01(int row, int column) {

            Matrix<T> matrix01 = new Matrix<T>(row, column);
            for (int i=0;i<row;i++) {
                for (int j=0;j<column;j++) {
                    matrix01[i, j] = (dynamic)i + j;
                }
            }

            return matrix01;
        }

        public Matrix<T> ConstructionTest02(Matrix<T> input)
        {
            return input;
        }

    }


}
