using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.IOApp
{
    public static partial class IOText
    {


        /// <summary>
        /// ê‚ëŒÉpÉXÇçÏê¨Ç∑ÇÈ
        /// </summary>
        /// <param name="pathOrFileName"></param>
        /// <returns></returns>
        public static string CreateFullPath(string pathOrFileName){
            string result = pathOrFileName;
            if (System.IO.Path.GetExtension(pathOrFileName) == ".txt"){ }
            else{
                result += ".txt";
            }
            if (pathOrFileName.Contains("\\")){ }
            else{
                result = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), result);
            }
            return result;
        }


    }
}