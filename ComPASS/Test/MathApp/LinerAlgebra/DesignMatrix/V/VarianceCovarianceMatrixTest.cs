using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.CoMPASS.MathApp;

namespace Test.Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class DesignMatrixTest
    {
        /// <summary>
        /// 分散共分散のテスト関数
        /// </summary>
        public void VarianceCovarianceMatrixTest()
        {
            Console.WriteLine("分散共分散のテスト関数");

            Console.WriteLine("例題");
            Console.WriteLine("引用 - 分散共分散行列の定義と性質 | 高校数学の美しい物語");

            Console.WriteLine("\n計画行列の各成分");
            Matrix<double> designMatrix = new Matrix<double>(3, 2);
            designMatrix[0, 0] = 40; designMatrix[0, 1] = 80;
            designMatrix[1, 0] = 80; designMatrix[1, 1] = 90;
            designMatrix[2, 0] = 90; designMatrix[2, 1] = 100;
            for (int i=0;i<designMatrix.RowCount;i++) {
                for (int j=0;j<designMatrix.ColumnCount;j++) {
                    Console.Write(designMatrix[i, j] + "\t");
                }
                Console.WriteLine("");
            }


            Console.WriteLine("\n計画行列の分散共分散行列");
            Matrix<double> varianceCovarianceMatrix = DesignMatrix<double>.VarianceCovarianceMatrix(designMatrix);
            for (int i = 0; i < varianceCovarianceMatrix.RowCount; i++)
            {
                for (int j = 0; j < varianceCovarianceMatrix.ColumnCount; j++)
                {
                    Console.Write(varianceCovarianceMatrix[i, j] + "\t");
                }
                Console.WriteLine("");
            }


            Console.WriteLine("\n例題の回答(小数に直している)");
            Console.WriteLine(1400.0 / 3 + "\t" + 500.0 / 3 + "\n" + 500.0 / 3 + "\t" + 200.0 / 3);

        }

    }
}
