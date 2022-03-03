using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{


    public partial class Statistics<T>
        where T : struct
    {
        /// <summary>
        /// 正規分布表の片側分布を計算して,  
        /// p値から統計量Kpを計算する.
        /// 統計量の有効数字は4桁なので, doubleで返しても良いだろう.
        /// </summary>
        /// <param name="pValue"></param>
        /// <returns></returns>
        public static double TableOfNormalDistribution_1Side_PValuetoKp(double pValue)
        {
            double p = pValue;

            if (p < 0.001)
            {
                throw new FormatException("p値は,0.001以上でないといけません");
            }
            if (p > 0.49)
            {
                throw new FormatException("p値は,0.49以下でないといけません");
            }

            // p値 0.00X (X: 1 - 9)
            if (p < 0.01)
            {
                if (p < 0.002) { return 3.090; }// 0.001
                if (p < 0.003) { return 2.878; }// 0.002
                if (p < 0.004) { return 2.748; }// 0.003
                if (p < 0.005) { return 2.652; }// 0.004
                if (p < 0.006) { return 2.576; }// 0.005

                if (p < 0.007) { return 2.512; }// 0.006
                if (p < 0.008) { return 2.457; }// 0.007
                if (p < 0.009) { return 2.409; }// 0.008
                return 2.366;// 0.009
            }

            p = Math.Round(p * 100) / 100;

            // p値 0.0X (X: 1 - 9)
            if (p < 0.1)
            {
                if (p < 0.02) { return 2.326; }// 0.01
                if (p < 0.03) { return 2.054; }// 0.02
                if (p < 0.04) { return 1.881; }// 0.03
                if (p < 0.05) { return 1.751; }// 0.04
                if (p < 0.06) { return 1.645; }// 0.05

                if (p < 0.07) { return 1.555; }// 0.06
                if (p < 0.08) { return 1.476; }// 0.07
                if (p < 0.09) { return 1.405; }// 0.08
                return 1.341;// 0.09
            }

            // p値 0.1X (X: 0 - 9)
            if (p < 0.2)
            {
                if (p < 0.11) { return 1.282; }// 0.10

                if (p < 0.12) { return 1.227; }// 0.11
                if (p < 0.13) { return 1.175; }// 0.12
                if (p < 0.14) { return 1.126; }// 0.13
                if (p < 0.15) { return 1.080; }// 0.14
                if (p < 0.16) { return 1.036; }// 0.15

                if (p < 0.17) { return 0.994; }// 0.16
                if (p < 0.18) { return 0.954; }// 0.17
                if (p < 0.19) { return 0.915; }// 0.18
                return 0.878;// 0.19
            }

            // p値 0.2X (X: 0 - 9)
            if (p < 0.3)
            {
                if (p < 0.21) { return 0.842; }// 0.20

                if (p < 0.22) { return 0.806; }// 0.21
                if (p < 0.23) { return 0.772; }// 0.22
                if (p < 0.24) { return 0.739; }// 0.23
                if (p < 0.25) { return 0.706; }// 0.24
                if (p < 0.26) { return 0.674; }// 0.25

                if (p < 0.27) { return 0.643; }// 0.26
                if (p < 0.28) { return 0.613; }// 0.27
                if (p < 0.29) { return 0.583; }// 0.28
                return 0.553;// 0.29
            }

            // p値 0.3X (X: 0 - 9)
            if (p < 0.4)
            {
                if (p < 0.31) { return 0.524; }// 0.30

                if (p < 0.32) { return 0.496; }// 0.31
                if (p < 0.33) { return 0.468; }// 0.32
                if (p < 0.34) { return 0.440; }// 0.33
                if (p < 0.35) { return 0.412; }// 0.34
                if (p < 0.36) { return 0.385; }// 0.35

                if (p < 0.37) { return 0.358; }// 0.36
                if (p < 0.38) { return 0.332; }// 0.37
                if (p < 0.39) { return 0.305; }// 0.38
                return 0.279;// 0.39
            }

            // p値 0.4X (X: 0 - 9)
            if (p < 0.41) { return 0.253; }// 0.40

            if (p < 0.42) { return 0.228; }// 0.41
            if (p < 0.43) { return 0.202; }// 0.42
            if (p < 0.44) { return 0.176; }// 0.43
            if (p < 0.45) { return 0.151; }// 0.44
            if (p < 0.46) { return 0.126; }// 0.45

            if (p < 0.47) { return 0.100; }// 0.46
            if (p < 0.48) { return 0.075; }// 0.47
            if (p < 0.49) { return 0.050; }// 0.48
            return 0.025;// 0.49
        }

    }
}
