using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.IOApp
{
    public partial class IOTextTest
    {

        /// <summary>
        /// 1次元配列 double[3] をカンマ区切りstringに変換して保存して、その後読み込む.
        /// </summary>
        public static void TestReadTextSplitedByCommaJagArray(double dummyVariable)
        {

            double[] array_1 = new double[3];
            array_1[0] = 1.1;
            array_1[1] = 3;
            array_1[2] = -2.34;
            string ccs = IOTypeChange.CreateCommaSeparatedString(array_1);
            Console.WriteLine(ccs);

            IOText.WriteText("testConsoleApp2", ccs, false);

            string[][] readArray = IOText.ReadTextSplitedByCommaJagArray("testConsoleApp2");
            foreach (var r in readArray)
            {
                foreach (var a in r) { Console.Write(a + "\t"); }
                Console.WriteLine("");
            }
        }

    }
}
