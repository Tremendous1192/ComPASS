﻿using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.CoMPASS.MathApp;

namespace Test.Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class VectorTest
    {
        /// <summary>
        /// コンストラクターのテストメソッド。
        /// Vector＜double＞を生成して、各要素を確認する。
        /// </summary>
        public void ConstructorDoubleTest()
        {

            //コンストラクターのテスト 1
            int dimension = 5;
            Console.WriteLine(dimension + "次元の零ベクトルを生成します");
            Vector<double> vector_1 = new Vector<double>(dimension);

            for (int i=0;i<vector_1.Dimension;i++) {
                Console.WriteLine(vector_1[i]);            
            }
            //改行
            Console.WriteLine("\n\n");


            //コンストラクターのテスト 2
            Console.WriteLine("次の1次元配列を初期値とするベクトルを生成します");
            double[] copiedArray_1 = new double[3];
            for (int i=0;i<copiedArray_1.Length;i++) {
                copiedArray_1[i] = 1 + i;
                Console.WriteLine(copiedArray_1[i]);
            }

            var vector_2 = new Vector<double>(copiedArray_1);
            Console.WriteLine("\n生成したベクトルの各要素を確認します。");
            for (int i = 0; i < vector_2.Dimension; i++)
            {
                Console.WriteLine(vector_2[i]);
            }
            //改行
            Console.WriteLine("\n\n");


            //コンストラクターのテスト 3
            Console.WriteLine("次のリストを初期値とするベクトルを生成します");
            var copiedList_2 = new List<double>();
            for (int i = 0; i < 4; i++){
                copiedList_2.Add(2 + i);
                Console.WriteLine(copiedList_2[i]);
            }

            var vector_3 = new Vector<double>(copiedList_2);
            Console.WriteLine("\n生成したベクトルの各要素を確認します。");
            for (int i = 0; i < vector_3.Dimension; i++)
            {
                Console.WriteLine(vector_3[i]);
            }


        }

    }
}
