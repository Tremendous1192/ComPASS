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
        /// txtファイルに書き出します。stringを記録する
        /// </summary>
        /// <param name="textFileName"></param>
        /// <param name="writtenText"></param>
        /// <returns></returns>
        public static void WriteText(string textFileName, string writtenText, bool append, string encodingName = "Shift_JIS")
        {
            string path = IOText.CreateFullPath(textFileName);

            //NugetでSystem.Text.Encoding.CodePagesをダウンロードしておく.
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            try
            {
                using (var writer = new StreamWriter(path, append, Encoding.GetEncoding(encodingName)))
                {
                    writer.WriteLine(writtenText);
                }
            }
            catch
            {
                using (var writer = new StreamWriter(path, false, Encoding.GetEncoding(encodingName)))
                {
                    writer.WriteLine(writtenText);
                }
            }

        }


        /// <summary>
        /// txt に書き足す。string[]を記録する
        /// </summary>
        /// <param name="textFileName"></param>
        /// <param name="writtenText"></param>
        /// <returns></returns>
        public static void WriteText(string textFileName, string[] writtenText, bool append, string encodingName = "Shift_JIS")
        {
            string path = IOText.CreateFullPath(textFileName);

            //NugetでSystem.Text.Encoding.CodePagesをダウンロードしておく.
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);


            try
            {
                using (var writer = new StreamWriter(path, append, Encoding.GetEncoding(encodingName)))
                {
                    foreach (string w in writtenText) { writer.WriteLine(w); }
                }
            }
            catch
            {
                using (var writer = new StreamWriter(path, false, Encoding.GetEncoding(encodingName)))
                {
                    foreach (string w in writtenText) { writer.WriteLine(w); }
                }
            }

        }

        /// <summary>
        /// txt に書き足す。List<string>を記録する
        /// </summary>
        /// <param name="textFileName"></param>
        /// <param name="writtenText"></param>
        /// <returns></returns>
        public static void WriteText(string textFileName, List<string> writtenText, bool append, string encodingName = "Shift_JIS")
        {
            string path = IOText.CreateFullPath(textFileName);

            //NugetでSystem.Text.Encoding.CodePagesをダウンロードしておく.
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            try
            {
                using (var writer = new StreamWriter(path, append, Encoding.GetEncoding(encodingName)))
                {
                    foreach (string w in writtenText) { writer.WriteLine(w); }
                }
            }
            catch
            {
                using (var writer = new StreamWriter(path, false, Encoding.GetEncoding(encodingName)))
                {
                    foreach (string w in writtenText) { writer.WriteLine(w); }
                }
            }

        }


        /// <summary>
        /// txt に書き足す。string[ , ]を記録する
        /// </summary>
        /// <param name="textFileName"></param>
        /// <param name="writtenText"></param>
        /// <returns></returns>
        public static void WriteText(string textFileName, string[,] writtenText, bool append, string encodingName = "Shift_JIS")
        {
            string[] combined = IOTypeChange.CreateCommaSeparatedString(writtenText);

            WriteText(textFileName, combined, append, encodingName);
        }


        /// <summary>
        /// txt に書き足す。string[ , ]を記録する
        /// </summary>
        /// <param name="textFileName"></param>
        /// <param name="writtenText"></param>
        /// <returns></returns>
        public static void WriteText(string textFileName, string[][] writtenText, bool append, string encodingName = "Shift_JIS")
        {
            string[] combined = IOTypeChange.CreateCommaSeparatedString(writtenText);

            WriteText(textFileName, combined, append, encodingName);
        }





    }
}