using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.CoMPASS.MathApp;

namespace Test.Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class IRandomNumber
    {

        /// <summary>
        /// 一様分布、正規分布、半正規分布、対数正規分布、コーシー分布のテストを行う。
        /// </summary>
        public void Test_Uniform_Normal_HalfNormal_LogNormal_Cauchy()
        {
            Console.WriteLine("一様分布、正規分布、半正規分布、対数正規分布、コーシー分布を生成する");
            Console.WriteLine("[0,  100]における生成数を確認する" + "\n\n");


            UniformDistribution ud = new UniformDistribution(1);
            uint[] count_ud = new uint[105];

            NormalDistribution nd = new NormalDistribution(1, 2);
            uint[] count_nd = new uint[105];

            HalfNormalDistribution hnd = new HalfNormalDistribution(1, 2);
            uint[] count_hnd = new uint[105];

            LogNormalDistribution lnd = new LogNormalDistribution(1, 2);
            uint[] count_lnd = new uint[105];

            CauchyDistribution cd = new CauchyDistribution(1, 2);
            uint[] count_cd = new uint[105];


            double r = 0.0;
            for (int i = 0; i < 100; i++)
            {
                r =Math.Round( ud.NextDouble(0, 100));
                if (r < 0 || 100 < r) { }
                else 
                {
                    count_ud[(int)r]++;
                }

                r = Math.Round(nd.NextDouble(50.5, 15));
                if (r < 0 || 100 < r) { }
                else
                {
                    count_nd[(int)r]++;
                }

                r = Math.Round(hnd.NextDouble(15));
                if (r < 0 || 100 < r) { }
                else
                {
                    count_hnd[(int)r]++;
                }

                r = Math.Round(lnd.NextDouble(50.5, 15));
                if (r < 0 || 100 < r) { }
                else
                {
                    count_lnd[(int)r]++;
                }

                r = Math.Round(cd.NextDouble(50.5, 15));
                if (r < 0 || 100 < r) { }
                else
                {
                    count_cd[(int)r]++;
                }

            }


            Console.WriteLine("乱数" + "\t" 
                + "一様分布" + "\t" + "正規分布" + "\t"
                + "半正規分布" + "\t" + "対数正規分布" + "\t"
                + "コーシー分布");
            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(i + "\t" 
                    + count_ud[i] + "\t" + count_nd[i] + "\t" 
                    + count_hnd[i] + "\t" + count_lnd[i] + "\t" 
                    + count_cd[i]);
            }


        }

    }
}
