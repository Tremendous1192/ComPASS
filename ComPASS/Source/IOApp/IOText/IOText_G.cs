using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.IOApp
{
    public static partial class IOText
    {


        /// <summary>
        /// 現在のDirectoryにあるtxtデータのファイル名を全て取得する
        /// </summary>
        /// <returns></returns>
        public static string[] GetFileNameOfTextType()
        {
            string[] files = System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory());
            if (files.Length < 1) { Console.WriteLine("No file is here ."); return new string[1]; }

            List<string> temp_List = new List<string>();
            for (int i = 0; i < files.GetLength(0); i++)
            {
                if (Path.GetExtension(files[i]) == ".txt")
                {
                    temp_List.Add(Path.GetFileNameWithoutExtension(files[i]) + Path.GetExtension(files[i]));
                }
            }

            if (temp_List.Count < 1) { Console.WriteLine("No .txt file is here ."); return new string[1]; }

            return temp_List.ToArray();
        }



    }
}