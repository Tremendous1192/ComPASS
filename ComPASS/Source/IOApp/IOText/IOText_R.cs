using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Reflection;

namespace Tremendous1192.SelfEmployed.CoMPASS.IOApp
{
    public static partial class IOText
    {

        /// <summary>
        /// txtデータを読み込む。string[]を読み込む。
        /// </summary>
        /// <param name="textFileName"></param>
        /// <returns></returns>
        public static string[] ReadText(string textFileName, string encodingName = "Shift_JIS")
        {
            string path = IOText.CreateFullPath(textFileName);

            //.Net Coreでtxtを使用するのに必要。
            //NugetでSystem.Text.Encoding.CodePagesをダウンロードしておく.
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            List<string> temp = new List<string>();
            if (File.Exists(path))
            {
                using (var reader = new StreamReader(path, Encoding.GetEncoding(encodingName)))
                {
                    while (!reader.EndOfStream)
                    {
                        temp.Add(reader.ReadLine());
                    }
                    reader.Dispose();
                }
            }
            else
            {
                throw new FormatException("404 File Not Found : " + nameof(textFileName));
            }

            int blank = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[temp.Count - 1 - i] != "")
                {
                    break;
                }
                blank++;
            }
            for (int i = 0; i < blank; i++)
            {
                temp.RemoveAt(temp.Count - 1);
            }
            return temp.ToArray();
        }


        /// <summary>
        /// txtデータを読み込む。string[,]を読み込む。
        /// カンマ , 区切りでデータを取り出す。
        /// </summary>
        /// <param name="textFileName"></param>
        /// <returns></returns>
        public static string[,] ReadTextSplitedByComma2DimArray(string textFileName, string encodingName = "Shift_JIS")
        {
            string[] read = ReadText(textFileName, encodingName);


            int maxColumn = 1;
            for (int j = 0; j < read.Length; j++)
            {
                maxColumn = Math.Max(maxColumn, read[j].Split(',').Length);
            }

            string[,] result = new string[read.Length, maxColumn];
            for (int j = 0; j < read.Length; j++)
            {
                string[] row = read[j].Split(',');
                for (int k = 0; k < row.Length; k++)
                {
                    result[j, k] = row[k];
                }
            }
            return result;
        }


	public static string[][] ReadTextSplitedByCommaJagArray(string textFileName, string encodingName = "Shift_JIS")
        {
            string[] read = ReadText(textFileName, encodingName);


            int maxColumn = 1;
            for (int j = 0; j < read.Length; j++)
            {
                maxColumn = Math.Max(maxColumn, read[j].Split(',').Length);
            }

            string[][] result = new string[read.Length][];
            for (int i = 0; i < read.Length; i++)
            {
		result[i]=read[i].Split(',');
            }
            return result;
        }



    }
}