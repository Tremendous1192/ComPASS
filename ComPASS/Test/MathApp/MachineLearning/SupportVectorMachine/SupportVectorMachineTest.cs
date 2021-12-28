using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.CoMPASS.MathApp;

namespace Test.Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class SupportVectorMachineTest
    {
        public void SimplePolynomialKernelTest()
        {

            Matrix<double> designMatrix = new Matrix<double>(6, 2);
            Vector<double> labelsY = new Vector<double>(6);

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

            SimplePolynomialKernel<double> iKernel = new SimplePolynomialKernel<double>();

            var coefficientsA = SupportVectorMachine<double>.Learn(labelsY, designMatrix, iKernel, -1);


            double[] results = new double[designMatrix.RowCount];
            for (int i=0;i<results.Length;i++) 
            {
                results[i] = SupportVectorMachine<double>.Classify(labelsY, designMatrix, iKernel, coefficientsA, designMatrix.PickUpRowVector(i));

                Console.WriteLine(designMatrix[i, 0] + " " + designMatrix[i, 1] + " " + labelsY[i] + " " + results[i]);
            }





        }

    }
}
