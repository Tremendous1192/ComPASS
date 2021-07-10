using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.IOApp
{
	public static partial class IOTypeChange
	{


		//カンマ区切り文字列を作成する
		public static string CreateCommaSeparatedString<T>(T[] input)
		where T : struct
		{
			string combined = "";
			for (int i = 0; i < input.GetLength(0) - 1; i++)
			{
				combined += input[i].ToString().Replace(',', '.') + ",";
			}
			combined += input[input.GetLength(0) - 1].ToString().Replace(',', '.');
			return combined;
		}


		//カンマ区切り文字列を作成する
		public static string CreateCommaSeparatedString(string[] input)
		{
			string combined = "";
			for (int i = 0; i < input.GetLength(0) - 1; i++)
			{
				combined += input[i] + ",";
			}
			combined += input[input.GetLength(0) - 1];
			return combined;
		}


		//カンマ区切り文字列を作成する
		public static string[] CreateCommaSeparatedString<T>(T[,] input)
	where T : struct
		{
			string[] combined = new string[input.GetLength(0)];
			for (int i = 0; i < input.GetLength(0); i++)
			{
				for (int j = 0; j < input.GetLength(1) - 1; j++)
				{
					combined[i] += input[i, j].ToString().Replace(',', '.') + ",";
				}
				combined[i] += input[i, input.GetLength(1) - 1].ToString().Replace(',', '.');
			}
			return combined;
		}

		//カンマ区切り文字列を作成する
		public static string[] CreateCommaSeparatedString(string[,] input)
		{
			string[] combined = new string[input.GetLength(0)];
			for (int i = 0; i < input.GetLength(0); i++)
			{
				for (int j = 0; j < input.GetLength(1) - 1; j++)
				{
					combined[i] += input[i, j] + ",";
				}
				combined[i] += input[i, input.GetLength(1) - 1];
			}
			return combined;
		}



		//カンマ区切り文字列を作成する
		public static string[] CreateCommaSeparatedString<T>(T[][] input)
		where T : struct
		{
			string[] combined = new string[input.GetLength(0)];
			for (int i = 0; i < input.GetLength(0); i++)
			{
				for (int j = 0; j < input[i].GetLength(0) - 1; j++)
				{
					combined[i] += input[i][j].ToString().Replace(',', '.') + ",";
				}
				combined[i] += (input[i][input[i].GetLength(0) - 1]).ToString().Replace(',', '.');
			}
			return combined;
		}



		//カンマ区切り文字列を作成する
		public static string[] CreateCommaSeparatedString(string[][] input)
		{
			string[] combined = new string[input.GetLength(0)];
			for (int i = 0; i < input.GetLength(0); i++)
			{
				for (int j = 0; j < input[i].GetLength(0) - 1; j++)
				{
					combined[i] += input[i][j] + ",";
				}
				combined[i] += (input[i][input[i].GetLength(0) - 1]);
			}
			return combined;
		}



		//カンマ区切り文字列を作成する
		public static string CreateCommaSeparatedString<T>(List<T> input)
		where T : struct
		{
			string combined = "";
			for (int i = 0; i < input.Count - 1; i++)
			{
				combined += input[i].ToString().Replace(',', '.') + ",";
			}
			combined += input[input.Count - 1].ToString().Replace(',', '.');
			return combined;
		}


		//カンマ区切り文字列を作成する
		public static string CreateCommaSeparatedString(List<string> input)
		{
			string combined = "";
			for (int i = 0; i < input.Count - 1; i++)
			{
				combined += input[i] + ",";
			}
			combined += input[input.Count - 1];
			return combined;
		}


	}
}