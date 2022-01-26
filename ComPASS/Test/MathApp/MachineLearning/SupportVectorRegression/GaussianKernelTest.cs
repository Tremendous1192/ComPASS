using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.CoMPASS.MathApp;

namespace Test.Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class SupportVectorRegressionTest
    {

        public void GaussianKernelTest()
        {

            Matrix<double> designMatrix = new Matrix<double>(6, 2);
            ColumnVector<double> labelsY = new ColumnVector<double>(6);

            //データ点の配置(x-y平面を想像してください)
            // 1 -1 1
            // 1 -1 1
            int num = 0;
            designMatrix[num, 0] = 0; designMatrix[num, 1] = 0;
            labelsY[num] = 1;

            num = 1;
            designMatrix[num, 0] = 1; designMatrix[num, 1] = 0;
            labelsY[num] = -1;

            num = 2;
            designMatrix[num, 0] = 2; designMatrix[num, 1] = 0;
            labelsY[num] = 1;

            num = 3;
            designMatrix[num, 0] = 0; designMatrix[num, 1] = 1;
            labelsY[num] = 1;

            num = 4;
            designMatrix[num, 0] = 1; designMatrix[num, 1] = 1;
            labelsY[num] = -1;

            num = 5;
            designMatrix[num, 0] = 2; designMatrix[num, 1] = 1;
            labelsY[num] = 1;

            GaussianKernel<double> iKernel = new GaussianKernel<double>();

            var coefficientsA = SupportVectorRegression<double>.Learn(labelsY, designMatrix, iKernel, 0.01);


            Console.WriteLine("計画行列x1" + "\t" + "計画行列x2" + "\t" + "目的関数" + "\t" + "予測値");
            double[] results = new double[designMatrix.RowCount];
            for (int i = 0; i < results.Length; i++)
            {
                results[i] = SupportVectorRegression<double>.Regression(designMatrix, iKernel, coefficientsA, designMatrix.PickUpRowVector(i));

                Console.WriteLine(designMatrix[i, 0] + "\t\t" + designMatrix[i, 1] + "\t\t" + labelsY[i] + "\t\t" + results[i].ToString("G5"));
            }





        }



    }
}
